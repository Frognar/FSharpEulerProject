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
    0
