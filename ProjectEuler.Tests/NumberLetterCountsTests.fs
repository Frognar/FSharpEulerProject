module NumberLetterCountsTests

open Xunit

//[<Fact>]
//let ```numbers 1 to 1000 written out in words would have 21124 letters`` () =
//    Assert.Equal(21124, [ 1..1000 ]
//                 |> List.map ProjectEuler.read
//                 |> List.map (_.Replace(" ", "").Replace("-", "").Length)
//                 |> List.sum)

[<Fact>]
let ``1 is one`` () =
    Assert.Equal("one", ProjectEuler.read 1)
