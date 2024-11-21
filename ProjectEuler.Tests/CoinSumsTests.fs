module CoinSumsTests

open Xunit

[<Fact>]
let ``there is only one (empty) combination for a sum of 0`` () =
    Assert.StrictEqual([[]], ProjectEuler.findCombinations 0 [1; 2; 5])

[<Fact>]
let ``there is no combination for a sum of 5 with the numbers 2, 4 and 6`` () =
    Assert.Empty(ProjectEuler.findCombinations 5 [2; 4; 6])

[<Fact>]
let ``if the target is in given numbers, it should be a possible combination`` () =
    Assert.Contains([5], ProjectEuler.findCombinations 5 [1; 2; 5; 10])

[<Fact>]
let ``if the target is no numbers given, there is no possible combination`` () =
    Assert.Empty(ProjectEuler.findCombinations 5 [])

[<Fact>]
let ``if the target can be obtained from the given numbers, it should be a possible combination`` () =
    Assert.Contains([1; 1; 1; 1; 1], ProjectEuler.findCombinations 5 [1; 2; 10])
    Assert.Contains([1; 1; 1; 2], ProjectEuler.findCombinations 5 [1; 2; 10])
    Assert.Contains([1; 2; 2], ProjectEuler.findCombinations 5 [1; 2; 10])
