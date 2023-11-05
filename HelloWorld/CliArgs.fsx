namespace ConsoleApp.HelloWorld

module CliArgs = 

    let cliArgs _ = // indent methods or they dont compile!
        printfn "%A" (System.Environment.GetCommandLineArgs()); // Get Command line args // "%A" format specifier, A means "any"
        0 // Exit code for program 