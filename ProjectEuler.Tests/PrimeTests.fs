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

[<Fact>]
let ``6 is not prime`` () =
    Assert.False(ProjectEuler.isPrime 6)

[<Fact>]
let ``7 is prime`` () =
    Assert.True(ProjectEuler.isPrime 7)

[<Fact>]
let ``8 is not prime`` () =
    Assert.False(ProjectEuler.isPrime 8)

[<Fact>]
let ``9 is not prime`` () =
    Assert.False(ProjectEuler.isPrime 9)

[<Fact>]
let ``10 is not prime`` () =
    Assert.False(ProjectEuler.isPrime 10)

[<Fact>]
let ``11 is prime`` () =
    Assert.True(ProjectEuler.isPrime 11)

[<Fact>]
let ``12 is not prime`` () =
    Assert.False(ProjectEuler.isPrime 12)

[<Fact>]
let ``13 is prime`` () =
    Assert.True(ProjectEuler.isPrime 13)

[<Fact>]
let ``14 is not prime`` () =
    Assert.False(ProjectEuler.isPrime 14)

[<Fact>]
let ``15 is not prime`` () =
    Assert.False(ProjectEuler.isPrime 15)

[<Fact>]
let ``16 is not prime`` () =
    Assert.False(ProjectEuler.isPrime 16)

[<Fact>]
let ``17 is prime`` () =
    Assert.True(ProjectEuler.isPrime 17)

[<Fact>]
let ``18 is not prime`` () =
    Assert.False(ProjectEuler.isPrime 18)

[<Fact>]
let ``19 is prime`` () =
    Assert.True(ProjectEuler.isPrime 19)

[<Fact>]
let ``20 is not prime`` () =
    Assert.False(ProjectEuler.isPrime 20)

[<Fact>]
let ``first 10 prime numbers are [2; 3; 5; 7; 11; 13; 17; 19; 23; 29]`` () =
    Assert.StrictEqual([2; 3; 5; 7; 11; 13; 17; 19; 23; 29], ProjectEuler.generatePrimes () |> Seq.take 10 |> Seq.toList)

[<Fact>]
let ``10001st prime number is 104743`` () =
    Assert.Equal(104743, ProjectEuler.generatePrimes () |> Seq.take 10001 |> Seq.toList |> List.last)
