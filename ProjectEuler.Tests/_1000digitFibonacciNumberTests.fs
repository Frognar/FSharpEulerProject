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

[<Fact>]
let ``the first Fibonacci term with 1 digit is at index 1`` () =
    Assert.Equal(1, ProjectEuler.indexOfFirstTermWithDigits 1)

[<Fact>]
let ``the first Fibonacci term with 3 digits is at index 12`` () =
    Assert.Equal(12, ProjectEuler.indexOfFirstTermWithDigits 3)

[<Fact>]
let ``the first Fibonacci term with 4 digits is at index 17`` () =
    Assert.Equal(17, ProjectEuler.indexOfFirstTermWithDigits 4)

[<Fact>]
let ``the first Fibonacci term with 1000 digits is at index 4782`` () =
    Assert.Equal(4782, ProjectEuler.indexOfFirstTermWithDigits 1000)
