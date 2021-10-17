using System;
namespace Hotstar
{
    public enum STREAMING : ulong
    { 
        /// <summary>
        /// Request a model to be loaded into memory.
        /// 
        ///
        /// > Hash model
        ///
        /// </summary>
        REQUEST_MODEL = 0x963D27A58DF860AC,
        /// <summary>
        /// Checks if the specified model has loaded into memory.
        ///
        /// > Hash model
        ///
        /// </summary>
        HAS_MODEL_LOADED = 0x98A4EB5D89A0C952,
        /// <summary>
        /// STREAMING::REQUEST_MODELS_IN_ROOM(l_13BC, "V_FIB01_cur_elev");
        /// STREAMING::REQUEST_MODELS_IN_ROOM(l_13BC, "limbo");
        /// STREAMING::REQUEST_MODELS_IN_ROOM(l_13BB, "V_Office_gnd_lifts");
        /// STREAMING::REQUEST_MODELS_IN_ROOM(l_13BB, "limbo");
        /// STREAMING::REQUEST_MODELS_IN_ROOM(l_13BC, "v_fib01_jan_elev");
        /// STREAMING::REQUEST_MODELS_IN_ROOM(l_13BC, "limbo");
        ///
        /// > Interior interior
        /// > const char* roomName
        ///
        /// </summary>
        REQUEST_MODELS_IN_ROOM = 0x8A7A40100EDFEC58,
        /// <summary>
        /// Unloads model from memory
        ///
        /// > Hash model
        ///
        /// </summary>
        SET_MODEL_AS_NO_LONGER_NEEDED = 0xE532F5D78798DAAB,
        /// <summary>
        /// Check if model is in cdimage(rpf)
        ///
        /// > Hash model
        ///
        /// </summary>
        IS_MODEL_IN_CDIMAGE = 0x35B9E0803292B641,
        /// <summary>
        /// Returns whether the specified model exists in the game.
        ///
        /// > Hash model
        ///
        /// </summary>
        IS_MODEL_VALID = 0xC0296A2EDF545E92,
        /// <summary>
        /// Returns whether the specified model represents a vehicle.
        ///
        /// > Hash model
        ///
        /// </summary>
        IS_MODEL_A_VEHICLE = 0x19AAC8F07BFEC53E,
        /// <summary>
        /// MulleDK19: Alias of REQUEST_COLLISION_AT_COORD.
        ///
        /// > float x
        /// > float y
        /// > float z
        ///
        /// </summary>
        REQUEST_ADDITIONAL_COLLISION_AT_COORD = 0xC9156DC11411A9EA,
        /// <summary>
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        ///
        /// > const char* animDict
        ///
        /// </summary>
        DOES_ANIM_DICT_EXIST = 0x2DA49C3B79856961,
        /// <summary>
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        ///
        /// > const char* animDict
        ///
        /// </summary>
        REQUEST_ANIM_DICT = 0xD3BD40951412FEF6,
        /// <summary>
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        ///
        /// > const char* animDict
        ///
        /// </summary>
        HAS_ANIM_DICT_LOADED = 0xD031A9162D01088C,
        /// <summary>
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        ///
        /// > const char* animDict
        ///
        /// </summary>
        REMOVE_ANIM_DICT = 0xF66A602F829E2A06,
        /// <summary>
        /// Starts loading the specified animation set. An animation set provides movement animations for a ped. See SET_PED_MOVEMENT_CLIPSET.
        /// 
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        /// 
        /// Full list of movement clipsets by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/movementClipsetsCompact.json
        ///
        /// > const char* animSet
        ///
        /// </summary>
        REQUEST_ANIM_SET = 0x6EA47DAE7FAD0EED,
        /// <summary>
        /// Gets whether the specified animation set has finished loading. An animation set provides movement animations for a ped. See SET_PED_MOVEMENT_CLIPSET.
        /// 
        /// Animation set and clip set are synonymous.
        /// 
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        /// 
        /// Full list of movement clipsets by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/movementClipsetsCompact.json
        ///
        /// > const char* animSet
        ///
        /// </summary>
        HAS_ANIM_SET_LOADED = 0xC4EA073D86FB29B0,
        /// <summary>
        /// Unloads the specified animation set. An animation set provides movement animations for a ped. See SET_PED_MOVEMENT_CLIPSET.
        /// 
        /// Animation set and clip set are synonymous.
        /// 
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        /// 
        /// Full list of movement clipsets by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/movementClipsetsCompact.json
        ///
        /// > const char* animSet
        ///
        /// </summary>
        REMOVE_ANIM_SET = 0x16350528F93024B3,
        /// <summary>
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        /// 
        /// Full list of movement clipsets by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/movementClipsetsCompact.json
        ///
        /// > const char* clipSet
        ///
        /// </summary>
        REQUEST_CLIP_SET = 0xD2A71E1A77418A49,
        /// <summary>
        /// Alias for HAS_ANIM_SET_LOADED.
        /// 
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        /// 
        /// Full list of movement clipsets by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/movementClipsetsCompact.json
        ///
        /// > const char* clipSet
        ///
        /// </summary>
        HAS_CLIP_SET_LOADED = 0x318234F4F3738AF3,
        /// <summary>
        /// Alias for REMOVE_ANIM_SET.
        /// 
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        /// 
        /// Full list of movement clipsets by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/movementClipsetsCompact.json
        ///
        /// > const char* clipSet
        ///
        /// </summary>
        REMOVE_CLIP_SET = 0x01F73A131C18CD94,
        /// <summary>
        /// Exemple: REQUEST_IPL("TrevorsTrailerTrash");
        /// 
        /// Full list of IPLs and interior entity sets by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/ipls.json
        ///
        /// > const char* iplName
        ///
        /// </summary>
        REQUEST_IPL = 0x41B4893843BBDB74,
        /// <summary>
        /// Removes an IPL from the map.
        /// 
        /// Full list of IPLs and interior entity sets by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/ipls.json
        /// 
        /// Example:
        /// C#:
        /// Function.Call(Hash.REMOVE_IPL, "trevorstrailertidy");
        /// 
        /// C++:
        /// STREAMING::REMOVE_IPL("trevorstrailertidy");
        /// 
        /// iplName = Name of IPL you want to remove.
        ///
        /// > const char* iplName
        ///
        /// </summary>
        REMOVE_IPL = 0xEE6C5AD3ECE0A82D,
        /// <summary>
        /// Full list of IPLs and interior entity sets by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/ipls.json
        ///
        /// > const char* iplName
        ///
        /// </summary>
        IS_IPL_ACTIVE = 0x88A741E44A2B3495,
        /// <summary>
        /// 0 - default
        /// 1 - HeistIsland
        ///
        /// > int waterType
        ///
        /// </summary>
        _LOAD_GLOBAL_WATER_TYPE = 0x7E3F55ED251B76D3,
        /// <summary>
        /// This is a NOP function. It does nothing at all.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_DITCH_POLICE_MODELS = 0x42CBE54462D92634,
        /// <summary>
        /// maps script name (thread + 0xD0) by lookup via scriptfx.dat - does nothing when script name is empty
        ///
        ///
        /// </summary>
        REQUEST_PTFX_ASSET = 0x944955FB2A3935C8,
        /// <summary>
        ///  From the b678d decompiled scripts:
        /// 
        ///  STREAMING::REQUEST_NAMED_PTFX_ASSET("core_snow");
        ///  STREAMING::REQUEST_NAMED_PTFX_ASSET("fm_mission_controler");
        ///  STREAMING::REQUEST_NAMED_PTFX_ASSET("proj_xmas_firework");
        ///  STREAMING::REQUEST_NAMED_PTFX_ASSET("scr_apartment_mp");
        ///  STREAMING::REQUEST_NAMED_PTFX_ASSET("scr_biolab_heist");
        ///  STREAMING::REQUEST_NAMED_PTFX_ASSET("scr_indep_fireworks");
        ///  STREAMING::REQUEST_NAMED_PTFX_ASSET("scr_indep_parachute");
        ///  STREAMING::REQUEST_NAMED_PTFX_ASSET("scr_indep_wheelsmoke");
        ///  STREAMING::REQUEST_NAMED_PTFX_ASSET("scr_mp_cig_plane");
        ///  STREAMING::REQUEST_NAMED_PTFX_ASSET("scr_mp_creator");
        ///  STREAMING::REQUEST_NAMED_PTFX_ASSET("scr_mp_tankbattle");
        ///  STREAMING::REQUEST_NAMED_PTFX_ASSET("scr_ornate_heist");
        ///  STREAMING::REQUEST_NAMED_PTFX_ASSET("scr_prison_break_heist_station");
        ///
        /// > const char* fxName
        ///
        /// </summary>
        REQUEST_NAMED_PTFX_ASSET = 0xB80D8756B4668AB6,
        /// <summary>
        /// Control how many new (ambient?) peds will spawn in the game world.
        /// Range for p0 seems to be 0-3, where 0 is none and 3 is the normal level.
        ///
        /// > int p0
        ///
        /// </summary>
        SET_PED_POPULATION_BUDGET = 0x8C95333CFC3340F3,
        /// <summary>
        /// Override the area where the camera will render the terrain.
        /// p3, p4 and p5 are usually set to 0.0
        /// 
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float offsetX
        /// > float offsetY
        /// > float offsetZ
        ///
        /// </summary>
        SET_FOCUS_POS_AND_VEL = 0xBB7454BAFF08FE25,
        /// <summary>
        /// It seems to make the entity's coords mark the point from which LOD-distances are measured. In my testing, setting a vehicle as the focus entity and moving that vehicle more than 300 distance units away from the player will make the level of detail around the player go down drastically (shadows disappear, textures go extremely low res, etc). The player seems to be the default focus entity.
        ///
        /// > Entity entity
        ///
        /// </summary>
        SET_FOCUS_ENTITY = 0x198F77705FA0931D,
        /// <summary>
        /// Possible p0 values:
        /// 
        /// "prologue"
        /// "Prologue_Main"
        ///
        /// > const char* name
        /// > BOOL toggle
        ///
        /// </summary>
        SET_MAPDATACULLBOX_ENABLED = 0xAF12610C644A35C9,
        /// <summary>
        /// Always returns zero.
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float rad
        /// > Any p4
        /// > Any p5
        ///
        /// </summary>
        STREAMVOL_CREATE_SPHERE = 0x219C7B8D53E429FD,
        /// <summary>
        /// Always returns zero.
        ///
        /// > float p0
        /// > float p1
        /// > float p2
        /// > float p3
        /// > float p4
        /// > float p5
        /// > float p6
        /// > Any p7
        /// > Any p8
        ///
        /// </summary>
        STREAMVOL_CREATE_FRUSTUM = 0x1F3F018BC3AFA77C,
        /// <summary>
        /// Always returns zero.
        ///
        /// > float p0
        /// > float p1
        /// > float p2
        /// > float p3
        /// > float p4
        /// > float p5
        /// > Any p6
        ///
        /// </summary>
        STREAMVOL_CREATE_LINE = 0x0AD9710CEE2F590F,
        /// <summary>
        /// `radius` value is usually between `3f` and `7000f` in original 1868 scripts.
        /// `p7` is 0, 1, 2, 3 or 4 used in decompiled scripts, 0 is by far the most common.
        /// Returns True if success, used only 7 times in decompiled scripts of 1868
        ///
        /// > float posX
        /// > float posY
        /// > float posZ
        /// > float offsetX
        /// > float offsetY
        /// > float offsetZ
        /// > float radius
        /// > int p7
        ///
        /// </summary>
        NEW_LOAD_SCENE_START = 0x212A8D0D2BABFAC2,
        /// <summary>
        /// if (!sub_8f12("START LOAD SCENE SAFE")) {
        ///     if (CUTSCENE::GET_CUTSCENE_TIME() > 4178) {
        ///         STREAMING::_ACCFB4ACF53551B0(1973.845458984375, 3818.447265625, 32.43629837036133, 15.0, 2);
        ///         sub_8e9e("START LOAD SCENE SAFE", 1);
        ///     }
        /// }
        /// 
        /// (Previously known as STREAMING::_NEW_LOAD_SCENE_START_SAFE)
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        /// > Any p4
        ///
        /// </summary>
        NEW_LOAD_SCENE_START_SPHERE = 0xACCFB4ACF53551B0,
        /// <summary>
        /// // this enum comes directly from R* so don't edit this
        /// enum ePlayerSwitchTypes
        /// {
        ///   SWITCH_TYPE_AUTO,
        ///  SWITCH_TYPE_LONG,
        ///  SWITCH_TYPE_MEDIUM,
        ///    SWITCH_TYPE_SHORT
        /// };
        /// 
        /// Use GET_IDEAL_PLAYER_SWITCH_TYPE for the best switch type.
        /// 
        /// ----------------------------------------------------
        /// 
        /// Examples from the decompiled scripts:
        /// 
        /// STREAMING::START_PLAYER_SWITCH(l_832._f3, PLAYER::PLAYER_PED_ID(), 0, 3);
        /// STREAMING::START_PLAYER_SWITCH(l_832._f3, PLAYER::PLAYER_PED_ID(), 2050, 3);
        /// STREAMING::START_PLAYER_SWITCH(PLAYER::PLAYER_PED_ID(), l_832._f3, 1024, 3);
        /// STREAMING::START_PLAYER_SWITCH(g_141F27, PLAYER::PLAYER_PED_ID(), 513, v_14);
        /// 
        /// Note: DO NOT, use SWITCH_TYPE_LONG with flag 513. It leaves you stuck in the clouds. You'll have to call STOP_PLAYER_SWITCH() to return to your ped.
        /// 
        /// Flag 8 w/ SWITCH_TYPE_LONG will zoom out 3 steps, then zoom in 2/3 steps and stop on the 3rd and just hang there.
        /// Flag 8 w/ SWITCH_TYPE_MEDIUM will zoom out 1 step, and just hang there.
        ///
        /// > Ped from
        /// > Ped to
        /// > int flags
        /// > int switchType
        ///
        /// </summary>
        START_PLAYER_SWITCH = 0xFAA23F2CBA159D67,
        /// <summary>
        /// Returns true if the player is currently switching, false otherwise.
        /// (When the camera is in the sky moving from Trevor to Franklin for example)
        ///
        ///
        /// </summary>
        IS_PLAYER_SWITCH_IN_PROGRESS = 0xD9D2CFFF49FAB35F,
        /// <summary>
        /// x1, y1, z1 -- Coords of your ped model
        /// x2, y2, z2 -- Coords of the ped you want to switch to
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        ///
        /// </summary>
        GET_IDEAL_PLAYER_SWITCH_TYPE = 0xB5D7B26B45720E05,
        /// <summary>
        /// All names can be found in playerswitchestablishingshots.meta
        ///
        /// > const char* name
        ///
        /// </summary>
        SET_PLAYER_SWITCH_ESTABLISHING_SHOT = 0x0FDE9DBFC0A6BC65,
        /// <summary>
        /// doesn't act normally when used on mount chilliad
        /// Flags is a bitflag:
        /// 2^n - Enabled Functionality:
        /// 0 - Skip camera rotate up
        /// 3 - Wait for SET_PLAYER_SWITCH_ESTABLISHING_SHOT / hang at last step. You will still need to run 0x74DE2E8739086740 to exit "properly" and then STOP_PLAYER_SWITCH
        /// 6 - Invert Switch Direction (false = out, true = in)
        /// 8 - Hang above ped
        /// 
        /// switchType: 0 - 3
        /// 0: 1 step towards ped
        /// 1: 3 steps out from ped
        /// 2: 1 step out from ped
        /// 3: 1 step towards ped
        ///
        /// > Ped ped
        /// > int flags
        /// > int switchType
        ///
        /// </summary>
        _SWITCH_OUT_PLAYER = 0xAAB3200ED59016BC,
        /// <summary>
        /// This allows you to override "extended distance scaling" setting. Needs to be called each frame.
        /// Max scaling seems to be 200.0, normal is 1.0
        /// See https://gfycat.com/DetailedHauntingIncatern
        ///
        /// > float scaling
        ///
        /// </summary>
        OVERRIDE_LODSCALE_THIS_FRAME = 0xA76359FC80B2438E,
        /// <summary>
        /// This native is used to attribute the SRL that BEGIN_SRL is going to load. This is usually used for 'in-game' cinematics (not cutscenes but camera stuff) instead of SET_FOCUS_POS_AND_VEL because it loads a specific area of the map which is pretty useful when the camera moves from distant areas.
        /// For instance, GTA:O opening cutscene.
        /// https://pastebin.com/2EeKVeLA : a list of SRL found in srllist.meta
        /// https://pastebin.com/zd9XYUWY here is the content of a SRL file opened with codewalker.
        ///
        /// > const char* srl
        ///
        /// </summary>
        PREFETCH_SRL = 0x3D245789CE12982C,
        /// <summary>
        /// Returns true when the srl from BEGIN_SRL is loaded.
        ///
        ///
        /// </summary>
        IS_SRL_LOADED = 0xD0263801A4C5B0BB,
        /// <summary>
        /// Clear the current srl and stop rendering the area selected by PREFETCH_SRL and started with BEGIN_SRL.
        ///
        ///
        /// </summary>
        END_SRL = 0x0A41540E63C9EE17,
        /// <summary>
        /// 0.0 = no memory used
        /// 1.0 = all memory used
        /// 
        /// Maximum model memory (as defined in common\data\missioncreatordata.meta) is 100 MiB
        /// 
        /// GET_*
        ///
        ///
        /// </summary>
        _GET_USED_CREATOR_MODEL_MEMORY_PERCENTAGE = 0x3D3D8B3BE5A83D35,
        /// <summary>
        /// Enables the specified island. For more information, see islandhopper.meta
        ///
        /// > const char* name
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_ISLAND_HOPPER_ENABLED = 0x9A9D1BA639675CF1,
        /// <summary>
        /// This native does absolutely nothing, just a nullsub
        ///
        /// > Any p0
        ///
        /// </summary>
        _0x4E52E752C76E7E7A = 0x4E52E752C76E7E7A,
        /// <summary>
        /// SET_PLAYER_*
        ///
        /// > int p0
        ///
        /// </summary>
        _0x5F2013F8BC24EE69 = 0x5F2013F8BC24EE69,
        /// <summary>
        /// Probably IS_SWITCH_*
        ///
        ///
        /// </summary>
        _0x933BBEEB8C61B5F4 = 0x933BBEEB8C61B5F4,
        LOAD_ALL_OBJECTS_NOW = 0xBD6E84632DD4CB3F,
        LOAD_SCENE = 0x4448EB75B4904BDB,
        NETWORK_UPDATE_LOAD_SCENE = 0xC4582015556D1C46,
        IS_NETWORK_LOADING_SCENE = 0x41CA5A33160EA4AB,
        SET_INTERIOR_ACTIVE = 0xE37B76C387BE28ED,
        REQUEST_MENU_PED_MODEL = 0xA0261AEF7ACFC51E,
        IS_MODEL_A_PED = 0x75816577FEA6DAD5,
        REQUEST_COLLISION_AT_COORD = 0x07503F7948F491A7,
        REQUEST_COLLISION_FOR_MODEL = 0x923CB32A3B874FCB,
        HAS_COLLISION_FOR_MODEL_LOADED = 0x22CCA434E368F03A,
        SET_STREAMING = 0x6E0C692677008888,
        _GET_GLOBAL_WATER_TYPE = 0xF741BD853611592D,
        SET_GAME_PAUSES_FOR_STREAMING = 0x717CD6E6FAEBBEDC,
        SET_REDUCE_PED_MODEL_BUDGET = 0x77B5F9A36BF96710,
        SET_REDUCE_VEHICLE_MODEL_BUDGET = 0x80C527893080CCF3,
        GET_NUMBER_OF_STREAMING_REQUESTS = 0x4060057271CEBC89,
        HAS_PTFX_ASSET_LOADED = 0xCA7D9B86ECA7481B,
        REMOVE_PTFX_ASSET = 0x88C6814073DD4A73,
        HAS_NAMED_PTFX_ASSET_LOADED = 0x8702416E512EC454,
        REMOVE_NAMED_PTFX_ASSET = 0x5F61EBBE1A00F96D,
        SET_VEHICLE_POPULATION_BUDGET = 0xCB9E1EB3BE2AF4E9,
        CLEAR_FOCUS = 0x31B73D1EA9F01DA2,
        IS_ENTITY_FOCUS = 0x2DDFF3FB9075D747,
        STREAMVOL_DELETE = 0x1EE7D8DF4425F053,
        STREAMVOL_HAS_LOADED = 0x7D41E9D2D17C5B2D,
        STREAMVOL_IS_VALID = 0x07C313F94746702C,
        IS_STREAMVOL_ACTIVE = 0xBC9823AB80A3DCAC,
        NEW_LOAD_SCENE_STOP = 0xC197616D221FF4A4,
        IS_NEW_LOAD_SCENE_ACTIVE = 0xA41A05B6CB741B85,
        IS_NEW_LOAD_SCENE_LOADED = 0x01B8247A7A8B9AD1,
        STOP_PLAYER_SWITCH = 0x95C0A5BBDC189AA1,
        GET_PLAYER_SWITCH_TYPE = 0xB3C94A90D9FC9E62,
        GET_PLAYER_SWITCH_STATE = 0x470555300D10B2A5,
        GET_PLAYER_SHORT_SWITCH_STATE = 0x20F898A5D9782800,
        GET_PLAYER_SWITCH_JUMP_CUT_INDEX = 0x78C0D93253149435,
        SET_PLAYER_SWITCH_OUTRO = 0xC208B673CE446B61,
        ALLOW_PLAYER_SWITCH_PAN = 0x43D1680C6D19A8E9,
        ALLOW_PLAYER_SWITCH_OUTRO = 0x74DE2E8739086740,
        ALLOW_PLAYER_SWITCH_ASCENT = 0x8E2A065ABDAE6994,
        ALLOW_PLAYER_SWITCH_DESCENT = 0xAD5FDF34B81BFE79,
        IS_SWITCH_READY_FOR_DESCENT = 0xDFA80CB25D0A19B3,
        ENABLE_SWITCH_PAUSE_BEFORE_DESCENT = 0xD4793DFF3AF2ABCD,
        DISABLE_SWITCH_OUTRO_FX = 0xBD605B8E0E18B3BB,
        _SWITCH_IN_PLAYER = 0xD8295AF639FD9CB8,
        GET_PLAYER_SWITCH_INTERP_OUT_DURATION = 0x08C2D6C52A3104BB,
        GET_PLAYER_SWITCH_INTERP_OUT_CURRENT_TIME = 0x5B48A06DD0E792A5,
        IS_SWITCH_SKIPPING_DESCENT = 0x5B74EA8CFD5E3E7E,
        GET_LODSCALE = 0x0C15B0E443B2349D,
        SET_RENDER_HD_ONLY = 0x40AEFD1A244741F2,
        BEGIN_SRL = 0x9BADDC94EF83B823,
        SET_SRL_TIME = 0xA74A541C6884E7B8,
        SET_HD_AREA = 0xB85F26619073E775,
        CLEAR_HD_AREA = 0xCE58B1CFB9290813,
        INIT_CREATOR_BUDGET = 0xB5A4DB34FE89B88A,
        SHUTDOWN_CREATOR_BUDGET = 0xCCE26000E9A6FAD7,
        ADD_MODEL_TO_CREATOR_BUDGET = 0x0BC3144DEB678666,
        REMOVE_MODEL_FROM_CREATOR_BUDGET = 0xF086AD9354FAC3A3,
        _0x0811381EF5062FEC = 0x0811381EF5062FEC,
        _0x71E7B2E657449AAD = 0x71E7B2E657449AAD,
        _0x1E9057A74FD73E23 = 0x1E9057A74FD73E23,
        _0xBED8CA5FF5E04113 = 0xBED8CA5FF5E04113,
        _0x472397322E92A856 = 0x472397322E92A856,
        _0x03F1A106BDA7DD3E = 0x03F1A106BDA7DD3E,
        _0x95A7DABDDBB78AE7 = 0x95A7DABDDBB78AE7,
        _0x63EB2B972A218CAC = 0x63EB2B972A218CAC,
        _0xFB199266061F820A = 0xFB199266061F820A,
        _0xF4A0DADB70F57FA6 = 0xF4A0DADB70F57FA6,
        _0x5068F488DDB54DD8 = 0x5068F488DDB54DD8,
        _0xEF39EE20C537E98C = 0xEF39EE20C537E98C,
        _0xBEB2D9A1D9A8F55A = 0xBEB2D9A1D9A8F55A,
        _0x20C6C7E4EB082A7F = 0x20C6C7E4EB082A7F,
        _0xF8155A7F03DDFC8E = 0xF8155A7F03DDFC8E,
    }
}