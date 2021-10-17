using System;
namespace Hotstar
{
    public enum RECORDING : ulong
    { 
        /// <summary>
        /// This disable the recording feature and has to be called every frame.
        ///
        ///
        /// </summary>
        _STOP_RECORDING_THIS_FRAME = 0xEB2D525B57F42B40,
        /// <summary>
        /// This will disable the ability to make camera changes in R* Editor.
        /// 
        /// RE*
        ///
        ///
        /// </summary>
        _DISABLE_ROCKSTAR_EDITOR_CAMERA_CHANGES = 0xAF66DCEE6609B148,
        /// <summary>
        /// Starts recording a replay.
        /// If mode is 0, turns on action replay.
        /// If mode is 1, starts recording.
        /// If already recording a replay, does nothing.
        ///
        /// > int mode
        ///
        /// </summary>
        _START_RECORDING = 0xC3AC2FFF9612AC81,
        /// <summary>
        /// Stops recording and saves the recorded clip.
        ///
        ///
        /// </summary>
        _STOP_RECORDING_AND_SAVE_CLIP = 0x071A5197D6AFC8B3,
        /// <summary>
        /// Stops recording and discards the recorded clip.
        ///
        ///
        /// </summary>
        _STOP_RECORDING_AND_DISCARD_CLIP = 0x88BB3507ED41A240,
        /// <summary>
        /// Checks if you're recording, returns TRUE when you start recording (F1) or turn on action replay (F2)
        /// 
        /// mov al, cs:g_bIsRecordingGameplay // byte_141DD0CD0 in b944
        /// retn
        ///
        ///
        /// </summary>
        _IS_RECORDING = 0x1897CA71995A90B4,
        /// <summary>
        /// -This function appears to be deprecated/ unused. Tracing the call internally leads to a _nullsub -
        /// 
        /// first one seems to be a string of a mission name, second one seems to be a bool/toggle
        /// 
        /// p1 was always 0.
        /// 
        ///
        /// > const char* missionNameLabel
        /// > Any p1
        ///
        /// </summary>
        _0x208784099002BC30 = 0x208784099002BC30,
        /// <summary>
        /// Does nothing (it's a nullsub).
        ///
        /// > int p0
        /// > int p1
        /// > int p2
        ///
        /// </summary>
        _0x66972397E0757E7A = 0x66972397E0757E7A,
        _SAVE_RECORDING_CLIP = 0x644546EC5287471B,
        _0x48621C9FCA3EBD28 = 0x48621C9FCA3EBD28,
        _0x81CBAE94390F9F89 = 0x81CBAE94390F9F89,
        _0x13B350B8AD0EEE10 = 0x13B350B8AD0EEE10,
        _0x293220DA1B46CEBC = 0x293220DA1B46CEBC,
        _0xF854439EFBB3B583 = 0xF854439EFBB3B583,
        _0xDF4B952F7D381B95 = 0xDF4B952F7D381B95,
        _0x4282E08174868BE3 = 0x4282E08174868BE3,
        _0x33D47E85B476ABCD = 0x33D47E85B476ABCD,
    }
}