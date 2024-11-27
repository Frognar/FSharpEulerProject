module TruncatablePrimesTests

open Xunit

[<Fact>]
let ``left truncates of 3797 are [797; 97; 7]`` () =
    Assert.StrictEqual([797; 97; 7], ProjectEuler.leftTruncates 3797)

[<Fact>]
let ``right truncates of 3797 are [379; 37; 3]`` () =
    Assert.StrictEqual([379; 37; 3], ProjectEuler.rightTruncates 3797)

[<Fact>]
let ``left and right truncates of 3797 are [797; 97; 7; 379; 37; 3]`` () =
    Assert.StrictEqual([797; 97; 7; 379; 37; 3], ProjectEuler.truncates 3797)

[<Fact>]
let ``3797 is a truncatable prime`` () =
    Assert.True(ProjectEuler.isTruncatablePrime 3797)

[<Fact>]
let ``All truncatable primes are [23; 37; 53; 73; 313; 317; 373; 797; 3137; 3797; 739397]`` () =
    Assert.StrictEqual(
        [23; 37; 53; 73; 313; 317; 373; 797; 3137; 3797; 739397],
        ProjectEuler.truncatablePrimes ())