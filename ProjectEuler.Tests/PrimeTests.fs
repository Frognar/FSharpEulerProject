module PrimeTests

open Xunit

[<Fact>]
let ``2 is prime`` () =
    Assert.True(ProjectEuler.isPrime 2)

