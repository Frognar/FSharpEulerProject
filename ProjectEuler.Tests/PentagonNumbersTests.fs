module PentagonNumbersTests

open Xunit

[<Fact>]
let ``1st pentagon number is 1`` () =
    Assert.Equal(1, ProjectEuler.pentagonNumbers () |> Seq.head)