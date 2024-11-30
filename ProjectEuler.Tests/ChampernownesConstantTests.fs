module ChampernownesConstantTests

open Xunit

[<Fact>]
let ``the 12th digit of Champernowne's constant is 1`` () =
    Assert.Equal(1, ProjectEuler.champernownesConstant 12)

[<Fact>]
let ``the 2nd digit of Champernowne's constant is 2`` () =
    Assert.Equal(2, ProjectEuler.champernownesConstant 2)

[<Fact>]
let ``the 1000000thd digit of Champernowne's constant is 2`` () =
    Assert.Equal(1, ProjectEuler.champernownesConstant 1000000)

[<Fact>]
let ``the product of the [1; 10; 100; 1000; 10000; 100000; 1000000] digits of Champernowne's constant is 210`` () =
    Assert.Equal(210, ProjectEuler.champernownesConstantProduct [1; 10; 100; 1000; 10000; 100000; 1000000])