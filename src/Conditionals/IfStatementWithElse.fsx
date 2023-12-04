namespace ConsoleApp.Conditionals

module ifStatements =

    let ifStatement _ = 
        if 1 > 2 then
            2
        else // You cannot skip else or elseif clause in F# unless you return unit.            
            4      

    let ifStatementWithElif _ =
        if 1 > 2 then
            2
        elif 1 < 1 then // elif is like elseif in C#
            1
        elif 1 = 1 then // comparison is done with one =
            10
        else // then keyword is only needed after if/elif, not else
            4

