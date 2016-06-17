Imports System.Diagnostics.CodeAnalysis
Imports System.Drawing.Design
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.Serialization
Imports System.Security.Permissions
<Editor("System.Drawing.Design.ImageEditor, System.Drawing.Design", GetType(UITypeEditor))>
Public Class Sprite
    Inherits MarshalByRefObject
    Implements ISerializable, ICloneable, IDisposable
    Public Property BitMap As Bitmap
    Sub New(BitMap As Bitmap)
        Me.BitMap = BitMap
    End Sub
    Shared Narrowing Operator CType(Sprite As Sprite) As Bitmap
        Return Sprite.BitMap
    End Operator
    Shared Widening Operator CType(Bitmap As Bitmap) As Sprite
        Return New Sprite(Bitmap)
    End Operator
#Region "Inherits Image"
    Public Function Clone() As Object Implements ICloneable.Clone
        Return BitMap.Clone()
    End Function
    Public Sub Dispose() Implements IDisposable.Dispose
        BitMap.Dispose()
    End Sub
#If False Then
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        BitMap.Dispose(disposing)
    End Sub
    Protected Overrides Sub Finalize() 'Implements Object.Finalize
        BitMap.Finalize()
    End Sub
#End If
    Public Shared Function FromFile(ByVal filename As String) As Image
        Return Bitmap.FromFile(filename)
    End Function
    Public Shared Function FromFile(ByVal filename As String, ByVal useEmbeddedColorManagement As Boolean) As Image
        Return Bitmap.FromFile(filename, useEmbeddedColorManagement)
    End Function
    Public Shared Function FromHbitmap(ByVal hbitmap As IntPtr) As Bitmap
        Return Bitmap.FromHbitmap(hbitmap)
    End Function
    Public Shared Function FromHbitmap(ByVal hbitmap As IntPtr, ByVal hpalette As IntPtr) As Bitmap
        Return Bitmap.FromHbitmap(hbitmap, hpalette)
    End Function
    Public Shared Function FromStream(ByVal stream As Stream) As Image
        Return Bitmap.FromStream(stream)
    End Function
    Public Shared Function FromStream(ByVal stream As Stream, ByVal useEmbeddedColorManagement As Boolean) As Image
        Return Bitmap.FromStream(stream, useEmbeddedColorManagement)
    End Function
    Public Shared Function FromStream(ByVal stream As Stream, ByVal useEmbeddedColorManagement As Boolean, ByVal validateImageData As Boolean) As Image
        Return Bitmap.FromStream(stream, useEmbeddedColorManagement, validateImageData)
    End Function
    Public Function GetBounds(ByRef pageUnit As GraphicsUnit) As RectangleF
        Return BitMap.GetBounds(pageUnit)
    End Function
    Public Function GetEncoderParameterList(ByVal encoder As Guid) As EncoderParameters
        Return BitMap.GetEncoderParameterList(encoder)
    End Function
    Public Function GetFrameCount(ByVal dimension As FrameDimension) As Integer
        Return BitMap.GetFrameCount(dimension)
    End Function
    Public Shared Function GetPixelFormatSize(ByVal pixfmt As PixelFormat) As Integer
        Return Bitmap.GetPixelFormatSize(pixfmt)
    End Function
    Public Function GetPropertyItem(ByVal propid As Integer) As PropertyItem
        Return BitMap.GetPropertyItem(propid)
    End Function
    Public Function GetThumbnailImage(ByVal thumbWidth As Integer, ByVal thumbHeight As Integer, ByVal callback As Bitmap.GetThumbnailImageAbort, ByVal callbackData As IntPtr) As Image
        Return BitMap.GetThumbnailImage(thumbWidth, thumbHeight, callback, callbackData)
    End Function
    Public Shared Function IsAlphaPixelFormat(ByVal pixfmt As PixelFormat) As Boolean
        Return Bitmap.IsAlphaPixelFormat(pixfmt)
    End Function
    Public Shared Function IsCanonicalPixelFormat(ByVal pixfmt As PixelFormat) As Boolean
        Return Bitmap.IsCanonicalPixelFormat(pixfmt)
    End Function
    Public Shared Function IsExtendedPixelFormat(ByVal pixfmt As PixelFormat) As Boolean
        Return Bitmap.IsExtendedPixelFormat(pixfmt)
    End Function
    Public Sub RemovePropertyItem(ByVal propid As Integer)
        BitMap.RemovePropertyItem(propid)
    End Sub
    Public Sub RotateFlip(ByVal rotateFlipType As RotateFlipType)
        BitMap.RotateFlip(rotateFlipType)
    End Sub
    Public Sub Save(ByVal filename As String)
        BitMap.Save(filename)
    End Sub
    Public Sub Save(ByVal stream As Stream, ByVal format As ImageFormat)
        BitMap.Save(stream, format)
    End Sub
    Public Sub Save(ByVal filename As String, ByVal format As ImageFormat)
        BitMap.Save(filename, format)
    End Sub
    Public Sub Save(ByVal stream As Stream, ByVal encoder As ImageCodecInfo, ByVal encoderParams As EncoderParameters)
        BitMap.Save(stream, encoder, encoderParams)
    End Sub
    Public Sub Save(ByVal filename As String, ByVal encoder As ImageCodecInfo, ByVal encoderParams As EncoderParameters)
        BitMap.Save(filename, encoder, encoderParams)
    End Sub
    Public Sub SaveAdd(ByVal encoderParams As EncoderParameters)
        BitMap.SaveAdd(encoderParams)
    End Sub
    Public Sub SaveAdd(ByVal image As Image, ByVal encoderParams As EncoderParameters)
        BitMap.SaveAdd(image, encoderParams)
    End Sub
    Public Function SelectActiveFrame(ByVal dimension As FrameDimension, ByVal frameIndex As Integer) As Integer
        Return BitMap.SelectActiveFrame(dimension, frameIndex)
    End Function
    Public Sub SetPropertyItem(ByVal propitem As PropertyItem)
        BitMap.SetPropertyItem(propitem)
    End Sub
    <SecurityPermission(SecurityAction.LinkDemand, Flags:=SecurityPermissionFlag.SerializationFormatter)>
    <SecurityPermissionAttribute(SecurityAction.LinkDemand, Flags:=SecurityPermissionFlag.SerializationFormatter)>
    <SuppressMessage("Microsoft.Usage", "CA2240:ImplementISerializableCorrectly")>
    Private Sub ISerializable_GetObjectData(si As SerializationInfo, context As StreamingContext) Implements ISerializable.GetObjectData
        Using stream As New MemoryStream()
            Save(stream)
            si.AddValue("Data", stream.ToArray(), GetType(Byte()))
        End Using
    End Sub
    Friend Sub Save(stream As MemoryStream)
        ' Jpeg loses data, so we don't want to use it to serialize...
        '
        Dim dest As ImageFormat = RawFormat
        If dest Is ImageFormat.Jpeg Then
            dest = ImageFormat.Png
        End If
        Dim codec As ImageCodecInfo = dest.FindEncoder()

        ' If we don't find an Encoder (for things like Icon), we
        ' just switch back to PNG...
        '
        If codec Is Nothing Then
            codec = ImageFormat.Png.FindEncoder()
        End If
        Save(stream, codec, Nothing)
    End Sub
    ' Properties
    <Browsable(False)>
    Public ReadOnly Property Flags As Integer
        Get
            Return BitMap.Flags
        End Get
    End Property
    <Browsable(False)>
    Public ReadOnly Property FrameDimensionsList As Guid()
        Get
            Return BitMap.FrameDimensionsList
        End Get
    End Property
    <DefaultValue(False), Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public ReadOnly Property Height As Integer
        Get
            Return BitMap.Height
        End Get
    End Property
    Public ReadOnly Property HorizontalResolution As Single
        Get
            Return BitMap.HorizontalResolution
        End Get
    End Property
    <Browsable(False)>
    Public Property Palette As ColorPalette
        Get
            Return BitMap.Palette
        End Get
        Set(value As ColorPalette)
            BitMap.Palette = value
        End Set
    End Property

    Public ReadOnly Property PhysicalDimension As SizeF
        Get
            Return BitMap.PhysicalDimension
        End Get
    End Property
    Public ReadOnly Property PixelFormat As PixelFormat
        Get
            Return BitMap.PixelFormat
        End Get
    End Property
    <Browsable(False)>
    Public ReadOnly Property PropertyIdList As Integer()
        Get
            Return BitMap.PropertyIdList
        End Get
    End Property
    <Browsable(False)>
    Public ReadOnly Property PropertyItems As PropertyItem()
        Get
            Return BitMap.PropertyItems
        End Get
    End Property
    Public ReadOnly Property RawFormat As ImageFormat
        Get
            Return BitMap.RawFormat
        End Get
    End Property
    Public ReadOnly Property Size As Size
        Get
            Return BitMap.Size
        End Get
    End Property
    <Localizable(False), Bindable(True), DefaultValue(CStr(Nothing)), TypeConverter(GetType(StringConverter))>
    Public Property Tag As Object
        Get
            Return BitMap.Tag
        End Get
        Set(value As Object)
            BitMap.Tag = value
        End Set
    End Property
    Public ReadOnly Property VerticalResolution As Single
        Get
            Return BitMap.VerticalResolution
        End Get
    End Property
    <DefaultValue(False), Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public ReadOnly Property Width As Integer
        Get
            Return BitMap.Width
        End Get
    End Property
