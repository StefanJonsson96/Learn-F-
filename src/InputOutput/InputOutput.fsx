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

    let exitProgramInput _ =
      
      let mutable shouldContinue = true
      while shouldContinue do    
        Console.WriteLine("Hello world. Press x to exit.")
        let input = Console.ReadLine();

        shouldContinue <- input <> "x"

      Console.WriteLine("Exited program.")
      0
      
      