module Tests

open Xunit

[<Fact>]
let ``sum of multiples of 3 and 5 for natural numbers below 3 is 0`` () =
    Assert.Equal(0, ProjectEuler.sumOfMultiplesOf3And5 3)

[<Fact>]
let ``sum of multiples of 3 and 5 for natural numbers below 4 is 3`` () =
    Assert.Equal(3, ProjectEuler.sumOfMultiplesOf3And5 4)

[<Fact>]
let ``sum of multiples of 3 and 5 for numbers below 6 is 8`` () =
    Assert.Equal(8, ProjectEuler.sumOfMultiplesOf3And5 6)

[<Fact>]
let ``sum of multiples of 3 and 5 for numbers below 10 is 23`` () =
    Assert.Equal(23, ProjectEuler.sumOfMultiplesOf3And5 10)


[<Fact>]
let ``sum of multiples of 3 and 5 for numbers below 1000 is 233168`` () =
    Assert.Equal(233168, ProjectEuler.sumOfMultiplesOf3And5 1000)
