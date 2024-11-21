module CoinSumsTests

open Xunit

[<Fact>]
let ``there is only one (empty) combination for a sum of 0`` () =
    Assert.StrictEqual([[]], ProjectEuler.findCombinations 0 [1; 2; 5])
