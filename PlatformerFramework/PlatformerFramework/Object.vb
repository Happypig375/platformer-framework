Public Class [Object]
    Inherits PictureBox
    Protected Friend _Sprite As Sprite
    Public Property Sprite() As Sprite
        Get
            Return _Sprite
        End Get
        Set(ByVal value As Sprite)
            _Sprite = value
            Image = value
        End Set
    End Property

End Class
