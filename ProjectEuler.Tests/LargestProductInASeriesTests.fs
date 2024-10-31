module LargestProductInASeriesTests

open Xunit

[<Fact>]
let ``"" split into substrings of size 1 should be []`` () =
    Assert.StrictEqual([], ProjectEuler.splitIntoSubstrings 1 "")

[<Fact>]
let ``"1" split into substrings of size 1 should be ["1"]`` () =
    Assert.StrictEqual(["1"], ProjectEuler.splitIntoSubstrings 1 "1")

[<Fact>]
let ``"12" split into substrings of size 1 should be ["1"; "2"]`` () =
    Assert.StrictEqual(["1"; "2"], ProjectEuler.splitIntoSubstrings 1 "12")

[<Fact>]
let ``"12" split into substrings of size 2 should be ["12"]`` () =
    Assert.StrictEqual(["12"], ProjectEuler.splitIntoSubstrings 2 "12")

[<Fact>]
let ``"123" split into substrings of size 2 should be ["12"; "23"]`` () =
    Assert.StrictEqual(["12"; "23"], ProjectEuler.splitIntoSubstrings 2 "123")

[<Fact>]
let ``"731671765313306" split into substrings of size 13 should be ["7316717653133"; "3167176531330"; "1671765313306"]`` () =
    Assert.StrictEqual(["7316717653133"; "3167176531330"; "1671765313306"], ProjectEuler.splitIntoSubstrings 13 "731671765313306")

[<Fact>]
let ``"" split into digits should be []`` () =
    Assert.Empty(ProjectEuler.splitDigits "")

[<Fact>]
let ``"1" split into digits should be [1]`` () =
    Assert.StrictEqual(([1]: int64 list), ProjectEuler.splitDigits "1")

[<Fact>]
let ``"12" split into digits should be [1; 2]`` () =
    Assert.StrictEqual(([1; 2]: int64 list), ProjectEuler.splitDigits "12")

[<Fact>]
let ``"7316717653133" split into digits should be [7; 3; 1; 6; 7; 1; 7; 6; 5; 3; 1; 3; 3]`` () =
    Assert.StrictEqual(([7; 3; 1; 6; 7; 1; 7; 6; 5; 3; 1; 3; 3]: int64 list), ProjectEuler.splitDigits "7316717653133")

[<Fact>]
let ``[] largest product is 0`` () =
    Assert.Equal(0L, ProjectEuler.largestProduct [])

[<Fact>]
let ``[[1]] largest product is 1`` () =
    Assert.Equal(1L, ProjectEuler.largestProduct [[1]])

[<Fact>]
let ``[[1]; [2]] largest product is 2`` () =
    Assert.Equal(2L, ProjectEuler.largestProduct [[1]; [2]])

[<Fact>]
let ``[[1; 3]; [2; 1]] largest product is 3`` () =
    Assert.Equal(3L, ProjectEuler.largestProduct [[1; 3]; [2; 1]])


[<Fact>]
let ``[[7; 3; 1; 6; 7; 1; 7; 6; 5; 3; 1; 3; 3]; [2; 1]] largest product is 5000940`` () =
    Assert.Equal(5000940L, ProjectEuler.largestProduct [
        [7; 3; 1; 6; 7; 1; 7; 6; 5; 3; 1; 3; 3]
        [3; 1; 6; 7; 1; 7; 6; 5; 3; 1; 3; 3; 0]
        [1; 6; 7; 1; 7; 6; 5; 3; 1; 3; 3; 0; 6]
    ])

[<Fact>]
let ``the greatest product of thirteen adjacent digits in the 1000-digit number is 23514624000`` () =
    let str = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450"
    Assert.Equal(23514624000L, str
                 |> ProjectEuler.splitIntoSubstrings 13
                 |> List.filter (fun s -> not (s.Contains '0'))
                 |> List.map ProjectEuler.splitDigits
                 |> ProjectEuler.largestProduct)