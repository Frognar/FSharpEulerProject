module DistinctPrimesFactorsTests

open Xunit

[<Fact>]
let ``Test prime factors of a number`` () =
    Assert.StrictEqual([2L; 7L], ProjectEuler.primeFactors 14)
    Assert.StrictEqual([3L; 5L], ProjectEuler.primeFactors 15)
    Assert.StrictEqual([2L; 2L; 7L; 23L], ProjectEuler.primeFactors 644)
