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

[<Fact>]
let ``1/2 is a possible fraction from digits [1; 2]`` () =
    Assert.Contains((1, 2), ProjectEuler.findPossibleFractions [1; 2])

[<Fact>]
let ``2/1 is a possible fraction from digits [1; 2]`` () =
    Assert.Contains((2, 1), ProjectEuler.findPossibleFractions [1; 2])

[<Fact>]
let ``1/1 is a possible fraction from digits [1; 2]`` () =
    Assert.Contains((1, 1), ProjectEuler.findPossibleFractions [1; 2])

[<Fact>]
let ``2/2 is a possible fraction from digits [1; 2]`` () =
    Assert.Contains((2, 2), ProjectEuler.findPossibleFractions [1; 2])