module NonAbundantSumsTests

open Xunit

[<Fact>]
let ``Two is not an abundant number`` () =
    Assert.False(ProjectEuler.isAbundant 2)
