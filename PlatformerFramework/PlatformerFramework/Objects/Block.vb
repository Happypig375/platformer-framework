﻿''' <summary>
''' This object is a block.
''' </summary>
Public Class Block
    Inherits Subject
    <Category("_Behaviour")> Public Property BlockType As BlockType = BlockType.Block
    <Category("_Behaviour")> Public Property FadeOutSpeed As Byte = 10
    <Category("_Behaviour")> Public Property PlaySoundWhenPlayerWalksOn As IO.Stream
    <Category("_Behaviour")> Public Property MovingSpeed As Byte
    <Category("_Behaviour")> Public Property IgnoreBullets As Boolean
    <Category("_Behaviour")> Public Property IgnoreBulletsEvenIfLocked As Boolean
    <Category("_Behaviour")> Public Property NeedKeyID As Integer

    <Category("_WhenDestroyed")> Public Property DestroyedSprite As Sprite
    <Category("_WhenDestroyed")> Public Property DestroySound As IO.Stream
    <Category("_WhenDestroyed")> Public Property DestroyScore As Short
    <Category("_WhenDestroyed")> Public Property DestroyPopupIndex As Integer
    <Category("_WhenDestroyed")> Public Property DestroyActivateSwitch As Boolean
    <Category("_WhenDestroyed")> Public Property DestroyActivateSwitchID As Integer

    <Category("_WhenTransform")> Public Property TransformedSprite As Sprite
    <Category("_WhenTransform")> Public Property TransformSound As IO.Stream
    <Category("_WhenTransform")> Public Property TransformScore As Short
    <Category("_WhenTransform")> Public Property TransformPopupIndex As Integer
    <Category("_WhenTransform")> Public Property TransformSwitch As Boolean
    <Category("_WhenTransform")> Public Property TransformSwitchID As Integer

    <Category("_WhenPushed")> Public Property PushedSound As IO.Stream
    <Category("_WhenPushed")> Public Property PushedPopupIndex As Integer
    <Category("_WhenPushed")> Public Property PushedSwitch As Boolean
    <Category("_WhenPushed")> Public Property PushedSwitchID As Integer

    <Category("_WhenOpened")> Public Property OpenSprite As Sprite
    <Category("_WhenOpened")> Public Property OpenSound As IO.Stream
    <Category("_WhenOpened")> Public Property OpenScore As Short
    <Category("_WhenOpened")> Public Property OpenPopupIndex As Integer
    <Category("_WhenOpened")> Public Property OpenSwitch As Boolean
    <Category("_WhenOpened")> Public Property OpenSwitchID As Integer

    <Category("_WhenPush")> Public Property PushSound As IO.Stream
    <Category("_WhenPush")> Public Property PushPopupIndex As Integer
    <Category("_WhenPush")> Public Property PushSwitch As Boolean
    <Category("_WhenPush")> Public Property PushSwitchID As Integer
    <Category("_WhenPush")> Public Property PushPower As Byte = 10
End Class
