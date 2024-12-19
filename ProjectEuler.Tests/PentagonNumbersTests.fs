module PentagonNumbersTests

open Xunit

[<Fact>]
let ``1st pentagon number is 1`` () =
    Assert.Equal(1, ProjectEuler.pentagonNumbers () |> Seq.head)

[<Fact>]
let ``2nd pentagon number is 5`` () =
    Assert.Equal(5, ProjectEuler.pentagonNumbers () |> Seq.tail |> Seq.head)

[<Fact>]
let ``10th pentagon number is 145`` () =
    Assert.Equal(145, ProjectEuler.pentagonNumbers () |> Seq.skip 9 |> Seq.head)

[<Fact>]
let ``1 is pentagon number`` () =
    Assert.True(ProjectEuler.isPentagonNumber 1)

[<Fact>]
let ``2 is not pentagon number`` () =
    Assert.False(ProjectEuler.isPentagonNumber 2)