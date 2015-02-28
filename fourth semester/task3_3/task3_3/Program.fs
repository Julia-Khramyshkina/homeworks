let countOfEven list = 
   let evenList = List.filter (fun x -> x % 2 = 0) list
   List.length evenList

countOfEven [1; 2; 3; 4; 5]

let countOfEven2 list = 
   let newList = list |> List.map (fun x -> x % 2)
   let countOfNotEven = List.fold (fun acc elem -> acc + elem) 0 newList
   List.length newList - countOfNotEven

countOfEven2 [1; 2; 3; 4; 5]
