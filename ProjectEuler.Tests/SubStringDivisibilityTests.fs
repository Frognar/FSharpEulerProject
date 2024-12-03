module SubStringDivisibilityTests

open Xunit

[<Fact>]
let ``0 to 1 pandigital numbers are [10]`` () =
    Assert.StrictEqual([10], ProjectEuler.generatePandigitalNumbers 0 1)