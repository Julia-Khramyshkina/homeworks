open System
open System.Collections.Generic

type HashTable<'a when 'a: equality>(hashFunction : ('a -> int)) =
   let retMutL i = 
      let mutable list = new List<_>()
      list    
   let mutable hashtable = [for i in 0..499 -> retMutL i]
   let ourHashFunction = hashFunction

   member v.Insert value = 
      let ins value  =
         let cell = ourHashFunction value 
         hashtable.[cell].Add(value)
      ins value

   member v.Remove value =
      let remove value = 
         let cell = ourHashFunction value
         (hashtable.Item cell).Remove(value)
      remove value

   member v.Exist value =
      let exist value =
         let cell = ourHashFunction value
         let list = hashtable.Item cell
         let length = List.length [list]
         let mutable result = false
         for i in 0..length - 1 do
            if (list.[i]) = value then
              result <- true
         result
      exist value

let func = fun x -> (x * 5 + 2) % 499

let hashtable = new HashTable<int>(func)  
hashtable.Insert 1
hashtable.Insert 5
hashtable.Insert 8

let exist = hashtable.Exist 5

hashtable.Remove 5