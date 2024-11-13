module LexicographicPermutationsTests

open Xunit

[<Fact>]
let ``finds the first lexicographic permutation of [0; 1; 2]`` () =
    let result = ProjectEuler.lexicographicPermutation 1 [0; 1; 2]
    Assert.StrictEqual([0; 1; 2], result)

[<Fact>]
let ``finds the second lexicographic permutation of [0; 1; 2]`` () =
    let result = ProjectEuler.lexicographicPermutation 2 [0; 1; 2]
    Assert.StrictEqual([0; 2; 1], result)

[<Fact>]
let ``finds the millionth lexicographic permutation of [0; 1; 2; 3; 4; 5; 6; 7; 8; 9]`` () =
    let result = ProjectEuler.lexicographicPermutation 1000000 [0; 1; 2; 3; 4; 5; 6; 7; 8; 9]
    Assert.StrictEqual([2; 7; 8; 3; 9; 1; 5; 4; 6; 0], result)