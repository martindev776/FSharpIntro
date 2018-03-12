module BasicsModule

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



