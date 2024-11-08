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

[<Theory>]
[<InlineData(10, "ten")>]
[<InlineData(11, "eleven")>]
[<InlineData(12, "twelve")>]
[<InlineData(13, "thirteen")>]
[<InlineData(14, "fourteen")>]
[<InlineData(15, "fifteen")>]
[<InlineData(16, "sixteen")>]
[<InlineData(17, "seventeen")>]
[<InlineData(18, "eighteen")>]
[<InlineData(19, "nineteen")>]
let ``teens are read as expected`` number expected =
    Assert.Equal(expected, ProjectEuler.read number)

[<Theory>]
[<InlineData(20, "twenty")>]
[<InlineData(30, "thirty")>]
[<InlineData(40, "forty")>]
[<InlineData(50, "fifty")>]
[<InlineData(60, "sixty")>]
[<InlineData(70, "seventy")>]
[<InlineData(80, "eighty")>]
[<InlineData(90, "ninety")>]
let ``tens are read as expected`` number expected =
    Assert.Equal(expected, ProjectEuler.read number)

[<Theory>]
[<InlineData(21, "twenty-one")>]
[<InlineData(32, "thirty-two")>]
[<InlineData(43, "forty-three")>]
[<InlineData(54, "fifty-four")>]
[<InlineData(65, "sixty-five")>]
[<InlineData(76, "seventy-six")>]
[<InlineData(87, "eighty-seven")>]
[<InlineData(98, "ninety-eight")>]
let ``numbers 21 to 99 are read as expected`` number expected =
    Assert.Equal(expected, ProjectEuler.read number)
