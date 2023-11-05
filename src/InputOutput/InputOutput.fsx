namespace ConsoleApp.InputOutput

open System

module InputOutput = 
    let InputOutput _ =
        printf "Hejsan hoppsan \n"
        let input = Console.ReadLine(); // familiar? .net classes are avaliable in F#
        Console.WriteLine("\n" 
        + "You wrote:" 
        + input 
        + ".\nGoodbye"); 
        0