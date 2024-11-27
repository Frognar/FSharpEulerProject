module TruncatablePrimesTests

open Xunit

[<Fact>]
let ``left truncates of 3797 are 797, 97, 7`` () =
    Assert.StrictEqual([797; 97; 7], ProjectEuler.leftTruncates 3797)

[<Fact>]
let ``right truncates of 3797 are 379, 37, 3`` () =
    Assert.StrictEqual([379; 37; 3], ProjectEuler.rightTruncates 3797)

[<Fact>]
let ``left and right truncates of 3797 are 797, 97, 7, 379, 37, 3`` () =
    Assert.StrictEqual([797; 97; 7; 379; 37; 3], ProjectEuler.truncates 3797)  