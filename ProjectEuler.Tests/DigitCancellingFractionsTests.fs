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

[<Fact>]
let ``from factors [(1,1); (1,2); (2,1); (2;2)] only (1,2) has value smaller than 1`` () =
    let fractions = [(1, 1); (1, 2); (2, 1); (2, 2)]
    Assert.StrictEqual([(1, 2)], ProjectEuler.filterFractionsSmallerThanOne fractions)

[<Fact>]
let ``there are no fractions with value smaller than 1 in [(1,1); (2,2); (3,3); (2,1)]`` () =
    let fractions = [(1,1); (2,2); (3,3); (2,1)]
    Assert.Empty(ProjectEuler.filterFractionsSmallerThanOne fractions)

[<Fact>]
let ``there are some fractions with at least one common digit in denominator and numerator`` () =
    let fractions = [(10, 20); (11, 22); (12, 22)]
    Assert.StrictEqual([(10, 20); (12, 22)], ProjectEuler.filterFractionsWithCommonDigit fractions)

[<Fact>]
let ``there are some non-trivial fractions`` () =
    let fractions = [(10, 20); (12, 22); (10, 11)]
    Assert.StrictEqual([(12, 22); (10, 11)], ProjectEuler.filterNonTrivialFractions fractions)