namespace ConsoleApp.UnitOfMeasure

module UnitOfMeasure =
  [<Measure>] type cm
  [<Measure>] type inch
  [<Measure>] type m
  [<Measure>] type sec
  [<Measure>] type kg 
  [<Measure>] type lbs
  [<Measure>] type degreeCelcius
  [<Measure>] type degreeFahrenheit

  let convertDegCToF c = c * 1.8<degreeFahrenheit/degreeCelcius> + 32.0<degreeFahrenheit> // with units of measure you can easily convert celsius to fahrenheit with this one liner function