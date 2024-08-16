open System

let random = Random()

let GenerateRandomNumbers count min max =
    List.init count (fun _ -> random.Next(min, max + 1))
let randomNumbers = GenerateRandomNumbers 10 1 100

printfn "Rastgele Sayılar: %A" randomNumbers

let sum = List.sum randomNumbers
printfn "Toplam: %d" sum

let average = float sum / float (List.length randomNumbers)
printfn "Ortalama: %f" average


let threshold = 50
let filteredNumbers = List.filter (fun x -> x > threshold) randomNumbers
printfn "Eşik Değerinden Büyük Sayılar (%d): %A" threshold filteredNumbers