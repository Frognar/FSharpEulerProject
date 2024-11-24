module DigitFactorialsTests

open Xunit

[<Fact>]
let ``1 can be written as the sum of factorial of its digits`` () =
    Assert.True(ProjectEuler.isFactorialOfItsDigitSum 1)

[<Fact>]
let ``2 can be written as the sum of factorial of its digits`` () =
    Assert.True(ProjectEuler.isFactorialOfItsDigitSum 2)

[<Fact>]
let ``3 cannot be written as the sum of factorial of its digits`` () =
    Assert.False(ProjectEuler.isFactorialOfItsDigitSum 3)

[<Fact>]
let ``145 can be written as the sum of factorial of its digits`` () =
    Assert.True(ProjectEuler.isFactorialOfItsDigitSum 145)

[<Fact>]
let ``the limit for numbers that can be written as the sum of factorial of its digits is 2177280`` () =
    let nf = [1..9] |> List.fold (*) 1
    Assert.Equal(2177280, Seq.initInfinite (fun i -> i + 1)
    |> Seq.takeWhile (fun x -> x < (nf * x |> string |> String.length))
    |> Seq.rev
    |> Seq.head
    |> (*) nf)
