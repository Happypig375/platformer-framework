Public Class [Object]
    Inherits PictureBox
    <Category("_Appearance")> Public Property FixedOnScreenPosition As Boolean
    <Category("_Appearance")> Public Property BaseColor As Color
    <Category("_Appearance")> Public Overridable Property MainSprite As Sprite
    <Category("_Appearance")> Public Property AnimationSpeed As Byte = 10
    <Category("_Appearance")> Public Property Depth As Integer
    <Category("_Appearance")> Public Property Transparency As Byte = 100
    Protected Friend _CurrentSprite As Sprite
    Public Property CurrentSprite() As Sprite
        Get
            Return _CurrentSprite
        End Get
        Set(ByVal value As Sprite)
            _CurrentSprite = value
            Image = value
        End Set
    End Property

End Class
