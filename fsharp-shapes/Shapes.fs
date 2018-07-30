open System

type Coordinates =
    { X: float
      Y: float }

type Size =
    | SquareSize of size: float
    | RectangleSize of width: float * height: float
    | CircleSize of radius: float

type Shape =
    | Square of size: float * Coordinates option
    | Rectangle of width: float * height: float * Coordinates option
    | Circle of radius: float * Coordinates option
    
let area shape =
    match shape with
    | Square (s, _) -> s * s
    | Rectangle (h, w, _) -> h * w
    | Circle (r, _) -> Math.PI * r ** 2.

let updateSize shape size : Result<Shape, string> =
    match shape, size with
    | Square (_, c), SquareSize side -> Square(side, c) |> Ok
    | Rectangle (_, _, c), RectangleSize (w, h) -> Rectangle(w, h, c) |> Ok
    | Circle (_, c), CircleSize radius -> Circle(radius, c) |> Ok
    | othershape, othersize ->
        sprintf "[%A] cannot be resized with [%A]" othershape othersize
            |> Error

let updateCoordinates shape coordinates =
    match shape with
    | Square (s, _) -> Square(s, coordinates)
    | Rectangle (h, w, _) -> Rectangle(h, w, coordinates)
    | Circle (r, _) -> Circle(r, coordinates)

let shapeDescription shape =
    match shape with
    | Square(s, _) -> sprintf "Square - W: %.2f H: %.2f A: %.2f" s s (area shape)
    | Rectangle(h, w, _) -> sprintf "Rectangle - W: %.2f H: %.2f A: %.2f" h w (area shape)
    | Circle(r, _) -> sprintf "Circle - A: %.2f" (area shape)

//let square = Square(10.0, None)
//let movedSquare = updateCoordinates square (Some { X = 50.0; Y = 25.0 })

//printfn "%s" (shapeDescription square (area square))
//printfn "%s" (shapeDescription movedSquare (area movedSquare))

let circle = Circle(20., None)
let resizedCircle = updateSize circle (CircleSize(40.))

//printfn "%s" (shapeDescription circle (area circle))
//printfn "%s" (shapeDescription resizedCircle (area resizedCircle))

let circle2 = Circle(20., None)
match updateSize circle (SquareSize(40.)) with
| Ok newCircle -> printfn "New Circle: %A" newCircle
| Error why -> printfn "Error: %s" why

let shapes = 
    [ Circle(5.0, None)
      Rectangle(5., 10., None)
      Rectangle(15., 20., None)
      Rectangle(25., 30., None)
      Square(15., None)
      Square(20., None) ]

let describedShapes shapes =
    shapes |> Seq.map shapeDescription

describedShapes shapes |> Seq.iter (fun d -> printfn "%s" d)