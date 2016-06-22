Public Class Mobile
    Inherits Subject
    <Category("_Sprites")> Public Overrides Property MainSprite As Sprite
        Get
            Return MyBase.MainSprite
        End Get
        Set(value As Sprite)
            MyBase.MainSprite = value
        End Set
    End Property
    <Category("_Sprites")> Public Property MoveSprite As Sprite
    <Category("_Sprites")> Public Property HitSprite As Sprite
    <Category("_Sprites")> Public Property DeadSprite As Sprite

    <Category("_Moving")> Public Property CanGoThroughBlocks As Boolean
    <Category("_Moving")> Public Property ApplyGravity As Boolean = True
    <Category("_Moving")> Public Property MoveSpeed As Byte = 8
    <Category("_Moving")> Public Property WalkingOnSlopes As SlopeWalking = SlopeWalking.Normal
    <Category("_Moving")> Public Property MoveDirection As Direction = Direction.Right
    <Category("_Moving")> Public Property MoveTowardsPlayer As Boolean

    <Category("_Health")> Public Property InitialHealth As UShort = 100
    <Category("_Health")> Public Property InfiniteHealth As Boolean
    <Category("_Health")> Public Property DetectHurtingZone As Boolean
    <Category("_Health")> Public Property DetectKillingZone As Boolean
    <Category("_Health")> Public Property DrawHealthBar As Boolean
    <Category("_Health")> Public Property HealthBarWidth As UShort = 40
    <Category("_Health")> Public Property HealthBarHeight As Byte = 6
    <Category("_Health")> Public Property HealthBarColor As Color = Color.Blue
    <Category("_Health")> Public Property HealthBarPosition As SByte = -20

    <Category("_FightHandling")> Public Property CanCollideWithPlayer As Boolean = True
    <Category("_FightHandling")> Public Property AddScoreWhenHit As UShort
    <Category("_FightHandling")> Public Property AddScoreWhenKilled As UShort
    <Category("_FightHandling")> Public Property ShowPopupWhenKilled As Integer
    <Category("_FightHandling")> Public Property DeleteWhenDead As Boolean = True
    <Category("_FightHandling")> Public Property DeleteAfterSeconds As Byte
    <Category("_FightHandling")> Public Property IgnoreBulletsWhenDead As Boolean

    <Category("_Actions")> Public Property ActivateSwitchWhenHit As Boolean
    <Category("_Actions")> Public Property HitSwitchID As Integer
    <Category("_Actions")> Public Property ActivateSwitchWhenKilled As Boolean
    <Category("_Actions")> Public Property KilledSwitchID As Integer

    <Category("_Sounds")> Public Property Hit As IO.Stream
    <Category("_Sounds")> Public Property HitByPlayer As IO.Stream
    <Category("_Sounds")> Public Property Dead As IO.Stream
End Class
''' <summary>
''' This object is a monster. A monster object is the opponent of the player in a game. Monsters can be stationary or moving, they cannot shoot.
''' </summary>
Public Class Monster
    Inherits Mobile
    <Category("_Sprites")> Public Property MeleeAttackSprite As Sprite
    <Category("_Moving")> Public Property StopWhenAttack As Boolean
    <Category("_FightHandling")> Public Property AttackDamageOnPlayer As Byte = 10
    <Category("_Sounds")> Public Property Attack As IO.Stream
End Class
''' <summary>
''' This object is an enemy. An enemy object is the opponent of the player in a game.
''' It can be stationary or moving, it can shoot at specified intervals.
''' </summary>
Public Class Enemy
    Inherits Monster
    <Category("_Shooting")> Public Property CanShoot As Boolean
    <Category("_Shooting")> Public Property PlayerDetectRange As Range = Range.Intermediate
    <Category("_Shooting")> Public Property Frequency As Frequency = Frequency.Intermediate
    <Category("_Shooting")> Public Property BulletSprite As Sprite
    <Category("_Shooting")> Public Property BulletAnimationSpeed As Byte = 10
    <Category("_Shooting")> Public Property BulletFreezeLastFrame As Boolean
    <Category("_Shooting")> Public Property BulletSpeed As Byte = 5
    <Category("_Shooting")> Public Property BulletDamage As Byte = 10
    <Category("_Shooting")> Public Property BulletHorizzontalShift As SByte
    <Category("_Shooting")> Public Property BulleterticalShift As SByte
    <Category("_Shooting")> Public Property ShootingDirection As Direction = Direction.MovingDirection
End Class