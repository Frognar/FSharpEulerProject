module DigitFactorialsTests

open Xunit

[<Fact>]
let ``1 can be written as the sum of factorial of its digits`` () =
    Assert.True(ProjectEuler.isFactorialOfItsDigitSum 1)
