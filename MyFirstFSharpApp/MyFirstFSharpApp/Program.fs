// Learn more about F# at http://fsharp.org

[<EntryPoint>] // Attribute telling F# that this is the starting point
let main argv =
    let items = argv.Length
    printfn "Passed in %d items: %A" items argv
    0 // return an integer exit code
