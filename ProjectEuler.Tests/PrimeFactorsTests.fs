module PrimeFactorsTests

open Xunit

[<Fact>]
let ``prime factors of 1 is []`` () =
    Assert.Empty(ProjectEuler.primeFactors 1)

[<Fact>]
let ``prime factors of 2 is [2]`` () =
    Assert.StrictEqual([2], ProjectEuler.primeFactors 2)

[<Fact>]
let ``prime factors of 3 is [3]`` () =
    Assert.StrictEqual([3], ProjectEuler.primeFactors 3)

[<Fact>]
let ``prime factors of 4 is [2; 2]`` () =
    Assert.StrictEqual([2; 2], ProjectEuler.primeFactors 4)

[<Fact>]
let ``prime factors of 5 is [5]`` () =
    Assert.StrictEqual([5], ProjectEuler.primeFactors 5)

[<Fact>]
let ``prime factors of 6 is [2; 3]`` () =
    Assert.StrictEqual([2; 3], ProjectEuler.primeFactors 6)

[<Fact>]
let ``prime factors of 7 is [7]`` () =
    Assert.StrictEqual([7], ProjectEuler.primeFactors 7)

[<Fact>]
let ``prime factors of 8 is [2; 2; 2]`` () =
    Assert.StrictEqual([2; 2; 2], ProjectEuler.primeFactors 8)

[<Fact>]
let ``prime factors of 9 is [3; 3]`` () =
    Assert.StrictEqual([3; 3], ProjectEuler.primeFactors 9)