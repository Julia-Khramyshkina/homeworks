type Tree<'a> =
    | Tree of 'a * Tree<'a> * Tree<'a>
    | Tip of 'a

let evenCheck = fun x -> x % 2 = 0;

let funcWithCondition tree condition =
   let rec functionWithCondition tree condition result =
       match tree with
       | Tree (a, l, r) ->
          let result = functionWithCondition (Tip a) condition result @ functionWithCondition l condition result @ functionWithCondition r condition result;
          result;
       | Tip a ->
          let returnBool = condition a;
          if (returnBool) then
             [a];
          else 
             [];
   functionWithCondition tree condition [];

let tree = Tree(6, Tree(2, Tip(3), Tip(4)), Tip(9));

funcWithCondition tree evenCheck;
