let firstPosition number list =
   let rec firstPositionOfNumberInList number list size  =
       match list with
       | [] -> -1
       | h :: t ->
         if h = number then
            size - List.length t - 1
         else
            firstPositionOfNumberInList number t size 
   let size = List.length list
   firstPositionOfNumberInList number list size

let rec checkDifferent list = 
    match list with
    | h :: t ->
      let value = firstPosition h t
      if (value = -1) then
         checkDifferent t
      else false
    | [] -> true
   
checkDifferent [1; 2; 3]

checkDifferent [1; 1; 1]





//
//         let localCheck t =          
//         match t with 
//         | h1 :: t1 -> 
//           if (h = h1) then
//              false
//           else localCheck t1
//         | [] -> true


//       checkDifferentRec t

 //      | [] -> true

                