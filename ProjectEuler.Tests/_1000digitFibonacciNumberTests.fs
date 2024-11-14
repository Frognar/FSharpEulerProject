module _1000digitFibonacciNumberTests

open Xunit

[<Fact>]
let ``digit count of 1 should be 1`` () =
    Assert.Equal(1, ProjectEuler.digitCount 1I)

[<Fact>]
let ``digit count of 10 should be 2`` () =
    Assert.Equal(2, ProjectEuler.digitCount 10I)

[<Fact>]
let ``digit count of 1000 should be 4`` () =
    Assert.Equal(4, ProjectEuler.digitCount 1000I)
