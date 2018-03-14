// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System
open FilterModule
open FoldModule
open System.Numerics

[<EntryPoint>]
let main argv =  

    //let theNumbers = [1..10]
    //Display.DisplayListOfIntegers (BasicsModule.multedBy2AndLessThan6ReversePipe theNumbers)
    
    //Console.WriteLine(BasicsModule.pi)

    //PatternMatchingModule.printTypes
    //PatternMatchingModule.print 10
    //PatternMatchingModule.print 100
    //PatternMatchingModule.print 1

    //FoldModule.print
    //FilterModule.print
    //RecursionModule.print

    Console.WriteLine "Press any key..."
    Console.ReadKey() |> ignore
    0 // return an integer exit code
