<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Player1 = New Platformer.Player()
        Me.Ladder1 = New Platformer.Ladder()
        CType(Me.Player1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ladder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Player1
        '
        Me.Player1.Active = True
        Me.Player1.AnimationSpeed = CType(0, Byte)
        Me.Player1.ApplyGravity = False
        Me.Player1.BaseColor = System.Drawing.Color.Empty
        Me.Player1.BulletAnimationSpeed = CType(10, Byte)
        Me.Player1.BulletDamage = CType(50, Byte)
        Me.Player1.BulletDirection = Platformer.Direction.Up
        Me.Player1.BulletExplode = False
        Me.Player1.BulletHorizontalShift = 0
        Me.Player1.BulletLifeTime = CType(2, Byte)
        Me.Player1.BulletSpeed = CType(10, Byte)
        Me.Player1.BulletSprite = Nothing
        Me.Player1.BulletVerticalShift = 0
        Me.Player1.CanShootBullets = False
        Me.Player1.CanShootInAir = True
        Me.Player1.CanUseMeleeInAir = True
        Me.Player1.CheckSwitch = 0
        Me.Player1.Climb = Nothing
        Me.Player1.ClimbIdle = Nothing
        Me.Player1.CurrentSprite = Nothing
        Me.Player1.Damage = CType(50, Byte)
        Me.Player1.Dead = Nothing
        Me.Player1.DeadSprite = Nothing
        Me.Player1.Depth = 0
        Me.Player1.DieWhenOutsideOfLevel = False
        Me.Player1.ExplodeSound = Nothing
        Me.Player1.ExplodeSprite = Nothing
        Me.Player1.FixedOnScreenPosition = False
        Me.Player1.FreeLastBulletFrame = False
        Me.Player1.FreezeLastFrame = False
        Me.Player1.Hit = Nothing
        Me.Player1.HitABlock = True
        Me.Player1.HitADestroyable = True
        Me.Player1.HitADoor = True
        Me.Player1.HitAMonster = True
        Me.Player1.HitAnEnemy = True
        Me.Player1.HitAPushable = True
        Me.Player1.HitASwitch = True
        Me.Player1.HitSprite = Nothing
        Me.Player1.IgnoreAllCollisions = False
        Me.Player1.Jump = Nothing
        Me.Player1.JumpSprite = Nothing
        Me.Player1.JumpStrength = CType(8, Byte)
        Me.Player1.Location = New System.Drawing.Point(27, 34)
        Me.Player1.MainSprite = Nothing
        Me.Player1.MaxBulletsAtOnce = CType(100, Byte)
        Me.Player1.Melee = Nothing
        Me.Player1.MeleeAttackInAir = Nothing
        Me.Player1.MeleeAttackSprite = Nothing
        Me.Player1.MomentumAcceleration = CType(20, Byte)
        Me.Player1.MomentumFriction = CType(10, Byte)
        Me.Player1.MoveSpeed = CType(0, Byte)
        Me.Player1.MoveSprite = Nothing
        Me.Player1.Name = "Player1"
        Me.Player1.OverwriteActualHealth = CType(0, Byte)
        Me.Player1.RemoveObjectWhenSwitch = False
        Me.Player1.Shoot = Nothing
        Me.Player1.ShootInAir = Nothing
        Me.Player1.ShootSprite = Nothing
        Me.Player1.Size = New System.Drawing.Size(100, 50)
        Me.Player1.StopWhenMeleeAttack = False
        Me.Player1.TabIndex = 0
        Me.Player1.TabStop = False
        Me.Player1.ToggleActivityWhenSwitch = True
        Me.Player1.ToggleVisibilityWhenSwitch = True
        Me.Player1.Transparency = CType(0, Byte)
        Me.Player1.UseMomentum = False
        Me.Player1.WalkingOnSlopes = Platformer.SlopeWalking.No
        '
        'Ladder1
        '
        Me.Ladder1.Active = True
        Me.Ladder1.AnimationSpeed = CType(10, Byte)
        Me.Ladder1.BaseColor = System.Drawing.Color.Empty
        Me.Ladder1.BlockType = CType(((Platformer.BlockType.Disappearing Or Platformer.BlockType.Cloud) _
            Or Platformer.BlockType.lenny), Platformer.BlockType)
        Me.Ladder1.CheckSwitch = 0
        Me.Ladder1.CurrentSprite = Nothing
        Me.Ladder1.Depth = 0
        Me.Ladder1.FixedOnScreenPosition = False
        Me.Ladder1.Location = New System.Drawing.Point(163, 185)
        Me.Ladder1.MainSprite = Nothing
        Me.Ladder1.Name = "Ladder1"
        Me.Ladder1.RemoveObjectWhenSwitch = False
        Me.Ladder1.Size = New System.Drawing.Size(100, 50)
        Me.Ladder1.TabIndex = 1
        Me.Ladder1.TabStop = False
        Me.Ladder1.ToggleActivityWhenSwitch = True
        Me.Ladder1.ToggleVisibilityWhenSwitch = True
        Me.Ladder1.Transparency = CType(100, Byte)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Ladder1)
        Me.Controls.Add(Me.Player1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Player1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ladder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Player1 As Player
    Friend WithEvents Ladder1 As Ladder
End Class
