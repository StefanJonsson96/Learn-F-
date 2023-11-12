namespace ConsoleApp.Iteration

module ForInDo =      
    let forInDoLoop _ = // iterate over an IEnumerable, similar to foreach in C#
        let myList = ["looping 0"; "to type each value in my list 1"; "this is the last string 2";] 
        for i in myList do // syntax is for pattern in enumerable do, body-expression.
           printfn "%A" i |> ignore // notice how "what you do in the loop, has to be indented on new line"
        0