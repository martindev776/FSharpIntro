module FilterModule

open System
open Display

let integers = [1..10]
let isEven i = i % 2 = 0

let evenIntegers = List.filter isEven integers

let print =
    DisplayListOfIntegers evenIntegers