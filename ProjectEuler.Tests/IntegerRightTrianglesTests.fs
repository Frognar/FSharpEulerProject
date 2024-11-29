module IntegerRightTrianglesTests

open Xunit

[<Fact>]
let ``3 4 5 triangle is a right triangle`` () =
    Assert.True(ProjectEuler.isRightTriangle 3 4 5)