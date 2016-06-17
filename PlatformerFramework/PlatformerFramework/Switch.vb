Public Class Switch
    Inherits [Object]
    <Category("_SwitcDetails")> Public Property OnlyActivateWhenFireButton As Boolean
    <Category("_SwitchDetails")> Public Property SwitchNumber As Integer

    <Category("_WhenSwitched")> Public Property ChangeSprite As Sprite
    <Category("_WhenSwitched")> Public Property PlaySound As IO.Stream
    <Category("_WhenSwitched")> Public Property ShowPopupIndex As Integer

    <Category("_InitalStatus")> Public Overloads Property Visible As Boolean
        Get
            Return MyBase.Visible
        End Get
        Set(value As Boolean)
            MyBase.Visible = value
        End Set
    End Property
    <Category("_InitalStatus")> Public Property Active As Boolean
        Get
            Return Enabled
        End Get
        Set(value As Boolean)
            Enabled = value
        End Set
    End Property

    <Category("_SwitchHandling")> Public Property CheckSwitch As Integer
    <Category("_SwitchHandling")> Public Property ToggleVisibilityWhenSwitch As Boolean
    <Category("_SwitchHandling")> Public Property ToggleActivityWhenSwitch As Boolean
    <Category("_SwitchHandling")> Public Property RemoveObjectWhenSwitch As Boolean
    <Category("_SwitchHandling")> Public Property ActivatedByPlayerBullet As Boolean
    <Category("_SwitchHandling")> Public Property ActivatedByPlayerMelee As Boolean
    <Category("_SwitchHandling")> Public Property IgnorePlayerCollision As Boolean
End Class
