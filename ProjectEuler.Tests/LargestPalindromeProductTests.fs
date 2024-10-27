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

[<Fact>]
let ``isPalindrome of 112 is false`` () =
    Assert.False(ProjectEuler.isPalindrome 112)

[<Fact>]
let ``isPalindrome of 111 is true`` () =
    Assert.True(ProjectEuler.isPalindrome 111)

[<Fact>]
let ``isPalindrome of 121 is true`` () =
    Assert.True(ProjectEuler.isPalindrome 121)

[<Fact>]
let ``isPalindrome of 1221 is true`` () =
    Assert.True(ProjectEuler.isPalindrome 1221)


[<Fact>]
let ``isPalindrome of 9009 is true`` () =
    Assert.True(ProjectEuler.isPalindrome 9009)

[<Fact>]
let ``getPalindromesFromMultiples [1..10] should be [1; 2; 3; 4; 5; 6; 7; 8; 9]`` () =
    Assert.StrictEqual([1; 2; 3; 4; 5; 6; 7; 8; 9], ProjectEuler.getPalindromesFromMultiples [1..10])
