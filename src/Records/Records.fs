namespace ConsoleApp.Records

module Records =      

    type Person = {FirstName: string; LastName: string; Age: int;}
      with member this.FullName = $"{this.FirstName} {this.LastName}"
           member this.IsOld = this.Age >= 40
           static member New f l a = { FirstName = f; LastName = l; Age = a } // members static or not needs to be indented one lvl after with keyword
           
    let declarePersonAndPrintFirstName _ =
      let person = { FirstName = "Stefan"; LastName = "Jonsson"; Age = 28 }
      printfn "%A" person.FirstName
      0

    let declarePersonAndPrintAge _ =
      let person = { FirstName = "Stefan"; LastName = "Jonsson"; Age = 28 }
      printfn "%A" person.Age
      0

    let declarePersonAndPrintIfOldOrNot _ =
      let person = { FirstName = "Stefan"; LastName = "Jonsson"; Age = 28 }
      printfn "%A" ("Is the person old?: " + person.IsOld.ToString())
      0
        
    let modifyRecords _= 
      let person1 = { FirstName = "Stefan"; LastName = "Jonsson"; Age = 28 } // records are immutable by default
      printfn "%A" ("Person age: " + person1.Age.ToString())
      let person2 = { person1 with Age = 99 } // using the with syntax you can copy over the record to a new record, this is a better pattern than making the record mutable
      printfn "%A" ("Person age after modification: " + person2.Age.ToString())
      0

    let boolToString b = 
      if b then "true" else "false" // toString() doesn't work on booleans so I made a helper method

    let checkRecordEquavilence _ =
      let person1 = { FirstName = "Stefan"; LastName = "Jonsson"; Age = 28 }
      let person2 = { FirstName = "Kalle"; LastName = "Anka"; Age = 15 }
      let person3 = { FirstName = "Nisse"; LastName = "Pisse"; Age = 67 }
      let person4 = { FirstName = "Stefan"; LastName = "Jonsson"; Age = 28 }
      let equalPersons = boolToString (person1 = person4) // "Record equality is based on value not reference."
      let notEqualPersons = boolToString (person2 = person3)
      printfn "%A" $"person1 = person4:  {equalPersons}"
      printfn "%A" $"person2 = person3:  {notEqualPersons}"
      0
    
        
        