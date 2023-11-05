open System
open System.Linq
open System.Text
open Microsoft.FSharp.Core.Printf


let square x = // define a function with let keywoard and methodname. the x is the variable of the return value! 
    x * x      // x will always be the evaultion of the LAST EXPRESSION
               // anything after = is the "method body" with proper indentation


let cliArgs _ = // indent methods or they dont compile!
    printfn "%A" (System.Environment.GetCommandLineArgs()); // Get Command line args // "%A" format specifier, A means "any"
    0 // Exit code for program 


let immutableVariables _ =
    let hej = 0
    let output = "Initial value of variable: " + hej.ToString()
    let changeValueExpression = hej = 1
    let output2 = "Value of the operation " + nameof(changeValueExpression) + ": " + changeValueExpression.ToString()
    let output3 = "Value of the variable after attempting to change it: " + hej.ToString()
    printfn "%A" output // Variables are immutable thats why we cannot change "Hej"
    printfn "%A" output2 // Every expression has a value!! That is why trying to change the immutable type returns "false"!!
    printfn "%A" output3 
    0


let arrayTest _ =  
    let myArray = [|1.; 5; 10.|] // pipes needed to declare array
    myArray[0] <- 69 // Arrow operator changes value of something mutable (NOT VARIABLES; but values in an array!)
    printfn "%A" myArray[0] 
    0



let listTest _ =
    let myList = [1; 5; 10;] // List syntax has no pipes
    // myList[0] <- 69420 this doesn't work because values in list are immutable!
    printfn "%A" myList[0]
    0


let intRanges _ = 
    let intRangeArray = [|1..5|] // .. syntax is a range, so 1..5 => 1 2 3 4 5
    let intRangeArray2 = [|10..10..100|] // you can also have an optional 2nd parameter "how much you want to increment", so 10..10..100 would be 10 20 30 40 50 60 70 80 90 100
    printfn "%A" intRangeArray
    printfn "%A" intRangeArray2
    0


let consOperator _ =
   let myList = [1; 2; 3;]
   let newList = 4 :: myList // :: operator makes a new list with leftside value as the head, and the list added after
   printfn "%A" myList
   printfn "%A" newList
   0


let concatenateOperator _ = 
    let myList = [1;2;3;]
    let myOtherList = [4;5;6;]
    let concatList = myList@myOtherList // @ operator concats lists
    printfn "%A" concatList
    0


let pipeForward _ =
    let list = [1;5;15;25;]
    let multiplyEachValueAndThenRemoveFirstValue = list |> List.map(fun x -> x*2) // map is equavilent of select in c# linq
                                                        |> List.filter(fun x -> x <> 2) // filter is equavilent of where in c# linq
                                                                                        // notice how pipe forward |> is used to chain calls 
                                                                                        // notice how fun x -> is equavilent of x => in c#
    // |> List.take(1)  (this wouldnt compile because u need to indent properly!!!
    printfn "%A" multiplyEachValueAndThenRemoveFirstValue // 10; 30; 50; 1 > removed 5>10 15>30 25>50 
    0


let sliceString _ =
    let string = "hejsan"
    let subString = string[2..5] // substrings can be done using slice method, so this will result in "jsan" since we slice from index 2>5
    printfn "%A" subString // strings are immutable so trying to assign string[1] = 'b' will not work
    0


let newLineString _ =
    let string ="hejsan
    new line here" // strings are indented as u write them, no need to write \r \n, u just indent the string. 
    let ignoreIndenation = "hejsan\
    no new line here "// if you want to ignore that behaviour, just put a \ before new line, and the string will stay on the same line
    printfn "%A" string
    printfn "%A" ignoreIndenation
    0


let verbatimString _ =
    let verbatimString = @"<xml>I can have quotes "" in my verbatim string</xml>"
    printfn "%A" verbatimString // verbatim strings with the @ operator works same as c#
    0


let trippleQuotedString _ =
    let tripleQuoteString = """I can have quotes in my tripple quoted string "" :) """ // Tripple quoted strings work the same as they do in c#
    printfn "%A" tripleQuoteString
    0


let stringBuilder _ = 
    let builder = StringBuilder() 
    builder.Append("Hejsan ") |> ignore // Stringbuiilder is good at working with strings in f# since strings are immutable.
    builder.Append("Hoppsan") |> ignore // Since we dont care about the value "Hoppsan" on its own, but the completed string, its good practise to explicitly ignore the append rows
    builder.Append(" ") |> ignore
    printfn "%A" (builder.ToString())
    0

let interpolatedString _ = 
    let a = 1
    let b = 2
    let interpolatedString = $"Hejsan a={a} hoppsan b={b}." // String interpolation works the same as c#
    printfn "%A" interpolatedString
    0


let differentPrintFunctions _ =
    let string = "Hejsan hoppsan"
    //printf "%A" string // print to console or "stdout" 
    //sprintf "%A" string // returns a formatted string
    //eprintf "%A" string // outputs to stderr (errors)
    //fprintf "%A" string // outpot to text writer
    //bprintf "%A" string // output to a strinbuilder
    //kprintf "%A" string // calls a function to generate a result
    // google how theese work later
    0


let unit _ =
    let unit = () // Unit is used when no value is needed, it is not NULL. it is more comparable to "void". To assign something unit, use the () syntax
    printfn "%A" unit // Unit cannot be ignored in pattern matches! you have to handle "unit" cases
    0


type GenericKvp<'a, 'b> = // Generics have slightly different syntax to C#, type parameters have a ' before the name
    {
        Key: 'a;
        Value: 'b;
    }

type WronglyInferedGenericKvp<'a, 'b> = // Generics have slightly different syntax to C#, type parameters have a ' before the name
    {
        Key: 'a;
        Value: 'b;
    }

let getTypeName (type_: Type) : string =
  let genericTypeDefinition = type_.GetGenericTypeDefinition() // Helper method to get type name without namespace and junk
  genericTypeDefinition.Name

let getTypeNameWithoutTypeArguments (type_: Type) : string =
  let genericTypeDefinition = type_.GetGenericTypeDefinition()
  let name = genericTypeDefinition.Name
  let index = name.IndexOf('`')
  if index >= 0 then // if statements need then keyword
    name.Substring(0, index)
  else
    name

[<EntryPoint>] // Entry point for program
let genericKvpTesting _ =
    let Kvp = { Key = "Hejsan 1"; Value = 1 } // The type declared above is generic, so I can make one kvp with string,int and one with bool,float. 
    let Kvp2 = { Key = true; Value = 1.1} 
    let Kvp3: GenericKvp<string, string> = { Key = null; Value = "not null"}
    printfn "%A" $"Key1: {Kvp.Key} Value2: {Kvp.Value}"  // Wrongly infered type
    printfn "%A"$"Key2: {Kvp2.Key} Value2: {Kvp2.Value}" // Wrongly infered type
    printfn "%A" $"Key3: {Kvp3.Key} Value3: {Kvp3.Value}" // The type I want
    printfn "%A" $"Type infered on first kvp: {(getTypeName(Kvp.GetType()))} " // However, inferred type can be wrong! use : operator to decide what type you want if you need to!
    printfn "%A" $"Type infered on first kvp: {(getTypeName(Kvp3.GetType()))} " // The ´2 after the type namne is how many generic arguments you have! If you want to
    printfn "%A" $"Type infered on first kvp: {(getTypeNameWithoutTypeArguments(Kvp3.GetType()))} " // Removing amount of type arguments can be done with string manipulation
    0




