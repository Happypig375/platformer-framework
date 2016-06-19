''' <summary>
''' This object represents a pushable button. Does something when the user clicks the button.
''' </summary>
Public Class Button
    Inherits [Interface]
    <Category("_InitialStatus")> Public Property InitializeAs
    <Category("_Event")> Public Shadows Event Click(sender As Object, e As EventArgs)
End Class
