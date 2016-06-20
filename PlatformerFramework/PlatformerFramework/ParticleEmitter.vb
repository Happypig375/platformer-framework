''' <summary>
''' This object is a particle emitter.
''' </summary>
Public Class ParticleEmitter
    Inherits Subject
    <Category("_EmittedParticles")> Public Property Sprite As Sprite
    <Category("_EmittedParticles")> Public Property CreationFrequency As UShort = 6

    <Category("_LifetimeRandomRange")> Public Property LifetimeMin As UShort = 60
    <Category("_LifetimeRandomRange")> Public Property LifetimeMax As UShort = 100

    <Category("_ShiftRandomRange")> Public Property ShiftHorizontalMin As Short = -2
    <Category("_ShiftRandomRange")> Public Property ShiftHorizontalMax As Short = 2
    <Category("_ShiftRandomRange")> Public Property ShiftVerticalMin As Short = -2
    <Category("_ShiftRandomRange")> Public Property ShiftVerticalMax As Short = -2

    <Category("_ScaleRandomRange")> Public Property ScaleMin As UShort = 80
    <Category("_ScaleRandomRange")> Public Property ScaleMax As UShort = 120

    <Category("_SpeedRandomRange")> Public Property SpeedHorizontalMin As UShort = 0
    <Category("_SpeedRandomRange")> Public Property SpeedHorizontalMax As UShort = 10
    <Category("_SpeedRandomRange")> Public Property SpeedVerticalMin As UShort = 0
    <Category("_SpeedRandomRange")> Public Property SpeedVerticalMax As UShort = 0

    <Category("_MovingAcceleration")> Public Property MovingAccelerationHorizontal As Short = 0
    <Category("_MovingAcceleration")> Public Property MovingAccelerationVertical As Short = 20

    <Category("_TransparencyRandomRange")> Public Property TransparencyMin As UShort = 60
    <Category("_TransparencyRandomRange")> Public Property TransparencyMax As UShort = 100

    <Category("_TransparencyFadeOut")> Public Property TransparencyFadeOutSpeed As Byte = 10

    <Category("_RotationRandomRange")> Public Property RotationMin As UShort = 0
    <Category("_RotationRandomRange")> Public Property RotationMax As UShort = 360

    <Category("_RotationChange")> Public Property RotationChangeSpeed As Byte = 0
End Class
