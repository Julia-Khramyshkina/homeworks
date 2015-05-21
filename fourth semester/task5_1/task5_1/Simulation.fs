module Simulation 
open StorageNetworkTopology
open System

   type Simulation(random : System.Random, input : List<int * string>, matrix : int [][], needSize : int) = 
      let mutable networkTopology : StorageNetworkTopology = StorageNetworkTopology(input, matrix, needSize)
      member v.ChangeNetworkState = 
         networkTopology.ProcessingDataOfNetwork
         let infected : bool array ref = ref (Array.zeroCreate (networkTopology.SizeOfTopology()))

         let rec getInfectedArray count =
             if (count < networkTopology.SizeOfTopology()) then
                (!infected).[count] <- networkTopology.IsInfected(count)
                let count = count + 1
                getInfectedArray count
         getInfectedArray 0
         let randNext = random.Next()
         let sizeT = networkTopology.SizeOfTopology()

         let array : int array ref = ref (Array.create sizeT -1)
         let count : int ref = ref 0

         for i in 0 .. sizeT - 1 do
            if (!infected).[i] = true then
               for j in 0 .. sizeT - 1 do
               if networkTopology.Relations i j then
                  (!array).[!count] <- j
                  count := !count + 1

         let length = Array.length !array
         let rec go i =
            if (i < length) then
               if (!array).[i] <> -1 then
                  networkTopology.TryInfect randNext (!array).[i] 
               let i = i + 1
               go i
         go 0 

      member v.ShowState (currentComputer : int) =
         if (networkTopology.IsInfected(currentComputer)) then
            "is infected."
         else
            "is healthy."

      member v.ShowAllStates =
        let rec show i = 
            if i < networkTopology.SizeOfTopology() then
               let number = string i;
               let separate = string " "
               printfn "%A" (number + separate + v.ShowState(i))
               let i = i + 1
               show i
        show 0  