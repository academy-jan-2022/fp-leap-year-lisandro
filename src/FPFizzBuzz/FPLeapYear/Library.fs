module LeapYear
open Microsoft.FSharp.Core

let (|IsNotDivisibleBy|_|) divisor number =
    match number % divisor with
    | 0 -> None
    |_ -> Some ()
   
let (|IsDivisibleBy|_|) divisor number =
    match number % divisor with
    | 0 -> Some()
    |_ -> None
    

let check number =
    match number with
    | IsNotDivisibleBy 4 -> false
    | IsDivisibleBy 4 & IsDivisibleBy 100 & IsNotDivisibleBy 400 -> false
    |_ -> true