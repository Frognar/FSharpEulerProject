module LargestPalindromeProductTests

open Xunit

[<Fact>]
let ``isPalindrome of 1 is true`` () =
    Assert.True(ProjectEuler.isPalindrome 1)
