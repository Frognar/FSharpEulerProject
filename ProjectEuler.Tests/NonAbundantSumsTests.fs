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