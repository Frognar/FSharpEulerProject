﻿module ProjectEuler

open System.Collections.Generic
open System.Numerics

let isDivisibleByAny xs n =
    List.exists (fun x -> n % x = 0) xs

let sumOfMultiplesOf3And5 n =
    [1 .. n - 1]
    |> List.filter (isDivisibleByAny [3; 5])
    |> List.sum
    
let fibonacci =
    Seq.unfold (fun (a, b) -> Some(a, (b, a + b))) (1, 1)
    
let bigFibonacci =
    Seq.unfold (fun (a, b) -> Some(a, (b, a + b))) (1I, 1I)
    
let numbersUpTo threshold sequence =
    sequence
    |> Seq.takeWhile (fun x -> x <= threshold)
    |> Seq.toList

let fibonacciUpTo maxFibValue =
    fibonacci
    |> numbersUpTo maxFibValue

let sumOfFilteredNumbers filter numbers : int =
    numbers
    |> List.filter filter
    |> List.sum

let isEven n = n % 2 = 0

let sumOfEvenNumbers numbers =
    numbers
    |> sumOfFilteredNumbers isEven

let sumOfEvenFibonacciNumbers maxFibValue =
    fibonacciUpTo maxFibValue
    |> sumOfEvenNumbers

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

let rec greatestCommonDivisor<'a when 'a :> INumber<'a> and 'a: comparison> (a: 'a) (b: 'a) : 'a =
    if b = 'a.Zero then a
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

let roundTo10Digits (n: BigInteger) =
    let nLength = n |> string |> String.length
    if nLength < 10 then n
    else 
        let x = nLength |> (+) -10 |> double
        let rounded = double n / (double 10 ** x) |> round |> int64
        rounded |> string |> Seq.take 10 |> Seq.map string |> String.concat "" |> BigInteger.Parse

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

