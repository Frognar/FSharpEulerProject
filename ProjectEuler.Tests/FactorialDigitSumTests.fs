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
let ``the factorial of 0 is 1`` () =
    Assert.Equal(1I, ProjectEuler.bigFactorial 0I)

[<Fact>]
let ``the factorial of 2 is 2`` () =
    Assert.Equal(2I, ProjectEuler.bigFactorial 2I)

[<Fact>]
let ``the factorial of 3 is 6`` () =
    Assert.Equal(6I, ProjectEuler.bigFactorial 3I)

[<Fact>]
let ``the factorial of 100 is 93326215443944152681699238856266700490715968264381621468592963895217599993229915608941463976156518286253697920827223758251185210916864000000000000000000000000`` () =
    Assert.Equal(
        93326215443944152681699238856266700490715968264381621468592963895217599993229915608941463976156518286253697920827223758251185210916864000000000000000000000000I,
        ProjectEuler.bigFactorial 100I)
