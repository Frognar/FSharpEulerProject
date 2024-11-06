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
    Assert.Equal(1L, ProjectEuler.factorial 0)

[<Fact>]
let ``factorial 1 is 1`` () =
    Assert.Equal(1L, ProjectEuler.factorial 1)

[<Fact>]
let ``factorial 2 is 2`` () =
    Assert.Equal(2L, ProjectEuler.factorial 2)

[<Fact>]
let ``factorial 3 is 6`` () =
    Assert.Equal(6L, ProjectEuler.factorial 3)

[<Fact>]
let ``factorial 20 is 2432902008176640000`` () =
    Assert.Equal(2432902008176640000L, ProjectEuler.factorial 20)