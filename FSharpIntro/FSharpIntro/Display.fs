module Display

let DisplayListOfIntegers integers = 
    integers |> List.map (printfn "%i") |> ignore