module CoinSumsTests

open Xunit

[<Fact>]
let ``there is only one (empty) combination for a sum of 0`` () =
    Assert.StrictEqual([[]], ProjectEuler.findCombinations 0 [1; 2; 5])

[<Fact>]
let ``there is no combination for a sum of 5 with the numbers 2, 4 and 6`` () =
    Assert.Empty(ProjectEuler.findCombinations 5 [2; 4; 6])
