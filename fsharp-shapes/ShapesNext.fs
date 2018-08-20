module GeometryPrimitives =
    type Coordinates =
        { X: float
          Y: float }
        //static member (+) (a: Coordinates, b: Coordinates) =
        //    { X = a.X + b.X
        //      Y = a.Y + b.Y }
        //static member (/) (a: Coordinates, b: Coordinates) =
        //    let coord = a + b
        //    { X = coord.X / 2.; Y = coord.Y / 2. }
          
    type CirclePoint =
        { C: Coordinates }
    
    type RectanglePoints =
        { A: Coordinates
          B: Coordinates
          C: Coordinates
          D: Coordinates }

    type TrianglePoints =
        { A: Coordinates
          B: Coordinates
          C: Coordinates }
    
    type Shape =
        | Circle of CirclePoint * Radius: float
        | Rectangle of RectanglePoints
        | Triangle of TrianglePoints

module GeometryFormulas =
    open GeometryPrimitives
    
    let pointDistance p q =
        let dx = p.X - q.X
        let dy = p.Y - q.Y
        sqrt(dx * dx + dy * dy)

    let circleArea r =
        System.Math.PI * r ** 2.
    
    let rectangleArea (points: RectanglePoints) =
       (pointDistance points.A points.B) * (pointDistance points.B points.C)
    
    let triangleArea (points: TrianglePoints) =
        abs (points.A.X * (points.B.Y - points.C.Y) +
            points.B.X * (points.C.Y - points.A.Y) +
            points.C.X * (points.A.Y - points.B.Y)) / 2.
    
    let center shape =
        match shape with
        | Circle (point, _) -> { X = point.C.X; Y = point.C.Y }
        //| Rectangle (points) -> { X = (((points.A + points.B) / 2.)); Y = ((points.C + points.D) / 2.)}
        //| Rectangle (points) -> { A = addCoordinates points.A }


module GeometryOperations =
    open GeometryPrimitives
    open GeometryFormulas
    
    let addCoordinates coord1 coord2 =
        let x = coord1.X + coord2.X
        let y = coord1.Y + coord2.Y
        { X = x ; Y = y }
    
    //let rectangleCenter (rectangle) =
    //    rectangle.
    
    //let addRectangle

    let area shape =
        match shape with
        | Circle (_, r) -> circleArea r
        | Rectangle (points) -> rectangleArea points
        | Triangle (points) -> triangleArea points
        
    
    let move shape coordinates =
        match shape with
        | Circle (_, r) -> Circle({ C = coordinates }, r)
        //| Rectangle (points) -> Rectangle({ A = coordinates. }) 
        //| Triangle (points) -> Triangle(coordinates)
        
open GeometryPrimitives
open GeometryFormulas
open GeometryOperations

let rect1 = Rectangle ({ A = { X = 7. ; Y = 11. }
                         B = { X = 14. ; Y = 11. }
                         C = { X = 14. ; Y = 18. }
                         D = { X = 7. ; Y = 18. } })

printfn "%f" (area rect1)