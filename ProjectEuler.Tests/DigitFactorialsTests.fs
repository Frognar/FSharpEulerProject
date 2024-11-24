module DigitFactorialsTests

open Xunit

[<Fact>]
let ``1 can be written as the sum of factorial of its digits`` () =
    Assert.True(ProjectEuler.isFactorialOfItsDigitSum 1)

[<Fact>]
let ``2 can be written as the sum of factorial of its digits`` () =
    Assert.True(ProjectEuler.isFactorialOfItsDigitSum 2)

[<Fact>]
let ``3 cannot be written as the sum of factorial of its digits`` () =
    Assert.False(ProjectEuler.isFactorialOfItsDigitSum 3)
