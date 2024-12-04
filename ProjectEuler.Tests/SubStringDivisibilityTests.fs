module SubStringDivisibilityTests

open Xunit

[<Fact>]
let ``permutations of [1] are [[1]]`` () =
    Assert.StrictEqual([[1]], ProjectEuler.permutations [1] |> Seq.toList)

[<Fact>]
let ``permutations of [1; 2] are [[1; 2]; [2; 1]]`` () =
    Assert.StrictEqual([[1; 2]; [2; 1]], ProjectEuler.permutations [1; 2] |> Seq.toList)

[<Fact>]
let ``digits [1; 2; 3] form a number 123`` () =
    Assert.Equal(123L, ProjectEuler.digitsToNumber [1; 2; 3])

[<Fact>]
let ``digits [1; 4; 0; 6; 3; 5; 7; 2; 8; 9] has interesting sub-string divisibility property`` () =
    Assert.True(ProjectEuler.hasInterestingSubStringDivisibility [1; 4; 0; 6; 3; 5; 7; 2; 8; 9])

[<Fact>]
let ``the sum of all 0 to 9 pandigital numbers with interesting sub-string divisibility property is 16695334890`` () =
    Assert.Equal(16695334890L, ProjectEuler.permutations [0L..9L]
                 |> Seq.filter ProjectEuler.hasInterestingSubStringDivisibility
                 |> Seq.map ProjectEuler.digitsToNumber
                 |> Seq.map int64
                 |> Seq.sum)