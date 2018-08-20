module GeometryOperations
    open GeometryPrimitives
    open GeometryFormulas
    
    let addCoordinates coord1 coord2 =
        let x = coord1.X + coord2.X
        let y = coord1.Y + coord2.Y
        { X = x ; Y = y }

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