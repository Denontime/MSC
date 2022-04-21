using System;
using System.Collections.Generic;
using System.Text;

namespace BottlePickModuleForWindows.Enmu
{
    public enum PTLProtocol
    {

        _CD = 0xCD, // PTL pick model returned header
        _45 = 0x45, // PTL pick model returned data check
        _DC = 0xDC, // PTL pick model returned footer
        _BB = 0xBB, // PTL bind model returned header
        _A0 = 0xA0, // PTL bind model returned data check
        _5B = 0x5B, // PTL bind model returned footer
        _EF = 0xEF,
        _DF = 0xDF,
        _FE = 0xFE,
        _FD = 0xFD,
        _F9 = 0xF9,
        _43 = 0x43,
        _44 = 0x44,
        _46 = 0x46,
        _49 = 0x49,
        _0 = 0x0
    }

    public enum LCDPTLProtocol
    {
        _AB = 0xAB,
        _AC = 0xA,
        _45 = 0x45,
        _F9 = 0xF9,
        _BA = 0xBA,
        _CA = 0xCA,
        _ED = 0xED,
        _EC = 0xE,
        _DE = 0xDE,
        _CE = 0xCE,
        _00 = 0x0,
        _E1 = 0xE1,
        _E2 = 0xE2,
        _E3 = 0xE3,
        _E4 = 0xE4,
        _F1 = 0xF1,
        _F2 = 0xF2,
        _F3 = 0xF3,
        _F4 = 0xF4,
        _43 = 0x43,
        _44 = 0x44,
        _46 = 0x46,
        _EE = 0xEE,
        _9F = 0x9F,
        _06 = 0x6,
        _47 = 0x47
    }

    public enum PTLType
    {
        None = 0,
        PTL = 1,
        LCDPTL = 2
    }

    public enum PTLModel
    {
        UnKnow = 0,
        Pick = 1,
        BindStart = 2,
        BindStop = 3,
        Binding = 4,
        Search = 5,
        ReSendData = 6
    }
    public enum PTLPushType
    {
        NoFlashLightNoInventory = 0x7E,
        NoFlashLightPicked = 0x7F,
        FlashLightNoInventory = 0x9E,
        FlashLightPicked = 0x9F
    }

    public enum BoxTransStatus
    {
        NotPicked = 1,
        Picked = 2,
        Read = 3,
        Diverted = 4,

        // Task 312574 WCS: Record Divider failed boxes
        DivertedFailed = 5,
        NoInventory = 6,
        RouteClosed = 7,
        HandPicked = 8,
        LateConfirm = 9,
        NoRead = 99,
        Recirculate = 100
    }
}
