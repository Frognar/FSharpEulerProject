﻿module LargestProductInASeriesTests

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
let ``"731671765313306" split into substrings of size 13 should be ["7316717653133"; "3167176531330"; "1671765313306"]`` () =
    Assert.StrictEqual(["7316717653133"; "3167176531330"; "1671765313306"], ProjectEuler.splitIntoSubstrings 13 "731671765313306")

[<Fact>]
let ``"" split into digits should be []`` () =
    Assert.Empty(ProjectEuler.splitDigits "")

[<Fact>]
let ``"1" split into digits should be [1]`` () =
    Assert.StrictEqual(([1]: int64 list), ProjectEuler.splitDigits "1")

[<Fact>]
let ``"12" split into digits should be [1; 2]`` () =
    Assert.StrictEqual(([1; 2]: int64 list), ProjectEuler.splitDigits "12")

[<Fact>]
let ``"7316717653133" split into digits should be [7; 3; 1; 6; 7; 1; 7; 6; 5; 3; 1; 3; 3]`` () =
    Assert.StrictEqual(([7; 3; 1; 6; 7; 1; 7; 6; 5; 3; 1; 3; 3]: int64 list), ProjectEuler.splitDigits "7316717653133")

[<Fact>]
let ``[] largest product is 0`` () =
    Assert.Equal(0L, ProjectEuler.largestProduct [])

[<Fact>]
let ``[[1]] largest product is 1`` () =
    Assert.Equal(1L, ProjectEuler.largestProduct [[1]])

[<Fact>]
let ``[[1]; [2]] largest product is 2`` () =
    Assert.Equal(2L, ProjectEuler.largestProduct [[1]; [2]])

[<Fact>]
let ``[[1; 3]; [2; 1]] largest product is 3`` () =
    Assert.Equal(3L, ProjectEuler.largestProduct [[1; 3]; [2; 1]])


[<Fact>]
let ``[[7; 3; 1; 6; 7; 1; 7; 6; 5; 3; 1; 3; 3]; [2; 1]] largest product is 5000940`` () =
    Assert.Equal(5000940L, ProjectEuler.largestProduct [
        [7; 3; 1; 6; 7; 1; 7; 6; 5; 3; 1; 3; 3]
        [3; 1; 6; 7; 1; 7; 6; 5; 3; 1; 3; 3; 0]
        [1; 6; 7; 1; 7; 6; 5; 3; 1; 3; 3; 0; 6]
    ])
