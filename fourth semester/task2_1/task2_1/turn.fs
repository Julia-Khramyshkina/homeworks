let simpleTurn list =
   let rec turn list result =
       match list with
       | head :: tail -> 
          let result = head :: result
          turn tail result
       | [] -> result
   turn list []

simpleTurn [1; 2; 3]