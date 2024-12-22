module DistinctPrimesFactorsTests

open Xunit

[<Fact>]
let ``Test prime factors of a number`` () =
    Assert.StrictEqual([2L; 7L], ProjectEuler.primeFactors 14)
    Assert.StrictEqual([3L; 5L], ProjectEuler.primeFactors 15)
    Assert.StrictEqual([2L; 2L; 7L; 23L], ProjectEuler.primeFactors 644)

[<Fact>]
let ``Test count of distinct prime factors`` () =
    Assert.True(ProjectEuler.hasDistinctPrimeFactors 2 14)
    Assert.True(ProjectEuler.hasDistinctPrimeFactors 3 644)
    Assert.False(ProjectEuler.hasDistinctPrimeFactors 4 644)

[<Fact>]
let ``Find first sequence of consecutive numbers`` () =
    Assert.Equal(14L, ProjectEuler.findConsecutiveNumbers 2 2)
    Assert.Equal(644L, ProjectEuler.findConsecutiveNumbers 3 3)
    Assert.Equal(134043L, ProjectEuler.findConsecutiveNumbers 4 4)
