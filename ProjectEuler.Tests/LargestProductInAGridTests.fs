module LargestProductInAGridTests

open Xunit

[<Fact>]
let ``grid 1x1 has only one set of adjacent numbers in the same direction`` () =
    let grid = [[1]]
    Assert.Equivalent([[1]], ProjectEuler.getStraightAdjacentNumbers grid)

[<Fact>]
let ``grid 2x2 has rows in the same direction`` () =
    let grid = [[1; 2]
                [3; 4]]
    let actual = ProjectEuler.getStraightAdjacentNumbers grid
    let expected = [[1; 2]; [3; 4]]
    expected |> List.iter (fun x -> Assert.Contains(x, actual))
