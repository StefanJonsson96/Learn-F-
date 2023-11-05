open System

let inputOutput _ =
    printf "Hejsan hoppsan \n"
    let input = Console.ReadLine(); // familiar? .net classes are avaliable in F#
    Console.WriteLine("\n" 
    + "You wrote:" 
    + input 
    + ".\nGoodbye"); 
    0

[<EntryPoint>]
    inputOutput
    0