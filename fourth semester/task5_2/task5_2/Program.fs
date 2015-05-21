open System
open System.Collections
open System.Collections.Generic

type Tree<'a> =
    | Empty
    | Tip of 'a
    | Tree of 'a * Tree<'a> *Tree<'a>

type Enumerator<'a>(tree : Tree<'a>) =
    let rec treeToList tree =
       match tree with
        | Empty -> []
        | Tip x -> [x] 
        | Tree(x, l, r) ->  x :: treeToList l @ treeToList r
   
    let list = ref (treeToList tree) 

    interface IEnumerator with
       member v.get_Current() =
        let current = (!list).Head :> obj 
        list := (!list).Tail
        current

        member v.MoveNext() = 
         match !list with
         | [] ->
            false
         | _ -> 
            true
        member v.Reset() = list := (treeToList tree)

    interface IEnumerator<'a> with
       member v.get_Current() = (!list).Head
       member v.Dispose () = ()

type BinaryTreeSearch() =
   let mutable tree : Tree<'a> = Empty
   let rec rightmost tree =
       match tree with
       | Empty -> Empty 
       | Tip a -> Tip a
       | Tree(x, l, r) ->
          match r with
          | Empty -> tree
          | _ -> rightmost r                  
   member v.Insert x =
     let rec recInsert x value =
        match value with 
        | Empty -> Tip x         
        | Tip current ->
           if (x < current) then
              Tree(current, Tip x, Empty)
           elif (x > current) then
              Tree(current, Empty, Tip x)  
           else 
              Tree (x, Empty, Empty)
         | Tree(current, l, r) ->
           if (x < current) then
              Tree(current, recInsert x l, r) 
           elif (x > current) then
              Tree(current, l, recInsert x r) 
           else 
              Tree(x, l, r)
     tree <- recInsert x tree
   member v.Exist x = 
     let rec recExist tree x =
        match tree with
        | Empty -> 
           false
        | Tip a ->
           x = a
        | Tree(current, l, r) ->
           if x < current then
              recExist l x
           elif x > current then
              recExist r x
           else 
              true
     recExist tree x
     member v.Remove x = 
        let rec recRemove tree x = 
            match tree with
            | Empty -> Empty
            | Tip a -> 
               if (a = x) then 
                  Empty
               else
                  printfn "%A" "not exist"
                  tree
            | Tree (current, l, r) ->
                if x > current then Tree(current, l, recRemove r x)
                elif x < current then Tree(current, recRemove l x, r)
                else
                   match r with
                   | Empty -> Empty        
                   | _ ->
                     match l with
                     | Empty -> r 
                     | _ ->
                        let forRemove = rightmost l
                        match forRemove with
                        | Tip a -> Tree(a, recRemove l a, r)
                        | _ -> Empty
        if (v.Exist x) then
           tree <- recRemove tree x
        else 
           printfn "not exist"  

   interface IEnumerable with
       member t.GetEnumerator() = new Enumerator<'a>(tree) :> IEnumerator

let tree = new BinaryTreeSearch()
tree.Insert 5
tree.Insert 2
tree.Insert 1
tree.Insert 3
tree.Insert 8
tree.Insert 6
tree.Insert 9

tree.Remove 4
tree.Remove 5

printfn "%A" (tree.Exist 1)

for i in tree do
    printf "%A " i