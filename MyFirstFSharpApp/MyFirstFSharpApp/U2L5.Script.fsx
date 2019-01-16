open System.Net.Mime.MediaTypeNames

// 5.5

let add (a:int, b:int) : int = 
    let answer:int = a + b
    answer

    
let add2 (a, b) = 
    a + b //default binding of + is int

let add3 (a:float, b) =
    a + b //no implicit conversion allowed : constraining the type via parameter

let add4 (a, b) =
    a + b + "Hello"

let add5 (a, b) =
    (a + b) * 1.0

//5.9
open System.Collections.Generic

let createList(first, second) =
    let output = List()
    output.Add(first)
    output.Add(second)
    output

createList(1,2)
createList("a","b")