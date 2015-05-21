module OSClass 

    type OSClass (input : (int * string)) =
       let mutable isInfection = false
       let mutable probabilityOfInfection = 0
       let mutable number = 1

       member v.infection value = 
           if (value = "Windows") then
              75
           elif (value = "Linux") then
              66
           else
              80

       member v.getData =
         number <- fst input    
         let temp = snd input
         probabilityOfInfection <- v.infection temp

       member v.giveProbability value =
         probabilityOfInfection <- v.infection value
       member v.Infected = 
          isInfection <- true
       member v.tryInfect (value : int) = 
         if (probabilityOfInfection <= value) then
            v.Infected
       member v.ProbabilityOfInfection = probabilityOfInfection    
       member v.isInfected =  isInfection
       