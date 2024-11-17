module QuadraticPrimesTests

open Xunit

[<Fact>]
let ``quadratic formula n^2 + an + b with a = b = 0 is f(n) -> n^2`` () =
    Assert.StrictEqual(
        [0..5] |> List.map (fun n -> n * n),
        [0..5] |> List.map (ProjectEuler.evaluateQuadratic 0 0))

[<Fact>]
let ``quadratic formula n^2 + an + b with a = 1, b = 0 is f(n) -> n^2 + n`` () =
    Assert.StrictEqual(
        [0..5] |> List.map (fun n -> n * n + n),
        [0..5] |> List.map (ProjectEuler.evaluateQuadratic 1 0))