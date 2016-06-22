''' <summary>
''' This object is a collectable element. The player can collect this item and optionally perform actions.
''' </summary>
Public Class Collectable
    Inherits Subject
    <Category("_WhenCollected")> Public Property CollectSound As IO.Stream
    <Category("_WhenCollected")> Public Property CollectScore As Short = 25
    <Category("_WhenCollected")> Public Property CollectPopupIndex As Integer
    <Category("_WhenCollected")> Public Property CollectSwitch As Boolean
    <Category("_WhenCollected")> Public Property CollectSwitchID As Integer
    <Category("_WhenCollected")> Public Property PlayerCanShoot As Boolean
    <Category("_WhenCollected")> Public Property ExtraLife As Boolean
    <Category("_WhenCollected")> Public Property IncreaseTimer As Boolean
    <Category("_WhenCollected")> Public Property TimerID As Integer
    <Category("_WhenCollected")> Public Property IncreaseSeconds As Byte

    <Category("_WhenCollected")> Public Property RemoveFromLevel As Boolean = True
    <Category("_WhenCollected")> Public Property IncreaseHealth As SByte = 25

    <Category("_Powerups")> Public Property ActivateShield As Boolean
    <Category("_PowerUps")> Public Property SheildSeconds As Byte = 5
    <Category("_PowerUps")> Public Property InvisibleToEnemies As Boolean
    <Category("_PowerUps")> Public Property InvisibleSeconds As Byte = 5
    <Category("_PowerUps")> Public Property PlayerCanFly As Boolean
    <Category("_PowerUps")> Public Property FlySeconds As Byte = 5
End Class
''' <summary>
''' This object is a key for doors. If a door is set as locked, the player needs a key to open.
''' </summary>
Public Class Key
    Inherits Collectable
    <Category("_WhenCollected")> Public Property KeyID As Integer
End Class