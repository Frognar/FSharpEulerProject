module HighlyDivisibleTriangularNumberTests

open Xunit

[<Fact>]
let ``the first triangular number is 1`` () =
    Assert.Equal(1, ProjectEuler.triangularNumbers () |> Seq.head)