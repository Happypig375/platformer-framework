''' <summary>
''' This object is a block.
''' </summary>
Public Class Block
    Inherits Subject
    <Category("_Behaviour")> Public Property BlockType As BlockType = BlockType.Block
    <Category("_Behaviour")> Public Property FadeOutSpeed As Byte = 10
    <Category("_Behaviour")> Public Property PlaySoundWhenPlayerWalksOn As IO.Stream
    <Category("_Behaviour")> Public Property MovingSpeed As Byte
    <Category("_Behaviour")> Public Property IgnoreBullets As Boolean
End Class
