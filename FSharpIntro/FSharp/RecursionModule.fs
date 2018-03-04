
module RecursionModule

open System

let rec recursiveSum ints = 
    match ints with
    | [] -> 0
    | x::xs -> x + recursiveSum xs
       
let sum ints =
    let rec recursiveTailSum acc ints =
        match ints with
        | [] -> acc
        | x::xs -> recursiveTailSum (acc + x) xs
    recursiveTailSum 0 ints
    
let print =
    let overFlowInts = [1..100000]
    let ints = [1..10]
    Console.WriteLine (recursiveSum ints)
    Console.WriteLine (sum overFlowInts)