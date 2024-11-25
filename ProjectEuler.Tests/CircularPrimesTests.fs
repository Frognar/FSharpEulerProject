module CircularPrimesTests

open Xunit

[<Fact>]
let ``145 can be rotated to 451`` () =
    Assert.Contains(451, ProjectEuler.rotate 145)

[<Fact>]
let ``145 can be rotated to 514`` () =
    Assert.Contains(514, ProjectEuler.rotate 145)