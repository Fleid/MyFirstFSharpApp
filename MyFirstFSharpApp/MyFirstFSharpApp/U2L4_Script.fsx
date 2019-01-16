
// 4.1

let name = "Florian"
let age = 38

let randomGenerator = System.Random()
let randomString = randomGenerator.Next(10).ToString()
printfn "My random number = %A" randomString

let getNext () =
    randomGenerator.Next(10)

getNext()

// 4.4

open System

let doStuffWithTwoNumbers(first, second) =
    let added = first + second
    Console.WriteLine("{0} + {1} = {2}", first, second, added)
    let doubled = added *2
    doubled

doStuffWithTwoNumbers(3,4)