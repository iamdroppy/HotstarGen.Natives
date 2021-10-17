using System;
namespace Hotstar
{
    public enum INTERIOR : ulong
    { 
        /// <summary>
        /// GET_INTERIOR_*
        ///
        /// > Interior interior
        ///
        /// </summary>
        _GET_INTERIOR_HEADING = 0xF49B58631D9E22D9,
        /// <summary>
        /// GET_INTERIOR_*
        ///
        /// > Interior interior
        /// > Vector3* position
        /// > Hash* nameHash
        ///
        /// </summary>
        _GET_INTERIOR_INFO = 0x252BDC06B73FA6EA,
        /// <summary>
        /// Returns the group ID of the specified interior. For example, regular interiors have group 0, subway interiors have group 1. There are a few other groups too.
        ///
        /// > Interior interior
        ///
        /// </summary>
        GET_INTERIOR_GROUP_ID = 0xE4A84ABF135EF91A,
        /// <summary>
        /// Does anyone know what this does? I know online modding isn't generally supported especially by the owner of this db, but I first thought this could be used to force ourselves into someones apartment, but I see now that isn't possible.
        ///
        /// > Entity entity
        /// > Interior interior
        /// > Hash roomHashKey
        ///
        /// </summary>
        FORCE_ROOM_FOR_ENTITY = 0x52923C4710DD9907,
        /// <summary>
        /// Gets the room hash key from the room that the specified entity is in. Each room in every interior has a unique key. Returns 0 if the entity is outside.
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_ROOM_KEY_FROM_ENTITY = 0x47C2A06D4F5F424B,
        /// <summary>
        /// Seems to do the exact same as INTERIOR::GET_ROOM_KEY_FROM_ENTITY
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_KEY_FOR_ENTITY_IN_ROOM = 0x399685DB942336BC,
        /// <summary>
        /// Returns the handle of the interior that the entity is in. Returns 0 if outside.
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_INTERIOR_FROM_ENTITY = 0x2107BA504071A6BB,
        /// <summary>
        /// Immediately removes entity from an interior. Like sets entity to `limbo` room.
        ///
        /// > Entity entity
        ///
        /// </summary>
        _CLEAR_INTERIOR_FOR_ENTITY = 0x85D5422B2039A70D,
        /// <summary>
        /// Returns the current interior id from gameplay camera
        ///
        ///
        /// </summary>
        _GET_INTERIOR_FROM_GAMEPLAY_CAM = 0xE7D267EC6CA966C3,
        /// <summary>
        /// Returns interior ID from specified coordinates. If coordinates are outside, then it returns 0.
        /// 
        /// Example for VB.NET
        /// Dim interiorID As Integer = Native.Function.Call(Of Integer)(Hash.GET_INTERIOR_AT_COORDS, X, Y, Z)
        ///
        /// > float x
        /// > float y
        /// > float z
        ///
        /// </summary>
        GET_INTERIOR_AT_COORDS = 0xB0F7F8663821D9C3,
        /// <summary>
        /// Does something similar to INTERIOR::DISABLE_INTERIOR.
        /// 
        /// You don't fall through the floor but everything is invisible inside and looks the same as when INTERIOR::DISABLE_INTERIOR is used. Peds behaves normally inside. 
        ///
        /// > Interior interior
        ///
        /// </summary>
        UNPIN_INTERIOR = 0x261CCE7EED010641,
        /// <summary>
        /// Returns the interior ID representing the requested interior at that location (if found?). The supplied interior string is not the same as the one used to load the interior.
        /// 
        /// Use: INTERIOR::UNPIN_INTERIOR(INTERIOR::GET_INTERIOR_AT_COORDS_WITH_TYPE(x, y, z, interior))
        /// 
        /// Interior types include: "V_Michael", "V_Franklins", "V_Franklinshouse", etc.. you can find them in the scripts.
        /// 
        /// Not a very useful native as you could just use GET_INTERIOR_AT_COORDS instead and get the same result, without even having to specify the interior type.
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > const char* interiorType
        ///
        /// </summary>
        GET_INTERIOR_AT_COORDS_WITH_TYPE = 0x05B7A89BD78797FC,
        /// <summary>
        /// Hashed version of GET_INTERIOR_AT_COORDS_WITH_TYPE
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > Hash typeHash
        ///
        /// </summary>
        GET_INTERIOR_AT_COORDS_WITH_TYPEHASH = 0xF0F77ADB9F67E79D,
        /// <summary>
        /// Returns true if the collision at the specified coords is marked as being outside (false if there's an interior)
        ///
        /// > float x
        /// > float y
        /// > float z
        ///
        /// </summary>
        IS_COLLISION_MARKED_OUTSIDE = 0xEEA5AC2EDA7C33E8,
        /// <summary>
        /// More info: http://gtaforums.com/topic/836367-adding-props-to-interiors/
        /// 
        /// Full list of IPLs and interior entity sets by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/ipls.json
        ///
        /// > Interior interior
        /// > const char* entitySetName
        ///
        /// </summary>
        ACTIVATE_INTERIOR_ENTITY_SET = 0x55E86AF2712B36A1,
        /// <summary>
        /// Full list of IPLs and interior entity sets by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/ipls.json
        ///
        /// > Interior interior
        /// > const char* entitySetName
        ///
        /// </summary>
        DEACTIVATE_INTERIOR_ENTITY_SET = 0x420BD37289EEE162,
        /// <summary>
        /// Full list of IPLs and interior entity sets by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/ipls.json
        ///
        /// > Interior interior
        /// > const char* entitySetName
        ///
        /// </summary>
        IS_INTERIOR_ENTITY_SET_ACTIVE = 0x35F7DD45E8C0A16D,
        /// <summary>
        /// Full list of IPLs and interior entity sets by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/ipls.json
        ///
        /// > Interior interior
        /// > const char* entitySetName
        /// > int color
        ///
        /// </summary>
        _SET_INTERIOR_ENTITY_SET_COLOR = 0xC1F1920BAF281317,
        /// <summary>
        /// This is the native that is used to hide the exterior of GTA Online apartment buildings when you are inside an apartment.
        /// 
        /// More info: http://gtaforums.com/topic/836301-hiding-gta-online-apartment-exteriors/
        ///
        /// > Hash mapObjectHash
        ///
        /// </summary>
        ENABLE_EXTERIOR_CULL_MODEL_THIS_FRAME = 0xA97F257D0151A6AB,
        /// <summary>
        /// Example: 
        /// This removes the interior from the strip club and when trying to walk inside the player just falls:
        /// 
        /// INTERIOR::DISABLE_INTERIOR(118018, true);
        ///
        /// > Interior interior
        /// > BOOL toggle
        ///
        /// </summary>
        DISABLE_INTERIOR = 0x6170941419D7D8EC,
        /// <summary>
        /// Does something similar to INTERIOR::DISABLE_INTERIOR
        ///
        /// > Interior interior
        /// > BOOL toggle
        ///
        /// </summary>
        CAP_INTERIOR = 0xD9175F941610DB54,
        /// <summary>
        /// Exemple of use(carmod_shop.c4)
        ///  INTERIOR::_AF348AFCB575A441("V_CarModRoom");
        ///
        /// > const char* roomName
        ///
        /// </summary>
        _0xAF348AFCB575A441 = 0xAF348AFCB575A441,
        /// <summary>
        /// Usage: INTERIOR::_0x405DC2AEF6AF95B9(INTERIOR::GET_KEY_FOR_ENTITY_IN_ROOM(PLAYER::PLAYER_PED_ID()));
        ///
        /// > Hash roomHashKey
        ///
        /// </summary>
        _0x405DC2AEF6AF95B9 = 0x405DC2AEF6AF95B9,
        /// <summary>
        /// Only used once in the entire game scripts.
        /// Does not actually return anything.
        ///
        /// > Interior interior
        ///
        /// </summary>
        _0x4C2330E61D3DEB56 = 0x4C2330E61D3DEB56,
        /// <summary>
        /// DISABLE_[METRO_SYSTEM]?
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _0x9E6542F0CE8E70A3 = 0x9E6542F0CE8E70A3,
        /// <summary>
        /// Jenkins hash _might_ be 0xFC227584.
        ///
        /// > Entity entity
        /// > BOOL toggle
        ///
        /// </summary>
        _0x7241CCB7D020DB69 = 0x7241CCB7D020DB69,
        GET_OFFSET_FROM_INTERIOR_IN_WORLD_COORDS = 0x9E3B3E6D66F6E22F,
        IS_INTERIOR_SCENE = 0xBC72B5D7A1CBD54D,
        IS_VALID_INTERIOR = 0x26B0E73D7EAAF4D3,
        CLEAR_ROOM_FOR_ENTITY = 0xB365FC0C4E27FFA7,
        FORCE_ROOM_FOR_GAME_VIEWPORT = 0x920D853F3E17F1DA,
        GET_ROOM_KEY_FOR_GAME_VIEWPORT = 0xA6575914D2A0B450,
        CLEAR_ROOM_FOR_GAME_VIEWPORT = 0x23B59D8912F94246,
        ADD_PICKUP_TO_INTERIOR_ROOM_BY_NAME = 0x3F6167F351168730,
        PIN_INTERIOR_IN_MEMORY = 0x2CA429C029CCF247,
        IS_INTERIOR_READY = 0x6726BDCCC1932F0E,
        GET_INTERIOR_FROM_COLLISION = 0xEC4CF9FCB29A4424,
        REFRESH_INTERIOR = 0x41F37C3427C75AE0,
        _ENABLE_SCRIPT_CULL_MODEL_THIS_FRAME = 0x50C375537449F369,
        IS_INTERIOR_DISABLED = 0xBC5115A5A939DD15,
        IS_INTERIOR_CAPPED = 0x92BAC8ACF88CEC26,
        _0x82EBB79E258FA2B7 = 0x82EBB79E258FA2B7,
        _0x38C1CB1CB119A016 = 0x38C1CB1CB119A016,
        _0x483ACA1176CA93F1 = 0x483ACA1176CA93F1,
        _0x7ECDF98587E92DEC = 0x7ECDF98587E92DEC,
    }
}