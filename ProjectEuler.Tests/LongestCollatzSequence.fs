module LongestCollatzSequence

open Xunit

[<Fact>]
let ``next Collatz number after 13 is 40`` () =
    Assert.Equal(40, ProjectEuler.nextCollatz 13)

[<Fact>]
let ``next Collatz number after 40 is 20`` () =
    Assert.Equal(20, ProjectEuler.nextCollatz 40)

[<Fact>]
let ``next Collatz number after 20 is 10`` () =
    Assert.Equal(10, ProjectEuler.nextCollatz 20)

[<Fact>]
let ``next Collatz number after 10 is 5`` () =
    Assert.Equal(5, ProjectEuler.nextCollatz 10)

[<Fact>]
let ``next Collatz number after 5 is 16`` () =
    Assert.Equal(16, ProjectEuler.nextCollatz 5)

[<Fact>]
let ``Collatz sequence for 1 is [1]`` () =
    Assert.StrictEqual([1], ProjectEuler.collatzSequence 1)

[<Fact>]
let ``Collatz sequence for 2 is [2; 1]`` () =
    Assert.StrictEqual([2; 1], ProjectEuler.collatzSequence 2)

[<Fact>]
let ``Collatz sequence for 3 is [3; 10; 5; 16; 8; 4; 2; 1]`` () =
    Assert.StrictEqual([3; 10; 5; 16; 8; 4; 2; 1], ProjectEuler.collatzSequence 3)

[<Fact>]
let ``Collatz sequence for 13 is [13; 40; 20; 10; 5; 16; 8; 4; 2; 1]`` () =
    Assert.StrictEqual([13; 40; 20; 10; 5; 16; 8; 4; 2; 1], ProjectEuler.collatzSequence 13)

[<Fact>]
let ``Collatz sequences for 1 are [ (1, [1]) ]`` () =
    Assert.StrictEqual(Map [(1L, [1L])], ProjectEuler.collatzSequences 1)

[<Fact>]
let ``Collatz sequences for 2 are [ (1, [1]); (2, [2; 1]) ]`` () =
    Assert.StrictEqual(Map [(1L, [1L]); (2L, [2L; 1L])], ProjectEuler.collatzSequences 2)

[<Fact>]
let ``longest Collatz sequence in range [1..99_999] is from 77031 with 351 steps`` () =
    Assert.Equal((77031L, 351), ProjectEuler.collatzSequences 99_999
                 |> Map.toList
                 |> List.map (fun (n, x) -> (n, x |> List.length))
                 |> List.maxBy snd)

[<Fact>]
let ``longest Collatz sequence in range [1..999_999] is from 837799 with 525 steps`` () =
    Assert.Equal((837799L, 525), ProjectEuler.collatzSequences 999_999
                 |> Map.toList
                 |> List.map (fun (n, x) -> (n, x |> List.length))
                 |> List.maxBy snd)
