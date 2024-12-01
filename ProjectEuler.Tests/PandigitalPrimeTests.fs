module PandigitalPrimeTests

open Xunit

[<Fact>]
let ``123 is pandigital 3`` () =
    Assert.True(ProjectEuler.isPandigitalByLength 123)

[<Fact>]
let ``the largest pandigital prime is 7652413`` () =
    Assert.Equal(7652413L, ProjectEuler.findLargestPandigitalPrime ())