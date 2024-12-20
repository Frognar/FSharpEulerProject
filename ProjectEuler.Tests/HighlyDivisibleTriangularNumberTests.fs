module HighlyDivisibleTriangularNumberTests

open Xunit

[<Fact>]
let ``the first triangular number is 1`` () =
    Assert.Equal(1, ProjectEuler.triangularNumbers () |> Seq.head)

[<Fact>]
let ``the second triangular number is 3`` () =
    Assert.Equal(3, ProjectEuler.triangularNumbers () |> Seq.skip 1 |> Seq.head)

[<Fact>]
let ``the seventh triangular number is 28`` () =
    Assert.Equal(28, ProjectEuler.triangularNumbers () |> Seq.skip 6 |> Seq.head)

[<Fact>]
let ``1 is divisible by [1]`` () =
    Assert.StrictEqual([1], ProjectEuler.getDivisors 1)

[<Fact>]
let ``2 is divisible by [1; 2]`` () =
    Assert.StrictEqual([1; 2], ProjectEuler.getDivisors 2)

[<Fact>]
let ``3 is divisible by [1; 3]`` () =
    Assert.StrictEqual([1; 3], ProjectEuler.getDivisors 3)

[<Fact>]
let ``351235123 is divisible by [1; 351235123]`` () =
    Assert.StrictEqual([1; 351235123], ProjectEuler.getDivisors 351235123)

[<Fact>]
let ``the seventh triangular number has over 5 divisors`` () =
    let numberOfDivisors = ProjectEuler.triangularNumbers ()
                           |> Seq.skip 6
                           |> Seq.head
                           |> ProjectEuler.getDivisors
                           |> List.length;

    Assert.True(numberOfDivisors > 5)

[<Fact>]
let ``first triangular number with over 500 divisors is 76576500`` () =
    let triangularNumber = ProjectEuler.triangularNumbers ()
                            |> Seq.skipWhile (fun x -> ProjectEuler.getDivisors x |> List.length < 500)
                            |> Seq.head

    Assert.Equal(76576500, triangularNumber)