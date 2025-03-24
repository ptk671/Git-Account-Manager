Imports System
Imports System.Runtime.InteropServices
Imports System.Text

Namespace LedVBNet


    Public Enum keyboardNames
        ESC = &H1
        F1 = &H3B
        F2 = &H3C
        F3 = &H3D
        F4 = &H3E
        F5 = &H3F
        F6 = &H40
        F7 = &H41
        F8 = &H42
        F9 = &H43
        F10 = &H44
        F11 = &H57
        F12 = &H58
        PRINT_SCREEN = &H137
        SCROLL_LOCK = &H46
        PAUSE_BREAK = &H145
        TILDE = &H29
        ONE = &H2
        TWO = &H3
        THREE = &H4
        FOUR = &H5
        FIVE = &H6
        SIX = &H7
        SEVEN = &H8
        EIGHT = &H9
        NINE = &HA
        ZERO = &HB
        MINUS = &HC
        EQUALS = &HD
        BACKSPACE = &HE
        INSERT = &H152
        HOME = &H147
        PAGE_UP = &H149
        NUM_LOCK = &H45
        NUM_SLASH = &H135
        NUM_ASTERISK = &H37
        NUM_MINUS = &H4A
        TAB = &HF
        Q = &H10
        W = &H11
        E = &H12
        R = &H13
        T = &H14
        Y = &H15
        U = &H16
        I = &H17
        O = &H18
        P = &H19
        OPEN_BRACKET = &H1A
        CLOSE_BRACKET = &H1B
        BACKSLASH = &H2B
        KEYBOARD_DELETE = &H153
        [END] = &H14F
        PAGE_DOWN = &H151
        NUM_SEVEN = &H47
        NUM_EIGHT = &H48
        NUM_NINE = &H49
        NUM_PLUS = &H4E
        CAPS_LOCK = &H3A
        A = &H1E
        S = &H1F
        D = &H20
        F = &H21
        G = &H22
        H = &H23
        J = &H24
        K = &H25
        L = &H26
        SEMICOLON = &H27
        APOSTROPHE = &H28
        ENTER = &H1C
        NUM_FOUR = &H4B
        NUM_FIVE = &H4C
        NUM_SIX = &H4D
        LEFT_SHIFT = &H2A
        Z = &H2C
        X = &H2D
        C = &H2E
        V = &H2F
        B = &H30
        N = &H31
        M = &H32
        COMMA = &H33
        PERIOD = &H34
        FORWARD_SLASH = &H35
        RIGHT_SHIFT = &H36
        ARROW_UP = &H148
        NUM_ONE = &H4F
        NUM_TWO = &H50
        NUM_THREE = &H51
        NUM_ENTER = &H11C
        LEFT_CONTROL = &H1D
        LEFT_WINDOWS = &H15B
        LEFT_ALT = &H38
        SPACE = &H39
        RIGHT_ALT = &H138
        RIGHT_WINDOWS = &H15C
        APPLICATION_SELECT = &H15D
        RIGHT_CONTROL = &H11D
        ARROW_LEFT = &H14B
        ARROW_DOWN = &H150
        ARROW_RIGHT = &H14D
        NUM_ZERO = &H52
        NUM_PERIOD = &H53
        G_1 = &HFFF1
        G_2 = &HFFF2
        G_3 = &HFFF3
        G_4 = &HFFF4
        G_5 = &HFFF5
        G_6 = &HFFF6
        G_7 = &HFFF7
        G_8 = &HFFF8
        G_9 = &HFFF9
        G_LOGO = &HFFFF1
        G_BADGE = &HFFFF2
    End Enum

    ' デバイスタイプを定義する列挙型
    Public Enum DeviceType
        Keyboard = &H0
        Mouse = &H3
        Mousemat = &H4
        Headset = &H8
        Speaker = &HE
    End Enum

    Public Class LogitechGSDK
        ' LED SDK定数
        Private Const LOGI_DEVICETYPE_MONOCHROM_ORD As Integer = 0
        Private Const LOGI_DEVICETYPE_RGB_ORD As Integer = 1
        Private Const LOGI_DEVICETYPE_PERKEY_RGB_ORD As Integer = 2

        Public Const LOGI_DEVICETYPE_MONOCHROME As Integer = (1 << LOGI_DEVICETYPE_MONOCHROM_ORD)
        Public Const LOGI_DEVICETYPE_RGB As Integer = (1 << LOGI_DEVICETYPE_RGB_ORD)
        Public Const LOGI_DEVICETYPE_PERKEY_RGB As Integer = (1 << LOGI_DEVICETYPE_PERKEY_RGB_ORD)
        Public Const LOGI_DEVICETYPE_ALL As Integer = (LOGI_DEVICETYPE_MONOCHROME Or LOGI_DEVICETYPE_RGB Or LOGI_DEVICETYPE_PERKEY_RGB)

        Public Const LOGI_LED_BITMAP_WIDTH As Integer = 21
        Public Const LOGI_LED_BITMAP_HEIGHT As Integer = 6
        Public Const LOGI_LED_BITMAP_BYTES_PER_KEY As Integer = 4

        Public Const LOGI_LED_BITMAP_SIZE As Integer = LOGI_LED_BITMAP_WIDTH * LOGI_LED_BITMAP_HEIGHT * LOGI_LED_BITMAP_BYTES_PER_KEY
        Public Const LOGI_LED_DURATION_INFINITE As Integer = 0

        ' LogitechLedEnginesWrapper.dllからの関数インポート
        <DllImport("LogitechLedEnginesWrapper", CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LogiLedInit() As Boolean
        End Function

        <DllImport("LogitechLedEnginesWrapper", CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LogiLedInitWithName(name As String) As Boolean
        End Function

        ' 設定オプション関数
        <DllImport("LogitechLedEnginesWrapper", CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LogiLedGetConfigOptionNumber(<MarshalAs(UnmanagedType.LPWStr)> configPath As String, ByRef defaultNumber As Double) As Boolean
        End Function

        <DllImport("LogitechLedEnginesWrapper", CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LogiLedGetConfigOptionBool(<MarshalAs(UnmanagedType.LPWStr)> configPath As String, ByRef defaultRed As Boolean) As Boolean
        End Function

        <DllImport("LogitechLedEnginesWrapper", CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LogiLedGetConfigOptionColor(<MarshalAs(UnmanagedType.LPWStr)> configPath As String, ByRef defaultRed As Integer, ByRef defaultGreen As Integer, ByRef defaultBlue As Integer) As Boolean
        End Function

        <DllImport("LogitechLedEnginesWrapper", CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LogiLedGetConfigOptionKeyInput(<MarshalAs(UnmanagedType.LPWStr)> configPath As String, buffer As StringBuilder, bufsize As Integer) As Boolean
        End Function

        <DllImport("LogitechLedEnginesWrapper", CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LogiLedSetTargetDevice(targetDevice As Integer) As Boolean
        End Function

        <DllImport("LogitechLedEnginesWrapper", CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LogiLedGetSdkVersion(ByRef majorNum As Integer, ByRef minorNum As Integer, ByRef buildNum As Integer) As Boolean
        End Function

        <DllImport("LogitechLedEnginesWrapper", CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LogiLedSaveCurrentLighting() As Boolean
        End Function

        <DllImport("LogitechLedEnginesWrapper", CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LogiLedSetLighting(redPercentage As Integer, greenPercentage As Integer, bluePercentage As Integer) As Boolean
        End Function

        <DllImport("LogitechLedEnginesWrapper", CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LogiLedRestoreLighting() As Boolean
        End Function

        <DllImport("LogitechLedEnginesWrapper", CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LogiLedFlashLighting(redPercentage As Integer, greenPercentage As Integer, bluePercentage As Integer, milliSecondsDuration As Integer, milliSecondsInterval As Integer) As Boolean
        End Function

        <DllImport("LogitechLedEnginesWrapper", CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LogiLedPulseLighting(redPercentage As Integer, greenPercentage As Integer, bluePercentage As Integer, milliSecondsDuration As Integer, milliSecondsInterval As Integer) As Boolean
        End Function

        <DllImport("LogitechLedEnginesWrapper", CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LogiLedStopEffects() As Boolean
        End Function

        <DllImport("LogitechLedEnginesWrapper", CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LogiLedExcludeKeysFromBitmap(keyList As keyboardNames(), listCount As Integer) As Boolean
        End Function

        <DllImport("LogitechLedEnginesWrapper", CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LogiLedSetLightingFromBitmap(bitmap As Byte()) As Boolean
        End Function

        <DllImport("LogitechLedEnginesWrapper", CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LogiLedSetLightingForKeyWithScanCode(keyCode As Integer, redPercentage As Integer, greenPercentage As Integer, bluePercentage As Integer) As Boolean
        End Function

        <DllImport("LogitechLedEnginesWrapper", CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LogiLedSetLightingForKeyWithHidCode(keyCode As Integer, redPercentage As Integer, greenPercentage As Integer, bluePercentage As Integer) As Boolean
        End Function

        <DllImport("LogitechLedEnginesWrapper", CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LogiLedSetLightingForKeyWithQuartzCode(keyCode As Integer, redPercentage As Integer, greenPercentage As Integer, bluePercentage As Integer) As Boolean
        End Function

        <DllImport("LogitechLedEnginesWrapper", CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LogiLedSetLightingForKeyWithKeyName(keyCode As keyboardNames, redPercentage As Integer, greenPercentage As Integer, bluePercentage As Integer) As Boolean
        End Function

        <DllImport("LogitechLedEnginesWrapper", CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LogiLedSaveLightingForKey(keyName As keyboardNames) As Boolean
        End Function

        <DllImport("LogitechLedEnginesWrapper", CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LogiLedRestoreLightingForKey(keyName As keyboardNames) As Boolean
        End Function

        <DllImport("LogitechLedEnginesWrapper", CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LogiLedFlashSingleKey(keyName As keyboardNames, redPercentage As Integer, greenPercentage As Integer, bluePercentage As Integer, msDuration As Integer, msInterval As Integer) As Boolean
        End Function

        <DllImport("LogitechLedEnginesWrapper", CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LogiLedPulseSingleKey(keyName As keyboardNames, startRedPercentage As Integer, startGreenPercentage As Integer, startBluePercentage As Integer, finishRedPercentage As Integer, finishGreenPercentage As Integer, finishBluePercentage As Integer, msDuration As Integer, isInfinite As Boolean) As Boolean
        End Function

        <DllImport("LogitechLedEnginesWrapper", CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LogiLedStopEffectsOnKey(keyName As keyboardNames) As Boolean
        End Function

        <DllImport("LogitechLedEnginesWrapper", CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Function LogiLedSetLightingForTargetZone(deviceType As DeviceType, zone As Integer, redPercentage As Integer, greenPercentage As Integer, bluePercentage As Integer) As Boolean
        End Function

        <DllImport("LogitechLedEnginesWrapper", CallingConvention:=CallingConvention.Cdecl)>
        Public Shared Sub LogiLedShutdown()
        End Sub
    End Class

End Namespace