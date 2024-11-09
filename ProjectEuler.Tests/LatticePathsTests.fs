module LatticePathsTests

open Xunit

[<Fact>]
let ``starting in the top left corner of a 1x1 gird, there are exactly two routes to the bottom right corner`` () =
    Assert.Equal(2I, ProjectEuler.latticePaths 1I)

[<Fact>]
let ``starting in the top left corner of a 2x2 gird, there are exactly six routes to the bottom right corner`` () =
    Assert.Equal(6I, ProjectEuler.latticePaths 2I)

[<Fact>]
let ``starting in the top left corner of a 3x3 gird, there are exactly 20 routes to the bottom right corner`` () =
    Assert.Equal(20I, ProjectEuler.latticePaths 3I)

[<Fact>]
let ``starting in the top left corner of a 20x20 gird, there are exactly 137846528820 routes to the bottom right corner`` () =
    Assert.Equal(137846528820I, ProjectEuler.latticePaths 20I)

[<Fact>]
let ``factorial 0 is 1`` () =
    Assert.Equal(1, ProjectEuler.factorial 0)

[<Fact>]
let ``factorial 1 is 1`` () =
    Assert.Equal(1, ProjectEuler.factorial 1)

[<Fact>]
let ``factorial 2 is 2`` () =
    Assert.Equal(2, ProjectEuler.factorial 2)

[<Fact>]
let ``factorial 3 is 6`` () =
    Assert.Equal(6, ProjectEuler.factorial 3)

[<Fact>]
let ``factorial 20 is 2432902008176640000`` () =
    Assert.Equal(2432902008176640000I, ProjectEuler.factorial 20I)