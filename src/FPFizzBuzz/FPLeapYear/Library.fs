module LeapYear
open Microsoft.FSharp.Core

let (|IsNotDivisibleBy|_|) divisor number =
    match number % divisor with
    | 0 -> None
    |_ -> Some ()
    
    

let check number =
    match number with
    | IsNotDivisibleBy 4 -> false
    |_ -> true