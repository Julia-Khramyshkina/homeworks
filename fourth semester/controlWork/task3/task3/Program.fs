open System.Collections.Generic;;

type elementWithPriority (element : int, priority : int) = 
   member v.Element = element;
   member v.Priority = priority;

type priorityQueue() = 
   let list = new List<elementWithPriority>();

   member v.Insert (element: int) ( priority : int) =
      let rec insert position =
        if (list.[position].Priority > priority)  then
           let position = position + 1;
           insert position
        elif (list.[position].Priority = priority && position < List.length list) then 
            if (list.[position + 1].Priority = priority) then
               let position = position + 1;
               insert position;
            else 
            let temp = elementWithPriority(element, priorityQueue);
            list.[position + 1] <- temp;
            
        else   
            let temp = elementWithPriority(element, priorityQueue);
            List.append list [temp];
// insert 0;





   
