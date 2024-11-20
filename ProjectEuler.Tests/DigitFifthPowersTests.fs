module DigitFifthPowersTests

open Xunit

[<Theory>]
[<InlineData(1, 1)>]
let ``fifth power of n`` (n: int) expected =
    Assert.Equal(expected, ProjectEuler.fifthPower n)
