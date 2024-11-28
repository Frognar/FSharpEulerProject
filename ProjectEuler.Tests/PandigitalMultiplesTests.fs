module PandigitalMultiplesTests

open Xunit

[<Fact>]
let ``concatenated product of 192 and [1..3] is "192384576"`` () =
    Assert.Equal("192384576", ProjectEuler.concatenatedProduct 192 [1..3])

[<Fact>]
let ``concatenated product of 9 and [1..5] is "918273645"`` () =
    Assert.Equal("918273645", ProjectEuler.concatenatedProduct 9 [1..5])

[<Fact>]
let ``concatenated product of 192 and [1..3] is pandigital 1-9`` () =
    Assert.True(ProjectEuler.isPandigital1to9 (ProjectEuler.concatenatedProduct 192 [1..3]))

[<Fact>]
let ``concatenated product of 9 and [1..5] is pandigital 1-9`` () =
    Assert.True(ProjectEuler.isPandigital1to9 (ProjectEuler.concatenatedProduct 9 [1..5]))