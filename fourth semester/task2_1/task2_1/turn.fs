let rec turn list result =
   match list with
   | head :: tail -> 
   let result = head :: result
   turn tail result
   | [] -> System.Console.WriteLine("Turning performed")

turn [1;2;3] []