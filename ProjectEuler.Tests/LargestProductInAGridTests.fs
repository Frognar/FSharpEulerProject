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

[<Fact>]
let ``split 2x2 matrix with 2x2 window should contain the original matrix`` () =
    let grid = [[1; 2]
                [3; 4]]
    let actual = ProjectEuler.splitWithWindow 2 grid
    Assert.StrictEqual([grid], actual)

[<Fact>]
let ``split 3x3 matrix with 2x2 window should contain top left 2x2 matrix`` () =
    let grid = [[1; 2; 3]
                [4; 5; 6]
                [7; 8; 9]]
    let actual = ProjectEuler.splitWithWindow 2 grid
    Assert.Contains([[1; 2]; [4; 5]], actual)

[<Fact>]
let ``split 3x3 matrix with 2x2 window should contain top right 2x2 matrix`` () =
    let grid = [[1; 2; 3]
                [4; 5; 6]
                [7; 8; 9]]
    let actual = ProjectEuler.splitWithWindow 2 grid
    Assert.Contains([[2; 3]; [5; 6]], actual)

[<Fact>]
let ``split 3x3 matrix with 2x2 window should contain bottom left 2x2 matrix`` () =
    let grid = [[1; 2; 3]
                [4; 5; 6]
                [7; 8; 9]]
    let actual = ProjectEuler.splitWithWindow 2 grid
    Assert.Contains([[4; 5]; [7; 8]], actual)

[<Fact>]
let ``split 3x3 matrix with 2x2 window should contain bottom right 2x2 matrix`` () =
    let grid = [[1; 2; 3]
                [4; 5; 6]
                [7; 8; 9]]
    let actual = ProjectEuler.splitWithWindow 2 grid
    Assert.Contains([[5; 6]; [8; 9]], actual)

[<Fact>]
let ``split 2x3 matrix with 2x2 widow should contain two 2x2 matrices`` () =
    let grid = [[1; 2; 3]
                [4; 5; 6]]
    let actual = ProjectEuler.splitWithWindow 2 grid
    let expected = [[[1; 2]; [4; 5]]; [[2; 3]; [5; 6]]]
    Assert.StrictEqual(expected, actual)

[<Fact>]
let ``split 4x4 matrix with 2x2 window should contain nine 2x2 matrices`` () =
    let grid = [[1; 2; 3; 4]
                [5; 6; 7; 8]
                [9; 10; 11; 12]
                [13; 14; 15; 16]]
    let actual = ProjectEuler.splitWithWindow 2 grid
    Assert.Equal(9, List.length actual)
