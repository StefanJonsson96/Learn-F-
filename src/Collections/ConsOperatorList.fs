namespace ConsoleApp.Collections

module ConsOperatorList =      

    let consOperator _ =
       let myList = [1; 2; 3;]
       let newList = 4 :: myList // :: operator makes a new list with leftside value as the head, and the list added after
       printfn "%A" myList
       printfn "%A" newList
       0