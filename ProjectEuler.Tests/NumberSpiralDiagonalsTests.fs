module NumberSpiralDiagonalsTests

open Xunit

[<Fact>]
let ``the sum of corner elements in 1 by 1 spiral is 1`` () =
    Assert.Equal(1, ProjectEuler.sumOfNumberSpiralCorners 1)

[<Fact>]
let ``the sum of corner elements in 3 by 3 spiral is 24`` () =
    Assert.Equal(24, ProjectEuler.sumOfNumberSpiralCorners 3)