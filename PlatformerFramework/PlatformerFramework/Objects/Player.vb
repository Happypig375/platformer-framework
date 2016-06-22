''' <summary>
''' This object is a player.
''' </summary>
Public Class Player
    Inherits Monster
    <Category("_Sprites")> Public Property JumpSprite As Sprite
    <Category("_Sprites")> Public Property FreezeLastFrame As Boolean
    <Category("_Sprites")> Public Property MeleeAttackInAir As Sprite
    <Category("_Sprites")> Public Property ShootSprite As Sprite
    <Category("_Sprites")> Public Property ShootInAir As Sprite
    <Category("_Sprites")> Public Property ClimbIdle As Sprite
    <Category("_Sprites")> Public Property Climb As Sprite

    <Category("_Health")> Public Property OverwriteActualHealth As Byte = 0
    <Category("_Health")> Public Property DieWhenOutsideOfLevel As Boolean = True

    <Category("_Moving")> Public Property JumpStrength As Byte = 8
    <Category("_Moving")> Public Property UseMomentum As Boolean
    <Category("_Moving")> Public Property MomentumAcceleration As Byte = 20
    <Category("_Moving")> Public Property MomentumFriction As Byte = 10
    <Category("_Moving")> Public Property IgnoreAllCollisions As Boolean
    <Category("_Moving")> Public Property StopWhenMeleeAttack As Boolean

    <Category("_Shooting")> Public Property CanShootBullets As Boolean
    <Category("_Shooting")> Public Property MaxBulletsAtOnce As Byte = 100
    <Category("_Shooting")> Public Property BulletSprite As Sprite
    <Category("_Shooting")> Public Property BulletAnimationSpeed As Byte = 10
    <Category("_Shooting")> Public Property FreeLastBulletFrame As Boolean
    <Category("_Shooting")> Public Property BulletDamage As Byte = 50
    <Category("_Shooting")> Public Property BulletSpeed As Byte = 10
    <Category("_Shooting")> Public Property BulletHorizontalShift As Integer
    <Category("_Shooting")> Public Property BulletVerticalShift As Integer
    <Category("_Shooting")> Public Property BulletDirection As Direction
    <Category("_Shooting")> Public Property BulletLifeTime As Byte = 2
    <Category("_Shooting")> Public Property BulletExplode As Boolean
    <Category("_Shooting")> Public Property ExplodeSprite As Sprite
    <Category("_Shooting")> Public Property ExplodeSound As IO.Stream
    <Category("_Shooting")> Public Property CanShootInAir As Boolean = True

    <Category("_ShowBulletExplosionWhen...")> Public Property HitAnEnemy As Boolean = True
    <Category("_ShowBulletExplosionWhen...")> Public Property HitAMonster As Boolean = True
    <Category("_ShowBulletExplosionWhen...")> Public Property HitADestroyable As Boolean = True
    <Category("_ShowBulletExplosionWhen...")> Public Property HitABlock As Boolean = True
    <Category("_ShowBulletExplosionWhen...")> Public Property HitAPushable As Boolean = True
    <Category("_ShowBulletExplosionWhen...")> Public Property HitASwitch As Boolean = True
    <Category("_ShowBulletExplosionWhen...")> Public Property HitADoor As Boolean = True

    <Category("_MeleeAttack")> Public Property Damage As Byte = 50
    <Category("_MeleeAttack")> Public Property CanUseMeleeInAir As Boolean = True

    <Category("_Sounds")> Public Property Jump As IO.Stream
    <Category("_Sounds")> Public Property Shoot As IO.Stream
    <Category("_Sounds")> Public Property Melee As IO.Stream
End Class
