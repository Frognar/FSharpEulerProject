module SelfPowersTests

open Xunit

[<Fact>]
let ``last ten digits of 1^1 + 2^2 + ... + 10^10 is 0405071317`` () =
    Assert.Equal(0405071317L, ProjectEuler.lastTenDigitsOfSeries 10)