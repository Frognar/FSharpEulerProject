module DigitCancellingFractionsTests

open Xunit

[<Fact>]
let ``possible fractions from digits [1] are [(1, 1)]`` () =
    Assert.StrictEqual([(1, 1)], ProjectEuler.findPossibleFractions [1])