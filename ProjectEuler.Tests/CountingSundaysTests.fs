module CountingSundaysTests

open Xunit

[<Theory>]
[<InlineData(2)>]
[<InlineData(15)>]
[<InlineData(1993)>]
[<InlineData(2023)>]
let ``a year not divisible by 4 is not a leap year`` year =
    Assert.False(ProjectEuler.isLeapYear year)

[<Theory>]
[<InlineData(4)>]
[<InlineData(16)>]
[<InlineData(2004)>]
let ``a year divided by 4 is a leap year`` year =
    Assert.True(ProjectEuler.isLeapYear year)

[<Theory>]
[<InlineData(100)>]
[<InlineData(1900)>]
[<InlineData(2100)>]
let ``but not on a century`` year =
    Assert.False(ProjectEuler.isLeapYear year)

[<Theory>]
[<InlineData(400)>]
[<InlineData(2000)>]
[<InlineData(2400)>]
let ``unless it is divisible by 400`` year =
    Assert.True(ProjectEuler.isLeapYear year)

[<Fact>]
let ``if 1st January is Monday, the 1st of February is Thursday`` () =
    Assert.Equal(ProjectEuler.Thursday, ProjectEuler.nextDay ProjectEuler.Monday 31)

[<Fact>]
let ``if 1st of February is Thursday in a leap year, the 1st of March is Friday`` () =
    Assert.Equal(ProjectEuler.Friday, ProjectEuler.nextDay ProjectEuler.Thursday 29)

[<Fact>]
let ``if 1st of February is Thursday in a non-leap year, the 1st of March is Thursday`` () =
    Assert.Equal(ProjectEuler.Thursday, ProjectEuler.nextDay ProjectEuler.Thursday 28)