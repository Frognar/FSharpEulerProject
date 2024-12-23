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

[<Fact>]
let ``quadratic formula n^2 + an + b with a = 0, b = 1 is f(n) -> n^2 + 1`` () =
    Assert.StrictEqual(
        [0..5] |> List.map (fun n -> n * n + 1),
        [0..5] |> List.map (ProjectEuler.evaluateQuadratic 0 1))

[<Fact>]
let ``quadratic formula n^2 + an + b with a = 1, b = 41 is f(n) -> n^2 + n + 41`` () =
    Assert.StrictEqual(
        [0..5] |> List.map (fun n -> n * n + n + 41),
        [0..5] |> List.map (ProjectEuler.evaluateQuadratic 1 41))

[<Fact>]
let ``quadratic formula n^2 + n + 41 produces primes for n = 0..39`` () =
    Assert.True([0..39]
                |> List.map (ProjectEuler.evaluateQuadratic 1 41)
                |> List.forall ProjectEuler.isPrime)
[<Fact>]
let ``quadratic formula n^2 + n + 41 produces 40 consecutive primes`` () =
    Assert.Equal(40, ProjectEuler.countConsecutivePrimes 1 41)

[<Fact>]
let ``quadratic formula n^2 - 79n + 1601 produces primes for n = 0..79`` () =
    Assert.True([0..79]
                |> List.map (ProjectEuler.evaluateQuadratic -79 1601)
                |> List.forall ProjectEuler.isPrime)

[<Fact>]
let ``quadratic formula n^2 - 79n + 1601 produces 80 consecutive primes`` () =
    Assert.Equal(80, ProjectEuler.countConsecutivePrimes -79 1601)

[<Fact>]
let ``product of a and b for quadratic formula n^2 - an + b, maximizing consecutive primes with a in [-999..999] and b in [-1000..1000], is -59231`` () =
    let rec loop a b (maxN, maxA, maxB) =
        if a > 999 then (maxN, maxA, maxB)
        else if b > 1000 then loop (a + 1) -1000 (maxN, maxA, maxB)
        else
            let n = ProjectEuler.countConsecutivePrimes a b
            if n > maxN then
                loop a (b + 1) (n, a, b)
            else
                loop a (b + 1) (maxN, maxA, maxB)
    
    let _, a, b = loop -999 -1000 (0, 0, 0)
    Assert.Equal(-59231, a * b)