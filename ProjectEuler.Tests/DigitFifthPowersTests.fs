module DigitFifthPowersTests

open Xunit

[<Theory>]
[<InlineData(1, 1)>]
[<InlineData(2, 32)>]
[<InlineData(9, 59049)>]
let ``fifth power of n`` (n: int) expected =
    Assert.Equal(expected, ProjectEuler.fifthPower n)

[<Theory>]
[<InlineData(1, 1)>]
[<InlineData(11, 2)>]
[<InlineData(12, 33)>]
let ``the sum of the digit fifth powers for n`` (n: int) expected =
    Assert.Equal(expected, ProjectEuler.digitFifthPowersSum n)

[<Theory>]
[<InlineData(10, false)>]
[<InlineData(4150, true)>]
let ``can n be written as the sum of digit fifth powers`` (n: int) expected =
    Assert.Equal(expected, ProjectEuler.isFifthPowerSum n)

[<Theory>]
[<InlineData(3, 2916)>]
[<InlineData(4, 32805)>]
[<InlineData(5, 354294)>]
let ``find the largest number that can be written as the sum of n-th powers`` (n: int) expected =
    Assert.Equal(expected, ProjectEuler.maxSearchLimit n)

[<Fact>]
let ``all numbers that can be written as the sum of fifth powers of their digits`` () =
    Assert.StrictEqual(
        [4150; 4151; 54748; 92727; 93084; 194979],
        ([10..354294] |> List.filter ProjectEuler.isFifthPowerSum))
