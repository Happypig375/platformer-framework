''' <summary>
''' This object is a downcounting timer. An action is performed when the time reaches zero.
''' </summary>
Public Class Timer
    Inherits InteractiveInterface
    <Category("_Appearance")> Public Property DropTimerBar As Boolean
    <Category("_Appearance")> Public Property TimerBarWidth As UShort = 100
    <Category("_Appearance")> Public Property TimerBarHeight As Byte = 6
    <Category("_Appearance")> Public Property TimerBarColor As Color = Color.Blue

    <Category("_Action")> Public Property Time As TimeSpan = TimeSpan.FromSeconds(30)
    <Category("_Action")> Public Property WhenTimeIsUp As TimeUp = TimeUp.PlayerDies
    <Category("_Action")> Public Property TimerID As Integer
    <Category("_Action")> Public Property Music As IO.Stream

    <Category("_Action")> Public Event TimeIsUp(sender As Object, e As Timers.ElapsedEventArgs)
End Class
