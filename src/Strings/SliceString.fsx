namespace ConsoleApp.Strings

module SliceString = 

    let sliceString _ =
        let string = "hejsan"
        let subString = string[2..5] // substrings can be done using slice method, so this will result in "jsan" since we slice from index 2>5
        printfn "%A" subString // strings are immutable so trying to assign string[1] = 'b' will not work
        0
