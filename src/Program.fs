open ConsoleApp.Iteration.ForInDo
open ConsoleApp.Iteration.ForToDo
open ConsoleApp.Iteration.WhileDo
open ConsoleApp.Iteration.FunctionalForLoop
open ConsoleApp.Collections.Array
open ConsoleApp.Collections.List
open ConsoleApp.Collections.IntRangesArray
open ConsoleApp.Collections.ConsOperatorList
open ConsoleApp.Collections.ConcatenateOperatorList
open ConsoleApp.Collections.PipeForwardOperatorList
open ConsoleApp.Generics.GenericKvp
open ConsoleApp.Generics.GenericKvpTesting
open ConsoleApp.Generics.GetTypeName
open ConsoleApp.Generics.WronglyInferedGenericKvp
open ConsoleApp.Strings.SliceString
open ConsoleApp.Strings.InterpolatedString
open ConsoleApp.Strings.NewLineString
open ConsoleApp.Strings.TrippleQuotedString
open ConsoleApp.Strings.VerbatimString
open ConsoleApp.InputOutput.InputOutput  
open ConsoleApp.InputOutput.DifferentPrintFunctions
open ConsoleApp.InputOutput.Unit
open ConsoleApp.Bindings.LetBindings
open ConsoleApp.Bindings.UseBindings
open ConsoleApp.Bindings.UsingBindings
open ConsoleApp.Bindings.DoBindings
open ConsoleApp.HelloWorld.HelloWorld
open ConsoleApp.HelloWorld.Square
open ConsoleApp.HelloWorld.CliArgs
open ConsoleApp.StringBuilder.StringBuilder
open ConsoleApp.Conditionals.ifStatements
open ConsoleApp.PatternMatching.PatternMatchConstant
open ConsoleApp.Exceptions.Exceptions
open ConsoleApp.Tuples.Tuples
open ConsoleApp.Records.Records
open ConsoleApp.DiscriminatedUnions.DaysOfWeek
open ConsoleApp.DiscriminatedUnions.Shapes
open ConsoleApp.Options.Options
open System

module Main = 

    [<EntryPoint>]
    addAsOptions (Some 1) (Some 3) |> describe |> printfn "%A"
    addAsOptions (Some 1) (None) |> describe |> printfn "%A"
    addAsOptions (None) (Some 1) |> describe |> printfn "%A"
    addAsOptions (None) (None) |> describe |> printfn "%A"
    parseStringToDoubleOptions "35.0" |> describe |> printfn "%A"
    parseStringToDoubleOptions "not a double" |> describe |> printfn "%A"


