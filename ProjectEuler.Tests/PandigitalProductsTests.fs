module PandigitalProductsTests

open Xunit

[<Fact>]
let ``123 is not a pandigital 1-9`` () =
    Assert.False(ProjectEuler.isPandigital 9 "123")