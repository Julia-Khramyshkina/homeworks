let positionOfMaxSum list =
   let rec positionOfMaxSumRec list currentPosition maxValue result =
       match list with
       | h1 :: h2 :: h3 :: t ->
          let newList = h2 :: h3 :: t
          let currentPosition = currentPosition + 1
          if (maxValue < h1 + h3) then
             let maxValue = h1 + h3
             let result = currentPosition
             positionOfMaxSumRec newList currentPosition maxValue result
          else positionOfMaxSumRec newList currentPosition maxValue result
       | _ -> result
   positionOfMaxSumRec list 0 0 0

positionOfMaxSum [1; 2; 3; 4; 5]