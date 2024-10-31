module SpecialPythagoreanTripletTests

open Xunit

[<Fact>]
let ``all a < b < c that sum up to 6 are [[1;2;3]]`` () =
    Assert.StrictEqual([[1;2;3]], ProjectEuler.threeSumCombinations 6)

[<Fact>]
let ``all a < b < c that sum up to 7 are [[1;2;4]]`` () =
    Assert.StrictEqual([[1;2;4]], ProjectEuler.threeSumCombinations 7)

[<Fact>]
let ``all a < b < c that sum up to 8 are [[1;2;5]; [1;3;4]]`` () =
    Assert.StrictEqual([[1; 2; 5]; [1; 3; 4]], ProjectEuler.threeSumCombinations 8)

[<Fact>]
let ``all a < b < c that sum up to 9 are [[1;2;6]; [1;3;5]; [2;3;4]]`` () =
    Assert.StrictEqual([[1; 2; 6]; [1; 3; 5]; [2; 3; 4]], ProjectEuler.threeSumCombinations 9)

[<Fact>]
let ``Pythagorean triplet for witch a + b + c = 1000 is [[200; 375; 425]]`` () =
    Assert.StrictEqual([[200; 375; 425]], ProjectEuler.threeSumCombinations 1000
                       |> List.filter (fun x -> x[0] * x[0] + x[1] * x[1] = x[2] * x[2]))
