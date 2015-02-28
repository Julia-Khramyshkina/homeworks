type Tree<'a> =
    | Tree of 'a * Tree<'a> * Tree<'a>
    | Tip of 'a

let rec size tree =
    match tree with
    | Tree(_, l, r) -> 1 + size l + size r
    | Tip _ -> 1

let tree = Tip (5)
size tree

let tree1 = Tree(6, Tree(2, Tip(1), Tip(3)), Tip(9))
size tree1