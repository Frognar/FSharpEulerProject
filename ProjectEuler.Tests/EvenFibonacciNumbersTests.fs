module EvenFibonacciNumbersTests

open Xunit

[<Fact>]
let ``fibonacci sequence up to 0 is empty`` () =
    Assert.StrictEqual([], ProjectEuler.fibonacciUpTo 0)

[<Fact>]
let ``fibonacci sequence up to 1 is [1]`` () =
    Assert.StrictEqual([1], ProjectEuler.fibonacciUpTo 1)

[<Fact>]
let ``fibonacci sequence up to 2 is [1; 2]`` () =
    Assert.StrictEqual([1; 2], ProjectEuler.fibonacciUpTo 2)
