module DigitFifthPowersTests

open Xunit

[<Theory>]
[<InlineData(1, 1)>]
[<InlineData(2, 32)>]
[<InlineData(9, 59049)>]
let ``fifth power of n`` (n: int) expected =
    Assert.Equal(expected, ProjectEuler.fifthPower n)

[<Fact>]
let ``the sum of the digit fifth powers for 1 is 1`` () =
    Assert.Equal(1, ProjectEuler.digitFifthPowersSum 1)