module SpecialPythagoreanTripletTests

open Xunit

[<Fact>]
let ``all a < b < c that sum up to 6 are [[1;2;3]]`` () =
    Assert.StrictEqual([[1;2;3]], ProjectEuler.threeSumCombinations 6)


[<Fact>]
let ``all a < b < c that sum up to 7 are [[1;2;4]]`` () =
    Assert.StrictEqual([[1;2;4]], ProjectEuler.threeSumCombinations 7)

