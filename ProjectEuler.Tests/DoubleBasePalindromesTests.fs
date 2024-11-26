module DoubleBasePalindromesTests

open Xunit

[<Fact>]
let ``1 in base 2 is 1`` () =
    Assert.Equal("1", ProjectEuler.toBase2 1)