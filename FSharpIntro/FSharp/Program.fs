// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System
open FilterModule
open FoldModule
open System.Numerics

[<EntryPoint>]
let main argv =  

    //printfn "%f" BasicsModule.pi
    //BasicsModule.printPartialApplication ()
    //BasicsModule.printPiping () 

    //PatternMatchingModule.printTypes
    //PatternMatchingModule.print 10
    //PatternMatchingModule.print 100
    //PatternMatchingModule.print 1

    
    //FilterModule.print
    //RecursionModule.print
    //FoldModule.print

    Console.WriteLine "Press any key..."
    Console.ReadKey() |> ignore
    0 // return an integer exit code
