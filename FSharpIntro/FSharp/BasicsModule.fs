module BasicsModule

open System
open System.Numerics

//pi = ln(-1) / i
let pi = (Complex.Log(Complex(-1.0, 0.0), Math.E) / Complex.ImaginaryOne).Real

//functions
let addOne x = x + 1

let addOneFun = fun x -> x + 1

//currying
let subTwoInts x y = x - y

let subTwoIntsCurry x =
    let subFunc y =
        x - y
    subFunc

//partial application
let addTwo = (+) 2
let addTwoResult = 2 |> addTwo

let addThree = fun i -> i + 3
let addThreeResult = addThree <| 2

let printPartialApplication () = 
    printfn "addTwoResult"
    printfn "%i" addTwoResult
    printfn "addThreeResult"
    printfn "%i" addThreeResult

//Similar to linq
let numbers = [1..10]
let multBy2 x = x * 2
let multedBy2 = List.map multBy2 numbers

let numbersLessThan4 = List.filter (fun x -> x < 4) numbers

//Piping
let lessThan6 x = x < 6
let multedBy2AndLessThan6 numbers = 
    List.map multBy2 numbers 
    |> List.filter lessThan6

let multedBy2AndLessThan6ReversePipe numbers = 
    List.filter lessThan6 
    <| List.map multBy2 numbers 

let printPiping () = 
    let theNumbers = [1..10]
    printfn "multedBy2AndLessThan6"
    Display.DisplayListOfIntegers (multedBy2AndLessThan6 theNumbers)
    printfn "multedBy2AndLessThan6ReversePipe"
    Display.DisplayListOfIntegers (multedBy2AndLessThan6ReversePipe theNumbers)

//Collections
let emptyList = List.empty //Has Pettern Matching
let emptySeq = Seq.empty //No Pattern Matching but can interop with IEnumerable
let emptyArray = Array.empty //Mutable


