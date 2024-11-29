module IntegerRightTrianglesTests

open Xunit

[<Fact>]
let ``3 4 5 triangle is a right triangle`` () =
    Assert.True(ProjectEuler.isRightTriangle 3 4 5)

[<Fact>]
let ``there are exactly three right triangles with perimeter equal to 120`` () =
    let rightTriangles = ProjectEuler.rightTriangles 120
    Assert.Equal(3, rightTriangles |> List.length)
    Assert.Contains([20; 48; 52], rightTriangles)
    Assert.Contains([24; 45; 51], rightTriangles)
    Assert.Contains([30; 40; 50], rightTriangles)