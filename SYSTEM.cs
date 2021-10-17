using System;
namespace Hotstar
{
    public enum SYSTEM : ulong
    { 
        /// <summary>
        /// Pauses execution of the current script, please note this behavior is only seen when called from one of the game script files(ysc). In order to wait an asi script use "static void WAIT(DWORD time);" found in main.h
        ///
        /// > int ms
        ///
        /// </summary>
        WAIT = 0x4EDE34FBADD967A6,
        /// <summary>
        /// Examples:
        ///  g_384A = SYSTEM::START_NEW_SCRIPT("cellphone_flashhand", 1424);
        ///  l_10D = SYSTEM::START_NEW_SCRIPT("taxiService", 1828);
        ///  SYSTEM::START_NEW_SCRIPT("AM_MP_YACHT", 5000);
        ///  SYSTEM::START_NEW_SCRIPT("emergencycall", 512);
        ///  SYSTEM::START_NEW_SCRIPT("emergencycall", 512); 
        ///  SYSTEM::START_NEW_SCRIPT("FM_maintain_cloud_header_data", 1424);
        ///  SYSTEM::START_NEW_SCRIPT("FM_Mission_Controller", 31000);
        ///  SYSTEM::START_NEW_SCRIPT("tennis_family", 3650);
        ///  SYSTEM::START_NEW_SCRIPT("Celebrations", 3650);
        /// 
        /// Decompiled examples of usage when starting a script:
        ///  
        ///     SCRIPT::REQUEST_SCRIPT(a_0);
        ///     if (SCRIPT::HAS_SCRIPT_LOADED(a_0)) {
        ///         SYSTEM::START_NEW_SCRIPT(a_0, v_3);
        ///         SCRIPT::SET_SCRIPT_AS_NO_LONGER_NEEDED(a_0);
        ///         return 1;
        ///     }
        ///  
        /// or:
        /// 
        ///     v_2 = "MrsPhilips2";
        ///     SCRIPT::REQUEST_SCRIPT(v_2);
        ///     while (!SCRIPT::HAS_SCRIPT_LOADED(v_2)) {
        ///     SCRIPT::REQUEST_SCRIPT(v_2);
        ///     SYSTEM::WAIT(0);
        ///     }
        ///     sub_8792(36);
        ///     SYSTEM::START_NEW_SCRIPT(v_2, 17000);
        ///     SCRIPT::SET_SCRIPT_AS_NO_LONGER_NEEDED(v_2);
        /// 
        /// All native script names: pastebin.com/K9adDsu4 and pastebin.com/yLNWicUi
        ///
        /// > const char* scriptName
        /// > int stackSize
        ///
        /// </summary>
        START_NEW_SCRIPT = 0xE81651AD79516E48,
        /// <summary>
        /// return : script thread id, 0 if failed
        /// Pass pointer to struct of args in p1, size of struct goes into p2
        ///
        /// > const char* scriptName
        /// > Any* args
        /// > int argCount
        /// > int stackSize
        ///
        /// </summary>
        START_NEW_SCRIPT_WITH_ARGS = 0xB8BA7F44DF1575E1,
        /// <summary>
        /// Counts up. Every 1000 is 1 real-time second. Use SETTIMERA(int value) to set the timer (e.g.: SETTIMERA(0)).
        ///
        ///
        /// </summary>
        TIMERA = 0x83666F9FB8FEBD4B,
        /// <summary>
        /// Gets the current frame time.
        ///
        ///
        /// </summary>
        TIMESTEP = 0x0000000050597EE2,
        /// <summary>
        /// Calculates the magnitude of a vector.
        ///
        /// > float x
        /// > float y
        /// > float z
        ///
        /// </summary>
        VMAG = 0x652D2EEEF1D3E62C,
        /// <summary>
        /// Calculates the magnitude of a vector but does not perform Sqrt operations. (Its way faster)
        ///
        /// > float x
        /// > float y
        /// > float z
        ///
        /// </summary>
        VMAG2 = 0xA8CEACB4F35AE058,
        /// <summary>
        /// Calculates distance between vectors.
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        ///
        /// </summary>
        VDIST = 0x2A488C176D52CCA5,
        /// <summary>
        /// Calculates distance between vectors but does not perform Sqrt operations. (Its way faster)
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        ///
        /// </summary>
        VDIST2 = 0xB7A628320EFF8E47,
        /// <summary>
        /// I'm guessing this rounds a float value up to the next whole number, and FLOOR rounds it down
        ///
        /// > float value
        ///
        /// </summary>
        CEIL = 0x11E019C8F43ACC8A,
        /// <summary>
        /// 0 = high
        /// 1 = normal
        /// 2 = low
        ///
        /// > int priority
        ///
        /// </summary>
        SET_THREAD_PRIORITY = 0x42B65DEEF2EDF2A1,
        START_NEW_SCRIPT_WITH_NAME_HASH = 0xEB1C67C3A5333A92,
        START_NEW_SCRIPT_WITH_NAME_HASH_AND_ARGS = 0xC4BB298BD441BE78,
        TIMERB = 0xC9D9444186B5A374,
        SETTIMERA = 0xC1B1E9A034A63A62,
        SETTIMERB = 0x5AE11BC36633DE4E,
        SIN = 0x0BADBFA3B172435F,
        COS = 0xD0FFB162F40A139C,
        SQRT = 0x71D93B57D07F9804,
        POW = 0xE3621CC40F31FE2E,
        _LOG10 = 0xE816E655DE37FE20,
        SHIFT_LEFT = 0xEDD95A39E5544DE8,
        SHIFT_RIGHT = 0x97EF1E5BCE9DC075,
        FLOOR = 0xF34EE736CF047844,
        ROUND = 0xF2DB717A73826179,
        TO_FLOAT = 0xBBDA792448DB5A89,
    }
}