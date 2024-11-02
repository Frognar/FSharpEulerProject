module LargestProductInAGridTests

open Xunit

[<Fact>]
let ``grid 1x1 has only one set of adjacent numbers in the same direction`` () =
    let grid = [[1]]
    Assert.Equivalent([[1]], ProjectEuler.getStraightAdjacentNumbers grid)