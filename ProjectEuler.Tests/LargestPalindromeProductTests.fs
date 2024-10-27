module LargestPalindromeProductTests

open Xunit

[<Fact>]
let ``isPalindrome of any one-digit number is true`` () =
    [0..9] |> List.iter (fun x -> Assert.True(ProjectEuler.isPalindrome x))

[<Fact>]
let ``isPalindrome of 10 is false`` () =
    Assert.False(ProjectEuler.isPalindrome 10)
[<Fact>]
let ``isPalindrome of 12 is false`` () =
    Assert.False(ProjectEuler.isPalindrome 12)

[<Fact>]
let ``isPalindrome of 11 is true`` () =
    Assert.True(ProjectEuler.isPalindrome 11)

[<Fact>]
let ``isPalindrome of 22 is true`` () =
    Assert.True(ProjectEuler.isPalindrome 22)