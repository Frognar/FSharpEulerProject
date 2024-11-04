module HighlyDivisibleTriangularNumberTests

open Xunit

[<Fact>]
let ``the first triangular number is 1`` () =
    Assert.Equal(1, ProjectEuler.triangularNumbers () |> Seq.head)

[<Fact>]
let ``the second triangular number is 3`` () =
    Assert.Equal(3, ProjectEuler.triangularNumbers () |> Seq.skip 1 |> Seq.head)
