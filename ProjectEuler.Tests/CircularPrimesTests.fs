module CircularPrimesTests

open Xunit

[<Fact>]
let ``145 can be rotated to 451`` () =
    Assert.Contains(451, ProjectEuler.rotate 145)

[<Fact>]
let ``145 can be rotated to 514`` () =
    Assert.Contains(514, ProjectEuler.rotate 145)
    
[<Fact>]
let ``there are 55 circular primes below one million`` () =
    Assert.Equal(55,
                 ProjectEuler.primesUpTo 1_000_000
                 |> List.map (fun x -> (x, ProjectEuler.rotate x))
                 |> List.filter (fun (_, rotations) -> (rotations |> Seq.forall ProjectEuler.isPrime))
                 |> List.map fst
                 |> List.length)