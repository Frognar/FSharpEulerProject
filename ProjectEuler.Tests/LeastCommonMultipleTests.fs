module LeastCommonMultipleTests

open Xunit

[<Fact>]
let ``gcd for 1 and 1 is 1`` () =
    Assert.Equal(1L, ProjectEuler.greatestCommonDivisor 1 1)

[<Fact>]
let ``gcd for 2 and 2 is 2`` () =
    Assert.Equal(2L, ProjectEuler.greatestCommonDivisor 2 2)

[<Fact>]
let ``gcd for 4 and 2 is 2`` () =
    Assert.Equal(2L, ProjectEuler.greatestCommonDivisor 4 2)

[<Fact>]
let ``lcm for [] is 0`` () =
    Assert.Equal(0L, ProjectEuler.leastCommonMultiple [])

[<Fact>]
let ``lcm for [4] is 4`` () =
    Assert.Equal(4L, ProjectEuler.leastCommonMultiple [4])

[<Fact>]
let ``lcm for [1; 1] is 1`` () =
    Assert.Equal(1L, ProjectEuler.leastCommonMultiple [1; 1])

[<Fact>]
let ``lcm for [1..3] is 6`` () =
    Assert.Equal(6L, ProjectEuler.leastCommonMultiple [1..3])

[<Fact>]
let ``lcm for [1..10] is 2520`` () =
    Assert.Equal(2520L, ProjectEuler.leastCommonMultiple [1..10])

[<Fact>]
let ``lcm for [1..20] is 232792560`` () =
    Assert.Equal(232792560L, ProjectEuler.leastCommonMultiple [1..20])