using System;
namespace Hotstar
{
    public enum WATER : ulong
    { 
        /// <summary>
        /// This function set height to the value of z-axis of the water surface.
        /// 
        /// This function works with sea and lake. However it does not work with shallow rivers (e.g. raton canyon will return -100000.0f)
        /// 
        /// note: seems to return true when you are in water
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float* height
        ///
        /// </summary>
        GET_WATER_HEIGHT = 0xF6829842C06AE524,
        /// <summary>
        /// Sets the water height for a given position and radius.
        /// 
        ///
        /// > float x
        /// > float y
        /// > float radius
        /// > float height
        ///
        /// </summary>
        MODIFY_WATER = 0xC443FD757C3BA637,
        /// <summary>
        /// Most likely ADD_CURRENT_*
        ///
        /// > float xLow
        /// > float yLow
        /// > float xHigh
        /// > float yHigh
        /// > float height
        ///
        /// </summary>
        _ADD_CURRENT_RISE = 0xFDBF4CDBC07E1706,
        /// <summary>
        /// p0 is the handle returned from _0xFDBF4CDBC07E1706
        /// 
        /// Most likely REMOVE_CURRENT_*
        ///
        /// > int p0
        ///
        /// </summary>
        _REMOVE_CURRENT_RISE = 0xB1252E3E59A82AAF,
        /// <summary>
        /// Sets a value that determines how aggressive the ocean waves will be. Values of 2.0 or more make for very aggressive waves like you see during a thunderstorm.
        /// 
        /// Works only ~200 meters around the player.
        ///
        /// > float intensity
        ///
        /// </summary>
        SET_DEEP_OCEAN_SCALER = 0xB96B00E976BE977F,
        /// <summary>
        /// Gets the aggressiveness factor of the ocean waves.
        ///
        ///
        /// </summary>
        GET_DEEP_OCEAN_SCALER = 0x2B2A2CC86778B619,
        /// <summary>
        /// Sets the waves intensity back to original (1.0 in most cases).
        ///
        ///
        /// </summary>
        RESET_DEEP_OCEAN_SCALER = 0x5E5E99285AE812DB,
        GET_WATER_HEIGHT_NO_WAVES = 0x8EE6B53CE13A9794,
        TEST_PROBE_AGAINST_WATER = 0xFFA5D878809819DB,
        TEST_PROBE_AGAINST_ALL_WATER = 0x8974647ED222EA5F,
        TEST_VERTICAL_PROBE_AGAINST_ALL_WATER = 0x2B3451FA1E3142E2,
        _0x547237AA71AB44DE = 0x547237AA71AB44DE,
    }
}