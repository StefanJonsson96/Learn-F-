namespace ConsoleApp.Options

open System.Globalization

module Options =      

    let isItSomething = function // Option<T> can either be Some<T> or None<T>. We use this to avoid null
      | Some i -> "Yes"
      | None -> "No"

    let addAsOptions xoption yoption = // simple addd function but using Option<int> instead of int, the
      match xoption with
        | Some xvalue ->
          match yoption with
            | Some yvalue -> Some (xvalue + yvalue)
            | None -> None
        | None -> None

    let parseStringToDoubleOptions s : option<double> = // No need to deal with exceptions or null, just return Some or None when trying to parse.=
      match System.Double.TryParse(string s, CultureInfo.InvariantCulture) with
      | (true, value) -> Some value
      | _ -> None

    let describe = function
      | Some x -> $"The value is {x}"
      | None -> $"There is no value"
