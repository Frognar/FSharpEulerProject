module CodedTriangleNumbersTests

open Xunit

[<Fact>]
let ``1st triangle number is 1`` () =
    Assert.Equal(1, ProjectEuler.triangleNumber 1)

[<Fact>]
let ``2nd triangle number is 3`` () =
    Assert.Equal(3, ProjectEuler.triangleNumber 2)

[<Fact>]
let ``3rd triangle number is 6`` () =
    Assert.Equal(6, ProjectEuler.triangleNumber 3)