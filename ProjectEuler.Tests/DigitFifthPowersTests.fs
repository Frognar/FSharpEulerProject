module DigitFifthPowersTests

open Xunit

[<Fact>]
let ``fifth power of 1 is 1`` () =
    Assert.Equal(1, ProjectEuler.fifthPower 1)