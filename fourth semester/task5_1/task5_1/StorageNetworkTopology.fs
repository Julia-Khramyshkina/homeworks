
module StorageNetworkTopology 
open System.IO
open System.Runtime.Serialization.Formatters.Binary
open OSClass

   type StorageNetworkTopology (res : List<string>)  =
//      let input = new FileStream("Data.txt", FileMode.Open)
//          
//      let readValue inputStream =
//        let formatter = new BinaryFormatter()
//        let res = formatter.Deserialize(inputStream)
//        unbox res
//      let res : List<string> = readValue input

      let mutable size = 1;
      let mutable arrayOfRelations = Array2D.create size size 0

      let mutable matrixOfComputers : OSClass array = Array.zeroCreate size; 
      member v.ProcessingDataOfNetwork =
         size <- int res.[0];
         arrayOfRelations <- Array2D.create size size 0
         matrixOfComputers <- Array.zeroCreate size;

         let rec getMatrixOfComputers count =
            let line = res.[count];
            matrixOfComputers.[count - 1] <- new OSClass(line);
            matrixOfComputers.[count - 1].getData

            if (count  < size) then
               let count = count + 1;
               getMatrixOfComputers count;
         getMatrixOfComputers 1;
         let count = 1 + size;         

         let rec getRelations i =
             if (i < size) then
                let line = res.[i + size + 1];
                let buf = line.Split(' ');
                let rec getRelationsInside j =
                   if (size > j) then
                      arrayOfRelations.[i, j] <- int buf.[j];
                      let j = j + 1;
                      getRelationsInside j;
                getRelationsInside 0;
                let i = i + 1;
                getRelations i;
         getRelations 0;
         v.TryInfect 100 0

      member v.IsInfected (currentNumber : int) = matrixOfComputers.[currentNumber].isInfected;
      member v.SizeOfTopology() = size;

      member v.Relations (computer1 : int) ( computer2: int) = arrayOfRelations.[computer1, computer2] = 1;

      member v.TryInfect (value : int) (computer : int) = matrixOfComputers.[computer].tryInfect(value);

