module ProjectEuler

let sumOfMultiplesOf3And5 n =
    [1 .. n-1]
    |> List.filter (fun x -> x % 3 = 0 || x % 5 = 0)
    |> List.sum
    
let fibonacci =
    Seq.unfold (fun (a, b) -> Some(a, (b, a + b))) (1, 2)

let fibonacciUpTo maxFibValue =
    fibonacci
    |> Seq.takeWhile (fun x -> x <= maxFibValue)
    |> Seq.toList

let sumOfEvenFibonacciNumbers maxFibValue =
    fibonacciUpTo maxFibValue
    |> List.filter (fun x -> x % 2 = 0)
    |> List.sum

let primeFactors (n: int64) : int64 list =
    let rec factor (n: int64) (div: int64) res =
        match n with
        | _ when n < 2 -> res |> List.rev
        | _ when n % div = 0 -> factor (n / div) div (div :: res)
        | _ -> factor n (div + 1L) res

    factor n 2 []

let largestPrimeFactor n =
    primeFactors n
    |> List.max

let isPalindrome n =
    let str = (string n)
    let rev = Seq.rev str |> Seq.map string |> String.concat ""
    str = rev

let getPalindromesFromMultiples xs =
    List.allPairs xs xs
    |> List.map (fun (x, y) -> x * y)
    |> List.filter isPalindrome
    |> List.distinct

let getLargestPalindromeFromMultiples xs =
    getPalindromesFromMultiples xs
    |> List.max

let rec greatestCommonDivisor a b =
    if b = 0L then a
    else greatestCommonDivisor b (a % b)

let leastCommonMultiple numbers =
    let rec lcm a tail =
        match tail with
        | [] -> a
        | [b] -> a * b / greatestCommonDivisor a b
        | b::t -> lcm (a * b / greatestCommonDivisor a b) t

    match numbers with
    | [] -> 0L
    | a::tail -> lcm a tail

let square x = x * x

let sumOfSquares numbers =
    numbers |> List.map square |> List.sum

let squareOfSum (numbers: int list) =
    numbers |> List.sum |> square

let isPrime n =
    let rec checkPrime n div =
        match n with
        | _ when n < 2 -> false
        | _ when n <= 3 -> true
        | _ when n % 2 = 0 || n % 3 = 0 -> false
        | _ when n < (div * div) -> true
        | _ when n % div = 0 -> false
        | _ -> checkPrime n (div + 2)

    checkPrime n 5

let generatePrimes () =
    Seq.initInfinite (fun x -> x + 1)
    |> Seq.filter isPrime

let splitIntoSubstrings size str =
    let rec split size (str: string) acc =
        if str.Length < size then acc
        else split size (str[1..]) (str[0..size - 1] :: acc)

    split size str [] |> List.rev

let splitDigits (str: string) =
    str |> Seq.map (fun c -> int64 (string c)) |> Seq.toList

let largestProduct (numbers: int64 list list): int64 =
    let listProduct l = l |> List.fold (*) 1L
    match numbers with
    | [] -> 0
    | n -> n
         |> List.map listProduct
         |> List.max

let threeSumCombinations n =
    seq {
        for b in [2..n/2 - 1] do
            for a in [1..b - 1] do
                let c = n - a - b
                if c > b then
                    yield [a; b; c]
    } |> Seq.toList

let primesUpTo n =
    match n with
    | _ when n < 2L -> []
    | _ ->
        let isPrime = Array.create (int n + 1) true
        isPrime[0] <- false
        isPrime[1] <- false
        let limit = int (sqrt (float n))
        for i in 2 .. limit do
            if isPrime[i] then
                for j in i * i .. i .. int n do
                    isPrime[j] <- false

        [for i in 2 .. int n do if isPrime[i] then yield int64 i]

let getStraightAdjacentNumbers (grid: int list list) =
    let getDiagonals (g: int list list) =
        let size = List.length g
        [[for i in 0 .. size - 1 do yield g[i][i]]
         [for i in 0 .. size - 1 do yield g[i][size - 1 - i]]]

    let rows = grid
    let columns = List.transpose grid
    let diagonals = getDiagonals grid
    List.concat [rows; columns; diagonals]

let splitWithWindow window (matrix: int list list) =
    let width = List.length matrix
    let height = if width = 0 then 0 else List.length matrix[0]
    if width < window then []
    else [
          for jOffset in 0 .. height - window do
              for iOffset in 0 .. width - window do
                [for i in iOffset .. window + iOffset- 1 do
                     [for j in jOffset .. window + jOffset - 1 do yield matrix[i][j]]]
          ]

let triangularNumbers () =
    Seq.unfold
        (fun (current, n) ->
            let nextValue = current + n
            Some(nextValue, (nextValue, n + 1)))
        (0, 1)

let getDivisors n =
    let upperBound = int (sqrt (float n))
    [1..upperBound]
    |> List.collect (fun d ->
        if n % d = 0 then
            if d = n / d then [d]
            else [d; n / d]
        else []
    )
    |> List.sort

let roundTo10Digits (n: System.Numerics.BigInteger) =
    let nLength = n |> string |> String.length
    if nLength < 10 then n
    else 
        let x = nLength |> (+) -10 |> double
        let rounded = double n / (double 10 ** x) |> round |> int64
        rounded |> string |> Seq.take 10 |> Seq.map string |> String.concat "" |> System.Numerics.BigInteger.Parse

let (|Even|Odd|) n =
    match n with
    | _ when n % 2 = 0 -> Even
    | _ -> Odd

let nextCollatz n =
    match n with
    | Even -> n / 2
    | Odd -> 3 * n + 1

let collatzSequence n =
    let rec loop n acc =
        match n with
        | 1 -> acc
        | _ ->
            let next = nextCollatz n
            loop next (next :: acc)

    loop n [n] |> List.rev

let collatzSequences (n: int64) =
    let rec updateMemory (mem: Map<int64, int64 list>) (acc: int64 list) =
        match acc with
        | [head] -> mem.Add (head, acc)
        | head::tail when not (mem.ContainsKey head) -> updateMemory (mem.Add (head, acc)) tail
        | _ -> mem

    let rec loop n cur acc (mem: Map<int64, int64 list>) =
        match cur with
        | 1L -> updateMemory mem (acc |> List.rev)
        | _ when mem.ContainsKey cur ->
            updateMemory mem (List.concat [acc |> List.skip 1 |> List.rev; mem[cur]])
        | _ -> 
            let next = if cur % 2L = 0L then cur / 2L else 3L * cur + 1L
            loop n next (next :: acc) mem
    
    let rec buildSequences i mem =
        if i > n then mem
        else
            let mem = loop i i [i] mem
            buildSequences (i + 1L) mem
    
    buildSequences 1L Map.empty

let rec factorial n =
    match n with
    | 0 | 1 -> 1
    | _ -> n * factorial (n - 1)

let latticePaths x =
    if x = 1 then 2 else 6
