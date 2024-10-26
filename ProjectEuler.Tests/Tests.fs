module Tests

open Xunit

[<Fact>]
let ``sum of multiples of 3 and 5 for natural numbers below 3 is 0`` () =
    Assert.Equal(0, ProjectEuler.sumOfMultiplesOf3And5 3)

[<Fact>]
let ``sum of multiples of 3 and 5 for natural numbers below 4 is 3`` () =
    Assert.Equal(3, ProjectEuler.sumOfMultiplesOf3And5 4)
