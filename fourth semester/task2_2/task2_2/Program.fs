let rec powerOfFive start count list = 
    if count = -1 then 
       list @ [start]   
    else
       let list = list @ [start]
       let start = start * 2
       let count = count - 1 
       powerOfFive start count list

powerOfFive 2 4 []

