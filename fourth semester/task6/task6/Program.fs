type RoundingBuilder (accuracy : int) =
    member this.Bind ((x : float) , rest) =
         rest x   
    member this.Return (x : float) = 
        System.Math.Round(x, accuracy)

let test = 
   RoundingBuilder 3 {
      let! a = 2.0 / 12.0
      let! b = 3.5
      return a / b
   }

test