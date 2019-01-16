
let name = "Florian"
let age = 38

let randomGenerator = System.Random()
let randomString = randomGenerator.Next(10).ToString()
printfn "My random number = %A" randomString

let getNext () =
    randomGenerator.Next(10)

getNext()