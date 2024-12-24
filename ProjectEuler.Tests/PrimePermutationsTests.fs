module PrimePermutationsTests

open Xunit

[<Fact>]
let ``isPrime correctly identifies prime numbers`` () =
    Assert.True(ProjectEuler.isPrime 2)
    Assert.True(ProjectEuler.isPrime 3)
    Assert.True(ProjectEuler.isPrime 1487)
    Assert.False(ProjectEuler.isPrime 1)
    Assert.False(ProjectEuler.isPrime 4)
    Assert.False(ProjectEuler.isPrime 1000)

[<Fact>]
let ``permutations returns all unique permutations`` () =
    let perms = ProjectEuler.permutations [1; 4; 8; 7] |> Seq.toList
    Assert.Contains([1; 4; 8; 7], perms)
    Assert.Contains([4; 8; 1; 7], perms)
    Assert.Contains([8; 1; 4; 7], perms)
    Assert.Equal(24, perms |> List.length)