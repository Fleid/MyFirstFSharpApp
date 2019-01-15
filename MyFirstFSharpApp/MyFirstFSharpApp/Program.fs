// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>] // Attribute telling F# that this is the starting point
let main argv =
    //printfn "Hello World from F#!"
    printfn "%A" argv // will return [||], empty array, if no value in input
    0 // return an integer exit code
