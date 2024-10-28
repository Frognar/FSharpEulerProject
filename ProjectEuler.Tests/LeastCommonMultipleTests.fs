module LeastCommonMultipleTests

open Xunit

[<Fact>]
let ``gcd for 1 and 1 is 1`` () =
    Assert.Equal(1, ProjectEuler.greatestCommonDivisor 1 1)