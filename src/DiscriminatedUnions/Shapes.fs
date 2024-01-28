namespace ConsoleApp.DiscriminatedUnions

module Shapes =      
  
  type Shape = // Discriminated unions are usually used instead of inheritance in F#
    | Rectangle of w : float * h : float
    | Circle of r : float
    | Triangle of s1:float * s2:float * s3:float


  let perimiter shape = // There is no need to inherit the perimiter method of a generic shape interface like you would in C#.
    match shape with //  You just need to extend this pattern match when you add more shapes.
    | Rectangle (w, h) -> 2. * (w + h)
    | Circle r -> 2. * System.Math.PI * r 
    | Triangle (s1, s2, s3) -> s1 + s2 + s3

  let printPerimiterOfAShape shape =
    let perim = perimiter shape
    printfn "%A" $"The perimiter of the {(shape.GetType().Name)} is: {perim}."
    0
    
    
    
        
        