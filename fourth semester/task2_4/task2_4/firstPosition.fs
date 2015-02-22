let rec firstPositionOfNumberInList number list size =
    match list with
    | [] -> printfn "Not found this number"
    | h :: t ->
    if h = number then
       let firstPosition = size - List.length t - 1
       printfn "first position of this number in the list: %d" firstPosition
    else
       firstPositionOfNumberInList number t size


firstPositionOfNumberInList 1 [1;2;3;4;5] 5