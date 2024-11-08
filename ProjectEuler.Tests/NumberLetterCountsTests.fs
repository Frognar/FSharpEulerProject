module NumberLetterCountsTests

open Xunit

//[<Fact>]
//let ```numbers 1 to 1000 written out in words would have 21124 letters`` () =
//    Assert.Equal(21124, [ 1..1000 ]
//                 |> List.map ProjectEuler.read
//                 |> List.map (_.Replace(" ", "").Replace("-", "").Length)
//                 |> List.sum)

[<Theory>]
[<InlineData(1, "one")>]
[<InlineData(2, "two")>]
[<InlineData(3, "three")>]
[<InlineData(4, "four")>]
[<InlineData(5, "five")>]
[<InlineData(6, "six")>]
[<InlineData(7, "seven")>]
[<InlineData(8, "eight")>]
[<InlineData(9, "nine")>]
let ``units are read as expected`` number expected =
    Assert.Equal(expected, ProjectEuler.read number)
