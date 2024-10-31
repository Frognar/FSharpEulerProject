module LargestProductInASeriesTests

open Xunit

[<Fact>]
let ``"" split into substrings of size 1 should be []`` () =
    Assert.StrictEqual([], ProjectEuler.splitIntoSubstrings 1 "")

[<Fact>]
let ``"1" split into substrings of size 1 should be ["1"]`` () =
    Assert.StrictEqual(["1"], ProjectEuler.splitIntoSubstrings 1 "1")
