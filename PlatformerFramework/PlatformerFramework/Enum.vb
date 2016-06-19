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
Public Enum BlockType As Byte
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
    ''' This object is a block that can move left-right. The player can push this block.
    ''' </summary>
    MoveLeftRight = 8
    ''' <summary>
    ''' This object is a block that can move up-down. The player can push this block.
    ''' </summary>
    MoveUpDown = 16
    ''' <summary>
    ''' This object is a destroyable block. The player can destroy it with bullets or a melee.
    ''' </summary>
    Destroyable = 32
End Enum
