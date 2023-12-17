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

    let mapNumberToString2 = function // Shorthand for pattern match without having to define the parameter x, or the word match. Works the same as the example above.
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

    let mapNumberToString3 =  function // You can have multiple matches within the same pattern
    | 0 | 1 | 2 | 3 | 4  -> "Found a number below 5"
    | 5 | 6 | 7 | 8 | 9 -> "Found a number above 5"
    | a -> $"Not a number: {a}" // If you use the default operator _ the value is not stored! a is just a way to declare the value.

