module LargestProductInASeriesTests

open Xunit

[<Fact>]
let ``"" split into substrings of size 1 should be []`` () =
    Assert.StrictEqual([], ProjectEuler.splitIntoSubstrings 1 "")

[<Fact>]
let ``"1" split into substrings of size 1 should be ["1"]`` () =
    Assert.StrictEqual(["1"], ProjectEuler.splitIntoSubstrings 1 "1")

[<Fact>]
let ``"12" split into substrings of size 1 should be ["1"; "2"]`` () =
    Assert.StrictEqual(["1"; "2"], ProjectEuler.splitIntoSubstrings 1 "12")

[<Fact>]
let ``"12" split into substrings of size 2 should be ["12"]`` () =
    Assert.StrictEqual(["12"], ProjectEuler.splitIntoSubstrings 2 "12")

[<Fact>]
let ``"123" split into substrings of size 2 should be ["12"; "23"]`` () =
    Assert.StrictEqual(["12"; "23"], ProjectEuler.splitIntoSubstrings 2 "123")

[<Fact>]
let ``"" split into digits should be []`` () =
    Assert.Empty(ProjectEuler.splitDigits "")

[<Fact>]
let ``"1" split into digits should be [1]`` () =
    Assert.StrictEqual([1], ProjectEuler.splitDigits "1")