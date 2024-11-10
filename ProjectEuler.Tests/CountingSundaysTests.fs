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
let ``after monday in 31 day month the next day is thursday`` () =
    Assert.Equal(ProjectEuler.Thursday, ProjectEuler.nextDay ProjectEuler.Monday 31)

[<Fact>]
let ``after tuesday in 31 day month the next day is friday`` () =
    Assert.Equal(ProjectEuler.Friday, ProjectEuler.nextDay ProjectEuler.Tuesday 31)

[<Fact>]
let ``after wednesday in 31 day month the next day is saturday`` () =
    Assert.Equal(ProjectEuler.Saturday, ProjectEuler.nextDay ProjectEuler.Wednesday 31)

[<Fact>]
let ``after thursday in 31 day month the next day is sunday`` () =
    Assert.Equal(ProjectEuler.Sunday, ProjectEuler.nextDay ProjectEuler.Thursday 31)

[<Fact>]
let ``after friday in 31 day month the next day is monday`` () =
    Assert.Equal(ProjectEuler.Monday, ProjectEuler.nextDay ProjectEuler.Friday 31)

[<Fact>]
let ``after saturday in 31 day month the next day is tuesday`` () =
    Assert.Equal(ProjectEuler.Tuesday, ProjectEuler.nextDay ProjectEuler.Saturday 31)

[<Fact>]
let ``after sunday in 31 day month the next day is wednesday`` () =
    Assert.Equal(ProjectEuler.Wednesday, ProjectEuler.nextDay ProjectEuler.Sunday 31)

[<Fact>]
let ``after monday in 30 day month the next day is wednesday`` () =
    Assert.Equal(ProjectEuler.Wednesday, ProjectEuler.nextDay ProjectEuler.Monday 30)

[<Fact>]
let ``after tuesday in 30 day month the next day is thursday`` () =
    Assert.Equal(ProjectEuler.Thursday, ProjectEuler.nextDay ProjectEuler.Tuesday 30)

[<Fact>]
let ``after wednesday in 30 day month the next day is friday`` () =
    Assert.Equal(ProjectEuler.Friday, ProjectEuler.nextDay ProjectEuler.Wednesday 30)

[<Fact>]
let ``after thursday in 30 day month the next day is saturday`` () =
    Assert.Equal(ProjectEuler.Saturday, ProjectEuler.nextDay ProjectEuler.Thursday 30)

[<Fact>]
let ``after friday in 30 day month the next day is sunday`` () =
    Assert.Equal(ProjectEuler.Sunday, ProjectEuler.nextDay ProjectEuler.Friday 30)

[<Fact>]
let ``after saturday in 30 day month the next day is monday`` () =
    Assert.Equal(ProjectEuler.Monday, ProjectEuler.nextDay ProjectEuler.Saturday 30)

[<Fact>]
let ``after sunday in 30 day month the next day is tuesday`` () =
    Assert.Equal(ProjectEuler.Tuesday, ProjectEuler.nextDay ProjectEuler.Sunday 30)
