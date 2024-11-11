module AmicableNumbersTests

open Xunit

[<Fact>]
let ``proper divisors of 220 are [1; 2; 4; 5; 10; 11; 20; 22; 44; 55; 110]`` () =
    Assert.StrictEqual([1; 2; 4; 5; 10; 11; 20; 22; 44; 55; 110],
                       ProjectEuler.properDivisorsOf 220)

[<Fact>]
let ``sum of proper divisors of 220 is 284`` () =
    Assert.Equal(284, ProjectEuler.sumOfProperDivisorsOf 220)

[<Fact>]
let ``number 220 is amicable`` () =
    Assert.True(ProjectEuler.isAmicable 220)

[<Fact>]
let ``number 2 is not amicable`` () =
    Assert.False(ProjectEuler.isAmicable 2)

[<Fact>]
let ``number 6 is not amicable`` () =
    Assert.False(ProjectEuler.isAmicable 6)
