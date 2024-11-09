module FactorialDigitSumTests

open Xunit

[<Fact>]
let ``the sum of the digits in 1 is 1`` () =
    Assert.Equal(1, ProjectEuler.digitSum 1)

[<Fact>]
let ``the sum of the digits in 2 is 2`` () =
    Assert.Equal(2, ProjectEuler.digitSum 2)

[<Fact>]
let ``the sum of the digits in 12 is 3`` () =
    Assert.Equal(3, ProjectEuler.digitSum 12)

[<Fact>]
let ``the sum of the digits in 10! is 27`` () =
    Assert.Equal(27, ProjectEuler.digitSum (ProjectEuler.factorial 10))

[<Fact>]
let ``the sum of the digits in 100! is 648`` () =
    Assert.Equal(648, ProjectEuler.factorial 100I |> ProjectEuler.digitSum)