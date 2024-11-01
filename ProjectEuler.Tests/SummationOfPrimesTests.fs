module SummationOfPrimesTests

open Xunit

[<Fact>]
let ``primes up to 1 is empty`` () =
    Assert.Empty(ProjectEuler.primesUpTo 1)
