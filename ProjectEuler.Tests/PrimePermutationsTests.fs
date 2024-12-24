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

[<Fact>]
let ``getPermutations returns all unique permutations`` () =
    let perms = ProjectEuler.getPermutations 1487
    Assert.Contains(1487, perms)
    Assert.Contains(4817, perms)
    Assert.Contains(8147, perms)
    Assert.Equal(24, perms.Length)

[<Fact>]
let ``isArithmeticSequence identifies valid sequences`` () =
    Assert.True(ProjectEuler.isArithmeticSequence [1487; 4817; 8147])
    Assert.False(ProjectEuler.isArithmeticSequence [1487; 4817; 8148])
    Assert.True(ProjectEuler.isArithmeticSequence [1; 2; 3])
    Assert.False(ProjectEuler.isArithmeticSequence [1; 2; 4])