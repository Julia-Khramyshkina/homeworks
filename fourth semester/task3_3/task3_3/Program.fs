let countOfEven list = 
   let evenList = List.filter (fun x -> x % 2 = 0) list
   List.length evenList

countOfEven [1; 2; 3; 4; 5]

let countOfEven2 list = 
   let count = List.fold (fun res x -> if x % 2 = 0 then (res + 1) else res) 0 list
   count

countOfEven2 [1; 2; 3; 4; 5]

let countOfEven3 list = 
   let newList = list |> List.map (fun x -> (x + 1) % 2)
   List.sum newList

countOfEven3 [1; 2; 3; 4; 5] 
