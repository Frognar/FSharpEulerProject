module SubStringDivisibilityTests

open Xunit

[<Fact>]
let ``0 to 1 pandigital numbers are [10]`` () =
    Assert.StrictEqual([10], ProjectEuler.generatePandigitalNumbers 0 1)

[<Fact>]
let ``permutations of [1] are [[1]]`` () =
    Assert.StrictEqual([[1]], ProjectEuler.permutations [1])

[<Fact>]
let ``permutations of [1; 2] are [[1; 2]; [2; 1]]`` () =
    Assert.StrictEqual([[1; 2]; [2; 1]], ProjectEuler.permutations [1; 2])