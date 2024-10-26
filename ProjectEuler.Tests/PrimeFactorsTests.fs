module PrimeFactorsTests

open Xunit

[<Fact>]
let ``prime factors of 1 is []`` () =
    Assert.Empty(ProjectEuler.primeFactors 1)

[<Fact>]
let ``prime factors of 2 is [2]`` () =
    Assert.StrictEqual([2], ProjectEuler.primeFactors 2)