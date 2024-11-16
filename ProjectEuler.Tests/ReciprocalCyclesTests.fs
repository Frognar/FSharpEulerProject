module ReciprocalCyclesTests

open Xunit

[<Fact>]
let ``division of 1 by 1 is [0]`` () =
    Assert.StrictEqual([0], ProjectEuler.getRemainderCycle 1 1)

[<Fact>]
let ``division of 1 by 2 is [1; 0]`` () =
    Assert.StrictEqual([1; 0], ProjectEuler.getRemainderCycle 1 2)

[<Fact>]
let ``division of 1 by 3 is [1; 1]`` () =
    Assert.StrictEqual([1; 1], ProjectEuler.getRemainderCycle 1 3)

[<Fact>]
let ``division of 1 by 4 is [1; 2; 0]`` () =
    Assert.StrictEqual([1; 2; 0], ProjectEuler.getRemainderCycle 1 4)

[<Fact>]
let ``division of 1 by 7 is [1; 3; 2; 7; 1]`` () =
    Assert.StrictEqual([1; 3; 2; 6; 4; 5; 1], ProjectEuler.getRemainderCycle 1 7)
