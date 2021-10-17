using System;
namespace Hotstar
{
    public enum REPLAY : ulong
    { 
        /// <summary>
        /// Returns a bool if interior rendering is disabled, if yes, all "normal" rendered interiors are invisible
        ///
        ///
        /// </summary>
        _IS_INTERIOR_RENDERING_DISABLED = 0x95AB8B5C992C7B58,
        /// <summary>
        /// Sets (almost, not sure) all Rockstar Editor values (bIsRecording etc) to 0.
        ///
        ///
        /// </summary>
        _RESET_EDITOR_VALUES = 0x3353D13F09307691,
        /// <summary>
        /// Please note that you will need to call DO_SCREEN_FADE_IN after exiting the Rockstar Editor when you call this.
        ///
        /// > int p0
        ///
        /// </summary>
        _ACTIVATE_ROCKSTAR_EDITOR = 0x49DA8145672B2725,
        /// <summary>
        /// Does nothing (it's a nullsub).
        ///
        /// > const char* p0
        /// > BOOL p1
        ///
        /// </summary>
        _0x7E2BD3EF6C205F09 = 0x7E2BD3EF6C205F09,
        /// <summary>
        /// Disables some other rendering (internal)
        ///
        ///
        /// </summary>
        _0x5AD3932DAEB1E5D3 = 0x5AD3932DAEB1E5D3,
        _0xE058175F8EAFE79A = 0xE058175F8EAFE79A,
    }
}