#End Region
#Region "Inherits Bitmap"
#If False Then
    Shared Sub New()
        BitMap = New Bitmap()
    End Sub
#End If
    Public Sub New(ByVal Original As Image)
        Me.BitMap = New Bitmap(Original)
    End Sub
    Public Sub New(ByVal Stream As Stream)
        Me.BitMap = New Bitmap(Stream)
    End Sub
    Public Sub New(ByVal Filename As String)
        Me.BitMap = New Bitmap(Filename)
    End Sub
    Public Sub New(ByVal Original As Image, ByVal NewSize As Size)
        Me.BitMap = New Bitmap(Original, NewSize)
    End Sub
    Public Sub New(ByVal width As Integer, ByVal height As Integer)
        Me.BitMap = New Bitmap(width, height)
    End Sub
    Public Sub New(ByVal stream As Stream, ByVal useIcm As Boolean)
        Me.BitMap = New Bitmap(stream, useIcm)
    End Sub
    Public Sub New(ByVal filename As String, ByVal useIcm As Boolean)
        Me.BitMap = New Bitmap(filename, useIcm)
    End Sub
    Public Sub New(ByVal type As Type, ByVal resource As String)
        Me.BitMap = New Bitmap(type, resource)
    End Sub
    Public Sub New(ByVal original As Image, ByVal width As Integer, ByVal height As Integer)
        Me.BitMap = New Bitmap(original, width, height)
    End Sub
    Public Sub New(ByVal width As Integer, ByVal height As Integer, ByVal g As Graphics)
        Me.BitMap = New Bitmap(width, height, g)
    End Sub
    Public Sub New(ByVal width As Integer, ByVal height As Integer, ByVal format As PixelFormat)
        Me.BitMap = New Bitmap(width, height, format)
    End Sub
    Public Sub New(ByVal width As Integer, ByVal height As Integer, ByVal stride As Integer, ByVal format As PixelFormat, ByVal scan0 As IntPtr)
        Me.BitMap = New Bitmap(width, height, stride, format, scan0)
    End Sub
    Public Function Clone(ByVal rect As Rectangle, ByVal format As PixelFormat) As Bitmap
        Return BitMap.Clone(rect, format)
    End Function
    Public Function Clone(ByVal rect As RectangleF, ByVal format As PixelFormat) As Bitmap
        Return BitMap.Clone(rect, format)
    End Function
    Public Shared Function FromHicon(ByVal hicon As IntPtr) As Bitmap
        Return Bitmap.FromHicon(hicon)
    End Function
    Public Shared Function FromResource(ByVal hinstance As IntPtr, ByVal bitmapName As String) As Bitmap
        Return Bitmap.FromResource(hinstance, bitmapName)
    End Function
    <EditorBrowsable(EditorBrowsableState.Advanced), SecurityPermission(SecurityAction.LinkDemand, Flags:=SecurityPermissionFlag.UnmanagedCode)>
    Public Function GetHbitmap() As IntPtr
        Return BitMap.GetHbitmap
    End Function
    <EditorBrowsable(EditorBrowsableState.Advanced), SecurityPermission(SecurityAction.LinkDemand, Flags:=SecurityPermissionFlag.UnmanagedCode)>
    Public Function GetHbitmap(ByVal background As Color) As IntPtr
        Return BitMap.GetHbitmap(background)
    End Function
    <EditorBrowsable(EditorBrowsableState.Advanced), SecurityPermission(SecurityAction.LinkDemand, Flags:=SecurityPermissionFlag.UnmanagedCode)>
    Public Function GetHicon() As IntPtr
        Return BitMap.GetHicon
    End Function
    Public Function GetPixel(ByVal x As Integer, ByVal y As Integer) As Color
        Return BitMap.GetPixel(x, y)
    End Function
    <SecurityPermission(SecurityAction.LinkDemand, Flags:=SecurityPermissionFlag.UnmanagedCode)>
    Public Function LockBits(ByVal rect As Rectangle, ByVal flags As ImageLockMode, ByVal format As PixelFormat) As BitmapData
        Return BitMap.LockBits(rect, flags, format)
    End Function
    <SecurityPermission(SecurityAction.LinkDemand, Flags:=SecurityPermissionFlag.UnmanagedCode)>
    Public Function LockBits(ByVal rect As Rectangle, ByVal flags As ImageLockMode, ByVal format As PixelFormat, ByVal bitmapData As BitmapData) As BitmapData
        Return BitMap.LockBits(rect, flags, format, bitmapData)
    End Function
    Public Sub MakeTransparent()
        BitMap.MakeTransparent()
    End Sub
    Public Sub MakeTransparent(ByVal transparentColor As Color)
        BitMap.MakeTransparent(transparentColor)
    End Sub
    Public Sub SetPixel(ByVal x As Integer, ByVal y As Integer, ByVal color As Color)
        BitMap.SetPixel(x, y, color)
    End Sub
    Public Sub SetResolution(ByVal xDpi As Single, ByVal yDpi As Single)
        BitMap.SetResolution(xDpi, yDpi)
    End Sub
    <SecurityPermission(SecurityAction.LinkDemand, Flags:=SecurityPermissionFlag.UnmanagedCode)>
    Public Sub UnlockBits(ByVal bitmapdata As BitmapData)
        BitMap.UnlockBits(bitmapdata)
    End Sub
#End Region
End Class
Module SpriteExtensions
    <Runtime.CompilerServices.Extension>' Find any random encoder which supports this format
    Friend Function FindEncoder(ImageFormat As ImageFormat) As ImageCodecInfo
        Dim codecs As ImageCodecInfo() = ImageCodecInfo.GetImageEncoders()
        For Each codec As ImageCodecInfo In codecs
            If codec.FormatID.Equals(ImageFormat.Guid) Then
                Return codec
            End If
        Next
        Return Nothing
    End Function
End Module