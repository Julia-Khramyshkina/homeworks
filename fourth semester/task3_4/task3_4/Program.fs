type Tree<'a> =
    | Tree of 'a * Tree<'a> * Tree<'a>
    | Tip of 'a

let rec high tree = 
    match tree with 
        | Tree (_, l, r) -> 
           let result =  1 + max (high l) (high r)
           result
        | Tip _ -> 1

let tree1 = Tree(6, Tree(2, Tip(1), Tip(3)), Tip(9))
high tree1