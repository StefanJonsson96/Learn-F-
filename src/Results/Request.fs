namespace ConsoleApp.Results

open ConsoleApp.Results.RequestPipelineError

module Requests =

  type Request = { 
    Id: int;
    Name: string; 
    Email: string
    }

  let (>>=) result func = Result.bind func result // Helper method that lets you type >>= instead of |> Result.bind

  let validateName request = 
        match request.Name with
        | "" -> Error (ValidationError "Name is empty")
        | _ -> Ok request

  let validateEmail request =
        match request.Email with
        | "" -> Error (ValidationError "Email is empty")
        | _ -> Ok request

  let validateRequest request = 
        (Ok request) 
            >>= validateName 
            >>= validateEmail

  let storeInDatabase request =
    try
      // do db stuff
      Ok request
    with 
      | _ -> Error (DataBaseError "Database problem")