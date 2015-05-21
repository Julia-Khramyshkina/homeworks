module Work
open Simulation

let rand = new System.Random(100)

let list = (0, "Windows") :: (1, "Linux") :: (2, "Mac") :: (3, "Windows") :: [(4, "Linux")]
let matrix = [| [|0; 1; 0; 0; 1|]; [|1; 0; 0; 1; 0|]; [|0; 0; 0; 1; 0|]; [|0; 1; 1; 0; 0|]; [|1; 0; 0; 0; 0|] |]
let size = 5

let network = new Simulation(rand, list, matrix, size)
   

let rec someChanges number i = 
   network.ChangeNetworkState
   network.ShowAllStates
   printfn "%s" "end of state\n"
   let i = i + 1
   if (i < number) then
      someChanges number i
someChanges 100 0

