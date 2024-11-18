module NumberSpiralDiagonalsTests

open Xunit

[<Fact>]
let ``the sum of corner elements in 1 by 1 spiral is 1`` () =
    Assert.Equal(1, ProjectEuler.sumOfNumberSpiralCorners 1)