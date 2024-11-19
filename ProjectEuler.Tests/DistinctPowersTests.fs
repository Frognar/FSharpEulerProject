module DistinctPowersTests

open Xunit

[<Fact>]
let ``power combinations of a^b with a = b = 2 are [4]`` () =
    Assert.StrictEqual([4], ProjectEuler.powerCombinations [2])