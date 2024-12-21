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