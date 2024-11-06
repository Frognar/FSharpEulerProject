module PowerDigitSumTests

open Xunit

[<Fact>]
let ``sum of digits of 2^0 is 1`` () =
    Assert.Equal(1, ProjectEuler.powerDigitSum 2 0)

[<Fact>]
let ``sum of digits of 2^1 is 2`` () =
    Assert.Equal(2, ProjectEuler.powerDigitSum 2 1)

[<Fact>]
let ``sum of digits of 3^1 is 3`` () =
    Assert.Equal(3, ProjectEuler.powerDigitSum 3 1)

[<Fact>]
let ``sum of digits of 2^2 is 4`` () =
    Assert.Equal(4, ProjectEuler.powerDigitSum 2 2)

[<Fact>]
let ``sum of digits of 3^2 is 9`` () =
    Assert.Equal(9, ProjectEuler.powerDigitSum 3 2)

[<Fact>]
let ``sum of digits of 2^4 is 7`` () =
    Assert.Equal(7, ProjectEuler.powerDigitSum 2 4)
