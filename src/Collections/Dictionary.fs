namespace ConsoleApp.Collections

module Dictionary =      

  let dictionaryTest _ = // dictionaries in F# are an imutable implementation of the .net IDictionary<K,V> that we know of from C#.
    let kvp = 
      [ "SomeKey", "SomeValue"; "SomeOtherKey", "SomeOtherValue" ]
      |> dict // with the pipe forward dict syntax you create a dictionary
    printfn "%A" kvp["SomeKey"]
    0