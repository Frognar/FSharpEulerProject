module LatticePathsTests

open Xunit

[<Fact>]
let ``starting in the top left corner of a 1x1 gird, there are exactly two routes to the bottom right corner`` () =
    Assert.Equal(2, ProjectEuler.latticePaths 1)

[<Fact>]
let ``starting in the top left corner of a 2x2 gird, there are exactly six routes to the bottom right corner`` () =
    Assert.Equal(6, ProjectEuler.latticePaths 2)
