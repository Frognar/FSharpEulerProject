module AmicableNumbersTests

open Xunit

[<Fact>]
let ``proper divisors of 220 are [1; 2; 4; 5; 10; 11; 20; 22; 44; 55; 110]`` () =
    Assert.StrictEqual([1; 2; 4; 5; 10; 11; 20; 22; 44; 55; 110],
                       ProjectEuler.properDivisorsOf 220)

[<Fact>]
let ``sum of proper divisors of 220 is 284`` () =
    Assert.Equal(284, ProjectEuler.sumOfProperDivisorsOf 220)