using System;
namespace Hotstar
{
    public enum DLC : ulong
    { 
        /// <summary>
        /// Example:
        /// DLC::IS_DLC_PRESENT($\mpbusiness2\);
        /// ($ = gethashkey)
        /// 
        /// bruteforce these:
        /// 0xB119F6D
        /// 0x96F02EE6
        ///
        /// > Hash dlcHash
        ///
        /// </summary>
        IS_DLC_PRESENT = 0x812595A0644CE1DE,
        /// <summary>
        /// Sets the value of the specified variable to 0.
        /// Always returns true.
        ///
        /// > BOOL* p0
        /// > Any unused
        ///
        /// </summary>
        HAS_CLOUD_REQUESTS_FINISHED = 0x46E2B844905BC5F0,
        /// <summary>
        /// Unloads GROUP_MAP (GTAO/MP) DLC data and loads GROUP_MAP_SP DLC. Neither are loaded by default, 0888C3502DBBEEF5 is a cognate to this function and loads MP DLC (and unloads SP DLC by extension).
        /// 
        /// The original (and wrong) definition is below:
        /// 
        /// This unload the GTA:O DLC map parts (like high end garages/apartments).
        /// Works in singleplayer.
        ///
        ///
        /// </summary>
        ON_ENTER_SP = 0xD7C10C4A637992C9,
        /// <summary>
        /// This loads the GTA:O dlc map parts (high end garages, apartments).
        /// Works in singleplayer.
        /// In order to use GTA:O heist IPL's you have to call this native with the following params: SET_INSTANCE_PRIORITY_MODE(1);
        ///
        ///
        /// </summary>
        ON_ENTER_MP = 0x0888C3502DBBEEF5,
        /// <summary>
        /// Only used once in scripts, in maintransition.
        /// 
        /// maintransition.c4, line ~82432:
        /// if (PED::_7350823473013C02(PLAYER::PLAYER_PED_ID()) && (DECORATOR::_241FCA5B1AA14F75() == 0)) {
        ///     g_2542A5 = a_1; // 'g_2542A5' used in 'building_controller.ysc' for IPL stuff?
        ///     return 1;
        /// }
        /// 
        /// Likely used solely for the players ped. The function it's in seems to only be used for initialization/quitting. Called among natives to discard scaleforms, disable frontend, fading in/out, etc. Neighboring strings to some calls include "HUD_JOINING", "HUD_QUITTING".
        /// 
        /// Most likely ARE_*
        ///
        ///
        /// </summary>
        _0x241FCA5B1AA14F75 = 0x241FCA5B1AA14F75,
        /// <summary>
        /// MulleDK19: This function is hard-coded to always return 1.
        ///
        ///
        /// </summary>
        _0xF2E07819EF1A5289 = 0xF2E07819EF1A5289,
        /// <summary>
        /// MulleDK19: This function is hard-coded to always return 0.
        ///
        ///
        /// </summary>
        _0x9489659372A81585 = 0x9489659372A81585,
        /// <summary>
        /// MulleDK19: This function is hard-coded to always return 1.
        ///
        ///
        /// </summary>
        _0xA213B11DFF526300 = 0xA213B11DFF526300,
        /// <summary>
        /// GET_IS_LOADING_*
        ///
        ///
        /// </summary>
        _0xC4637A6D03C24CC3 = 0xC4637A6D03C24CC3,
        _GET_EXTRA_CONTENT_PACK_HAS_BEEN_INSTALLED = 0x8D30F648014A92B5,
        GET_IS_LOADING_SCREEN_ACTIVE = 0x10D0A8F259E93EC9,
    }
}