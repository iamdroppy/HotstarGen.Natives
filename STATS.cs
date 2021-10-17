using System;
namespace Hotstar
{
    public enum STATS : ulong
    { 
        /// <summary>
        /// Example:
        /// 
        /// for (v_2 = 0; v_2 <= 4; v_2 += 1) {
        ///     STATS::STAT_CLEAR_SLOT_FOR_RELOAD(v_2);
        /// }
        ///
        /// > int statSlot
        ///
        /// </summary>
        STAT_CLEAR_SLOT_FOR_RELOAD = 0xEB0A72181D4AA4AD,
        /// <summary>
        /// Example:
        ///  STATS::STAT_SET_INT(MISC::GET_HASH_KEY("MPPLY_KILLS_PLAYERS"), 1337, true);
        ///
        /// > Hash statName
        /// > int value
        /// > BOOL save
        ///
        /// </summary>
        STAT_SET_INT = 0xB3271D7AB655B441,
        /// <summary>
        /// Example:
        ///  STATS::STAT_SET_FLOAT(MISC::GET_HASH_KEY("MP0_WEAPON_ACCURACY"), 66.6f, true);
        ///
        /// > Hash statName
        /// > float value
        /// > BOOL save
        ///
        /// </summary>
        STAT_SET_FLOAT = 0x4851997F37FE9B3C,
        /// <summary>
        /// Example:
        ///  STATS::STAT_SET_BOOL(MISC::GET_HASH_KEY("MPPLY_MELEECHLENGECOMPLETED"), trur, true);
        ///
        /// > Hash statName
        /// > BOOL value
        /// > BOOL save
        ///
        /// </summary>
        STAT_SET_BOOL = 0x4B33C4243DE0C432,
        /// <summary>
        /// The following values have been found in the decompiled scripts:
        /// "RC_ABI1"
        /// "RC_ABI2"
        /// "RC_BA1"
        /// "RC_BA2"
        /// "RC_BA3"
        /// "RC_BA3A"
        /// "RC_BA3C"
        /// "RC_BA4"
        /// "RC_DRE1"
        /// "RC_EPS1"
        /// "RC_EPS2"
        /// "RC_EPS3"
        /// "RC_EPS4"
        /// "RC_EPS5"
        /// "RC_EPS6"
        /// "RC_EPS7"
        /// "RC_EPS8"
        /// "RC_EXT1"
        /// "RC_EXT2"
        /// "RC_EXT3"
        /// "RC_EXT4"
        /// "RC_FAN1"
        /// "RC_FAN2"
        /// "RC_FAN3"
        /// "RC_HAO1"
        /// "RC_HUN1"
        /// "RC_HUN2"
        /// "RC_JOS1"
        /// "RC_JOS2"
        /// "RC_JOS3"
        /// "RC_JOS4"
        /// "RC_MAU1"
        /// "RC_MIN1"
        /// "RC_MIN2"
        /// "RC_MIN3"
        /// "RC_MRS1"
        /// "RC_MRS2"
        /// "RC_NI1"
        /// "RC_NI1A"
        /// "RC_NI1B"
        /// "RC_NI1C"
        /// "RC_NI1D"
        /// "RC_NI2"
        /// "RC_NI3"
        /// "RC_OME1"
        /// "RC_OME2"
        /// "RC_PA1"
        /// "RC_PA2"
        /// "RC_PA3"
        /// "RC_PA3A"
        /// "RC_PA3B"
        /// "RC_PA4"
        /// "RC_RAM1"
        /// "RC_RAM2"
        /// "RC_RAM3"
        /// "RC_RAM4"
        /// "RC_RAM5"
        /// "RC_SAS1"
        /// "RC_TON1"
        /// "RC_TON2"
        /// "RC_TON3"
        /// "RC_TON4"
        /// "RC_TON5"
        ///
        /// > Hash statName
        /// > const char* value
        /// > BOOL save
        ///
        /// </summary>
        STAT_SET_GXT_LABEL = 0x17695002FD8B2AE0,
        /// <summary>
        /// 'value' is a structure to a structure, 'numFields' is how many fields there are in said structure (usually 7).
        /// 
        /// The structure looks like this:
        /// 
        /// int year
        /// int month
        /// int day
        /// int hour
        /// int minute
        /// int second
        /// int millisecond
        /// 
        /// The decompiled scripts use TIME::GET_POSIX_TIME to fill this structure.
        ///
        /// > Hash statName
        /// > Any* value
        /// > int numFields
        /// > BOOL save
        ///
        /// </summary>
        STAT_SET_DATE = 0x2C29BFB64F4FCBE4,
        /// <summary>
        /// p1 always true.
        ///
        /// > Hash statName
        /// > BOOL p1
        ///
        /// </summary>
        STAT_SET_CURRENT_POSIX_TIME = 0xC2F84B7F9C4D0C61,
        /// <summary>
        /// p2 appears to always be -1
        /// 
        ///
        /// > Hash statHash
        /// > int* outValue
        /// > int p2
        ///
        /// </summary>
        STAT_GET_INT = 0x767FBC2AC802EF3D,
        /// <summary>
        /// p1 is always -1 in the script files
        ///
        /// > Hash statHash
        /// > int p1
        ///
        /// </summary>
        STAT_GET_STRING = 0xE50384ACC2C3DB74,
        /// <summary>
        /// Needs more research. Seems to return "STAT_UNKNOWN" if no such user id exists.
        ///
        /// > Any p0
        ///
        /// </summary>
        STAT_GET_USER_ID = 0x2365C388E393BBE2,
        /// <summary>
        /// Does not take effect immediately, unfortunately.
        /// 
        /// profileSetting seems to only be 936, 937 and 938 in scripts
        ///
        /// > int profileSetting
        /// > int value
        ///
        /// </summary>
        STAT_SET_PROFILE_SETTING_VALUE = 0x68F01422BE1D838F,
        /// <summary>
        /// Needs more research. Possibly used to calculate the "mask" when calling "STAT_SET_BOOL_MASKED"?
        ///
        /// > int p0
        ///
        /// </summary>
        _STAT_GET_PACKED_BOOL_MASK = 0xF4D8E7AC2A27758C,
        /// <summary>
        /// Needs more research. Possibly used to calculate the "mask" when calling "STAT_SET_MASKED_INT"?
        ///
        /// > int p0
        ///
        /// </summary>
        _STAT_GET_PACKED_INT_MASK = 0x94F12ABF9C79E339,
        /// <summary>
        /// Needs more research. Gets the stat name of a masked bool?
        /// 
        /// section - values used in the decompiled scripts:
        /// "_NGPSTAT_BOOL"
        /// "_NGTATPSTAT_BOOL"
        /// "_NGDLCPSTAT_BOOL"
        /// "_DLCBIKEPSTAT_BOOL"
        /// "_DLCGUNPSTAT_BOOL"
        /// "_GUNTATPSTAT_BOOL"
        /// "_DLCSMUGCHARPSTAT_BOOL"
        /// "_GANGOPSPSTAT_BOOL"
        /// "_BUSINESSBATPSTAT_BOOL"
        /// "_ARENAWARSPSTAT_BOOL"
        /// "_CASINOPSTAT_BOOL"
        /// "_CASINOHSTPSTAT_BOOL"
        /// "_HEIST3TATTOOSTAT_BOOL"
        ///
        /// > int index
        /// > BOOL spStat
        /// > BOOL charStat
        /// > int character
        /// > const char* section
        ///
        /// </summary>
        _GET_NGSTAT_BOOL_HASH = 0xBA52FF538ED2BC71,
        /// <summary>
        /// Needs more research. Gets the stat name of a masked int?
        /// 
        /// section - values used in the decompiled scripts:
        /// "_NGPSTAT_INT"
        /// "_MP_NGPSTAT_INT"
        /// "_MP_LRPSTAT_INT"
        /// "_MP_APAPSTAT_INT"
        /// "_MP_LR2PSTAT_INT"
        /// "_MP_BIKEPSTAT_INT"
        /// "_MP_IMPEXPPSTAT_INT"
        /// "_MP_GUNRPSTAT_INT"
        /// "_NGDLCPSTAT_INT"
        /// "_MP_NGDLCPSTAT_INT"
        /// "_DLCSMUGCHARPSTAT_INT"
        /// "_GANGOPSPSTAT_INT"
        /// "_BUSINESSBATPSTAT_INT"
        /// "_ARENAWARSPSTAT_INT"
        /// "_CASINOPSTAT_INT"
        /// "_CASINOHSTPSTAT_INT"
        ///
        /// > int index
        /// > BOOL spStat
        /// > BOOL charStat
        /// > int character
        /// > const char* section
        ///
        /// </summary>
        _GET_NGSTAT_INT_HASH = 0x2B4CDCA6F07FF3DA,
        /// <summary>
        /// p2 - Default value? Seems to be -1 most of the time.
        ///
        /// > Hash statName
        /// > int mask
        /// > int p2
        ///
        /// </summary>
        STAT_GET_BOOL_MASKED = 0x10FE3F1B79F9B071,
        /// <summary>
        /// PLAYSTATS_START_INVITE_DESPAWNING?
        ///
        ///
        /// </summary>
        _PLAYSTATS_START_OFFLINE_MODE = 0x098760C7461724CD,
        /// <summary>
        /// This native does absolutely nothing, just a nullsub
        ///
        /// > Any p0
        /// > Any p1
        /// > Any p2
        ///
        /// </summary>
        PLAYSTATS_ODDJOB_DONE = 0x69DEA3E9DB727B4C,
        /// <summary>
        /// This is a typo made by R*. It's supposed to be called PLAYSTATS_WEAPON_MOD_CHANGE.
        ///
        /// > Hash weaponHash
        /// > Hash componentHashTo
        /// > Hash componentHashFrom
        ///
        /// </summary>
        PLAYSTATS_WEAPON_MODE_CHANGE = 0xE95C8A1875A02CA4,
        /// <summary>
        /// longest time being ilde?
        ///
        /// > int time
        ///
        /// </summary>
        PLAYSTATS_IDLE_KICK = 0x5DA3A8DE8CB6226F,
        /// <summary>
        /// platformName must be one of the following: ps3, xbox360, ps4, xboxone
        ///
        /// > const char* platformName
        ///
        /// </summary>
        _STAT_MIGRATE_SAVE = 0xA5C80D8E768A9E66,
        /// <summary>
        /// Sets profile setting 866
        /// 
        /// SET_*
        ///
        /// > int value
        ///
        /// </summary>
        _SET_HAS_CONTENT_UNLOCKS_FLAGS = 0xDAC073C7901F9E15,
        /// <summary>
        /// Sets profile setting 501
        ///
        /// > int transactionId
        ///
        /// </summary>
        _SET_SAVE_MIGRATION_TRANSACTION_ID = 0xF6792800AC95350D,
        /// <summary>
        /// Allows CEventNetworkStuntPerformed to be triggered.
        ///
        ///
        /// </summary>
        _PLAYSTATS_STUNT_PERFORMED_EVENT_ALLOW_TRIGGER = 0x928DBFB892638EF3,
        /// <summary>
        /// Disallows CEventNetworkStuntPerformed to be triggered.
        ///
        ///
        /// </summary>
        _PLAYSTATS_STUNT_PERFORMED_EVENT_DISALLOW_TRIGGER = 0x8A800DACCC0DA55D,
        /// <summary>
        /// STAT_SET_*
        ///
        /// > int p0
        ///
        /// </summary>
        _0x5688585E6D563CD8 = 0x5688585E6D563CD8,
        /// <summary>
        /// STAT_LOAD_*
        ///
        ///
        /// </summary>
        _0xECB41AC6AB754401 = 0xECB41AC6AB754401,
        /// <summary>
        /// STATS::0x343B27E2(0);
        /// STATS::0x343B27E2(1);
        /// STATS::0x343B27E2(2);
        /// STATS::0x343B27E2(3);
        /// STATS::0x343B27E2(4);
        /// STATS::0x343B27E2(5);
        /// STATS::0x343B27E2(6);
        /// STATS::0x343B27E2(7);
        /// 
        /// Identical in ingamehud & maintransition.
        ///
        /// > int p0
        ///
        /// </summary>
        _0x26D7399B9587FE89 = 0x26D7399B9587FE89,
        /// <summary>
        /// STATS::0xE3247582(0);
        /// STATS::0xE3247582(1);
        /// STATS::0xE3247582(2);
        /// STATS::0xE3247582(3);
        /// STATS::0xE3247582(4);
        /// STATS::0xE3247582(5);
        /// STATS::0xE3247582(6);
        ///
        /// > int p0
        ///
        /// </summary>
        _0xA78B8FA58200DA56 = 0xA78B8FA58200DA56,
        /// <summary>
        /// This native does absolutely nothing, just a nullsub
        ///
        ///
        /// </summary>
        _0xC01D2470F22CDE5A = 0xC01D2470F22CDE5A,
        /// <summary>
        /// PLAYSTATS_*
        ///
        /// > int* playerAccountId
        /// > int* posixTime
        ///
        /// </summary>
        _0x6DEE77AFF8C21BD1 = 0x6DEE77AFF8C21BD1,
        /// <summary>
        /// PLAYSTATS_S*
        ///
        /// > int p0
        ///
        /// </summary>
        _0xD1032E482629049E = 0xD1032E482629049E,
        /// <summary>
        /// example from completionpercentage_controller.ysc.c4
        /// 
        /// if (STATS::_5EAD2BF6484852E4()) {
        ///             MISC::SET_BIT(g_17b95._f20df._ff10, 15);
        ///             STATS::_11FF1C80276097ED(0xe9ec4dd1, 200, 0);
        ///         }
        ///
        ///
        /// </summary>
        _0x5EAD2BF6484852E4 = 0x5EAD2BF6484852E4,
        /// <summary>
        /// Sets profile setting 939
        ///
        ///
        /// </summary>
        _0xC67E2DA1CBE759E2 = 0xC67E2DA1CBE759E2,
        /// <summary>
        /// Sets profile setting 933
        ///
        /// > int value
        ///
        /// </summary>
        _0xF1A1803D3476F215 = 0xF1A1803D3476F215,
        /// <summary>
        /// Sets profile setting 934
        ///
        /// > int value
        ///
        /// </summary>
        _0x38BAAA5DD4C9D19F = 0x38BAAA5DD4C9D19F,
        /// <summary>
        /// Sets profile setting 935
        ///
        /// > int value
        ///
        /// </summary>
        _0x55384438FC55AD8E = 0x55384438FC55AD8E,
        /// <summary>
        /// This function is hard-coded to always return 1.
        /// 
        /// NETWORK_IS_*
        ///
        ///
        /// </summary>
        _0xB3DA2606774A8E2D = 0xB3DA2606774A8E2D,
        STAT_LOAD = 0xA651443F437B1CE6,
        STAT_SAVE = 0xE07BCA305B82D2FD,
        STAT_LOAD_PENDING = 0xA1750FFAFA181661,
        STAT_SAVE_PENDING = 0x7D3A583856F2C5AC,
        STAT_SAVE_PENDING_OR_REQUESTED = 0xBBB6AD006F1BBEA3,
        STAT_DELETE_SLOT = 0x49A49BED12794D70,
        STAT_SLOT_IS_LOADED = 0x0D0A9F0E7BD91E3C,
        STAT_SET_BLOCK_SAVES = 0xF434A10BA01C37D0,
        STAT_SET_STRING = 0xA87B2335D12531D7,
        STAT_SET_POS = 0xDB283FDE680FE72E,
        STAT_SET_MASKED_INT = 0x7BBB1B54583ED410,
        STAT_SET_USER_ID = 0x8CDDF1E452BABE11,
        STAT_GET_FLOAT = 0xD7AE6C9C9C6AC54C,
        STAT_GET_BOOL = 0x11B5E6D2AE73F48E,
        STAT_GET_DATE = 0x8B0FACEFC36C824B,
        STAT_GET_POS = 0x350F82CCB186AA1B,
        STAT_GET_MASKED_INT = 0x655185A06D9EEAAB,
        STAT_GET_LICENSE_PLATE = 0x5473D4195058B2E4,
        STAT_SET_LICENSE_PLATE = 0x69FF13266D7296DA,
        STAT_INCREMENT = 0x9B5A68C6489E9909,
        STAT_GET_NUMBER_OF_DAYS = 0xE0E854F5280FB769,
        STAT_GET_NUMBER_OF_HOURS = 0xF2D4B2FE415AAFC3,
        STAT_GET_NUMBER_OF_MINUTES = 0x7583B4BE4C5A41B5,
        STAT_GET_NUMBER_OF_SECONDS = 0x2CE056FF3723F00B,
        GET_PACKED_BOOL_STAT_KEY = 0x80C75307B1C42837,
        GET_PACKED_INT_STAT_KEY = 0x61E111E323419E07,
        GET_PACKED_TU_BOOL_STAT_KEY = 0xC4BB08EE7907471E,
        GET_PACKED_TU_INT_STAT_KEY = 0xD16C2AD6B8E32854,
        STAT_SET_BOOL_MASKED = 0x5BC62EC1937B9E5B,
        PLAYSTATS_BACKGROUND_SCRIPT_ACTION = 0x5009DFD741329729,
        PLAYSTATS_NPC_INVITE = 0x93054C88E6AA7C44,
        PLAYSTATS_AWARD_XP = 0x46F917F6B4128FE4,
        PLAYSTATS_RANK_UP = 0xC7F2DE41D102BFB4,
        PLAYSTATS_ACTIVITY_DONE = 0xA071E0ED98F91286,
        PLAYSTATS_LEAVE_JOB_CHAIN = 0xC5BE134EC7BA96A0,
        PLAYSTATS_MISSION_STARTED = 0xC19A2925C34D2231,
        PLAYSTATS_MISSION_OVER = 0x7C4BB33A8CED7324,
        PLAYSTATS_MISSION_CHECKPOINT = 0xC900596A63978C1D,
        PLAYSTATS_RANDOM_MISSION_DONE = 0x71862B1D855F32E1,
        PLAYSTATS_ROS_BET = 0x121FB4DDDC2D5291,
        PLAYSTATS_RACE_CHECKPOINT = 0x9C375C315099DDE4,
        PLAYSTATS_MATCH_STARTED = 0xBC80E22DED931E3D,
        PLAYSTATS_SHOP_ITEM = 0x176852ACAAC173D1,
        PLAYSTATS_CRATE_DROP_MISSION_DONE = 0x1CAE5D2E3F9A07F0,
        _PLAYSTATS_CRATE_CREATED_MISSION_DONE = 0xAFC7E5E075A96F46,
        PLAYSTATS_HOLD_UP_MISSION_DONE = 0xCB00196B31C39EB1,
        PLAYSTATS_IMPORT_EXPORT_MISSION_DONE = 0x2B69F5074C894811,
        PLAYSTATS_RACE_TO_POINT_MISSION_DONE = 0xADDD1C754E2E2914,
        PLAYSTATS_ACQUIRED_HIDDEN_PACKAGE = 0x79AB33F0FBFAC40C,
        PLAYSTATS_WEBSITE_VISITED = 0xDDF24D535060F811,
        PLAYSTATS_FRIEND_ACTIVITY = 0x0F71DE29AB2258F1,
        PLAYSTATS_PROP_CHANGE = 0xBA739D6D5A05D6E7,
        PLAYSTATS_CLOTH_CHANGE = 0x34B973047A2268B9,
        PLAYSTATS_CHEAT_APPLIED = 0x6058665D72302D3F,
        PLAYSTATS_QUICKFIX_TOOL = 0x90D0622866E80445,
        _PLAYSTATS_HEIST_SAVE_CHEAT = 0xF4FF020A08BC8863,
        _PLAYSTATS_DIRECTOR_MODE = 0x46326E13DA4E0546,
        _PLAYSTATS_AWARD_BADSPORT = 0x47B32F5611E6E483,
        _PLAYSTATS_PEGASAIRCRAFT = 0x9572BD4DD6B72122,
        _PLAYSTATS_PI_MENU_HIDE_SETTINGS = 0x203B381133817079,
        LEADERBOARDS_GET_NUMBER_OF_COLUMNS = 0x117B45156D7EFF2E,
        LEADERBOARDS_GET_COLUMN_ID = 0xC4B5467A1886EA7E,
        LEADERBOARDS_GET_COLUMN_TYPE = 0xBF4FEF46DB7894D3,
        LEADERBOARDS_READ_CLEAR_ALL = 0xA34CB6E6F0DF4A0B,
        LEADERBOARDS_READ_CLEAR = 0x7CCE5C737A665701,
        LEADERBOARDS_READ_PENDING = 0xAC392C8483342AC2,
        LEADERBOARDS_READ_ANY_PENDING = 0xA31FD15197B192BD,
        LEADERBOARDS_READ_SUCCESSFUL = 0x2FB19228983E832C,
        LEADERBOARDS2_READ_FRIENDS_BY_ROW = 0x918B101666F9CB83,
        LEADERBOARDS2_READ_BY_HANDLE = 0xC30713A383BFBF0E,
        LEADERBOARDS2_READ_BY_ROW = 0xA9CDB1E3F0A49883,
        LEADERBOARDS2_READ_BY_RANK = 0xBA2C7DB0C129449A,
        LEADERBOARDS2_READ_BY_RADIUS = 0x5CE587FB5A42C8C4,
        LEADERBOARDS2_READ_BY_SCORE_INT = 0x7EEC7E4F6984A16A,
        LEADERBOARDS2_READ_BY_SCORE_FLOAT = 0xE662C8B759D08F3C,
        LEADERBOARDS2_READ_RANK_PREDICTION = 0xC38DC1E90D22547C,
        _LEADERBOARDS2_READ_BY_PLATFORM = 0xF1AE5DCDBFCA2721,
        LEADERBOARDS2_WRITE_DATA = 0xAE2206545888AE49,
        LEADERBOARDS_WRITE_ADD_COLUMN = 0x0BCA1D2C47B0D269,
        LEADERBOARDS_WRITE_ADD_COLUMN_LONG = 0x2E65248609523599,
        LEADERBOARDS_CACHE_DATA_ROW = 0xB9BB18E2C40142ED,
        LEADERBOARDS_CLEAR_CACHE_DATA = 0xD4B02A6B476E1FDC,
        LEADERBOARDS_GET_CACHE_EXISTS = 0x9C51349BE6CDFE2C,
        LEADERBOARDS_GET_CACHE_TIME = 0xF04C1C27DA35F6C8,
        LEADERBOARDS_GET_CACHE_NUMBER_OF_ROWS = 0x58A651CD201D89AD,
        LEADERBOARDS_GET_CACHE_DATA_ROW = 0x9120E8DBA3D69273,
        _UPDATE_STAT_INT = 0x11FF1C80276097ED,
        _UPDATE_STAT_FLOAT = 0x30A6614C1F7799B8,
        SET_PROFILE_SETTING_PROLOGUE_COMPLETE = 0xB475F27C6A994D65,
        STAT_SET_CHEAT_IS_ACTIVE = 0x047CBED6F6F8B63C,
        LEADERBOARDS2_WRITE_DATA_FOR_EVENT_TYPE = 0xC980E62E33DF1D5C,
        STAT_GET_SAVE_MIGRATION_STATUS = 0x886913BBEACA68C1,
        _STAT_SAVE_MIGRATION_CANCEL = 0x4FEF53183C3C6414,
        _STAT_GET_CANCEL_SAVE_MIGRATION_STATUS = 0x567384DFA67029E6,
        _STAT_SAVE_MIGRATION_CONSUME_CONTENT_UNLOCK = 0x3270F67EED31FBC1,
        _STAT_GET_SAVE_MIGRATION_CONSUME_CONTENT_UNLOCK_STATUS = 0xCE5AA445ABA8DEE0,
        _PLAYSTATS_SPENT_PI_CUSTOM_LOADOUT = 0xBE509B0A3693DE8B,
        _PLAYSTATS_BUY_CONTRABAND = 0xD6781E42755531F7,
        _PLAYSTATS_SELL_CONTRABAND = 0xC729991A9065376E,
        _PLAYSTATS_DEFEND_CONTRABAND = 0x2605663BD4F23B5D,
        _PLAYSTATS_RECOVER_CONTRABAND = 0x04D90BA8207ADA2D,
        _HIRED_LIMO = 0x792271AB35C356A4,
        _ORDERED_BOSS_VEHICLE = 0xCEA553E35C2246E1,
        _PLAYSTATS_CHANGE_MC_EMBLEM = 0x0A50D2604E05CB94,
        _PLAYSTATS_EARNED_MC_POINTS = 0x501478855A6074CE,
        _PLAYSTATS_COPY_RANK_INTO_NEW_SLOT = 0xB7257BA2550EA10A,
        _PLAYSTATS_DUPE_DETECTION = 0x848B66100EE33B05,
        _PLAYSTATS_BAN_ALERT = 0x516FC96EB88EEFE5,
        _PLAYSTATS_GUNRUN_MISSION_ENDED = 0x0EACDF8487D5155A,
        _PLAYSTATS_STONE_HATCHET_END = 0x35E39E5570358630,
        _PLAYSTATS_SMUG_MISSION_ENDED = 0x320C35147D5B5DDD,
        _PLAYSTATS_H2_FMPREP_END = 0xD8AFB345A9C5CCBB,
        _PLAYSTATS_H2_INSTANCE_END = 0x1E1497D0D2108115,
        _PLAYSTATS_DAR_MISSION_END = 0x0BC254FF3A911501,
        _PLAYSTATS_ENTER_SESSION_PACK = 0x878FF156D36E9956,
        _PLAYSTATS_DRONE_USAGE = 0x66C7BB2416ED3FCE,
        _PLAYSTATS_SPECTATOR_WHEEL_SPIN = 0x6731DE84A38BFAD0,
        _PLAYSTATS_ARENA_WAR_SPECTATOR = 0x6F4F599753F8200A,
        _PLAYSTATS_ARENA_WARS_ENDED = 0xB479D9F0D48A1BC5,
        _PLAYSTATS_PASSIVE_MODE = 0x35EEC6C2BC821A71,
        _PLAYSTATS_COLLECTIBLE = 0xCD0A8A9338681CF2,
        _PLAYSTATS_CASINO_STORY_MISSION_ENDED = 0xFCCCAC2BD3C1F180,
        _PLAYSTATS_CASINO_CHIP = 0x0999F3F090EC5012,
        _PLAYSTATS_CASINO_ROULETTE = 0x95101C443A84E7F1,
        _PLAYSTATS_CASINO_BLACKJACK = 0x3EAE97309727E7AD,
        _PLAYSTATS_CASINO_THREECARDPOKER = 0xF740FB339D471C35,
        _PLAYSTATS_CASINO_SLOTMACHINE = 0xEF5EC67D392B830A,
        _PLAYSTATS_CASINO_INSIDETRACK = 0x049F059625058A86,
        _PLAYSTATS_CASINO_LUCKYSEVEN = 0x0C432C1435F5E4FA,
        _PLAYSTATS_CASINO_ROULETTE_LIGHT = 0x6572ABA3DE1197FC,
        _PLAYSTATS_CASINO_BLACKJACK_LIGHT = 0xD5451C7BF151EB6F,
        _PLAYSTATS_CASINO_THREECARDPOKER_LIGHT = 0xC9001364B4388F22,
        _PLAYSTATS_CASINO_SLOTMACHINE_LIGHT = 0xE60054A0FAE8227F,
        _PLAYSTATS_CASINO_INSIDETRACK_LIGHT = 0x23A3CBCD50D54E47,
        _PLAYSTATS_ARCADEGAME = 0x533A7D1EA58DF958,
        _PLAYSTATS_CASINO_MISSION_ENDED = 0x1A0D4A6C336B7BC5,
        _PLAYSTATS_ROBBERY_PREP = 0x1A67DFBF1F5C3835,
        _PLAYSTATS_ROBBERY_FINALE = 0xBBA55BE9AAAABF44,
        _PLAYSTATS_EXTRA_EVENT = 0xFA5B74BAB8A7EF99,
        _PLAYSTATS_CARCLUB_POINTS = 0xFF14D6FEEC507BBE,
        _PLAYSTATS_CARCLUB_CHALLENGE = 0x1187CB58D7F3BED7,
        _PLAYSTATS_CARCLUB_PRIZE = 0x69C922B677621428,
        _0x7F2C4CDF2E82DF4C = 0x7F2C4CDF2E82DF4C,
        _0xE496A53BA5F50A56 = 0xE496A53BA5F50A56,
        _0x6A7F19756F1A9016 = 0x6A7F19756F1A9016,
        _0x7E6946F68A38B74F = 0x7E6946F68A38B74F,
        _0xA8733668D1047B51 = 0xA8733668D1047B51,
        _0x9B4BD21D69B1E609 = 0x9B4BD21D69B1E609,
        _0xC0E0D686DDFC6EAE = 0xC0E0D686DDFC6EAE,
        _0x5A556B229A169402 = 0x5A556B229A169402,
        _0xB1D2BB1E1631F5B1 = 0xB1D2BB1E1631F5B1,
        _0xBED9F5693F34ED17 = 0xBED9F5693F34ED17,
        _0xF8C54A461C3E11DC = 0xF8C54A461C3E11DC,
        _0xF5BB8DAC426A52C0 = 0xF5BB8DAC426A52C0,
        _0xA736CF7FB7C5BFF4 = 0xA736CF7FB7C5BFF4,
        _0x14E0B2D1AD1044E0 = 0x14E0B2D1AD1044E0,
        _0x6A60E43998228229 = 0x6A60E43998228229,
        _0xBFAFDB5FAAA5C5AB = 0xBFAFDB5FAAA5C5AB,
        _0x8C9D11605E59D955 = 0x8C9D11605E59D955,
        _0x3DE3AA516FB126A4 = 0x3DE3AA516FB126A4,
        _0xBAA2F0490E146BE8 = 0xBAA2F0490E146BE8,
        _0x1A7CE7CD3E653485 = 0x1A7CE7CD3E653485,
        _0x419615486BBF1956 = 0x419615486BBF1956,
        _0x84DFC579C2FC214C = 0x84DFC579C2FC214C,
        _0x0A9C7F36E5D7B683 = 0x0A9C7F36E5D7B683,
        _0x164C5FF663790845 = 0x164C5FF663790845,
        _0xEDBF6C9B0D2C65C8 = 0xEDBF6C9B0D2C65C8,
        _0x6551B1F7F6CD46EA = 0x6551B1F7F6CD46EA,
        _0x2CD90358F67D0AA8 = 0x2CD90358F67D0AA8,
        _0xA0F93D5465B3094D = 0xA0F93D5465B3094D,
        _0x71B008056E5692D6 = 0x71B008056E5692D6,
        _0x34770B9CE0E03B91 = 0x34770B9CE0E03B91,
        _0x88578F6EC36B4A3A = 0x88578F6EC36B4A3A,
        _0x38491439B6BA7F7D = 0x38491439B6BA7F7D,
        _0x8EC74CEB042E7CFF = 0x8EC74CEB042E7CFF,
        _0x6483C25849031C4F = 0x6483C25849031C4F,
        _0xC141B8917E0017EC = 0xC141B8917E0017EC,
        _0x723C1CE13FBFDB67 = 0x723C1CE13FBFDB67,
        _0x0D01D20616FC73FB = 0x0D01D20616FC73FB,
        _0x428EAF89E24F6C36 = 0x428EAF89E24F6C36,
        _0x6F361B8889A792A3 = 0x6F361B8889A792A3,
        _0xC847B43F369AC0B5 = 0xC847B43F369AC0B5,
        _0x9A62EC95AE10E011 = 0x9A62EC95AE10E011,
        _0x4C89FE2BDEB3F169 = 0x4C89FE2BDEB3F169,
        _0xC6E0E2616A7576BB = 0xC6E0E2616A7576BB,
        _0x5BD5F255321C4AAF = 0x5BD5F255321C4AAF,
        _0xDEAAF77EB3687E97 = 0xDEAAF77EB3687E97,
        _0x98E2BC1CA26287C3 = 0x98E2BC1CA26287C3,
        _0x629526ABA383BCAA = 0x629526ABA383BCAA,
        _0xBE3DB208333D9844 = 0xBE3DB208333D9844,
        _0x33D72899E24C3365 = 0x33D72899E24C3365,
        _0xA761D4AC6115623D = 0xA761D4AC6115623D,
        _0xF11F01D98113536A = 0xF11F01D98113536A,
        _0x8B9CDBD6C566C38C = 0x8B9CDBD6C566C38C,
        _0xE8853FBCE7D8D0D6 = 0xE8853FBCE7D8D0D6,
        _0xA943FD1722E11EFD = 0xA943FD1722E11EFD,
        _0x84A810B375E69C0E = 0x84A810B375E69C0E,
        _0x9EC8858184CD253A = 0x9EC8858184CD253A,
        _0xBA9749CC94C1FD85 = 0xBA9749CC94C1FD85,
        _0x55A8BECAF28A4EB7 = 0x55A8BECAF28A4EB7,
        _0x32CAC93C9DE73D32 = 0x32CAC93C9DE73D32,
        _0xAFF47709F1D5DCCE = 0xAFF47709F1D5DCCE,
        _0x6E0A5253375C4584 = 0x6E0A5253375C4584,
        _0x1A8EA222F9C67DBB = 0x1A8EA222F9C67DBB,
        _0xF9F2922717B819EC = 0xF9F2922717B819EC,
        _0x0B8B7F74BF061C6D = 0x0B8B7F74BF061C6D,
        _0x6BC0ACD0673ACEBE = 0x6BC0ACD0673ACEBE,
        _0x8D8ADB562F09A245 = 0x8D8ADB562F09A245,
        _0xD1A1EE3B4FA8E760 = 0xD1A1EE3B4FA8E760,
        _0x88087EE1F28024AE = 0x88087EE1F28024AE,
        _0xFCC228E07217FCAC = 0xFCC228E07217FCAC,
        _0x678F86D8FC040BDB = 0x678F86D8FC040BDB,
        _0xA6F54BB2FFCA35EA = 0xA6F54BB2FFCA35EA,
        _0x5FF2C33B13A02A11 = 0x5FF2C33B13A02A11,
        _0x282B6739644F4347 = 0x282B6739644F4347,
        _0xF06A6F41CB445443 = 0xF06A6F41CB445443,
        _0x7B18DA61F6BAE9D5 = 0x7B18DA61F6BAE9D5,
        _0x06EAF70AE066441E = 0x06EAF70AE066441E,
        _0x14EDA9EE27BD1626 = 0x14EDA9EE27BD1626,
        _0x930F504203F561C9 = 0x930F504203F561C9,
        _0xE3261D791EB44ACB = 0xE3261D791EB44ACB,
        _0x73001E34F85137F8 = 0x73001E34F85137F8,
        _0x53CAE13E9B426993 = 0x53CAE13E9B426993,
        _0x7D36291161859389 = 0x7D36291161859389,
        _0x60EEDC12AF66E846 = 0x60EEDC12AF66E846,
        _0x3EBEAC6C3F81F6BD = 0x3EBEAC6C3F81F6BD,
        _0x96E6D5150DBF1C09 = 0x96E6D5150DBF1C09,
        _0xA3C53804BDB68ED2 = 0xA3C53804BDB68ED2,
        _0x6BCCF9948492FD85 = 0x6BCCF9948492FD85,
        _0xD1C9B92BDD3F151D = 0xD1C9B92BDD3F151D,
        _0x44919CC079BB60BF = 0x44919CC079BB60BF,
        _0x7033EEFD9B28088E = 0x7033EEFD9B28088E,
        _0xAA525DFF66BB82F5 = 0xAA525DFF66BB82F5,
        _0x015B03EE1C43E6EC = 0x015B03EE1C43E6EC,
        _0xBF371CD2B64212FD = 0xBF371CD2B64212FD,
        _0x7D8BA05688AD64C7 = 0x7D8BA05688AD64C7,
        _0x0B565B0AAE56A0E8 = 0x0B565B0AAE56A0E8,
        _0x28ECB8AC2F607DB2 = 0x28ECB8AC2F607DB2,
        _0xCC25A4553DFBF9EA = 0xCC25A4553DFBF9EA,
        _0xF534D94DFA2EAD26 = 0xF534D94DFA2EAD26,
        _0xD558BEC0BBA7E8D2 = 0xD558BEC0BBA7E8D2,
        _0x03C2EEBB04B3FB72 = 0x03C2EEBB04B3FB72,
        _0x8989CBD7B4E82534 = 0x8989CBD7B4E82534,
        _0x27AA1C973CACFE63 = 0x27AA1C973CACFE63,
        _0xDAF80797FC534BEC = 0xDAF80797FC534BEC,
        _0x316DB59CD14C1774 = 0x316DB59CD14C1774,
        _0x2D7A9B577E72385E = 0x2D7A9B577E72385E,
        _0x830C3A44EB3F2CF9 = 0x830C3A44EB3F2CF9,
        _0xB26F670685631727 = 0xB26F670685631727,
        _0xC14BD9F5337219B2 = 0xC14BD9F5337219B2,
        _0x4FCDBD3F0A813C25 = 0x4FCDBD3F0A813C25,
        _0xDFBD93BF2943E29B = 0xDFBD93BF2943E29B,
        _0x92FC0EEDFAC04A14 = 0x92FC0EEDFAC04A14,
        _0x0077F15613D36993 = 0x0077F15613D36993,
        _0xF9096193DF1F99D4 = 0xF9096193DF1F99D4,
        _0x2E0259BABC27A327 = 0x2E0259BABC27A327,
        _0x53C31853EC9531FF = 0x53C31853EC9531FF,
        _0x810B5FCC52EC7FF0 = 0x810B5FCC52EC7FF0,
        _0x5BF29846C6527C54 = 0x5BF29846C6527C54,
        _0xC03FAB2C2F92289B = 0xC03FAB2C2F92289B,
        _0x5CDAED54B34B0ED0 = 0x5CDAED54B34B0ED0,
        _0x4AFF7E02E485E92B = 0x4AFF7E02E485E92B,
        _0xDFCDB14317A9B361 = 0xDFCDB14317A9B361,
        _0xC1E963C58664B556 = 0xC1E963C58664B556,
        _0x2FA3173480008493 = 0x2FA3173480008493,
        _0xD4367D310F079DB0 = 0xD4367D310F079DB0,
        _0x4DC416F246A41FC8 = 0x4DC416F246A41FC8,
        _0x2818FF6638CB09DE = 0x2818FF6638CB09DE,
        _0xD6CA58B3B53A0F22 = 0xD6CA58B3B53A0F22,
    }
}