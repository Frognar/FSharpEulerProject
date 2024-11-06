module LatticePathsTests

open Xunit

[<Fact>]
let ``in grid 2x2 from the top left corner can go right`` () =
    let startPosition = (0, 0)
    let girdSize = (2, 2)
    let possibleMoves = ProjectEuler.possibleMoves startPosition girdSize
    Assert.Contains((0, 1), possibleMoves)
