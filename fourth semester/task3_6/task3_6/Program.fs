let isPrime number = 
   let rec isPrimeRec number currentNumber =
       let currentNumber = currentNumber + 1
       if (currentNumber < (number / 2) && number % currentNumber <> 0) then 
         isPrimeRec number currentNumber
       elif (number % currentNumber = 0 && number <> currentNumber) then
         false
       elif (currentNumber < number) then
         isPrimeRec number currentNumber
       else
         true
   isPrimeRec number 1

let primes =
    Seq.initInfinite (fun i -> i + 2) 
    |> Seq.filter isPrime