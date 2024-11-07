module MaximumPathSumTests

open Xunit

[<Fact>]
let ``the maximum total from top to bottom of triangle [ [1] ] is 1`` () =
    Assert.Equal(1, ProjectEuler.maximumTotal [ [1] ])