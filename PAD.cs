using System;
namespace Hotstar
{
    public enum PAD : ulong
    { 
        /// <summary>
        /// padIndex: 0 (PLAYER_CONTROL), 1 (unk) and 2 (unk) used in the scripts.
        ///
        /// > int padIndex
        /// > int control
        ///
        /// </summary>
        IS_CONTROL_ENABLED = 0x1CEA6BFDF248E5D9,
        /// <summary>
        /// Returns whether a control is currently pressed.
        /// padIndex: 0 (PLAYER_CONTROL), 1 (unk) and 2 (unk) used in the scripts.
        ///
        /// > int padIndex
        /// > int control
        ///
        /// </summary>
        IS_CONTROL_PRESSED = 0xF3A21BCD95725A4A,
        /// <summary>
        /// Returns whether a control is currently _not_ pressed.
        /// padIndex: 0 (PLAYER_CONTROL), 1 (unk) and 2 (unk) used in the scripts.
        ///
        /// > int padIndex
        /// > int control
        ///
        /// </summary>
        IS_CONTROL_RELEASED = 0x648EE3E7F38877DD,
        /// <summary>
        /// Returns whether a control was newly pressed since the last check.
        /// padIndex: 0 (PLAYER_CONTROL), 1 (unk) and 2 (unk) used in the scripts.
        ///
        /// > int padIndex
        /// > int control
        ///
        /// </summary>
        IS_CONTROL_JUST_PRESSED = 0x580417101DDB492F,
        /// <summary>
        /// Returns whether a control was newly released since the last check.
        /// padIndex: 0 (PLAYER_CONTROL), 1 (unk) and 2 (unk) used in the scripts.
        ///
        /// > int padIndex
        /// > int control
        ///
        /// </summary>
        IS_CONTROL_JUST_RELEASED = 0x50F940259D3841E6,
        /// <summary>
        /// padIndex: 0 (PLAYER_CONTROL), 1 (unk) and 2 (unk) used in the scripts.
        ///
        /// > int padIndex
        /// > int control
        ///
        /// </summary>
        GET_CONTROL_VALUE = 0xD95E79E8686D2C27,
        /// <summary>
        /// Returns the value of GET_CONTROL_VALUE normalized (i.e. a real number value between -1 and 1)
        /// 
        /// padIndex: 0 (PLAYER_CONTROL), 1 (unk) and 2 (unk) used in the scripts.
        ///
        /// > int padIndex
        /// > int control
        ///
        /// </summary>
        GET_CONTROL_NORMAL = 0xEC3C9B8D5327B563,
        /// <summary>
        /// Seems to return values between -1 and 1 for controls like gas and steering.
        /// 
        /// padIndex: 0 (PLAYER_CONTROL), 1 (unk) and 2 (unk) used in the scripts.
        ///
        /// > int padIndex
        /// > int control
        ///
        /// </summary>
        GET_CONTROL_UNBOUND_NORMAL = 0x5B84D09CEC5209C5,
        /// <summary>
        /// This is for simulating player input.
        /// amount is a float value from 0 - 1
        /// 
        /// padIndex: 0 (PLAYER_CONTROL), 1 (unk) and 2 (unk) used in the scripts.
        ///
        /// > int padIndex
        /// > int control
        /// > float amount
        ///
        /// </summary>
        _SET_CONTROL_NORMAL = 0xE8A25867FBA3B05E,
        /// <summary>
        /// padIndex: 0 (PLAYER_CONTROL), 1 (unk) and 2 (unk) used in the scripts.
        ///
        /// > int padIndex
        /// > int control
        ///
        /// </summary>
        IS_DISABLED_CONTROL_PRESSED = 0xE2587F8CBBD87B1D,
        /// <summary>
        /// padIndex: 0 (PLAYER_CONTROL), 1 (unk) and 2 (unk) used in the scripts.
        ///
        /// > int padIndex
        /// > int control
        ///
        /// </summary>
        IS_DISABLED_CONTROL_RELEASED = 0xFB6C4072E9A32E92,
        /// <summary>
        /// padIndex: 0 (PLAYER_CONTROL), 1 (unk) and 2 (unk) used in the scripts.
        ///
        /// > int padIndex
        /// > int control
        ///
        /// </summary>
        IS_DISABLED_CONTROL_JUST_PRESSED = 0x91AEF906BCA88877,
        /// <summary>
        /// padIndex: 0 (PLAYER_CONTROL), 1 (unk) and 2 (unk) used in the scripts.
        ///
        /// > int padIndex
        /// > int control
        ///
        /// </summary>
        IS_DISABLED_CONTROL_JUST_RELEASED = 0x305C8DCD79DA8B0F,
        /// <summary>
        /// control - c# works with (int)GTA.Control.CursorY / (int)GTA.Control.CursorX and returns the mouse movement (additive).
        /// 
        /// padIndex: 0 (PLAYER_CONTROL), 1 (unk) and 2 (unk) used in the scripts.
        ///
        /// > int padIndex
        /// > int control
        ///
        /// </summary>
        GET_DISABLED_CONTROL_NORMAL = 0x11E65974A982637C,
        /// <summary>
        /// The "disabled" variant of _0x5B84D09CEC5209C5.
        /// 
        /// padIndex: 0 (PLAYER_CONTROL), 1 (unk) and 2 (unk) used in the scripts.
        ///
        /// > int padIndex
        /// > int control
        ///
        /// </summary>
        GET_DISABLED_CONTROL_UNBOUND_NORMAL = 0x4F8A26A890FD62FB,
        /// <summary>
        /// padIndex: 0 (PLAYER_CONTROL), 1 (unk) and 2 (unk) used in the scripts.
        /// 
        /// Used to be known as _GET_LAST_INPUT_METHOD & _IS_INPUT_DISABLED
        ///
        /// > int padIndex
        ///
        /// </summary>
        _IS_USING_KEYBOARD = 0xA571D46727E2B718,
        /// <summary>
        /// padIndex: 0 (PLAYER_CONTROL), 1 (unk) and 2 (unk) used in the scripts.
        /// 
        /// Used to be known as _IS_INPUT_JUST_DISABLED
        ///
        /// > int padIndex
        ///
        /// </summary>
        _IS_USING_KEYBOARD_2 = 0x13337B38DB572509,
        /// <summary>
        /// formerly called _GET_CONTROL_ACTION_NAME incorrectly
        /// 
        /// p2 appears to always be true.
        /// p2 is unused variable in function.
        /// 
        /// EG:
        /// GET_CONTROL_INSTRUCTIONAL_BUTTON (2, 201, 1) /*INPUT_FRONTEND_ACCEPT (e.g. Enter button)*/
        /// GET_CONTROL_INSTRUCTIONAL_BUTTON (2, 202, 1) /*INPUT_FRONTEND_CANCEL (e.g. ESC button)*/
        /// GET_CONTROL_INSTRUCTIONAL_BUTTON (2, 51, 1) /*INPUT_CONTEXT (e.g. E button)*/
        /// 
        /// gtaforums.com/topic/819070-c-draw-instructional-buttons-scaleform-movie/#entry1068197378
        /// 
        /// padIndex: 0 (PLAYER_CONTROL), 1 (unk) and 2 (unk) used in the scripts.
        ///
        /// > int padIndex
        /// > int control
        /// > BOOL p2
        ///
        /// </summary>
        GET_CONTROL_INSTRUCTIONAL_BUTTON = 0x0499D7B09FC9B407,
        /// <summary>
        /// padIndex: 0 (PLAYER_CONTROL), 1 (unk) and 2 (unk) used in the scripts.
        ///
        /// > int padIndex
        /// > int controlGroup
        /// > BOOL p2
        ///
        /// </summary>
        GET_CONTROL_GROUP_INSTRUCTIONAL_BUTTON = 0x80C2FD58D720C801,
        /// <summary>
        /// padIndex: 0 (PLAYER_CONTROL), 1 (unk) and 2 (unk) used in the scripts.
        ///
        /// > int padIndex
        /// > int red
        /// > int green
        /// > int blue
        ///
        /// </summary>
        SET_CONTROL_LIGHT_EFFECT_COLOR = 0x8290252FFF36ACB5,
        /// <summary>
        /// padIndex always seems to be 0
        /// duration in milliseconds 
        /// frequency should range from about 10 (slow vibration) to 255 (very fast)
        /// appears to be a hash collision, though it does do what it says
        /// 
        /// example:
        /// SET_PAD_SHAKE(0, 100, 200);
        ///
        /// > int padIndex
        /// > int duration
        /// > int frequency
        ///
        /// </summary>
        SET_PAD_SHAKE = 0x48B3886C1358D0D5,
        /// <summary>
        /// Returns the local player's targeting mode. See PLAYER::SET_PLAYER_TARGETING_MODE.
        ///
        ///
        /// </summary>
        GET_LOCAL_PLAYER_AIM_STATE = 0xBB41AFBBBC0A0287,
        /// <summary>
        /// Same behavior as GET_LOCAL_PLAYER_AIM_STATE but only used on the PC version.
        ///
        ///
        /// </summary>
        _GET_LOCAL_PLAYER_AIM_STATE_2 = 0x59B9A7AF4C95133C,
        /// <summary>
        /// Returns profile setting 225.
        ///
        ///
        /// </summary>
        GET_IS_USING_ALTERNATE_DRIVEBY = 0x0F70731BACCFBB96,
        /// <summary>
        /// Returns profile setting 17.
        ///
        ///
        /// </summary>
        GET_ALLOW_MOVEMENT_WHILE_ZOOMED = 0xFC859E2374407556,
        /// <summary>
        /// padIndex: 0 (PLAYER_CONTROL), 1 (unk) and 2 (unk) used in the scripts.
        ///
        /// > int padIndex
        /// > int control
        ///
        /// </summary>
        SET_INPUT_EXCLUSIVE = 0xEDE476E5EE29EDB1,
        /// <summary>
        /// control values and meaning: github.com/crosire/scripthookvdotnet/blob/dev_v3/source/scripting/Controls.cs
        /// 
        /// padIndex: 0 (PLAYER_CONTROL), 1 (unk) and 2 (unk) used in the scripts.
        /// 
        /// Control values from the decompiled scripts: 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,
        /// 28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,53,5
        /// 4,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,
        /// 79,80,81,82,85,86,87,88,89,90,91,92,93,95,96,97,98,99,100,101,102,103,105,
        /// 107,108,109,110,111,112,113,114,115,116,117,118,119,123,126,129,130,131,132,
        /// 133,134,136,137,138,139,140,141,142,143,144,145,146,147,148,149,150,151,152,
        /// 153,154,155,156,157,158,159,160,161,162,163,164,165,166,167,168,169,171,172
        /// ,177,187,188,189,190,195,196,199,200,201,202,203,205,207,208,209,211,212,213, 217,219,220,221,225,226,230,234,235,236,237,238,239,240,241,242,243,244,257,
        /// 261,262,263,264,265,270,271,272,273,274,278,279,280,281,282,283,284,285,286,
        /// 287,288,289,337.
        /// 
        /// Example: PAD::DISABLE_CONTROL_ACTION(2, 19, true) disables the switching UI from appearing both when using a keyboard and Xbox 360 controller. Needs to be executed each frame. 
        ///  
        /// Control group 1 and 0 gives the same results as 2. Same results for all players. 
        ///
        /// > int padIndex
        /// > int control
        /// > BOOL disable
        ///
        /// </summary>
        DISABLE_CONTROL_ACTION = 0xFE99B66D079CF6BC,
        /// <summary>
        /// control values and meaning: github.com/crosire/scripthookvdotnet/blob/dev/source/scripting/Controls.hpp
        /// 
        /// padIndex: 0 (PLAYER_CONTROL), 1 (unk) and 2 (unk) used in the scripts.
        /// 
        /// Control values from the decompiled scripts: 
        /// 0,1,2,3,4,5,6,8,9,10,11,14,15,16,17,19,21,22,24,25,26,30,31,32,33,34,35,36,
        /// 37,44,46,47,59,60,65,68,69,70,71,72,73,74,75,76,79,80,81,82,86,95,98,99,100
        /// ,101,114,140,141,143,172,173,174,175,176,177,178,179,180,181,187,188,189,19
        /// 0,195,196,197,198,199,201,202,203,204,205,206,207,208,209,210,217,218,219,2
        /// 20,221,225,228,229,230,231,234,235,236,237,238,239,240,241,242,245,246,257,
        /// 261,262,263,264,286,287,288,289,337,338,339,340,341,342,343
        /// 
        /// INPUTGROUP_MOVE
        /// INPUTGROUP_LOOK
        /// INPUTGROUP_WHEEL
        /// INPUTGROUP_CELLPHONE_NAVIGATE
        /// INPUTGROUP_CELLPHONE_NAVIGATE_UD
        /// INPUTGROUP_CELLPHONE_NAVIGATE_LR
        /// INPUTGROUP_FRONTEND_DPAD_ALL
        /// INPUTGROUP_FRONTEND_DPAD_UD
        /// INPUTGROUP_FRONTEND_DPAD_LR
        /// INPUTGROUP_FRONTEND_LSTICK_ALL
        /// INPUTGROUP_FRONTEND_RSTICK_ALL
        /// INPUTGROUP_FRONTEND_GENERIC_UD
        /// INPUTGROUP_FRONTEND_GENERIC_LR
        /// INPUTGROUP_FRONTEND_GENERIC_ALL
        /// INPUTGROUP_FRONTEND_BUMPERS
        /// INPUTGROUP_FRONTEND_TRIGGERS
        /// INPUTGROUP_FRONTEND_STICKS
        /// INPUTGROUP_SCRIPT_DPAD_ALL
        /// INPUTGROUP_SCRIPT_DPAD_UD
        /// INPUTGROUP_SCRIPT_DPAD_LR
        /// INPUTGROUP_SCRIPT_LSTICK_ALL
        /// INPUTGROUP_SCRIPT_RSTICK_ALL
        /// INPUTGROUP_SCRIPT_BUMPERS
        /// INPUTGROUP_SCRIPT_TRIGGERS
        /// INPUTGROUP_WEAPON_WHEEL_CYCLE
        /// INPUTGROUP_FLY
        /// INPUTGROUP_SUB
        /// INPUTGROUP_VEH_MOVE_ALL
        /// INPUTGROUP_CURSOR
        /// INPUTGROUP_CURSOR_SCROLL
        /// INPUTGROUP_SNIPER_ZOOM_SECONDARY
        /// INPUTGROUP_VEH_HYDRAULICS_CONTROL
        /// 
        /// 
        /// Took those in IDA Pro.Not sure in which order they go
        ///
        /// > int padIndex
        /// > int control
        /// > BOOL enable
        ///
        /// </summary>
        ENABLE_CONTROL_ACTION = 0x351220255D64C155,
        /// <summary>
        /// padIndex: 0 (PLAYER_CONTROL), 1 (unk) and 2 (unk) used in the scripts.
        ///
        /// > int padIndex
        ///
        /// </summary>
        DISABLE_ALL_CONTROL_ACTIONS = 0x5F4B6931816E599B,
        /// <summary>
        /// padIndex: 0 (PLAYER_CONTROL), 1 (unk) and 2 (unk) used in the scripts.
        ///
        /// > int padIndex
        ///
        /// </summary>
        ENABLE_ALL_CONTROL_ACTIONS = 0xA5FFE9B05F199DE7,
        /// <summary>
        /// Used in carsteal3 script with p0 = "Carsteal4_spycar".
        /// 
        /// S*
        ///
        /// > const char* name
        ///
        /// </summary>
        _SWITCH_TO_INPUT_MAPPING_SCHEME = 0x3D42B92563939375,
        /// <summary>
        /// Same as 0x3D42B92563939375
        /// 
        /// S*
        ///
        /// > const char* name
        ///
        /// </summary>
        _SWITCH_TO_INPUT_MAPPING_SCHEME_2 = 0x4683149ED1DDE7A1,
        /// <summary>
        /// S*
        ///
        ///
        /// </summary>
        _RESET_INPUT_MAPPING_SCHEME = 0x643ED62D5EA3BEBD,
        /// <summary>
        /// padIndex: 0 (PLAYER_CONTROL), 1 (unk) and 2 (unk) used in the scripts.
        /// 
        /// Hardcoded to return false.
        ///
        /// > int padIndex
        ///
        /// </summary>
        _0x23F09EADC01449D6 = 0x23F09EADC01449D6,
        /// <summary>
        /// padIndex: 0 (PLAYER_CONTROL), 1 (unk) and 2 (unk) used in the scripts.
        ///
        /// > int padIndex
        ///
        /// </summary>
        _0x6CD79468A1E595C6 = 0x6CD79468A1E595C6,
        /// <summary>
        /// Does nothing (it's a nullsub).
        ///
        /// > Any p0
        /// > Any p1
        /// > Any p2
        /// > Any p3
        /// > Any p4
        ///
        /// </summary>
        _0x14D29BB12D47F68C = 0x14D29BB12D47F68C,
        /// <summary>
        /// Used with IS_LOOK_INVERTED() and negates its affect.
        /// 
        /// --
        /// 
        /// Not sure how the person above got that description, but here's an actual example:
        /// 
        /// if (PAD::_GET_LAST_INPUT_METHOD(2)) {
        ///     if (a_5) {
        ///         if (PAD::IS_LOOK_INVERTED()) {
        ///             a_3 *= -1;
        ///         }
        ///         if (PAD::_E1615EC03B3BB4FD()) {
        ///             a_3 *= -1;
        ///         }
        ///     }
        /// }
        ///
        ///
        /// </summary>
        _0xE1615EC03B3BB4FD = 0xE1615EC03B3BB4FD,
        /// <summary>
        /// padIndex: 0 (PLAYER_CONTROL), 1 (unk) and 2 (unk) used in the scripts.
        /// 
        /// A*
        ///
        /// > int padIndex
        ///
        /// </summary>
        _0x7F4724035FDCA1DD = 0x7F4724035FDCA1DD,
        _SET_CURSOR_LOCATION = 0xFC695459D4D0E219,
        STOP_PAD_SHAKE = 0x38C16A305E8CDC8D,
        SET_PAD_SHAKE_SUPPRESSED_ID = 0xF239400E16C23E08,
        IS_LOOK_INVERTED = 0x77B612531280010D,
        SET_PLAYERPAD_SHAKES_WHEN_CONTROLLER_DISABLED = 0x798FDEB5B1575088,
        _0x5B73C77D9EB66E24 = 0x5B73C77D9EB66E24,
        _0xD7D22F5592AED8BA = 0xD7D22F5592AED8BA,
        _0xCB0360EFEFB2580D = 0xCB0360EFEFB2580D,
        _0xA0CEFCEA390AAB9B = 0xA0CEFCEA390AAB9B,
        _0x25AAA32BDC98F2A3 = 0x25AAA32BDC98F2A3,
    }
}