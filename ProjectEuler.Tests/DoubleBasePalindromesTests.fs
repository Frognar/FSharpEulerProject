module DoubleBasePalindromesTests

open Xunit

[<Fact>]
let ``1 in base 2 is 1`` () =
    Assert.Equal("1", ProjectEuler.toBase2 1)

[<Fact>]
let ``2 in base 2 is 10`` () =
    Assert.Equal("10", ProjectEuler.toBase2 2)

[<Fact>]
let ``3 in base 2 is 11`` () =
    Assert.Equal("11", ProjectEuler.toBase2 3)

[<Fact>]
let ``585 in base 2 is 1001001001`` () =
    Assert.Equal("1001001001", ProjectEuler.toBase2 585)

[<Fact>]
let ``1 is palindrome in both base 10 and base 2`` () =
    Assert.True(ProjectEuler.isDoubleBasePalindrome 1)

[<Fact>]
let ``2 is not palindrome in base 2`` () =
    Assert.False(ProjectEuler.isDoubleBasePalindrome 2)

[<Fact>]
let ``3 is palindrome in both base 10 and base 2`` () =
    Assert.True(ProjectEuler.isDoubleBasePalindrome 3)

[<Fact>]
let ``11 is not palindrome in base 2`` () =
    Assert.False(ProjectEuler.isDoubleBasePalindrome 11)