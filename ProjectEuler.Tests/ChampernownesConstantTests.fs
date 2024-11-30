module ChampernownesConstantTests

open Xunit

[<Fact>]
let ``the 12th digit of Champernowne's constant is 1`` () =
    Assert.Equal(1, ProjectEuler.champernownesConstant 12)