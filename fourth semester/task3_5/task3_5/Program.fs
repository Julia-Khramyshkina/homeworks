type PartOfTree =
    | Plus of PartOfTree * PartOfTree
    | Minus of PartOfTree * PartOfTree
    | Multy of PartOfTree * PartOfTree
    | Divide of PartOfTree * PartOfTree
    | Number of int

let resultOfCalculateExpression tree = 
   let rec resultOfArithmeticExpression tree result =
       match tree with
       | Plus(l, r) ->
          let result = resultOfArithmeticExpression l result + resultOfArithmeticExpression r result
          result
       | Minus(l, r) ->
          let result =resultOfArithmeticExpression l result - resultOfArithmeticExpression r result
          result
       | Multy(l, r) ->
          let result = resultOfArithmeticExpression l result * resultOfArithmeticExpression r result
          result
       | Divide( l, r) ->
          let result = resultOfArithmeticExpression l result / resultOfArithmeticExpression r result
          result
       | Number x  -> x

   resultOfArithmeticExpression tree 0

let expr = (Plus (Minus(Number 1, Number 3), Number 9));

printfn "%A"  <| resultOfCalculateExpression expr 