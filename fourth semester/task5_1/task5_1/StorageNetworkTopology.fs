
module StorageNetworkTopology 
open System.IO
open System.Runtime.Serialization.Formatters.Binary
open OSClass

   type StorageNetworkTopology (input : List<int * string>, matrix : int [][], needSize : int)  =
      let mutable size = 1
      let mutable arrayOfRelations = Array2D.create size size 0

      let mutable matrixOfComputers : OSClass array = Array.zeroCreate size
      member v.ProcessingDataOfNetwork =
         size <- needSize
         arrayOfRelations <- Array2D.create size size 0
         matrixOfComputers <- Array.zeroCreate size

         let rec getMatrixOfComputers count =
            let line = input.[count]
            matrixOfComputers.[count] <- new OSClass(fst line, snd line)
            matrixOfComputers.[count].getData

            if (count + 1 < size) then
               let count = count + 1;
               getMatrixOfComputers count;
         getMatrixOfComputers 0;
         let count = 1 + size;         

         let getRelations =
            for i = 0 to (size - 1) do
                for j = 0 to (size - 1) do
                 arrayOfRelations.[i, j] <- matrix.[i].[j]
         v.TryInfect 100 0

      member v.IsInfected (currentNumber : int) = matrixOfComputers.[currentNumber].isInfected
      member v.SizeOfTopology() = size

      member v.Relations (computer1 : int) (computer2: int) = arrayOfRelations.[computer1, computer2] = 1

      member v.TryInfect (value : int) (computer : int) = matrixOfComputers.[computer].tryInfect(value)