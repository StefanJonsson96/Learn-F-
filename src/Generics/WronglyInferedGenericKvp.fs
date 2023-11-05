namespace ConsoleApp.Generics

module WronglyInferedGenericKvp =

    type WronglyInferedGenericKvp<'a, 'b> = // Generics have slightly different syntax to C#, type parameters have a ' before the name
        {
            Key: 'a;
            Value: 'b;
        }