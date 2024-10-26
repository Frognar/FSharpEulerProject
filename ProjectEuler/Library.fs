module ProjectEuler

let sumOfMultiplesOf3And5 n =
    [1 .. n-1]
    |> List.filter (fun x -> x % 3 = 0 || x % 5 = 0)
    |> List.sum

let fibonacciUpTo maxFibValue =
    match maxFibValue with
    | 0 -> []
    | 1 -> [1]
    | _ -> [1; 2]
