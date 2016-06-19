''' <summary>
''' This object is a finish point. The actual level ends when the player touches it.
''' </summary>
Public Class FinishLevel
    Inherits DesignItem
    <Category("_WhenTouched")> Public Property ChangeSprite As Sprite
    <Category("_WhenTouched")> Public Property PlaySound As IO.Stream
    <Category("_WhenTouched")> Public Property ShowPopupIndex As Integer
    <Category("_WhenTouched")> Public Property AddScore As Short

    <Category("_AlternativeLevelFinish")> Public Property LevelScoreReachesX As Boolean
    <Category("_AlternativeLevelFinish")> Public Property ScoreToReach As Integer
    <Category("_AlternativeLevelFinish")> Public Property ObjectsOfATypeCleared
    <Category("_AlternativeLevelFinish")> Public Property ObjectToCheck As Subject
End Class
