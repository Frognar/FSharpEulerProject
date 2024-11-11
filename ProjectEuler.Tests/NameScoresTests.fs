module NameScoresTests

open Xunit

[<Fact>]
let ``"COLIN" is worth 3 + 15 + 12 + 9 + 14 = 53`` () =
    Assert.Equal(53, ProjectEuler.nameScore "COLIN")

[<Fact>]
let ``"MARY" is worth 13 + 1 + 18 + 25 = 57`` () =
    Assert.Equal(57, ProjectEuler.nameScore "MARY")
