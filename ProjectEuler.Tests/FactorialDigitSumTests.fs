module FactorialDigitSumTests

open Xunit

[<Fact>]
let ``the sum of the digits in 1 is 1`` () =
    Assert.Equal(1, ProjectEuler.digitSum 1)

[<Fact>]
let ``the sum of the digits in 2 is 2`` () =
    Assert.Equal(2, ProjectEuler.digitSum 2)
