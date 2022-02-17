module Tests

open Xunit

[<Theory>]
[<InlineData(1997, false)>]
let ``is not a leap year when NOT divisible by 4`` (year, expected) =
  let result = LeapYear.check year
  Assert.Equal(expected, result)

[<Theory>]
[<InlineData(1997, 4, false)>]
let ``should return false when the number is not divisible by the divisor`` (number, divisor, expected) =
  let result =
    match number with
    | LeapYear.IsNotDivisibleBy divisor -> false
    |_ -> true
    
  Assert.Equal(expected, result)