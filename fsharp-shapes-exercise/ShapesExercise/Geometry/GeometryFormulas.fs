module GeometryFormulas
    open GeometryPrimitives
    
    /// <summary>
    /// Calculates the distance between two points.
    /// </summary>
    /// <param name="p">The first point.</param>
    /// <param name="q">The second point.</param>
    let pointDistance p q =
        let dx = p.X - q.X
        let dy = p.Y - q.Y
        sqrt(dx * dx + dy * dy)
    
    /// <summary>
    /// Calculates the area of a circle.
    /// </summary>
    /// <param name="r">The radius of the circle.</param>
    let circleArea r =
        System.Math.PI * r ** 2.
    
    /// <summary>
    /// Calculates the area of a rectangle.
    /// </summary>
    /// <param name="points">The points of the rectangle.</param>
    let rectangleArea (points: RectanglePoints) =
       (pointDistance points.A points.B) * (pointDistance points.B points.C)
    
    /// <summary>
    /// Calculates the area of a triangle.
    /// </summary>
    /// <param name="points">The points of the triangle.</param>
    let triangleArea (points: TrianglePoints) =
        abs (points.A.X * (points.B.Y - points.C.Y) +
            points.B.X * (points.C.Y - points.A.Y) +
            points.C.X * (points.A.Y - points.B.Y)) / 2.
    

    let center shape =
        match shape with
        | Circle (point, _) -> { X = point.C.X; Y = point.C.Y }
        //| Rectangle (points) -> { X = (((points.A + points.B) / 2.)); Y = ((points.C + points.D) / 2.)}
        //| Rectangle (points) -> { A = addCoordinates points.A }