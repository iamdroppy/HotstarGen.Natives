using System;
namespace Hotstar
{
    public enum DATAFILE : ulong
    { 
        /// <summary>
        /// Adds the given request ID to the watch list.
        ///
        /// > int id
        ///
        /// </summary>
        DATAFILE_WATCH_REQUEST_ID = 0xAD6875BBC0FC899C,
        /// <summary>
        /// if ((NETWORK::_597F8DBA9B206FC7() > 0) && DATAFILE::_01095C95CD46B624(0)) {
        ///     v_10 = DATAFILE::_GET_ROOT_OBJECT();
        ///     v_11 = DATAFILE::_OBJECT_VALUE_GET_INTEGER(v_10, "pt");
        ///     sub_20202(2, v_11);
        ///     a_0 += 1;
        /// } else { 
        ///     a_0 += 1;
        /// }
        /// 
        ///
        /// > int p0
        /// > Any p1
        ///
        /// </summary>
        DATAFILE_SELECT_CREATOR_STATS = 0x01095C95CD46B624,
        /// <summary>
        /// Loads a User-Generated Content (UGC) file. These files can be found in "[GTA5]\data\ugc" and "[GTA5]\common\patch\ugc". They seem to follow a naming convention, most likely of "[name]_[part].ugc". See example below for usage.
        /// 
        /// Returns whether or not the file was successfully loaded.
        /// 
        /// Example:
        /// DATAFILE::_LOAD_UGC_FILE("RockstarPlaylists") // loads "rockstarplaylists_00.ugc"
        ///
        /// > const char* filename
        /// > Any p1
        ///
        /// </summary>
        DATAFILE_LOAD_OFFLINE_UGC = 0xC5238C011AF405E4,
        /// <summary>
        /// Example:
        /// if (!DATAFILE::_BEDB96A7584AA8CF())
        /// {
        ///     if (!g_109E3)
        ///  {
        ///         if (((sub_d4f() == 2) == 0) && (!NETWORK::NETWORK_IS_GAME_IN_PROGRESS()))
        ///       {
        ///             if (NETWORK::NETWORK_IS_CLOUD_AVAILABLE())
        ///          {
        ///                 g_17A8B = 0;
        ///             }
        ///             if (!g_D52C)
        ///           {
        ///                 sub_730();
        ///             }
        ///         }
        ///     }
        /// }
        /// 
        /// 
        ///
        ///
        /// </summary>
        DATAFILE_IS_SAVE_PENDING = 0xBEDB96A7584AA8CF,
        /// <summary>
        /// Types:
        /// 1 = Boolean
        /// 2 = Integer
        /// 3 = Float
        /// 4 = String
        /// 5 = Vector3
        /// 6 = Object
        /// 7 = Array
        ///
        /// > Any* objectData
        /// > const char* key
        ///
        /// </summary>
        DATADICT_GET_TYPE = 0x031C55ED33227371,
        /// <summary>
        /// Types:
        /// 1 = Boolean
        /// 2 = Integer
        /// 3 = Float
        /// 4 = String
        /// 5 = Vector3
        /// 6 = Object
        /// 7 = Array
        ///
        /// > Any* arrayData
        /// > int arrayIndex
        ///
        /// </summary>
        DATAARRAY_GET_TYPE = 0x3A0014ADB172A3C5,
        DATAFILE_CLEAR_WATCH_LIST = 0x6CC86E78358D5119,
        DATAFILE_IS_VALID_REQUEST_ID = 0xFCCAE5B92A830878,
        DATAFILE_HAS_LOADED_FILE_DATA = 0x15FF52B809DB2353,
        DATAFILE_HAS_VALID_FILE_DATA = 0xF8CC1EBE0B62E29F,
        DATAFILE_SELECT_ACTIVE_FILE = 0x22DA66936E0FFF37,
        DATAFILE_DELETE_REQUESTED_FILE = 0x8F5EA1C01D65A100,
        UGC_CREATE_CONTENT = 0xC84527E235FCA219,
        UGC_CREATE_MISSION = 0xA5EFC3E847D60507,
        UGC_UPDATE_CONTENT = 0x648E7A5434AF7969,
        UGC_UPDATE_MISSION = 0x4645DE9980999E93,
        UGC_SET_PLAYER_DATA = 0x692D808C34A82143,
        DATAFILE_SELECT_UGC_DATA = 0xA69AC4ADE82B57A4,
        DATAFILE_SELECT_UGC_STATS = 0x9CB0BFA7A9342C3D,
        DATAFILE_SELECT_UGC_PLAYER_DATA = 0x52818819057F2B40,
        DATAFILE_CREATE = 0xD27058A1CA2B13EE,
        DATAFILE_DELETE = 0x9AB9C1CFC8862DFB,
        DATAFILE_STORE_MISSION_HEADER = 0x2ED61456317B8178,
        DATAFILE_FLUSH_MISSION_HEADER = 0xC55854C7D7274882,
        DATAFILE_GET_FILE_DICT = 0x906B778CA1DC72B6,
        DATAFILE_START_SAVE_TO_CLOUD = 0x83BCCE3224735F05,
        DATAFILE_UPDATE_SAVE_TO_CLOUD = 0x4DFDD9EB705F8140,
        DATADICT_SET_BOOL = 0x35124302A556A325,
        DATADICT_SET_INT = 0xE7E035450A7948D5,
        DATADICT_SET_FLOAT = 0xC27E1CC2D795105E,
        DATADICT_SET_STRING = 0x8FF3847DADD8E30C,
        DATADICT_SET_VECTOR = 0x4CD49B76338C7DEE,
        DATADICT_CREATE_DICT = 0xA358F56F10732EE1,
        DATADICT_CREATE_ARRAY = 0x5B11728527CA6E5F,
        DATADICT_GET_BOOL = 0x1186940ED72FFEEC,
        DATADICT_GET_INT = 0x78F06F6B1FB5A80C,
        DATADICT_GET_FLOAT = 0x06610343E73B9727,
        DATADICT_GET_STRING = 0x3D2FD9E763B24472,
        DATADICT_GET_VECTOR = 0x46CD3CB66E0825CC,
        DATADICT_GET_DICT = 0xB6B9DDC412FCEEE2,
        DATADICT_GET_ARRAY = 0x7A983AA9DA2659ED,
        DATAARRAY_ADD_BOOL = 0xF8B0F5A43E928C76,
        DATAARRAY_ADD_INT = 0xCABDB751D86FE93B,
        DATAARRAY_ADD_FLOAT = 0x57A995FD75D37F56,
        DATAARRAY_ADD_STRING = 0x2F0661C155AEEEAA,
        DATAARRAY_ADD_VECTOR = 0x407F8D034F70F0C2,
        DATAARRAY_ADD_DICT = 0x6889498B3E19C797,
        DATAARRAY_GET_BOOL = 0x50C1B2874E50C114,
        DATAARRAY_GET_INT = 0x3E5AE19425CD74BE,
        DATAARRAY_GET_FLOAT = 0xC0C527B525D7CFB5,
        DATAARRAY_GET_STRING = 0xD3F2FFEB8D836F52,
        DATAARRAY_GET_VECTOR = 0x8D2064E5B64A628A,
        DATAARRAY_GET_DICT = 0x8B5FADCC4E3A145F,
        DATAARRAY_GET_COUNT = 0x065DB281590CEA2D,
        _0xA6EEF01087181EDD = 0xA6EEF01087181EDD,
        _0x6AD0BD5E087866CB = 0x6AD0BD5E087866CB,
        _0xDBF860CF1DB8E599 = 0xDBF860CF1DB8E599,
    }
}