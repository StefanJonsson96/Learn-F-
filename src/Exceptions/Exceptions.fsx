namespace ConsoleApp.Exceptions

open System

module Exceptions =

    exception MyCustomException of string // Custom exception syntax. the datatypes after of keyword are what you should pass to the constructor.

    let raiseCustomExceptionTest string = 
      raise (MyCustomException("Something went wrong."))

    let raiseNullRefExceptionTest string = 
      raise (NullReferenceException("Send help."))
      
    let catchCustomExceptionTest _ = 
      try 
        (raiseCustomExceptionTest "asd")
      with
        | MyCustomException(e) -> printfn "Your custom exception was caught."
        | a -> printfn $"Other exceptions will continue up the call stack. {a.Message}"

    // Exceptions are caught in pattterns.
    // raise or reraise is equavilent to C# throw keyword. 
    // However it is not very common to use exceptions for control flow the same way. However we do need to be able to catch them when interoping with the C# or other .NET libraries!

