module PrimeFactorsTests

open Xunit

[<Fact>]
let ``prime factors of 1 is []`` () =
    Assert.Empty(ProjectEuler.primeFactors 1)