// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System
open FilterModule
open FoldModule

[<EntryPoint>]
let main argv =  
    
    FoldModule.print
    //FilterModule.print
    //RecursionModule.print

    Console.WriteLine "Press any key..."
    Console.ReadKey() |> ignore
    0 // return an integer exit code
