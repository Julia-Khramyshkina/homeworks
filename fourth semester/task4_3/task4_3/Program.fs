open System.IO
open System.Runtime.Serialization.Formatters.Binary

let rec countInformationSave listNames listPhones position result =
    if (List.length listNames <> position && List.length listPhones <> position) then 
       let result = listPhones.[position] :: result
       let result = listNames.[position] :: result
       let position = position + 1
       countInformationSave listNames listPhones position result
    else result

let rec informationGetNames list resultListNames  =
    match list with 
    | h1 :: h2 :: t -> 
          let resultListNames = h1 :: resultListNames
          informationGetNames t resultListNames 
    | _ -> resultListNames

let rec informationGetPhones list resultListPhones =
    match list with 
    | h1 :: h2 :: t -> 
          let resultListPhones = h2 :: resultListPhones
          informationGetPhones t resultListPhones
    | _ -> resultListPhones

let writeValue outputStream (x: 'a) =
    let formatter = new BinaryFormatter()
    formatter.Serialize(outputStream, box x)
    
let readValue inputStream =
    let formatter = new BinaryFormatter()
    let res = formatter.Deserialize(inputStream)
    unbox res

let addRecordName result =
   let name = System.Console.ReadLine()
   name :: result

let addRecordPhone result =
   let number = System.Console.ReadLine()
   number :: result

let rec searchPosition list key result =
    let size = List.length list
    match list with
    | h :: t -> 
       if (h = key) then result
       else 
         let result = result + 1
         if result < size then
            searchPosition t key result
         else -1
    | [] -> result

let phoneAndNameList =
   let rec phone listNames listPhones command = 
      printfn "hello! this is phoneBook: please input command
    0 - out
    1 - add rocrd (name and phone)
    2 - search phone for name
    3 - seacrh name for phone
    4 - save count data in file
    5 - read data from file\n"
      let command =  System.Console.ReadLine()
      match command with
      | "0" -> printfn "good-bye"
      | "1" -> 
         printfn "please input new name"
         let listNames = addRecordName listNames
         printfn "please input new phone"
         let listPhones = addRecordPhone listPhones
         phone listNames listPhones command
      | "2" -> 
         printfn "please input name for search phone"
         let temp = System.Console.ReadLine()
         let count = searchPosition listNames temp 0
         if count = -1 then
            printfn "%s" "not exist"
         else
            let number = listPhones.[count]
            printfn "phone: %s" number
         phone listNames listPhones command
      | "3" ->
         printfn "please input phone for search name"
         let number = System.Console.ReadLine()
         let count = searchPosition listPhones number 0
         if count = -1 then
            printfn "%s" "not exist" 
         else
            let name = listNames.[count]
            printfn "name: %s" name
         phone listNames listPhones command
      | "4" ->
         let fsOut = new FileStream("Data.txt", FileMode.Create)
         let toSave =  countInformationSave listNames listPhones 0 []
         writeValue fsOut toSave
         fsOut.Close()
         printfn "data saved"
         phone listNames listPhones command
      | "5" ->
         let fsIn = new FileStream("Data.txt", FileMode.Open)
         let res : List<string> = readValue fsIn
         fsIn.Close()
         let listNames = informationGetNames res []
         let listPhones = informationGetPhones res []
         printfn "data gotten"
         phone listNames listPhones command
      | _ -> printfn "incorrect input"
   phone [] [] ""

phoneAndNameList;