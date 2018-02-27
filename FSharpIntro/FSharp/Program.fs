// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System
open FilterModule
open Display

[<EntryPoint>]
let main argv =  


    DisplayListOfIntegers evenIntegers

    Console.WriteLine "Press any key..."
    Console.ReadLine() |> ignore
    0 // return an integer exit code
