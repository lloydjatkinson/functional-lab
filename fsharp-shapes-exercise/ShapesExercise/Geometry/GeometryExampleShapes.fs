module GeometryExampleShapes
    open GeometryPrimitives

    let singleCircle = Circle({ C = { X = 5. ; Y = 5. }}, Radius = 2.)

    let singleRectangle = Rectangle({ A = { X = 10. ; Y = 4. }
                                      B = { X = 15. ; Y = 4. }
                                      C = { X = 15. ; Y = 6. }
                                      D = { X = 10. ; Y = 6. } })
    
    let singleTriangle = Triangle({ A = { X = 28. ; Y = 6. }
                                    B = { X = 48. ; Y = 6. }
                                    C = { X = 43. ; Y = 11. }})
    
    let shapeCollection =
        [ Circle({ C = { X = 5. ; Y = 5. }}, Radius = 2.)

          Circle({ C = { X = 28. ; Y = 11. }}, Radius = 2.)

          Rectangle({ A = { X = 10. ; Y = 4. }
                      B = { X = 15. ; Y = 4. }
                      C = { X = 15. ; Y = 6. }
                      D = { X = 10. ; Y = 6. } })

          Rectangle({ A = { X = 16. ; Y = 23. }
                      B = { X = 32. ; Y = 23. }
                      C = { X = 32. ; Y = 28. }
                      D = { X = 16. ; Y = 28. } })

          Rectangle({ A = { X = 6. ; Y = 29. }
                      B = { X = 8. ; Y = 29. }
                      C = { X = 8. ; Y = 39. }
                      D = { X = 6. ; Y = 39. } })
          
          Triangle({ A = { X = 38. ; Y = 6. }
                     B = { X = 48. ; Y = 6. }
                     C = { X = 43. ; Y = 11. } })

          Triangle({ A = { X = 14. ; Y = 40. }
                     B = { X = 18. ; Y = 40. }
                     C = { X = 16. ; Y = 42. } })]
          