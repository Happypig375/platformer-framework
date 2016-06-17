Public Class Button
    Inherits [Object]
    <Category("_Appearance")> Public Property DrawShadow As Boolean
    <Category("_Appearance")> Public Property ShadowHorizontalOffset As Byte
    <Category("_Appearance")> Public Property ShadowVerticalOffset As Byte
    <Category("_Event")> Public Shadows Event Click(sender As Object, e As EventArgs)
End Class
