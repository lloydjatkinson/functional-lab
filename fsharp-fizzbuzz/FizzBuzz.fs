let fizzbuzz n =
    match n % 3 = 0, n % 5 = 0 with
    | true, false -> "Fizz"
    | false, true -> "Buzz"
    | true, true -> "FizzBuzz"
    | false, false -> sprintf "%d" n

let fizzbuzzSequence x y =
    [x..y] |> Seq.map fizzbuzz

fizzbuzzSequence 1 100 |> Seq.iter (printfn "%s")

// Alternative version without intermediate collection
[1..100]
    |> Seq.map fizzbuzz
    |> Seq.iter (printfn "%s")
