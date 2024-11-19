module DistinctPowersTests

open Xunit

[<Fact>]
let ``power combinations of a^b with a = b = 2 are [4]`` () =
    Assert.StrictEqual([4I], ProjectEuler.powerCombinations [2])

[<Fact>]
let ``power combinations of a^b with a,b in range [2..3] are [4; 8; 9; 27]`` () =
    Assert.StrictEqual([4I; 8I; 9I; 27I], ProjectEuler.powerCombinations [2..3])

[<Fact>]
let ``power combinations of a^b with a,b in range [2..4] are [4; 8; 16; 9; 27; 81; 16; 64; 256]`` () =
    Assert.StrictEqual([4I; 8I; 16I; 9I; 27I; 81I; 16I; 64I; 256I], ProjectEuler.powerCombinations [2..4])

[<Fact>]
let ``count of distinct terms from a list [4; 8; 9; 27] is 4`` () =
    Assert.Equal(4, ProjectEuler.countDistinctTerms [4; 8; 9; 27])

[<Fact>]
let ``count of distinct terms from a list [4; 8; 16; 9; 27; 81; 16; 64; 256] is 8`` () =
    Assert.Equal(8, ProjectEuler.countDistinctTerms [4; 8; 16; 9; 27; 81; 16; 64; 256])

[<Fact>]
let ``count of distinct terms from a list of all power combinations of a^b with a,b in range [2..100] is 9183`` () =
    Assert.Equal(9183, [2..100]
                       |> ProjectEuler.powerCombinations
                       |> ProjectEuler.countDistinctTerms)