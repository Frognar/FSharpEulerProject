module EvenFibonacciNumbersTests

open Xunit

[<Fact>]
let ``fibonacci sequence up to 0 is empty`` () =
    Assert.StrictEqual([], ProjectEuler.fibonacciUpTo 0)

[<Fact>]
let ``fibonacci sequence up to 1 is [1; 1]`` () =
    Assert.StrictEqual([1; 1], ProjectEuler.fibonacciUpTo 1)

[<Fact>]
let ``fibonacci sequence up to 2 is [1; 1; 2]`` () =
    Assert.StrictEqual([1; 1; 2], ProjectEuler.fibonacciUpTo 2)


[<Fact>]
let ``fibonacci sequence up to 3 is [1; 1; 2; 3]`` () =
    Assert.StrictEqual([1; 1; 2; 3], ProjectEuler.fibonacciUpTo 3)


[<Fact>]
let ``fibonacci sequence up to 4 is [1; 1; 2; 3]`` () =
    Assert.StrictEqual([1; 1; 2; 3], ProjectEuler.fibonacciUpTo 4)


[<Fact>]
let ``fibonacci sequence up to 5 is [1; 1; 2; 3; 5]`` () =
    Assert.StrictEqual([1; 1; 2; 3; 5], ProjectEuler.fibonacciUpTo 5)


[<Fact>]
let ``fibonacci sequence up to 100 is [1; 1; 2; 3; 5; 8; 13; 21; 34; 55; 89]`` () =
    Assert.StrictEqual([1; 1; 2; 3; 5; 8; 13; 21; 34; 55; 89], ProjectEuler.fibonacciUpTo 100)

[<Fact>]
let ``sum of even fibonacci numbers up to 1 is 0`` () =
    Assert.Equal(0, ProjectEuler.sumOfEvenFibonacciNumbers 1)

[<Fact>]
let ``sum of even fibonacci numbers up to 2 is 2`` () =
    Assert.Equal(2, ProjectEuler.sumOfEvenFibonacciNumbers 2)

[<Fact>]
let ``sum of even fibonacci numbers up to 3 is 2`` () =
    Assert.Equal(2, ProjectEuler.sumOfEvenFibonacciNumbers 3)

[<Fact>]
let ``sum of even fibonacci numbers up to 100 is 44`` () =
    Assert.Equal(44, ProjectEuler.sumOfEvenFibonacciNumbers 100)

[<Fact>]
let ``sum of even fibonacci numbers up to 4_000_000 is 4613732`` () =
    Assert.Equal(4613732, ProjectEuler.sumOfEvenFibonacciNumbers 4_000_000)
