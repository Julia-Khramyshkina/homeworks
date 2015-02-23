let rec firstPositionOfNumberInList number list size  =
    match list with
    | [] -> -1
    | h :: t ->
      if h = number then
         let temp = size - List.length t - 1
         temp
      else
         firstPositionOfNumberInList number t size 

let firstPosition number list =
    let size = List.length list
    firstPositionOfNumberInList number list size

firstPosition 3 [1;2;3;4;5]