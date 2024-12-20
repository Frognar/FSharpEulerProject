module TriangularPentagonalHexagonalTests

open Xunit

[<Fact>]
let ``first 5 triangle numbers are [1; 3; 6; 10; 15]`` () =
    Assert.StrictEqual([1; 3; 6; 10; 15], ProjectEuler.triangleNumbers () |> Seq.take 5 |> Seq.toList)