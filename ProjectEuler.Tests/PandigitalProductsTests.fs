module PandigitalProductsTests

open Xunit

[<Fact>]
let ``123 is not a pandigital 1-9`` () =
    Assert.False(ProjectEuler.isPandigital 9 "123")

[<Fact>]
let ``123456789 is a pandigital 1-9`` () =
    Assert.True(ProjectEuler.isPandigital 9 "123456789")

[<Fact>]
let ``987654321 is a pandigital 1-9`` () =
    Assert.True(ProjectEuler.isPandigital 9 "987654321")