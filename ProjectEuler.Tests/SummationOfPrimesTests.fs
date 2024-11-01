module SummationOfPrimesTests

open Xunit

[<Fact>]
let ``primes up to 1 is empty`` () =
    Assert.Empty(ProjectEuler.primesUpTo 1)

[<Fact>]
let ``primes up to 2 are [2]`` () =
    Assert.StrictEqual([2], ProjectEuler.primesUpTo 2)
