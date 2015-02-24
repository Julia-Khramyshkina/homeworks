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

firstPosition 3 [1; 2; 3; 4; 5]