module NameScoresTests

open Xunit

[<Fact>]
let ``"COLIN" is worth 3 + 15 + 12 + 9 + 14 = 53`` () =
    Assert.Equal(53, ProjectEuler.wordScore "COLIN")

[<Fact>]
let ``"MARY" is worth 13 + 1 + 18 + 25 = 57`` () =
    Assert.Equal(57, ProjectEuler.wordScore "MARY")

[<Fact>]
let ``"MARY" is in file 0022_names.txt`` () =
    let lines = System.IO.File.ReadAllLines("../../../../resources/0022_names.txt")
                |> Array.collect (fun (x: string) -> x.Split(',') |> Array.map (_.Replace("\"", "")))

    Assert.Contains("MARY", lines)

[<Fact>]
let ``the total of all the name scores in file 0022_names.txt is 871198282`` () =
    let lines = System.IO.File.ReadAllLines("../../../../resources/0022_names.txt")
                |> Array.collect (fun (x: string) -> x.Split(',') |> Array.map (_.Replace("\"", "")))
                |> Array.sort
    
    Assert.Equal(871198282L, lines
                     |> Array.map (fun x -> (int64 (ProjectEuler.wordScore x)))
                     |> Array.indexed
                     |> Array.map (fun (i, x) -> (int64 i + 1L) * x)
                     |> Array.sum)
    