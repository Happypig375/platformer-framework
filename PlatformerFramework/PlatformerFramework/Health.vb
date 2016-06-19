''' <summary>
''' This object displays the actual health of the player.
''' </summary>
Public Class Health
    Inherits [Interface]
    <Category("_Appearance")> Public Property DrawHealthBar As Boolean
    <Category("_Appearance")> Public Property HealthBarWidth As UShort = 100
    <Category("_Appearance")> Public Property HealthBarHeight As Byte = 6
    <Category("_Appearance")> Public Property HealthBarColor As Color = Color.Blue
End Class
