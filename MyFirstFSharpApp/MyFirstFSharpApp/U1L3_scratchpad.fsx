open System.IO
open System

// alt enter : execute in interactive

let text = "Hello, world"
printfn "This is your value: %A" text
text.Length


let greetPerson name age =
    sprintf "Hello, %s. You are %d years old" name age

let greeting = greetPerson "Fred" 25

let countWords (text:string) =
    text.Split(' ').Length


let myText = "This is my perfect example"
let countedWords = countWords myText
let outputArray = [myText; countedWords.ToString()]
let outputText = String.concat ", " outputArray

let outputFileName = @"c:\temp\tryThisChapter2.txt"

File.WriteAllText(outputFileName, outputText)
