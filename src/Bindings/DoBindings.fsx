namespace ConsoleApp.Bindings

module DoBindings = 

    do printfn "%A" "The code in the DoBindings module is always executed due to the do keyword." // do binding lets you execute code without defining a function or a value!
    do (1+1 |>ignore) // do expects unit as a return value. so if you try to "do 1+1", you should ignore it or you will have a compiler warning.