// alt enter : execute in interactive

let text = "Hello, world"
printfn "This is your value: %A" text
text.Length


let greetPerson name age =
    sprintf "Hello, %s. You are %d years old" name age

let greeting = greetPerson "Fred" 25

