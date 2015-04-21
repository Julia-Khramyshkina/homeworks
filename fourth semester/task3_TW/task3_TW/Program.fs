open System
open System.Collections.Generic

type HashTable<'a when 'a: equality>(hashFunction : ('a -> int)) =
   let mutable hashtable = [for i in 0..499 -> new List<_>()]
   member v.Insert value = 
      let cell = hashFunction value 
      hashtable.[cell].Add(value)

   member v.Remove value =
      let cell = hashFunction value
      (hashtable.Item cell).Remove(value)

   member v.Exist value =
      let cell = hashFunction value
      let list = hashtable.Item cell
      let res = list.Contains(value)
      res

let func = fun x -> (x * 5 + 8) % 500

let hashtable = new HashTable<int>(func)  
hashtable.Insert 1
hashtable.Insert 5
hashtable.Insert 8

let exist = hashtable.Exist 5

hashtable.Remove 5