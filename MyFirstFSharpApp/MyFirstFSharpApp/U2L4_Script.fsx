
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

// 4.6

let estimagedAge =
    let age =
        let year = DateTime.Now.Year
        year - 1980
    sprintf "You are about %d years old!" age

// 4.7

let estimateAges (familyName, year1, year2, year3) =
    let calculateAge yearOfBirth =
        let year = System.DateTime.Now.Year
        year - yearOfBirth
    
    let estimatedAge1 = calculateAge year1
    let estimatedAge2 = calculateAge year2
    let estimatedAge3 = calculateAge year3

    let averageAge = (estimatedAge1 + estimatedAge2 + estimatedAge3) / 3
    sprintf "Average age for family %s is %d" familyName averageAge

estimateAges("E",1980,1990,2018)

// 4.8
// Windows form that contains WebBrowser control for hosting the content of a web resource to be downloaded

open System
open System.Net
open System.Windows.Forms

let webClient = new WebClient()
let fsharpOrg = webClient.DownloadString(Uri "http://fsharp.org")
let browser =
    new WebBrowser( ScriptErrorsSuppressed = true,
                    Dock = DockStyle.Fill,
                    DocumentText = fsharpOrg)
let form = new Form(Text = "Hello from F#!")
form.Controls.Add browser
form.Show()
