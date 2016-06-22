''' <summary>
''' This object is a point (either start point, aka departure, and end point, aka destination) of teleporting.
''' </summary>
Public Class Teleporter
    Inherits InteractiveInterface
    <Category("_Teleporting")> Public Property PlaySound As IO.Stream
    <Category("_Teleporting")> Public Property TeleportToTeleporter As Integer
    <Category("_Teleporting")> Public Property TeleporterType As TeleporterType
End Class
