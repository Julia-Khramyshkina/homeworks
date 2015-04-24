open System
open System.Collections.Generic

exception ErrorOfEmpty of string

type Stack<'a>() = 
   let list = new List<'a>()
   
   member v.Push value = 
      list.Add(value)

   member v.Pop() =
      if (v.IsEmpty()) then
         raise(ErrorOfEmpty("Empty stack")) 
      let last = list.Count
      let value = list.Item (last - 1)
      list.RemoveAt (last - 1)
      value

   member v.IsEmpty() =
      let count = list.Count
      count = 0

let test = new Stack<int>()
test.Push 1
test.Push 4
test.Push 5

try
   printfn "%d" (test.Pop())
   printfn "%d" (test.Pop())
   printfn "%d" (test.Pop())
   printfn "%d" (test.Pop())
    
with
    | ErrorOfEmpty(message) -> printfn "Error! -- %A" message

let check = test.IsEmpty()
printfn "Is Empty: %A" check