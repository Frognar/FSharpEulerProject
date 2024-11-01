module SummationOfPrimesTests

open Xunit

[<Fact>]
let ``primes up to 1 is empty`` () =
    Assert.Empty(ProjectEuler.primesUpTo 1)

[<Fact>]
let ``primes up to 2 are [2]`` () =
    Assert.StrictEqual([2], ProjectEuler.primesUpTo 2)

[<Fact>]
let ``primes up to 3 are [2; 3]`` () =
    Assert.StrictEqual([2; 3], ProjectEuler.primesUpTo 3)

[<Fact>]
let ``primes up to 4 are [2; 3]`` () =
    Assert.StrictEqual([2; 3], ProjectEuler.primesUpTo 4)

[<Fact>]
let ``primes up to 100 are [2; 3; 5; 7; 11; 13; 17; 19; 23; 29; 31; 37; 41; 43; 47; 53; 59; 61; 67; 71; 73; 79; 83; 89; 97]`` () =
    let expected = [2; 3; 5; 7; 11; 13; 17; 19; 23; 29; 31; 37; 41; 43; 47; 53; 59; 61; 67; 71; 73; 79; 83; 89; 97]
    Assert.StrictEqual(expected, ProjectEuler.primesUpTo 100)

