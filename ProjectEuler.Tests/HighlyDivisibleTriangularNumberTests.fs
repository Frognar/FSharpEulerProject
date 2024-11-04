module HighlyDivisibleTriangularNumberTests

open Xunit

[<Fact>]
let ``the first triangular number is 1`` () =
    Assert.Equal(1, ProjectEuler.triangularNumbers () |> Seq.head)

[<Fact>]
let ``the second triangular number is 3`` () =
    Assert.Equal(3, ProjectEuler.triangularNumbers () |> Seq.skip 1 |> Seq.head)

[<Fact>]
let ``the seventh triangular number is 28`` () =
    Assert.Equal(28, ProjectEuler.triangularNumbers () |> Seq.skip 6 |> Seq.head)

[<Fact>]
let ``1 is divisible by [1]`` () =
    Assert.StrictEqual([1], ProjectEuler.getDivisors 1)