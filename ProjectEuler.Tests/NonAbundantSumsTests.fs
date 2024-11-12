module NonAbundantSumsTests

open Xunit

[<Fact>]
let ``Two is not an abundant number`` () =
    Assert.False(ProjectEuler.isAbundant 2)

[<Fact>]
let ``Twelve is an abundant number`` () =
    Assert.True(ProjectEuler.isAbundant 12)

[<Fact>]
let ``Eighteen is an abundant number`` () =
    Assert.True(ProjectEuler.isAbundant 18)

[<Fact>]
let ``Three can be written as the sum of two numbers from list [1; 2; 3]`` () =
    let numbers = [1; 2; 3]
    Assert.True(ProjectEuler.canBeWrittenAsSumOf2NumbersFrom numbers 3)

[<Fact>]
let ``Three cannot be written as the sum of two numbers from list [1; 3]`` () =
    let numbers = [1; 3]
    Assert.False(ProjectEuler.canBeWrittenAsSumOf2NumbersFrom numbers 3)

[<Fact>]
let ``abundant numbers up to 20 are [12; 18; 20]`` () =
    Assert.StrictEqual([12; 18; 20], ProjectEuler.abundantNumbersUpTo 20)

[<Fact>]
let ``limited sums of two numbers from [1; 2; 5; 6] limited to 10 are [2; 3; 6; 7; 4; 8; 10]`` () =
    Assert.StrictEqual([2; 3; 6; 7; 4; 8; 10], ProjectEuler.limitedSumsOfTwo [1; 2; 5; 6] 10 |> Seq.toList)

[<Fact>]
let ``the sum of all the positive integers which cannot be written as the sum of two abundant numbers is 4,179,871`` () =
    let limit = 28123
    let abundantNumbers = ProjectEuler.abundantNumbersUpTo limit
    let sumSet = ProjectEuler.limitedSumsOfTwo abundantNumbers limit
    Assert.Equal(4179871, [1..limit]
                 |> List.filter (fun n -> not (sumSet.Contains(n)))
                 |> List.sum)