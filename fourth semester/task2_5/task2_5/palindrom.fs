let rec palindrom input size firstPos secondPos =
    if (String.length input = size) && ((firstPos - secondPos) = 0 || (firstPos - secondPos) = 1 || (secondPos - firstPos) = 1) then
       if input.[firstPos] = input.[secondPos] then
          printfn "This string is a palindrom"
       else
          printfn "This string isn't a palindrom"
    else 
       if (input.[firstPos] = input.[secondPos]) then
          let firstPos = firstPos + 1
          let secondPos = secondPos - 1
          palindrom input size firstPos secondPos
       else
          printfn "This string isn't a palindrom"


palindrom "ollo" 4 0 3  
palindrom "ololo" 5 0 4    
palindrom "o" 1 0 0     
palindrom "ol" 2 0 1                         