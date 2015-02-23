let rec turn list result =
   match list with
   | head :: tail -> 
       let result = head :: result
       turn tail result
   | [] -> printfn "Turning performed"

let simpleTurn list =
    turn list []

simpleTurn [1; 2; 3]