module PatternMatchingModule

type A = int
type B = int * int
type C = float

type Letters = A | B

let ConvertToString x =
    match A with
    | A -> x.ToString()
    | B -> x.ToString()

let printTheInt x = 
    match x with
    | 100 -> "One Hundred"
    | 10 -> "Ten"
    | _ -> "I don't know this number"

let printTheIntFunction = function
    | 100 -> "One Hundred"
    | 10 -> "Ten"
    | _ -> "I don't know this number"

let print x =
    printfn "With match keyword %s" (printTheInt x)
    printfn "With function syntax %s" (printTheIntFunction x)

let a = 3
let b = (2, 3)
let c = 3.14
let printTypes =
    printfn "%s" (ConvertToString a)
    printfn "%s" (ConvertToString b)
    printfn "%s" (ConvertToString c)