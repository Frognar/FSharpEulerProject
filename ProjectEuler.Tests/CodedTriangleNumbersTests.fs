module CodedTriangleNumbersTests

open Xunit

[<Fact>]
let ``1st triangle number is 1`` () =
    Assert.Equal(1, ProjectEuler.triangleNumber 1)

[<Fact>]
let ``2nd triangle number is 3`` () =
    Assert.Equal(3, ProjectEuler.triangleNumber 2)

[<Fact>]
let ``3rd triangle number is 6`` () =
    Assert.Equal(6, ProjectEuler.triangleNumber 3)

[<Fact>]
let ``triangle numbers up to 10 are [1; 3; 6; 10]`` () =
    Assert.StrictEqual([1; 3; 6; 10], ProjectEuler.triangleNumbersUpTo 10)

[<Fact>]
let ``world value of 'SKY' is 55`` () =
    Assert.Equal(55, ProjectEuler.wordScore "SKY")

[<Fact>]
let ``world value of 'SKY' is a triangle number`` () =
    Assert.True(ProjectEuler.isTriangleNumber "SKY")

[<Fact>]
let ``words.txt contains 162 triangle numbers`` () =
    let words = System.IO.File.ReadAllLines("../../../../resources/0042_words.txt")
                |> Array.collect (fun (x: string) -> x.Split(',') |> Array.map _.Replace("\"", ""))

    Assert.Equal(162, words
                     |> Array.filter ProjectEuler.isTriangleNumber
                     |> Array.length)
