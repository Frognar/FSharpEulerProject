module NumberSpiralDiagonalsTests

open Xunit

[<Fact>]
let ``the sum of corner elements in 1 by 1 spiral is 1`` () =
    Assert.Equal(1, ProjectEuler.sumOfNumberSpiralCorners 1)

[<Fact>]
let ``the sum of corner elements in 3 by 3 spiral is 24`` () =
    Assert.Equal(24, ProjectEuler.sumOfNumberSpiralCorners 3)

[<Fact>]
let ``the sum of corner elements in 5 by 5 spiral is 76`` () =
    Assert.Equal(76, ProjectEuler.sumOfNumberSpiralCorners 5)

[<Fact>]
let ``the sum of the numbers on the diagonals in 5 by 5 number spiral is 101`` () =
    Assert.Equal(101, ProjectEuler.sumOfNumberSpiralDiagonals 5)

[<Fact>]
let ``the sum of the numbers on the diagonals in 1001 by 1001 number spiral is 101`` () =
    Assert.Equal(669171001, ProjectEuler.sumOfNumberSpiralDiagonals 1001)