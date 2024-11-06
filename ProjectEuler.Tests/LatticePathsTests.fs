module LatticePathsTests

open Xunit

[<Fact>]
let ``starting in the top left corner of a 1x1 gird, there are exactly two routes to the bottom right corner`` () =
    Assert.Equal(2, ProjectEuler.latticePaths 1)

[<Fact>]
let ``starting in the top left corner of a 2x2 gird, there are exactly six routes to the bottom right corner`` () =
    Assert.Equal(6, ProjectEuler.latticePaths 2)

//[<Fact>]
//let ``starting in the top left corner of a 3x3 gird, there are exactly 20 routes to the bottom right corner`` () =
//    Assert.Equal(20, ProjectEuler.latticePaths 3)

[<Fact>]
let ``factorial 0 is 1`` () =
    Assert.Equal(1, ProjectEuler.factorial 0)

[<Fact>]
let ``factorial 1 is 1`` () =
    Assert.Equal(1, ProjectEuler.factorial 1)

[<Fact>]
let ``factorial 2 is 2`` () =
    Assert.Equal(2, ProjectEuler.factorial 2)