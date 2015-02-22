let rec multy number result =
    if (number = 0) then
       result
    else
       let tempNumber = number % 10  
       let result = result * tempNumber
       let number = number / 10
       multy number result

multy 12345 1