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

[<Fact>]
let ``"12" split into digits should be [1; 2]`` () =
    Assert.StrictEqual([1; 2], ProjectEuler.splitDigits "12")

[<Fact>]
let ``[] largest product is 0`` () =
    Assert.Equal(0, ProjectEuler.largestProduct [])

[<Fact>]
let ``[[1]] largest product is 1`` () =
    Assert.Equal(1, ProjectEuler.largestProduct [[1]])

[<Fact>]
let ``[[1]; [2]] largest product is 2`` () =
    Assert.Equal(2, ProjectEuler.largestProduct [[1]; [2]])

[<Fact>]
let ``[[1; 3]; [2; 1]] largest product is 3`` () =
    Assert.Equal(3, ProjectEuler.largestProduct [[1; 3]; [2; 1]])
