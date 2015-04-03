let sumOfFibonacchiEven = 
   let fibSeq = Seq.unfold (fun (a,b) -> Some(a+b, (b, a+b))) (0,1)
   let fibList = fibSeq |> Seq.takeWhile (fun x -> x <= 1000000 ) |> Seq.toList
   let fibEvenList = List.filter (fun x -> x % 2 = 0) fibList
   let sumOffibEvenList = List.sum fibEvenList;
   sumOffibEvenList;

sumOfFibonacchiEven;