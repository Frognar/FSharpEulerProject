module SumSquareDifferenceTests

open Xunit

[<Fact>]
let ``sum of the squares of the first 0 natural numbers is 0`` () =
    Assert.Equal(0, ProjectEuler.sumOfSquares [])
