''' <summary>
''' This object is a hurting zone. This object will decrease the player's health when the player touches it.
''' </summary>
Public Class HurtingZone
    Inherits Subject
    <Category("_WhenTouched")> Public Property TouchedSound As IO.Stream
    <Category("_WhenTouched")> Public Property TouchedPopupIndex As Integer
    <Category("_WhenTouched")> Public Property TouchedSwitch As Boolean
    <Category("_WhenTouched")> Public Property TouchedSwitchID As Integer
    <Category("_WhenTouched")> Public Overridable Property DecreasePlayerHealth As SByte
End Class
''' <summary>
''' This object is a killing zone. This object will instantly kill the player when the player touches it.
''' </summary>
Public Class KillingZone
    Inherits HurtingZone
    <Category("_WhenTouched")> Public Shadows Const DecreasePlayerHealth As Single = Single.PositiveInfinity
End Class
