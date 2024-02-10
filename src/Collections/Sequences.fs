namespace ConsoleApp.Collections

open System.Diagnostics

module Sequences =      

    let sequenceTest _ =  
        let sw = Stopwatch.StartNew()
        let sequence = seq {System.Int32.MaxValue-500000000..System.Int32.MaxValue}
        for i in sequence do // values in a sequences arent computed until iterated upon, so they are more efficient for big numbers
          i+1 |> ignore
        sw.Stop()
        printfn "Elapsed time with sequence: %s" (sw.Elapsed.ToString()) // 1,87 seconds
        0

    let slowListTest _ =
      let sw = Stopwatch.StartNew()
      let list = [System.Int32.MaxValue-500000000..System.Int32.MaxValue]
      for i in list do 
        i+1 |> ignore
      sw.Stop()
      printfn "Elapsed time with list %s" (sw.Elapsed.ToString()) // 39,5 seconds
      0