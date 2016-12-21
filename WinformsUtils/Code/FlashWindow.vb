Imports System.Runtime.InteropServices

Public NotInheritable Class FlashWindow
    Private Sub New()
    End Sub
    <DllImport("user32.dll")> _
    Private Shared Function FlashWindowEx(ByRef pwfi As FLASHWINFO) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function
    <StructLayout(LayoutKind.Sequential)> _
    Private Structure FLASHWINFO
        ''' <summary>
        ''' The size of the structure in bytes.
        ''' </summary>
        Public cbSize As UInteger
        ''' <summary>
        ''' A Handle to the Window to be Flashed. The window can be either opened or minimized.
        ''' </summary>
        Public hwnd As IntPtr
        ''' <summary>
        ''' The Flash Status.
        ''' </summary>
        Public dwFlags As UInteger
        ''' <summary>
        ''' The number of times to Flash the window.
        ''' </summary>
        Public uCount As UInteger
        ''' <summary>
        ''' The rate at which the Window is to be flashed, in milliseconds. If Zero, the function uses the default cursor blink rate.
        ''' </summary>
        Public dwTimeout As UInteger
    End Structure
    ''' <summary>
    ''' Stop flashing. The system restores the window to its original stae.
    ''' </summary>
    Public Const FLASHW_STOP As UInteger = 0

    ''' <summary>
    ''' Flash the window caption.
    ''' </summary>
    Public Const FLASHW_CAPTION As UInteger = 1

    ''' <summary>
    ''' Flash the taskbar button.
    ''' </summary>
    Public Const FLASHW_TRAY As UInteger = 2

    ''' <summary>
    ''' Flash both the window caption and taskbar button.
    ''' This is equivalent to setting the FLASHW_CAPTION | FLASHW_TRAY flags.
    ''' </summary>
    Public Const FLASHW_ALL As UInteger = 3
    ''' <summary>
    ''' Flash continuously, until the FLASHW_STOP flag is set.
    ''' </summary>
    Public Const FLASHW_TIMER As UInteger = 4
    ''' <summary>
    ''' Flash continuously until the window comes to the foreground.
    ''' </summary>
    Public Const FLASHW_TIMERNOFG As UInteger = 12

    ''' <summary>
    ''' Flash the spacified Window (Form) until it recieves focus.
    ''' </summary>
    ''' <param name="form">The Form (Window) to Flash.</param>
    ''' <returns></returns>
    Public Shared Function Flash(form As System.Windows.Forms.Form) As Boolean
        ' Make sure we're running under Windows 2000 or later
        If Win2000OrLater Then
            Dim fi As FLASHWINFO = Create_FLASHWINFO(form.Handle, FLASHW_ALL Or FLASHW_TIMERNOFG, UInteger.MaxValue, 0)
            Return FlashWindowEx(fi)
        End If
        Return False
    End Function
    Private Shared Function Create_FLASHWINFO(handle As IntPtr, flags As UInteger, count As UInteger, timeout As UInteger) As FLASHWINFO
        Dim fi As New FLASHWINFO()
        fi.cbSize = Convert.ToUInt32(Marshal.SizeOf(fi))
        fi.hwnd = handle
        fi.dwFlags = flags
        fi.uCount = count
        fi.dwTimeout = timeout
        Return fi
    End Function
    ''' <summary>
    ''' Flash the specified Window (form) for the specified number of times
    ''' </summary>
    ''' <param name="form">The Form (Window) to Flash.</param>
    ''' <param name="count">The number of times to Flash.</param>
    ''' <returns></returns>
    Public Shared Function Flash(form As System.Windows.Forms.Form, count As UInteger) As Boolean
        If Win2000OrLater Then
            Dim fi As FLASHWINFO = Create_FLASHWINFO(form.Handle, FLASHW_ALL, count, 0)
            Return FlashWindowEx(fi)
        End If
        Return False
    End Function
    ''' <summary>
    ''' Start Flashing the specified Window (form)
    ''' </summary>
    ''' <param name="form">The Form (Window) to Flash.</param>
    ''' <returns></returns>
    Public Shared Function Start(form As System.Windows.Forms.Form) As Boolean
        If Win2000OrLater Then
            Dim fi As FLASHWINFO = Create_FLASHWINFO(form.Handle, FLASHW_ALL, UInteger.MaxValue, 0)
            Return FlashWindowEx(fi)
        End If
        Return False
    End Function
    ''' <summary>
    ''' Stop Flashing the specified Window (form)
    ''' </summary>
    ''' <param name="form"></param>
    ''' <returns></returns>
    Public Shared Function [Stop](form As System.Windows.Forms.Form) As Boolean
        If Win2000OrLater Then
            Dim fi As FLASHWINFO = Create_FLASHWINFO(form.Handle, FLASHW_STOP, UInteger.MaxValue, 0)
            Return FlashWindowEx(fi)
        End If
        Return False
    End Function
    ''' <summary>
    ''' A boolean value indicating whether the application is running on Windows 2000 or later.
    ''' </summary>
    Private Shared ReadOnly Property Win2000OrLater() As Boolean
        Get
            Return System.Environment.OSVersion.Version.Major >= 5
        End Get
    End Property
End Class