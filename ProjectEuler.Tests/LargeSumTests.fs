﻿module LargeSumTests

open Xunit

[<Fact>]
let ``37107287533902102798797998220837590246510135740250 round to 10 digits is 3710728753`` () =
    Assert.Equal(3710728753I, ProjectEuler.roundTo10Digits 37107287533902102798797998220837590246510135740250I)

[<Fact>]
let ``91942213363574161572522430563301811072406154908250 round to 10 digits is 9194221336`` () =
    Assert.Equal(9194221336I, ProjectEuler.roundTo10Digits 91942213363574161572522430563301811072406154908250I)

[<Fact>]
let ``46376937677490009712648124896970078050417018260538 round to 10 digits is 4637693768`` () =
    Assert.Equal(4637693768I, ProjectEuler.roundTo10Digits 46376937677490009712648124896970078050417018260538I)

[<Fact>]
let ``9999999999 round to 10 digits is 9999999999`` () =
    Assert.Equal(9999999999I, ProjectEuler.roundTo10Digits 9999999999I)

[<Fact>]
let ``99999999999 round to 10 digits is 1000000000`` () =
    Assert.Equal(1000000000I, ProjectEuler.roundTo10Digits 99999999999I)
