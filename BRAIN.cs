using System;
namespace Hotstar
{
    public enum BRAIN : ulong
    { 
        /// <summary>
        /// BRAIN::ADD_SCRIPT_TO_RANDOM_PED("pb_prostitute", ${s_f_y_hooker_01}, 100, 0);
        /// 
        /// - Nacorpio
        /// 
        /// -----
        /// 
        /// Hardcoded to not work in Multiplayer.
        ///
        /// > const char* name
        /// > Hash model
        /// > float p2
        /// > float p3
        ///
        /// </summary>
        ADD_SCRIPT_TO_RANDOM_PED = 0x4EE5367468A65CCC,
        /// <summary>
        /// Registers a script for any object with a specific model hash.
        /// 
        /// BRAIN::REGISTER_OBJECT_SCRIPT_BRAIN("ob_telescope", ${prop_telescope_01}, 100, 4.0, -1, 9);
        /// 
        /// - Nacorpio
        ///
        /// > const char* scriptName
        /// > Hash modelHash
        /// > int p2
        /// > float activationRange
        /// > int p4
        /// > int p5
        ///
        /// </summary>
        REGISTER_OBJECT_SCRIPT_BRAIN = 0x0BE84C318BA6EC22,
        /// <summary>
        /// Gets whether the world point the calling script is registered to is within desired range of the player.
        ///
        ///
        /// </summary>
        IS_WORLD_POINT_WITHIN_BRAIN_ACTIVATION_RANGE = 0xC5042CC6F5E3D450,
        /// <summary>
        /// Something like flush_all_scripts 
        /// 
        /// Most of time comes after NETWORK_END_TUTORIAL_SESSION() or before TERMINATE_THIS_THREAD()
        ///
        ///
        /// </summary>
        _0x4D953DF78EBF8158 = 0x4D953DF78EBF8158,
        /// <summary>
        /// Possible values:
        /// 
        /// act_cinema
        /// am_mp_carwash_launch
        /// am_mp_carwash_control
        /// am_mp_property_ext
        /// chop
        /// fairgroundHub
        /// launcher_BasejumpHeli
        /// launcher_BasejumpPack
        /// launcher_CarWash
        /// launcher_golf
        /// launcher_Hunting_Ambient
        /// launcher_MrsPhilips
        /// launcher_OffroadRacing
        /// launcher_pilotschool
        /// launcher_Racing
        /// launcher_rampage
        /// launcher_rampage
        /// launcher_range
        /// launcher_stunts
        /// launcher_stunts
        /// launcher_tennis
        /// launcher_Tonya
        /// launcher_Triathlon
        /// launcher_Yoga
        /// ob_mp_bed_low
        /// ob_mp_bed_med
        ///
        /// > const char* action
        ///
        /// </summary>
        _0x6D6840CEE8845831 = 0x6D6840CEE8845831,
        /// <summary>
        /// Looks like a cousin of above function _6D6840CEE8845831 as it was found among them. Must be similar
        /// 
        /// Here are possible values of argument - 
        /// 
        /// "ob_tv"
        /// "launcher_Darts"
        ///
        /// > const char* action
        ///
        /// </summary>
        _0x6E91B04E08773030 = 0x6E91B04E08773030,
        IS_OBJECT_WITHIN_BRAIN_ACTIVATION_RANGE = 0xCCBA154209823057,
        REGISTER_WORLD_POINT_SCRIPT_BRAIN = 0x3CDC7136613284BD,
        ENABLE_SCRIPT_BRAIN_SET = 0x67AA4D73F0CFA86B,
        DISABLE_SCRIPT_BRAIN_SET = 0x14D8518E9760F08F,
        _0x0B40ED49D7D6FF84 = 0x0B40ED49D7D6FF84,
    }
}