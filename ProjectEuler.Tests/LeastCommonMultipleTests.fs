module LeastCommonMultipleTests

open Xunit

[<Fact>]
let ``gcd for 1 and 1 is 1`` () =
    Assert.Equal(1, ProjectEuler.greatestCommonDivisor 1 1)

[<Fact>]
let ``gcd for 2 and 2 is 2`` () =
    Assert.Equal(2, ProjectEuler.greatestCommonDivisor 2 2)

[<Fact>]
let ``gcd for 4 and 2 is 2`` () =
    Assert.Equal(2, ProjectEuler.greatestCommonDivisor 4 2)