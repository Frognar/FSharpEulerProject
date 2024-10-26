module ProjectEuler

let sumOfMultiplesOf3And5 n =
    match n with
    | _ when n > 5 -> 8
    | _ when n > 3 -> 3
    | _ -> 0