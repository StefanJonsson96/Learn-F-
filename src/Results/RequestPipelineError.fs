namespace ConsoleApp.Results

module RequestPipelineError =

  type RequestPipeLineError = 
      | ValidationError of string
      | DataBaseError of string