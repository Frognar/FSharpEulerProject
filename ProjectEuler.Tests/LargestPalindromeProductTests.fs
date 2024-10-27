module LargestPalindromeProductTests

open Xunit

[<Fact>]
let ``isPalindrome of any one-digit number is true`` () =
    [0..9] |> List.iter (fun x -> Assert.True(ProjectEuler.isPalindrome x))
