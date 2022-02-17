module Tests

open Xunit

[<Theory>]
[<InlineData(1997, false)>]
let ``is not a leap year when NOT divisible by 4`` (year, expected) =
  let result = LeapYear.check year
  Assert.Equal(expected, result)
