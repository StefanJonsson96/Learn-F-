namespace ConsoleApp.PatternMatching

module PatternMatchConstant =

    let mapNumberToString x = 
      match x with
      | 0 -> "Zero" 
      | 1 -> "One" 
      | 2 -> "Two"
      | 3 -> "Three"
      | 4 -> "Four"
      | 5 -> "Five"
      | 6 -> "Six"
      | 7 -> "Seven"
      | 8 -> "Eight"
      | 9 -> "Nine"
      | _ -> "Not a number"