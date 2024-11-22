module PandigitalProductsTests

open Xunit

[<Fact>]
let ``123 is not a pandigital 1-9`` () =
    Assert.False(ProjectEuler.isPandigital 9 "123")

[<Fact>]
let ``123456789 is a pandigital 1-9`` () =
    Assert.True(ProjectEuler.isPandigital 9 "123456789")

[<Fact>]
let ``987654321 is a pandigital 1-9`` () =
    Assert.True(ProjectEuler.isPandigital 9 "987654321")
    
[<Fact>]
let ``123 is a pandigital 1-3`` () =
    Assert.True(ProjectEuler.isPandigital 3 "123")

[<Fact>]
let ``permutations of "1" are [["1"]]`` () =
    Assert.StrictEqual([["1"]], ProjectEuler.permutationsOf "1")

[<Fact>]
let ``permutations of "2" are [["2"]]`` () =
    Assert.StrictEqual([["2"]], ProjectEuler.permutationsOf "2")

[<Fact>]
let ``permutations of "12" are [["1"; "2"]; ["2"; "1"]]`` () =
    Assert.StrictEqual([["1"; "2"]; ["2"; "1"]], ProjectEuler.permutationsOf "12")

[<Fact>]
let ``permutations of "123" are [["1"; "2"; "3"]; ["1"; "3"; "2"]; ["2"; "1"; "3"]; ["2"; "3"; "1"]; ["3"; "1"; "2"]; ["3"; "2"; "1"]]`` () =
    let expected = [["1"; "2"; "3"]; ["1"; "3"; "2"]; ["2"; "1"; "3"]; ["2"; "3"; "1"]; ["3"; "1"; "2"]; ["3"; "2"; "1"]]
    Assert.StrictEqual(expected, ProjectEuler.permutationsOf "123")

[<Fact>]
let ``["1"; "2"; "3"; "4"] can be grouped into 3 groups`` () =
    let expected = [["1"; "2"; "34"]; ["1"; "23"; "4"]; ["12"; "3"; "4"]]
    Assert.StrictEqual(expected, ProjectEuler.makeGroups 3 ["1"; "2"; "3"; "4"])

[<Fact>]
let ``("1", "2", "3") -> 1 * 2 <> 3`` () =
    Assert.False(ProjectEuler.canBeWrittenAsProduct ("1", "2", "3"))

[<Fact>]
let ``("2", "2", "4") -> 2 * 2 = 4`` () =
    Assert.True(ProjectEuler.canBeWrittenAsProduct ("2", "2", "4"))