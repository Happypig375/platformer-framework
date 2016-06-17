Public Class DesignItem
    Inherits [Object]
    <Category("_Actions")> Public Property MovingSpeed As Byte
    <Category("_Actions")> Public Property MovingDirection As Direction
    <Category("_Actions")> Public Property RotationSpeed As Byte

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
End Class
