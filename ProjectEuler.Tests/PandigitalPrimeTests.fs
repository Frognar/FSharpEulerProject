module PandigitalPrimeTests

open Xunit

[<Fact>]
let ``123 is pandigital 3`` () =
    Assert.True(ProjectEuler.isPandigitalByLength 123)
