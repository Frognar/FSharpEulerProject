module SummationOfPrimesTests

open Xunit

[<Fact>]
let ``primes up to 1 is empty`` () =
    Assert.Empty(ProjectEuler.primesUpTo 1)

[<Fact>]
let ``primes up to 2 are [2]`` () =
    let expected: int64 list = [2]
    Assert.StrictEqual(expected, ProjectEuler.primesUpTo 2)

[<Fact>]
let ``primes up to 3 are [2; 3]`` () =
    let expected: int64 list = [2; 3]
    Assert.StrictEqual(expected, ProjectEuler.primesUpTo 3)

[<Fact>]
let ``primes up to 4 are [2; 3]`` () =
    let expected: int64 list = [2; 3]
    Assert.StrictEqual(expected, ProjectEuler.primesUpTo 4)

[<Fact>]
let ``primes up to 100 are [2; 3; 5; 7; 11; 13; 17; 19; 23; 29; 31; 37; 41; 43; 47; 53; 59; 61; 67; 71; 73; 79; 83; 89; 97]`` () =
    let expected: int64 list = [2; 3; 5; 7; 11; 13; 17; 19; 23; 29; 31; 37; 41; 43; 47; 53; 59; 61; 67; 71; 73; 79; 83; 89; 97]
    Assert.StrictEqual(expected, ProjectEuler.primesUpTo 100L)

[<Fact>]
let ``sum of all primes below 100_000 is 454396537`` () =
    Assert.Equal(454396537L, ProjectEuler.primesUpTo 100_000 |> List.sum)

[<Fact>]
let ``sum of all primes below 200_000 is 1709600813`` () =
    Assert.Equal(1709600813L, ProjectEuler.primesUpTo 200_000 |> List.sum)

[<Fact>]
let ``sum of all primes below 1million is 142913828922`` () =
    Assert.Equal(37550402023L, ProjectEuler.primesUpTo 1000000 |> List.sum)

[<Fact>]
let ``sum of all primes below 2million is 142913828922`` () =
    Assert.Equal(142913828922L, ProjectEuler.primesUpTo 2000000 |> List.sum)