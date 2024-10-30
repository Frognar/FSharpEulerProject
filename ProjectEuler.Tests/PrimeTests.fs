module PrimeTests

open Xunit

[<Fact>]
let ``1 is not prime`` () =
    Assert.False(ProjectEuler.isPrime 1)

[<Fact>]
let ``2 is prime`` () =
    Assert.True(ProjectEuler.isPrime 2)

[<Fact>]
let ``3 is prime`` () =
    Assert.True(ProjectEuler.isPrime 3)

