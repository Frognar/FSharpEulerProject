module LexicographicPermutationsTests

open Xunit

[<Fact>]
let ``finds the first lexicographic permutation of [0; 1; 2]`` () =
    let result = ProjectEuler.lexicographicPermutation 1 [0; 1; 2]
    Assert.StrictEqual([0; 1; 2], result)
