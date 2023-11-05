namespace ConsoleApp.Generics

module GenericKvp =

    type GenericKvp<'a, 'b> = // Generics have slightly different syntax to C#, type parameters have a ' before the name
        {
            Key: 'a;
            Value: 'b;
        }