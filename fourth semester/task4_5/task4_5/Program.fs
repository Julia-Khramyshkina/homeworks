type Tree<'a> =
    | Tree of 'a * Tree<'a> * Tree<'a>
    | Empty

let tree = Tree(6, Tree(2, Tree(1, Tree(4, Empty, Empty), Tree(5, Empty, Empty)), Tree(3, Empty, Empty)),Tree(9, Empty, Empty))

let testMap  =  function y -> y + 1
let doMap func list  =
   list |> List.map func

let rec getList tree list  =
    match tree with
    | Tree(a, l, r) -> 
       let list = [a]  @ getList l list @ getList r list;
       list;
    | Empty -> [];
     
let rec getTree list =
   let rec insert h t =
       match t with
       | Tree(hd, l, r) ->
         if h < hd then
            Tree(hd, (insert h l), r)
         else
           Tree(hd, l, (insert h r)) 
       | Empty -> Tree(h, Empty, Empty)
        
   match list with
   | h :: t -> insert h (getTree t)
   | [] -> Empty

let mapTree tree func = 
   getTree(doMap func (getList tree []))

mapTree tree testMap;
