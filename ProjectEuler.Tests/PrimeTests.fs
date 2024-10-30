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

[<Fact>]
let ``4 is not prime`` () =
    Assert.False(ProjectEuler.isPrime 4)

[<Fact>]
let ``5 is prime`` () =
    Assert.True(ProjectEuler.isPrime 5)

