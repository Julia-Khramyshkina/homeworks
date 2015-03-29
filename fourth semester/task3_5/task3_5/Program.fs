type PartOfTree =
    | Plus of PartOfTree * PartOfTree
    | Minus of PartOfTree * PartOfTree
    | Multy of PartOfTree * PartOfTree
    | Divide of PartOfTree * PartOfTree
    | One
    | Two
    | Three
    | Four
    | Five
    | Six
    | Seven
    | Eight
    | Nine
    | Zero


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
       | x  -> 
          match x with
          | One -> 1
          | Two -> 2
          | Three -> 3
          | Four -> 4
          | Five -> 5
          | Six -> 6
          | Seven -> 7
          | Eight -> 8
          | Nine -> 9
          | Zero -> 0
   resultOfArithmeticExpression tree 0

let expr = (Plus (Minus(One, Three), Nine));

printfn "%A"  <| resultOfCalculateExpression expr 