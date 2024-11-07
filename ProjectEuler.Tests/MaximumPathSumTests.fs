module MaximumPathSumTests

open Xunit

[<Fact>]
let ``the maximum total from top to bottom of triangle [ [1] ] is 1`` () =
    Assert.Equal(1, ProjectEuler.maximumTotal [ [1] ])

[<Fact>]
let ``the maximum total from top to bottom of triangle [ [2] ] is 2`` () =
    Assert.Equal(2, ProjectEuler.maximumTotal [ [2] ])

[<Fact>]
let ``the maximum total from top to bottom of triangle [ ] is 0`` () =
    Assert.Equal(0, ProjectEuler.maximumTotal [ ])

[<Fact>]
let ``the maximum total from top to bottom of triangle [ [3]; [7; 4] ] is 10`` () =
    Assert.Equal(10, ProjectEuler.maximumTotal [ [3]; [7; 4] ])