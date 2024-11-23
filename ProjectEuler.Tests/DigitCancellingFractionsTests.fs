module DigitCancellingFractionsTests

open Xunit

[<Fact>]
let ``possible fractions from digits [1] are [(1, 1)]`` () =
    Assert.StrictEqual([(1, 1)], ProjectEuler.findPossibleFractions [1])

[<Fact>]
let ``possible fractions from digits [2] are [(2, 2)]`` () =
    Assert.StrictEqual([(2, 2)], ProjectEuler.findPossibleFractions [2])

[<Fact>]
let ``cannot build fractions without digits`` () =
    Assert.Empty(ProjectEuler.findPossibleFractions [])