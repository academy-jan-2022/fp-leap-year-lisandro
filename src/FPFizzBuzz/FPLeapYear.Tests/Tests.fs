module Tests

open Xunit

[<Theory>]
[<InlineData(1997, true)>]
let ``is not a leap year when NOT divisible by 4`` () =
  let result = LeapYear.check 1
  Assert.Equal("1", result)
