namespace ConsoleApp.Generics

open System

module GetTypeName =      

    let getTypeName (type_: Type) : string =
        let genericTypeDefinition = type_.GetGenericTypeDefinition() // Helper method to get type name without namespace and junk
        genericTypeDefinition.Name

    let getTypeNameWithoutTypeArguments (type_: Type) : string =
        let genericTypeDefinition = type_.GetGenericTypeDefinition()
        let name = genericTypeDefinition.Name
        let index = name.IndexOf('`')
        if index >= 0 then // if statements need then keyword
            name.Substring(0, index)
        else
        name