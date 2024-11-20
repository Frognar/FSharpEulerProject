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