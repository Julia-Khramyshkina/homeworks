let func x l = List.map (fun y -> y * x) l;

let func1 x : int list -> int list  = 
   List.map (fun y -> y * x);

let func2 x : int list -> int list  = 
   List.map (fun y -> (*) x y);

let func3 x : int list -> int list  = 
   List.map ((*) x);;

let func4 : int -> int list -> int list  = 
   List.map << (*)