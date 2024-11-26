module DoubleBasePalindromesTests

open Xunit

[<Fact>]
let ``1 in base 2 is 1`` () =
    Assert.Equal("1", ProjectEuler.toBase2 1)

[<Fact>]
let ``2 in base 2 is 10`` () =
    Assert.Equal("10", ProjectEuler.toBase2 2)

[<Fact>]
let ``3 in base 2 is 11`` () =
    Assert.Equal("11", ProjectEuler.toBase2 3)