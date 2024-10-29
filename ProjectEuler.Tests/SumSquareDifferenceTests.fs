module SumSquareDifferenceTests

open Xunit

[<Fact>]
let ``sum of the squares of the first 0 natural numbers is 0`` () =
    Assert.Equal(0, ProjectEuler.sumOfSquares [])

[<Fact>]
let ``sum of the squares of the first 1 natural numbers is 1`` () =
    Assert.Equal(1, ProjectEuler.sumOfSquares [1])

[<Fact>]
let ``sum of the squares of the first 2 natural numbers is 5`` () =
    Assert.Equal(5, ProjectEuler.sumOfSquares [1..2])

[<Fact>]
let ``sum of the squares of the first 10 natural numbers is 385`` () =
    Assert.Equal(385, ProjectEuler.sumOfSquares [1..10])

[<Fact>]
let ``square of the sum of the first 0 natural numbers is 0`` () =
    Assert.Equal(0, ProjectEuler.squareOfSum [])

[<Fact>]
let ``square of the sum of the first 1 natural numbers is 1`` () =
    Assert.Equal(1, ProjectEuler.squareOfSum [1])

[<Fact>]
let ``square of the sum of the first 2 natural numbers is 9`` () =
    Assert.Equal(9, ProjectEuler.squareOfSum [1..2])

[<Fact>]
let ``square of the sum of the first 10 natural numbers is 3025`` () =
    Assert.Equal(3025, ProjectEuler.squareOfSum [1..10])

[<Fact>]
let ``difference between the sum of the squares of the first 10 natural numbers and the square of the sum id 2630`` () =
    Assert.Equal(2640, ProjectEuler.squareOfSum [1..10] - ProjectEuler.sumOfSquares [1..10])

[<Fact>]
let ``difference between the sum of the squares of the first 100 natural numbers and the square of the sum id 25164150`` () =
    Assert.Equal(25164150, ProjectEuler.squareOfSum [1..100] - ProjectEuler.sumOfSquares [1..100])