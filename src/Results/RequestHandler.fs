namespace ConsoleApp.Results

open ConsoleApp.Results.Requests
open ConsoleApp.Results.RequestPipelineError

module RequestHandler =

  let returnStatus result = // Returns a Ok or Error,
    match result with
    | Ok data -> (Ok data)
    | Error e ->
      match e with
      | ValidationError field -> (Error field)
      | DataBaseError message -> (Error message)
   

  let requestProcessor request=
    (Ok request) // wrap request in a Result.Ok
      >>= validateRequest 
      >>= storeInDatabase  
      |> returnStatus