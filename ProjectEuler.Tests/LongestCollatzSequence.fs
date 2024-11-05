module LongestCollatzSequence

open Xunit

[<Fact>]
let ``next Collatz number after 13 is 40`` () =
    Assert.Equal(40, ProjectEuler.nextCollatz 13)

[<Fact>]
let ``next Collatz number after 40 is 20`` () =
    Assert.Equal(20, ProjectEuler.nextCollatz 40)
