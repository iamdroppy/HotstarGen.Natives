using System;
namespace Hotstar
{
    public enum MOBILE : ulong
    { 
        /// <summary>
        /// Creates a mobile phone of the specified type.
        /// 
        /// Possible phone types:
        /// 
        /// 0 - Default phone / Michael's phone
        /// 1 - Trevor's phone
        /// 2 - Franklin's phone
        /// 4 - Prologue phone
        /// 
        /// These values represent bit flags, so a value of '3' would toggle Trevor and Franklin's phones together, causing unexpected behavior and most likely crash the game.
        ///
        /// > int phoneType
        ///
        /// </summary>
        CREATE_MOBILE_PHONE = 0xA4E8E696C532FBC7,
        /// <summary>
        /// Destroys the currently active mobile phone.
        ///
        ///
        /// </summary>
        DESTROY_MOBILE_PHONE = 0x3BC861DF703E5097,
        /// <summary>
        /// The minimum/default is 500.0f. If you plan to make it bigger set it's position as well. Also this seems to need to be called in a loop as when you close the phone the scale is reset. If not in a loop you'd need to call it everytime before you re-open the phone.
        ///
        /// > float scale
        ///
        /// </summary>
        SET_MOBILE_PHONE_SCALE = 0xCBDD322A73D6D932,
        /// <summary>
        /// Last parameter is unknown and always zero.
        ///
        /// > float rotX
        /// > float rotY
        /// > float rotZ
        /// > Any p3
        ///
        /// </summary>
        SET_MOBILE_PHONE_ROTATION = 0xBB779C0CA917E865,
        /// <summary>
        /// If bool Toggle = true so the mobile is hide to screen.
        /// If bool Toggle = false so the mobile is show to screen.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SCRIPT_IS_MOVING_MOBILE_PHONE_OFFSCREEN = 0xF511F759238A5122,
        /// <summary>
        /// This one is weird and seems to return a TRUE state regardless of whether the phone is visible on screen or tucked away.
        /// 
        /// 
        /// I can confirm the above. This function is hard-coded to always return 1.
        ///
        ///
        /// </summary>
        CAN_PHONE_BE_SEEN_ON_SCREEN = 0xC4E2813898C97A4B,
        /// <summary>
        /// For move the finger of player, the value of int goes 1 at 5.
        ///
        /// > int direction
        ///
        /// </summary>
        _CELL_CAM_MOVE_FINGER = 0x95C9E72F3D7DEC9B,
        /// <summary>
        /// if the bool "Toggle" is "true" so the phone is lean.
        /// if the bool "Toggle" is "false" so the phone is not lean.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _CELL_CAM_SET_LEAN = 0x44E44169EF70138E,
        /// <summary>
        /// Disables the phone up-button, oddly enough. 
        /// i.e.: When the phone is out, and this method is called with false as it's parameter, the phone will not be able to scroll up. However, when you use the down arrow key, it's functionality still, works on the phone. 
        /// 
        /// When the phone is not out, and this method is called with false as it's parameter, you will not be able to bring up the phone. Although the up arrow key still works for whatever functionality it's used for, just not for the phone.
        /// 
        /// This can be used for creating menu's when trying to disable the phone from being used. 
        /// 
        /// You do not have to call the function again with false as a parameter, as soon as the function stops being called, the phone will again be usable.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _CELL_CAM_DISABLE_THIS_FRAME = 0x015C49A93E3E086E,
        /// <summary>
        /// Needs more research. If the "phone_cam12" filter is applied, this function is called with "TRUE"; otherwise, "FALSE".
        /// 
        /// Example (XBOX 360):
        /// 
        /// // check current filter selection
        /// if (MISC::ARE_STRINGS_EQUAL(getElem(g_2471024, &l_17, 4), "phone_cam12") != 0)
        /// {
        ///     MOBILE::_0xC273BB4D(0); // FALSE
        /// }
        /// else
        /// {
        ///     MOBILE::_0xC273BB4D(1); // TRUE
        /// }
        ///
        /// > int* toggle
        ///
        /// </summary>
        _0xA2CCBE62CD4C91A4 = 0xA2CCBE62CD4C91A4,
        GET_MOBILE_PHONE_ROTATION = 0x1CEFB61F193070AE,
        SET_MOBILE_PHONE_POSITION = 0x693A5C6D6734085B,
        GET_MOBILE_PHONE_POSITION = 0x584FDFDA48805B86,
        _SET_MOBILE_PHONE_UNK = 0x375A706A5C2FD084,
        CELL_CAM_ACTIVATE = 0xFDE8F069C542D126,
        CELL_CAM_IS_CHAR_VISIBLE_NO_FACE_CHECK = 0x439E9BC95B7E7FBE,
        GET_MOBILE_PHONE_RENDER_ID = 0xB4A53E05F68B6FA1,
        _0x1B0B4AEED5B9B41C = 0x1B0B4AEED5B9B41C,
        _0x53F4892D18EC90A4 = 0x53F4892D18EC90A4,
        _0x3117D84EFA60F77B = 0x3117D84EFA60F77B,
        _0x15E69E2802C24B8D = 0x15E69E2802C24B8D,
        _0xAC2890471901861C = 0xAC2890471901861C,
        _0xD6ADE981781FCA09 = 0xD6ADE981781FCA09,
        _0xF1E22DC13F5EEBAD = 0xF1E22DC13F5EEBAD,
        _0x466DA42C89865553 = 0x466DA42C89865553,
    }
}