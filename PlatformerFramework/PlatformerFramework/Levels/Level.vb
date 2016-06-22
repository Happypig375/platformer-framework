Public Class Level
    <Category("_Appearence")> Public Property LevelType As LevelType = LevelType.Playable

    ''' <summary>
    ''' Level graphics will be rendered on all other levels, which is useful for GUI design (Score, Health, etc)
    ''' </summary>
    ''' <returns></returns>
    <Category("_SpecialGUISetting")> Public Property SpecialGUISetting As Boolean

    ''' <summary>
    ''' In number of screens.
    ''' </summary>
    ''' <returns></returns>
    <Category("_Size")> Public Property Width As Byte = 1
    ''' <summary>
    ''' In number of screens.
    ''' </summary>
    ''' <returns></returns>
    <Category("_Size")> Public Property Height As Byte = 1

    <Category("_Background")> Public Property Color As Color = Color.Black
    <Category("_Background")> Public Property Gradient As Boolean
    <Category("_Background")> Public Property GradientStart As Color = Color.Blue
    <Category("_Background")> Public Property GradientEnd As Color = Color.White
    <Category("_Background")> Public Property GradientType As GradientType
    <Category("_Background")> Public Property Pattern As Boolean
    <Category("_Background")> Public Property PatternSprite As Sprite
    <Category("_Background")> Public Property FixedPosition As Boolean
    <Category("_Background")> Public Property Transparency As Byte = 100

    <Category("_WhenStart")> Public Property PlayMusic As IO.Stream
    <Category("_WhenStart")> Public Property PlayMode As AudioPlayMode = AudioPlayMode.BackgroundLoop
    <Category("_WhenStart")> Public Property ResetPlayerHealth As Boolean = True
    <Category("_WhenStart")> Public Property ResetDoorKeys As Boolean = True
    <Category("_WhenStart")> Public Property ResetSwitches As Boolean = True
    <Category("_WhenStart")> Public Property ResetInventory As Boolean
    Function Divide(Frames As UInteger, FrameRate As UInteger) As String
        Dim 
    End Function
End Class
