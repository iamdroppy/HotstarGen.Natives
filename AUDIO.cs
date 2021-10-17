using System;
namespace Hotstar
{
    public enum AUDIO : ulong
    { 
        /// <summary>
        /// All found occurrences in b617d, sorted alphabetically and identical lines removed: pastebin.com/RFb4GTny
        /// 
        /// AUDIO::PLAY_PED_RINGTONE("Remote_Ring", PLAYER::PLAYER_PED_ID(), 1);
        /// AUDIO::PLAY_PED_RINGTONE("Dial_and_Remote_Ring", PLAYER::PLAYER_PED_ID(), 1);
        /// 
        ///
        /// > const char* ringtoneName
        /// > Ped ped
        /// > BOOL p2
        ///
        /// </summary>
        PLAY_PED_RINGTONE = 0xF9E56683CA8E11A5,
        /// <summary>
        /// NOTE: ones that are -1, 0 - 35 are determined by a function where it gets a TextLabel from a global then runs,
        /// _GET_TEXT_SUBSTRING and depending on what the result is it goes in check order of 0 - 9 then A - Z then z (lowercase). So it will then return 0 - 35 or -1 if it's 'z'. The func to handle that ^^ is func_67 in dialog_handler.c atleast in TU27 Xbox360 scripts.
        /// 
        /// p0 is -1, 0 - 35
        /// p1 is a char or string (whatever you wanna call it)
        /// p2 is Global 10597 + i * 6. 'i' is a while(i < 70) loop
        /// p3 is again -1, 0 - 35 
        /// p4 is again -1, 0 - 35 
        /// p5 is either 0 or 1 (bool ?)
        /// p6 is either 0 or 1 (The func to determine this is bool)
        /// p7 is either 0 or 1 (The func to determine this is bool)
        /// p8 is either 0 or 1 (The func to determine this is bool)
        /// p9 is 0 - 3 (Determined by func_60 in dialogue_handler.c)
        /// p10 is either 0 or 1 (The func to determine this is bool)
        /// p11 is either 0 or 1 (The func to determine this is bool)
        /// p12 is unknown as in TU27 X360 scripts it only goes to p11.
        ///
        /// > int index
        /// > const char* p1
        /// > const char* p2
        /// > int p3
        /// > int p4
        /// > BOOL p5
        /// > BOOL p6
        /// > BOOL p7
        /// > BOOL p8
        /// > int p9
        /// > BOOL p10
        /// > BOOL p11
        /// > BOOL p12
        ///
        /// </summary>
        ADD_LINE_TO_CONVERSATION = 0xC5EF963405593646,
        /// <summary>
        /// 4 calls in the b617d scripts. The only one with p0 and p2 in clear text:
        /// 
        /// AUDIO::ADD_PED_TO_CONVERSATION(5, l_AF, "DINAPOLI");
        /// 
        /// =================================================
        /// One of the 2 calls in dialogue_handler.c p0 is in a while-loop, and so is determined to also possibly be 0 - 15.
        ///
        /// > int index
        /// > Ped ped
        /// > const char* p2
        ///
        /// </summary>
        ADD_PED_TO_CONVERSATION = 0x95D9F4BC443956E7,
        /// <summary>
        /// If this is the correct name, what microphone? I know your TV isn't going to reach out and adjust your headset so..
        ///
        /// > BOOL p0
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > float x3
        /// > float y3
        /// > float z3
        ///
        /// </summary>
        SET_MICROPHONE_POSITION = 0xB6AE90EDDE95C762,
        /// <summary>
        /// One call found in the b617d scripts:
        /// 
        /// AUDIO::_8A694D7A68F8DC38(NETWORK::NET_TO_PED(l_3989._f26F[0/*1*/]), "CONV_INTERRUPT_QUIT_IT", "LESTER");
        ///
        /// > Ped ped
        /// > const char* p1
        /// > const char* p2
        ///
        /// </summary>
        INTERRUPT_CONVERSATION_AND_PAUSE = 0x8A694D7A68F8DC38,
        /// <summary>
        /// This native does absolutely nothing, just a nullsub
        ///
        /// > int p0
        ///
        /// </summary>
        REGISTER_SCRIPT_WITH_AUDIO = 0xC6ED9D5092438D91,
        /// <summary>
        /// This native does absolutely nothing, just a nullsub
        ///
        ///
        /// </summary>
        UNREGISTER_SCRIPT_WITH_AUDIO = 0xA8638BE228D4751A,
        /// <summary>
        ///  All occurrences and usages found in b617d: pastebin.com/NzZZ2Tmm
        ///  
        ///
        /// > const char* p0
        /// > BOOL p1
        /// > Any p2
        ///
        /// </summary>
        REQUEST_MISSION_AUDIO_BANK = 0x7345BDD95E62E0F2,
        /// <summary>
        /// All occurrences and usages found in b617d, sorted alphabetically and identical lines removed: pastebin.com/XZ1tmGEz
        ///
        /// > const char* p0
        /// > BOOL p1
        /// > Any p2
        ///
        /// </summary>
        REQUEST_AMBIENT_AUDIO_BANK = 0xFE02FFBED8CA9D99,
        /// <summary>
        /// All occurrences and usages found in b617d, sorted alphabetically and identical lines removed: pastebin.com/AkmDAVn6
        ///
        /// > const char* p0
        /// > BOOL p1
        /// > int p2
        ///
        /// </summary>
        REQUEST_SCRIPT_AUDIO_BANK = 0x2F844A8B08D76685,
        /// <summary>
        /// All found occurrences in b617d, sorted alphabetically and identical lines removed: pastebin.com/A8Ny8AHZ
        /// 
        /// Full list of audio / sound names by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/soundNames.json
        ///
        /// > int soundId
        /// > const char* audioName
        /// > const char* audioRef
        /// > BOOL p3
        /// > Any p4
        /// > BOOL p5
        ///
        /// </summary>
        PLAY_SOUND = 0x7FF4944CC209192D,
        /// <summary>
        /// List: https://pastebin.com/DCeRiaLJ
        /// 
        /// All occurrences as of Cayo Perico Heist DLC (b2189), sorted alphabetically and identical lines removed: https://git.io/JtLxM
        /// 
        /// Full list of audio / sound names by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/soundNames.json
        ///
        /// > int soundId
        /// > const char* audioName
        /// > const char* audioRef
        /// > BOOL p3
        ///
        /// </summary>
        PLAY_SOUND_FRONTEND = 0x67C540AA08E4A6F5,
        /// <summary>
        /// Only call found in the b617d scripts:
        /// 
        /// AUDIO::PLAY_DEFERRED_SOUND_FRONTEND("BACK", "HUD_FREEMODE_SOUNDSET");
        /// 
        /// Full list of audio / sound names by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/soundNames.json
        ///
        /// > const char* soundName
        /// > const char* soundsetName
        ///
        /// </summary>
        PLAY_DEFERRED_SOUND_FRONTEND = 0xCADA5A0D0702381E,
        /// <summary>
        /// All found occurrences in b617d, sorted alphabetically and identical lines removed: pastebin.com/f2A7vTj0 
        /// No changes made in b678d.
        /// 
        /// gtaforums.com/topic/795622-audio-for-mods
        /// 
        /// Full list of audio / sound names by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/soundNames.json
        ///
        /// > int soundId
        /// > const char* audioName
        /// > Entity entity
        /// > const char* audioRef
        /// > BOOL isNetwork
        /// > Any p5
        ///
        /// </summary>
        PLAY_SOUND_FROM_ENTITY = 0xE65F427EB70AB1ED,
        /// <summary>
        /// All found occurrences in b617d, sorted alphabetically and identical lines removed: pastebin.com/eeFc5DiW
        /// 
        /// gtaforums.com/topic/795622-audio-for-mods
        /// 
        /// Full list of audio / sound names by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/soundNames.json
        ///
        /// > int soundId
        /// > const char* audioName
        /// > float x
        /// > float y
        /// > float z
        /// > const char* audioRef
        /// > BOOL isNetwork
        /// > int range
        /// > BOOL p8
        ///
        /// </summary>
        PLAY_SOUND_FROM_COORD = 0x8D8686B622B88120,
        /// <summary>
        /// Could this be used alongside either, 
        /// SET_NETWORK_ID_EXISTS_ON_ALL_MACHINES or _SET_NETWORK_ID_SYNC_TO_PLAYER to make it so other players can hear the sound while online? It'd be a bit troll-fun to be able to play the Zancudo UFO creepy sounds globally.
        ///
        /// > int soundId
        ///
        /// </summary>
        GET_NETWORK_ID_FROM_SOUND_ID = 0x2DE3F0A134FFBC0D,
        /// <summary>
        /// From the scripts, p0:
        /// 
        /// "ArmWrestlingIntensity",
        /// "INOUT",
        /// "Monkey_Stream",
        /// "ZoomLevel"
        ///
        /// > const char* p0
        /// > float p1
        ///
        /// </summary>
        SET_VARIABLE_ON_STREAM = 0x2F9D3834AEB9EF79,
        /// <summary>
        /// AUDIO::SET_VARIABLE_ON_UNDER_WATER_STREAM("inTunnel", 1.0);
        /// AUDIO::SET_VARIABLE_ON_UNDER_WATER_STREAM("inTunnel", 0.0);
        ///
        /// > const char* variableName
        /// > float value
        ///
        /// </summary>
        SET_VARIABLE_ON_UNDER_WATER_STREAM = 0x733ADF241531E5C2,
        /// <summary>
        /// Plays ambient speech. See also _0x444180DB.
        /// 
        /// ped: The ped to play the ambient speech.
        /// speechName: Name of the speech to play, eg. "GENERIC_HI".
        /// speechParam: Can be one of the following:
        /// SPEECH_PARAMS_STANDARD
        /// SPEECH_PARAMS_ALLOW_REPEAT
        /// SPEECH_PARAMS_BEAT
        /// SPEECH_PARAMS_FORCE
        /// SPEECH_PARAMS_FORCE_FRONTEND
        /// SPEECH_PARAMS_FORCE_NO_REPEAT_FRONTEND
        /// SPEECH_PARAMS_FORCE_NORMAL
        /// SPEECH_PARAMS_FORCE_NORMAL_CLEAR
        /// SPEECH_PARAMS_FORCE_NORMAL_CRITICAL
        /// SPEECH_PARAMS_FORCE_SHOUTED
        /// SPEECH_PARAMS_FORCE_SHOUTED_CLEAR
        /// SPEECH_PARAMS_FORCE_SHOUTED_CRITICAL
        /// SPEECH_PARAMS_FORCE_PRELOAD_ONLY
        /// SPEECH_PARAMS_MEGAPHONE
        /// SPEECH_PARAMS_HELI
        /// SPEECH_PARAMS_FORCE_MEGAPHONE
        /// SPEECH_PARAMS_FORCE_HELI
        /// SPEECH_PARAMS_INTERRUPT
        /// SPEECH_PARAMS_INTERRUPT_SHOUTED
        /// SPEECH_PARAMS_INTERRUPT_SHOUTED_CLEAR
        /// SPEECH_PARAMS_INTERRUPT_SHOUTED_CRITICAL
        /// SPEECH_PARAMS_INTERRUPT_NO_FORCE
        /// SPEECH_PARAMS_INTERRUPT_FRONTEND
        /// SPEECH_PARAMS_INTERRUPT_NO_FORCE_FRONTEND
        /// SPEECH_PARAMS_ADD_BLIP
        /// SPEECH_PARAMS_ADD_BLIP_ALLOW_REPEAT
        /// SPEECH_PARAMS_ADD_BLIP_FORCE
        /// SPEECH_PARAMS_ADD_BLIP_SHOUTED
        /// SPEECH_PARAMS_ADD_BLIP_SHOUTED_FORCE
        /// SPEECH_PARAMS_ADD_BLIP_INTERRUPT
        /// SPEECH_PARAMS_ADD_BLIP_INTERRUPT_FORCE
        /// SPEECH_PARAMS_FORCE_PRELOAD_ONLY_SHOUTED
        /// SPEECH_PARAMS_FORCE_PRELOAD_ONLY_SHOUTED_CLEAR
        /// SPEECH_PARAMS_FORCE_PRELOAD_ONLY_SHOUTED_CRITICAL
        /// SPEECH_PARAMS_SHOUTED
        /// SPEECH_PARAMS_SHOUTED_CLEAR
        /// SPEECH_PARAMS_SHOUTED_CRITICAL
        /// 
        /// Note: A list of Name and Parameters can be found here pastebin.com/1GZS5dCL
        /// 
        /// Full list of speeches and voices names by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/speeches.json
        ///
        /// > Ped ped
        /// > const char* speechName
        /// > const char* speechParam
        /// > Any p3
        ///
        /// </summary>
        PLAY_PED_AMBIENT_SPEECH_NATIVE = 0x8E04FEDD28D42462,
        /// <summary>
        /// Plays ambient speech. See also _0x5C57B85D.
        /// 
        /// See PLAY_PED_AMBIENT_SPEECH_NATIVE for parameter specifications.
        /// 
        /// Full list of speeches and voices names by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/speeches.json
        ///
        /// > Ped ped
        /// > const char* speechName
        /// > const char* speechParam
        /// > Any p3
        ///
        /// </summary>
        PLAY_PED_AMBIENT_SPEECH_AND_CLONE_NATIVE = 0xC6941B4A3A8FBBB9,
        /// <summary>
        /// This is the same as PLAY_PED_AMBIENT_SPEECH_NATIVE and PLAY_PED_AMBIENT_SPEECH_AND_CLONE_NATIVE but it will allow you to play a speech file from a specific voice file. It works on players and all peds, even animals.
        /// 
        /// EX (C#):
        /// GTA.Native.Function.Call(Hash._0x3523634255FC3318, Game.Player.Character, "GENERIC_INSULT_HIGH", "s_m_y_sheriff_01_white_full_01", "SPEECH_PARAMS_FORCE_SHOUTED", 0);
        /// 
        /// The first param is the ped you want to play it on, the second is the speech name, the third is the voice name, the fourth is the speech param, and the last param is usually always 0.
        /// 
        /// Full list of speeches and voices names by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/speeches.json
        ///
        /// > Ped ped
        /// > const char* speechName
        /// > const char* voiceName
        /// > const char* speechParam
        /// > BOOL p4
        ///
        /// </summary>
        PLAY_PED_AMBIENT_SPEECH_WITH_VOICE_NATIVE = 0x3523634255FC3318,
        /// <summary>
        /// Full list of speeches and voices names by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/speeches.json
        ///
        /// > const char* speechName
        /// > const char* voiceName
        /// > float x
        /// > float y
        /// > float z
        /// > const char* speechParam
        ///
        /// </summary>
        PLAY_AMBIENT_SPEECH_FROM_POSITION_NATIVE = 0xED640017ED337E45,
        /// <summary>
        /// This native enables the audio flag "TrevorRageIsOverridden" and sets the voice effect to `voiceEffect`
        ///
        /// > const char* voiceEffect
        ///
        /// </summary>
        OVERRIDE_TREVOR_RAGE = 0x13AD665062541A7E,
        /// <summary>
        /// Needs another parameter [int p2]. The signature is PED::PLAY_PAIN(Ped ped, int painID, int p1, int p2);
        /// 
        /// Last 2 parameters always seem to be 0.
        /// 
        /// EX: Function.Call(Hash.PLAY_PAIN, TestPed, 6, 0, 0);
        /// 
        /// Known Pain IDs
        /// ________________________
        /// 
        /// 1 - Doesn't seem to do anything. Does NOT crash the game like previously said. (Latest patch)
        /// 6 - Scream (Short)
        /// 7 - Scared Scream (Kinda Long)
        /// 8 - On Fire
        /// 
        ///
        /// > Ped ped
        /// > int painID
        /// > int p1
        /// > Any p3
        ///
        /// </summary>
        PLAY_PAIN = 0xBC9AE166038A5CEC,
        /// <summary>
        /// Audio List
        /// gtaforums.com/topic/795622-audio-for-mods/
        /// 
        /// All found occurrences in b617d, sorted alphabetically and identical lines removed: pastebin.com/FTeAj4yZ
        /// 
        /// Yes
        ///
        /// > Ped ped
        /// > const char* name
        ///
        /// </summary>
        SET_AMBIENT_VOICE_NAME = 0x6C8065A3B780185B,
        /// <summary>
        /// Assigns some ambient voice to the ped.
        ///
        /// > Ped ped
        ///
        /// </summary>
        _SET_PED_SCREAM = 0x40CF0D12D142A9E8,
        /// <summary>
        /// From the scripts:
        /// 
        /// AUDIO::_SET_PED_VOICE_GROUP(PLAYER::PLAYER_PED_ID(), MISC::GET_HASH_KEY("PAIGE_PVG"));
        /// AUDIO::_SET_PED_VOICE_GROUP(PLAYER::PLAYER_PED_ID(), MISC::GET_HASH_KEY("TALINA_PVG"));
        /// AUDIO::_SET_PED_VOICE_GROUP(PLAYER::PLAYER_PED_ID(), MISC::GET_HASH_KEY("FEMALE_LOST_BLACK_PVG"));
        /// AUDIO::_SET_PED_VOICE_GROUP(PLAYER::PLAYER_PED_ID(), MISC::GET_HASH_KEY("FEMALE_LOST_WHITE_PVG"));
        ///
        /// > Ped ped
        /// > Hash voiceGroupHash
        ///
        /// </summary>
        _SET_PED_VOICE_GROUP = 0x7CDC8C3B89F661B3,
        /// <summary>
        /// Checks if the ped can play the speech or has the speech file, last parameter is usually 0
        /// 
        /// DOES_C*
        ///
        /// > Ped ped
        /// > const char* speechName
        /// > BOOL unk
        ///
        /// </summary>
        _CAN_PED_SPEAK = 0x49B99BF3FDA89A7A,
        /// <summary>
        /// Sets the ped drunk sounds.  Only works with PLAYER_PED_ID
        /// 
        /// ====================================================
        /// 
        /// As mentioned above, this only sets the drunk sound to ped/player.
        /// 
        /// To give the Ped a drunk effect with drunk walking animation try using SET_PED_MOVEMENT_CLIPSET
        /// 
        /// Below is an example
        /// 
        /// if (!Function.Call<bool>(Hash.HAS_ANIM_SET_LOADED, "move_m@drunk@verydrunk"))
        ///                 {
        ///                     Function.Call(Hash.REQUEST_ANIM_SET, "move_m@drunk@verydrunk");
        ///                 }
        ///                 Function.Call(Hash.SET_PED_MOVEMENT_CLIPSET, Ped.Handle, "move_m@drunk@verydrunk", 0x3E800000);
        /// 
        /// 
        /// 
        /// And to stop the effect use
        /// RESET_PED_MOVEMENT_CLIPSET
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        SET_PED_IS_DRUNK = 0x95D2D383D5396B8A,
        /// <summary>
        /// Plays sounds from a ped with chop model. For example it used to play bark or sniff sounds. p1 is always 3 or 4294967295 in decompiled scripts. By a quick disassembling I can assume that this arg is unused.
        /// This native is works only when you call it on the ped with right model (ac_chop only ?)
        /// Speech Name can be: CHOP_SNIFF_SEQ CHOP_WHINE CHOP_LICKS_MOUTH CHOP_PANT bark GROWL SNARL BARK_SEQ
        ///
        /// > Ped pedHandle
        /// > int p1
        /// > const char* speechName
        ///
        /// </summary>
        PLAY_ANIMAL_VOCALIZATION = 0xEE066C7006C49C0A,
        /// <summary>
        /// mood can be 0 or 1 (it's not a boolean value!). Effects audio of the animal.
        ///
        /// > Ped animal
        /// > int mood
        ///
        /// </summary>
        SET_ANIMAL_MOOD = 0xCC97B29285B1DC3B,
        /// <summary>
        /// Returns 255 (radio off index) if the function fails.
        ///
        ///
        /// </summary>
        GET_PLAYER_RADIO_STATION_INDEX = 0xE8AF77C4C06ADC93,
        /// <summary>
        /// Returns active radio station name
        ///
        ///
        /// </summary>
        GET_PLAYER_RADIO_STATION_NAME = 0xF6D733C32076AD03,
        /// <summary>
        /// Converts radio station index to string. Use HUD::_GET_LABEL_TEXT to get the user-readable text.
        ///
        /// > int radioStation
        ///
        /// </summary>
        GET_RADIO_STATION_NAME = 0xB28ECA15046CA8B9,
        /// <summary>
        /// List of radio stations that are in the wheel, in clockwise order, as of LS Tuners DLC: https://git.io/J8a3k
        /// An older list including hidden radio stations: https://pastebin.com/Kj9t38KF
        ///
        /// > const char* stationName
        ///
        /// </summary>
        SET_RADIO_TO_STATION_NAME = 0xC69EDA28699D5107,
        /// <summary>
        /// List of radio stations that are in the wheel, in clockwise order, as of LS Tuners DLC: https://git.io/J8a3k
        /// An older list including hidden radio stations: https://pastebin.com/Kj9t38KF
        ///
        /// > Vehicle vehicle
        /// > const char* radioStation
        ///
        /// </summary>
        SET_VEH_RADIO_STATION = 0x1B9C0099CB942AC6,
        /// <summary>
        /// IS_VEHICLE_*
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _IS_VEHICLE_RADIO_ENABLED = 0x0BE4BE946463F917,
        /// <summary>
        /// Full list of static emitters by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/staticEmitters.json
        ///
        /// > const char* emitterName
        /// > const char* radioStation
        ///
        /// </summary>
        SET_EMITTER_RADIO_STATION = 0xACF57305B12AF907,
        /// <summary>
        /// Example:
        /// AUDIO::SET_STATIC_EMITTER_ENABLED((Any*)"LOS_SANTOS_VANILLA_UNICORN_01_STAGE", false);    AUDIO::SET_STATIC_EMITTER_ENABLED((Any*)"LOS_SANTOS_VANILLA_UNICORN_02_MAIN_ROOM", false);    AUDIO::SET_STATIC_EMITTER_ENABLED((Any*)"LOS_SANTOS_VANILLA_UNICORN_03_BACK_ROOM", false);
        /// 
        /// This turns off surrounding sounds not connected directly to peds.
        /// 
        /// Full list of static emitters by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/staticEmitters.json
        ///
        /// > const char* emitterName
        /// > BOOL toggle
        ///
        /// </summary>
        SET_STATIC_EMITTER_ENABLED = 0x399D2D3B33F1B8EB,
        /// <summary>
        /// L* (LINK_*?)
        /// 
        /// Full list of static emitters by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/staticEmitters.json
        ///
        /// > const char* emitterName
        /// > Entity entity
        ///
        /// </summary>
        _LINK_STATIC_EMITTER_TO_ENTITY = 0x651D3228960D08AF,
        /// <summary>
        /// Sets radio station by index.
        ///
        /// > int radioStation
        ///
        /// </summary>
        SET_RADIO_TO_STATION_INDEX = 0xA619B168B8A8570F,
        /// <summary>
        /// I see this as a native that would of been used back in GTA III when you finally unlocked the bridge to the next island and such.
        ///
        /// > int newsStory
        ///
        /// </summary>
        UNLOCK_MISSION_NEWS_STORY = 0xB165AB7C248B2DC1,
        /// <summary>
        /// Only found this one in the decompiled scripts:
        /// 
        /// AUDIO::SET_RADIO_TRACK("RADIO_03_HIPHOP_NEW", "ARM1_RADIO_STARTS");
        /// 
        ///
        /// > const char* radioStation
        /// > const char* radioTrack
        ///
        /// </summary>
        SET_RADIO_TRACK = 0xB39786F201FEE30B,
        /// <summary>
        /// can't seem to enable radio on cop cars etc
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        SET_VEHICLE_RADIO_ENABLED = 0x3B988190C0AA6C0B,
        /// <summary>
        /// Examples:
        /// 
        /// AUDIO::SET_CUSTOM_RADIO_TRACK_LIST("RADIO_01_CLASS_ROCK", "END_CREDITS_KILL_MICHAEL", 1);
        /// AUDIO::SET_CUSTOM_RADIO_TRACK_LIST("RADIO_01_CLASS_ROCK", "END_CREDITS_KILL_MICHAEL", 1);
        /// AUDIO::SET_CUSTOM_RADIO_TRACK_LIST("RADIO_01_CLASS_ROCK", "END_CREDITS_KILL_TREVOR", 1);
        /// AUDIO::SET_CUSTOM_RADIO_TRACK_LIST("RADIO_01_CLASS_ROCK", "END_CREDITS_SAVE_MICHAEL_TREVOR", 1);
        /// AUDIO::SET_CUSTOM_RADIO_TRACK_LIST("RADIO_01_CLASS_ROCK", "OFF_ROAD_RADIO_ROCK_LIST", 1);
        /// AUDIO::SET_CUSTOM_RADIO_TRACK_LIST("RADIO_06_COUNTRY", "MAGDEMO2_RADIO_DINGHY", 1);
        /// AUDIO::SET_CUSTOM_RADIO_TRACK_LIST("RADIO_16_SILVERLAKE", "SEA_RACE_RADIO_PLAYLIST", 1);
        /// AUDIO::SET_CUSTOM_RADIO_TRACK_LIST("RADIO_01_CLASS_ROCK", "OFF_ROAD_RADIO_ROCK_LIST", 1);
        ///
        /// > const char* radioStation
        /// > const char* trackListName
        /// > BOOL p2
        ///
        /// </summary>
        SET_CUSTOM_RADIO_TRACK_LIST = 0x4E404A9361F75BB2,
        /// <summary>
        /// 3 calls in the b617d scripts, removed duplicate.
        /// 
        /// AUDIO::CLEAR_CUSTOM_RADIO_TRACK_LIST("RADIO_16_SILVERLAKE");
        /// AUDIO::CLEAR_CUSTOM_RADIO_TRACK_LIST("RADIO_01_CLASS_ROCK");
        ///
        /// > const char* radioStation
        ///
        /// </summary>
        CLEAR_CUSTOM_RADIO_TRACK_LIST = 0x1654F24A88A8E3FE,
        /// <summary>
        /// 6 calls in the b617d scripts, removed identical lines:
        /// 
        /// AUDIO::SET_RADIO_STATION_MUSIC_ONLY("RADIO_01_CLASS_ROCK", 1);
        /// AUDIO::SET_RADIO_STATION_MUSIC_ONLY(AUDIO::GET_RADIO_STATION_NAME(10), 0);
        /// AUDIO::SET_RADIO_STATION_MUSIC_ONLY(AUDIO::GET_RADIO_STATION_NAME(10), 1);
        ///
        /// > const char* radioStation
        /// > BOOL toggle
        ///
        /// </summary>
        SET_RADIO_STATION_MUSIC_ONLY = 0x774BD811F656A122,
        /// <summary>
        /// AUDIO::UNLOCK_RADIO_STATION_TRACK_LIST("RADIO_16_SILVERLAKE", "MIRRORPARK_LOCKED");
        ///
        /// > const char* radioStation
        /// > const char* trackListName
        ///
        /// </summary>
        UNLOCK_RADIO_STATION_TRACK_LIST = 0x031ACB6ABA18C729,
        /// <summary>
        /// Just a nullsub (i.e. does absolutely nothing) since build 1604.
        ///
        /// > BOOL enableMixes
        ///
        /// </summary>
        _UPDATE_LSUR = 0x47AED84213A47510,
        /// <summary>
        /// Disables the radio station (hides it from the radio wheel).
        ///
        /// > const char* radioStationName
        /// > BOOL toggle
        ///
        /// </summary>
        _LOCK_RADIO_STATION = 0x477D9DB48F889591,
        /// <summary>
        /// Doesn't have an effect in Story Mode.
        ///
        /// > const char* radioStation
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_RADIO_STATION_IS_VISIBLE = 0x4CAFEBFA21EC188D,
        /// <summary>
        /// GET_CURRENT_*
        /// Seems to return hashed radio station name?
        ///
        /// > const char* radioStationName
        ///
        /// </summary>
        _GET_CURRENT_RADIO_STATION_HASH = 0x3E65CDE5215832C1,
        /// <summary>
        /// Full list of ambient zones by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/ambientZones.json
        ///
        /// > const char* zoneName
        /// > BOOL p1
        /// > BOOL p2
        ///
        /// </summary>
        SET_AMBIENT_ZONE_STATE = 0xBDA07E5950085E46,
        /// <summary>
        /// This function also has a p2, unknown. Signature AUDIO::CLEAR_AMBIENT_ZONE_STATE(const char* zoneName, bool p1, Any p2);
        /// 
        /// Still needs more research.
        /// 
        /// Full list of ambient zones by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/ambientZones.json
        ///
        /// > const char* zoneName
        /// > BOOL p1
        ///
        /// </summary>
        CLEAR_AMBIENT_ZONE_STATE = 0x218DD44AAAC964FF,
        /// <summary>
        /// Full list of ambient zones by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/ambientZones.json
        ///
        /// > const char* ambientZone
        /// > BOOL p1
        /// > BOOL p2
        ///
        /// </summary>
        SET_AMBIENT_ZONE_STATE_PERSISTENT = 0x1D6650420CEC9D3B,
        /// <summary>
        /// Full list of ambient zones by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/ambientZones.json
        ///
        /// > const char* ambientZone
        /// > BOOL p1
        /// > BOOL p2
        ///
        /// </summary>
        SET_AMBIENT_ZONE_LIST_STATE_PERSISTENT = 0xF3638DAE8C4045E1,
        /// <summary>
        /// Full list of ambient zones by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/ambientZones.json
        ///
        /// > const char* ambientZone
        ///
        /// </summary>
        IS_AMBIENT_ZONE_ENABLED = 0x01E2817A479A7F9B,
        /// <summary>
        /// All occurrences found in b617d, sorted alphabetically and identical lines removed: 
        /// 
        /// AUDIO::SET_CUTSCENE_AUDIO_OVERRIDE("_AK");
        /// AUDIO::SET_CUTSCENE_AUDIO_OVERRIDE("_CUSTOM");
        /// AUDIO::SET_CUTSCENE_AUDIO_OVERRIDE("_TOOTHLESS");
        ///
        /// > const char* name
        ///
        /// </summary>
        SET_CUTSCENE_AUDIO_OVERRIDE = 0x3B4BF5F0859204D9,
        /// <summary>
        /// SET_VARIABLE_ON_*
        ///
        /// > const char* variableName
        /// > float value
        ///
        /// </summary>
        _SET_VARIABLE_ON_CUTSCENE_AUDIO = 0xBCC29F935ED07688,
        /// <summary>
        /// Plays the given police radio message.
        /// 
        /// All found occurrences in b617d, sorted alphabetically and identical lines removed: pastebin.com/GBnsQ5hr
        ///
        /// > const char* name
        /// > float p1
        ///
        /// </summary>
        PLAY_POLICE_REPORT = 0xDFEBD56D9BD1EB16,
        /// <summary>
        /// Plays the siren sound of a vehicle which is otherwise activated when fastly double-pressing the horn key.
        /// Only works on vehicles with a police siren.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        BLIP_SIREN = 0x1B9025BDA76822B6,
        /// <summary>
        /// Overrides the vehicle's horn hash.
        /// When changing this hash on a vehicle, it will not return the 'overwritten' hash. It will still always return the default horn hash (same as GET_VEHICLE_DEFAULT_HORN)
        /// 
        /// vehicle - the vehicle whose horn should be overwritten
        /// mute - p1 seems to be an option for muting the horn
        /// p2 - maybe a horn id, since the function AUDIO::GET_VEHICLE_DEFAULT_HORN(veh) exists?
        ///
        /// > Vehicle vehicle
        /// > BOOL override
        /// > int hornHash
        ///
        /// </summary>
        OVERRIDE_VEH_HORN = 0x3CDC1E622CCE0356,
        /// <summary>
        /// Checks whether the horn of a vehicle is currently played.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        IS_HORN_ACTIVE = 0x9D6BFC12B05C6121,
        /// <summary>
        /// Makes pedestrians sound their horn longer, faster and more agressive when they use their horn.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_AGGRESSIVE_HORNS = 0x395BF71085D1B1D9,
        /// <summary>
        /// Example:
        /// AUDIO::LOAD_STREAM("CAR_STEAL_1_PASSBY", "CAR_STEAL_1_SOUNDSET");
        /// 
        /// All found occurrences in the b678d decompiled scripts: pastebin.com/3rma6w5w
        /// 
        /// Stream names often ends with "_MASTER", "_SMALL" or "_STREAM". Also "_IN", "_OUT" and numbers.   
        /// 
        /// soundSet is often set to 0 in the scripts. These are common to end the soundSets: "_SOUNDS", "_SOUNDSET" and numbers.
        /// 
        /// Full list of audio / sound names by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/soundNames.json
        ///
        /// > const char* streamName
        /// > const char* soundSet
        ///
        /// </summary>
        LOAD_STREAM = 0x1F1F957154EC51DF,
        /// <summary>
        /// Example:
        /// AUDIO::LOAD_STREAM_WITH_START_OFFSET("STASH_TOXIN_STREAM", 2400, "FBI_05_SOUNDS");
        /// 
        /// Only called a few times in the scripts.
        /// 
        /// Full list of audio / sound names by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/soundNames.json
        ///
        /// > const char* streamName
        /// > int startOffset
        /// > const char* soundSet
        ///
        /// </summary>
        LOAD_STREAM_WITH_START_OFFSET = 0x59C16B79F53B3712,
        /// <summary>
        /// Used with AUDIO::LOAD_STREAM
        /// 
        /// Example from finale_heist2b.c4:
        /// TASK::TASK_SYNCHRONIZED_SCENE(l_4C8[2/*14*/], l_4C8[2/*14*/]._f7, l_30A, "push_out_vault_l", 4.0, -1.5, 5, 713, 4.0, 0);
        ///                     PED::SET_SYNCHRONIZED_SCENE_PHASE(l_4C8[2/*14*/]._f7, 0.0);
        ///                     PED::_2208438012482A1A(l_4C8[2/*14*/], 0, 0);
        ///                     PED::SET_PED_COMBAT_ATTRIBUTES(l_4C8[2/*14*/], 38, 1);
        ///                     PED::SET_BLOCKING_OF_NON_TEMPORARY_EVENTS(l_4C8[2/*14*/], 1);
        ///                     if (AUDIO::LOAD_STREAM("Gold_Cart_Push_Anim_01", "BIG_SCORE_3B_SOUNDS")) {
        ///                         AUDIO::PLAY_STREAM_FROM_OBJECT(l_36F[0/*1*/]);
        ///                     }
        ///
        /// > Object object
        ///
        /// </summary>
        PLAY_STREAM_FROM_OBJECT = 0xEBAA9B64D76356FD,
        /// <summary>
        /// Common in the scripts:
        /// AUDIO::IS_AMBIENT_SPEECH_DISABLED(PLAYER::PLAYER_PED_ID());
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_AMBIENT_SPEECH_DISABLED = 0x932C2D096A2C3FFF,
        /// <summary>
        /// SET_*
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _SOUND_VEHICLE_HORN_THIS_FRAME = 0x9C11908013EA4715,
        /// <summary>
        /// This native sets the audio of the specified vehicle to the audioName (p1).
        /// 
        /// Use the audioNameHash found in vehicles.meta
        /// 
        /// Example:
        /// _SET_VEHICLE_AUDIO(veh, "ADDER");
        /// The selected vehicle will now have the audio of the Adder.
        /// 
        /// FORCE_VEHICLE_???
        ///
        /// > Vehicle vehicle
        /// > const char* audioName
        ///
        /// </summary>
        _FORCE_VEHICLE_ENGINE_AUDIO = 0x4F0C413926060B38,
        /// <summary>
        /// SET_VEHICLE_BOOST_ACTIVE(vehicle, 1, 0);
        /// SET_VEHICLE_BOOST_ACTIVE(vehicle, 0, 0); 
        /// 
        /// Will give a boost-soundeffect.
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        SET_VEHICLE_BOOST_ACTIVE = 0x4A04DE7CAB2739A1,
        /// <summary>
        /// doorId: see SET_VEHICLE_DOOR_SHUT
        ///
        /// > Vehicle vehicle
        /// > int doorId
        ///
        /// </summary>
        PLAY_VEHICLE_DOOR_OPEN_SOUND = 0x3A539D52857EA82D,
        /// <summary>
        /// doorId: see SET_VEHICLE_DOOR_SHUT
        ///
        /// > Vehicle vehicle
        /// > int doorId
        ///
        /// </summary>
        PLAY_VEHICLE_DOOR_CLOSE_SOUND = 0x62A456AA4769EF34,
        /// <summary>
        /// Works for planes only.
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        ENABLE_STALL_WARNING_SOUNDS = 0xC15907D667F7CFB2,
        /// <summary>
        /// Hardcoded to return 1
        ///
        ///
        /// </summary>
        IS_GAME_IN_CONTROL_OF_MUSIC = 0x6D28DC1671E334FD,
        /// <summary>
        /// Called 38 times in the scripts. There are 5 different audioNames used.
        ///  One unknown removed below.
        /// 
        /// AUDIO::PLAY_MISSION_COMPLETE_AUDIO("DEAD");
        /// AUDIO::PLAY_MISSION_COMPLETE_AUDIO("FRANKLIN_BIG_01");
        /// AUDIO::PLAY_MISSION_COMPLETE_AUDIO("GENERIC_FAILED");
        /// AUDIO::PLAY_MISSION_COMPLETE_AUDIO("TREVOR_SMALL_01");
        ///
        /// > const char* audioName
        ///
        /// </summary>
        PLAY_MISSION_COMPLETE_AUDIO = 0xB138AAB8A70D3C69,
        /// <summary>
        /// Used to prepare a scene where the surrounding sound is muted or a bit changed. This does not play any sound.
        /// 
        /// List of all usable scene names found in b617d. Sorted alphabetically and identical names removed: pastebin.com/MtM9N9CC
        ///
        /// > const char* scene
        ///
        /// </summary>
        START_AUDIO_SCENE = 0x013A80FC08F6E4F2,
        /// <summary>
        /// ??
        ///
        ///
        /// </summary>
        STOP_AUDIO_SCENES = 0xBAC7FC81A75EC1A1,
        /// <summary>
        /// All found occurrences in b678d:
        /// pastebin.com/ceu67jz8
        ///
        /// > Entity entity
        /// > const char* groupName
        /// > float p2
        ///
        /// </summary>
        ADD_ENTITY_TO_AUDIO_MIX_GROUP = 0x153973AB99FE8980,
        /// <summary>
        /// All music event names found in the b617d scripts: pastebin.com/GnYt0R3P
        ///
        /// > const char* eventName
        ///
        /// </summary>
        PREPARE_MUSIC_EVENT = 0x1E5185B72EF5158A,
        /// <summary>
        /// All music event names found in the b617d scripts: pastebin.com/GnYt0R3P
        ///
        /// > const char* eventName
        ///
        /// </summary>
        CANCEL_MUSIC_EVENT = 0x5B17A90291133DA5,
        /// <summary>
        /// List of all usable event names found in b617d used with this native. Sorted alphabetically and identical names removed: pastebin.com/RzDFmB1W
        /// 
        /// All music event names found in the b617d scripts: pastebin.com/GnYt0R3P
        ///
        /// > const char* eventName
        ///
        /// </summary>
        TRIGGER_MUSIC_EVENT = 0x706D57B0F50DA710,
        /// <summary>
        /// Example:
        /// 
        /// bool prepareAlarm = AUDIO::PREPARE_ALARM("PORT_OF_LS_HEIST_FORT_ZANCUDO_ALARMS");
        ///
        /// > const char* alarmName
        ///
        /// </summary>
        PREPARE_ALARM = 0x9D74AE343DB65533,
        /// <summary>
        /// Example:
        /// 
        /// This will start the alarm at Fort Zancudo.
        /// 
        /// AUDIO::START_ALARM("PORT_OF_LS_HEIST_FORT_ZANCUDO_ALARMS", 1);
        /// 
        /// First parameter (char) is the name of the alarm.
        /// Second parameter (bool) is unknown, it does not seem to make a difference if this one is 0 or 1.
        /// 
        /// ----------
        /// 
        /// It DOES make a difference but it has to do with the duration or something I dunno yet
        /// 
        /// ----------
        /// 
        ///  Found in the b617d scripts:
        /// 
        ///  AUDIO::START_ALARM("AGENCY_HEIST_FIB_TOWER_ALARMS", 0);
        ///  AUDIO::START_ALARM("AGENCY_HEIST_FIB_TOWER_ALARMS_UPPER", 1);
        ///  AUDIO::START_ALARM("AGENCY_HEIST_FIB_TOWER_ALARMS_UPPER_B", 0);
        ///  AUDIO::START_ALARM("BIG_SCORE_HEIST_VAULT_ALARMS", a_0);
        ///  AUDIO::START_ALARM("FBI_01_MORGUE_ALARMS", 1);
        ///  AUDIO::START_ALARM("FIB_05_BIOTECH_LAB_ALARMS", 0);
        ///  AUDIO::START_ALARM("JEWEL_STORE_HEIST_ALARMS", 0);
        ///  AUDIO::START_ALARM("PALETO_BAY_SCORE_ALARM", 1);
        ///  AUDIO::START_ALARM("PALETO_BAY_SCORE_CHICKEN_FACTORY_ALARM", 0);
        ///  AUDIO::START_ALARM("PORT_OF_LS_HEIST_FORT_ZANCUDO_ALARMS", 1);
        ///  AUDIO::START_ALARM("PORT_OF_LS_HEIST_SHIP_ALARMS", 0);
        ///  AUDIO::START_ALARM("PRISON_ALARMS", 0);
        ///  AUDIO::START_ALARM("PROLOGUE_VAULT_ALARMS", 0);
        ///
        /// > const char* alarmName
        /// > BOOL p2
        ///
        /// </summary>
        START_ALARM = 0x0355EF116C4C97B2,
        /// <summary>
        /// Example:
        /// 
        /// This will stop the alarm at Fort Zancudo.
        /// 
        /// AUDIO::STOP_ALARM("PORT_OF_LS_HEIST_FORT_ZANCUDO_ALARMS", 1);
        /// 
        /// First parameter (char) is the name of the alarm.
        /// Second parameter (bool) has to be true (1) to have any effect.
        ///
        /// > const char* alarmName
        /// > BOOL toggle
        ///
        /// </summary>
        STOP_ALARM = 0xA1CADDCD98415A41,
        /// <summary>
        /// Example:
        /// 
        /// bool playing = AUDIO::IS_ALARM_PLAYING("PORT_OF_LS_HEIST_FORT_ZANCUDO_ALARMS");
        ///
        /// > const char* alarmName
        ///
        /// </summary>
        IS_ALARM_PLAYING = 0x226435CB96CCFC8C,
        /// <summary>
        /// Returns hash of default vehicle horn
        /// 
        /// Hash is stored in audVehicleAudioEntity
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_VEHICLE_DEFAULT_HORN = 0x02165D55000219AC,
        /// <summary>
        /// Enables/disables ped's "loud" footstep sound.
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_PED_AUDIO_FOOTSTEP_LOUD = 0x0653B735BFBDFE87,
        /// <summary>
        /// Enables/disables ped's "quiet" footstep sound.
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_PED_AUDIO_FOOTSTEP_QUIET = 0x29DA3CA8D8B2692D,
        /// <summary>
        /// Sets audio flag "OverridePlayerGroundMaterial"
        ///
        /// > Hash hash
        /// > BOOL toggle
        ///
        /// </summary>
        OVERRIDE_PLAYER_GROUND_MATERIAL = 0xD2CC78CD3D0B50F9,
        /// <summary>
        /// Sets audio flag "OverrideMicrophoneSettings"
        ///
        /// > Hash hash
        /// > BOOL toggle
        ///
        /// </summary>
        _OVERRIDE_MICROPHONE_SETTINGS = 0x75773E11BA459E90,
        /// <summary>
        /// If value is set to true, and ambient siren sound will be played.
        /// Appears to enable/disable an audio flag.
        ///
        /// > BOOL value
        ///
        /// </summary>
        DISTANT_COP_CAR_SIRENS = 0x552369F549563AD5,
        /// <summary>
        /// Possible flag names:
        /// "ActivateSwitchWheelAudio"
        /// "AllowAmbientSpeechInSlowMo"
        /// "AllowCutsceneOverScreenFade"
        /// "AllowForceRadioAfterRetune"
        /// "AllowPainAndAmbientSpeechToPlayDuringCutscene"
        /// "AllowPlayerAIOnMission"
        /// "AllowPoliceScannerWhenPlayerHasNoControl"
        /// "AllowRadioDuringSwitch"
        /// "AllowRadioOverScreenFade"
        /// "AllowScoreAndRadio"
        /// "AllowScriptedSpeechInSlowMo"
        /// "AvoidMissionCompleteDelay"
        /// "DisableAbortConversationForDeathAndInjury"
        /// "DisableAbortConversationForRagdoll"
        /// "DisableBarks"
        /// "DisableFlightMusic"
        /// "DisableReplayScriptStreamRecording"
        /// "EnableHeadsetBeep"
        /// "ForceConversationInterrupt"
        /// "ForceSeamlessRadioSwitch"
        /// "ForceSniperAudio"
        /// "FrontendRadioDisabled"
        /// "HoldMissionCompleteWhenPrepared"
        /// "IsDirectorModeActive"
        /// "IsPlayerOnMissionForSpeech"
        /// "ListenerReverbDisabled"
        /// "LoadMPData"
        /// "MobileRadioInGame"
        /// "OnlyAllowScriptTriggerPoliceScanner"
        /// "PlayMenuMusic"
        /// "PoliceScannerDisabled"
        /// "ScriptedConvListenerMaySpeak"
        /// "SpeechDucksScore"
        /// "SuppressPlayerScubaBreathing"
        /// "WantedMusicDisabled"
        /// "WantedMusicOnMission"
        /// 
        /// -------------------------------
        /// No added flag names between b393d and b573d, including b573d.
        /// 
        /// #######################################################################
        /// 
        /// "IsDirectorModeActive" is an audio flag which will allow you to play speech infinitely without any pauses like in Director Mode.
        /// 
        /// -----------------------------------------------------------------------
        /// 
        /// All flag IDs and hashes:
        /// 
        /// ID: 00 | Hash: 0x0FED7A7F
        /// ID: 01 | Hash: 0x20A7858F
        /// ID: 02 | Hash: 0xA11C2259
        /// ID: 03 | Hash: 0x08DE4700
        /// ID: 04 | Hash: 0x989F652F
        /// ID: 05 | Hash: 0x3C9E76BA
        /// ID: 06 | Hash: 0xA805FEB0
        /// ID: 07 | Hash: 0x4B94EA26
        /// ID: 08 | Hash: 0x803ACD34
        /// ID: 09 | Hash: 0x7C741226
        /// ID: 10 | Hash: 0x31DB9EBD
        /// ID: 11 | Hash: 0xDF386F18
        /// ID: 12 | Hash: 0x669CED42
        /// ID: 13 | Hash: 0x51F22743
        /// ID: 14 | Hash: 0x2052B35C
        /// ID: 15 | Hash: 0x071472DC
        /// ID: 16 | Hash: 0xF9928BCC
        /// ID: 17 | Hash: 0x7ADBDD48
        /// ID: 18 | Hash: 0xA959BA1A
        /// ID: 19 | Hash: 0xBBE89B60
        /// ID: 20 | Hash: 0x87A08871
        /// ID: 21 | Hash: 0xED1057CE
        /// ID: 22 | Hash: 0x1584AD7A
        /// ID: 23 | Hash: 0x8582CFCB
        /// ID: 24 | Hash: 0x7E5E2FB0
        /// ID: 25 | Hash: 0xAE4F72DB
        /// ID: 26 | Hash: 0x5D16D1FA
        /// ID: 27 | Hash: 0x06B2F4B8
        /// ID: 28 | Hash: 0x5D4CDC96
        /// ID: 29 | Hash: 0x8B5A48BA
        /// ID: 30 | Hash: 0x98FBD539
        /// ID: 31 | Hash: 0xD8CB0473
        /// ID: 32 | Hash: 0x5CBB4874
        /// ID: 33 | Hash: 0x2E9F93A9
        /// ID: 34 | Hash: 0xD93BEA86
        /// ID: 35 | Hash: 0x92109B7D
        /// ID: 36 | Hash: 0xB7EC9E4D
        /// ID: 37 | Hash: 0xCABDBB1D
        /// ID: 38 | Hash: 0xB3FD4A52
        /// ID: 39 | Hash: 0x370D94E5
        /// ID: 40 | Hash: 0xA0F7938F
        /// ID: 41 | Hash: 0xCBE1CE81
        /// ID: 42 | Hash: 0xC27F1271
        /// ID: 43 | Hash: 0x9E3258EB
        /// ID: 44 | Hash: 0x551CDA5B
        /// ID: 45 | Hash: 0xCB6D663C
        /// ID: 46 | Hash: 0x7DACE87F
        /// ID: 47 | Hash: 0xF9DE416F
        /// ID: 48 | Hash: 0x882E6E9E
        /// ID: 49 | Hash: 0x16B447E7
        /// ID: 50 | Hash: 0xBD867739
        /// ID: 51 | Hash: 0xA3A58604
        /// ID: 52 | Hash: 0x7E046BBC
        /// ID: 53 | Hash: 0xD95FDB98
        /// ID: 54 | Hash: 0x5842C0ED
        /// ID: 55 | Hash: 0x285FECC6
        /// ID: 56 | Hash: 0x9351AC43
        /// ID: 57 | Hash: 0x50032E75
        /// ID: 58 | Hash: 0xAE6D0D59
        /// ID: 59 | Hash: 0xD6351785
        /// ID: 60 | Hash: 0xD25D71BC
        /// ID: 61 | Hash: 0x1F7F6423
        /// ID: 62 | Hash: 0xE24C3AA6
        /// ID: 63 | Hash: 0xBFFDD2B7
        ///
        /// > const char* flagName
        /// > BOOL toggle
        ///
        /// </summary>
        SET_AUDIO_FLAG = 0xB9EFD5C25018725A,
        /// <summary>
        /// Sets the position of the audio event to the entity's position for one frame(?)
        /// 
        /// if (l_8C3 == 0) {
        ///     sub_27fd1(0, -1, 1);
        ///     if (PED::IS_SYNCHRONIZED_SCENE_RUNNING(l_87D)) {
        ///         AUDIO::STOP_SYNCHRONIZED_AUDIO_EVENT(l_87D);
        ///     }
        ///     if (sub_7dd(l_A00)) {
        ///         AUDIO::_950A154B8DAB6185("PAP2_IG1_POPPYSEX", l_A00);
        ///     }
        ///     sub_91c("TK************ SETTING SYNCH SCENE AUDIO POSITION THIS FRAME ************TK");
        ///     l_8C3 = 1;
        /// }
        /// 
        /// --
        /// 
        /// Found in the b617d scripts, duplicates removed: 
        /// 
        /// AUDIO::_950A154B8DAB6185("CAR_5_IG_6", l_7FE[1/*1*/]);
        /// AUDIO::_950A154B8DAB6185("EX03_TRAIN_BIKE_LAND",   PLAYER::PLAYER_PED_ID());
        /// AUDIO::_950A154B8DAB6185("FBI_2_MCS_1_LeadIn", l_40[2/*1*/]);
        /// AUDIO::_950A154B8DAB6185("FIN_C2_MCS_1", l_24C[0/*1*/]);
        /// AUDIO::_950A154B8DAB6185("MNT_DNC", l_5F);
        /// AUDIO::_950A154B8DAB6185("PAP2_IG1_POPPYSEX", l_A00);
        ///
        /// > const char* p0
        /// > Entity p1
        ///
        /// </summary>
        _SET_SYNCHRONIZED_AUDIO_EVENT_POSITION_THIS_FRAME = 0x950A154B8DAB6185,
        /// <summary>
        /// Needs to be called every frame.
        /// Audio mode to apply this frame: https://alloc8or.re/gta5/doc/enums/audSpecialEffectMode.txt
        ///
        /// > int mode
        ///
        /// </summary>
        SET_AUDIO_SPECIAL_EFFECT_MODE = 0x12561FCBB62D5B9C,
        /// <summary>
        /// Found in the b617d scripts, duplicates removed:  
        /// 
        /// AUDIO::_044DBAD7A7FA2BE5("V_CARSHOWROOM_PS_WINDOW_UNBROKEN", "V_CARSHOWROOM_PS_WINDOW_BROKEN");
        /// 
        ///  AUDIO::_044DBAD7A7FA2BE5("V_CIA_PS_WINDOW_UNBROKEN", "V_CIA_PS_WINDOW_BROKEN");
        /// 
        ///  AUDIO::_044DBAD7A7FA2BE5("V_DLC_HEIST_APARTMENT_DOOR_CLOSED", "V_DLC_HEIST_APARTMENT_DOOR_OPEN");
        /// 
        ///  AUDIO::_044DBAD7A7FA2BE5("V_FINALEBANK_PS_VAULT_INTACT", "V_FINALEBANK_PS_VAULT_BLOWN");
        /// 
        ///  AUDIO::_044DBAD7A7FA2BE5("V_MICHAEL_PS_BATHROOM_WITH_WINDOW", "V_MICHAEL_PS_BATHROOM_WITHOUT_WINDOW");
        ///
        /// > const char* p0
        /// > const char* p1
        ///
        /// </summary>
        SET_PORTAL_SETTINGS_OVERRIDE = 0x044DBAD7A7FA2BE5,
        /// <summary>
        ///  Found in the b617d scripts, duplicates removed: 
        /// 
        ///  AUDIO::_B4BBFD9CD8B3922B("V_CARSHOWROOM_PS_WINDOW_UNBROKEN");
        ///  AUDIO::_B4BBFD9CD8B3922B("V_CIA_PS_WINDOW_UNBROKEN");
        ///  AUDIO::_B4BBFD9CD8B3922B("V_DLC_HEIST_APARTMENT_DOOR_CLOSED");
        ///  AUDIO::_B4BBFD9CD8B3922B("V_FINALEBANK_PS_VAULT_INTACT");
        ///  AUDIO::_B4BBFD9CD8B3922B("V_MICHAEL_PS_BATHROOM_WITH_WINDOW");
        ///
        /// > const char* p0
        ///
        /// </summary>
        REMOVE_PORTAL_SETTINGS_OVERRIDE = 0xB4BBFD9CD8B3922B,
        /// <summary>
        /// HAS_*
        ///
        ///
        /// </summary>
        _HAS_MULTIPLAYER_AUDIO_DATA_LOADED = 0x544810ED9DB6BBE6,
        /// <summary>
        /// HAS_*
        ///
        ///
        /// </summary>
        _HAS_MULTIPLAYER_AUDIO_DATA_UNLOADED = 0x5B50ABB1FE3746F4,
        /// <summary>
        /// IS_MOBILE_PHONE_*
        ///
        ///
        /// </summary>
        _0xC8B1B2425604CDD0 = 0xC8B1B2425604CDD0,
        /// <summary>
        /// Tune Forward... ?
        /// 
        /// SET_RADIO_*
        ///
        ///
        /// </summary>
        _0xFF266D1D0EB1195D = 0xFF266D1D0EB1195D,
        /// <summary>
        /// Tune Backwards... ?
        /// 
        /// SET_RADIO_*
        ///
        ///
        /// </summary>
        _0xDD6BCF9E94425DF9 = 0xDD6BCF9E94425DF9,
        /// <summary>
        /// SET_VEH*
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _0xC1805D05E6D4FE10 = 0xC1805D05E6D4FE10,
        /// <summary>
        /// GET_NE*
        /// Gets values from the radio?
        ///
        /// > float* p0
        /// > float* p1
        /// > int* p2
        ///
        /// </summary>
        _0xC64A06D939F826F5 = 0xC64A06D939F826F5,
        /// <summary>
        /// GET_CURRENT_*
        ///
        /// > const char* radioStationName
        ///
        /// </summary>
        _0x34D66BC058019CE0 = 0x34D66BC058019CE0,
        /// <summary>
        /// SET_VEHICLE_*
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        _0xF3365489E0DD50F9 = 0xF3365489E0DD50F9,
        /// <summary>
        /// Does nothing (it's a nullsub).
        ///
        /// > BOOL p0
        ///
        /// </summary>
        _0x02E93C796ABD3A97 = 0x02E93C796ABD3A97,
        /// <summary>
        /// SET_VEHICLE_CONVERSATIONS_PERSIST?
        ///
        /// > BOOL p0
        /// > BOOL p1
        ///
        /// </summary>
        _0x58BB377BEC7CD5F4 = 0x58BB377BEC7CD5F4,
        /// <summary>
        /// BL*
        ///
        /// > Ped ped
        /// > BOOL p1
        /// > BOOL p2
        ///
        /// </summary>
        _0xF8AD2EED7C47E8FE = 0xF8AD2EED7C47E8FE,
        /// <summary>
        /// SET_H*
        ///
        /// > Vehicle vehicle
        /// > float p1
        ///
        /// </summary>
        _0x9D3AF56E94C9AE98 = 0x9D3AF56E94C9AE98,
        /// <summary>
        /// SET_P*
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        _0x6FDDAD856E36988A = 0x6FDDAD856E36988A,
        /// <summary>
        /// Something like UPDATE_PED_*
        ///
        /// > Ped ped
        /// > BOOL p1
        /// > Hash hash
        ///
        /// </summary>
        _0xBF4DC1784BE94DFA = 0xBF4DC1784BE94DFA,
        /// <summary>
        /// STOP_S[MOKE_GRENADE_EXPLOSION_SOUNDS]?
        ///
        ///
        /// </summary>
        _0xE4E6DD5566D28C82 = 0xE4E6DD5566D28C82,
        IS_PED_RINGTONE_PLAYING = 0x1E8E5E20937E3137,
        STOP_PED_RINGTONE = 0x6C5AE23EFA885092,
        IS_MOBILE_PHONE_CALL_ONGOING = 0x7497D2CE2C30D24C,
        CREATE_NEW_SCRIPTED_CONVERSATION = 0xD2C91A0B572AAE56,
        START_SCRIPT_PHONE_CONVERSATION = 0x252E5F915EABB675,
        PRELOAD_SCRIPT_PHONE_CONVERSATION = 0x6004BCB0E226AAEA,
        START_SCRIPT_CONVERSATION = 0x6B17C62C9635D2DC,
        PRELOAD_SCRIPT_CONVERSATION = 0x3B3CAD6166916D87,
        START_PRELOADED_CONVERSATION = 0x23641AFE870AF385,
        GET_IS_PRELOADED_CONVERSATION_READY = 0xE73364DB90778FFA,
        IS_SCRIPTED_CONVERSATION_ONGOING = 0x16754C556D2EDE3D,
        IS_SCRIPTED_CONVERSATION_LOADED = 0xDF0D54BE7A776737,
        GET_CURRENT_SCRIPTED_CONVERSATION_LINE = 0x480357EE890C295A,
        PAUSE_SCRIPTED_CONVERSATION = 0x8530AD776CD72B12,
        RESTART_SCRIPTED_CONVERSATION = 0x9AEB285D1818C9AC,
        STOP_SCRIPTED_CONVERSATION = 0xD79DEEFB53455EBA,
        SKIP_TO_NEXT_SCRIPTED_CONVERSATION_LINE = 0x9663FE6B7A61EB00,
        INTERRUPT_CONVERSATION = 0xA018A12E5C5C2FA6,
        HINT_AMBIENT_AUDIO_BANK = 0x8F8C0E370AE62F5C,
        HINT_SCRIPT_AUDIO_BANK = 0xFB380A29641EC31A,
        RELEASE_MISSION_AUDIO_BANK = 0x0EC92A1BF0857187,
        RELEASE_AMBIENT_AUDIO_BANK = 0x65475A218FFAA93D,
        RELEASE_NAMED_SCRIPT_AUDIO_BANK = 0x77ED170667F50170,
        RELEASE_SCRIPT_AUDIO_BANK = 0x7A2D8AD0A9EB9C3F,
        GET_SOUND_ID = 0x430386FE9BF80B45,
        RELEASE_SOUND_ID = 0x353FC880830B88FA,
        STOP_SOUND = 0xA3B0C41BA5CC0BB5,
        GET_SOUND_ID_FROM_NETWORK_ID = 0x75262FD12D0A1C84,
        SET_VARIABLE_ON_SOUND = 0xAD6B3148A78AE9B6,
        OVERRIDE_UNDERWATER_STREAM = 0xF2A9CDABCEA04BD6,
        HAS_SOUND_FINISHED = 0xFCBDCE714A7C88E5,
        RESET_TREVOR_RAGE = 0xE78503B10C4314E0,
        SET_PLAYER_ANGRY = 0xEA241BB04110F091,
        RELEASE_WEAPON_AUDIO = 0xCE4AC0439F607045,
        ACTIVATE_AUDIO_SLOWMO_MODE = 0xD01005D2BA2EB778,
        DEACTIVATE_AUDIO_SLOWMO_MODE = 0xDDC635D5B3262C56,
        _SET_AMBIENT_VOICE_NAME_HASH = 0x9A53DED9921DE990,
        _GET_AMBIENT_VOICE_NAME_HASH = 0x5E203DA2BA15D436,
        _SET_PED_AUDIO_GENDER = 0xA5342D390CDA41D6,
        STOP_CURRENT_PLAYING_SPEECH = 0x7A73D05A607734C7,
        STOP_CURRENT_PLAYING_AMBIENT_SPEECH = 0xB8BEC0CA6F0EDB0F,
        IS_AMBIENT_SPEECH_PLAYING = 0x9072C8B49907BFAD,
        IS_SCRIPTED_SPEECH_PLAYING = 0xCC9AA18DCC7084F4,
        IS_ANY_SPEECH_PLAYING = 0x729072355FA39EC9,
        IS_PED_IN_CURRENT_CONVERSATION = 0x049E937F18F4020C,
        IS_ANIMAL_VOCALIZATION_PLAYING = 0xC265DF9FB44A9FBD,
        IS_MOBILE_PHONE_RADIO_ACTIVE = 0xB35CE999E8EF317E,
        SET_MOBILE_PHONE_RADIO_STATE = 0xBF286C554784F3DF,
        GET_PLAYER_RADIO_STATION_GENRE = 0xA571991A7FE6CCEB,
        IS_RADIO_RETUNING = 0xA151A7394A214E65,
        IS_RADIO_FADED_OUT = 0x0626A247D2405330,
        _SET_VEH_HAS_RADIO_OVERRIDE = 0x3E45765F3FBB582F,
        SET_FRONTEND_RADIO_ACTIVE = 0xF7F26C6E9CC9EBB8,
        IS_MISSION_NEWS_STORY_UNLOCKED = 0x66E49BF55B4B1874,
        GET_AUDIBLE_MUSIC_TRACK_TEXT_ID = 0x50B196FC9ED6545B,
        PLAY_END_CREDITS_MUSIC = 0xCD536C4D33DCC900,
        SKIP_RADIO_FORWARD = 0x6DDBBDD98E2E9C25,
        FREEZE_RADIO_STATION = 0x344F393B027E38C3,
        UNFREEZE_RADIO_STATION = 0xFC00454CF60B91DD,
        SET_RADIO_AUTO_UNFREEZE = 0xC1AA9F53CE982990,
        SET_INITIAL_PLAYER_STATION = 0x88795F13FACDA88D,
        SET_USER_RADIO_CONTROL_ENABLED = 0x19F21E63AE6EAE4E,
        _SET_RADIO_TRACK_MIX = 0x2CB0075110BE1E56,
        SET_VEHICLE_RADIO_LOUD = 0xBB6F1CAEC68B0BCE,
        _IS_VEHICLE_RADIO_LOUD = 0x032A116663A4D5AC,
        SET_MOBILE_RADIO_ENABLED_DURING_GAMEPLAY = 0x1098355A16064BB3,
        DOES_PLAYER_VEH_HAVE_RADIO = 0x109697E2FFBAC8A1,
        IS_PLAYER_VEH_RADIO_ENABLE = 0x5F43D83FD6738741,
        GET_NUM_UNLOCKED_RADIO_STATIONS = 0xF1620ECB50E01DE7,
        FIND_RADIO_STATION_INDEX = 0x8D67489793FF428B,
        SET_RADIO_FRONTEND_FADE_TIME = 0x2C96CDB04FCA358E,
        _LOCK_RADIO_STATION_TRACK_LIST = 0xFF5E5EA2DCEEACF3,
        _FORCE_RADIO_TRACK_LIST_POSITION = 0x4E0AF9114608257C,
        SET_AMBIENT_ZONE_LIST_STATE = 0x9748FA4DE50CCE3E,
        CLEAR_AMBIENT_ZONE_LIST_STATE = 0x120C48C614909FA4,
        _CANCEL_CURRENT_POLICE_REPORT = 0xB4F90FAF7670B16F,
        IS_STREAM_PLAYING = 0xD11FA52EB849D978,
        GET_STREAM_PLAY_TIME = 0x4E72BBDBCA58A3DB,
        PLAY_STREAM_FROM_PED = 0x89049DD63C08B5D1,
        PLAY_STREAM_FROM_VEHICLE = 0xB70374A758007DFA,
        PLAY_STREAM_FRONTEND = 0x58FCE43488F9F5F4,
        PLAY_STREAM_FROM_POSITION = 0x21442F412E8DE56B,
        STOP_STREAM = 0xA4718A1419D18151,
        STOP_PED_SPEAKING = 0x9D64D7405520E3D3,
        DISABLE_PED_PAIN_AUDIO = 0xA9A41C1E940FB0E8,
        SET_SIREN_WITH_NO_DRIVER = 0x1FEF0683B96EBCF2,
        _SET_SIREN_KEEP_ON = 0xF584CF8529B51434,
        _TRIGGER_SIREN = 0x66C3FB05206041BA,
        SET_HORN_ENABLED = 0x76D683C108594D0E,
        SET_AUDIO_VEHICLE_PRIORITY = 0xE5564483E407F914,
        USE_SIREN_AS_HORN = 0xFA932DE350266EF8,
        _PRELOAD_VEHICLE_AUDIO = 0xCA4CEA6AE0000A7E,
        SET_VEHICLE_STARTUP_REV_SOUND = 0xF1F8157B8C3F171C,
        _RESET_VEHICLE_STARTUP_REV_SOUND = 0xD2DCCD8E16E20997,
        IS_VEHICLE_AUDIBLY_DAMAGED = 0x5DB8010EE71FDEF2,
        SET_VEHICLE_AUDIO_ENGINE_DAMAGE_FACTOR = 0x59E7B488451F4D3A,
        SET_VEHICLE_AUDIO_BODY_DAMAGE_FACTOR = 0x01BB4D577D38BD9E,
        ENABLE_VEHICLE_FANBELT_DAMAGE = 0x1C073274E065C6D2,
        ENABLE_VEHICLE_EXHAUST_POPS = 0x2BE4BC731D039D5A,
        SET_SCRIPT_UPDATE_DOOR_AUDIO = 0x06C0023BED16DD6B,
        SET_GPS_ACTIVE = 0x3BD3F52BA9B1E4E8,
        IS_MISSION_COMPLETE_PLAYING = 0x19A30C23F5827F8A,
        IS_MISSION_COMPLETE_READY_FOR_UI = 0x6F259F82D873B8B8,
        BLOCK_DEATH_JINGLE = 0xF154B8D1775B2DEC,
        STOP_AUDIO_SCENE = 0xDFE8422B3B94E688,
        IS_AUDIO_SCENE_ACTIVE = 0xB65B60556E2A9225,
        SET_AUDIO_SCENE_VARIABLE = 0xEF21A9EF089A2668,
        SET_AUDIO_SCRIPT_CLEANUP_TIME = 0xA5F377B175A699C5,
        REMOVE_ENTITY_FROM_AUDIO_MIX_GROUP = 0x18EB48CFC41F2EA0,
        AUDIO_IS_SCRIPTED_MUSIC_PLAYING = 0x845FFC3A4FEEFA3E,
        IS_MUSIC_ONESHOT_PLAYING = 0xA097AB275061FB21,
        GET_MUSIC_PLAYTIME = 0xE7A0D23DC414507B,
        RECORD_BROKEN_GLASS = 0xFBE20329593DEC9D,
        CLEAR_ALL_BROKEN_GLASS = 0xB32209EFFDC04913,
        FORCE_PED_PANIC_WALLA = 0x062D5EAD4DA2FA6A,
        STOP_ALL_ALARMS = 0x2F794A877ADD4C92,
        GET_VEHICLE_DEFAULT_HORN_IGNORE_MODS = 0xACB5DCCA1EC76840,
        RESET_PED_AUDIO_FLAGS = 0xF54BB7B61036F335,
        FREEZE_MICROPHONE = 0xD57AAAE0E2214D11,
        PREPARE_SYNCHRONIZED_AUDIO_EVENT = 0xC7ABCACA4985A766,
        PREPARE_SYNCHRONIZED_AUDIO_EVENT_FOR_SCENE = 0x029FE7CD1B7E2E75,
        PLAY_SYNCHRONIZED_AUDIO_EVENT = 0x8B2FD4560E55DD2D,
        STOP_SYNCHRONIZED_AUDIO_EVENT = 0x92D6A88E64A94430,
        GET_MUSIC_VOL_SLIDER = 0x3A48AB4445D499BE,
        REQUEST_TENNIS_BANKS = 0x4ADA3F19BE4A6047,
        UNREQUEST_TENNIS_BANKS = 0x0150B6FF25A9E2E5,
        STOP_CUTSCENE_AUDIO = 0x806058BBDC136E06,
        _GET_VEHICLE_DEFAULT_HORN_VARIATION = 0xD53F3A29BCE2580E,
        _SET_VEHICLE_HORN_VARIATION = 0x0350E7E17BA767D0,
        _0x33E3C6C6F2F0B506 = 0x33E3C6C6F2F0B506,
        _0x892B6AB8F33606F5 = 0x892B6AB8F33606F5,
        _0x0B568201DD99F0EB = 0x0B568201DD99F0EB,
        _0x61631F5DF50D1C34 = 0x61631F5DF50D1C34,
        _0xAA19F5572C38B564 = 0xAA19F5572C38B564,
        _0xB542DE8C3D1CB210 = 0xB542DE8C3D1CB210,
        _0x40763EA7B9B783E7 = 0x40763EA7B9B783E7,
        _0x19AF7ED9B9D23058 = 0x19AF7ED9B9D23058,
        _0x9AC92EED5E4793AB = 0x9AC92EED5E4793AB,
        _0x11579D940949C49E = 0x11579D940949C49E,
        _0x5B9853296731E88D = 0x5B9853296731E88D,
        _0x7EC3C679D0E7E46B = 0x7EC3C679D0E7E46B,
        _0x1B7ABE26CBCBF8C7 = 0x1B7ABE26CBCBF8C7,
        _0x30CA2EF91D15ADF8 = 0x30CA2EF91D15ADF8,
        _0x55ECF4D13D9903B0 = 0x55ECF4D13D9903B0,
        _0xDA07819E452FFE8F = 0xDA07819E452FFE8F,
        _0x5D2BFAAB8D956E0E = 0x5D2BFAAB8D956E0E,
        _0x9BD7BD55E4533183 = 0x9BD7BD55E4533183,
        _0xAB6781A5F3101470 = 0xAB6781A5F3101470,
        _0xA8A7D434AFB4B97B = 0xA8A7D434AFB4B97B,
        _0x2ACABED337622DF2 = 0x2ACABED337622DF2,
        _0x97FFB4ADEED08066 = 0x97FFB4ADEED08066,
        _0x2DD39BF3E2F9C47F = 0x2DD39BF3E2F9C47F,
        _0x159B7318403A1CD8 = 0x159B7318403A1CD8,
        _0x70B8EC8FC108A634 = 0x70B8EC8FC108A634,
        _0x149AEE66F0CB3A99 = 0x149AEE66F0CB3A99,
        _0x8BF907833BE275DE = 0x8BF907833BE275DE,
        _0x43FA0DFC5DF87815 = 0x43FA0DFC5DF87815,
        _0xB81CF134AEB56FFB = 0xB81CF134AEB56FFB,
        _0xC8EDE9BDBCCBA6D4 = 0xC8EDE9BDBCCBA6D4,
        _0xBEF34B1D9624D5DD = 0xBEF34B1D9624D5DD,
    }
}