let factorial<'a when 'a :> INumber<'a> and 'a: comparison> (n: 'a) : 'a =
    if n <= 'a.One then 'a.One
    else ['a.One..n] |> Seq.reduce (*)

let latticePaths (x: BigInteger) =
    (factorial (2I * x)) / ((factorial x) * (factorial x))

let digitSum n =
    n |> string |> Seq.map (fun x -> int (string x)) |> Seq.sum

let powerDigitSum (n: int) p =
    let rec pow x p : BigInteger =
        match p with
        | 0 -> 1I
        | 1 -> x
        | _ -> pow (x * (n |> BigInteger)) (p - 1)

    let res = pow (n |> BigInteger) p
    res |> digitSum

let read (n: int) =
    let readUnit n =
        match n with
        | 1 -> "one"
        | 2 -> "two"
        | 3 -> "three"
        | 4 -> "four"
        | 5 -> "five"
        | 6 -> "six"
        | 7 -> "seven"
        | 8 -> "eight"
        | 9 -> "nine"
        | _ -> ""

    let read1_19 n =
        match n with
        | x when x < 10 -> readUnit x
        | 10 -> "ten"
        | 11 -> "eleven"
        | 12 -> "twelve"
        | 13 -> "thirteen"
        | 14 -> "fourteen"
        | 15 -> "fifteen"
        | 16 -> "sixteen"
        | 17 -> "seventeen"
        | 18 -> "eighteen"
        | 19 -> "nineteen"
        | _ -> ""

    let readTens n =
        match n with
        | 2 -> "twenty"
        | 3 -> "thirty"
        | 4 -> "forty"
        | 5 -> "fifty"
        | 6 -> "sixty"
        | 7 -> "seventy"
        | 8 -> "eighty"
        | 9 -> "ninety"
        | _ -> ""

    let read20_99 n =
        match n % 10 with
        | 0 -> readTens (n / 10)
        | x -> readTens (n / 10) + "-" + readUnit x

    let read1_99 n =
        match n with
        | x when x < 20 -> read1_19 x
        | x -> read20_99 x

    let read100_999 n =
        match n % 100 with
        | 0 -> readUnit (n / 100) + " hundred"
        | x -> readUnit (n / 100) + " hundred and " + read1_99 x
    
    match n with
    | x when x < 100 -> read1_99 x
    | x when x < 1000 -> read100_999 x
    | _ -> "one thousand"

let maximumTotal (triangle: int list list) =
    match triangle |> List.rev with
    | [] -> 0
    | [x] -> x[0]
    | head::tail ->
        let rec progress tr (btm: int list) =
            match tr with
            | [] -> btm[0]
            | h::t -> progress t (h
                                  |> List.indexed
                                  |> List.map (fun (i, x) -> x + if btm[i] >= btm[i + 1] then btm[i] else btm[i + 1]))
        progress tail head

let isLeapYear year =
    year % 4 = 0 && (year % 100 <> 0 || year % 400 = 0)

type Day = Monday | Tuesday | Wednesday | Thursday | Friday | Saturday | Sunday
let nextDay startDay daysInMonth =
    match startDay with
    | Monday -> List.item (daysInMonth % 4) [Monday; Tuesday; Wednesday; Thursday]
    | Tuesday -> List.item (daysInMonth % 4) [Tuesday; Wednesday; Thursday; Friday]
    | Wednesday -> List.item (daysInMonth % 4) [Wednesday; Thursday; Friday; Saturday]
    | Thursday -> List.item (daysInMonth % 4) [Thursday; Friday; Saturday; Sunday]
    | Friday -> List.item (daysInMonth % 4) [Friday; Saturday; Sunday; Monday]
    | Saturday -> List.item (daysInMonth % 4) [Saturday; Sunday; Monday; Tuesday]
    | Sunday -> List.item (daysInMonth % 4) [Sunday; Monday; Tuesday; Wednesday]

let countingSundays startYear endYear =
    let daysPerMonth = [31; 28; 31; 30; 31; 30; 31; 31; 30; 31; 30; 31]
    let rec loop year month day count =
        if year = endYear then count
        else
            let daysInMonth = if month = 2 && not (isLeapYear year) then daysPerMonth[month - 1] else 29
            let nextDay = nextDay day daysInMonth
            let newCount = if nextDay = Sunday then (count + 1) else count
            match month with
            | 12 -> loop (year + 1) 1 nextDay newCount
            | _ -> loop year (month + 1) nextDay newCount
    loop startYear 1 Wednesday 0

let properDivisorsOf n =
    let divisors = getDivisors n
    divisors[0..divisors.Length - 2]

let sumOfProperDivisorsOf n =
    properDivisorsOf n
    |> List.sum

let isAmicable n =
    let x = sumOfProperDivisorsOf n
    sumOfProperDivisorsOf x = n  && x <> n

let wordScore (name: string) =
    let charScore c = int c - int 'A' + 1
    name
    |> Seq.map charScore
    |> Seq.sum

let isAbundant n =
    sumOfProperDivisorsOf n > n

let canBeWrittenAsSumOf2NumbersFrom numbers n =
    numbers
    |> List.filter (fun a ->
        let b = n - a
        (b, numbers) ||> List.contains)
    |> List.isEmpty
    |> not

let abundantNumbersUpTo limit =
    [1..limit] |> List.filter isAbundant
    
let limitedSumsOfTwo numbers limit =
    let sumSet = HashSet<int>()
    for x in numbers do
        for y in numbers do
            let sum = x + y
            if sum <= limit then
                sumSet.Add(sum) |> ignore

    sumSet

let lexicographicPermutation nth digits =
    let rec findPermutation n remainingDigits acc =
        match remainingDigits with
        | [] -> acc |> List.rev
        | _ ->
            let count = factorial (List.length remainingDigits - 1)
            let index = n / count
            let selectedDigit = List.item index remainingDigits
            let newDigits = List.filter ((<>) selectedDigit) remainingDigits
            findPermutation (n % count) newDigits (selectedDigit :: acc)

    findPermutation (nth - 1) digits []

let digitCount n =
    n |> string |> String.length

let indexOfFirstTermWithDigits digitCountThreshold =
    (bigFibonacci |> Seq.findIndex (fun x -> digitCount x >= digitCountThreshold)) + 1

let getRemainderCycle n d =
    let rec loop a acc =
        let reminder = a % d
        if reminder = 0 then 0::acc
        else if acc |> List.contains reminder then (reminder::acc) 
        else loop (reminder * 10) (reminder::acc)

    loop n [] |> List.rev

let getRemainderCycleLength n d =
    let reminders = getRemainderCycle n d
    let last = List.last reminders
    match last with
    | 0 -> 0
    | _ ->
        let firstIndex = reminders |> List.findIndex ((=) last)
        reminders.Length - (firstIndex + 1)

let longestReciprocalCycle threshold =
    [1..threshold]
    |> List.map (getRemainderCycleLength 1)
    |> List.indexed
    |> List.maxBy snd
    |> fst
    |> ((+) 1)

let evaluateQuadratic a b x =
    square x + a * x + b

let countConsecutiveBy formula predicate seq =
    seq
    |> Seq.map formula
    |> Seq.takeWhile predicate
    |> Seq.length

let countConsecutivePrimes a b =
    countConsecutiveBy (evaluateQuadratic a b) isPrime (Seq.initInfinite id)

let sumOfNumberSpiralCorners n =
    match n with
    | 1 -> 1
    | x -> 4 * x * x - 6 * x + 6 

let sumOfNumberSpiralDiagonals n =
    [1..n]
    |> List.filter (fun x -> x % 2 = 1)
    |> List.map sumOfNumberSpiralCorners
    |> List.sum

let powerCombinations (range: int list) =
    (range, range)
    ||> List.allPairs
    |> List.map BigInteger.Pow

let countDistinctTerms terms =
    terms
    |> List.distinct
    |> List.length

let countDistinctPowerCombinations range =
    range
    |> powerCombinations
    |> countDistinctTerms

let fifthPower n =
    n * n * n * n * n

let digitFifthPowersSum n =
    n
    |> string
    |> Seq.map (string >> int >> fifthPower)
    |> Seq.sum

let isFifthPowerSum n =
    n = digitFifthPowersSum n

let maxSearchLimit (power: int) =
    let rec findLimit n =
        if n * (pown 9 power) < pown 10 (n - 1) then (n - 1) * (pown 9 power)
        else findLimit (n + 1)
    findLimit 1

let rec findCombinations target numbers =
    match target, numbers with
    | 0, _ -> [[]]
    | _, [] -> []
    | _, n :: rest ->
        let withCurrent =
            if target >= n then
                findCombinations (target - n) numbers
                |> List.map (fun combination -> n :: combination)
            else []
        let withoutCurrent = findCombinations target rest
        withCurrent @ withoutCurrent

let isPandigital n digits =
    digits
    |> Seq.sort
    |> Seq.map string
    |> String.concat "" = ([1..n] |> List.map string |> String.concat "")

let permutationsOf n =
    let rec permutations list =
        match list with
        | [] -> [[]]
        | xs -> [for x in xs do
                     for perm in permutations (List.filter ((<>) x) xs) -> x :: perm]

    permutations (n |> Seq.map string |> Seq.toList)

let makeGroups n list =
    let rec splitIntoParts parts remaining count =
        match count, remaining with
        | 0, [] -> [List.rev parts]
        | 0, _ -> []
        | _, [] -> []
        | _ ->
            [1..List.length remaining]
            |> List.collect (fun len ->
                let part = List.take len remaining
                let rest = List.skip len remaining
                splitIntoParts (String.concat "" part :: parts) rest (count - 1))
    splitIntoParts [] list n

let canBeWrittenAsProduct ((multiplicand, multiplier, product): string * string * string) =
    (int multiplicand) * (int multiplier) = (int product)

let findPossibleFractions (numbers : int list) =
    (numbers, numbers) ||> List.allPairs

let filterFractionsSmallerThanOne (fractions: (int * int) list) =
    fractions |> List.filter (fun (x, y) -> x < y)

let filterFractionsWithCommonDigit (fractions: (int * int) list) =
    fractions |> List.filter (fun (x, y) -> (string x) |> Seq.exists (string y).Contains)

let filterNonTrivialFractions (fractions: (int * int) list) =
    fractions |> List.filter (fun (x, y) -> not (x % 10 = 0 && y % 10 = 0))

let canBeSimplifiedByRemovingCommonDigit (numerator, denominator) =
    let numStr, denomStr = string numerator, string denominator
    match numStr |> Seq.tryFind denomStr.Contains with
    | Some commonDigit ->
        let newNum = numStr.Remove(numStr.IndexOf(commonDigit), 1)
        let newDenom = denomStr.Remove(denomStr.IndexOf(commonDigit), 1)
        (float newNum) / (float newDenom) = (float numerator) / (float denominator)
    | None -> false

let findNonTrivialFractions numbers =
    numbers
    |> findPossibleFractions
    |> filterFractionsSmallerThanOne
    |> filterFractionsWithCommonDigit
    |> filterNonTrivialFractions
    |> List.filter canBeSimplifiedByRemovingCommonDigit

let calculateProduct (fractions: (int * int) list) =
    fractions
    |> List.fold (fun x (c, d) -> (fst x * c, snd x * d)) (1, 1)

let simplifyFraction (numerator, denominator) =
    let gcd = greatestCommonDivisor numerator denominator
    (numerator / gcd, denominator / gcd)

let isFactorialOfItsDigitSum n =
    let digitFactorialSum = n
                            |> string
                            |> Seq.map (fun x -> [1..(x |> string |> int)] |> List.fold (*) 1)
                            |> Seq.sum

    n = digitFactorialSum

let rotate n =
    let nstr = string n
    let rec loop x i acc =
        match i with
        | _ when i = nstr.Length -> acc
        | _ ->
            let next = Seq.append (Seq.tail x) (Seq.singleton (Seq.head x)) |> Seq.map string |> String.concat ""
            loop next (i + 1) (next :: acc)

    loop nstr 1 [] |> Seq.map int |> Seq.rev

let toBase2 (n: int) =
    System.Convert.ToString(n, 2)

let isDoubleBasePalindrome n =
    isPalindrome n && isPalindrome (toBase2 n)

let sumOfDoubleBasePalindromes numbers =
    numbers |> sumOfFilteredNumbers isDoubleBasePalindrome

let leftTruncates n =
    let nStr = n |> string
    nStr
    |> Seq.indexed
    |> Seq.map (fun (i, _) -> nStr.Substring(i + 1))
    |> Seq.map int
    |> Seq.take (nStr.Length - 1)
    |> Seq.toList

let rightTruncates n =
    let nStr = n |> string
    nStr
    |> Seq.indexed
    |> Seq.map (fun (i, _) -> nStr.Remove(nStr.Length - i - 1))
    |> Seq.map int
    |> Seq.take (nStr.Length - 1)
    |> Seq.toList

let truncates n =
    leftTruncates n @ rightTruncates n

let isTruncatablePrime n =
    let nIsPrime = isPrime n
    nIsPrime && truncates n |> List.forall isPrime

let truncatablePrimes () =
    Seq.initInfinite (fun i -> i + 10)
    |> Seq.filter isTruncatablePrime
    |> Seq.take 11
    |> Seq.toList

let sumOfTruncatablePrimes () =
    truncatablePrimes ()
    |> List.sum
    

let isPandigital1to9 n =
    isPandigital 9 n

let concatenatedProduct n multipliers =
    multipliers
    |> List.map (fun x -> x * n)
    |> List.map string
    |> String.concat ""

let findLargestPandigitalFor x =
    let rec loop n acc =
        let product = concatenatedProduct x [1..n]
        if product.Length > 9 then acc
        elif isPandigital1to9 product then product
        else loop (n + 1) acc
    loop 2 ""

let findLargestPandigitalOverall start stop =
    [start..stop]
    |> Seq.map findLargestPandigitalFor
    |> Seq.filter (fun s -> s <> "")
    |> Seq.maxBy int

let isRightTriangle a b c =
    a * a + b * b = c * c

let rightTriangles perimeter =
    threeSumCombinations perimeter
    |> List.filter (fun x -> isRightTriangle x[0] x[1] x[2])

let findPerimeterWithHighestNumberOfRightTriangles limit =
    [1..limit]
    |> List.map rightTriangles
    |> List.map List.length
    |> List.indexed
    |> List.maxBy snd
    |> fst
    |> (+) 1

let champernownesConstant index =
    Seq.initInfinite (fun i -> (i + 1) |> string)
    |> Seq.map seq
    |> Seq.concat
    |> Seq.skip (index - 1)
    |> Seq.head
    |> (string >> int)

let champernownesConstantProduct indices =
    indices
    |> List.map champernownesConstant
    |> List.reduce (*)

let isPandigitalByLength x =
    let xstr = string x
    isPandigital (xstr |> String.length) xstr

let findLargestPandigitalPrime () =
    primesUpTo 7654321
    |> List.filter isPandigitalByLength
    |> List.max

let triangleNumber n =
    n * (n + 1) / 2

let triangleNumbers () =
    Seq.initInfinite triangleNumber |> Seq.tail    

let triangleNumbersUpTo n =
    triangleNumbers()
    |> Seq.takeWhile (fun x -> x <= n)
    |> Seq.toList

let isTriangleNumber n =
    triangleNumbersUpTo n |> List.last = n

let isTriangleNumberWord word =
    let wordValue = wordScore word
    triangleNumbersUpTo wordValue |> List.last = wordValue

let rec permutations list =
    match list with
    | [] -> seq [ [] ]
    | _ ->
        seq {
            for i in 0 .. list.Length - 1 do
                let elem = list[i]
                let rest = list[0 .. i - 1] @ list[i + 1..]
                for perm in permutations rest do
                    yield elem :: perm
        }

let digitsToNumber digits =
    digits |> List.fold (fun acc c -> (acc * 10L) + c) 0L

let getPermutations (n: int) : int list =
    n
    |> string
    |> Seq.map (string >> int)
    |> Seq.toList
    |> permutations
    |> Seq.toList
    |> List.map (List.fold (fun acc c -> (acc * 10) + c) 0)
    

let hasInterestingSubStringDivisibility (digits: int64 list) =
    if digits.Length <> 10 then false
    else
        let primes = [2L; 3; 5; 7; 11; 13; 17]
        digits
        |> List.tail
        |> List.windowed 3
        |> List.zip primes
        |> List.forall (fun (prime, window) -> (digitsToNumber window) % prime = 0)

let pentagonalNumber n = n * (3 * n - 1) / 2

let pentagonalNumbers () =
    Seq.initInfinite pentagonalNumber |> Seq.tail

let isPentagonalNumber n =
    let discriminant = 1.0 + 24.0 * float n
    let sqrtDiscriminant = System.Math.Sqrt(discriminant)
    sqrtDiscriminant = floor sqrtDiscriminant && (1.0 + sqrtDiscriminant) % 6.0 = 0.0

let hexagonalNumber n = n * (2 * n - 1)

let hexagonalNumbers () =
    Seq.initInfinite hexagonalNumber |> Seq.tail

let isHexagonalNumber n =
    hexagonalNumbers ()
    |> Seq.takeWhile (fun x -> x <= n)
    |> Seq.last = n

let isOdd n =
    n % 2 <> 0

let isComposite n =
    not (isPrime n)

let isOddComposite n =
    isOdd n && isComposite n

let isGoldbachTrue n =
    primesUpTo n
    |> List.exists (fun p ->
        let reminder = n - p
        let squarePart = reminder / 2L
        squarePart > 0L && (sqrt (float squarePart) |> int64 |> fun x -> x * x = squarePart))

let findSmallestOddComposite () =
    Seq.initInfinite (fun x -> x + 3)
    |> Seq.filter isOddComposite
    |> Seq.find (fun n -> not (isGoldbachTrue n))

let hasDistinctPrimeFactors count n =
    primeFactors n |> List.distinct |> List.length = count

let findConsecutiveNumbers count consecutiveCount =
    let rec search n streak =
        if streak = consecutiveCount then n - consecutiveCount
        elif hasDistinctPrimeFactors count n then search (n + 1L) (streak + 1L)
        else search (n + 1L) 0L
    search 2L 0L

let modPow (base': BigInteger) (exp: int) (modulus: BigInteger) =
    let rec power (base': BigInteger) (exp: int) (acc: BigInteger) =
        if exp = 0 then acc
        elif exp % 2 = 0 then
            power ((base' * base') % modulus) (exp / 2) acc
        else
            power ((base' * base') % modulus) (exp / 2) ((acc * base') % modulus)
    power base' exp 1I

let lastTenDigitsOfSeries n =
    let modulus = 10000000000I
    ([1..n]
    |> List.map (fun n -> modPow (BigInteger n) n modulus)
    |> List.sum) % modulus

let isArithmeticSequence (numbers: int list) =
    if numbers.Length < 2 then true
    else
        let differences = 
            List.pairwise numbers
            |> List.map (fun (a, b) -> b - a)
        List.forall ((=) differences[0]) differences

let findSpecialSequences () =
    let fourDigitPrimes = 
        [1000..9999]
        |> List.filter isPrime
    
    [for a in fourDigitPrimes do
        let permsOfA = getPermutations a
                       |> List.distinct
                       |> List.filter isPrime

        for b in permsOfA |> List.filter (fun x -> x > a) do
            for c in permsOfA |> List.filter (fun x -> x > b) do
                if isArithmeticSequence [a; b; c] then
                    yield [a; b; c]]