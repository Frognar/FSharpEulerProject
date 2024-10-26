module EvenFibonacciNumbersTests

open Xunit

[<Fact>]
let ``fibonacci sequence up to 0 is empty`` () =
    Assert.StrictEqual([], ProjectEuler.fibonacciUpTo 0)