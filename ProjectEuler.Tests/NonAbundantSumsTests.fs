module NonAbundantSumsTests

open Xunit

[<Fact>]
let ``Two is not an abundant number`` () =
    Assert.False(ProjectEuler.isAbundant 2)

[<Fact>]
let ``Twelve is an abundant number`` () =
    Assert.True(ProjectEuler.isAbundant 12)
