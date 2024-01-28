namespace ConsoleApp.DiscriminatedUnions

module DaysOfWeek =      
  
  type DaysOfWeek = 
    | Monday
    | Tuesday
    | Wednesday
    | Thursday
    | Friday
    | Saturday
    | Sunday


  let printValueInferedFromDiscriminatedUnion _ =
    let day = Sunday
    printfn "%A" day
    0
    
        
        