module GeometryPrimitives
    type Point2D =
        { X: float
          Y: float }
        //static member (+) (a: Coordinates, b: Coordinates) =
        //    { X = a.X + b.X
        //      Y = a.Y + b.Y }
        //static member (/) (a: Coordinates, b: Coordinates) =
        //    let coord = a + b
        //    { X = coord.X / 2.; Y = coord.Y / 2. }
          
    type CirclePoint =
        { C: Point2D }
    
    type RectanglePoints =
        { A: Point2D
          B: Point2D
          C: Point2D
          D: Point2D }

    type TrianglePoints =
        { A: Point2D
          B: Point2D
          C: Point2D }
    
    type Shape =
        | Circle of CirclePoint * Radius: float
        | Rectangle of RectanglePoints
        | Triangle of TrianglePoints