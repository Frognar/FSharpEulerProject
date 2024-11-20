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

[<Fact>]
let ``10 cannot be written as the sum of fifth powers`` () =
    Assert.False(ProjectEuler.isFifthPowerSum 10)  