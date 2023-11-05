namespace ConsoleApp.Generics

open ConsoleApp.Generics.GenericKvp
open ConsoleApp.Generics.GetTypeName
open ConsoleApp.Generics.WronglyInferedGenericKvp

module GenericKvpTesting = 

    let genericKvpTesting _ =
        let Kvp = { Key = "Hejsan 1"; Value = 1 } // The type declared above is generic, so I can make one kvp with string,int and one with bool,float. 
        let Kvp2 = { Key = true; Value = 1.1} 
        let Kvp3: GenericKvp<string, string> = { Key = null; Value = "not null"} // Inferred type can be wrong! use : operator to decide what type you want if you need to!
        printfn "%A" $"Key1: {Kvp.Key} Value1: {Kvp.Value}"  // Wrongly infered type
        printfn "%A"$"Key2: {Kvp2.Key} Value2: {Kvp2.Value}" // Wrongly infered type
        printfn "%A" $"Key3: {Kvp3.Key} Value3: {Kvp3.Value}" // The type I want
        printfn "%A" $"Type infered on Kvp: {(getTypeName(Kvp.GetType()))} " 
        printfn "%A" $"Type infered on Kvp2: {getTypeName(Kvp2.GetType())} "
        printfn "%A" $"Type infered on Kvp3: {(getTypeName(Kvp3.GetType()))} " // The ´2 after the type namne is how many generic arguments you have!
        printfn "%A" $"Type infered on Kvp3 without type argumentsp: {(getTypeNameWithoutTypeArguments(Kvp3.GetType()))} " // Removing amount of type arguments can be done with string manipulation.
        0