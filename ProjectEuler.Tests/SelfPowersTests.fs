module SelfPowersTests

open Xunit
    
[<Fact>]
let ``modPow 9 ^ 9 % 1000 = 489`` () =
    Assert.Equal(489I, ProjectEuler.modPow 9I 9 1000I)
    
[<Fact>]
let ``modPow 19 ^ 19 % 1000 = 979`` () =
    Assert.Equal(979I, ProjectEuler.modPow 19I 19 1000I)

[<Fact>]
let ``last ten digits of 1^1 + 2^2 + ... + 10^10 is 0405071317`` () =
    Assert.Equal(0405071317I, ProjectEuler.lastTenDigitsOfSeries 10)

[<Fact>]
let ``last ten digits of 1^1 + 2^2 + ... + 1000^1000 is 9110846700`` () =
    Assert.Equal(9110846700I, ProjectEuler.lastTenDigitsOfSeries 1000)