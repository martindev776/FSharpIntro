module FoldModule

let numbers = [1..3]
let accFunction acc i = acc - i

//Fold
let initFoldVal = 0
let foldFunc is = List.fold accFunction initFoldVal is
// (((0 - 1) - 2) - 3)
let foldResult = foldFunc numbers

//Fold back
let initFoldBackVal = 0
let foldBackFunc is = List.foldBack accFunction is initFoldBackVal
//  (1 - (2 - (3 - 0)))
let foldBackResult = foldBackFunc numbers

let print = 
    printfn "Fold Result: %i" foldResult
    printfn "Fold Back Result: %i" foldBackResult
