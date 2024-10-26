module PrimeFactorsTests

open Xunit

[<Fact>]
let ``prime factors of 1 is []`` () =
    Assert.Empty(ProjectEuler.primeFactors 1)

[<Fact>]
let ``prime factors of 2 is [2]`` () =
    Assert.StrictEqual(([2]: int64 list), ProjectEuler.primeFactors 2)

[<Fact>]
let ``prime factors of 3 is [3]`` () =
    Assert.StrictEqual(([3]: int64 list), ProjectEuler.primeFactors 3)

[<Fact>]
let ``prime factors of 4 is [2; 2]`` () =
    Assert.StrictEqual(([2; 2]: int64 list), ProjectEuler.primeFactors 4)

[<Fact>]
let ``prime factors of 5 is [5]`` () =
    Assert.StrictEqual(([5]: int64 list), ProjectEuler.primeFactors 5)

[<Fact>]
let ``prime factors of 6 is [2; 3]`` () =
    Assert.StrictEqual(([2; 3]: int64 list), ProjectEuler.primeFactors 6)

[<Fact>]
let ``prime factors of 7 is [7]`` () =
    Assert.StrictEqual(([7]: int64 list), ProjectEuler.primeFactors 7)

[<Fact>]
let ``prime factors of 8 is [2; 2; 2]`` () =
    Assert.StrictEqual(([2; 2; 2]: int64 list), ProjectEuler.primeFactors 8)

[<Fact>]
let ``prime factors of 9 is [3; 3]`` () =
    Assert.StrictEqual(([3; 3]: int64 list), ProjectEuler.primeFactors 9)

[<Fact>]
let ``prime factors of 100 is [2; 2; 5; 5]`` () =
    Assert.StrictEqual(([2; 2; 5; 5]: int64 list), ProjectEuler.primeFactors 100)

[<Fact>]
let ``prime factors of 13195 is [5; 29]`` () =
    Assert.StrictEqual(([5; 7; 13; 29]: int64 list), ProjectEuler.primeFactors 13195)

[<Fact>]
let ``largest prime factor of 13195 is 29`` () =
    Assert.Equal((29: int64), ProjectEuler.largestPrimeFactor 13195)

[<Fact>]
let ``largest prime factor of 600851475143 is 6857`` () =
    Assert.Equal((6857: int64), ProjectEuler.largestPrimeFactor 600851475143L)