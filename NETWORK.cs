using System;
namespace Hotstar
{
    public enum NETWORK : ulong
    { 
        /// <summary>
        /// Online version is defined here: update\update.rpf\common\data\version.txt
        /// 
        /// Example:
        /// 
        /// [ONLINE_VERSION_NUMBER]
        /// 1.33
        /// 
        /// _GET_ONLINE_VERSION() will return "1.33"
        ///
        ///
        /// </summary>
        _GET_ONLINE_VERSION = 0xFCA9373EF340AC0A,
        /// <summary>
        /// Returns whether the player is signed into Social Club.
        ///
        ///
        /// </summary>
        NETWORK_IS_SIGNED_IN = 0x054354A99211EB96,
        /// <summary>
        /// Returns whether the game is not in offline mode.
        /// 
        /// seemed not to work for some ppl
        ///
        ///
        /// </summary>
        NETWORK_IS_SIGNED_ONLINE = 0x1077788E268557C2,
        /// <summary>
        /// Returns whether the signed-in user has valid Rockstar Online Services (ROS) credentials.
        ///
        ///
        /// </summary>
        NETWORK_HAS_VALID_ROS_CREDENTIALS = 0x85443FF4C328F53B,
        /// <summary>
        /// If you are host, returns true else returns false.
        ///
        ///
        /// </summary>
        NETWORK_IS_HOST = 0x8DB296B814EDDA07,
        /// <summary>
        /// 11 - Need to download tunables.
        /// 12 - Need to download background script.
        /// 
        /// Returns 1 if the multiplayer is loaded, otherwhise 0.
        ///
        /// > int* loadingState
        ///
        /// </summary>
        NETWORK_CAN_ACCESS_MULTIPLAYER = 0xAF50DA1A3F8B1BA4,
        /// <summary>
        /// unknown params
        /// 
        /// p0 = 0, 2, or 999 (The global is 999 by default.)
        /// p1 = 0 (Always in every script it's found in atleast.)
        /// p2 = 0, 3, or 4 (Based on a var that is determined by a function.)
        /// p3 = maxPlayers (It's obvious in x360 scripts it's always 18)
        /// p4 = 0 (Always in every script it's found in atleast.)
        /// p5 = 0 or 1. (1 if network_can_enter_multiplayer, but set to 0 if other checks after that are passed.)
        /// p5 is reset to 0 if,
        /// Global_1315318 = 0 or Global_1315323 = 9 or 12 or (Global_1312629 = 0 && Global_1312631 = true/1) those are passed.
        ///
        /// > Any p0
        /// > Any p1
        /// > Any p2
        /// > int maxPlayers
        /// > Any p4
        /// > Any p5
        ///
        /// </summary>
        NETWORK_SESSION_ENTER = 0x330ED4D05491934F,
        /// <summary>
        /// Does nothing in online but in offline it will cause the screen to fade to black. Nothing happens past then, the screen will sit at black until you restart GTA. Other stuff must be needed to actually host a session.
        ///
        /// > int p0
        /// > int maxPlayers
        /// > BOOL p2
        ///
        /// </summary>
        NETWORK_SESSION_HOST = 0x6F3D4ED9BEE4E61D,
        /// <summary>
        /// Does nothing in online but in offline it will cause the screen to fade to black. Nothing happens past then, the screen will sit at black until you restart GTA. Other stuff must be needed to actually host a session.
        ///
        /// > int p0
        /// > int maxPlayers
        ///
        /// </summary>
        NETWORK_SESSION_HOST_FRIENDS_ONLY = 0xB9CFD27A5D578D83,
        /// <summary>
        /// p0 is always false and p1 varies.
        /// NETWORK_SESSION_END(0, 1)
        /// NETWORK_SESSION_END(0, 0)
        /// Results in: "Connection to session lost due to an unknown network error. Please return to Grand Theft Auto V and try again later."
        ///
        /// > BOOL p0
        /// > BOOL p1
        ///
        /// </summary>
        NETWORK_SESSION_END = 0xA02E59562D711006,
        /// <summary>
        /// Only works as host.
        ///
        /// > Player player
        ///
        /// </summary>
        NETWORK_SESSION_KICK_PLAYER = 0xFA8904DC5F304220,
        /// <summary>
        /// playerTypes:
        /// 0 = regular joiner
        /// 4 = spectator
        /// 8 = unknown
        ///
        /// > int playerType
        /// > int playerCount
        ///
        /// </summary>
        NETWORK_SESSION_SET_MATCHMAKING_GROUP_MAX = 0x8B6A4DD0AF9CE215,
        /// <summary>
        /// groupId range: [0, 4]
        ///
        /// > int groupId
        ///
        /// </summary>
        NETWORK_SESSION_ADD_ACTIVE_MATCHMAKING_GROUP = 0xCAE55F48D3D7875C,
        /// <summary>
        /// ..
        ///
        /// > int* p0
        /// > int p1
        ///
        /// </summary>
        NETWORK_ADD_FOLLOWERS = 0x236406F60CF216D6,
        /// <summary>
        /// NETWORK_RE*
        /// 
        /// Triggers a CEventNetworkInviteConfirmed event
        ///
        ///
        /// </summary>
        _NETWORK_ACCEPT_INVITE = 0x62A0296C1BB1CEB3,
        /// <summary>
        /// Loads up the map that is loaded when beeing in mission creator
        /// Player gets placed in a mix between online/offline mode
        /// p0 is always 2 in R* scripts.
        /// 
        /// Appears to be patched in gtav b757 (game gets terminated) alonside with most other network natives to prevent online modding ~ghost30812
        ///
        /// > int p0
        ///
        /// </summary>
        NETWORK_SESSION_HOST_SINGLE_PLAYER = 0xC74C33FCA52856D5,
        /// <summary>
        /// This checks if player is playing on gta online or not.
        /// Please add an if and block your mod if this is "true".
        ///
        ///
        /// </summary>
        NETWORK_IS_SESSION_STARTED = 0x9DE624D2FC4B603F,
        /// <summary>
        /// Only one occurence in the scripts:
        /// 
        /// auto sub_cb43(auto a_0, auto a_1) {
        ///     if (g_2594CB._f1) {
        ///         if (NETWORK::_855BC38818F6F684()) {
        ///             NETWORK::_ABD5E88B8A2D3DB2(&a_0._fB93);
        ///             g_2594CB._f14/*{13}*/ = a_0._fB93;
        ///             g_2594CB._f4/*"64"*/ = a_1;
        ///             return 1;
        ///         }
        ///     }
        ///     return 0;
        /// }
        /// 
        /// other:
        /// looks like it passes a player in the paramater
        /// 
        /// Contains string "NETWORK_VOICE_CONNECT_TO_PLAYER" in ida
        ///
        /// > Any* p0
        ///
        /// </summary>
        NETWORK_SESSION_VOICE_CONNECT_TO_PLAYER = 0xABD5E88B8A2D3DB2,
        /// <summary>
        /// Message is limited to 64 characters.
        ///
        /// > const char* message
        /// > Any* gamerHandle
        ///
        /// </summary>
        NETWORK_SEND_TEXT_MESSAGE = 0x3A214F2EC889B100,
        /// <summary>
        /// p0: Unknown int
        /// p1: Unknown int
        /// p2: Unknown int
        /// p3: Unknown int
        /// p4: Unknown always 0 in decompiled scripts
        /// p5: BOOL purpose unknown, both 0 and 1 are used in decompiled scripts.
        /// p6: BOOL purpose unknown, both 0 and 1 are used in decompiled scripts.
        /// p7: Unknown int, it's an int according to decompiled scripts, however the value is always 0 or 1.
        /// p8: Unknown int, it's an int according to decompiled scripts, however the value is always 0 or 1.
        /// p9: Unknown int, sometimes 0, but also 32768 or 16384 appear in decompiled scripst, maybe a flag of some sort?
        /// 
        /// From what I can tell it looks like it does the following:
        /// Creates/hosts a new transition to another online session, using this in FiveM will result in other players being disconencted from the server/preventing them from joining. This is most likely because I entered the wrong session parameters since they're pretty much all unknown right now.
        /// You also need to use `NetworkJoinTransition(Player player)` and `NetworkLaunchTransition()`.
        ///
        /// > int p0
        /// > int p1
        /// > int p2
        /// > int p3
        /// > Any p4
        /// > BOOL p5
        /// > BOOL p6
        /// > int p7
        /// > Any p8
        /// > int p9
        ///
        /// </summary>
        NETWORK_HOST_TRANSITION = 0xA60BB5CE242BB254,
        /// <summary>
        /// p2 is true 3/4 of the occurrences I found.
        /// 'players' is the number of players for a session. On PS3/360 it's always 18. On PC it's 32.
        ///
        /// > Any* p0
        /// > Any p1
        /// > BOOL p2
        /// > int players
        /// > BOOL p4
        ///
        /// </summary>
        NETWORK_DO_TRANSITION_TO_FREEMODE = 0x3AAD8B2FCA1E289F,
        /// <summary>
        /// Returns count.
        ///
        /// > Any* data
        /// > int dataCount
        ///
        /// </summary>
        NETWORK_GET_TRANSITION_MEMBERS = 0x73B000F7FBC55829,
        /// <summary>
        /// the first arg seems to be the network player handle (&handle) and the second var is pretty much always "" and the third seems to be a number between 0 and ~10 and the 4th is is something like 0 to 5 and I guess the 5th is a bool cuz it is always 0 or 1
        /// 
        /// does this send an invite to a player?
        ///
        /// > Any* gamerHandle
        /// > const char* p1
        /// > int p2
        /// > int p3
        /// > BOOL p4
        ///
        /// </summary>
        NETWORK_SEND_TRANSITION_GAMER_INSTRUCTION = 0x31D1D2B858D25E6B,
        /// <summary>
        /// int handle[76];
        ///           NETWORK_HANDLE_FROM_FRIEND(iSelectedPlayer, &handle[0], 13);
        ///           Player uVar2 = NETWORK_GET_PLAYER_FROM_GAMER_HANDLE(&handle[0]);
        ///           NETWORK_JOIN_TRANSITION(uVar2);
        /// nothing doin.
        ///
        /// > Player player
        ///
        /// </summary>
        NETWORK_JOIN_TRANSITION = 0x9D060B08CD63321A,
        /// <summary>
        /// String "NETWORK_SEND_PRESENCE_TRANSITION_INVITE" is contained in the function in ida so this one is correct.
        ///
        /// > Any* p0
        /// > Any* p1
        /// > Any p2
        /// > Any p3
        ///
        /// </summary>
        _NETWORK_SEND_PRESENCE_TRANSITION_INVITE = 0xC116FF9B4D488291,
        /// <summary>
        /// Hardcoded to return false.
        ///
        ///
        /// </summary>
        NETWORK_IS_IN_PLATFORM_PARTY = 0x2FC5650B0271CB57,
        /// <summary>
        /// Hardcoded to return false.
        ///
        ///
        /// </summary>
        NETWORK_IS_IN_PLATFORM_PARTY_CHAT = 0xFD8B834A8BA05048,
        /// <summary>
        /// This would be nice to see if someone is in party chat, but 2 sad notes.
        /// 1) It only becomes true if said person is speaking in that party at the time.
        /// 2) It will never, become true unless you are in that party with said person.
        ///
        /// > Any* gamerHandle
        ///
        /// </summary>
        NETWORK_IS_CHATTING_IN_PLATFORM_PARTY = 0x8DE9945BCC9AEC52,
        /// <summary>
        /// Same as GET_RANDOM_INT_IN_RANGE
        ///
        /// > int rangeStart
        /// > int rangeEnd
        ///
        /// </summary>
        NETWORK_GET_RANDOM_INT_RANGED = 0xE30CF56F1EFA5F43,
        /// <summary>
        /// p1 = 6
        ///
        /// > Player player
        /// > int p1
        /// > Hash scriptHash
        ///
        /// </summary>
        _TRIGGER_SCRIPT_CRC_CHECK_ON_PLAYER = 0x46FB3ED415C7641C,
        /// <summary>
        /// Seems to always return 0, but it's used in quite a few loops.
        /// 
        /// for (num3 = 0; num3 < NETWORK::0xCCD8C02D(); num3++)
        ///     {
        ///         if (NETWORK::NETWORK_IS_PARTICIPANT_ACTIVE(PLAYER::0x98F3B274(num3)) != 0)
        ///         {
        ///             var num5 = NETWORK::NETWORK_GET_PLAYER_INDEX(PLAYER::0x98F3B274(num3));
        ///
        ///
        /// </summary>
        NETWORK_GET_MAX_NUM_PARTICIPANTS = 0xA6C90FBC38E395EE,
        /// <summary>
        /// Returns the Player associated to a given Ped when in an online session.
        ///
        /// > Ped ped
        ///
        /// </summary>
        NETWORK_GET_PLAYER_INDEX_FROM_PED = 0x6C0E2E0125610278,
        /// <summary>
        /// Returns the amount of players connected in the current session. Only works when connected to a session/server.
        ///
        ///
        /// </summary>
        NETWORK_GET_NUM_CONNECTED_PLAYERS = 0xA4A79DD2D9600654,
        /// <summary>
        /// scriptName examples:
        /// "freemode", "AM_CR_SecurityVan", ...
        /// 
        /// Most of the time, these values are used:
        /// p1 = -1
        /// p2 = 0
        ///
        /// > const char* scriptName
        /// > int p1
        /// > int p2
        ///
        /// </summary>
        NETWORK_GET_HOST_OF_SCRIPT = 0x1D6A14F1F9A736FC,
        /// <summary>
        /// Return the local Participant ID
        ///
        ///
        /// </summary>
        PARTICIPANT_ID = 0x90986E8876CE0A83,
        /// <summary>
        /// Return the local Participant ID.
        /// 
        /// This native is exactly the same as 'PARTICIPANT_ID' native.
        ///
        ///
        /// </summary>
        PARTICIPANT_ID_TO_INT = 0x57A3BDDAD8E5AA0A,
        /// <summary>
        /// Returns true if the specified network id is controlled by someone else.
        ///
        /// > int netId
        ///
        /// </summary>
        _NETWORK_IS_NETWORK_ID_A_CLONE = 0x7242F8B741CE1086,
        /// <summary>
        /// calls from vehicle to net.
        /// 
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        VEH_TO_NET = 0xB4C94523F023419C,
        /// <summary>
        /// gets the network id of a ped
        ///
        /// > Ped ped
        ///
        /// </summary>
        PED_TO_NET = 0x0EDEC3C276198689,
        /// <summary>
        /// Lets objects spawn online simply do it like this:
        /// 
        /// int createdObject = OBJ_TO_NET(CREATE_OBJECT_NO_OFFSET(oball, pCoords.x, pCoords.y, pCoords.z, 1, 0, 0));
        ///
        /// > Object object
        ///
        /// </summary>
        OBJ_TO_NET = 0x99BFDC94A603E541,
        /// <summary>
        /// gets the ped id of a network id
        ///
        /// > int netHandle
        ///
        /// </summary>
        NET_TO_PED = 0xBDCD95FC216A8B3E,
        /// <summary>
        /// gets the object id of a network id
        ///
        /// > int netHandle
        ///
        /// </summary>
        NET_TO_OBJ = 0xD8515F5FEA14CB3F,
        /// <summary>
        /// gets the entity id of a network id
        ///
        /// > int netHandle
        ///
        /// </summary>
        NET_TO_ENT = 0xBFFEAB45A9A9094A,
        /// <summary>
        /// Hardcoded to return -1.
        ///
        /// > Any* p0
        /// > Any p1
        ///
        /// </summary>
        NETWORK_DISPLAYNAMES_FROM_HANDLES_START = 0xD66C9E72B3CC4982,
        /// <summary>
        /// MulleDK19: This function is hard-coded to always return 0.
        ///
        /// > Any p0
        /// > Any p1
        /// > Any p2
        ///
        /// </summary>
        NETWORK_GET_DISPLAYNAMES_FROM_HANDLES = 0x58CC181719256197,
        /// <summary>
        /// Returns the name of a given player. Returns "**Invalid**" if rlGamerInfo of the given player cannot be retrieved or the player doesn't exist.
        ///
        /// > Player player
        ///
        /// </summary>
        NETWORK_PLAYER_GET_NAME = 0x7718D2E2060837D2,
        /// <summary>
        /// Returns a string of the player's Rockstar Id. 
        /// Takes a 24 char buffer. Returns the buffer or "**Invalid**" if rlGamerInfo of the given player cannot be retrieved or the player doesn't exist.
        ///
        /// > Player player
        /// > int* userID
        ///
        /// </summary>
        NETWORK_PLAYER_GET_USERID = 0x4927FC39CD0869A0,
        /// <summary>
        /// Checks if a specific value (BYTE) in CNetGamePlayer is nonzero.
        /// Returns always false in Singleplayer.
        /// 
        /// No longer used for dev checks since first mods were released on PS3 & 360.
        /// R* now checks with the IS_DLC_PRESENT native for the dlc hash 2532323046,
        /// if that is present it will unlock dev stuff.
        ///
        /// > Player player
        ///
        /// </summary>
        NETWORK_PLAYER_IS_ROCKSTAR_DEV = 0x544ABDDA3B409B6D,
        /// <summary>
        /// In scripts R* calls 'NETWORK_GET_FRIEND_NAME' in this param.
        ///
        /// > const char* friendName
        ///
        /// </summary>
        NETWORK_IS_FRIEND_IN_SAME_TITLE = 0x2EA9A3BEDF3F17B8,
        /// <summary>
        /// This function is hard-coded to always return 0.
        ///
        /// > Any p0
        ///
        /// </summary>
        NETWORK_IS_PENDING_FRIEND = 0x0BE73DA6984A6E33,
        /// <summary>
        /// Same as NETWORK_CAN_COMMUNICATE_WITH_GAMER
        /// 
        /// NETWORK_CAN_*
        ///
        /// > Any* gamerHandle
        ///
        /// </summary>
        _NETWORK_CAN_COMMUNICATE_WITH_GAMER_2 = 0x8F5D1AD832AEB06C,
        /// <summary>
        /// returns true if someone is screaming or talking in a microphone
        ///
        /// > Player player
        ///
        /// </summary>
        NETWORK_IS_PLAYER_TALKING = 0x031E11F3D447647E,
        /// <summary>
        /// Could possibly bypass being muted or automatically muted
        ///
        /// > Player player
        /// > BOOL toggle
        ///
        /// </summary>
        NETWORK_OVERRIDE_CHAT_RESTRICTIONS = 0x3039AE5AD2C9C0C4,
        /// <summary>
        /// This is used alongside the native,
        /// 'NETWORK_OVERRIDE_RECEIVE_RESTRICTIONS'. Read its description for more info.
        ///
        /// > Player player
        /// > BOOL toggle
        ///
        /// </summary>
        NETWORK_OVERRIDE_SEND_RESTRICTIONS = 0x97DD4C5944CC2E6A,
        /// <summary>
        /// R* uses this to hear all player when spectating. 
        /// It allows you to hear other online players when their chat is on none, crew and or friends
        ///
        /// > Player player
        /// > BOOL toggle
        ///
        /// </summary>
        NETWORK_OVERRIDE_RECEIVE_RESTRICTIONS = 0xDDF73E2B1FEC5AB4,
        /// <summary>
        /// p0 is always false in scripts.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        NETWORK_OVERRIDE_RECEIVE_RESTRICTIONS_ALL = 0x0FF2862B61A58AF9,
        /// <summary>
        /// Same as _IS_TEXT_CHAT_ACTIVE, except it does not check if the text chat HUD component is initialized, and therefore may crash.
        ///
        ///
        /// </summary>
        _NETWORK_IS_TEXT_CHAT_ACTIVE = 0x5FCF4D7069B09026,
        /// <summary>
        /// Starts a new singleplayer game (at the prologue).
        ///
        ///
        /// </summary>
        SHUTDOWN_AND_LAUNCH_SINGLE_PLAYER_GAME = 0x593850C16A36B692,
        /// <summary>
        /// In singleplayer this will re-load your game.
        /// 
        /// In FiveM / GTA:Online this disconnects you from the session, and starts loading single player, however you still remain connected to the server (only if you're the host, if you're not then you also (most likely) get disconnected from the server) and other players will not be able to join until you exit the game.
        /// 
        /// You might need to DoScreenFadeIn and ShutdownLoadingScreen otherwise you probably won't end up loading into SP at all.
        /// 
        /// Somewhat related note: opening the pause menu after loading into this 'singleplayer' mode crashes the game.
        ///
        ///
        /// </summary>
        _SHUTDOWN_AND_LOAD_MOST_RECENT_SAVE = 0x9ECA15ADFE141431,
        /// <summary>
        /// This native does absolutely nothing, just a nullsub
        ///
        /// > Any p0
        /// > Any p1
        /// > Any p2
        /// > Any p3
        ///
        /// </summary>
        NETWORK_SET_RICH_PRESENCE = 0x1DCCACDCFC569362,
        /// <summary>
        /// This native does absolutely nothing, just a nullsub
        ///
        /// > int p0
        /// > const char* textLabel
        ///
        /// </summary>
        NETWORK_SET_RICH_PRESENCE_STRING = 0x3E200C2BCF4164EB,
        /// <summary>
        /// p4 and p5 are always 0 in scripts
        ///
        /// > Player player
        /// > float x
        /// > float y
        /// > float z
        /// > BOOL p4
        /// > BOOL p5
        ///
        /// </summary>
        NETWORK_LEAVE_PED_BEHIND_BEFORE_WARP = 0x9769F811D1785B03,
        /// <summary>
        /// entity must be a valid entity; ped can be NULL
        ///
        /// > Entity entity
        /// > Ped ped
        ///
        /// </summary>
        REMOVE_ALL_STICKY_BOMBS_FROM_ENTITY = 0x715135F4B82AC90D,
        /// <summary>
        /// bufferSize is 35 in the scripts.
        /// 
        /// bufferSize is the elementCount of p0(desc), sizeof(p0) == 280 == p1*8 == 35 * 8, p2(netHandle) is obtained from NETWORK::NETWORK_HANDLE_FROM_PLAYER.  And no, I can't explain why 35 * sizeof(int) == 280 and not 140, but I'll get back to you on that.
        /// 
        /// the answer is: because p0 an int64_t* / int64_t[35].  and FYI p2 is an int64_t[13]
        /// 
        /// pastebin.com/cSZniHak
        ///
        /// > Any* clanDesc
        /// > int bufferSize
        /// > Any* gamerHandle
        ///
        /// </summary>
        NETWORK_CLAN_PLAYER_GET_DESC = 0xEEE6EACBE8874FBA,
        /// <summary>
        /// bufferSize is 35 in the scripts.
        ///
        /// > int* clanDesc
        /// > int bufferSize
        ///
        /// </summary>
        NETWORK_CLAN_IS_ROCKSTAR_CLAN = 0x7543BB439F63792B,
        /// <summary>
        /// bufferSize is 35 in the scripts.
        ///
        /// > int* clanDesc
        /// > int bufferSize
        /// > char* formattedTag
        ///
        /// </summary>
        NETWORK_CLAN_GET_UI_FORMATTED_TAG = 0xF45352426FF3A4F0,
        /// <summary>
        /// Only documented...
        /// 
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        ///
        /// > const char* animDict
        /// > const char* animName
        ///
        /// </summary>
        _NETWORK_CLAN_ANIMATION = 0x729E3401F0430686,
        /// <summary>
        /// Whether or not another player is allowed to take control of the entity
        ///
        /// > int netId
        /// > BOOL toggle
        ///
        /// </summary>
        SET_NETWORK_ID_CAN_MIGRATE = 0x299EEB23175895FC,
        /// <summary>
        /// if set to true other network players can't see it
        /// if set to false other network player can see it
        /// =========================================
        /// ^^ I attempted this by grabbing an object with GET_ENTITY_PLAYER_IS_FREE_AIMING_AT and setting this naive no matter the toggle he could still see it.
        /// 
        /// pc or last gen?
        /// 
        /// ^^ last-gen
        ///
        /// > Entity entity
        /// > BOOL toggle
        ///
        /// </summary>
        _NETWORK_SET_ENTITY_INVISIBLE_TO_NETWORK = 0xF1CA12B18AEF5298,
        /// <summary>
        /// Hardcoded to not work in SP.
        ///
        /// > BOOL p0
        ///
        /// </summary>
        FADE_OUT_LOCAL_PLAYER = 0x416DBD4CD6ED8DD2,
        /// <summary>
        /// normal - transition like when your coming out of LSC
        /// slow - transition like when you walk into a mission
        ///  
        ///
        /// > Entity entity
        /// > BOOL normal
        /// > BOOL slow
        ///
        /// </summary>
        NETWORK_FADE_OUT_ENTITY = 0xDE564951F95E09ED,
        /// <summary>
        /// state - 0 does 5 fades
        /// state - 1 does 6 fades
        /// 
        /// p3: setting to 1 made vehicle fade in slower, probably "slow" as per NETWORK_FADE_OUT_ENTITY
        ///
        /// > Entity entity
        /// > BOOL state
        /// > Any p2
        ///
        /// </summary>
        NETWORK_FADE_IN_ENTITY = 0x1F4ED342ACEFE62D,
        /// <summary>
        /// Makes the provided entity visible for yourself for the current frame.
        ///
        /// > Entity entity
        ///
        /// </summary>
        SET_ENTITY_LOCALLY_INVISIBLE = 0xE135A9FF3F5D05D8,
        /// <summary>
        /// p0 appears to be for MP
        ///
        /// > BOOL p0
        /// > Any p1
        ///
        /// </summary>
        GET_NUM_RESERVED_MISSION_OBJECTS = 0xAA81B5F10BC43AC2,
        /// <summary>
        /// p0 appears to be for MP
        ///
        /// > BOOL p0
        /// > Any p1
        ///
        /// </summary>
        GET_NUM_RESERVED_MISSION_PEDS = 0x1F13D5AE5CB17E17,
        /// <summary>
        /// p0 appears to be for MP
        ///
        /// > BOOL p0
        /// > Any p1
        ///
        /// </summary>
        GET_NUM_RESERVED_MISSION_VEHICLES = 0xCF3A965906452031,
        /// <summary>
        /// Returns the same value as GET_NETWORK_TIME in freemode, but as opposed to `GET_NETWORK_TIME` it always gets the most recent time, instead of once per tick.
        /// Could be used for benchmarking since it can return times in ticks.
        ///
        ///
        /// </summary>
        GET_NETWORK_TIME_ACCURATE = 0x89023FBBF9200E9F,
        /// <summary>
        /// Adds the first argument to the second.
        ///
        /// > int timeA
        /// > int timeB
        ///
        /// </summary>
        GET_TIME_OFFSET = 0x017008CCDAD48503,
        /// <summary>
        /// Subtracts the second argument from the first, then returns whether the result is negative.
        ///
        /// > int timeA
        /// > int timeB
        ///
        /// </summary>
        IS_TIME_LESS_THAN = 0xCB2CF5148012C8D0,
        /// <summary>
        /// Subtracts the first argument from the second, then returns whether the result is negative.
        ///
        /// > int timeA
        /// > int timeB
        ///
        /// </summary>
        IS_TIME_MORE_THAN = 0xDE350F8651E4346C,
        /// <summary>
        /// Returns true if the two times are equal; otherwise returns false.
        ///
        /// > int timeA
        /// > int timeB
        ///
        /// </summary>
        IS_TIME_EQUAL_TO = 0xF5BC95857BD6D512,
        /// <summary>
        /// Subtracts the second argument from the first.
        ///
        /// > int timeA
        /// > int timeB
        ///
        /// </summary>
        GET_TIME_DIFFERENCE = 0xA2C6FC031D46FFF0,
        /// <summary>
        /// Same as GET_CLOUD_TIME_AS_INT but returns the value as a hex string (%I64X).
        ///
        ///
        /// </summary>
        _GET_CLOUD_TIME_AS_STRING = 0xF12E6CD06C73D69E,
        /// <summary>
        /// Returns POSIX timestamp, an int representing the cloud time.
        ///
        ///
        /// </summary>
        GET_CLOUD_TIME_AS_INT = 0x9A73240B49945C76,
        /// <summary>
        /// Takes the specified time and writes it to the structure specified in the second argument.
        /// 
        /// struct date_time
        /// {
        ///     int year;
        ///     int PADDING1;
        ///     int month;
        ///     int PADDING2;
        ///     int day;
        ///     int PADDING3;
        ///     int hour;
        ///     int PADDING4;
        ///     int minute;
        ///     int PADDING5;
        ///     int second;
        ///     int PADDING6;
        /// };
        ///
        /// > int posixTime
        /// > Any* timeStructure
        ///
        /// </summary>
        CONVERT_POSIX_TIME = 0xAC97AF97FA68E5D5,
        /// <summary>
        /// rage::netBlenderLinInterp::GetPositionMaxForUpdateLevel
        ///
        /// > Vehicle vehicle
        /// > float multiplier
        ///
        /// </summary>
        _SET_NETWORK_VEHICLE_POSITION_UPDATE_MULTIPLIER = 0xA2A707979FE754DC,
        /// <summary>
        /// Enables a periodic ShapeTest within the NetBlender and invokes rage::netBlenderLinInterp::GoStraightToTarget (or some functional wrapper).
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_NETWORK_ENABLE_VEHICLE_POSITION_CORRECTION = 0x838DA0936A24ED4D,
        /// <summary>
        /// Enables ghosting between specific players
        ///
        /// > Player player
        /// > BOOL p1
        ///
        /// </summary>
        _SET_RELATIONSHIP_TO_PLAYER = 0xA7C511FA1C5BDA38,
        /// <summary>
        /// Must be a value between 1 and 254
        ///
        /// > int alpha
        ///
        /// </summary>
        _SET_GHOSTED_ENTITY_ALPHA = 0x658500AE6D723A7E,
        /// <summary>
        /// Resets the entity ghost alpha to the default value (128)
        ///
        ///
        /// </summary>
        _RESET_GHOSTED_ENTITY_ALPHA = 0x17330EBF2F2124A8,
        /// <summary>
        /// One of the first things it does is get the players ped.
        /// Then it calls a function that is used in some tasks and ped based functions.
        /// p5, p6, p7 is another coordinate (or zero), often related to `GET_BLIP_COORDS, in the decompiled scripts.
        ///
        /// > Player player
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        /// > float p5
        /// > float p6
        /// > float p7
        /// > int flags
        ///
        /// </summary>
        NETWORK_START_RESPAWN_SEARCH_FOR_PLAYER = 0x5A6FFA2433E2F14C,
        /// <summary>
        /// p8, p9, p10 is another coordinate, or zero, often related to `GET_BLIP_COORDS in the decompiled scripts.
        ///
        /// > Player player
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > float width
        /// > float p8
        /// > float p9
        /// > float p10
        /// > int flags
        ///
        /// </summary>
        NETWORK_START_RESPAWN_SEARCH_IN_ANGLED_AREA_FOR_PLAYER = 0x4BA92A18502BCA61,
        /// <summary>
        /// Based on scripts such as in freemode.c how they call their vars vVar and fVar the 2nd and 3rd param it a Vector3 and Float, but the first is based on get_random_int_in_range..
        ///
        /// > int randomInt
        /// > Vector3* coordinates
        /// > float* heading
        ///
        /// </summary>
        NETWORK_GET_RESPAWN_RESULT = 0x371EA43692861CF1,
        /// <summary>
        /// *
        ///
        ///
        /// </summary>
        NETWORK_START_SOLO_TUTORIAL_SESSION = 0x17E0198B3882C2CB,
        /// <summary>
        /// NETWORK_ARE_*
        ///
        /// > Player player
        /// > int index
        ///
        /// </summary>
        _NETWORK_IS_PLAYER_EQUAL_TO_INDEX = 0x9DE986FC9A87C474,
        /// <summary>
        /// Note: This only works for vehicles, which appears to be a bug (since the setter _does_ work for every entity type and the name is 99% correct).
        ///
        /// > Entity entity
        ///
        /// </summary>
        _NETWORK_IS_ENTITY_CONCEALED = 0x71302EC70689052A,
        /// <summary>
        /// Works in Singleplayer too.
        /// Passing wrong data (e.g. hours above 23) will cause the game to crash.
        ///
        /// > int hours
        /// > int minutes
        /// > int seconds
        ///
        /// </summary>
        NETWORK_OVERRIDE_CLOCK_TIME = 0xE679E3E06E363892,
        /// <summary>
        /// To remove, see: NETWORK_REMOVE_ENTITY_AREA
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
        NETWORK_ADD_ENTITY_ANGLED_AREA = 0x376C6375BA60293A,
        /// <summary>
        /// Actually returns the version (TUNABLE_VERSION)
        ///
        ///
        /// </summary>
        NETWORK_GET_TUNABLE_CLOUD_CRC = 0x10BD227A753B0D84,
        /// <summary>
        /// Returns defaultValue if the tunable doesn't exist.
        ///
        /// > Hash tunableContext
        /// > Hash tunableName
        /// > BOOL defaultValue
        ///
        /// </summary>
        NETWORK_TRY_ACCESS_TUNABLE_BOOL_HASH = 0xC7420099936CE286,
        /// <summary>
        /// Return the content modifier id (the tunables context if you want) of a specific content.
        /// 
        /// It takes the content hash (which is the mission id hash), and return the content modifier id, used as the tunables context.
        /// 
        /// The mission id can be found on the Social club, for example, 'socialclub.rockstargames.com/games/gtav/jobs/job/A8M6Bz8MLEC5xngvDCzGwA'
        /// 
        /// 'A8M6Bz8MLEC5xngvDCzGwA' is the mission id, so the game hash this and use it as the parameter for this native.
        /// 
        ///
        /// > Hash contentHash
        ///
        /// </summary>
        NETWORK_GET_CONTENT_MODIFIER_LIST_ID = 0x187382F8A3E0A6C3,
        /// <summary>
        /// Allows vehicle wheels to be destructible even when the vehicle entity is invincible.
        ///
        /// > Entity entity
        /// > BOOL toggle
        ///
        /// </summary>
        _NETWORK_SET_VEHICLE_WHEELS_DESTRUCTIBLE = 0x890E2C5ABED7236D,
        /// <summary>
        /// In the console script dumps, this is only referenced once. 
        /// NETWORK::NETWORK_EXPLODE_VEHICLE(vehicle, 1, 0, 0);
        /// 
        /// ^^^^^ That must be PC script dumps? In X360 Script Dumps it is reference a few times with 2 differences in the parameters.
        /// Which as you see below is 1, 0, 0 + 1, 1, 0 + 1, 0, and a *param?
        /// 
        /// am_plane_takedown.c 
        /// network_explode_vehicle(net_to_veh(Local_40.imm_2), 1, 1, 0);
        /// 
        /// armenian2.c 
        /// network_explode_vehicle(Local_80[6 <2>], 1, 0, 0);
        /// 
        /// fm_horde_controler.c
        /// network_explode_vehicle(net_to_veh(*uParam0), 1, 0, *uParam0);
        /// 
        /// fm_mission_controller.c, has 6 hits so not going to list them.
        /// 
        /// Side note, setting the first parameter to 0 seems to mute sound or so?
        /// 
        /// Seems it's like ADD_EXPLOSION, etc. the first 2 params. The 3rd atm no need to worry since it always seems to be 0.
        /// 
        ///
        /// > Vehicle vehicle
        /// > BOOL isAudible
        /// > BOOL isInvisible
        /// > BOOL p3
        ///
        /// </summary>
        NETWORK_EXPLODE_VEHICLE = 0x301A42153C9AD707,
        /// <summary>
        /// value must be < 255
        ///
        /// > int id
        ///
        /// </summary>
        NETWORK_SET_PROPERTY_ID = 0x1775961C2FBBCB5C,
        /// <summary>
        /// index2 is unused
        ///
        /// > int index
        /// > int index2
        ///
        /// </summary>
        GET_COMMERCE_ITEM_CAT = 0x6F44CBF56D79FAC0,
        /// <summary>
        /// Access to the store for shark cards etc...
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_STORE_ENABLED = 0x9641A9FF718E9C5E,
        /// <summary>
        /// Downloads prod.cloud.rockstargames.com/titles/gta5/[platform]/check.json
        ///
        ///
        /// </summary>
        CLOUD_CHECK_AVAILABILITY = 0x4F18196C8D38768D,
        /// <summary>
        /// This native does absolutely nothing, just a nullsub
        ///
        ///
        /// </summary>
        _CLEAR_LAUNCH_PARAMS = 0x966DD84FB6A46017,
        /// <summary>
        /// Return the mission id of a job.
        ///
        /// > int p0
        ///
        /// </summary>
        UGC_GET_CONTENT_ID = 0x55AA95F481D694D2,
        /// <summary>
        /// Return the root content id of a job.
        ///
        /// > int p0
        ///
        /// </summary>
        UGC_GET_ROOT_CONTENT_ID = 0xC0173D6BFF4E0348,
        /// <summary>
        /// 0 = succeeded
        /// 1 = pending
        /// 2 = failed
        ///
        /// > int p0
        ///
        /// </summary>
        GET_STATUS_OF_TEXTURE_DOWNLOAD = 0x8BD6C6DEA20E82C6,
        /// <summary>
        /// Returns true if the NAT type is Strict (3) and a certain number of connections have failed.
        ///
        ///
        /// </summary>
        _NETWORK_SHOULD_SHOW_CONNECTIVITY_TROUBLESHOOTING = 0x82A2B386716608F1,
        /// <summary>
        /// index is always 18 in scripts
        ///
        /// > int index
        ///
        /// </summary>
        NETWORK_HAS_ROS_PRIVILEGE = 0xA699957E60D80214,
        /// <summary>
        /// Always returns -1. Seems to be XB1 specific.
        ///
        /// > Any* netHandle
        ///
        /// </summary>
        NETWORK_START_USER_CONTENT_PERMISSIONS_CHECK = 0xDEB2B99A1AF1A2A6,
        /// <summary>
        /// Returns true if dinput8.dll is present in the game directory.
        /// You will get following error message if that is true: "You are attempting to access GTA Online servers with an altered version of the game."
        ///
        ///
        /// </summary>
        _NETWORK_HAS_GAME_BEEN_ALTERED = 0x659CF2EF7F550C4F,
        /// <summary>
        /// Same as _NETWORK_GET_AVERAGE_LATENCY_FOR_PLAYER (0xD414BE129BB81B32)
        ///
        /// > Player player
        ///
        /// </summary>
        _NETWORK_GET_AVERAGE_LATENCY_FOR_PLAYER_2 = 0x0E3A041ED6AC2B45,
        /// <summary>
        /// NETWORK_GET_*
        ///
        /// > Player player
        ///
        /// </summary>
        _NETWORK_GET_OLDEST_RESEND_COUNT_FOR_PLAYER = 0x52C1EADAF7B10302,
        /// <summary>
        /// Returns the coordinates of another player.
        /// Does not work if you enter your own player id as p0 (will return `(0.0, 0.0, 0.0)` in that case).
        ///
        /// > Player player
        ///
        /// </summary>
        _NETWORK_GET_PLAYER_COORDS = 0x125E6D638B8605D4,
        /// <summary>
        /// Used by NetBlender
        ///
        /// > Entity entity
        ///
        /// </summary>
        _NETWORK_GET_LAST_VELOCITY_RECEIVED = 0x33DE49EDF4DDE77A,
        /// <summary>
        /// MulleDK19: This function is hard-coded to always return 1.
        ///
        ///
        /// </summary>
        _0xBD545D44CCE70597 = 0xBD545D44CCE70597,
        /// <summary>
        /// MulleDK19: This function is hard-coded to always return 1.
        ///
        ///
        /// </summary>
        _0xEBCAB9E5048434F4 = 0xEBCAB9E5048434F4,
        /// <summary>
        /// Hardcoded to return zero.
        /// 
        /// ==== PS4 specific info ====
        /// 
        /// Returns some sort of unavailable reason:
        /// -1 = REASON_INVALID
        ///  0 = REASON_OTHER
        ///  1 = REASON_SYSTEM_UPDATE
        ///  2 = REASON_GAME_UPDATE
        ///  3 = REASON_SIGNED_OUT
        ///  4 = REASON_AGE
        ///  5 = REASON_CONNECTION
        /// 
        /// =================================
        ///
        ///
        /// </summary>
        _0x74FB3E29E6D10FA9 = 0x74FB3E29E6D10FA9,
        /// <summary>
        /// MulleDK19: This function is hard-coded to always return 1.
        ///
        ///
        /// </summary>
        _0x7808619F31FF22DB = 0x7808619F31FF22DB,
        /// <summary>
        /// MulleDK19: This function is hard-coded to always return 0.
        ///
        ///
        /// </summary>
        _0xA0FA4EC6A05DA44E = 0xA0FA4EC6A05DA44E,
        /// <summary>
        /// NETWORK_IS_*
        /// 
        /// Seems to be related to PlayStation
        ///
        ///
        /// </summary>
        _0x8D11E61A4ABF49CC = 0x8D11E61A4ABF49CC,
        /// <summary>
        /// Hardcoded to return false.
        ///
        ///
        /// </summary>
        _0x64E5C4CC82847B73 = 0x64E5C4CC82847B73,
        /// <summary>
        /// NETWORK_SESSION_IS_*
        ///
        ///
        /// </summary>
        _0xD313DE83394AF134 = 0xD313DE83394AF134,
        /// <summary>
        /// NETWORK_SESSION_IS_*
        ///
        ///
        /// </summary>
        _0xBDB6F89C729CF388 = 0xBDB6F89C729CF388,
        /// <summary>
        /// NETWORK_GET_NUM_*
        ///
        ///
        /// </summary>
        _0x617F49C2668E6155 = 0x617F49C2668E6155,
        /// <summary>
        /// Appears to set whether a transition should be started when the session is migrating.
        /// 
        /// NETWORK_SET_*
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _0xA2E9C1AB8A92E8CD = 0xA2E9C1AB8A92E8CD,
        /// <summary>
        /// NETWORK_IS_TRANSITION_*
        ///
        ///
        /// </summary>
        _0xC571D0E77D8BBC29 = 0xC571D0E77D8BBC29,
        /// <summary>
        /// NETWORK_HAS_*
        ///
        /// > Any* p0
        ///
        /// </summary>
        _0x3F9990BF5F22759C = 0x3F9990BF5F22759C,
        /// <summary>
        /// Does nothing. It's just a nullsub.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _0x4A9FDE3A5A6D0437 = 0x4A9FDE3A5A6D0437,
        /// <summary>
        /// NETWORK_RE*
        ///
        ///
        /// </summary>
        _0xF083835B70BA9BFE = 0xF083835B70BA9BFE,
        /// <summary>
        /// NETWORK_HAS_*
        ///
        /// > Any* gamerHandle
        ///
        /// </summary>
        _0x71DC455F5CD1C2B1 = 0x71DC455F5CD1C2B1,
        /// <summary>
        /// NETWORK_SET_*
        ///
        /// > Any* p0
        /// > Any* p1
        ///
        /// </summary>
        _0x0D77A82DC2D0DA59 = 0x0D77A82DC2D0DA59,
        /// <summary>
        /// NETWORK_IS_*
        ///
        ///
        /// </summary>
        _0x14922ED3E38761F0 = 0x14922ED3E38761F0,
        /// <summary>
        /// Has something to do with a host request.
        /// 
        /// NETWORK_RE*
        ///
        ///
        /// </summary>
        _0x741A3D8380319A81 = 0x741A3D8380319A81,
        /// <summary>
        /// I've had this return the player's ped handle sometimes, but also other random entities.
        /// Whatever p0 is, it's at least not synced to other players.
        /// At least not all the time, some p0 values actually output the same entity, (different handle of course, but same entity).
        /// But another p0 value may return an entity for player x, but not for player y (it'll just return -1 even if the entity exists on both clients).
        /// 
        /// Returns an entity handle or -1, value changes based on p0's value.
        ///
        /// > Any p0
        ///
        /// </summary>
        _0x37D5F739FD494675 = 0x37D5F739FD494675,
        /// <summary>
        /// Sets some voice chat related value.
        /// 
        /// NETWORK_SET_*
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _0x3C5C1E2C2FF814B1 = 0x3C5C1E2C2FF814B1,
        /// <summary>
        /// Sets some voice chat related value.
        /// 
        /// NETWORK_SET_*
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _0x9D7AFCBF21C51712 = 0x9D7AFCBF21C51712,
        /// <summary>
        /// Sets some voice chat related value.
        /// 
        /// NETWORK_SET_*
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _0x6A5D89D7769A40D8 = 0x6A5D89D7769A40D8,
        /// <summary>
        /// NETWORK_SET_*
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _0x8EF52ACAECC51D9C = 0x8EF52ACAECC51D9C,
        /// <summary>
        /// SET_NETWORK_*
        ///
        /// > BOOL p0
        ///
        /// </summary>
        _0x13F1FCB111B820B0 = 0x13F1FCB111B820B0,
        /// <summary>
        /// IS_*
        ///
        /// > Entity entity
        ///
        /// </summary>
        _0x7EF7649B64D7FF10 = 0x7EF7649B64D7FF10,
        /// <summary>
        /// NETWORK_A*
        /// Similar structure as NETWORK_ADD_ENTITY_TO_SYNCHRONISED_SCENE but it includes this time a hash.
        /// In casino_slots it is used one time in a synced scene involving a ped and the slot machine?
        ///
        /// > int netScene
        /// > Hash modelHash
        /// > float x
        /// > float y
        /// > float z
        /// > float p5
        /// > const char* p6
        /// > float p7
        /// > float p8
        /// > int flags
        ///
        /// </summary>
        _0x45F35C0EDC33B03B = 0x45F35C0EDC33B03B,
        /// <summary>
        /// p0 is always 0. p1 is pointing to a global.
        ///
        /// > int p0
        /// > Any p1
        ///
        /// </summary>
        _0xFB1F9381E80FA13F = 0xFB1F9381E80FA13F,
        /// <summary>
        /// teamId must be < 3, instanceId must be < 64
        /// 
        /// NETWORK_A*
        ///
        /// > int teamId
        /// > int instanceId
        ///
        /// </summary>
        _0xFB680D403909DC70 = 0xFB680D403909DC70,
        /// <summary>
        /// nullsub, doesn't do anything
        ///
        /// > Any p0
        /// > Any p1
        ///
        /// </summary>
        _0x3FC795691834481D = 0x3FC795691834481D,
        /// <summary>
        /// Does nothing (it's a nullsub).
        ///
        /// > Any p0
        ///
        /// </summary>
        _0xB606E6CC59664972 = 0xB606E6CC59664972,
        /// <summary>
        /// IS_COMMERCE_*
        ///
        ///
        /// </summary>
        _0x1D4DC17C38FEAFF0 = 0x1D4DC17C38FEAFF0,
        /// <summary>
        /// RESET_*
        /// 
        /// sfink: related to: NETWORK_BAIL
        /// NETWORK_BAIL_TRANSITION
        /// NETWORK_JOIN_GROUP_ACTIVITY
        /// NETWORK_JOIN_TRANSITION
        /// NETWORK_LAUNCH_TRANSITION
        /// NETWORK_SESSION_HOST
        /// NETWORK_SESSION_HOST_CLOSED
        /// NETWORK_SESSION_HOST_FRIENDS_ONLY
        /// NETWORK_SESSION_HOST_SINGLE_PLAYER
        /// NETWORK_SESSION_VOICE_LEAVE
        ///
        ///
        /// </summary>
        _0x444C4525ECE0A4B9 = 0x444C4525ECE0A4B9,
        /// <summary>
        /// IS_*
        ///
        ///
        /// </summary>
        _0x59328EB08C5CEB2B = 0x59328EB08C5CEB2B,
        /// <summary>
        /// Checks some commerce stuff
        ///
        ///
        /// </summary>
        _0x754615490A029508 = 0x754615490A029508,
        /// <summary>
        /// Checks some commerce stuff
        ///
        ///
        /// </summary>
        _0x155467ACA0F55705 = 0x155467ACA0F55705,
        /// <summary>
        /// MulleDK19: This function is hard-coded to always return 0.
        ///
        ///
        /// </summary>
        _0x8B0C2964BA471961 = 0x8B0C2964BA471961,
        /// <summary>
        /// MulleDK19: This function is hard-coded to always return 0.
        ///
        ///
        /// </summary>
        _0x88B588B41FF7868E = 0x88B588B41FF7868E,
        /// <summary>
        /// MulleDK19: This function is hard-coded to always return 0.
        ///
        ///
        /// </summary>
        _0x67FC09BC554A75E5 = 0x67FC09BC554A75E5,
        /// <summary>
        /// Returns true if profile setting 901 is set to true and sets it to false.
        /// 
        /// NETWORK_C*
        ///
        ///
        /// </summary>
        _0x60EDD13EB3AC1FF3 = 0x60EDD13EB3AC1FF3,
        /// <summary>
        /// NETWORK_S*
        ///
        ///
        /// </summary>
        _0xCA59CCAE5D01E4CE = 0xCA59CCAE5D01E4CE,
        /// <summary>
        /// Does nothing (it's a nullsub).
        ///
        /// > Player player
        ///
        /// </summary>
        _0x6BFF5F84102DF80A = 0x6BFF5F84102DF80A,
        /// <summary>
        /// This native does absolutely nothing, just a nullsub
        ///
        ///
        /// </summary>
        _0x5C497525F803486B = 0x5C497525F803486B,
        /// <summary>
        /// MulleDK19: This function is hard-coded to always return 0.
        ///
        ///
        /// </summary>
        _0x6FB7BB3607D27FA2 = 0x6FB7BB3607D27FA2,
        /// <summary>
        /// NETWORK_GET_*
        ///
        /// > Entity entity
        ///
        /// </summary>
        _0x64D779659BC37B19 = 0x64D779659BC37B19,
        /// <summary>
        /// NETWORK_GET_P*
        ///
        /// > Entity entity
        ///
        /// </summary>
        _0xAA5FAFCD2C5F5E47 = 0xAA5FAFCD2C5F5E47,
        /// <summary>
        /// Does nothing (it's a nullsub).
        ///
        ///
        /// </summary>
        _0xAEDF1BC1C133D6E3 = 0xAEDF1BC1C133D6E3,
        /// <summary>
        /// Does nothing (it's a nullsub).
        ///
        ///
        /// </summary>
        _0x2555CF7DA5473794 = 0x2555CF7DA5473794,
        /// <summary>
        /// Does nothing (it's a nullsub).
        ///
        ///
        /// </summary>
        _0x6FD992C4A1C1B986 = 0x6FD992C4A1C1B986,
        NETWORK_IS_CLOUD_AVAILABLE = 0x9A4CF4F48AD77302,
        NETWORK_HAS_SOCIAL_CLUB_ACCOUNT = 0x67A5589628E0CFF6,
        NETWORK_ARE_SOCIAL_CLUB_POLICIES_CURRENT = 0xBA9775570DB788CF,
        NETWORK_HAVE_ONLINE_PRIVILEGES = 0x25CB5A9F37BFD063,
        _NETWORK_HAS_AGE_RESTRICTED_PROFILE = 0x1353F87E89946207,
        NETWORK_HAVE_USER_CONTENT_PRIVILEGES = 0x72D918C99BCACC54,
        NETWORK_HAVE_COMMUNICATION_PRIVILEGES = 0xAEEF48CDF5B6CE7C,
        NETWORK_CHECK_USER_CONTENT_PRIVILEGES = 0x595F028698072DD9,
        NETWORK_CHECK_COMMUNICATION_PRIVILEGES = 0x83F28CE49FBBFFBA,
        NETWORK_HAS_SOCIAL_NETWORKING_SHARING_PRIV = 0x76BF03FADBF154F5,
        NETWORK_GET_AGE_GROUP = 0x9614B71F8ADB982B,
        _NETWORK_HAVE_ONLINE_PRIVILEGE_2 = 0x5EA784D197556507,
        NETWORK_CAN_BAIL = 0x580CE4438479CC61,
        NETWORK_BAIL = 0x95914459A87EBA28,
        _NETWORK_TRANSITION_TRACK = 0xC3BFED92026A2AAD,
        NETWORK_IS_MULTIPLAYER_DISABLED = 0x9747292807126EDA,
        NETWORK_CAN_ENTER_MULTIPLAYER = 0x7E782A910C362C25,
        NETWORK_SESSION_FRIEND_MATCHMAKING = 0x2CFC76E0D087C994,
        NETWORK_SESSION_CREW_MATCHMAKING = 0x94BC51E9449D917F,
        NETWORK_SESSION_ACTIVITY_QUICKMATCH = 0xBE3E347A87ACEB82,
        NETWORK_SESSION_HOST_CLOSED = 0xED34C0C02C098BB7,
        NETWORK_SESSION_IS_CLOSED_FRIENDS = 0xFBCFA2EA2E206890,
        NETWORK_SESSION_IS_CLOSED_CREW = 0x74732C6CA90DA2B4,
        NETWORK_SESSION_IS_SOLO = 0xF3929C2379B60CCE,
        NETWORK_SESSION_IS_PRIVATE = 0xCEF70AA5B3F89BA1,
        NETWORK_SESSION_GET_KICK_VOTE = 0xD6D09A6F32F49EF1,
        NETWORK_JOIN_PREVIOUSLY_FAILED_SESSION = 0x59DF79317F85A7E0,
        NETWORK_JOIN_PREVIOUSLY_FAILED_TRANSITION = 0xFFE1E5B792D92B34,
        NETWORK_SESSION_SET_MATCHMAKING_GROUP = 0x49EC8030F5015F8B,
        NETWORK_SESSION_GET_MATCHMAKING_GROUP_FREE = 0x56CE820830EF040B,
        NETWORK_SESSION_SET_MATCHMAKING_PROPERTY_ID = 0x3F52E880AAF6C8CA,
        NETWORK_SESSION_SET_MATCHMAKING_MENTAL_STATE = 0xF1EEA2DDA9FFA69D,
        NETWORK_SESSION_VALIDATE_JOIN = 0xC19F6C8E7865A6FF,
        NETWORK_CLEAR_FOLLOWERS = 0x058F43EC59A8631A,
        NETWORK_GET_GLOBAL_MULTIPLAYER_CLOCK = 0x6D03BFBD643B2A02,
        _NETWORK_GET_TARGETING_MODE = 0xDFFA5BE8381C3314,
        NETWORK_FIND_GAMERS_IN_CREW = 0xE532D6811B3A4D2A,
        NETWORK_FIND_MATCHED_GAMERS = 0xF7B2CFDE5C9F700D,
        NETWORK_IS_FINDING_GAMERS = 0xDDDF64C91BFCF0AA,
        NETWORK_DID_FIND_GAMERS_SUCCEED = 0xF9B83B77929D8863,
        NETWORK_GET_NUM_FOUND_GAMERS = 0xA1B043EE79A916FB,
        NETWORK_GET_FOUND_GAMER = 0x9DCFF2AFB68B3476,
        NETWORK_CLEAR_FOUND_GAMERS = 0x6D14CCEE1B40381A,
        NETWORK_QUEUE_GAMER_FOR_STATUS = 0x85A0EF54A500882C,
        NETWORK_GET_GAMER_STATUS_FROM_QUEUE = 0x2CC848A861D01493,
        NETWORK_IS_GETTING_GAMER_STATUS = 0x94A8394D150B013A,
        NETWORK_DID_GET_GAMER_STATUS_SUCCEED = 0x5AE17C6B0134B7F1,
        NETWORK_GET_GAMER_STATUS_RESULT = 0x02A8BEC6FD9AF660,
        NETWORK_CLEAR_GET_GAMER_STATUS = 0x86E0660E4F5C956D,
        NETWORK_SESSION_JOIN_INVITE = 0xC6F8AB8A4189CF3A,
        NETWORK_SESSION_CANCEL_INVITE = 0x2FBF47B1B36D36F9,
        NETWORK_SESSION_FORCE_CANCEL_INVITE = 0xA29177F7703B5644,
        NETWORK_HAS_PENDING_INVITE = 0xAC8C7B9B88C4A668,
        NETWORK_SESSION_WAS_INVITED = 0x23DFB504655D0CE4,
        NETWORK_SESSION_GET_INVITER = 0xE57397B4A3429DD0,
        NETWORK_SUPPRESS_INVITE = 0xA0682D67EF1FBA3D,
        NETWORK_BLOCK_INVITES = 0x34F9E9049454A7A0,
        NETWORK_BLOCK_JOIN_QUEUE_INVITES = 0xCFEB8AF24FC1D0BB,
        _NETWORK_BLOCK_KICKED_PLAYERS = 0x6B07B9CE4D390375,
        NETWORK_SET_SCRIPT_READY_FOR_EVENTS = 0x7AC752103856FB20,
        NETWORK_IS_OFFLINE_INVITE_PENDING = 0x74698374C45701D2,
        NETWORK_CLEAR_OFFLINE_INVITE_PENDING = 0x140E6A44870A11CE,
        NETWORK_SESSION_LEAVE_SINGLE_PLAYER = 0x3442775428FD2DAA,
        NETWORK_IS_GAME_IN_PROGRESS = 0x10FAB35428CCC9D7,
        NETWORK_IS_SESSION_ACTIVE = 0xD83C2B94E7508980,
        NETWORK_IS_IN_SESSION = 0xCA97246103B63917,
        NETWORK_IS_SESSION_BUSY = 0xF4435D66A8E2905E,
        NETWORK_CAN_SESSION_END = 0x4EEBC3694E49C572,
        NETWORK_SESSION_MARK_VISIBLE = 0x271CC6AB59EBF9A5,
        NETWORK_SESSION_IS_VISIBLE = 0xBA416D68C631496A,
        NETWORK_SESSION_BLOCK_JOIN_REQUESTS = 0xA73667484D7037C3,
        NETWORK_SESSION_CHANGE_SLOTS = 0xB4AB419E0D86ACAE,
        NETWORK_SESSION_GET_PRIVATE_SLOTS = 0x53AFD64C6758F2F9,
        NETWORK_SESSION_VOICE_HOST = 0x9C1556705F864230,
        NETWORK_SESSION_VOICE_LEAVE = 0x6793E42BE02B575D,
        NETWORK_SESSION_VOICE_RESPOND_TO_REQUEST = 0x7F8413B7FC2AA6B9,
        NETWORK_SESSION_VOICE_SET_TIMEOUT = 0x5B8ED3DB018927B1,
        NETWORK_SESSION_IS_IN_VOICE_SESSION = 0x855BC38818F6F684,
        NETWORK_SESSION_IS_VOICE_SESSION_BUSY = 0xEF0912DDF7C4CB4B,
        NETWORK_SET_ACTIVITY_SPECTATOR = 0x75138790B4359A74,
        NETWORK_IS_ACTIVITY_SPECTATOR = 0x12103B9E0C9F92FB,
        NETWORK_SET_ACTIVITY_SPECTATOR_MAX = 0x9D277B76D1D12222,
        NETWORK_GET_ACTIVITY_PLAYER_NUM = 0x73E2B500410DA5A2,
        NETWORK_IS_ACTIVITY_SPECTATOR_FROM_HANDLE = 0x2763BBAA72A7BCB9,
        NETWORK_DO_TRANSITION_QUICKMATCH = 0x71FB0EBCD4915D56,
        NETWORK_DO_TRANSITION_QUICKMATCH_ASYNC = 0xA091A5E44F0072E5,
        NETWORK_DO_TRANSITION_QUICKMATCH_WITH_GROUP = 0x9C4AB58491FDC98A,
        NETWORK_JOIN_GROUP_ACTIVITY = 0xA06509A691D12BE4,
        NETWORK_IS_TRANSITION_CLOSED_FRIENDS = 0x6512765E3BE78C50,
        NETWORK_IS_TRANSITION_CLOSED_CREW = 0x0DBD5D7E3C5BEC3B,
        NETWORK_IS_TRANSITION_SOLO = 0x5DC577201723960A,
        NETWORK_IS_TRANSITION_PRIVATE = 0x5A6AA44FF8E931E6,
        NETWORK_SET_TRANSITION_CREATOR_HANDLE = 0xEF26739BCD9907D5,
        NETWORK_CLEAR_TRANSITION_CREATOR_HANDLE = 0xFB3272229A82C759,
        NETWORK_INVITE_GAMERS_TO_TRANSITION = 0x4A595C32F77DFF76,
        NETWORK_SET_GAMER_INVITED_TO_TRANSITION = 0xCA2C8073411ECDB6,
        NETWORK_LEAVE_TRANSITION = 0xD23A1A815D21DB19,
        NETWORK_LAUNCH_TRANSITION = 0x2DCF46CB1A4F0884,
        NETWORK_BAIL_TRANSITION = 0xEAA572036990CD1B,
        NETWORK_DO_TRANSITION_TO_GAME = 0x3E9BB38102A589B0,
        NETWORK_DO_TRANSITION_TO_NEW_GAME = 0x4665F51EFED00034,
        NETWORK_DO_TRANSITION_TO_NEW_FREEMODE = 0x9E80A5BA8109F974,
        NETWORK_IS_TRANSITION_TO_GAME = 0x9D7696D8F4FA6CB7,
        NETWORK_APPLY_TRANSITION_PARAMETER = 0x521638ADA1BA0D18,
        NETWORK_APPLY_TRANSITION_PARAMETER_STRING = 0xEBEFC2E77084F599,
        NETWORK_MARK_TRANSITION_GAMER_AS_FULLY_JOINED = 0x5728BB6D63E3FF1D,
        NETWORK_IS_TRANSITION_HOST = 0x0B824797C9BF2159,
        NETWORK_IS_TRANSITION_HOST_FROM_HANDLE = 0x6B5C83BA3EFE6A10,
        NETWORK_GET_TRANSITION_HOST = 0x65042B9774C4435E,
        NETWORK_IS_IN_TRANSITION = 0x68049AEFF83D8F0A,
        NETWORK_IS_TRANSITION_STARTED = 0x53FA83401D9C07FE,
        NETWORK_IS_TRANSITION_BUSY = 0x520F3282A53D26B7,
        NETWORK_IS_TRANSITION_MATCHMAKING = 0x292564C735375EDF,
        NETWORK_OPEN_TRANSITION_MATCHMAKING = 0x2B3A8F7CA3A38FDE,
        NETWORK_CLOSE_TRANSITION_MATCHMAKING = 0x43F4DBA69710E01E,
        NETWORK_IS_TRANSITION_OPEN_TO_MATCHMAKING = 0x37A4494483B9F5C9,
        NETWORK_SET_TRANSITION_VISIBILITY_LOCK = 0x0C978FDA19692C2C,
        NETWORK_IS_TRANSITION_VISIBILITY_LOCKED = 0xD0A484CB2F829FBE,
        NETWORK_SET_TRANSITION_ACTIVITY_ID = 0x30DE938B516F0AD2,
        NETWORK_CHANGE_TRANSITION_SLOTS = 0xEEEDA5E6D7080987,
        NETWORK_HAS_PLAYER_STARTED_TRANSITION = 0x9AC9CCBFA8C29795,
        NETWORK_ARE_TRANSITION_DETAILS_VALID = 0x2615AA2A695930C1,
        NETWORK_HAS_INVITED_GAMER_TO_TRANSITION = 0x7284A47B3540E6CF,
        NETWORK_IS_ACTIVITY_SESSION = 0x05095437424397FA,
        NETWORK_SEND_INVITE_VIA_PRESENCE = 0xC3C7A6AFDB244624,
        NETWORK_GET_NUM_PRESENCE_INVITES = 0xCEFA968912D0F78D,
        NETWORK_ACCEPT_PRESENCE_INVITE = 0xFA91550DF9318B22,
        NETWORK_REMOVE_PRESENCE_INVITE = 0xF0210268DB0974B1,
        NETWORK_GET_PRESENCE_INVITE_ID = 0xDFF09646E12EC386,
        NETWORK_GET_PRESENCE_INVITE_INVITER = 0x4962CC4AA2F345B7,
        NETWORK_GET_PRESENCE_INVITE_HANDLE = 0x38D5B0FEBB086F75,
        NETWORK_GET_PRESENCE_INVITE_SESSION_ID = 0x26E1CD96B0903D60,
        NETWORK_GET_PRESENCE_INVITE_CONTENT_ID = 0x24409FC4C55CB22D,
        NETWORK_GET_PRESENCE_INVITE_PLAYLIST_LENGTH = 0xD39B3FFF8FFDD5BF,
        NETWORK_GET_PRESENCE_INVITE_PLAYLIST_CURRENT = 0x728C4CC7920CD102,
        NETWORK_GET_PRESENCE_INVITE_FROM_ADMIN = 0x3DBF2DF0AEB7D289,
        NETWORK_GET_PRESENCE_INVITE_IS_TOURNAMENT = 0x8806CEBFABD3CE05,
        NETWORK_HAS_FOLLOW_INVITE = 0x76D9B976C4C09FDE,
        NETWORK_ACTION_FOLLOW_INVITE = 0xC88156EBB786F8D5,
        NETWORK_CLEAR_FOLLOW_INVITE = 0x439BFDE3CD0610F6,
        NETWORK_REMOVE_TRANSITION_INVITE = 0x7524B431B2E6F7EE,
        NETWORK_REMOVE_ALL_TRANSITION_INVITE = 0x726E0375C7A26368,
        NETWORK_INVITE_GAMERS = 0x9D80CD1D0E6327DE,
        NETWORK_HAS_INVITED_GAMER = 0x4D86CD31E8976ECE,
        NETWORK_GET_CURRENTLY_SELECTED_GAMER_HANDLE_FROM_INVITE_MENU = 0x74881E6BCAE2327C,
        NETWORK_SET_CURRENTLY_SELECTED_GAMER_HANDLE_FROM_INVITE_MENU = 0x7206F674F2A3B1BB,
        NETWORK_SET_INVITE_ON_CALL_FOR_INVITE_MENU = 0x66F010A4B031A331,
        NETWORK_CHECK_DATA_MANAGER_SUCCEEDED_FOR_HANDLE = 0x44B37CDCAE765AAE,
        FILLOUT_PM_PLAYER_LIST = 0xCBBD7C4991B64809,
        FILLOUT_PM_PLAYER_LIST_WITH_NAMES = 0x716B6DB9D1886106,
        REFRESH_PLAYER_LIST_STATS = 0xE26CCFF8094D8C74,
        NETWORK_SET_CURRENT_DATA_MANAGER_HANDLE = 0x796A87B3B68D1F3D,
        _NETWORK_GET_PLATFORM_PARTY_UNK = 0x01ABCE5E7CBDA196,
        NETWORK_GET_PLATFORM_PARTY_MEMBERS = 0x120364DE2845DAF8,
        NETWORK_SEED_RANDOM_NUMBER_GENERATOR = 0xF1B84178F8674195,
        NETWORK_GET_RANDOM_INT = 0x599E4FA1F87EB5FF,
        NETWORK_PLAYER_IS_CHEATER = 0x655B91F1495A9090,
        NETWORK_PLAYER_GET_CHEATER_REASON = 0x172F75B6EE2233BA,
        NETWORK_PLAYER_IS_BADSPORT = 0x19D8DA0E5A68045A,
        _REMOTE_CHEAT_DETECTED = 0x472841A026D26D8B,
        BAD_SPORT_PLAYER_LEFT_DETECTED = 0xEC5E3AF5289DCA81,
        NETWORK_APPLY_PED_SCAR_DATA = 0xE66C690248F11150,
        NETWORK_SET_THIS_SCRIPT_IS_NETWORK_SCRIPT = 0x1CA59E306ECB80A5,
        _NETWORK_IS_THIS_SCRIPT_MARKED = 0xD1110739EEADB592,
        NETWORK_GET_THIS_SCRIPT_IS_NETWORK_SCRIPT = 0x2910669969E9535E,
        NETWORK_GET_NUM_PARTICIPANTS = 0x18D0456E86604654,
        NETWORK_GET_SCRIPT_STATUS = 0x57D158647A6BFABF,
        NETWORK_REGISTER_HOST_BROADCAST_VARIABLES = 0x3E9B2F01C50DF595,
        NETWORK_REGISTER_PLAYER_BROADCAST_VARIABLES = 0x3364AA97340CA215,
        NETWORK_FINISH_BROADCASTING_DATA = 0x64F62AFB081E260D,
        NETWORK_HAS_RECEIVED_HOST_BROADCAST_DATA = 0x5D10B3795F3FC886,
        NETWORK_GET_PLAYER_INDEX = 0x24FB80D107371267,
        NETWORK_GET_PARTICIPANT_INDEX = 0x1B84DF6AF2A46938,
        NETWORK_IS_PLAYER_CONNECTED = 0x93DC1BE4E1ABE9D1,
        NETWORK_GET_TOTAL_NUM_PLAYERS = 0xCF61D4B4702EE9EB,
        NETWORK_IS_PARTICIPANT_ACTIVE = 0x6FF8FF40B6357D45,
        NETWORK_IS_PLAYER_ACTIVE = 0xB8DFD30D6973E135,
        NETWORK_IS_PLAYER_A_PARTICIPANT = 0x3CA58F6CB7CBD784,
        NETWORK_IS_HOST_OF_THIS_SCRIPT = 0x83CD99A1E6061AB5,
        NETWORK_GET_HOST_OF_THIS_SCRIPT = 0xC7B4D79B01FA7A5C,
        NETWORK_SET_MISSION_FINISHED = 0x3B3D11CD9FFCDFC9,
        NETWORK_IS_SCRIPT_ACTIVE = 0x9D40DF90FAD26098,
        NETWORK_IS_SCRIPT_ACTIVE_BY_HASH = 0xDA7DE67F5FE5EE13,
        NETWORK_GET_NUM_SCRIPT_PARTICIPANTS = 0x3658E8CD94FC121A,
        NETWORK_GET_INSTANCE_ID_OF_THIS_SCRIPT = 0x638A3A81733086DB,
        _NETWORK_GET_POSITION_HASH_OF_THIS_SCRIPT = 0x257ED0FADF750BCF,
        NETWORK_IS_PLAYER_A_PARTICIPANT_ON_SCRIPT = 0x1AD5B71586B94820,
        NETWORK_GET_DESTROYER_OF_NETWORK_ID = 0x7A1ADEEF01740A24,
        _NETWORK_GET_DESTROYER_OF_ENTITY = 0x4CACA84440FA26F6,
        NETWORK_GET_ENTITY_KILLER_OF_PLAYER = 0x42B2DAA6B596F5F8,
        NETWORK_RESURRECT_LOCAL_PLAYER = 0xEA23C49EAA83ACFB,
        NETWORK_SET_LOCAL_PLAYER_INVINCIBLE_TIME = 0x2D95C7E2D7E07307,
        NETWORK_IS_LOCAL_PLAYER_INVINCIBLE = 0x8A8694B48715B000,
        NETWORK_DISABLE_INVINCIBLE_FLASHING = 0x9DD368BF06983221,
        _NETWORK_PED_FORCE_GAME_STATE_UPDATE = 0xF0BC9BCD24A511D5,
        NETWORK_SET_LOCAL_PLAYER_SYNC_LOOK_AT = 0x524FF0AEFF9C3973,
        NETWORK_HAS_ENTITY_BEEN_REGISTERED_WITH_THIS_THREAD = 0xB07D3185E11657A5,
        NETWORK_GET_NETWORK_ID_FROM_ENTITY = 0xA11700682F3AD45C,
        NETWORK_GET_ENTITY_FROM_NETWORK_ID = 0xCE4E5D9B0A4FF560,
        NETWORK_GET_ENTITY_IS_NETWORKED = 0xC7827959479DCC78,
        NETWORK_GET_ENTITY_IS_LOCAL = 0x0991549DE4D64762,
        NETWORK_REGISTER_ENTITY_AS_NETWORKED = 0x06FAACD625D80CAA,
        NETWORK_UNREGISTER_NETWORKED_ENTITY = 0x7368E683BB9038D6,
        NETWORK_DOES_NETWORK_ID_EXIST = 0x38CE16C96BD11344,
        NETWORK_DOES_ENTITY_EXIST_WITH_NETWORK_ID = 0x18A47D074708FD68,
        NETWORK_REQUEST_CONTROL_OF_NETWORK_ID = 0xA670B3662FAFFBD0,
        NETWORK_HAS_CONTROL_OF_NETWORK_ID = 0x4D36070FE0215186,
        NETWORK_REQUEST_CONTROL_OF_ENTITY = 0xB69317BF5E782347,
        NETWORK_REQUEST_CONTROL_OF_DOOR = 0x870DDFD5A4A796E4,
        NETWORK_HAS_CONTROL_OF_ENTITY = 0x01BF60A500E28887,
        NETWORK_HAS_CONTROL_OF_PICKUP = 0x5BC9495F0B3B6FA6,
        NETWORK_HAS_CONTROL_OF_DOOR = 0xCB3C68ADB06195DF,
        NETWORK_IS_DOOR_NETWORKED = 0xC01E93FAC20C3346,
        NET_TO_VEH = 0x367B936610BA360C,
        NETWORK_GET_LOCAL_HANDLE = 0xE86051786B66CD8E,
        NETWORK_HANDLE_FROM_USER_ID = 0xDCD51DD8F87AEC5C,
        NETWORK_HANDLE_FROM_MEMBER_ID = 0xA0FD21BED61E5C4C,
        NETWORK_HANDLE_FROM_PLAYER = 0x388EB2B86C73B6B3,
        NETWORK_HASH_FROM_PLAYER_HANDLE = 0xBC1D768F2F5D6C05,
        NETWORK_HASH_FROM_GAMER_HANDLE = 0x58575AC3CF2CA8EC,
        NETWORK_HANDLE_FROM_FRIEND = 0xD45CB817D7E177D2,
        NETWORK_GAMERTAG_FROM_HANDLE_START = 0x9F0C0A981D73FA56,
        NETWORK_GAMERTAG_FROM_HANDLE_PENDING = 0xB071E27958EF4CF0,
        NETWORK_GAMERTAG_FROM_HANDLE_SUCCEEDED = 0xFD00798DBA7523DD,
        NETWORK_GET_GAMERTAG_FROM_HANDLE = 0x426141162EBE5CDB,
        NETWORK_ARE_HANDLES_THE_SAME = 0x57DBA049E110F217,
        NETWORK_IS_HANDLE_VALID = 0x6F79B93B0A8E4133,
        NETWORK_GET_PLAYER_FROM_GAMER_HANDLE = 0xCE5F689CF5A0A49D,
        NETWORK_MEMBER_ID_FROM_GAMER_HANDLE = 0xC82630132081BB6F,
        NETWORK_IS_GAMER_IN_MY_SESSION = 0x0F10B05DDF8D16E9,
        NETWORK_SHOW_PROFILE_UI = 0x859ED1CEA343FCA8,
        NETWORK_PLAYER_INDEX_IS_CHEATER = 0x565E430DB3B05BEC,
        _NETWORK_GET_ENTITY_NET_SCRIPT_ID = 0x815F18AD865F057F,
        NETWORK_IS_INACTIVE_PROFILE = 0x7E58745504313A2E,
        NETWORK_GET_MAX_FRIENDS = 0xAFEBB0D5D8F687D2,
        NETWORK_GET_FRIEND_COUNT = 0x203F1CFD823B27A4,
        NETWORK_GET_FRIEND_NAME = 0xE11EBBB2A783FE8B,
        _NETWORK_GET_FRIEND_NAME_FROM_INDEX = 0x4164F227D052E293,
        NETWORK_IS_FRIEND_ONLINE = 0x425A44533437B64D,
        NETWORK_IS_FRIEND_HANDLE_ONLINE = 0x87EB7A3FFCB314DB,
        NETWORK_IS_FRIEND_IN_MULTIPLAYER = 0x57005C18827F3A28,
        NETWORK_IS_FRIEND = 0x1A24A179F9B31654,
        NETWORK_IS_ADDING_FRIEND = 0x6EA101606F6E4D81,
        NETWORK_ADD_FRIEND = 0x8E02D73914064223,
        NETWORK_IS_FRIEND_INDEX_ONLINE = 0xBAD8F2A42B844821,
        NETWORK_SET_PLAYER_IS_PASSIVE = 0x1B857666604B1A74,
        NETWORK_GET_PLAYER_OWNS_WAYPOINT = 0x82377B65E943F72D,
        NETWORK_CAN_SET_WAYPOINT = 0xC927EC229934AF60,
        NETWORK_HAS_HEADSET = 0xE870F9F1F7B4F1FA,
        NETWORK_IS_LOCAL_TALKING = 0xC0D2AF00BCC234CA,
        NETWORK_GAMER_HAS_HEADSET = 0xF2FD55CB574BCC55,
        NETWORK_IS_GAMER_TALKING = 0x71C33B22606CD88A,
        NETWORK_CAN_COMMUNICATE_WITH_GAMER = 0xA150A4F065806B1F,
        NETWORK_IS_GAMER_MUTED_BY_ME = 0xCE60DE011B6C7978,
        NETWORK_AM_I_MUTED_BY_GAMER = 0xDF02A2C93F1F26DA,
        NETWORK_IS_GAMER_BLOCKED_BY_ME = 0xE944C4F5AF1B5883,
        NETWORK_AM_I_BLOCKED_BY_GAMER = 0x15337C7C268A27B2,
        NETWORK_CAN_VIEW_GAMER_USER_CONTENT = 0xB57A49545BA53CE7,
        NETWORK_HAS_VIEW_GAMER_USER_CONTENT_RESULT = 0xCCA4318E1AB03F1F,
        NETWORK_CAN_PLAY_MULTIPLAYER_WITH_GAMER = 0x07DD29D5E22763F1,
        NETWORK_CAN_GAMER_PLAY_MULTIPLAYER_WITH_ME = 0x135F9B7B7ADD2185,
        NETWORK_PLAYER_HAS_HEADSET = 0x3FB99A8B08D18FD6,
        NETWORK_IS_PLAYER_MUTED_BY_ME = 0x8C71288AE68EDE39,
        NETWORK_AM_I_MUTED_BY_PLAYER = 0x9D6981DFC91A8604,
        NETWORK_IS_PLAYER_BLOCKED_BY_ME = 0x57AF1F8E27483721,
        NETWORK_AM_I_BLOCKED_BY_PLAYER = 0x87F395D957D4353D,
        NETWORK_GET_PLAYER_LOUDNESS = 0x21A1684A25C2867F,
        NETWORK_SET_TALKER_PROXIMITY = 0xCBF12D65F95AD686,
        NETWORK_GET_TALKER_PROXIMITY = 0x84F0F13120B4E098,
        NETWORK_SET_VOICE_ACTIVE = 0xBABEC9E69A91C57B,
        NETWORK_OVERRIDE_TRANSITION_CHAT = 0xAF66059A131AA269,
        NETWORK_SET_TEAM_ONLY_CHAT = 0xD5B4883AC32F24C3,
        NETWORK_OVERRIDE_TEAM_RESTRICTIONS = 0x6F697A66CE78674E,
        NETWORK_SET_OVERRIDE_SPECTATOR_MODE = 0x70DA3BF8DACD3210,
        NETWORK_SET_NO_SPECTATOR_CHAT = 0xF46A1E03E8755980,
        NETWORK_OVERRIDE_SEND_RESTRICTIONS_ALL = 0x57B192B4D4AD23D5,
        NETWORK_SET_VOICE_CHANNEL = 0xEF6212C2EFEF1A23,
        NETWORK_CLEAR_VOICE_CHANNEL = 0xE036A705F989E049,
        NETWORK_APPLY_VOICE_PROXIMITY_OVERRIDE = 0xDBD2056652689917,
        NETWORK_CLEAR_VOICE_PROXIMITY_OVERRIDE = 0xF03755696450470C,
        NETWORK_SET_FRIENDLY_FIRE_OPTION = 0xF808475FA571D823,
        NETWORK_GET_TIMEOUT_TIME = 0x5ED0356A0CE3A34F,
        NETWORK_LEAVE_PED_BEHIND_BEFORE_CUTSCENE = 0xBF22E0F32968E967,
        NETWORK_CLAN_SERVICE_IS_VALID = 0x579CCED0265D4896,
        NETWORK_CLAN_PLAYER_IS_ACTIVE = 0xB124B57F571D8F18,
        NETWORK_CLAN_GET_LOCAL_MEMBERSHIPS_COUNT = 0x1F471B79ACC90BEF,
        NETWORK_CLAN_GET_MEMBERSHIP_DESC = 0x48DE78AF2C8885B8,
        NETWORK_CLAN_DOWNLOAD_MEMBERSHIP = 0xA989044E70010ABE,
        NETWORK_CLAN_DOWNLOAD_MEMBERSHIP_PENDING = 0x5B9E023DC6EBEDC0,
        NETWORK_CLAN_ANY_DOWNLOAD_MEMBERSHIP_PENDING = 0xB3F64A6A91432477,
        NETWORK_CLAN_REMOTE_MEMBERSHIPS_ARE_IN_CACHE = 0xBB6E6FEE99D866B2,
        NETWORK_CLAN_GET_MEMBERSHIP_COUNT = 0xAAB11F6C4ADBC2C1,
        NETWORK_CLAN_GET_MEMBERSHIP_VALID = 0x48A59CF88D43DF0E,
        NETWORK_CLAN_GET_MEMBERSHIP = 0xC8BC2011F67B3411,
        NETWORK_CLAN_JOIN = 0x9FAAA4F4FC71F87F,
        NETWORK_CLAN_GET_EMBLEM_TXD_NAME = 0x5835D9CD92E83184,
        NETWORK_CLAN_REQUEST_EMBLEM = 0x13518FF1C6B28938,
        NETWORK_CLAN_IS_EMBLEM_READY = 0xA134777FF7F33331,
        NETWORK_CLAN_RELEASE_EMBLEM = 0x113E6E3E50E286B0,
        NETWORK_GET_PRIMARY_CLAN_DATA_CLEAR = 0x9AA46BADAD0E27ED,
        NETWORK_GET_PRIMARY_CLAN_DATA_CANCEL = 0x042E4B70B93E6054,
        NETWORK_GET_PRIMARY_CLAN_DATA_START = 0xCE86D8191B762107,
        NETWORK_GET_PRIMARY_CLAN_DATA_PENDING = 0xB5074DB804E28CE7,
        NETWORK_GET_PRIMARY_CLAN_DATA_SUCCESS = 0x5B4F04F19376A0BA,
        NETWORK_GET_PRIMARY_CLAN_DATA_NEW = 0xC080FF658B2E41DA,
        SET_NETWORK_ID_EXISTS_ON_ALL_MACHINES = 0xE05E81A888FA63C8,
        SET_NETWORK_ID_ALWAYS_EXISTS_FOR_PLAYER = 0xA8A024587329F36A,
        NETWORK_SET_ENTITY_CAN_BLEND = 0xD830567D88A1E873,
        SET_NETWORK_ID_VISIBLE_IN_CUTSCENE = 0xA6928482543022B4,
        SET_NETWORK_CUTSCENE_ENTITIES = 0xAAA553E7DD28A457,
        IS_NETWORK_ID_OWNED_BY_PARTICIPANT = 0xA1607996431332DF,
        SET_LOCAL_PLAYER_VISIBLE_IN_CUTSCENE = 0xD1065D68947E7B6E,
        SET_LOCAL_PLAYER_INVISIBLE_LOCALLY = 0xE5F773C1A1D9D168,
        SET_LOCAL_PLAYER_VISIBLE_LOCALLY = 0x7619364C82D3BF14,
        SET_PLAYER_INVISIBLE_LOCALLY = 0x12B37D54667DB0B8,
        SET_PLAYER_VISIBLE_LOCALLY = 0xFAA10F1FAFB11AF2,
        NETWORK_IS_PLAYER_FADING = 0x631DC5DFF4B110E3,
        NETWORK_IS_ENTITY_FADING = 0x422F32CC7E56ABAD,
        IS_PLAYER_IN_CUTSCENE = 0xE73092F4157CD126,
        SET_ENTITY_VISIBLE_IN_CUTSCENE = 0xE0031D3C8F36AB82,
        SET_ENTITY_LOCALLY_VISIBLE = 0x241E289B5C059EDC,
        IS_DAMAGE_TRACKER_ACTIVE_ON_NETWORK_ID = 0x6E192E33AD436366,
        ACTIVATE_DAMAGE_TRACKER_ON_NETWORK_ID = 0xD45B1FFCCD52FF19,
        _IS_DAMAGE_TRACKER_ACTIVE_ON_PLAYER = 0xB2092A1EAA7FD45F,
        _ACTIVATE_DAMAGE_TRACKER_ON_PLAYER = 0xBEC0816FF5ACBCDA,
        IS_SPHERE_VISIBLE_TO_ANOTHER_MACHINE = 0xD82CF8E64C8729D8,
        IS_SPHERE_VISIBLE_TO_PLAYER = 0xDC3A310219E5DA62,
        RESERVE_NETWORK_MISSION_OBJECTS = 0x4E5C93BD0C32FBF8,
        RESERVE_NETWORK_MISSION_PEDS = 0xB60FEBA45333D36F,
        RESERVE_NETWORK_MISSION_VEHICLES = 0x76B02E21ED27A469,
        _RESERVE_NETWORK_LOCAL_OBJECTS = 0x797F9C5E661D920E,
        _RESERVE_NETWORK_LOCAL_PEDS = 0x2C8DF5D129595281,
        _RESERVE_NETWORK_LOCAL_VEHICLES = 0x42613035157E4208,
        CAN_REGISTER_MISSION_OBJECTS = 0x800DD4721A8B008B,
        CAN_REGISTER_MISSION_PEDS = 0xBCBF4FEF9FA5D781,
        CAN_REGISTER_MISSION_VEHICLES = 0x7277F1F2E085EE74,
        _CAN_REGISTER_MISSION_PICKUPS = 0x0A49D1CB6E34AF72,
        CAN_REGISTER_MISSION_ENTITIES = 0x69778E7564BADE6D,
        GET_NUM_CREATED_MISSION_OBJECTS = 0x12B6281B6C6706C0,
        GET_NUM_CREATED_MISSION_PEDS = 0xCB215C4B56A7FAE7,
        GET_NUM_CREATED_MISSION_VEHICLES = 0x0CD9AB83489430EA,
        GET_MAX_NUM_NETWORK_OBJECTS = 0xC7BE335216B5EC7C,
        GET_MAX_NUM_NETWORK_PEDS = 0x0C1F7D49C39D2289,
        GET_MAX_NUM_NETWORK_VEHICLES = 0x0AFCE529F69B21FF,
        GET_MAX_NUM_NETWORK_PICKUPS = 0xA72835064DD63E4C,
        GET_NETWORK_TIME = 0x7A5487FE9FAA6B48,
        HAS_NETWORK_TIME_STARTED = 0x46718ACEEDEAFC84,
        GET_TIME_AS_STRING = 0x9E23B1777A927DAD,
        NETWORK_SET_IN_SPECTATOR_MODE = 0x423DE3854BB50894,
        NETWORK_SET_IN_SPECTATOR_MODE_EXTENDED = 0x419594E137637120,
        NETWORK_SET_IN_FREE_CAM_MODE = 0xFC18DB55AE19E046,
        NETWORK_SET_CHOICE_MIGRATE_OPTIONS = 0x5C707A667DF8B9FA,
        NETWORK_IS_IN_SPECTATOR_MODE = 0x048746E388762E11,
        NETWORK_SET_IN_MP_CUTSCENE = 0x9CA5DE655269FEC4,
        NETWORK_IS_IN_MP_CUTSCENE = 0x6CC27C9FA2040220,
        NETWORK_IS_PLAYER_IN_MP_CUTSCENE = 0x63F9EE203C3619F2,
        SET_NETWORK_VEHICLE_RESPOT_TIMER = 0xEC51713AB6EC36E8,
        SET_NETWORK_VEHICLE_AS_GHOST = 0x6274C4712850841E,
        _SET_LOCAL_PLAYER_AS_GHOST = 0x5FFE9B4144F9712F,
        _IS_ENTITY_GHOSTED_TO_LOCAL_PLAYER = 0x21D04D7BC538C146,
        _NETWORK_SET_ENTITY_GHOSTED_WITH_OWNER = 0x4BA166079D658ED4,
        USE_PLAYER_COLOUR_INSTEAD_OF_TEAM_COLOUR = 0x77758139EC9B66C7,
        NETWORK_CREATE_SYNCHRONISED_SCENE = 0x7CD6BC4C2BBDD526,
        NETWORK_ADD_PED_TO_SYNCHRONISED_SCENE = 0x742A637471BCECD9,
        NETWORK_ADD_ENTITY_TO_SYNCHRONISED_SCENE = 0xF2404D68CBC855FA,
        NETWORK_ADD_SYNCHRONISED_SCENE_CAMERA = 0xCF8BD3B0BD6D42D7,
        NETWORK_ATTACH_SYNCHRONISED_SCENE_TO_ENTITY = 0x478DCBD2A98B705A,
        NETWORK_START_SYNCHRONISED_SCENE = 0x9A1B3FCDB36C8697,
        NETWORK_STOP_SYNCHRONISED_SCENE = 0xC254481A4574CB2F,
        NETWORK_GET_LOCAL_SCENE_FROM_NETWORK_ID = 0x02C40BF885C567B6,
        NETWORK_QUERY_RESPAWN_RESULTS = 0x3C891A251567DFCE,
        NETWORK_CANCEL_RESPAWN_SEARCH = 0xFB8F2A6F3DF08CBE,
        NETWORK_GET_RESPAWN_RESULT_FLAGS = 0x6C34F1208B8923FD,
        NETWORK_END_TUTORIAL_SESSION = 0xD0AFAFF5A51D72F7,
        NETWORK_IS_IN_TUTORIAL_SESSION = 0xADA24309FE08DACF,
        NETWORK_IS_TUTORIAL_SESSION_CHANGE_PENDING = 0x35F0B98A8387274D,
        NETWORK_GET_PLAYER_TUTORIAL_SESSION_INSTANCE = 0x3B39236746714134,
        NETWORK_CONCEAL_PLAYER = 0xBBDF066252829606,
        NETWORK_IS_PLAYER_CONCEALED = 0x919B3C98ED8292F9,
        _NETWORK_CONCEAL_ENTITY = 0x1632BE0AC1E62876,
        _NETWORK_OVERRIDE_CLOCK_MILLISECONDS_PER_GAME_MINUTE = 0x42BF1D2E723B6D7E,
        NETWORK_CLEAR_CLOCK_TIME_OVERRIDE = 0xD972DF67326F966E,
        NETWORK_IS_CLOCK_TIME_OVERRIDDEN = 0xD7C95D322FF57522,
        NETWORK_ADD_ENTITY_AREA = 0x494C8FB299290269,
        NETWORK_ADD_ENTITY_DISPLAYED_BOUNDARIES = 0x25B99872D588A101,
        NETWORK_REMOVE_ENTITY_AREA = 0x93CF869BAA0C4874,
        NETWORK_ENTITY_AREA_DOES_EXIST = 0xE64A3CA08DFA37A9,
        NETWORK_ENTITY_AREA_IS_OCCUPIED = 0x4A2D4E8BF4265B0F,
        NETWORK_USE_HIGH_PRECISION_BLENDING = 0x2B1813ABA29016C5,
        NETWORK_REQUEST_CLOUD_BACKGROUND_SCRIPTS = 0x924426BFFD82E915,
        NETWORK_IS_CLOUD_BACKGROUND_SCRIPT_REQUEST_PENDING = 0x8132C0EB8B2B3293,
        NETWORK_REQUEST_CLOUD_TUNABLES = 0x42FB3B532D526E6C,
        NETWORK_IS_TUNABLE_CLOUD_REQUEST_PENDING = 0x0467C11ED88B7D28,
        NETWORK_DOES_TUNABLE_EXIST = 0x85E5F8B9B898B20A,
        NETWORK_ACCESS_TUNABLE_INT = 0x8BE1146DFD5D4468,
        NETWORK_ACCESS_TUNABLE_FLOAT = 0xE5608CA7BC163A5F,
        NETWORK_ACCESS_TUNABLE_BOOL = 0xAA6A47A573ABB75A,
        NETWORK_DOES_TUNABLE_EXIST_HASH = 0xE4E53E1419D81127,
        _NETWORK_ALLOCATE_TUNABLES_REGISTRATION_DATA_MAP = 0xFAFC23AEE23868DB,
        NETWORK_ACCESS_TUNABLE_INT_HASH = 0x40FCE03E50E8DBE8,
        _NETWORK_REGISTER_TUNABLE_INT_HASH = 0x3A8B55FDA4C8DDEF,
        NETWORK_ACCESS_TUNABLE_FLOAT_HASH = 0x972BC203BBC4C4D5,
        _NETWORK_REGISTER_TUNABLE_FLOAT_HASH = 0x1950DAE9848A4739,
        NETWORK_ACCESS_TUNABLE_BOOL_HASH = 0xEA16B69D93D71A45,
        _NETWORK_REGISTER_TUNABLE_BOOL_HASH = 0x697F508861875B42,
        NETWORK_RESET_BODY_TRACKER = 0x72433699B4E6DD64,
        _NETWORK_GET_NUM_BODY_TRACKERS = 0xD38C4A6D047C019D,
        NETWORK_USE_LOGARITHMIC_BLENDING_THIS_FRAME = 0xCD71A4ECAB22709E,
        NETWORK_OVERRIDE_COORDS_AND_HEADING = 0xA7E30DE9272B6D49,
        NETWORK_DISABLE_PROXIMITY_MIGRATION = 0x407091CF6037118E,
        NETWORK_CLEAR_PROPERTY_ID = 0xC2B82527CA77053E,
        NETWORK_CACHE_LOCAL_PLAYER_HEAD_BLEND_DATA = 0xBD0BE0BFC927EAC1,
        NETWORK_HAS_CACHED_PLAYER_HEAD_BLEND_DATA = 0x237D5336A9A54108,
        NETWORK_APPLY_CACHED_PLAYER_HEAD_BLEND_DATA = 0x99B72C7ABDE5C910,
        GET_NUM_COMMERCE_ITEMS = 0xF2EAC213D5EA0623,
        IS_COMMERCE_DATA_VALID = 0xEA14EEF5B7CD2C30,
        GET_COMMERCE_ITEM_ID = 0x662635855957C411,
        GET_COMMERCE_ITEM_NAME = 0xB4271092CA7EDF48,
        GET_COMMERCE_PRODUCT_PRICE = 0xCA94551B50B4932C,
        GET_COMMERCE_ITEM_NUM_CATS = 0x2A7776C709904AB0,
        OPEN_COMMERCE_STORE = 0x58C21165F6545892,
        IS_COMMERCE_STORE_OPEN = 0x2EAC52B4019E2782,
        REQUEST_COMMERCE_ITEM_IMAGE = 0xA2F952104FC6DD4B,
        RELEASE_ALL_COMMERCE_ITEM_IMAGES = 0x72D0706CD6CCDB58,
        GET_COMMERCE_ITEM_TEXTURENAME = 0x722F5D28B61C5EA8,
        IS_STORE_AVAILABLE_TO_USER = 0x883D79C4071E18B3,
        CLOUD_DELETE_MEMBER_FILE = 0xC64DED7EF0D2FE37,
        CLOUD_HAS_REQUEST_COMPLETED = 0x4C61B39930D045DA,
        CLOUD_DID_REQUEST_SUCCEED = 0x3A3D5568AF297CD5,
        CLOUD_IS_CHECKING_AVAILABILITY = 0xC7ABAC5DE675EE3B,
        CLOUD_GET_AVAILABILITY_CHECK_RESULT = 0x0B0CC10720653F3B,
        UGC_COPY_CONTENT = 0x152D90E4C1B4738A,
        UGC_HAS_CREATE_FINISHED = 0x5E24341A7F92A74B,
        UGC_DID_CREATE_SUCCEED = 0x24E4E51FC16305F9,
        UGC_GET_CREATE_RESULT = 0xFBC5E768C7A77A6A,
        UGC_GET_CREATE_CONTENT_ID = 0xC55A0B40FFB1ED23,
        UGC_CLEAR_CREATE_RESULT = 0x17440AA15D1D3739,
        UGC_QUERY_MY_CONTENT = 0x9BF438815F5D96EA,
        UGC_QUERY_BY_CONTENT_ID = 0x158EC424F35EC469,
        UGC_QUERY_BY_CONTENT_IDS = 0xC7397A83F7A2A462,
        _UGC_QUERY_RECENTLY_CREATED_CONTENT = 0x6D4CB481FAC835E8,
        UGC_GET_BOOKMARKED_CONTENT = 0xD5A4B59980401588,
        UGC_GET_MY_CONTENT = 0x3195F8DD0D531052,
        UGC_GET_FRIEND_CONTENT = 0xF9E1CCAE8BA4C281,
        UGC_GET_CREW_CONTENT = 0x9F6E2821885CAEE2,
        UGC_GET_GET_BY_CATEGORY = 0x678BB03C1A3BD51E,
        SET_BALANCE_ADD_MACHINE = 0x815E5E3073DA1D67,
        SET_BALANCE_ADD_MACHINES = 0xB8322EEB38BE7C26,
        UGC_CANCEL_QUERY = 0xE9B99B6853181409,
        UGC_IS_GETTING = 0xD53ACDBEF24A46E8,
        UGC_HAS_GET_FINISHED = 0x02ADA21EA2F6918F,
        UGC_DID_GET_SUCCEED = 0x941E5306BCD7C2C7,
        UGC_GET_QUERY_RESULT = 0xEDF7F927136C224B,
        UGC_GET_CONTENT_NUM = 0xE0A6138401BCB837,
        UGC_GET_CONTENT_TOTAL = 0x769951E2455E2EB5,
        UGC_GET_CONTENT_HASH = 0x3A17A27D75C74887,
        UGC_CLEAR_QUERY_RESULTS = 0xBA96394A0EECFA65,
        UGC_GET_CONTENT_USER_ID = 0xCD67AD041A394C9C,
        UGC_GET_CONTENT_USER_NAME = 0x703F12425ECA8BF5,
        UGC_GET_CONTENT_CATEGORY = 0xA7BAB11E7C9C6C5A,
        UGC_GET_CONTENT_NAME = 0xBF09786A7FCAB582,
        UGC_GET_CONTENT_DESCRIPTION_HASH = 0x7CF0448787B23758,
        UGC_GET_CONTENT_PATH = 0xBAF6BABF9E7CCC13,
        UGC_GET_CONTENT_UPDATED_DATE = 0xCFD115B373C0DF63,
        UGC_GET_CONTENT_FILE_VERSION = 0x37025B27D9B658B1,
        UGC_GET_CONTENT_LANGUAGE = 0x32DD916F3F7C9672,
        UGC_GET_CONTENT_IS_PUBLISHED = 0x3054F114121C21EA,
        UGC_GET_CONTENT_IS_VERIFIED = 0xA9240A96C74CCA13,
        UGC_GET_CONTENT_RATING = 0x1ACCFBA3D8DAB2EE,
        UGC_GET_CONTENT_RATING_COUNT = 0x759299C5BB31D2A9,
        UGC_GET_CONTENT_RATING_POSITIVE_COUNT = 0x87E5C46C187FE0AE,
        UGC_GET_CONTENT_RATING_NEGATIVE_COUNT = 0x4E548C0D7AE39FF9,
        UGC_GET_CONTENT_HAS_PLAYER_RECORD = 0x70EA8DA57840F9BE,
        UGC_GET_CONTENT_HAS_PLAYER_BOOKMARKED = 0x993CBE59D350D225,
        UGC_REQUEST_CONTENT_DATA_FROM_INDEX = 0x171DF6A0C07FB3DC,
        UGC_REQUEST_CONTENT_DATA_FROM_PARAMS = 0x7FD2990AF016795E,
        UGC_REQUEST_CACHED_DESCRIPTION = 0x5E0165278F6339EE,
        UGC_GET_CACHED_DESCRIPTION = 0x40F7E66472DF3E5C,
        UGC_PUBLISH = 0x1DE0F5F50D723CAA,
        UGC_SET_BOOKMARKED = 0x274A1519DFC1094F,
        UGC_SET_DELETED = 0xD05D1A6C74DA3498,
        UGC_HAS_MODIFY_FINISHED = 0x299EF3C576773506,
        UGC_GET_MODIFY_RESULT = 0x5A0A3D1A186A5508,
        UGC_CLEAR_MODIFY_RESULT = 0xA1E5E0204A6FCC70,
        UGC_GET_CREATOR_NUM = 0x597F8DBA9B206FC7,
        UGC_POLICIES_MAKE_PRIVATE = 0x5CAE833B0EE0C500,
        UGC_CLEAR_OFFLINE_QUERY = 0x61A885D3F7CFEE9A,
        UGC_SET_QUERY_DATA_FROM_OFFLINE = 0xF98DDE0A8ED09323,
        UGC_IS_LANGUAGE_SUPPORTED = 0xF53E48461B71EECB,
        _FACEBOOK_SET_HEIST_COMPLETE = 0x098AB65B9ED9A9EC,
        _FACEBOOK_SET_CREATE_CHARACTER_COMPLETE = 0xDC48473142545431,
        _FACEBOOK_SET_MILESTONE_COMPLETE = 0x0AE1F1653B554AB9,
        _FACEBOOK_IS_SENDING_DATA = 0x62B9FEC9A11F10EF,
        _FACEBOOK_DO_UNK_CHECK = 0xA75E2B6733DA5142,
        _FACEBOOK_IS_AVAILABLE = 0x43865688AE10F0D7,
        TEXTURE_DOWNLOAD_REQUEST = 0x16160DA74A8E74A2,
        TITLE_TEXTURE_DOWNLOAD_REQUEST = 0x0B203B4AFDE53A4F,
        UGC_TEXTURE_DOWNLOAD_REQUEST = 0x308F96458B7087CC,
        TEXTURE_DOWNLOAD_RELEASE = 0x487EB90B98E9FB19,
        TEXTURE_DOWNLOAD_HAS_FAILED = 0x5776ED562C134687,
        TEXTURE_DOWNLOAD_GET_NAME = 0x3448505B6E35262D,
        NETWORK_IS_CABLE_CONNECTED = 0xEFFB25453D8600F9,
        _NETWORK_GET_ROS_PRIVILEGE_9 = 0x66B59CFFD78467AF,
        NETWORK_HAVE_ROS_SOCIAL_CLUB_PRIV = 0x606E4D3E3CCCF3EB,
        NETWORK_HAVE_ROS_BANNED_PRIV = 0x8020A73847E0CA7D,
        NETWORK_HAVE_ROS_CREATE_TICKET_PRIV = 0xA0AD7E2AF5349F61,
        NETWORK_HAVE_ROS_MULTIPLAYER_PRIV = 0x5F91D5D0B36AA310,
        NETWORK_HAVE_ROS_LEADERBOARD_WRITE_PRIV = 0x422D396F80A96547,
        NETWORK_HAS_ROS_PRIVILEGE_END_DATE = 0xC22912B1D85F26B1,
        _NETWORK_GET_ROS_PRIVILEGE_24 = 0x593570C289A77688,
        _NETWORK_GET_ROS_PRIVILEGE_25 = 0x91B87C55093DE351,
        _NETWORK_UPDATE_PLAYER_SCARS = 0xB7C7F6AD6424304B,
        NETWORK_DISABLE_LEAVE_REMOTE_PED_BEHIND = 0xC505036A35AFD01B,
        _NETWORK_ALLOW_LOCAL_ENTITY_ATTACHMENT = 0x267C78C60E806B9A,
        _NETWORK_IS_CONNECTION_ENDPOINT_RELAY_SERVER = 0x16D3D49902F697BB,
        _NETWORK_GET_AVERAGE_LATENCY_FOR_PLAYER = 0xD414BE129BB81B32,
        _NETWORK_GET_AVERAGE_PACKET_LOSS_FOR_PLAYER = 0x350C23949E43686C,
        _NETWORK_GET_NUM_UNACKED_FOR_PLAYER = 0xFF8FCF9FFC458A1C,
        _NETWORK_GET_UNRELIABLE_RESEND_COUNT_FOR_PLAYER = 0x3765C3A3E8192E10,
        _NETWORK_REPORT_MYSELF = 0x5626D9D6810730D5,
        _NETWORK_UGC_NAV = 0xC1447451DDB512F0,
        _0x4237E822315D8BA9 = 0x4237E822315D8BA9,
        _0x78321BEA235FD8CD = 0x78321BEA235FD8CD,
        _0x07EAB372C8841D99 = 0x07EAB372C8841D99,
        _0x906CA41A4B74ECA4 = 0x906CA41A4B74ECA4,
        _0x023ACAB2DC9DC4A4 = 0x023ACAB2DC9DC4A4,
        _0x0CF6CC51AA18F0F8 = 0x0CF6CC51AA18F0F8,
        _0x1F7BC3539F9E0224 = 0x1F7BC3539F9E0224,
        _0xA8ACB6459542A8C8 = 0xA8ACB6459542A8C8,
        _0x83FE8D7229593017 = 0x83FE8D7229593017,
        _0x53C10C8BD774F2C9 = 0x53C10C8BD774F2C9,
        _0x283B6062A2C01E9B = 0x283B6062A2C01E9B,
        _0x8B4FFC790CA131EF = 0x8B4FFC790CA131EF,
        _0x04918A41BC9B8157 = 0x04918A41BC9B8157,
        _0xB9351A07A0D458B1 = 0xB9351A07A0D458B1,
        _0x041C7F2A6C9894E6 = 0x041C7F2A6C9894E6,
        _0xF49ABC20D8552257 = 0xF49ABC20D8552257,
        _0x4811BBAC21C5FCD5 = 0x4811BBAC21C5FCD5,
        _0x5539C3EBF104A53A = 0x5539C3EBF104A53A,
        _0x702BC4D605522539 = 0x702BC4D605522539,
        _0x5ECD378EE64450AB = 0x5ECD378EE64450AB,
        _0x59D421683D31835A = 0x59D421683D31835A,
        _0x1153FA02A659051C = 0x1153FA02A659051C,
        _0x600F8CB31C7AAB6E = 0x600F8CB31C7AAB6E,
        _0xC42DD763159F3461 = 0xC42DD763159F3461,
        _0xF814FEC6A19FD6E0 = 0xF814FEC6A19FD6E0,
        _0x4C9034162368E206 = 0x4C9034162368E206,
        _0xB5D3453C98456528 = 0xB5D3453C98456528,
        _0x0E4F77F7B9D74D84 = 0x0E4F77F7B9D74D84,
        _0x1888694923EF4591 = 0x1888694923EF4591,
        _0xB13E88E655E5A3BC = 0xB13E88E655E5A3BC,
        _0x261E97AD7BCF3D40 = 0x261E97AD7BCF3D40,
        _0x39917E1B4CB0F911 = 0x39917E1B4CB0F911,
        _0x2CE9D95E4051AECD = 0x2CE9D95E4051AECD,
        _0x1398582B7F72B3ED = 0x1398582B7F72B3ED,
        _0x1F8E00FB18239600 = 0x1F8E00FB18239600,
        _0xF6F4383B7C92F11A = 0xF6F4383B7C92F11A,
        _0x973D76AA760A6CB6 = 0x973D76AA760A6CB6,
        _0x1171A97A3D3981B6 = 0x1171A97A3D3981B6,
        _0x742B58F723233ED9 = 0x742B58F723233ED9,
        _0xEBF8284D8CADEB53 = 0xEBF8284D8CADEB53,
        _0x3855FB5EB2C5E8B2 = 0x3855FB5EB2C5E8B2,
        _0x4AD490AE1536933B = 0x4AD490AE1536933B,
        _0x2BF66D2E7414F686 = 0x2BF66D2E7414F686,
        _0x6CE50E47F5543D0C = 0x6CE50E47F5543D0C,
        _0xFA2888E3833C8E96 = 0xFA2888E3833C8E96,
        _0x25D990F8E0E3F13C = 0x25D990F8E0E3F13C,
        _0xA12D3A5A3753CC23 = 0xA12D3A5A3753CC23,
        _0xF287F506767CC8A9 = 0xF287F506767CC8A9,
        _0xEA8C0DDB10E2822A = 0xEA8C0DDB10E2822A,
        _0xD6D7478CA62B8D41 = 0xD6D7478CA62B8D41,
        _0x560B423D73015E77 = 0x560B423D73015E77,
        _0x2302C0264EA58D31 = 0x2302C0264EA58D31,
        _0x2DA41ED6E1FCD7A5 = 0x2DA41ED6E1FCD7A5,
        _0xC434133D9BA52777 = 0xC434133D9BA52777,
        _0x83660B734994124D = 0x83660B734994124D,
        _0x4C2A9FDC22377075 = 0x4C2A9FDC22377075,
        _0xB309EBEA797E001F = 0xB309EBEA797E001F,
        _0x26F07DD83A5F7F98 = 0x26F07DD83A5F7F98,
        _0x7D395EA61622E116 = 0x7D395EA61622E116,
        _0xCFEB46DCD7D8D5EB = 0xCFEB46DCD7D8D5EB,
        _0x265559DA40B3F327 = 0x265559DA40B3F327,
        _0x4348BFDA56023A2F = 0x4348BFDA56023A2F,
        _0x5E3AA4CA2B6FB0EE = 0x5E3AA4CA2B6FB0EE,
        _0xCA575C391FEA25CC = 0xCA575C391FEA25CC,
        _0xADB57E5B663CCA8B = 0xADB57E5B663CCA8B,
        _0x17C9E241111A674D = 0x17C9E241111A674D,
        _0x2E4C123D1C8A710E = 0x2E4C123D1C8A710E,
        _0x2B51EDBEFC301339 = 0x2B51EDBEFC301339,
        _0xC32EA7A2F6CA7557 = 0xC32EA7A2F6CA7557,
        _0x9D724B400A7E8FFC = 0x9D724B400A7E8FFC,
        _0x0379DAF89BA09AA5 = 0x0379DAF89BA09AA5,
        _0x32EBD154CB6B8B99 = 0x32EBD154CB6B8B99,
        _0x76B3F29D3F967692 = 0x76B3F29D3F967692,
        _0x3FA36981311FA4FF = 0x3FA36981311FA4FF,
        _0xE16AA70CE9BEEDC3 = 0xE16AA70CE9BEEDC3,
        _0xE42D626EEC94E5D9 = 0xE42D626EEC94E5D9,
        _0xBA7F0B77D80A4EB7 = 0xBA7F0B77D80A4EB7,
        _0x0F1A4B45B7693B95 = 0x0F1A4B45B7693B95,
        _0xFAC18E7356BD3210 = 0xFAC18E7356BD3210,
        _0xD7B6C73CAD419BCF = 0xD7B6C73CAD419BCF,
        _0xA5EAFE473E45C442 = 0xA5EAFE473E45C442,
        _0xC9B43A33D09CADA7 = 0xC9B43A33D09CADA7,
        _0x144DA052257AE7D8 = 0x144DA052257AE7D8,
        _0xB37E4E6A2388CA7B = 0xB37E4E6A2388CA7B,
        _0x2B1C623823DB0D9D = 0x2B1C623823DB0D9D,
        _0x4DF7CFFF471A7FB1 = 0x4DF7CFFF471A7FB1,
        _0xA6FCECCF4721D679 = 0xA6FCECCF4721D679,
        _0x95BAF97C82464629 = 0x95BAF97C82464629,
        _0x7DB53B37A2F211A0 = 0x7DB53B37A2F211A0,
        _0x2E0BF682CC778D49 = 0x2E0BF682CC778D49,
        _0x0EDE326D47CD0F3E = 0x0EDE326D47CD0F3E,
        _0x38B7C51AB1EDC7D8 = 0x38B7C51AB1EDC7D8,
        _0x2A5E0621DD815A9A = 0x2A5E0621DD815A9A,
        _0xE6717E652B8C8D8A = 0xE6717E652B8C8D8A,
        _0x367EF5E2F439B4C6 = 0x367EF5E2F439B4C6,
        _0x94538037EE44F5CF = 0x94538037EE44F5CF,
        _0x265635150FB0D82E = 0x265635150FB0D82E,
        _0xFAE628F1E9ADB239 = 0xFAE628F1E9ADB239,
        _0x9FEDF86898F100E9 = 0x9FEDF86898F100E9,
        _0x692D58DF40657E8C = 0x692D58DF40657E8C,
        _0xA7862BC5ED1DFD7E = 0xA7862BC5ED1DFD7E,
        _0x97A770BEEF227E2B = 0x97A770BEEF227E2B,
        _0x5324A0E3E4CE3570 = 0x5324A0E3E4CE3570,
        _0xC87E740D9F3872CC = 0xC87E740D9F3872CC,
        _0x584770794D758C18 = 0x584770794D758C18,
        _0x8C8D2739BA44AF0F = 0x8C8D2739BA44AF0F,
        _0xAEAB987727C5A8A4 = 0xAEAB987727C5A8A4,
        _0x1D610EB0FEA716D9 = 0x1D610EB0FEA716D9,
        _0x7FCC39C46C3C03BD = 0x7FCC39C46C3C03BD,
        _0x2D5DC831176D0114 = 0x2D5DC831176D0114,
        _0xEBFA8D50ADDC54C4 = 0xEBFA8D50ADDC54C4,
        _0x162C23CA83ED0A62 = 0x162C23CA83ED0A62,
        _0x5A34CD9C3C5BEC44 = 0x5A34CD9C3C5BEC44,
        _0x68103E2247887242 = 0x68103E2247887242,
        _0x45E816772E93A9DB = 0x45E816772E93A9DB,
        _0x793FF272D5B365F4 = 0x793FF272D5B365F4,
        _0xB746D20B17F2A229 = 0xB746D20B17F2A229,
        _0x63B406D7884BFA95 = 0x63B406D7884BFA95,
        _0x4D02279C83BE69FE = 0x4D02279C83BE69FE,
        _0xFD75DABC0957BF33 = 0xFD75DABC0957BF33,
        _0x36391F397731595D = 0x36391F397731595D,
        _0x9465E683B12D3F6B = 0x9465E683B12D3F6B,
        _0x45A83257ED02D9BC = 0x45A83257ED02D9BC,
        _0xDB663CC9FF3407A9 = 0xDB663CC9FF3407A9,
    }
}