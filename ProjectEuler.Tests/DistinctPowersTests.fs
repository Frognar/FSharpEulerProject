module DistinctPowersTests

open Xunit

[<Fact>]
let ``power combinations of a^b with a = b = 2 are [4]`` () =
    Assert.StrictEqual([4I], ProjectEuler.powerCombinations [2])

[<Fact>]
let ``power combinations of a^b with a,b in range [2..3] are [4; 8; 9; 27]`` () =
    Assert.StrictEqual([4I; 8I; 9I; 27I], ProjectEuler.powerCombinations [2..3])