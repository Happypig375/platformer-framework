Public Enum SlopeWalking As Byte
    No
    Normal
    Extreme
End Enum
Public Enum Direction As UShort
    Up
    Right = 90
    Down = 180
    Left = 270
End Enum
Public Enum TimeUp As Byte
    PlayerDies
    RestartLevel
    GoToNextLevel
    SetASwitch
    StopMusic
    PlayMusic
    Custom
End Enum
Public Enum ButtonType As Byte
    ''' <summary>
    ''' The game starts when the player clicks this button.
    ''' </summary>
    StartButton
    ''' <summary>
    ''' The game goes to the title screen when the player clicks this button.
    ''' </summary>
    HomeButton
    ''' <summary>
    ''' The actual level restarts when the player clicks this button.
    ''' </summary>
    RestartButton
    ''' <summary>
    ''' The game continues on the next level when the player clicks this button.
    ''' </summary>
    ContinueButton
    ''' <summary>
    ''' Developer-defined code is executed when the player clicks the button.
    ''' </summary>
    CustomButton
End Enum
<Flags>
Public Enum BlockType As UShort
    ''' <summary>
    ''' This object is a block.
    ''' </summary>
    Block
    ''' <summary>
    ''' This object is a disappearing block. The player will fall from this block.
    ''' </summary>
    Disappearing
    ''' <summary>
    ''' This object is a cloud. The player can jump from a lower platform to this block.
    ''' </summary>
    Cloud
    ''' <summary>
    ''' This object is a ladder. The player can move from a lower platform to a higher platform.
    ''' </summary>
    Ladder = 4
    ''' <summary>
    ''' This object is a pushable block. The player can push this object left-right depending on the moving direction.
    ''' </summary>
    MoveLeftRight = 8
    ''' <summary>
    ''' This object is a pushable block. The player can push this object up-down depending on the moving direction.
    ''' </summary>
    MoveUpDown = 16
    ''' <summary>
    ''' This object is a pushable block. The player can push this object towards the moving direction.
    ''' </summary>
    Pushable = MoveLeftRight Or MoveUpDown
    ''' <summary>
    ''' This object is a pushable block that is snapped to grid.
    ''' </summary>
    SnapToGrid = 32
    ''' <summary>
    ''' This object is a destroyable block. The player can destroy it with bullets.
    ''' </summary>
    DestroyableByBullets = 64
    ''' <summary>
    ''' This object is a destroyable block. The player can destroy it with a melee.
    ''' </summary>
    DestroyableByMelee = 128
    ''' <summary>
    ''' This object is a destroyable block. The player can destroy it with bullets or a melee.
    ''' </summary>
    Destroyable = DestroyableByBullets Or DestroyableByMelee
    ''' <summary>
    ''' This object is a transformer block. The player can change its sprite when touches it from below.
    ''' </summary>
    TransformerBelow = 256
    ''' <summary>
    ''' This object is a transformer block. The player can change its sprite when touches it from its side.
    ''' </summary>
    TransformerSide = 512
    ''' <summary>
    ''' This object is a transformer block. The player can change its sprite when touches it from top.
    ''' </summary>
    TransformerTop = 1024
    ''' <summary>
    ''' This object is a transformer block. The player can change its sprite when touches it.
    ''' </summary>
    Transformer = TransformerBelow Or TransformerSide Or TransformerTop
End Enum
