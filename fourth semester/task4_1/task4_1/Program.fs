let parse string = 
   let rec parseRec string countPosition listCheck =
       if (countPosition <> String.length string) then
          if (string.[countPosition] = '{') then
             let listCheck = '{' :: listCheck;
             let countPosition = countPosition + 1;
             parseRec string countPosition listCheck
          elif (string.[countPosition] = '(') then
             let listCheck = '(' :: listCheck;
             let countPosition = countPosition + 1;
             parseRec string countPosition listCheck
          elif (string.[countPosition] = '[') then
             let listCheck = '[' :: listCheck;
             let countPosition = countPosition + 1;
             parseRec string countPosition listCheck;
          else
             if (string.[countPosition] = ']' && List.head listCheck <> '[' || string.[countPosition] = '}' && List.head listCheck <> '{' || string.[countPosition] = ')' && List.head listCheck <> '(') then
                false;
             else 
                let listCheck = List.tail listCheck;
                let countPosition = countPosition + 1;
                if (countPosition >= String.length string && List.length listCheck = 0) then 
                   true;
                else    
                   parseRec string countPosition listCheck
       else 
          if (List.length listCheck = 0) then
             true;
          else 
             false;
   parseRec string 0 [];

parse "([])";
parse "{([)]}";
parse "{([";
parse "{[)";
parse "";