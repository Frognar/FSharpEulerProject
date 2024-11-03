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

[<Fact>]
let ``grid 2x2 has columns in the same direction`` () =
    let grid = [[1; 2]
                [3; 4]]
    let actual = ProjectEuler.getStraightAdjacentNumbers grid
    let expected = [[1; 3]; [2; 4]]
    expected |> List.iter (fun x -> Assert.Contains(x, actual))

[<Fact>]
let ``grid 2x2 has diagonals in the same direction`` () =
    let grid = [[1; 2]
                [3; 4]]
    let actual = ProjectEuler.getStraightAdjacentNumbers grid
    let expected = [[1; 4]; [2; 3]]
    expected |> List.iter (fun x -> Assert.Contains(x, actual))

[<Fact>]
let ``split empty matrix with 2x2 window should be []`` () =
    let grid = []
    let actual = ProjectEuler.splitWithWindow 2 grid
    Assert.Empty(actual)
