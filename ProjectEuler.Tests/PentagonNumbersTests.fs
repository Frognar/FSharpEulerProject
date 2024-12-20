module PentagonNumbersTests

open Xunit

[<Fact>]
let ``1st pentagon number is 1`` () =
    Assert.Equal(1, ProjectEuler.pentagonalNumbers () |> Seq.head)

[<Fact>]
let ``2nd pentagon number is 5`` () =
    Assert.Equal(5, ProjectEuler.pentagonalNumbers () |> Seq.tail |> Seq.head)

[<Fact>]
let ``10th pentagon number is 145`` () =
    Assert.Equal(145, ProjectEuler.pentagonalNumbers () |> Seq.skip 9 |> Seq.head)

[<Fact>]
let ``1 is pentagon number`` () =
    Assert.True(ProjectEuler.isPentagonalNumber 1)

[<Fact>]
let ``2 is not pentagon number`` () =
    Assert.False(ProjectEuler.isPentagonalNumber 2)

[<Fact>]
let ``5 is pentagon number`` () =
    Assert.True(ProjectEuler.isPentagonalNumber 5)

[<Fact>]
let ``5482660 is pentagon number`` () =
    Assert.True(ProjectEuler.isPentagonalNumber 5482660)

[<Fact>]
let ``minimal difference between two pentagon numbers is 5482660`` () =
    let pentagonals = ProjectEuler.pentagonalNumbers ()
                      |> Seq.take 10000
                      |> Seq.toArray

    let minD = pentagonals
            |> Array.indexed
            |> Array.collect (fun (j, pj) ->
                pentagonals
                |> Array.skip (j + 1)
                |> Array.map (fun pk ->
                    let sum = pj + pk
                    let diff = pk - pj
                    (sum, diff)))
            |> Array.where (fun (s, d) -> ProjectEuler.isPentagonalNumber s && ProjectEuler.isPentagonalNumber d)
            |> Array.map snd
            |> Array.min

    Assert.Equal(5482660, minD)