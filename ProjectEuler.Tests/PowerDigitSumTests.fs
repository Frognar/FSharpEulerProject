module PowerDigitSumTests

open Xunit

[<Fact>]
let ``sum of digits of 2^0 is 1`` () =
    Assert.Equal(1I, ProjectEuler.powerDigitSum 2 0)

[<Fact>]
let ``sum of digits of 2^1 is 2`` () =
    Assert.Equal(2I, ProjectEuler.powerDigitSum 2 1)
