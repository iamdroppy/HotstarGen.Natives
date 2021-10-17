using System;
namespace Hotstar
{
    public enum MISC : ulong
    { 
        /// <summary>
        /// Maximum value is 1.
        /// At a value of 0 the game will still run at a minimum time scale.
        /// 
        /// Slow Motion 1: 0.6
        /// Slow Motion 2: 0.4
        /// Slow Motion 3: 0.2
        ///
        /// > float timeScale
        ///
        /// </summary>
        SET_TIME_SCALE = 0x1D408577D440E81E,
        /// <summary>
        /// If true, the player can't save the game. 
        /// 
        /// 
        /// If the parameter is true, sets the mission flag to true, if the parameter is false, the function does nothing at all.
        /// 
        /// ^ also, if the mission flag is already set, the function does nothing at all
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_MISSION_FLAG = 0xC4301E5121A0ED73,
        /// <summary>
        /// If the parameter is true, sets the random event flag to true, if the parameter is false, the function does nothing at all.
        /// Does nothing if the mission flag is set.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_RANDOM_EVENT_FLAG = 0x971927086CFD2158,
        /// <summary>
        /// Returns pointer to an empty string.
        /// 
        /// GET_C*
        ///
        ///
        /// </summary>
        _GET_GLOBAL_CHAR_BUFFER = 0x24DA7D7667FD7B09,
        /// <summary>
        /// Hardcoded to return false.
        ///
        ///
        /// </summary>
        _HAS_RESUMED_FROM_SUSPEND = 0xE8B9C0EC9E183F35,
        /// <summary>
        /// Returns current weather name hash
        ///
        ///
        /// </summary>
        GET_PREV_WEATHER_TYPE_HASH_NAME = 0x564B884A05EC45A3,
        /// <summary>
        /// Returns weather name hash
        ///
        ///
        /// </summary>
        GET_NEXT_WEATHER_TYPE_HASH_NAME = 0x711327CD09C8F162,
        /// <summary>
        /// The following weatherTypes are used in the scripts:
        /// "CLEAR"
        /// "EXTRASUNNY"
        /// "CLOUDS"
        /// "OVERCAST"
        /// "RAIN"
        /// "CLEARING"
        /// "THUNDER"
        /// "SMOG"
        /// "FOGGY"
        /// "XMAS"
        /// "SNOW"
        /// "SNOWLIGHT"
        /// "BLIZZARD"
        /// "HALLOWEEN"
        /// "NEUTRAL"
        ///
        /// > const char* weatherType
        ///
        /// </summary>
        SET_WEATHER_TYPE_PERSIST = 0x704983DF373B198F,
        /// <summary>
        /// The following weatherTypes are used in the scripts:
        /// "CLEAR"
        /// "EXTRASUNNY"
        /// "CLOUDS"
        /// "OVERCAST"
        /// "RAIN"
        /// "CLEARING"
        /// "THUNDER"
        /// "SMOG"
        /// "FOGGY"
        /// "XMAS"
        /// "SNOW"
        /// "SNOWLIGHT"
        /// "BLIZZARD"
        /// "HALLOWEEN"
        /// "NEUTRAL"
        ///
        /// > const char* weatherType
        ///
        /// </summary>
        SET_WEATHER_TYPE_NOW_PERSIST = 0xED712CA327900C8A,
        /// <summary>
        /// The following weatherTypes are used in the scripts:
        /// "CLEAR"
        /// "EXTRASUNNY"
        /// "CLOUDS"
        /// "OVERCAST"
        /// "RAIN"
        /// "CLEARING"
        /// "THUNDER"
        /// "SMOG"
        /// "FOGGY"
        /// "XMAS"
        /// "SNOW"
        /// "SNOWLIGHT"
        /// "BLIZZARD"
        /// "HALLOWEEN"
        /// "NEUTRAL"
        ///
        /// > const char* weatherType
        ///
        /// </summary>
        SET_WEATHER_TYPE_NOW = 0x29B487C359E19889,
        /// <summary>
        /// Mixes two weather types. If percentWeather2 is set to 0.0f, then the weather will be entirely of weatherType1, if it is set to 1.0f it will be entirely of weatherType2. If it's set somewhere in between, there will be a mixture of weather behaviors. To test, try this in the RPH console, and change the float to different values between 0 and 1:
        /// 
        /// execute "NativeFunction.Natives.x578C752848ECFA0C(Game.GetHashKey(""RAIN""), Game.GetHashKey(""SMOG""), 0.50f);
        /// 
        /// Note that unlike most of the other weather natives, this native takes the hash of the weather name, not the plain string. These are the weather names and their hashes:
        /// 
        /// CLEAR  0x36A83D84
        /// EXTRASUNNY  0x97AA0A79
        /// CLOUDS  0x30FDAF5C
        /// OVERCAST    0xBB898D2D
        /// RAIN    0x54A69840
        /// CLEARING    0x6DB1A50D
        /// THUNDER 0xB677829F
        /// SMOG    0x10DCF4B5
        /// FOGGY   0xAE737644
        /// XMAS    0xAAC9C895
        /// SNOWLIGHT   0x23FB812B
        /// BLIZZARD    0x27EA2814
        /// 
        /// 
        /// 
        /// 
        /// 
        /// /* OLD INVALID INFO BELOW */
        /// Not tested. Based purely on disassembly. Instantly sets the weather to sourceWeather, then transitions to targetWeather over the specified transitionTime in seconds.
        /// 
        /// If an invalid hash is specified for sourceWeather, the current weather type will be used.
        /// If an invalid hash is specified for targetWeather, the next weather type will be used.
        /// If an invalid hash is specified for both sourceWeather and targetWeather, the function just changes the transition time of the current transition.
        ///
        /// > Hash weatherType1
        /// > Hash weatherType2
        /// > float percentWeather2
        ///
        /// </summary>
        _SET_WEATHER_TYPE_TRANSITION = 0x578C752848ECFA0C,
        /// <summary>
        /// Appears to have an optional bool parameter that is unused in the scripts.
        /// 
        /// If you pass true, something will be set to zero.
        ///
        /// > const char* weatherType
        ///
        /// </summary>
        SET_OVERRIDE_WEATHER = 0xA43D5C6FE51ADBEF,
        /// <summary>
        /// This seems to edit the water wave, intensity around your current location.
        /// 
        /// 0.0f = Normal
        /// 1.0f = So Calm and Smooth, a boat will stay still.
        /// 3.0f = Really Intense.
        ///
        /// > float strength
        ///
        /// </summary>
        WATER_OVERRIDE_SET_STRENGTH = 0xC54A08C85AE4D410,
        /// <summary>
        /// Sets the the raw wind speed value.
        ///
        /// > float speed
        ///
        /// </summary>
        SET_WIND = 0xAC3A74E8384A9919,
        /// <summary>
        /// Using this native will clamp the wind speed value to a range of 0.0- 12.0. Using SET_WIND sets the same value but without the restriction.
        ///
        /// > float speed
        ///
        /// </summary>
        SET_WIND_SPEED = 0xEE09ECEDBABE47FC,
        /// <summary>
        /// The wind direction in radians
        /// 180 degrees, wind will blow from the south
        ///
        /// > float direction
        ///
        /// </summary>
        SET_WIND_DIRECTION = 0xEB0F4468467B4528,
        /// <summary>
        /// With an `intensity` higher than `0.5f`, only the creation of puddles gets faster, rain and rain sound won't increase after that.
        /// With an `intensity` of `0.0f` rain and rain sounds are disabled and there won't be any new puddles.
        /// To use the rain intensity of the current weather, call this native with `-1f` as `intensity`.
        ///
        /// > float intensity
        ///
        /// </summary>
        _SET_RAIN_LEVEL = 0x643E26EA6E024D92,
        /// <summary>
        /// creates single lightning+thunder at random position
        ///
        ///
        /// </summary>
        FORCE_LIGHTNING_FLASH = 0xF6062E089251C898,
        /// <summary>
        /// Found in the scripts:
        /// 
        /// MISC::_11B56FBBF7224868("CONTRAILS");
        ///
        /// > const char* name
        ///
        /// </summary>
        PRELOAD_CLOUD_HAT = 0x11B56FBBF7224868,
        /// <summary>
        /// The following cloudhats are useable:
        /// altostratus
        /// Cirrus
        /// cirrocumulus
        /// Clear 01
        /// Cloudy 01
        /// Contrails
        /// Horizon
        /// horizonband1
        /// horizonband2
        /// horizonband3
        /// horsey
        /// Nimbus
        /// Puffs
        /// RAIN
        /// Snowy 01
        /// Stormy 01
        /// stratoscumulus
        /// Stripey
        /// shower
        /// Wispy
        /// 
        ///
        /// > const char* name
        /// > float transitionTime
        ///
        /// </summary>
        LOAD_CLOUD_HAT = 0xFC4842A34657BFCB,
        /// <summary>
        /// Called 4 times in the b617d scripts:
        /// MISC::_A74802FB8D0B7814("CONTRAILS", 0);
        ///
        /// > const char* name
        /// > float p1
        ///
        /// </summary>
        UNLOAD_CLOUD_HAT = 0xA74802FB8D0B7814,
        /// <summary>
        /// Gets the ground elevation at the specified position. Note that if the specified position is below ground level, the function will output zero!
        /// 
        /// x: Position on the X-axis to get ground elevation at.
        /// y: Position on the Y-axis to get ground elevation at.
        /// z: Position on the Z-axis to get ground elevation at.
        /// groundZ: The ground elevation at the specified position.
        /// ignoreWater: Nearly always 0, very rarely 1 in the scripts: https://gfycat.com/NiftyTatteredCricket
        /// 
        /// Bear in mind this native can only calculate the elevation when the coordinates are within the client's render distance.
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float* groundZ
        /// > BOOL ignoreWater
        /// > BOOL p5
        ///
        /// </summary>
        GET_GROUND_Z_FOR_3D_COORD = 0xC906A7DAB05C8D2B,
        /// <summary>
        /// Returns the distance between two three-dimensional points, optionally ignoring the Z values.
        /// If useZ is false, only the 2D plane (X-Y) will be considered for calculating the distance.
        /// 
        /// Consider using this faster native instead: SYSTEM::VDIST - DVIST always takes in consideration the 3D coordinates.
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > BOOL useZ
        ///
        /// </summary>
        GET_DISTANCE_BETWEEN_COORDS = 0xF1B760881820C952,
        /// <summary>
        /// dx = x1 - x2
        /// dy = y1 - y2
        ///
        /// > float dx
        /// > float dy
        ///
        /// </summary>
        GET_HEADING_FROM_VECTOR_2D = 0x2FFB6B224F4B2926,
        /// <summary>
        /// This sets bit [offset] of [address] to on.
        /// 
        /// The offsets used are different bits to be toggled on and off, typically there is only one address used in a script.
        /// 
        /// Example:
        /// MISC::SET_BIT(&bitAddress, 1);
        /// 
        /// To check if this bit has been enabled:
        /// MISC::IS_BIT_SET(bitAddress, 1); // will return 1 afterwards
        /// 
        /// Please note, this method may assign a value to [address] when used.
        ///
        /// > int* address
        /// > int offset
        ///
        /// </summary>
        SET_BIT = 0x933D6A9EEC1BACD0,
        /// <summary>
        /// This sets bit [offset] of [address] to off.
        /// 
        /// Example:
        /// MISC::CLEAR_BIT(&bitAddress, 1);
        /// 
        /// To check if this bit has been enabled:
        /// MISC::IS_BIT_SET(bitAddress, 1); // will return 0 afterwards
        ///
        /// > int* address
        /// > int offset
        ///
        /// </summary>
        CLEAR_BIT = 0xE80492A9AC099A93,
        /// <summary>
        /// This native converts its past string to hash. It is hashed using jenkins one at a time method.
        ///
        /// > const char* string
        ///
        /// </summary>
        GET_HASH_KEY = 0xD24D37CC275948CC,
        /// <summary>
        /// This native always come right before SET_ENTITY_QUATERNION where its final 4 parameters are SLERP_NEAR_QUATERNION p9 to p12
        ///
        /// > float t
        /// > float x
        /// > float y
        /// > float z
        /// > float w
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float w1
        /// > float* outX
        /// > float* outY
        /// > float* outZ
        /// > float* outW
        ///
        /// </summary>
        SLERP_NEAR_QUATERNION = 0xF2F6A2FA49278625,
        /// <summary>
        /// `range`: The range, seems to not be very accurate during testing.
        /// `p4`: Unknown, when set to true it seems to always return true no matter what I try.
        /// `checkVehicle`: Check for any vehicles in that area.
        /// `checkPeds`: Check for any peds in that area.
        /// `ignoreEntity`: This entity will be ignored if it's in the area. Set to 0 if you don't want to exclude any entities.
        /// The BOOL parameters that are documented have not been confirmed. They are just documented from what I've found during testing. They may not work as expected in all cases.
        /// 
        /// Returns true if there is anything in that location matching the provided parameters.
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float range
        /// > BOOL p4
        /// > BOOL checkVehicles
        /// > BOOL checkPeds
        /// > BOOL p7
        /// > BOOL p8
        /// > Entity ignoreEntity
        /// > BOOL p10
        ///
        /// </summary>
        IS_POSITION_OCCUPIED = 0xADCDE75E1C60F32D,
        /// <summary>
        /// Example: CLEAR_AREA(0, 0, 0, 30, true, false, false, false);
        ///
        /// > float X
        /// > float Y
        /// > float Z
        /// > float radius
        /// > BOOL p4
        /// > BOOL ignoreCopCars
        /// > BOOL ignoreObjects
        /// > BOOL p7
        ///
        /// </summary>
        CLEAR_AREA = 0xA56F01F3765B93A0,
        /// <summary>
        /// MISC::_0x957838AAF91BD12D(x, y, z, radius, false, false, false, false); seem to make all objects go away, peds, vehicles etc. All booleans set to true doesn't seem to change anything. 
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        /// > BOOL p4
        /// > BOOL p5
        /// > BOOL p6
        /// > BOOL p7
        ///
        /// </summary>
        CLEAR_AREA_LEAVE_VEHICLE_HEALTH = 0x957838AAF91BD12D,
        /// <summary>
        /// Example:
        /// CLEAR_AREA_OF_VEHICLES(0.0f, 0.0f, 0.0f, 10000.0f, false, false, false, false, false, false);
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        /// > BOOL p4
        /// > BOOL p5
        /// > BOOL p6
        /// > BOOL p7
        /// > BOOL p8
        /// > BOOL p9
        ///
        /// </summary>
        CLEAR_AREA_OF_VEHICLES = 0x01C7B9B38428AEB6,
        /// <summary>
        /// I looked through the PC scripts that this site provides you with a link to find. It shows the last param mainly uses, (0, 2, 6, 16, and 17) so I am going to assume it is a type of flag. 
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        /// > int flags
        ///
        /// </summary>
        CLEAR_AREA_OF_OBJECTS = 0xDD9B9B385AAC7F5B,
        /// <summary>
        /// Example:       CLEAR_AREA_OF_PEDS(0, 0, 0, 10000, 1);
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        /// > int flags
        ///
        /// </summary>
        CLEAR_AREA_OF_PEDS = 0xBE31FD6CE464AC59,
        /// <summary>
        /// flags appears to always be 0
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        /// > int flags
        ///
        /// </summary>
        CLEAR_AREA_OF_COPS = 0x04F8FC8FCF58F88D,
        /// <summary>
        /// flags is usually 0 in the scripts.
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        /// > int flags
        ///
        /// </summary>
        CLEAR_AREA_OF_PROJECTILES = 0x0A1CB9094635D1A6,
        /// <summary>
        /// ignoreVehicle - bypasses vehicle check of the local player (it will not open if you are in a vehicle and this is set to false)
        ///
        /// > BOOL ignoreVehicle
        ///
        /// </summary>
        SET_SAVE_MENU_ACTIVE = 0xC9BF75D28165FF77,
        /// <summary>
        /// For a full list, see here: pastebin.com/yLNWicUi
        ///
        /// > const char* scriptName
        ///
        /// </summary>
        TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME = 0x9DC711BC69C548DF,
        /// <summary>
        /// Returns the index of the newly created hospital spawn point.
        /// 
        /// p3 might be radius?
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float p3
        /// > Any p4
        ///
        /// </summary>
        ADD_HOSPITAL_RESTART = 0x1F464EF988465A81,
        /// <summary>
        /// The game by default has 5 hospital respawn points. Disabling them all will cause the player to respawn at the last position they were.
        ///
        /// > int hospitalIndex
        /// > BOOL toggle
        ///
        /// </summary>
        DISABLE_HOSPITAL_RESTART = 0xC8535819C450EBA8,
        /// <summary>
        /// Disables the spawn point at the police house on the specified index.
        /// 
        /// policeIndex: The police house index.
        /// toggle: true to enable the spawn point, false to disable.
        /// 
        /// - Nacorpio
        ///
        /// > int policeIndex
        /// > BOOL toggle
        ///
        /// </summary>
        DISABLE_POLICE_RESTART = 0x23285DED6EBD7EA3,
        /// <summary>
        /// Sets whether the game should fade out after the player dies.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_FADE_OUT_AFTER_DEATH = 0x4A18E01DF2C87B86,
        /// <summary>
        /// Sets whether the game should fade out after the player is arrested.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_FADE_OUT_AFTER_ARREST = 0x1E0B4DC0D990A4E7,
        /// <summary>
        /// Sets whether the game should fade in after the player dies or is arrested.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_FADE_IN_AFTER_DEATH_ARREST = 0xDA66D2796BA33F12,
        /// <summary>
        /// Returns true if profile setting 208 is equal to 0.
        ///
        ///
        /// </summary>
        GET_IS_AUTO_SAVE_OFF = 0x6E04F06094C87047,
        /// <summary>
        /// Shows the screen which is visible before you redo a mission? The game will make a restoration point where you will cameback when the mission is over.
        /// Returns 1 if the message isn't currently on screen
        ///
        ///
        /// </summary>
        QUEUE_MISSION_REPEAT_SAVE = 0x44A0BDC559B35F6E,
        /// <summary>
        /// entity - entity to ignore
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > int damage
        /// > BOOL p7
        /// > Hash weaponHash
        /// > Ped ownerPed
        /// > BOOL isAudible
        /// > BOOL isInvisible
        /// > float speed
        /// > Entity entity
        /// > Any p14
        ///
        /// </summary>
        SHOOT_SINGLE_BULLET_BETWEEN_COORDS_IGNORE_ENTITY = 0xE3A7742E0B7A2F8B,
        /// <summary>
        /// entity - entity to ignore
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > int damage
        /// > BOOL p7
        /// > Hash weaponHash
        /// > Ped ownerPed
        /// > BOOL isAudible
        /// > BOOL isInvisible
        /// > float speed
        /// > Entity entity
        /// > BOOL p14
        /// > BOOL p15
        /// > BOOL p16
        /// > BOOL p17
        /// > Any p18
        /// > Any p19
        /// > Any p20
        ///
        /// </summary>
        SHOOT_SINGLE_BULLET_BETWEEN_COORDS_IGNORE_ENTITY_NEW = 0xBFE5756E7407064A,
        /// <summary>
        /// Gets the dimensions of a model.
        /// 
        /// Calculate (maximum - minimum) to get the size, in which case, Y will be how long the model is.
        /// 
        /// Example from the scripts: MISC::GET_MODEL_DIMENSIONS(ENTITY::GET_ENTITY_MODEL(PLAYER::PLAYER_PED_ID()), &v_1A, &v_17);
        ///
        /// > Hash modelHash
        /// > Vector3* minimum
        /// > Vector3* maximum
        ///
        /// </summary>
        GET_MODEL_DIMENSIONS = 0x03E8D3D5F549087A,
        /// <summary>
        /// Sets a visually fake wanted level on the user interface. Used by Rockstar's scripts to "override" regular wanted levels and make custom ones while the real wanted level and multipliers are still in effect.
        /// 
        /// Max is 6, anything above this makes it just 6. Also the mini-map gets the red & blue flashing effect.
        ///
        /// > int fakeWantedLevel
        ///
        /// </summary>
        SET_FAKE_WANTED_LEVEL = 0x1454F2448DE30163,
        /// <summary>
        /// Returns bit's boolean state from [offset] of [address].
        /// 
        /// Example:
        /// MISC::IS_BIT_SET(bitAddress, 1);
        /// 
        /// To enable and disable bits, see:
        /// MISC::SET_BIT(&bitAddress, 1);   // enable
        /// MISC::CLEAR_BIT(&bitAddress, 1); // disable
        ///
        /// > int address
        /// > int offset
        ///
        /// </summary>
        IS_BIT_SET = 0xA921AA820C25702F,
        /// <summary>
        /// This function is hard-coded to always return 0.
        ///
        ///
        /// </summary>
        IS_SNIPER_INVERTED = 0x61A23B7EDA9BDA24,
        /// <summary>
        /// Returns true if the game is using the metric measurement system (profile setting 227), false if imperial is used.
        ///
        ///
        /// </summary>
        SHOULD_USE_METRIC_MEASUREMENTS = 0xD3D15555431AB793,
        /// <summary>
        /// Compares two strings up to a specified number of characters.
        /// 
        /// Parameters:
        /// str1 - String to be compared.
        /// str2 - String to be compared.
        /// matchCase - Comparison will be case-sensitive.
        /// maxLength - Maximum number of characters to compare. A value of -1 indicates an infinite length.
        /// 
        /// Returns:
        /// A value indicating the relationship between the strings:
        /// <0 - The first non-matching character in 'str1' is less than the one in 'str2'. (e.g. 'A' < 'B', so result = -1)
        /// 0 - The contents of both strings are equal.
        /// >0 - The first non-matching character in 'str1' is less than the one in 'str2'. (e.g. 'B' > 'A', so result = 1)
        /// 
        /// Examples:
        /// MISC::COMPARE_STRINGS("STRING", "string", false, -1); // 0; equal
        /// MISC::COMPARE_STRINGS("TESTING", "test", false, 4); // 0; equal
        /// MISC::COMPARE_STRINGS("R2D2", "R2xx", false, 2); // 0; equal
        /// MISC::COMPARE_STRINGS("foo", "bar", false, -1); // 4; 'f' > 'b'
        /// MISC::COMPARE_STRINGS("A", "A", true, 1); // 0; equal
        /// 
        /// When comparing case-sensitive strings, lower-case characters are greater than upper-case characters:
        /// MISC::COMPARE_STRINGS("A", "a", true, 1); // -1; 'A' < 'a'
        /// MISC::COMPARE_STRINGS("a", "A", true, 1); // 1; 'a' > 'A'
        ///
        /// > const char* str1
        /// > const char* str2
        /// > BOOL matchCase
        /// > int maxLength
        ///
        /// </summary>
        COMPARE_STRINGS = 0x1E34710ECD4AB0EB,
        /// <summary>
        /// Determines whether there is a sniper bullet within the specified coordinates. The coordinates form an axis-aligned bounding box.
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        ///
        /// </summary>
        IS_SNIPER_BULLET_IN_AREA = 0xFEFCF11B01287125,
        /// <summary>
        /// Determines whether there is a projectile within the specified coordinates. The coordinates form a rectangle.
        /// 
        /// - Nacorpio
        /// 
        /// 
        /// ownedByPlayer = only projectiles fired by the player will be detected.
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > BOOL ownedByPlayer
        ///
        /// </summary>
        IS_PROJECTILE_IN_AREA = 0x5270A8FBC098C3F8,
        /// <summary>
        /// Determines whether there is a projectile of a specific type within the specified coordinates. The coordinates form a axis-aligned bounding box.
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > int type
        /// > BOOL ownedByPlayer
        ///
        /// </summary>
        IS_PROJECTILE_TYPE_IN_AREA = 0x2E0DC353342C4A6D,
        /// <summary>
        /// See IS_POINT_IN_ANGLED_AREA for the definition of an angled area.
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > float width
        /// > Any p7
        /// > BOOL ownedByPlayer
        ///
        /// </summary>
        IS_PROJECTILE_TYPE_IN_ANGLED_AREA = 0xF0BC12401061DEA0,
        /// <summary>
        /// GET_PROJECTILE_*
        ///
        /// > Ped ped
        /// > Hash weaponHash
        /// > float distance
        /// > Vector3* outCoords
        /// > Object* outProjectile
        /// > BOOL p5
        ///
        /// </summary>
        _GET_PROJECTILE_NEAR_PED = 0x82FDE6A57EE4EE44,
        /// <summary>
        /// For projectiles, see: IS_PROJECTILE_TYPE_IN_ANGLED_AREA
        /// See IS_POINT_IN_ANGLED_AREA for the definition of an angled area.
        /// Returns True if a bullet, as maintained by a pool within CWeaponManager, has been fired into the defined angled area.
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > float width
        /// > BOOL ownedByPlayer
        ///
        /// </summary>
        IS_BULLET_IN_ANGLED_AREA = 0x1A8B5F3C01E2B477,
        /// <summary>
        /// p3 - possibly radius?
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float p3
        /// > BOOL p4
        /// > BOOL p5
        ///
        /// </summary>
        HAS_BULLET_IMPACTED_IN_AREA = 0x9870ACFB89A90995,
        /// <summary>
        /// PS4
        ///
        ///
        /// </summary>
        IS_ORBIS_VERSION = 0xA72BC0B675B1519E,
        /// <summary>
        /// XBOX ONE
        ///
        ///
        /// </summary>
        IS_DURANGO_VERSION = 0x4D982ADB1978442D,
        /// <summary>
        /// if (MISC::IS_AUSSIE_VERSION()) {
        ///     sub_127a9(&l_31, 1024); // l_31 |= 1024
        ///     l_129 = 3;
        ///     sub_129d2("AUSSIE VERSION IS TRUE!?!?!"); // DEBUG
        /// }
        /// 
        /// Used to block some of the prostitute stuff due to laws in Australia.
        ///
        ///
        /// </summary>
        IS_AUSSIE_VERSION = 0x9F1935CA1F724008,
        /// <summary>
        /// Returns false if it's a null or empty string or if the string is too long. outInteger will be set to -999 in that case.
        /// 
        /// If all checks have passed successfully, the return value will be set to whatever strtol(string, 0i64, 10); returns.
        ///
        /// > const char* string
        /// > int* outInteger
        ///
        /// </summary>
        STRING_TO_INT = 0x5A5F40FE637EB584,
        /// <summary>
        /// See description of `ADD_STUNT_JUMP_ANGLED` for detailed info. The only difference really is this one does not have the radius (or angle, not sure) floats parameters for entry and landing zones.
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > float x3
        /// > float y3
        /// > float z3
        /// > float x4
        /// > float y4
        /// > float z4
        /// > float camX
        /// > float camY
        /// > float camZ
        /// > int p15
        /// > int p16
        /// > int p17
        ///
        /// </summary>
        ADD_STUNT_JUMP = 0x1A992DA297A4630C,
        /// <summary>
        /// Creates a new stunt jump.
        /// 
        /// The radius1 and radius2 might actually not be a radius at all, but that's what it seems to me testing them in-game. But they may be 'angle' floats instead, considering this native is named ADD_STUNT_JUMP_**ANGLED**.
        /// 
        /// Info about the specific 'parameter sections':
        /// 
        /// 
        /// **x1, y1, z1, x2, y2, z2 and radius1:**
        /// 
        /// First coordinates are for the jump entry area, and the radius that will be checked around that area. So if you're not exactly within the coordinates, but you are within the outter radius limit then it will still register as entering the stunt jump. Note as mentioned above, the radius is just a guess, I'm not really sure about it's exact purpose.
        /// 
        /// 
        /// **x3, y3, z3, x4, y4, z4 and radius2:**
        /// 
        /// Next part is the landing area, again starting with the left bottom (nearest to the stunt jump entry zone) coordinate, and the second one being the top right furthest away part of the landing area. Followed by another (most likely) radius float, this is usually slightly larger than the entry zone 'radius' float value, just because you have quite a lot of places where you can land (I'm guessing).
        /// 
        /// 
        /// **camX, camY and camZ:**
        /// 
        /// The final coordinate in this native is the Camera position. Rotation and zoom/FOV is managed by the game itself, you just need to provide the camera location.
        /// 
        /// 
        /// **unk1, unk2 and unk3:**
        /// 
        /// Not sure what these are for, but they're always `150, 0, 0` in decompiled scripts.
        /// 
        /// Visualized example in-game: https://d.fivem.dev/2019-03-15_18-24_c7802_846.png
        /// 
        /// Here is a list of almost all of the stunt jumps from GTA V (taken from decompiled scripts): https://pastebin.com/EW1jBPkY
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > float radius1
        /// > float x3
        /// > float y3
        /// > float z3
        /// > float x4
        /// > float y4
        /// > float z4
        /// > float radius2
        /// > float camX
        /// > float camY
        /// > float camZ
        /// > int p17
        /// > int p18
        /// > int p19
        ///
        /// </summary>
        ADD_STUNT_JUMP_ANGLED = 0xBBE5D803A5360CBF,
        /// <summary>
        /// Make sure to call this from the correct thread if you're using multiple threads because all other threads except the one which is calling SET_GAME_PAUSED will be paused which means you will lose control and the game remains in paused mode until you exit GTA5.exe
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_GAME_PAUSED = 0x577D1284D6873711,
        /// <summary>
        /// This native appears on the cheat_controller script and tracks a combination of buttons, which may be used to toggle cheats in-game. Credits to ThreeSocks for the info. The hash contains the combination, while the "amount" represents the amount of buttons used in a combination. The following page can be used to make a button combination: gta5offset.com/ts/hash/
        /// 
        /// INT_SCORES_SCORTED was a hash collision
        ///
        /// > Hash hash
        /// > int amount
        ///
        /// </summary>
        _HAS_BUTTON_COMBINATION_JUST_BEEN_ENTERED = 0x071E2A839DE82D90,
        /// <summary>
        /// Get inputted "Cheat code", for example:
        /// 
        /// while (TRUE)
        /// {
        ///     if (MISC::_557E43C447E700A8(${fugitive}))
        ///     {
        ///        // Do something.
        ///     }
        ///     SYSTEM::WAIT(0);
        /// }
        /// 
        /// Calling this will also set the last saved string hash to zero.
        /// 
        ///
        /// > Hash hash
        ///
        /// </summary>
        _HAS_CHEAT_STRING_JUST_BEEN_ENTERED = 0x557E43C447E700A8,
        /// <summary>
        /// Formerly known as _LOWER_MAP_PROP_DENSITY and wrongly due to idiots as _ENABLE_MP_DLC_MAPS.
        /// Sets the maximum prop density and changes a loading screen flag from 'loading story mode' to 'loading GTA Online'. Does not touch DLC map data at all.
        /// 
        /// In fact, I doubt this changes the flag whatsoever, that's the OTHER native idiots use together with this that does so, this one only causes a loading screen to show as it reloads map data.
        ///
        /// > int p0
        ///
        /// </summary>
        SET_INSTANCE_PRIORITY_MODE = 0x9BAE5AD2508DF078,
        /// <summary>
        /// Sets an unknown flag used by CScene in determining which entities from CMapData scene nodes to draw, similar to SET_INSTANCE_PRIORITY_MODE.
        ///
        /// > int flag
        ///
        /// </summary>
        SET_INSTANCE_PRIORITY_HINT = 0xC5F0A8EBD3F361CE,
        /// <summary>
        /// This function is hard-coded to always return 0.
        ///
        ///
        /// </summary>
        IS_FRONTEND_FADING = 0x7EA2B6AF97ECA6ED,
        /// <summary>
        /// spawns a few distant/out-of-sight peds, vehicles, animals etc each time it is called
        ///
        ///
        /// </summary>
        POPULATE_NOW = 0x7472BB270D7B4F3E,
        /// <summary>
        /// level can be from 0 to 3
        /// 0: 9.8 - normal
        /// 1: 2.4 - low
        /// 2: 0.1 - very low
        /// 3: 0.0 - off
        /// 
        /// //SuckMyCoke
        ///
        /// > int level
        ///
        /// </summary>
        SET_GRAVITY_LEVEL = 0x740E14FAD5842351,
        /// <summary>
        /// Seems to have the same functionality as REGISTER_TEXT_LABEL_TO_SAVE?
        /// 
        /// MISC::_6F7794F28C6B2535(&a_0._f1, "tlPlateText");
        /// MISC::_6F7794F28C6B2535(&a_0._f1C, "tlPlateText_pending");
        /// MISC::_6F7794F28C6B2535(&a_0._f10B, "tlCarAppPlateText");
        /// 
        /// "tl" prefix sounds like "Text Label"
        ///
        /// > Any* p0
        /// > const char* name
        ///
        /// </summary>
        _REGISTER_TEXT_LABEL_TO_SAVE_2 = 0x6F7794F28C6B2535,
        /// <summary>
        /// https://alloc8or.re/gta5/doc/enums/DispatchType.txt
        ///
        /// > int dispatchService
        /// > BOOL toggle
        ///
        /// </summary>
        ENABLE_DISPATCH_SERVICE = 0xDC0F817884CDD856,
        /// <summary>
        /// As for the 'police' incident, it will call police cars to you, but unlike PedsInCavalcades & Merryweather they won't start shooting at you unless you shoot first or shoot at them. The top 2 however seem to cancel theirselves if there is noone dead around you or a fire. I only figured them out as I found out the 3rd param is definately the amountOfPeople and they called incident 3 in scripts with 4 people (which the firetruck has) and incident 5 with 2 people (which the ambulence has). The 4 param I cant say is radius, but for the pedsInCavalcades and Merryweather R* uses 0.0f and for the top 3 (Emergency Services) they use 3.0f. 
        /// 
        /// Side Note: It seems calling the pedsInCavalcades or Merryweather then removing it seems to break you from calling the EmergencyEvents and I also believe pedsInCavalcades. (The V cavalcades of course not IV).
        /// 
        /// Side Note 2: I say it breaks as if you call this proper,
        /// if(CREATE_INCIDENT) etc it will return false if you do as I said above.
        /// =====================================================
        ///
        /// > int dispatchService
        /// > float x
        /// > float y
        /// > float z
        /// > int numUnits
        /// > float radius
        /// > int* outIncidentID
        /// > Any p7
        /// > Any p8
        ///
        /// </summary>
        CREATE_INCIDENT = 0x3F892CAF67444AE7,
        /// <summary>
        /// As for the 'police' incident, it will call police cars to you, but unlike PedsInCavalcades & Merryweather they won't start shooting at you unless you shoot first or shoot at them. The top 2 however seem to cancel theirselves if there is noone dead around you or a fire. I only figured them out as I found out the 3rd param is definately the amountOfPeople and they called incident 3 in scripts with 4 people (which the firetruck has) and incident 5 with 2 people (which the ambulence has). The 4 param I cant say is radius, but for the pedsInCavalcades and Merryweather R* uses 0.0f and for the top 3 (Emergency Services) they use 3.0f. 
        /// 
        /// Side Note: It seems calling the pedsInCavalcades or Merryweather then removing it seems to break you from calling the EmergencyEvents and I also believe pedsInCavalcades. (The V cavalcades of course not IV).
        /// 
        /// Side Note 2: I say it breaks as if you call this proper,
        /// if(CREATE_INCIDENT) etc it will return false if you do as I said above.
        /// =====================================================
        ///
        /// > int dispatchService
        /// > Ped ped
        /// > int numUnits
        /// > float radius
        /// > int* outIncidentID
        /// > Any p5
        /// > Any p6
        ///
        /// </summary>
        CREATE_INCIDENT_WITH_ENTITY = 0x05983472F0494E60,
        /// <summary>
        /// Delete an incident with a given id.
        /// 
        /// =======================================================
        /// Correction, I have change this to int, instead of int*
        /// as it doesn't use a pointer to the createdIncident.
        /// If you try it you will crash (or) freeze.
        /// =======================================================
        ///
        /// > int incidentId
        ///
        /// </summary>
        DELETE_INCIDENT = 0x556C1AA270D5A207,
        /// <summary>
        /// =======================================================
        /// Correction, I have change this to int, instead of int*
        /// as it doesn't use a pointer to the createdIncident.
        /// If you try it you will crash (or) freeze.
        /// =======================================================
        ///
        /// > int incidentId
        ///
        /// </summary>
        IS_INCIDENT_VALID = 0xC8BC6461E629BEAA,
        /// <summary>
        /// SET_INCIDENT_*
        ///
        /// > int incidentId
        /// > float p1
        ///
        /// </summary>
        _SET_INCIDENT_UNK = 0xD261BA3E7E998072,
        /// <summary>
        /// Finds a position ahead of the player by predicting the players next actions.
        /// The positions match path finding node positions.
        /// When roads diverge, the position may rapidly change between two or more positions. This is due to the engine not being certain of which path the player will take.
        /// 
        /// =======================================================
        /// I may sort this with alter research, but if someone
        /// already knows please tell what the difference in 
        /// X2, Y2, Z2 is. I doubt it's rotation. Is it like 
        /// checkpoints where X1, Y1, Z1 is your/a position and
        /// X2, Y2, Z2 is a given position ahead of that position?
        /// =======================================================
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > float distance
        /// > Vector3* spawnPoint
        ///
        /// </summary>
        FIND_SPAWN_POINT_IN_DIRECTION = 0x6874E2190B0C1972,
        /// <summary>
        /// This native is adding a zone, where you can change density settings. For example, you can add a zone on 0.0, 0.0, 0.0 with radius 900.0 and vehicleMultiplier 0.0, and you will not see any new population vehicle spawned in a radius of 900.0 from 0.0, 0.0, 0.0. Returns the id. You can have only 15 zones at the same time. You can remove zone using REMOVE_POP_MULTIPLIER_SPHERE
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        /// > float pedMultiplier
        /// > float vehicleMultiplier
        /// > BOOL p6
        /// > BOOL p7
        ///
        /// </summary>
        ADD_POP_MULTIPLIER_SPHERE = 0x32C7A7E8C43A1F80,
        /// <summary>
        /// Removes population multiplier sphere
        ///
        /// > int id
        /// > BOOL p1
        ///
        /// </summary>
        REMOVE_POP_MULTIPLIER_SPHERE = 0xE6869BECDD8F2403,
        /// <summary>
        /// Makes the ped jump around like they're in a tennis match
        ///
        /// > Ped ped
        /// > BOOL toggle
        /// > BOOL p2
        ///
        /// </summary>
        ENABLE_TENNIS_MODE = 0x28A04B411933F8A6,
        /// <summary>
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        ///
        /// > Ped ped
        /// > const char* animDict
        /// > const char* animName
        /// > float p3
        /// > float p4
        /// > BOOL p5
        ///
        /// </summary>
        PLAY_TENNIS_SWING_ANIM = 0xE266ED23311F24D4,
        /// <summary>
        /// To remove, see: REMOVE_DISPATCH_SPAWN_BLOCKING_AREA
        /// See IS_POINT_IN_ANGLED_AREA for the definition of an angled area.
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > float width
        ///
        /// </summary>
        _ADD_DISPATCH_SPAWN_BLOCKING_ANGLED_AREA = 0x918C7B2D2FF3928B,
        /// <summary>
        /// Adds a point related to CTacticalAnalysis
        ///
        /// > float x
        /// > float y
        /// > float z
        ///
        /// </summary>
        _ADD_TACTICAL_ANALYSIS_POINT = 0xB8721407EE9C3FF6,
        /// <summary>
        /// Activates (usused?) riot mode. All NPCs are being hostile to each other (including player). Also the game will give weapons (pistols, smgs) to random NPCs.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_RIOT_MODE_ENABLED = 0x2587A48BC88DFADF,
        /// <summary>
        /// sfink: note, p0 is set to 6 for PC platform in at least 1 script, or to `unk::_get_ui_language_id() == 0` otherwise.
        /// 
        /// NOTE: windowTitle uses text labels, and an invalid value will display nothing.
        /// 
        /// www.gtaforums.com/topic/788343-vrel-script-hook-v/?p=1067380474
        /// 
        /// windowTitle's
        /// -----------------
        /// CELL_EMAIL_BOD  =   "Enter your Eyefind message"
        /// CELL_EMAIL_BODE =   "Message too long. Try again"
        /// CELL_EMAIL_BODF    =   "Forbidden message. Try again"
        /// CELL_EMAIL_SOD    =   "Enter your Eyefind subject"
        /// CELL_EMAIL_SODE =   "Subject too long. Try again"
        /// CELL_EMAIL_SODF    =   "Forbidden text. Try again"
        /// CELL_EMASH_BOD   =   "Enter your Eyefind message"
        /// CELL_EMASH_BODE =   "Message too long. Try again"
        /// CELL_EMASH_BODF    =   "Forbidden message. Try again"
        /// CELL_EMASH_SOD    =   "Enter your Eyefind subject"
        /// CELL_EMASH_SODE =   "Subject too long. Try again"
        /// CELL_EMASH_SODF    =   "Forbidden Text. Try again"
        /// FMMC_KEY_TIP10   =   "Enter Synopsis"
        /// FMMC_KEY_TIP12  =   "Enter Custom Team Name"
        /// FMMC_KEY_TIP12F =   "Forbidden Text. Try again"
        /// FMMC_KEY_TIP12N  =   "Custom Team Name"
        /// FMMC_KEY_TIP8 =   "Enter Message"
        /// FMMC_KEY_TIP8F   =   "Forbidden Text. Try again"
        /// FMMC_KEY_TIP8FS  =   "Invalid Message. Try again"
        /// FMMC_KEY_TIP8S  =   "Enter Message"
        /// FMMC_KEY_TIP9    =   "Enter Outfit Name"
        /// FMMC_KEY_TIP9F   =   "Invalid Outfit Name. Try again"
        /// FMMC_KEY_TIP9N  =   "Outfit Name"
        /// PM_NAME_CHALL  =   "Enter Challenge Name"
        ///
        /// > int p0
        /// > const char* windowTitle
        /// > const char* p2
        /// > const char* defaultText
        /// > const char* defaultConcat1
        /// > const char* defaultConcat2
        /// > const char* defaultConcat3
        /// > int maxInputLength
        ///
        /// </summary>
        DISPLAY_ONSCREEN_KEYBOARD = 0x00DC833F2568DBF6,
        /// <summary>
        /// Returns the current status of the onscreen keyboard, and updates the output.
        /// 
        /// Status Codes:
        /// 
        /// -1: Keyboard isn't active
        /// 0: User still editing
        /// 1: User has finished editing
        /// 2: User has canceled editing
        ///
        ///
        /// </summary>
        UPDATE_ONSCREEN_KEYBOARD = 0x0CF2B696BBF945AE,
        /// <summary>
        /// Returns NULL unless UPDATE_ONSCREEN_KEYBOARD() returns 1 in the same tick.
        ///
        ///
        /// </summary>
        GET_ONSCREEN_KEYBOARD_RESULT = 0x8362B09B91893647,
        /// <summary>
        /// DO NOT use this as it doesn't clean up the text input box properly and your script will get stuck in the UPDATE_ONSCREEN_KEYBOARD() loop.
        /// Use _FORCE_CLOSE_TEXT_INPUT_BOX instead.
        /// 
        /// CANCEL_*
        ///
        ///
        /// </summary>
        _CANCEL_ONSCREEN_KEYBOARD = 0x58A39BE597CE99CD,
        /// <summary>
        /// p0 was always 2 in R* scripts.
        /// Called before calling DISPLAY_ONSCREEN_KEYBOARD if the input needs to be saved.
        ///
        /// > int p0
        ///
        /// </summary>
        NEXT_ONSCREEN_KEYBOARD_RESULT_WILL_DISPLAY_USING_THESE_FONTS = 0x3ED1438C1F5C6612,
        /// <summary>
        /// Appears to remove stealth kill action from memory
        ///
        /// > Hash hash
        /// > BOOL p1
        ///
        /// </summary>
        _REMOVE_STEALTH_KILL = 0xA6A12939F16D85BE,
        /// <summary>
        /// Sets the localplayer playerinfo state back to playing (State 0)
        /// 
        /// States are:
        /// -1: "Invalid"
        /// 0: "Playing"
        /// 1: "Died"
        /// 2: "Arrested"
        /// 3: "Failed Mission"
        /// 4: "Left Game"
        /// 5: "Respawn"
        /// 6: "In MP Cutscene"
        ///
        ///
        /// </summary>
        FORCE_GAME_STATE_PLAYING = 0xC0AA53F866B3134D,
        /// <summary>
        /// Begins with START_*. Next character in the name is either D or E.
        ///
        ///
        /// </summary>
        _START_BENCHMARK_RECORDING = 0x92790862E36C2ADA,
        /// <summary>
        /// Begins with STOP_*. Next character in the name is either D or E.
        ///
        ///
        /// </summary>
        _STOP_BENCHMARK_RECORDING = 0xC7DB36C24634F52B,
        /// <summary>
        /// Begins with RESET_*. Next character in the name is either D or E.
        ///
        ///
        /// </summary>
        _RESET_BENCHMARK_RECORDING = 0x437138B6A830166A,
        /// <summary>
        /// Saves the benchmark recording to %USERPROFILE%\Documents\Rockstar Games\GTA V\Benchmarks and submits some metrics.
        ///
        ///
        /// </summary>
        _SAVE_BENCHMARK_RECORDING = 0x37DEB0AA183FB6D8,
        /// <summary>
        /// Returns true if the current frontend menu is FE_MENU_VERSION_SP_PAUSE
        /// 
        /// U*
        ///
        ///
        /// </summary>
        _UI_IS_SINGLEPLAYER_PAUSE_MENU_ACTIVE = 0xEA2F2061875EED90,
        /// <summary>
        /// Returns true if the current frontend menu is FE_MENU_VERSION_LANDING_MENU
        ///
        ///
        /// </summary>
        _LANDING_MENU_IS_ACTIVE = 0x3BBBD13E5041A79E,
        /// <summary>
        /// Returns true if command line option '-benchmark' is set.
        ///
        ///
        /// </summary>
        _IS_COMMAND_LINE_BENCHMARK_VALUE_SET = 0xA049A5BE0F04F2F8,
        /// <summary>
        /// Returns value of the '-benchmarkIterations' command line option.
        ///
        ///
        /// </summary>
        _GET_BENCHMARK_ITERATIONS_FROM_COMMAND_LINE = 0x4750FC27570311EC,
        /// <summary>
        /// Returns value of the '-benchmarkPass' command line option.
        ///
        ///
        /// </summary>
        _GET_BENCHMARK_PASS_FROM_COMMAND_LINE = 0x1B2366C3F2A5C8DF,
        /// <summary>
        /// In singleplayer it does exactly what the name implies. In FiveM / GTA:Online it shows `Disconnecting from GTA Online` HUD and then quits the game.
        ///
        ///
        /// </summary>
        _RESTART_GAME = 0xE574A662ACAEFBB1,
        /// <summary>
        /// Exits the game and downloads a fresh social club update on next restart.
        ///
        ///
        /// </summary>
        _FORCE_SOCIAL_CLUB_UPDATE = 0xEB6891F03362FB12,
        /// <summary>
        /// Hardcoded to always return true.
        ///
        ///
        /// </summary>
        _HAS_ASYNC_INSTALL_FINISHED = 0x14832BF2ABA53FC5,
        /// <summary>
        /// aka "constrained"
        ///
        ///
        /// </summary>
        _IS_IN_POWER_SAVING_MODE = 0x684A41975F077262,
        /// <summary>
        /// Returns duration of how long the game has been in power-saving mode (aka "constrained") in milliseconds.
        ///
        ///
        /// </summary>
        _GET_POWER_SAVING_MODE_DURATION = 0xABB2FA71C83A1B72,
        /// <summary>
        /// If toggle is true, the ped's head is shown in the pause menu
        /// If toggle is false, the ped's head is not shown in the pause menu
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_PLAYER_IS_IN_ANIMAL_FORM = 0x4EBB7E87AA0DBED4,
        /// <summary>
        /// Although we don't have a jenkins hash for this one, the name is 100% confirmed.
        ///
        ///
        /// </summary>
        GET_IS_PLAYER_IN_ANIMAL_FORM = 0x9689123E3F213AA5,
        /// <summary>
        /// SET_PLAYER_*
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_PLAYER_ROCKSTAR_EDITOR_DISABLED = 0x9D8D44ADBBA61EF2,
        /// <summary>
        /// Does nothing (it's a nullsub). Seems to be PS4 specific.
        ///
        /// > const char* p0
        /// > const char* p1
        ///
        /// </summary>
        _0x4DCDF92BF64236CD = 0x4DCDF92BF64236CD,
        /// <summary>
        /// Does nothing (it's a nullsub). Seems to be PS4 specific.
        ///
        /// > const char* p0
        ///
        /// </summary>
        _0x31125FD509D9043F = 0x31125FD509D9043F,
        /// <summary>
        /// Does nothing (it's a nullsub). Seems to be PS4 specific.
        ///
        /// > const char* p0
        ///
        /// </summary>
        _0xEBD3205A207939ED = 0xEBD3205A207939ED,
        /// <summary>
        /// Does nothing (it's a nullsub). Seems to be PS4 specific.
        ///
        /// > Any p0
        ///
        /// </summary>
        _0x97E7E2C04245115B = 0x97E7E2C04245115B,
        /// <summary>
        /// Does nothing (it's a nullsub). Seems to be PS4 specific.
        ///
        /// > const char* p0
        ///
        /// </summary>
        _0x916CA67D26FD1E37 = 0x916CA67D26FD1E37,
        /// <summary>
        /// Does nothing (it's a nullsub). Seems to be PS4 specific.
        ///
        /// > const char* p0
        /// > const char* p1
        ///
        /// </summary>
        _0xEB078CA2B5E82ADD = 0xEB078CA2B5E82ADD,
        /// <summary>
        /// Does nothing (it's a nullsub). Seems to be PS4 specific.
        ///
        /// > const char* p0
        ///
        /// </summary>
        _0x703CC7F60CBB2B57 = 0x703CC7F60CBB2B57,
        /// <summary>
        /// Does nothing (it's a nullsub). Seems to be PS4 specific.
        ///
        ///
        /// </summary>
        _0x8951EB9C6906D3C8 = 0x8951EB9C6906D3C8,
        /// <summary>
        /// Does nothing (it's a nullsub). Seems to be PS4 specific.
        /// 
        /// Used only once in the scripts (ingamehud) with p0 = "AF_GAMEMODE"
        ///
        /// > const char* p0
        ///
        /// </summary>
        _0xBA4B8D83BDC75551 = 0xBA4B8D83BDC75551,
        /// <summary>
        /// Sets GtaThread+0x14A
        /// 
        /// SET_S*
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _0x65D2EBB47E1CEC21 = 0x65D2EBB47E1CEC21,
        /// <summary>
        /// Sets bit 3 in GtaThread+0x150
        /// 
        /// SET_T*
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _0x6F2135B6129620C1 = 0x6F2135B6129620C1,
        /// <summary>
        /// I*
        ///
        /// > const char* p0
        ///
        /// </summary>
        _0x8D74E26F54B4E5C3 = 0x8D74E26F54B4E5C3,
        /// <summary>
        /// 0 as param = weird black and green screen
        /// 0.1 - 0.99 = Prevent rain effect from falling (still sound and effects on puddles) and prevent puddles from increase/decrease, seems than it prevent any weather change too
        /// 1 and more = "Unfreeze" rain puddles but clear weather too
        /// When 'freezing' is enabled, it seem to also freeze value getted with GetRainLevel
        ///
        /// > float p0
        ///
        /// </summary>
        _0x0CF97F497FE7D048 = 0x0CF97F497FE7D048,
        /// <summary>
        /// Found in the scripts:
        /// 
        /// MISC::_02DEAAC8F8EA7FE7("");
        ///
        /// > const char* p0
        ///
        /// </summary>
        _0x02DEAAC8F8EA7FE7 = 0x02DEAAC8F8EA7FE7,
        /// <summary>
        /// GET_C*
        ///
        /// > float p0
        /// > float p1
        /// > float p2
        /// > float p3
        /// > float p4
        /// > float p5
        /// > float p6
        /// > float p7
        /// > float p8
        /// > BOOL p9
        ///
        /// </summary>
        _0x21C235BC64831E5A = 0x21C235BC64831E5A,
        /// <summary>
        /// Possibly used to clear scenario points.
        /// 
        /// CLEAR_*
        ///
        ///
        /// </summary>
        _0x7EC6F9A478A6A512 = 0x7EC6F9A478A6A512,
        /// <summary>
        /// GET_SAVE_*
        /// 
        /// GET_SAVE_UNLESS_CUSTOM_DOT ?
        ///
        /// > Vector3* p0
        /// > float* p1
        /// > BOOL* fadeInAfterLoad
        /// > BOOL* p3
        ///
        /// </summary>
        _0xA4A0065E39C9F25C = 0xA4A0065E39C9F25C,
        /// <summary>
        /// Toggles some stunt jump stuff.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _0xFB80AB299D2EE1BD = 0xFB80AB299D2EE1BD,
        /// <summary>
        /// Only found 3 times in decompiled scripts. Not a whole lot to go off of.
        /// 
        /// MISC::_48F069265A0E4BEC(a_0, "Movie_Name_For_This_Player");
        /// MISC::_48F069265A0E4BEC(&a_0._fB, "Ringtone_For_This_Player");
        /// MISC::_48F069265A0E4BEC(&a_0._f1EC4._f12[v_A/*6*/], &v_13); // where v_13 is "MPATMLOGSCRS0" thru "MPATMLOGSCRS15"
        ///
        /// > Any* p0
        /// > const char* name
        ///
        /// </summary>
        _0x48F069265A0E4BEC = 0x48F069265A0E4BEC,
        /// <summary>
        /// Only found 2 times in decompiled scripts. Not a whole lot to go off of.
        /// 
        /// MISC::_8269816F6CFD40F8(&a_0._f1F5A._f6[0/*8*/], "TEMPSTAT_LABEL"); // gets saved in a struct called "g_SaveData_STRING_ScriptSaves"
        /// MISC::_8269816F6CFD40F8(&a_0._f4B4[v_1A/*8*/], &v_5); // where v_5 is "Name0" thru "Name9", gets saved in a struct called "OUTFIT_Name"
        ///
        /// > Any* p0
        /// > const char* name
        ///
        /// </summary>
        _0x8269816F6CFD40F8 = 0x8269816F6CFD40F8,
        /// <summary>
        /// Another unknown label type...
        /// 
        /// MISC::_FAA457EF263E8763(a_0, "Thumb_label");
        /// MISC::_FAA457EF263E8763(&a_0._f10, "Photo_label");
        /// MISC::_FAA457EF263E8763(a_0, "GXTlabel");
        /// MISC::_FAA457EF263E8763(&a_0._f21, "StringComp");
        /// MISC::_FAA457EF263E8763(&a_0._f43, "SecondStringComp");
        /// MISC::_FAA457EF263E8763(&a_0._f53, "ThirdStringComp");
        /// MISC::_FAA457EF263E8763(&a_0._f32, "SenderStringComp");
        /// MISC::_FAA457EF263E8763(&a_0._f726[v_1A/*16*/], &v_20); // where v_20 is "LastJobTL_0_1" thru "LastJobTL_2_1", gets saved in a struct called "LAST_JobGamer_TL"
        /// MISC::_FAA457EF263E8763(&a_0._f4B, "PAID_PLAYER");
        /// MISC::_FAA457EF263E8763(&a_0._f5B, "RADIO_STATION");
        ///
        /// > Any* p0
        /// > const char* name
        ///
        /// </summary>
        _0xFAA457EF263E8763 = 0xFAA457EF263E8763,
        /// <summary>
        /// Related to tennis mode.
        /// 
        /// GET_TENNIS_*
        ///
        /// > Ped ped
        ///
        /// </summary>
        _0x19BFED045C647C49 = 0x19BFED045C647C49,
        /// <summary>
        /// Related to tennis mode.
        /// 
        /// GET_TENNIS_*
        ///
        /// > Ped ped
        ///
        /// </summary>
        _0xE95B0C7D5BA3B96B = 0xE95B0C7D5BA3B96B,
        /// <summary>
        /// From the scripts:
        /// 
        /// MISC::_54F157E0336A3822(sub_aa49(a_0), "ForcedStopDirection", v_E);
        /// 
        /// Related to tennis mode.
        /// 
        /// SET_*
        ///
        /// > Ped ped
        /// > const char* p1
        /// > float p2
        ///
        /// </summary>
        _0x54F157E0336A3822 = 0x54F157E0336A3822,
        /// <summary>
        /// RESET_*
        ///
        ///
        /// </summary>
        _0xD9F692D349249528 = 0xD9F692D349249528,
        /// <summary>
        /// SET_*
        ///
        /// > int p0
        /// > int p1
        ///
        /// </summary>
        _0xE532EC1A63231B4F = 0xE532EC1A63231B4F,
        /// <summary>
        /// Unsure about the use of this native but here's an example:
        /// 
        /// void sub_8709() {
        ///     MISC::_1EAE0A6E978894A2(0, 1);
        ///     MISC::_1EAE0A6E978894A2(1, 1);
        ///     MISC::_1EAE0A6E978894A2(2, 1);
        ///     MISC::_1EAE0A6E978894A2(3, 1);
        ///     MISC::_1EAE0A6E978894A2(4, 1);
        ///     MISC::_1EAE0A6E978894A2(5, 1);
        ///     MISC::_1EAE0A6E978894A2(6, 1);
        ///     MISC::_1EAE0A6E978894A2(7, 1);
        ///     MISC::_1EAE0A6E978894A2(8, 1);
        /// }
        /// 
        /// So it appears that p0 ranges from 0 to 8.
        /// 
        /// ENABLE_DISPATCH_SERVICE, seems to have a similar layout.
        ///
        /// > int p0
        /// > BOOL p1
        ///
        /// </summary>
        _0x1EAE0A6E978894A2 = 0x1EAE0A6E978894A2,
        /// <summary>
        /// HAS_*
        /// 
        /// Probably something like "has game been started for the first time".
        ///
        ///
        /// </summary>
        _0x6FDDF453C0C756EC = 0x6FDDF453C0C756EC,
        /// <summary>
        /// sets something to 1
        ///
        ///
        /// </summary>
        _0xE3D969D2785FFB5E = 0xE3D969D2785FFB5E,
        /// <summary>
        /// SCRIPT_RACE_*
        ///
        /// > Any p0
        /// > Any p1
        /// > Any p2
        /// > Any p3
        ///
        /// </summary>
        _0x1BB299305C3E8C13 = 0x1BB299305C3E8C13,
        /// <summary>
        /// Does nothing (it's a nullsub).
        ///
        ///
        /// </summary>
        _0x23227DF0B2115469 = 0x23227DF0B2115469,
        GET_ALLOCATED_STACK_SIZE = 0x8B3CA62B1EF19B62,
        GET_NUMBER_OF_FREE_STACKS_OF_THIS_SIZE = 0xFEAD16FC8F9DFC0F,
        SET_RANDOM_SEED = 0x444D98F98C11F3EC,
        GET_MISSION_FLAG = 0xA33CDCCDA663159E,
        GET_RANDOM_EVENT_FLAG = 0xD2D57F1D764117B1,
        _GET_BASE_ELEMENT_METADATA = 0xB335F761606DB47C,
        IS_PREV_WEATHER_TYPE = 0x44F28F86433B10A9,
        IS_NEXT_WEATHER_TYPE = 0x2FAA3A30BEC0F25D,
        SET_WEATHER_TYPE_OVERTIME_PERSIST = 0xFB5045B7C42B75BF,
        SET_RANDOM_WEATHER_TYPE = 0x8B05F884CF7E8020,
        CLEAR_WEATHER_TYPE_PERSIST = 0xCCC39339BEF76CF5,
        _GET_WEATHER_TYPE_TRANSITION = 0xF3BBE884A14BB413,
        CLEAR_OVERRIDE_WEATHER = 0x338D2E3477711050,
        WATER_OVERRIDE_SET_SHOREWAVEAMPLITUDE = 0xB8F87EAD7533B176,
        WATER_OVERRIDE_SET_SHOREWAVEMINAMPLITUDE = 0xC3EAD29AB273ECE8,
        WATER_OVERRIDE_SET_SHOREWAVEMAXAMPLITUDE = 0xA7A1127490312C36,
        WATER_OVERRIDE_SET_OCEANNOISEMINAMPLITUDE = 0x31727907B2C43C55,
        WATER_OVERRIDE_SET_OCEANWAVEAMPLITUDE = 0x405591EC8FD9096D,
        WATER_OVERRIDE_SET_OCEANWAVEMINAMPLITUDE = 0xF751B16FB32ABC1D,
        WATER_OVERRIDE_SET_OCEANWAVEMAXAMPLITUDE = 0xB3E6360DDE733E82,
        WATER_OVERRIDE_SET_RIPPLEBUMPINESS = 0x7C9C0B1EEB1F9072,
        WATER_OVERRIDE_SET_RIPPLEMINBUMPINESS = 0x6216B116083A7CB4,
        WATER_OVERRIDE_SET_RIPPLEMAXBUMPINESS = 0x9F5E6BB6B34540DA,
        WATER_OVERRIDE_SET_RIPPLEDISTURB = 0xB9854DFDE0D833D6,
        WATER_OVERRIDE_FADE_IN = 0xA8434F1DFF41D6E7,
        WATER_OVERRIDE_FADE_OUT = 0xC3C221ADDDE31A11,
        GET_WIND_SPEED = 0xA8CF1CC0AFCD3F12,
        GET_WIND_DIRECTION = 0x1F400FEF721170DA,
        GET_RAIN_LEVEL = 0x96695E368AD855F3,
        _SET_SNOW_LEVEL = 0x7F06937B0CDCBC1A,
        GET_SNOW_LEVEL = 0xC5868A966E5BE3AE,
        _CLEAR_CLOUD_HAT = 0x957E790EA1727B64,
        _SET_CLOUD_HAT_OPACITY = 0xF36199225D6D8C86,
        _GET_CLOUD_HAT_OPACITY = 0x20AC25E781AE4A84,
        GET_GAME_TIMER = 0x9CD27B0045628463,
        GET_FRAME_TIME = 0x15C40837039FFAF7,
        _GET_BENCHMARK_TIME = 0xE599A503B3837E1B,
        GET_FRAME_COUNT = 0xFC8202EFC642E6F2,
        GET_RANDOM_FLOAT_IN_RANGE = 0x313CE5879CEB6FCD,
        GET_RANDOM_INT_IN_RANGE = 0xD53343AA4FB7DD28,
        _GET_RANDOM_INT_IN_RANGE_2 = 0xF2D49816A804D134,
        GET_GROUND_Z_AND_NORMAL_FOR_3D_COORD = 0x8BDC7BFC57A81E76,
        _GET_GROUND_Z_FOR_3D_COORD_2 = 0x9E82F0F362881B29,
        ASIN = 0xC843060B5765DCE7,
        ACOS = 0x1D08B970013C34B6,
        TAN = 0x632106CC96E82E91,
        ATAN = 0xA9D1795CD5043663,
        ATAN2 = 0x8927CBF9D22261A4,
        GET_ANGLE_BETWEEN_2D_VECTORS = 0x186FC4BE848E1C92,
        IS_AREA_OCCUPIED = 0xA61B4DF533DCB56E,
        IS_POINT_OBSCURED_BY_A_MISSION_ENTITY = 0xE54E209C35FFA18D,
        CLEAR_ANGLED_AREA_OF_VEHICLES = 0x11DB3500F042A8AA,
        SET_CREDITS_ACTIVE = 0xB938B7E6D3C0620C,
        HAVE_CREDITS_REACHED_END = 0x075F1D57402C93BA,
        NETWORK_SET_SCRIPT_IS_SAFE_FOR_NETWORK_GAME = 0x9243BAC96D64C050,
        ADD_POLICE_RESTART = 0x452736765B31FC4B,
        _SET_RESTART_CUSTOM_POSITION = 0x706B5EDCAA7FA663,
        _CLEAR_RESTART_CUSTOM_POSITION = 0xA2716D40842EAF79,
        PAUSE_DEATH_ARREST_RESTART = 0x2C2B3493FBF51C71,
        IGNORE_NEXT_RESTART = 0x21FFB63D8C615361,
        SET_FADE_IN_AFTER_LOAD = 0xF3D78F59DFE18D79,
        REGISTER_SAVE_HOUSE = 0xC0714D0A7EEECA54,
        SET_SAVE_HOUSE = 0x4F548CABEAE553BC,
        OVERRIDE_SAVE_HOUSE = 0x1162EA8AE9D24EEA,
        DO_AUTO_SAVE = 0x50EEAAD86232EE55,
        IS_AUTO_SAVE_IN_PROGRESS = 0x69240733738C19A0,
        HAS_CODE_REQUESTED_AUTOSAVE = 0x2107A3773771186D,
        CLEAR_CODE_REQUESTED_AUTOSAVE = 0x06462A961E94B67C,
        BEGIN_REPLAY_STATS = 0xE0E500246FF73D66,
        ADD_REPLAY_STAT_VALUE = 0x69FE6DC87BD2A5E9,
        END_REPLAY_STATS = 0xA23E821FBDF8A5F2,
        HAVE_REPLAY_STATS_BEEN_STORED = 0xD642319C54AADEB6,
        GET_REPLAY_STAT_MISSION_ID = 0x5B1F2E327B6B6FE1,
        GET_REPLAY_STAT_MISSION_TYPE = 0x2B626A0150E4D449,
        GET_REPLAY_STAT_COUNT = 0xDC9274A7EF6B2867,
        GET_REPLAY_STAT_AT_INDEX = 0x8098C8D6597AAE18,
        CLEAR_REPLAY_STATS = 0x1B1AB132A16FDA55,
        QUEUE_MISSION_REPEAT_LOAD = 0x72DE52178C291CB5,
        GET_STATUS_OF_MISSION_REPEAT_SAVE = 0x2B5E102E4A42F2BF,
        IS_MEMORY_CARD_IN_USE = 0x8A75CE2956274ADD,
        SHOOT_SINGLE_BULLET_BETWEEN_COORDS = 0x867654CBC7606F2C,
        GET_FAKE_WANTED_LEVEL = 0x4C9296CBCD1B971E,
        USING_MISSION_CREATOR = 0xF14878FC50BEC6EE,
        ALLOW_MISSION_CREATOR_WARP = 0xDEA36202FC3382DF,
        SET_MINIGAME_IN_PROGRESS = 0x19E00D7322C6F85B,
        IS_MINIGAME_IN_PROGRESS = 0x2B4A15E44DE0F478,
        IS_THIS_A_MINIGAME_SCRIPT = 0x7B30F65D7B710098,
        GET_PROFILE_SETTING = 0xC488FF2356EA7791,
        ARE_STRINGS_EQUAL = 0x0C515FAB3FF9EA92,
        ABSI = 0xF0D31AD191A74F87,
        ABSF = 0x73D57CFFDD12C355,
        IS_PROJECTILE_TYPE_WITHIN_DISTANCE = 0x34318593248C8FB2,
        GET_COORDS_OF_PROJECTILE_TYPE_IN_AREA = 0x8D7A43EC6A5FEA45,
        GET_COORDS_OF_PROJECTILE_TYPE_WITHIN_DISTANCE = 0xDFB4138EEFED7B81,
        IS_BULLET_IN_AREA = 0x3F2023999AD51C1F,
        IS_BULLET_IN_BOX = 0xDE0F6D7450D37351,
        HAS_BULLET_IMPACTED_IN_BOX = 0xDC8C5D7CFEAB8394,
        IS_XBOX360_VERSION = 0xF6201B4DAF662A9D,
        IS_PS3_VERSION = 0xCCA1072C29D096C2,
        IS_PC_VERSION = 0x48AF36444B965238,
        IS_STRING_NULL = 0xF22B6C47C6EAB066,
        IS_STRING_NULL_OR_EMPTY = 0xCA042B6957743895,
        SET_BITS_IN_RANGE = 0x8EF07E15701D61ED,
        GET_BITS_IN_RANGE = 0x53158863FCC0893A,
        DELETE_STUNT_JUMP = 0xDC518000E39DAE1F,
        ENABLE_STUNT_JUMP_SET = 0xE369A5783B866016,
        DISABLE_STUNT_JUMP_SET = 0xA5272EBEDD4747F6,
        SET_STUNT_JUMPS_CAN_TRIGGER = 0xD79185689F8FD5DF,
        IS_STUNT_JUMP_IN_PROGRESS = 0x7A3F19700A4D0525,
        IS_STUNT_JUMP_MESSAGE_SHOWING = 0x2272B0A1343129F4,
        GET_NUM_SUCCESSFUL_STUNT_JUMPS = 0x996DD1E1E02F1008,
        GET_TOTAL_SUCCESSFUL_STUNT_JUMPS = 0x6856EC3D35C81EA4,
        CANCEL_STUNT_JUMP = 0xE6B7B0ACD4E4B75E,
        SET_THIS_SCRIPT_CAN_BE_PAUSED = 0xAA391C728106F7AF,
        SET_THIS_SCRIPT_CAN_REMOVE_BLIPS_CREATED_BY_ANY_SCRIPT = 0xB98236CAAECEF897,
        GET_INDEX_OF_CURRENT_LEVEL = 0xCBAD6729F7B1F4FC,
        START_SAVE_DATA = 0xA9575F812C6A7997,
        STOP_SAVE_DATA = 0x74E20C9145FB66FD,
        GET_SIZE_OF_SAVE_DATA = 0xA09F896CE912481F,
        REGISTER_INT_TO_SAVE = 0x34C9EE5986258415,
        _REGISTER_INT64_TO_SAVE = 0xA735353C77334EA0,
        REGISTER_ENUM_TO_SAVE = 0x10C2FA78D0E128A1,
        REGISTER_FLOAT_TO_SAVE = 0x7CAEC29ECB5DFEBB,
        REGISTER_BOOL_TO_SAVE = 0xC8F4131414C835A1,
        REGISTER_TEXT_LABEL_TO_SAVE = 0xEDB1232C5BEAE62F,
        START_SAVE_STRUCT_WITH_SIZE = 0xBF737600CDDBEADD,
        STOP_SAVE_STRUCT = 0xEB1774DF12BB9F12,
        START_SAVE_ARRAY_WITH_SIZE = 0x60FE567DF1B1AF9D,
        STOP_SAVE_ARRAY = 0x04456F95153C6BE4,
        _COPY_MEMORY = 0x213AEB2B90CBA7AC,
        BLOCK_DISPATCH_SERVICE_RESOURCE_CREATION = 0x9B2BD3773123EA2F,
        _GET_NUM_DISPATCHED_UNITS_FOR_PLAYER = 0xEB4A0C2D56441717,
        SET_INCIDENT_REQUESTED_UNITS = 0xB08B85D860E7BA3C,
        ADD_POP_MULTIPLIER_AREA = 0x67F6413D3220E18D,
        DOES_POP_MULTIPLIER_AREA_EXIST = 0x1327E2FE9746BAEE,
        REMOVE_POP_MULTIPLIER_AREA = 0xB129E447A2EDA4BF,
        _IS_POP_MULTIPLIER_AREA_UNK = 0x1312F4B242609CE3,
        DOES_POP_MULTIPLIER_SPHERE_EXIST = 0x171BAFB3C60389F4,
        IS_TENNIS_MODE = 0x5D5479D115290C3F,
        GET_TENNIS_SWING_ANIM_COMPLETE = 0x17DF68D720AA77F8,
        PLAY_TENNIS_DIVE_ANIM = 0x8FA9C42FC5D7C64B,
        _RESET_DISPATCH_SPAWN_LOCATION = 0x5896F2BD5683A4E1,
        SET_DISPATCH_SPAWN_LOCATION = 0xD10F442036302D50,
        RESET_DISPATCH_IDEAL_SPAWN_DISTANCE = 0x77A84429DD9F0A15,
        SET_DISPATCH_IDEAL_SPAWN_DISTANCE = 0x6FE601A64180D423,
        RESET_DISPATCH_TIME_BETWEEN_SPAWN_ATTEMPTS = 0xEB2DB0CAD13154B3,
        SET_DISPATCH_TIME_BETWEEN_SPAWN_ATTEMPTS = 0x44F7CBC1BEB3327D,
        SET_DISPATCH_TIME_BETWEEN_SPAWN_ATTEMPTS_MULTIPLIER = 0x48838ED9937A15D1,
        _ADD_DISPATCH_SPAWN_BLOCKING_AREA = 0x2D4259F1FEB81DA9,
        REMOVE_DISPATCH_SPAWN_BLOCKING_AREA = 0x264AC28B01B353A5,
        RESET_DISPATCH_SPAWN_BLOCKING_AREAS = 0xAC7BFD5C1D83EA75,
        _CLEAR_TACTICAL_ANALYSIS_POINTS = 0xB3CD58CCA6CDA852,
        DISPLAY_ONSCREEN_KEYBOARD_WITH_LONGER_INITIAL_STRING = 0xCA78CFA0366592FE,
        SET_EXPLOSIVE_AMMO_THIS_FRAME = 0xA66C71C98D5F2CFB,
        SET_FIRE_AMMO_THIS_FRAME = 0x11879CDD803D30F4,
        SET_EXPLOSIVE_MELEE_THIS_FRAME = 0xFF1BED81BFDC0FE0,
        SET_SUPER_JUMP_THIS_FRAME = 0x57FFF03E423A4C0B,
        _SET_BEAST_MODE_ACTIVE = 0x438822C279B73B93,
        _SET_FORCE_PLAYER_TO_JUMP = 0xA1183BCFEE0F93D1,
        ARE_PROFILE_SETTINGS_VALID = 0x5AA3BEFA29F03AD4,
        SCRIPT_RACE_INIT = 0x0A60017F841A54F2,
        SCRIPT_RACE_SHUTDOWN = 0x1FF6BF9A63E5757F,
        SCRIPT_RACE_GET_PLAYER_SPLIT_TIME = 0x8EF5573A1F801A5C,
        _CLEANUP_ASYNC_INSTALL = 0xC79AE21974B01FB2,
        _0x1178E104409FE58C = 0x1178E104409FE58C,
        _0x7F8F6405F4777AF6 = 0x7F8F6405F4777AF6,
        _0xF56DFB7B61BE7276 = 0xF56DFB7B61BE7276,
        _0xA0AD167E4B39D9A2 = 0xA0AD167E4B39D9A2,
        _0x39455BF4F4F55186 = 0x39455BF4F4F55186,
        _0x397BAA01068BAA96 = 0x397BAA01068BAA96,
        _0xB51B9AB9EF81868C = 0xB51B9AB9EF81868C,
        _0xEB2104E905C6F2E9 = 0xEB2104E905C6F2E9,
        _0xFA3FFB0EEBC288A3 = 0xFA3FFB0EEBC288A3,
        _0xFB00CA71DA386228 = 0xFB00CA71DA386228,
        _0xD10282B6E3751BA0 = 0xD10282B6E3751BA0,
        _0x693478ACBD7F18E7 = 0x693478ACBD7F18E7,
    }
}