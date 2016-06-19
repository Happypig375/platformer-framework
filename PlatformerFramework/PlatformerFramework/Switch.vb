Public Class Switch
    Inherits Subject
    <Category("_SwitcDetails")> Public Property OnlyActivateWhenFireButton As Boolean
    <Category("_SwitchDetails")> Public Property SwitchNumber As Integer

    <Category("_WhenSwitched")> Public Property ChangeSprite As Sprite
    <Category("_WhenSwitched")> Public Property PlaySound As IO.Stream
    <Category("_WhenSwitched")> Public Property ShowPopupIndex As Integer

    <Category("_SwitchHandling")> Public Property ActivatedByPlayerBullet As Boolean
    <Category("_SwitchHandling")> Public Property ActivatedByPlayerMelee As Boolean
    <Category("_SwitchHandling")> Public Property IgnorePlayerCollision As Boolean
End Class
