namespace ConsoleApp.Options

module Options =      

    let isItSomething = function // Option<T> can either be Some<T> or None<T>. We use this to avoid null
      | Some i -> "Yes"
      | None -> "No"