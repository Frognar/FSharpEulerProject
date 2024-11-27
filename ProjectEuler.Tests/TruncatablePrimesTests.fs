module TruncatablePrimesTests

open Xunit

[<Fact>]
let ``left truncates of 3797 are 797, 97, 7`` () =
    Assert.StrictEqual([797; 97; 7], ProjectEuler.leftTruncates 3797)