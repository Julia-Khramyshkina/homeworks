type Tree<'a> =
    | Tree of 'a * Tree<'a> * Tree<'a>
    | Tip of 'a 

let testMap  = function y -> y + 1

let rec mapTree tree func = 
    match tree with
    | Tree (value, left, right) -> Tree (func value, mapTree left func, mapTree right func)
    | Tip value -> Tip (func value)

let tree = Tree(6, Tree(2, Tip(1), Tip(3)), Tip(9))

mapTree tree testMap;
