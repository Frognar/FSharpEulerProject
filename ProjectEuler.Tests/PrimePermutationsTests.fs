module PrimePermutationsTests

open Xunit

[<Fact>]
let ``isPrime correctly identifies prime numbers`` () =
    Assert.True(ProjectEuler.isPrime 2)
    Assert.True(ProjectEuler.isPrime 3)
    Assert.True(ProjectEuler.isPrime 1487)
    Assert.False(ProjectEuler.isPrime 1)
    Assert.False(ProjectEuler.isPrime 4)
    Assert.False(ProjectEuler.isPrime 1000)