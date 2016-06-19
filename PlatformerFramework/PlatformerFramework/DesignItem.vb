''' <summary>
''' This object is a design element. It can be a background or foreground graphics element, stationary or moving in different directions.
''' </summary>
Public Class DesignItem
    Inherits Subject
    <Category("_Actions")> Public Property MovingSpeed As Byte
    <Category("_Actions")> Public Property MovingDirection As Direction
    <Category("_Actions")> Public Property RotationSpeed As Byte
End Class
