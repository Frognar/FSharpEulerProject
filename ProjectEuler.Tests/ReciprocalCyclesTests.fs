module ReciprocalCyclesTests

open Xunit

[<Fact>]
let ``division of 1 by 1 is [0]`` () =
    Assert.StrictEqual([0], ProjectEuler.getRemainderCycle 1 1)

