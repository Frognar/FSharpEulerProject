module CodedTriangleNumbersTests

open Xunit

[<Fact>]
let ``1st triangle number is 1`` () =
    Assert.Equal(1, ProjectEuler.triangleNumber 1)