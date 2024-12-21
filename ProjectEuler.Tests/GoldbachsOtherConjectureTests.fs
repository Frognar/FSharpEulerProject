module GoldbachsOtherConjectureTests

open Xunit

[<Fact>]
let ``9 is odd composite`` () =
    Assert.True(ProjectEuler.isOddComposite 9)

[<Fact>]
let ``15 is odd composite`` () =
    Assert.True(ProjectEuler.isOddComposite 15)

[<Fact>]
let ``7 is not odd composite`` () =
    Assert.False(ProjectEuler.isOddComposite 7)

[<Fact>]
let ``1 is not odd composite`` () =
    Assert.False(ProjectEuler.isOddComposite 2)

[<Fact>]
let ``9 met the Goldbach condition`` () =
    Assert.True(ProjectEuler.isGoldbachTrue 9)

[<Fact>]
let ``15 met the Goldbach condition`` () =
    Assert.True(ProjectEuler.isGoldbachTrue 15)

[<Fact>]
let ``33 met the Goldbach condition`` () =
    Assert.True(ProjectEuler.isGoldbachTrue 33)

[<Fact>]
let ``the smallest number that didn't meet the Goldbach condition is 5777`` () =
    Assert.Equal(5777, ProjectEuler.findSmallestOddComposite ())