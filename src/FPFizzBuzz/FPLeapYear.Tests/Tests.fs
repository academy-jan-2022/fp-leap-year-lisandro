module Tests

open Xunit

[<Theory>]
[<InlineData(1997, false)>]
[<InlineData(1996, true)>]
[<InlineData(1600, true)>]
[<InlineData(1600, true)>]
[<InlineData(1800, false)>]
let ``should return check if is a leap year or not`` (year, expected) =
  let result = LeapYear.check year
  Assert.Equal(expected, result)

[<Theory>]
[<InlineData(1997, 4, false)>]
[<InlineData(1800, 400, false)>]
let ``should return false when the number is not divisible by the divisor`` (number, divisor, expected) =
  let result =
    match number with
    | LeapYear.IsNotDivisibleBy divisor -> false
    |_ -> true
    
  Assert.Equal(expected, result)
  
[<Theory>]
[<InlineData(1996, 4, true)>]
[<InlineData(1600, 400, true)>]
[<InlineData(1800, 100, true)>]
let ``should return true when the number is divisible by the divisor`` (number, divisor, expected) =
  let result =
    match number with
    | LeapYear.IsDivisibleBy divisor -> true
    |_ -> true
    
  Assert.Equal(expected, result)