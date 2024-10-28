module ProjectEuler

open System

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

let greatestCommonDivisor a b =
    a