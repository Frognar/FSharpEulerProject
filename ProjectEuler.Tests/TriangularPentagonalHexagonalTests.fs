module TriangularPentagonalHexagonalTests

open Xunit

[<Fact>]
let ``first 5 triangle numbers are [1; 3; 6; 10; 15]`` () =
    Assert.StrictEqual([1; 3; 6; 10; 15], ProjectEuler.triangleNumbers () |> Seq.take 5 |> Seq.toList)

[<Fact>]
let ``first 5 pentagonal numbers are [1; 5; 12; 22; 35]`` () =
    Assert.StrictEqual([1; 5; 12; 22; 35], ProjectEuler.pentagonalNumbers () |> Seq.take 5 |> Seq.toList)