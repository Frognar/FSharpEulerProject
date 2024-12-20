module TriangularPentagonalHexagonalTests

open Xunit

[<Fact>]
let ``first 5 triangle numbers are [1; 3; 6; 10; 15]`` () =
    Assert.StrictEqual([1; 3; 6; 10; 15], ProjectEuler.triangleNumbers () |> Seq.take 5 |> Seq.toList)

[<Fact>]
let ``first 5 pentagonal numbers are [1; 5; 12; 22; 35]`` () =
    Assert.StrictEqual([1; 5; 12; 22; 35], ProjectEuler.pentagonalNumbers () |> Seq.take 5 |> Seq.toList)

[<Fact>]
let ``first 5 hexagonal numbers are [1; 6; 15; 28; 45]`` () =
    Assert.StrictEqual([1; 6; 15; 28; 45], ProjectEuler.hexagonalNumbers () |> Seq.take 5 |> Seq.toList)

[<Fact>]
let ``40755 is triangle, pentagonal and hexagonal`` () =
    Assert.True(ProjectEuler.isTriangleNumber 40755)
    Assert.True(ProjectEuler.isPentagonalNumber 40755)
    Assert.True(ProjectEuler.isHexagonalNumber 40755)

[<Fact>]
let ``next number that is triangle, pentagonal and hexagonal is 1533776805`` () =
    let next = ProjectEuler.hexagonalNumbers ()
               |> Seq.skip 143
               |> Seq.skipWhile (fun x -> not (ProjectEuler.isPentagonalNumber x && ProjectEuler.isHexagonalNumber x))
               |> Seq.head
 
    Assert.Equal(1533776805, next)
