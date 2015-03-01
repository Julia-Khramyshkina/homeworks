type Tree<'a> =
    | Tree of 'a * Tree<'a> * Tree<'a>
    | Tip of 'a

let resultOfCalculateExpression tree = 
   let rec resultOfArithmeticExpression tree result =
       match tree with
       | Tree('+', l, r) ->
          let result = resultOfArithmeticExpression l result + resultOfArithmeticExpression r result
          result
       | Tree('-', l, r) ->
          let result =resultOfArithmeticExpression l result - resultOfArithmeticExpression r result
          result
       | Tree('*', l, r) ->
          let result = resultOfArithmeticExpression l result * resultOfArithmeticExpression r result
          result
       | Tree('/', l, r) ->
          let result = resultOfArithmeticExpression l result / resultOfArithmeticExpression r result
          result
       | Tip x  -> 
          match x with
          | '1' -> 1
          | '2' -> 2
          | '3' -> 3
          | '4' -> 4
          | '5' -> 5
          | '6' -> 6
          | '7' -> 7
          | '8' -> 8
          | '9' -> 9
          | '0' -> 0
   resultOfArithmeticExpression tree 0

let tree = Tree('+', Tree('-', Tip('1'), Tip('3')), Tip('9'))

resultOfCalculateExpression tree 