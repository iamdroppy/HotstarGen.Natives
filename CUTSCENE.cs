using System;
namespace Hotstar
{
    public enum CUTSCENE : ulong
    { 
        /// <summary>
        /// flags: Usually 8
        ///
        /// > const char* cutsceneName
        /// > int flags
        ///
        /// </summary>
        REQUEST_CUTSCENE = 0x7A86743F475D9E09,
        /// <summary>
        /// flags: Usually 8
        /// 
        /// playbackFlags: Which scenes should be played.
        /// Example: 0x105 (bit 0, 2 and 8 set) will enable scene 1, 3 and 9.
        ///
        /// > const char* cutsceneName
        /// > int playbackFlags
        /// > int flags
        ///
        /// </summary>
        REQUEST_CUTSCENE_WITH_PLAYBACK_LIST = 0xC23DE0E91C30B58C,
        /// <summary>
        /// Simply loads the cutscene and doesn't do extra stuff that REQUEST_CUTSCENE does.
        ///
        /// > const char* cutsceneName
        ///
        /// </summary>
        REQUEST_CUT_FILE = 0x06A3524161C502BA,
        /// <summary>
        /// Simply checks if the cutscene has loaded and doesn't check via CutSceneManager as opposed to HAS_[THIS]_CUTSCENE_LOADED.
        ///
        /// > const char* cutsceneName
        ///
        /// </summary>
        HAS_CUT_FILE_LOADED = 0xA1C996C2A744262E,
        /// <summary>
        /// Simply unloads the cutscene and doesn't do extra stuff that REMOVE_CUTSCENE does.
        ///
        /// > const char* cutsceneName
        ///
        /// </summary>
        REMOVE_CUT_FILE = 0xD00D76A7DFC9D852,
        /// <summary>
        /// Jenkins hash probably is 0xFD8B1AC2
        ///
        /// > const char* cutsceneName
        ///
        /// </summary>
        _GET_CUT_FILE_NUM_SECTIONS = 0x0ABC54DE641DC0FC,
        /// <summary>
        /// flags: Usually 0.
        ///
        /// > int flags
        ///
        /// </summary>
        START_CUTSCENE = 0x186D5CB5E7B0FF7B,
        /// <summary>
        /// flags: Usually 0.
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > int flags
        ///
        /// </summary>
        START_CUTSCENE_AT_COORDS = 0x1C9ADDA3244A1FBF,
        /// <summary>
        /// p3 could be heading. Needs more research.
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float p3
        /// > int p4
        ///
        /// </summary>
        SET_CUTSCENE_ORIGIN = 0xB812B3FD1C01CF27,
        /// <summary>
        /// Only used twice in R* scripts
        ///
        /// > float p0
        /// > float p1
        /// > float p2
        /// > float p3
        /// > float p4
        /// > float p5
        ///
        /// </summary>
        SET_CUTSCENE_TRIGGER_AREA = 0x9896CE4721BE84BA,
        /// <summary>
        /// modelHash (p1) was always 0 in R* scripts
        ///
        /// > const char* cutsceneEntName
        /// > Hash modelHash
        ///
        /// </summary>
        CAN_SET_ENTER_STATE_FOR_REGISTERED_ENTITY = 0x645D0B458D8E17B5,
        /// <summary>
        /// Full list of ped components by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pedComponentVariations.json
        ///
        /// > const char* cutsceneEntName
        /// > int p1
        /// > int p2
        /// > int p3
        /// > Hash modelHash
        ///
        /// </summary>
        SET_CUTSCENE_PED_COMPONENT_VARIATION = 0xBA01E7B6DEEFBBC9,
        /// <summary>
        /// Thanks R*! ;)
        /// 
        /// if ((l_161 == 0) || (l_161 == 2)) {
        ///     sub_2ea27("Trying to set Jimmy prop variation");
        ///     CUTSCENE::_0546524ADE2E9723("Jimmy_Boston", 1, 0, 0, 0);
        /// }
        /// 
        /// Full list of ped components by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pedComponentVariations.json
        ///
        /// > const char* cutsceneEntName
        /// > int p1
        /// > int p2
        /// > int p3
        /// > Hash modelHash
        ///
        /// </summary>
        SET_CUTSCENE_PED_PROP_VARIATION = 0x0546524ADE2E9723,
        /// <summary>
        /// HAS_CUTSCENE_*
        /// Possibly HAS_CUTSCENE_CUT_THIS_FRAME, needs more research.
        ///
        ///
        /// </summary>
        _HAS_CUTSCENE_CUT_THIS_FRAME = 0x708BDD8CD795B043,
        /// <summary>
        /// SET_SCRIPT_*
        /// 
        /// Sets the cutscene's owning thread ID.
        ///
        /// > int threadId
        ///
        /// </summary>
        _0x8D9DF6ECA8768583 = 0x8D9DF6ECA8768583,
        /// <summary>
        /// GET_CUTSCENE_*
        ///
        ///
        /// </summary>
        _0x971D7B15BCDBEF99 = 0x971D7B15BCDBEF99,
        /// <summary>
        /// This function is hard-coded to always return 1.
        ///
        /// > const char* cutsceneName
        ///
        /// </summary>
        _0x4CEBC1ED31E8925E = 0x4CEBC1ED31E8925E,
        /// <summary>
        /// SET_VEHICLE_*
        /// 
        /// Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
        ///
        /// > Hash modelHash
        ///
        /// </summary>
        _0x7F96F23FA9B73327 = 0x7F96F23FA9B73327,
        /// <summary>
        /// Toggles a value (bool) for cutscenes.
        /// 
        /// SET_*
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _0xC61B86C9F61EB404 = 0xC61B86C9F61EB404,
        REMOVE_CUTSCENE = 0x440AF51A3462B86F,
        HAS_CUTSCENE_LOADED = 0xC59F528E9AB9F339,
        HAS_THIS_CUTSCENE_LOADED = 0x228D3D94F8A11C3C,
        CAN_REQUEST_ASSETS_FOR_CUTSCENE_ENTITY = 0xB56BBBCC2955D9CB,
        IS_CUTSCENE_PLAYBACK_FLAG_SET = 0x71B74D2AE19338D0,
        SET_CUTSCENE_ENTITY_STREAMING_FLAGS = 0x4C61C75BEE8184C2,
        STOP_CUTSCENE = 0xC7272775B4DC786E,
        STOP_CUTSCENE_IMMEDIATELY = 0xD220BDD222AC4A1E,
        GET_CUTSCENE_TIME = 0xE625BEABBAFFDAB9,
        GET_CUTSCENE_TOTAL_DURATION = 0xEE53B14A19E480D4,
        WAS_CUTSCENE_SKIPPED = 0x40C8656EDAEDD569,
        HAS_CUTSCENE_FINISHED = 0x7C0A893088881D57,
        IS_CUTSCENE_ACTIVE = 0x991251AFC3981F84,
        IS_CUTSCENE_PLAYING = 0xD3C2E180A40F031E,
        GET_CUTSCENE_SECTION_PLAYING = 0x49010A6A396553D8,
        GET_ENTITY_INDEX_OF_CUTSCENE_ENTITY = 0x0A2E9FDB9A8C62F6,
        REGISTER_ENTITY_FOR_CUTSCENE = 0xE40C1C56DF95C2E8,
        GET_ENTITY_INDEX_OF_REGISTERED_ENTITY = 0xC0741A26499654CD,
        CAN_SET_EXIT_STATE_FOR_REGISTERED_ENTITY = 0x4C6A6451C79E4662,
        CAN_SET_EXIT_STATE_FOR_CAMERA = 0xB2CBCD0930DFB420,
        SET_CUTSCENE_FADE_VALUES = 0x8093F23ABACCC7D4,
        SET_CUTSCENE_CAN_BE_SKIPPED = 0x41FAA8FB2ECE8720,
        REGISTER_SYNCHRONISED_SCRIPT_SPEECH = 0x2131046957F31B04,
        SET_CUTSCENE_PED_COMPONENT_VARIATION_FROM_PED = 0x2A56C06EBEF2B0D9,
        DOES_CUTSCENE_ENTITY_EXIST = 0x499EF20C5DB25C59,
        _0x011883F41211432A = 0x011883F41211432A,
        _0x583DF8E3D4AFBD98 = 0x583DF8E3D4AFBD98,
        _0x4FCD976DA686580C = 0x4FCD976DA686580C,
        _0x20746F7B1032A3C7 = 0x20746F7B1032A3C7,
        _0x06EE9048FD080382 = 0x06EE9048FD080382,
        _0xA0FE76168A189DDB = 0xA0FE76168A189DDB,
        _0x2F137B508DE238F2 = 0x2F137B508DE238F2,
        _0xE36A98D8AB3D3C66 = 0xE36A98D8AB3D3C66,
        _0x5EDEF0CF8C1DAB3C = 0x5EDEF0CF8C1DAB3C,
    }
}