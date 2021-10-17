using System;
namespace Hotstar
{
    public enum PLAYER : ulong
    { 
        /// <summary>
        /// Gets the ped for a specified player index.
        ///
        /// > Player player
        ///
        /// </summary>
        GET_PLAYER_PED = 0x43A66C31C68491C0,
        /// <summary>
        /// Does the same like PLAYER::GET_PLAYER_PED
        ///
        /// > Player player
        ///
        /// </summary>
        GET_PLAYER_PED_SCRIPT_INDEX = 0x50FAC3A3E030A6E1,
        /// <summary>
        /// Set the model for a specific Player. Be aware that this will destroy the current Ped for the Player and create a new one, any reference to the old ped should be reset
        /// Make sure to request the model first and wait until it has loaded.
        ///
        /// > Player player
        /// > Hash model
        ///
        /// </summary>
        SET_PLAYER_MODEL = 0x00A1CADD00108836,
        /// <summary>
        /// Gets the number of players in the current session.
        /// If not multiplayer, always returns 1.
        ///
        ///
        /// </summary>
        GET_NUMBER_OF_PLAYERS = 0x407C7F91DDB46C16,
        /// <summary>
        /// Gets the player's team.
        /// Does nothing in singleplayer.
        ///
        /// > Player player
        ///
        /// </summary>
        GET_PLAYER_TEAM = 0x37039302F4E0A008,
        /// <summary>
        /// Set player team on deathmatch and last team standing..
        ///
        /// > Player player
        /// > int team
        ///
        /// </summary>
        SET_PLAYER_TEAM = 0x0299FA38396A4940,
        /// <summary>
        /// Remnant from GTA IV. Does nothing in GTA V.
        ///
        /// > Player player
        ///
        /// </summary>
        GET_WANTED_LEVEL_RADIUS = 0x085DEB493BE80812,
        /// <summary>
        /// # Predominant call signatures
        /// PLAYER::SET_PLAYER_WANTED_CENTRE_POSITION(PLAYER::PLAYER_ID(), ENTITY::GET_ENTITY_COORDS(PLAYER::PLAYER_PED_ID(), 1));
        /// 
        /// # Parameter value ranges
        /// P0: PLAYER::PLAYER_ID()
        /// P1: ENTITY::GET_ENTITY_COORDS(PLAYER::PLAYER_PED_ID(), 1)
        /// P2: Not set by any call
        ///
        /// > Player player
        /// > Vector3* position
        /// > BOOL p2
        /// > BOOL p3
        ///
        /// </summary>
        SET_PLAYER_WANTED_CENTRE_POSITION = 0x520E541A97A13354,
        /// <summary>
        /// Drft
        ///
        /// > int wantedLevel
        ///
        /// </summary>
        GET_WANTED_LEVEL_THRESHOLD = 0xFDD179EAF45B556C,
        /// <summary>
        /// Call SET_PLAYER_WANTED_LEVEL_NOW for immediate effect
        /// 
        /// wantedLevel is an integer value representing 0 to 5 stars even though the game supports the 6th wanted level but no police will appear since no definitions are present for it in the game files
        /// 
        /// disableNoMission-  Disables When Off Mission- appears to always be false
        /// 
        ///
        /// > Player player
        /// > int wantedLevel
        /// > BOOL disableNoMission
        ///
        /// </summary>
        SET_PLAYER_WANTED_LEVEL = 0x39FF19C64EF7DA5B,
        /// <summary>
        /// p2 is always false in R* scripts
        ///
        /// > Player player
        /// > int wantedLevel
        /// > BOOL p2
        ///
        /// </summary>
        SET_PLAYER_WANTED_LEVEL_NO_DROP = 0x340E61DE7F471565,
        /// <summary>
        /// Forces any pending wanted level to be applied to the specified player immediately.
        /// 
        /// Call SET_PLAYER_WANTED_LEVEL with the desired wanted level, followed by SET_PLAYER_WANTED_LEVEL_NOW.
        /// 
        /// Second parameter is unknown (always false).
        ///
        /// > Player player
        /// > BOOL p1
        ///
        /// </summary>
        SET_PLAYER_WANTED_LEVEL_NOW = 0xE0A7D1E497FFCD6F,
        /// <summary>
        /// This executes at the same as speed as PLAYER::SET_PLAYER_WANTED_LEVEL(player, 0, false);
        /// 
        /// PLAYER::GET_PLAYER_WANTED_LEVEL(player); executes in less than half the time. Which means that it's worth first checking if the wanted level needs to be cleared before clearing. However, this is mostly about good code practice and can important in other situations. The difference in time in this example is negligible. 
        ///
        /// > Player player
        ///
        /// </summary>
        CLEAR_PLAYER_WANTED_LEVEL = 0xB302540597885499,
        /// <summary>
        /// Flags:
        /// SPC_AMBIENT_SCRIPT = (1 << 1),
        /// SPC_CLEAR_TASKS = (1 << 2),
        /// SPC_REMOVE_FIRES = (1 << 3),
        /// SPC_REMOVE_EXPLOSIONS = (1 << 4),
        /// SPC_REMOVE_PROJECTILES = (1 << 5),
        /// SPC_DEACTIVATE_GADGETS = (1 << 6),
        /// SPC_REENABLE_CONTROL_ON_DEATH = (1 << 7),
        /// SPC_LEAVE_CAMERA_CONTROL_ON = (1 << 8),
        /// SPC_ALLOW_PLAYER_DAMAGE = (1 << 9),
        /// SPC_DONT_STOP_OTHER_CARS_AROUND_PLAYER = (1 << 10),
        /// SPC_PREVENT_EVERYBODY_BACKOFF = (1 << 11),
        /// SPC_ALLOW_PAD_SHAKE = (1 << 12)
        /// 
        /// See: https://alloc8or.re/gta5/doc/enums/eSetPlayerControlFlag.txt
        ///
        /// > Player player
        /// > BOOL bHasControl
        /// > int flags
        ///
        /// </summary>
        SET_PLAYER_CONTROL = 0x8D32347D6D4C40A2,
        /// <summary>
        /// If toggle is set to false:
        ///  The police won't be shown on the (mini)map
        /// 
        /// If toggle is set to true:
        ///  The police will be shown on the (mini)map
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_POLICE_RADAR_BLIPS = 0x43286D561B72B8BF,
        /// <summary>
        /// The player will be ignored by the police if toggle is set to true
        ///
        /// > Player player
        /// > BOOL toggle
        ///
        /// </summary>
        SET_POLICE_IGNORE_PLAYER = 0x32C62AA929C2DA6A,
        /// <summary>
        /// Checks whether the specified player has a Ped, the Ped is not dead, is not injured and is not arrested.
        ///
        /// > Player player
        ///
        /// </summary>
        IS_PLAYER_PLAYING = 0x5E9564D8246B909A,
        /// <summary>
        /// Max value is 1.0
        ///
        /// > Player player
        /// > float difficulty
        ///
        /// </summary>
        SET_WANTED_LEVEL_DIFFICULTY = 0x9B0BB33B04405E7A,
        /// <summary>
        /// PLAYER::REPORT_CRIME(PLAYER::PLAYER_ID(), 37, PLAYER::GET_WANTED_LEVEL_THRESHOLD(1));
        /// 
        /// From am_armybase.ysc.c4:
        /// 
        /// PLAYER::REPORT_CRIME(PLAYER::PLAYER_ID(4), 36, PLAYER::GET_WANTED_LEVEL_THRESHOLD(4));
        /// 
        /// -----
        /// 
        /// This was taken from the GTAV.exe v1.334. The function is called sub_140592CE8. For a full decompilation of the function, see here: pastebin.com/09qSMsN7 
        /// 
        /// -----
        /// crimeType:
        /// 1: Firearms possession
        /// 2: Person running a red light ("5-0-5")
        /// 3: Reckless driver
        /// 4: Speeding vehicle (a "5-10")
        /// 5: Traffic violation (a "5-0-5")
        /// 6: Motorcycle rider without a helmet
        /// 7: Vehicle theft (a "5-0-3")
        /// 8: Grand Theft Auto
        /// 9: ???
        /// 10: ???
        /// 11: Assault on a civilian (a "2-40")
        /// 12: Assault on an officer
        /// 13: Assault with a deadly weapon (a "2-45")
        /// 14: Officer shot (a "2-45")
        /// 15: Pedestrian struck by a vehicle
        /// 16: Officer struck by a vehicle
        /// 17: Helicopter down (an "AC"?)
        /// 18: Civilian on fire (a "2-40")
        /// 19: Officer set on fire (a "10-99")
        /// 20: Car on fire
        /// 21: Air unit down (an "AC"?)
        /// 22: An explosion (a "9-96")
        /// 23: A stabbing (a "2-45") (also something else I couldn't understand)
        /// 24: Officer stabbed (also something else I couldn't understand)
        /// 25: Attack on a vehicle ("MDV"?)
        /// 26: Damage to property
        /// 27: Suspect threatening officer with a firearm
        /// 28: Shots fired
        /// 29: ???
        /// 30: ???
        /// 31: ???
        /// 32: ???
        /// 33: ???
        /// 34: A "2-45"
        /// 35: ???
        /// 36: A "9-25"
        /// 37: ???
        /// 38: ???
        /// 39: ???
        /// 40: ???
        /// 41: ???
        /// 42: ???
        /// 43: Possible disturbance
        /// 44: Civilian in need of assistance
        /// 45: ???
        /// 46: ???
        ///
        /// > Player player
        /// > int crimeType
        /// > int wantedLvlThresh
        ///
        /// </summary>
        REPORT_CRIME = 0xE9B09589827545E7,
        /// <summary>
        /// This was previously named as "RESERVE_ENTITY_EXPLODES_ON_HIGH_EXPLOSION_COMBO"
        /// which is obviously incorrect.
        /// 
        /// Seems to only appear in scripts used in Singleplayer. p1 ranges from 2 - 46.
        /// 
        /// 
        /// I assume this switches the crime type
        ///
        /// > Player player
        /// > int p1
        ///
        /// </summary>
        _SWITCH_CRIME_TYPE = 0x9A987297ED8BD838,
        /// <summary>
        /// Assigns the handle of locked-on melee target to *entity that you pass it.
        /// Returns false if no entity found.
        ///
        /// > Player player
        /// > Entity* entity
        ///
        /// </summary>
        GET_PLAYER_TARGET_ENTITY = 0x13EDE1A5DBF797C9,
        /// <summary>
        /// Gets a value indicating whether the specified player is currently aiming freely.
        ///
        /// > Player player
        ///
        /// </summary>
        IS_PLAYER_FREE_AIMING = 0x2E397FD2ECD37C87,
        /// <summary>
        /// Gets a value indicating whether the specified player is currently aiming freely at the specified entity.
        ///
        /// > Player player
        /// > Entity entity
        ///
        /// </summary>
        IS_PLAYER_FREE_AIMING_AT_ENTITY = 0x3C06B5C839B38F7B,
        /// <summary>
        /// Returns TRUE if it found an entity in your crosshair within range of your weapon. Assigns the handle of the target to the *entity that you pass it.
        /// Returns false if no entity found.
        ///
        /// > Player player
        /// > Entity* entity
        ///
        /// </summary>
        GET_ENTITY_PLAYER_IS_FREE_AIMING_AT = 0x2975C866E6713290,
        /// <summary>
        /// Affects the range of auto aim target.
        ///
        /// > Player player
        /// > float range
        ///
        /// </summary>
        SET_PLAYER_LOCKON_RANGE_OVERRIDE = 0x29961D490E5814FD,
        /// <summary>
        /// Set whether this player should be able to do drive-bys.
        /// 
        /// "A drive-by is when a ped is aiming/shooting from vehicle. This includes middle finger taunts. By setting this value to false I confirm the player is unable to do all that. Tested on tick."
        /// 
        ///
        /// > Player player
        /// > BOOL toggle
        ///
        /// </summary>
        SET_PLAYER_CAN_DO_DRIVE_BY = 0x6E8834B52EC20C77,
        /// <summary>
        /// Sets whether this player can be hassled by gangs.
        ///
        /// > Player player
        /// > BOOL toggle
        ///
        /// </summary>
        SET_PLAYER_CAN_BE_HASSLED_BY_GANGS = 0xD5E460AD7020A246,
        /// <summary>
        /// Sets whether this player can take cover.
        ///
        /// > Player player
        /// > BOOL toggle
        ///
        /// </summary>
        SET_PLAYER_CAN_USE_COVER = 0xD465A8599DFF6814,
        /// <summary>
        /// Gets the maximum wanted level the player can get.
        /// Ranges from 0 to 5.
        ///
        ///
        /// </summary>
        GET_MAX_WANTED_LEVEL = 0x462E0DB9B137DC5F,
        /// <summary>
        /// Returns the group ID the player is member of.
        ///
        /// > Player player
        ///
        /// </summary>
        GET_PLAYER_GROUP = 0x0D127585F77030AF,
        /// <summary>
        /// Can the player control himself, used to disable controls for player for things like a cutscene.
        /// 
        /// ---
        /// 
        /// You can't disable controls with this, use SET_PLAYER_CONTROL(...) for this. 
        ///
        /// > Player player
        ///
        /// </summary>
        IS_PLAYER_CONTROL_ON = 0x49C32D60007AFA47,
        /// <summary>
        /// Returns true when the player is not able to control the cam i.e. when running a benchmark test, switching the player or viewing a cutscene.
        /// 
        /// Note: I am not 100% sure if the native actually checks if the cam control is disabled but it seems promising.
        ///
        ///
        /// </summary>
        _IS_PLAYER_CAM_CONTROL_DISABLED = 0x7C814D2FB49F40C0,
        /// <summary>
        /// Returns TRUE if the player ('s ped) is climbing at the moment.
        ///
        /// > Player player
        ///
        /// </summary>
        IS_PLAYER_CLIMBING = 0x95E8F73DC65EFB9C,
        /// <summary>
        /// Return true while player is being arrested / busted.
        /// 
        /// If atArresting is set to 1, this function will return 1 when player is being arrested (while player is putting his hand up, but still have control)
        /// 
        /// If atArresting is set to 0, this function will return 1 only when the busted screen is shown.
        ///
        /// > Player player
        /// > BOOL atArresting
        ///
        /// </summary>
        IS_PLAYER_BEING_ARRESTED = 0x388A47C51ABDAC8E,
        /// <summary>
        /// Alternative: GET_VEHICLE_PED_IS_IN(PLAYER_PED_ID(), 1);
        ///
        ///
        /// </summary>
        GET_PLAYERS_LAST_VEHICLE = 0xB6997A7EB3F5C8C0,
        /// <summary>
        /// Returns the same as PLAYER_ID and NETWORK_PLAYER_ID_TO_INT
        ///
        ///
        /// </summary>
        GET_PLAYER_INDEX = 0xA5EDC40EF369B48D,
        /// <summary>
        /// Simply returns whatever is passed to it (Regardless of whether the handle is valid or not).
        ///
        /// > int value
        ///
        /// </summary>
        INT_TO_PLAYERINDEX = 0x41BD2A6B006AF756,
        /// <summary>
        /// Simply returns whatever is passed to it (Regardless of whether the handle is valid or not).
        /// --------------------------------------------------------
        /// if (NETWORK::NETWORK_IS_PARTICIPANT_ACTIVE(PLAYER::INT_TO_PARTICIPANTINDEX(i)))
        /// 
        ///
        /// > int value
        ///
        /// </summary>
        INT_TO_PARTICIPANTINDEX = 0x9EC6603812C24710,
        /// <summary>
        /// This returns YOUR 'identity' as a Player type.
        /// 
        /// Always returns 0 in story mode.
        ///
        ///
        /// </summary>
        PLAYER_ID = 0x4F8644AF03D0E0D6,
        /// <summary>
        /// Returns current player ped
        ///
        ///
        /// </summary>
        PLAYER_PED_ID = 0xD80958FC74E988A6,
        /// <summary>
        /// Does exactly the same thing as PLAYER_ID()
        ///
        ///
        /// </summary>
        NETWORK_PLAYER_ID_TO_INT = 0xEE68096F9F37341E,
        /// <summary>
        /// used with 1,2,8,64,128 in the scripts
        ///
        /// > int cleanupFlags
        ///
        /// </summary>
        FORCE_CLEANUP = 0xBC8983F38F78ED51,
        /// <summary>
        /// PLAYER::FORCE_CLEANUP_FOR_ALL_THREADS_WITH_THIS_NAME("pb_prostitute", 1); // Found in decompilation
        ///
        /// > const char* name
        /// > int cleanupFlags
        ///
        /// </summary>
        FORCE_CLEANUP_FOR_ALL_THREADS_WITH_THIS_NAME = 0x4C68DDDDF0097317,
        /// <summary>
        /// 1 - Welcome to Los Santos
        /// 2 - A Friendship Resurrected
        /// 3 - A Fair Day's Pay
        /// 4 - The Moment of Truth
        /// 5 - To Live or Die in Los Santos
        /// 6 - Diamond Hard
        /// 7 - Subversive
        /// 8 - Blitzed
        /// 9 - Small Town, Big Job
        /// 10 - The Government Gimps
        /// 11 - The Big One!
        /// 12 - Solid Gold, Baby!
        /// 13 - Career Criminal
        /// 14 - San Andreas Sightseer
        /// 15 - All's Fare in Love and War
        /// 16 - TP Industries Arms Race
        /// 17 - Multi-Disciplined
        /// 18 - From Beyond the Stars
        /// 19 - A Mystery, Solved
        /// 20 - Waste Management
        /// 21 - Red Mist
        /// 22 - Show Off
        /// 23 - Kifflom!
        /// 24 - Three Man Army
        /// 25 - Out of Your Depth
        /// 26 - Altruist Acolyte
        /// 27 - A Lot of Cheddar
        /// 28 - Trading Pure Alpha
        /// 29 - Pimp My Sidearm
        /// 30 - Wanted: Alive Or Alive
        /// 31 - Los Santos Customs
        /// 32 - Close Shave
        /// 33 - Off the Plane
        /// 34 - Three-Bit Gangster
        /// 35 - Making Moves
        /// 36 - Above the Law
        /// 37 - Numero Uno
        /// 38 - The Midnight Club
        /// 39 - Unnatural Selection
        /// 40 - Backseat Driver
        /// 41 - Run Like The Wind
        /// 42 - Clean Sweep
        /// 43 - Decorated
        /// 44 - Stick Up Kid
        /// 45 - Enjoy Your Stay
        /// 46 - Crew Cut
        /// 47 - Full Refund
        /// 48 - Dialling Digits
        /// 49 - American Dream
        /// 50 - A New Perspective
        /// 51 - Be Prepared
        /// 52 - In the Name of Science
        /// 53 - Dead Presidents
        /// 54 - Parole Day
        /// 55 - Shot Caller
        /// 56 - Four Way
        /// 57 - Live a Little
        /// 58 - Can't Touch This
        /// 59 - Mastermind
        /// 60 - Vinewood Visionary
        /// 61 - Majestic
        /// 62 - Humans of Los Santos
        /// 63 - First Time Director
        /// 64 - Animal Lover
        /// 65 - Ensemble Piece
        /// 66 - Cult Movie
        /// 67 - Location Scout
        /// 68 - Method Actor
        /// 69 - Cryptozoologist
        /// 70 - Getting Started
        /// 71 - The Data Breaches
        /// 72 - The Bogdan Problem
        /// 73 - The Doomsday Scenario
        /// 74 - A World Worth Saving
        /// 75 - Orbital Obliteration
        /// 76 - Elitist
        /// 77 - Masterminds
        ///
        /// > int achievementId
        ///
        /// </summary>
        GIVE_ACHIEVEMENT_TO_PLAYER = 0xBEC7076D64130195,
        /// <summary>
        /// For Steam.
        /// Does nothing and always returns false in the retail version of the game.
        ///
        /// > int achievementId
        /// > int progress
        ///
        /// </summary>
        _SET_ACHIEVEMENT_PROGRESS = 0xC2AFFFDABBDC2C5C,
        /// <summary>
        /// For Steam.
        /// Always returns 0 in retail version of the game.
        ///
        /// > int achievementId
        ///
        /// </summary>
        _GET_ACHIEVEMENT_PROGRESS = 0x1C186837D0619335,
        /// <summary>
        /// See GIVE_ACHIEVEMENT_TO_PLAYER
        ///
        /// > int achievementId
        ///
        /// </summary>
        HAS_ACHIEVEMENT_BEEN_PASSED = 0x867365E111A3B6EB,
        /// <summary>
        /// Returns TRUE if the game is in online mode and FALSE if in offline mode.
        /// 
        /// This is an alias for NETWORK_IS_SIGNED_ONLINE.
        ///
        ///
        /// </summary>
        IS_PLAYER_ONLINE = 0xF25D331DC2627BBC,
        /// <summary>
        /// this function is hard-coded to always return 0.
        ///
        ///
        /// </summary>
        IS_PLAYER_LOGGING_IN_NP = 0x74556E1420867ECA,
        /// <summary>
        /// Purpose of the BOOL currently unknown.
        /// Both, true and false, work
        ///
        /// > BOOL unk
        ///
        /// </summary>
        DISPLAY_SYSTEM_SIGNIN_UI = 0x94DD7888C10A979E,
        /// <summary>
        /// Simply sets you as invincible (Health will not deplete).
        /// 
        /// Use 0x733A643B5B0C53C1 instead if you want Ragdoll enabled, which is equal to:
        /// *(DWORD *)(playerPedAddress + 0x188) |= (1 << 9);
        ///
        /// > Player player
        /// > BOOL toggle
        ///
        /// </summary>
        SET_PLAYER_INVINCIBLE = 0x239528EACDC3E7DE,
        /// <summary>
        /// Returns the Player's Invincible status.
        /// 
        /// This function will always return false if 0x733A643B5B0C53C1 is used to set the invincibility status. To always get the correct result, use this:
        /// 
        ///  bool IsPlayerInvincible(Player player)
        ///     {
        ///      auto addr = getScriptHandleBaseAddress(GET_PLAYER_PED(player)); 
        /// 
        ///         if (addr)
        ///      {
        ///          DWORD flag = *(DWORD *)(addr + 0x188);
        ///             return ((flag & (1 << 8)) != 0) || ((flag & (1 << 9)) != 0);
        ///       }
        /// 
        ///        return false;
        ///  }
        /// 
        /// 
        ///
        /// > Player player
        ///
        /// </summary>
        GET_PLAYER_INVINCIBLE = 0xB721981B2B939E07,
        /// <summary>
        /// Example from fm_mission_controler.ysc.c4:
        /// 
        /// PLAYER::SET_PLAYER_LOCKON(PLAYER::PLAYER_ID(), 1);
        /// 
        /// All other decompiled scripts using this seem to be using the player id as the first parameter, so I feel the need to confirm it as so.
        /// 
        /// No need to confirm it says PLAYER_ID() so it uses PLAYER_ID() lol.
        ///
        /// > Player player
        /// > BOOL toggle
        ///
        /// </summary>
        SET_PLAYER_LOCKON = 0x5C8B2F450EE4328E,
        /// <summary>
        /// Sets your targeting mode.
        /// 0 = Assisted Aim - Full
        /// 1 = Assisted Aim - Partial
        /// 2 = Free Aim - Assisted
        /// 3 = Free Aim
        ///
        /// > int targetMode
        ///
        /// </summary>
        SET_PLAYER_TARGETING_MODE = 0xB1906895227793F3,
        /// <summary>
        /// This can be between 1.0f - 14.9f 
        /// 
        /// You can change the max in IDA from 15.0. I say 15.0 as the function blrs if what you input is greater than or equal to 15.0 hence why it's 14.9 max default.
        /// 
        /// 
        ///
        /// > Player player
        /// > float multiplier
        ///
        /// </summary>
        SET_AIR_DRAG_MULTIPLIER_FOR_PLAYERS_VEHICLE = 0xCA7DC8329F0A1E9E,
        /// <summary>
        /// Swim speed multiplier.
        /// Multiplier goes up to 1.49
        /// 
        /// Just call it one time, it is not required to be called once every tick. - Note copied from below native.
        /// 
        /// Note: At least the IDA method if you change the max float multiplier from 1.5 it will change it for both this and RUN_SPRINT below. I say 1.5 as the function blrs if what you input is greater than or equal to 1.5 hence why it's 1.49 max default.
        ///
        /// > Player player
        /// > float multiplier
        ///
        /// </summary>
        SET_SWIM_MULTIPLIER_FOR_PLAYER = 0xA91C6F0FF7D16A13,
        /// <summary>
        /// Multiplier goes up to 1.49 any value above will be completely overruled by the game and the multiplier will not take effect, this can be edited in memory however.
        /// 
        /// Just call it one time, it is not required to be called once every tick.
        /// 
        /// Note: At least the IDA method if you change the max float multiplier from 1.5 it will change it for both this and SWIM above. I say 1.5 as the function blrs if what you input is greater than or equal to 1.5 hence why it's 1.49 max default.
        ///
        /// > Player player
        /// > float multiplier
        ///
        /// </summary>
        SET_RUN_SPRINT_MULTIPLIER_FOR_PLAYER = 0x6DB47AA77FD94E09,
        /// <summary>
        /// Returns the time since the character was arrested in (ms) milliseconds.
        /// 
        /// example
        /// 
        /// var time = Function.call<int>(Hash.GET_TIME_SINCE_LAST_ARREST();
        /// 
        /// UI.DrawSubtitle(time.ToString());
        /// 
        /// if player has not been arrested, the int returned will be -1.
        ///
        ///
        /// </summary>
        GET_TIME_SINCE_LAST_ARREST = 0x5063F92F07C2A316,
        /// <summary>
        /// Returns the time since the character died in (ms) milliseconds.
        /// 
        /// example
        /// 
        /// var time = Function.call<int>(Hash.GET_TIME_SINCE_LAST_DEATH();
        /// 
        /// UI.DrawSubtitle(time.ToString());
        /// 
        /// if player has not died, the int returned will be -1.
        ///
        ///
        /// </summary>
        GET_TIME_SINCE_LAST_DEATH = 0xC7034807558DDFCA,
        /// <summary>
        /// Inhibits the player from using any method of combat including melee and firearms.
        /// 
        /// NOTE: Only disables the firing for one frame
        ///
        /// > Player player
        /// > BOOL toggle
        ///
        /// </summary>
        DISABLE_PLAYER_FIRING = 0x5E6CC07646BBEAB8,
        /// <summary>
        /// Default is 100. Use player id and not ped id. For instance: PLAYER::SET_PLAYER_MAX_ARMOUR(PLAYER::PLAYER_ID(), 100); // main_persistent.ct4
        ///
        /// > Player player
        /// > int value
        ///
        /// </summary>
        SET_PLAYER_MAX_ARMOUR = 0x77DFCCF5948B8C71,
        /// <summary>
        /// p1 is always 0 in the scripts
        ///
        /// > Player player
        /// > int p1
        ///
        /// </summary>
        _SPECIAL_ABILITY_ACTIVATE = 0x821FDC827D6F4090,
        /// <summary>
        /// p1 is always 0 in the scripts
        ///
        /// > Player player
        /// > int p1
        ///
        /// </summary>
        _SPECIAL_ABILITY_DEPLETE = 0x17F7471EACA78290,
        /// <summary>
        /// Every occurrence of p1 & p2 were both true.
        ///
        /// > Player player
        /// > BOOL p1
        /// > BOOL p2
        /// > Any p3
        ///
        /// </summary>
        SPECIAL_ABILITY_CHARGE_SMALL = 0x2E7B9B683481687D,
        /// <summary>
        /// Only 1 match. Both p1 & p2 were true.
        ///
        /// > Player player
        /// > BOOL p1
        /// > BOOL p2
        /// > Any p3
        ///
        /// </summary>
        SPECIAL_ABILITY_CHARGE_MEDIUM = 0xF113E3AA9BC54613,
        /// <summary>
        /// 2 matches. p1 was always true.
        ///
        /// > Player player
        /// > BOOL p1
        /// > BOOL p2
        /// > Any p3
        ///
        /// </summary>
        SPECIAL_ABILITY_CHARGE_LARGE = 0xF733F45FA4497D93,
        /// <summary>
        /// p1 appears to always be 1 (only comes up twice)
        ///
        /// > Player player
        /// > Ped p1
        /// > Any p2
        ///
        /// </summary>
        SPECIAL_ABILITY_CHARGE_CONTINUOUS = 0xED481732DFF7E997,
        /// <summary>
        /// p1 appears as 5, 10, 15, 25, or 30. p2 is always true.
        ///
        /// > Player player
        /// > int p1
        /// > BOOL p2
        /// > Any p3
        ///
        /// </summary>
        SPECIAL_ABILITY_CHARGE_ABSOLUTE = 0xB7B0870EB531D08D,
        /// <summary>
        /// 
        /// normalizedValue is from 0.0 - 1.0
        /// p2 is always 1
        ///
        /// > Player player
        /// > float normalizedValue
        /// > BOOL p2
        /// > Any p3
        ///
        /// </summary>
        SPECIAL_ABILITY_CHARGE_NORMALIZED = 0xA0696A65F009EE18,
        /// <summary>
        /// Also known as _RECHARGE_SPECIAL_ABILITY
        ///
        /// > Player player
        /// > BOOL p1
        /// > Any p2
        ///
        /// </summary>
        SPECIAL_ABILITY_FILL_METER = 0x3DACA8DDC6FD4980,
        /// <summary>
        /// p1 was always true.
        ///
        /// > Player player
        /// > BOOL p1
        /// > Any p2
        ///
        /// </summary>
        SPECIAL_ABILITY_DEPLETE_METER = 0x1D506DBBBC51E64B,
        /// <summary>
        /// `findCollisionLand`: This teleports the player to land when set to true and will not consider the Z coordinate parameter provided by you. It will automatically put the Z coordinate so that you don't fall from sky.
        ///
        /// > Player player
        /// > float x
        /// > float y
        /// > float z
        /// > float heading
        /// > BOOL p5
        /// > BOOL findCollisionLand
        /// > BOOL p7
        ///
        /// </summary>
        START_PLAYER_TELEPORT = 0xAD15F075A4DA0FDE,
        /// <summary>
        /// Disables the player's teleportation
        ///
        ///
        /// </summary>
        STOP_PLAYER_TELEPORT = 0xC449EDED9D73009C,
        /// <summary>
        /// `regenRate`: The recharge multiplier, a value between 0.0 and 1.0.
        /// Use 1.0 to reset it back to normal
        ///
        /// > Player player
        /// > float regenRate
        ///
        /// </summary>
        SET_PLAYER_HEALTH_RECHARGE_MULTIPLIER = 0x5DB660B38DD98A31,
        /// <summary>
        /// This modifies the damage value of your weapon. Whether it is a multiplier or base damage is unknown. 
        /// 
        /// Based on tests, it is unlikely to be a multiplier.
        /// 
        /// modifier's min value is 0.1
        ///
        /// > Player player
        /// > float modifier
        ///
        /// </summary>
        SET_PLAYER_WEAPON_DAMAGE_MODIFIER = 0xCE07B9F7817AADA3,
        /// <summary>
        /// modifier's min value is 0.1
        ///
        /// > Player player
        /// > float modifier
        ///
        /// </summary>
        SET_PLAYER_WEAPON_DEFENSE_MODIFIER = 0x2D83BC011CA14A3C,
        /// <summary>
        /// modifier's min value is 0.1
        ///
        /// > Player player
        /// > float modifier
        ///
        /// </summary>
        _SET_PLAYER_WEAPON_DEFENSE_MODIFIER_2 = 0xBCFDE9EDE4CF27DC,
        /// <summary>
        /// modifier's min value is 0.1
        ///
        /// > Player player
        /// > float modifier
        /// > BOOL p2
        ///
        /// </summary>
        SET_PLAYER_MELEE_WEAPON_DAMAGE_MODIFIER = 0x4A3DC7ECCC321032,
        /// <summary>
        /// modifier's min value is 0.1
        ///
        /// > Player player
        /// > float modifier
        ///
        /// </summary>
        SET_PLAYER_MELEE_WEAPON_DEFENSE_MODIFIER = 0xAE540335B4ABC4E2,
        /// <summary>
        /// modifier's min value is 0.1
        ///
        /// > Player player
        /// > float modifier
        ///
        /// </summary>
        SET_PLAYER_VEHICLE_DAMAGE_MODIFIER = 0xA50E117CDDF82F0C,
        /// <summary>
        /// modifier's min value is 0.1
        ///
        /// > Player player
        /// > float modifier
        ///
        /// </summary>
        SET_PLAYER_VEHICLE_DEFENSE_MODIFIER = 0x4C60E6EFDAFF2462,
        /// <summary>
        /// Tints:
        ///    None = -1,
        ///     Rainbow = 0,
        ///   Red = 1,
        ///   SeasideStripes = 2,
        ///    WidowMaker = 3,
        ///    Patriot = 4,
        ///   Blue = 5,
        ///  Black = 6,
        ///     Hornet = 7,
        ///    AirFocce = 8,
        ///  Desert = 9,
        ///    Shadow = 10,
        ///   HighAltitude = 11,
        ///     Airbone = 12,
        ///  Sunrise = 13,
        /// 
        ///
        /// > Player player
        /// > int tintIndex
        ///
        /// </summary>
        SET_PLAYER_PARACHUTE_TINT_INDEX = 0xA3D0E54541D9A5E5,
        /// <summary>
        /// Tints:
        ///   None = -1,
        ///     Rainbow = 0,
        ///   Red = 1,
        ///   SeasideStripes = 2,
        ///    WidowMaker = 3,
        ///    Patriot = 4,
        ///   Blue = 5,
        ///  Black = 6,
        ///     Hornet = 7,
        ///    AirFocce = 8,
        ///  Desert = 9,
        ///    Shadow = 10,
        ///   HighAltitude = 11,
        ///     Airbone = 12,
        ///  Sunrise = 13,
        ///
        /// > Player player
        /// > int* tintIndex
        ///
        /// </summary>
        GET_PLAYER_PARACHUTE_TINT_INDEX = 0x75D3F7A1B0D9B145,
        /// <summary>
        /// Tints:
        ///    None = -1,
        ///     Rainbow = 0,
        ///   Red = 1,
        ///   SeasideStripes = 2,
        ///    WidowMaker = 3,
        ///    Patriot = 4,
        ///   Blue = 5,
        ///  Black = 6,
        ///     Hornet = 7,
        ///    AirFocce = 8,
        ///  Desert = 9,
        ///    Shadow = 10,
        ///   HighAltitude = 11,
        ///     Airbone = 12,
        ///  Sunrise = 13,
        ///
        /// > Player player
        /// > int index
        ///
        /// </summary>
        SET_PLAYER_RESERVE_PARACHUTE_TINT_INDEX = 0xAF04C87F5DC1DF38,
        /// <summary>
        /// Tints:
        ///   None = -1,
        ///     Rainbow = 0,
        ///   Red = 1,
        ///   SeasideStripes = 2,
        ///    WidowMaker = 3,
        ///    Patriot = 4,
        ///   Blue = 5,
        ///  Black = 6,
        ///     Hornet = 7,
        ///    AirFocce = 8,
        ///  Desert = 9,
        ///    Shadow = 10,
        ///   HighAltitude = 11,
        ///     Airbone = 12,
        ///  Sunrise = 13,
        ///
        /// > Player player
        /// > int* index
        ///
        /// </summary>
        GET_PLAYER_RESERVE_PARACHUTE_TINT_INDEX = 0xD5A016BC3C09CF40,
        /// <summary>
        /// tints 0- 13
        /// 0 - unkown
        /// 1 - unkown
        /// 2 - unkown
        /// 3 - unkown
        /// 4 - unkown
        ///
        /// > Player player
        /// > int tintIndex
        ///
        /// </summary>
        SET_PLAYER_PARACHUTE_PACK_TINT_INDEX = 0x93B0FB27C9A04060,
        /// <summary>
        /// example:
        /// 
        /// flags: 0-6
        /// 
        /// PLAYER::SET_PLAYER_RESET_FLAG_PREFER_REAR_SEATS(PLAYER::PLAYER_ID(), 6);
        /// 
        /// wouldnt the flag be the seatIndex?
        ///
        /// > Player player
        /// > int flags
        ///
        /// </summary>
        SET_PLAYER_RESET_FLAG_PREFER_REAR_SEATS = 0x11D5F725F0E780E0,
        /// <summary>
        /// Values around 1.0f to 2.0f used in game scripts.
        ///
        /// > Player player
        /// > float multiplier
        ///
        /// </summary>
        SET_PLAYER_SNEAKING_NOISE_MULTIPLIER = 0xB2C1A29588A9F47C,
        /// <summary>
        /// This is to make the player walk without accepting input from INPUT.
        /// 
        /// gaitType is in increments of 100s. 2000, 500, 300, 200, etc.
        /// 
        /// p4 is always 1 and p5 is always 0.
        /// 
        /// C# Example :
        /// 
        /// Function.Call(Hash.SIMULATE_PLAYER_INPUT_GAIT, Game.Player, 1.0f, 100, 1.0f, 1, 0); //Player will go forward for 100ms
        ///
        /// > Player player
        /// > float amount
        /// > int gaitType
        /// > float speed
        /// > BOOL p4
        /// > BOOL p5
        ///
        /// </summary>
        SIMULATE_PLAYER_INPUT_GAIT = 0x477D5D63E63ECA5D,
        /// <summary>
        /// Every occurrence was either 0 or 2.
        ///
        /// > int index
        ///
        /// </summary>
        SET_PLAYER_CLOTH_PACKAGE_INDEX = 0x9F7BBA2EA6372500,
        /// <summary>
        /// 6 matches across 4 scripts. 5 occurrences were 240. The other was 255.
        ///
        /// > int value
        ///
        /// </summary>
        SET_PLAYER_CLOTH_LOCK_COUNTER = 0x14D913B777DFF5DA,
        /// <summary>
        /// Only 1 match. ob_sofa_michael.
        /// 
        /// PLAYER::PLAYER_ATTACH_VIRTUAL_BOUND(-804.5928f, 173.1801f, 71.68436f, 0f, 0f, 0.590625f, 1f, 0.7f);1.0.335.2, 1.0.350.1/2, 1.0.372.2, 1.0.393.2, 1.0.393.4, 1.0.463.1;
        ///
        /// > float p0
        /// > float p1
        /// > float p2
        /// > float p3
        /// > float p4
        /// > float p5
        /// > float p6
        /// > float p7
        ///
        /// </summary>
        PLAYER_ATTACH_VIRTUAL_BOUND = 0xED51733DC73AED51,
        /// <summary>
        /// 1.0.335.2, 1.0.350.1/2, 1.0.372.2, 1.0.393.2, 1.0.393.4, 1.0.463.1;
        ///
        ///
        /// </summary>
        PLAYER_DETACH_VIRTUAL_BOUND = 0x1DD5897E2FA6E7C9,
        /// <summary>
        /// Returns true if an unk value is greater than 0.0f
        ///
        /// > Player player
        ///
        /// </summary>
        IS_PLAYER_BATTLE_AWARE = 0x38D28DA81E4E9BF9,
        /// <summary>
        /// Appears only 3 times in the scripts, more specifically in michael1.ysc
        /// 
        /// -
        /// This can be used to prevent dying if you are "out of the world"
        ///
        /// > float x
        /// > float y
        /// > float z
        ///
        /// </summary>
        EXTEND_WORLD_BOUNDARY_FOR_PLAYER = 0x5006D96C995A5827,
        /// <summary>
        /// Returns true if the player is riding a train.
        ///
        /// > Player player
        ///
        /// </summary>
        IS_PLAYER_RIDING_TRAIN = 0x4EC12697209F2196,
        /// <summary>
        /// p1 was always 5.
        /// p4 was always false.
        ///
        /// > Player player
        /// > int p1
        /// > Any p2
        /// > Any p3
        /// > BOOL p4
        ///
        /// </summary>
        SET_PLAYER_PARACHUTE_VARIATION_OVERRIDE = 0xD9284A8C0D48352C,
        /// <summary>
        /// - This is called after SET_ALL_RANDOM_PEDS_FLEE_THIS_FRAME
        /// 
        ///
        /// > Player player
        ///
        /// </summary>
        _0xC3376F42B1FACCC6 = 0xC3376F42B1FACCC6,
        /// <summary>
        /// Seems to only appear in scripts used in Singleplayer.
        /// 
        /// Always used like this in scripts
        /// PLAYER::_BC9490CA15AEA8FB(PLAYER::PLAYER_ID());
        ///
        /// > Player player
        ///
        /// </summary>
        _0xBC9490CA15AEA8FB = 0xBC9490CA15AEA8FB,
        /// <summary>
        /// This has been found in use in the decompiled files.
        ///
        /// > Player player
        ///
        /// </summary>
        _0x4669B3ED80F24B4E = 0x4669B3ED80F24B4E,
        /// <summary>
        /// This has been found in use in the decompiled files.
        ///
        /// > Player player
        ///
        /// </summary>
        _0xAD73CE5A09E42D12 = 0xAD73CE5A09E42D12,
        /// <summary>
        /// PLAYER::0xBF6993C7(rPtr((&l_122) + 71)); // Found in decompilation
        /// 
        /// ***
        /// 
        /// In "am_hold_up.ysc" used once:
        /// 
        /// l_8d._f47 = MISC::GET_RANDOM_FLOAT_IN_RANGE(18.0, 28.0);
        /// PLAYER::_B45EFF719D8427A6((l_8d._f47));
        ///
        /// > float p0
        ///
        /// </summary>
        _0xB45EFF719D8427A6 = 0xB45EFF719D8427A6,
        /// <summary>
        /// 2 matches in 1 script - am_hold_up
        /// 
        /// Used in multiplayer scripts?
        ///
        ///
        /// </summary>
        _0x0032A6DBA562C518 = 0x0032A6DBA562C518,
        /// <summary>
        /// Always returns false.
        ///
        /// > Player player
        ///
        /// </summary>
        _0xDCC07526B8EC45AF = 0xDCC07526B8EC45AF,
        /// <summary>
        /// Found in "director_mode", "fm_bj_race_controler", "fm_deathmatch_controler", "fm_impromptu_dm_controler", "fm_race_controler", "gb_deathmatch".
        ///
        /// > Player player
        /// > BOOL p1
        ///
        /// </summary>
        _0xCAC57395B151135F = 0xCAC57395B151135F,
        /// <summary>
        /// Returns profile setting 237.
        /// 
        /// GET_*
        ///
        ///
        /// </summary>
        _0xB9CF1F793A9F1BF1 = 0xB9CF1F793A9F1BF1,
        /// <summary>
        /// Returns profile setting 243.
        /// 
        /// GET_*
        ///
        ///
        /// </summary>
        _0xCB645E85E97EA48B = 0xCB645E85E97EA48B,
        /// <summary>
        /// Disables something. Used only once in R* scripts (freemode.ysc).
        /// 
        /// DISABLE_PLAYER_*
        ///
        ///
        /// </summary>
        _0xB885852C39CC265D = 0xB885852C39CC265D,
        /// <summary>
        /// Appears once in "re_dealgonewrong"
        ///
        /// > Player player
        ///
        /// </summary>
        _0x5FC472C501CCADB3 = 0x5FC472C501CCADB3,
        /// <summary>
        /// Only 1 occurrence. p1 was 2.
        ///
        /// > Player player
        /// > int p1
        ///
        /// </summary>
        _0xF10B44FD479D69F3 = 0xF10B44FD479D69F3,
        /// <summary>
        /// 2 occurrences in agency_heist3a. p1 was 0.7f then 0.4f.
        ///
        /// > Player player
        /// > float p1
        ///
        /// </summary>
        _0xDD2620B7B9D16FF1 = 0xDD2620B7B9D16FF1,
        /// <summary>
        /// SET_PLAYER_MAX_*
        ///
        /// > Player player
        /// > float p1
        ///
        /// </summary>
        _0x8D768602ADEF2245 = 0x8D768602ADEF2245,
        /// <summary>
        /// IS_*
        ///
        /// > Player player
        ///
        /// </summary>
        _0x690A61A6D13583F6 = 0x690A61A6D13583F6,
        /// <summary>
        /// var num3 = PLAYER::GET_PLAYER_PED(l_2171); // proof l_2171 is a player
        /// 
        /// var num17 = PLAYER::0x9DF75B2A(l_2171, 100, 0); // l_2171
        /// 
        /// .ysc:
        ///     if (PLAYER::GET_PLAYER_WANTED_LEVEL(l_6EF) < v_4) { // l_6EF is a player
        ///         PLAYER::SET_PLAYER_WANTED_LEVEL(l_6EF, v_4, 0); // l_6EF
        ///         PLAYER::SET_PLAYER_WANTED_LEVEL_NOW(l_6EF, 0); // l_6EF
        ///     } else { 
        ///         PLAYER::_4669B3ED80F24B4E(l_6EF); // l_6EF
        ///         HUD::_BA8D65C1C65702E5(1);
        ///         a_0 = 1;
        ///     }
        /// 
        ///         if (l_4B24[l_6F2/*156*/]._f8C != PLAYER::_BC0753C9CA14B506(l_6EF, 100, 0)) { // l_6EF
        ///             l_4B24[l_6F2/*156*/]._f8C = PLAYER::_BC0753C9CA14B506(l_6EF, 100, 0); // l_6EF
        ///         }
        /// 
        /// Both was taken from fm_mission_controller
        /// 
        /// GET_PLAYER_*
        ///
        /// > Player player
        /// > int p1
        /// > BOOL p2
        ///
        /// </summary>
        _0xBC0753C9CA14B506 = 0xBC0753C9CA14B506,
        /// <summary>
        /// Used with radios:
        /// 
        /// void sub_cf383(auto _a0) {
        ///     if ((a_0)==1) {
        ///         if (MISC::IS_BIT_SET((g_240005._f1), 3)) {
        ///             PLAYER::_2F7CEB6520288061(0);
        ///             AUDIO::SET_AUDIO_FLAG("AllowRadioDuringSwitch", 0);
        ///             AUDIO::SET_MOBILE_PHONE_RADIO_STATE(0);
        ///             AUDIO::SET_AUDIO_FLAG("MobileRadioInGame", 0);
        ///         }
        ///         sub_cf3f6(1);
        ///     } else { 
        ///         if (MISC::IS_BIT_SET((g_240005._f1), 3)) {
        ///             PLAYER::_2F7CEB6520288061(1);
        ///             AUDIO::SET_AUDIO_FLAG("AllowRadioDuringSwitch", 1);
        ///             AUDIO::SET_MOBILE_PHONE_RADIO_STATE(1);
        ///             AUDIO::SET_AUDIO_FLAG("MobileRadioInGame", 1);
        ///         }
        ///         sub_cf3f6(0);
        ///     }
        /// }
        /// 
        /// SET_PLAYER_S*
        ///
        /// > BOOL p0
        ///
        /// </summary>
        _0x2F7CEB6520288061 = 0x2F7CEB6520288061,
        /// <summary>
        /// DISABLE_*
        ///
        /// > Player player
        ///
        /// </summary>
        _0x5501B7A5CDB79D37 = 0x5501B7A5CDB79D37,
        /// <summary>
        /// Unsets playerPed+330 if the current weapon has certain flags.
        ///
        /// > Any p0
        ///
        /// </summary>
        _0x237440E46D918649 = 0x237440E46D918649,
        /// <summary>
        /// ADD_*
        ///
        /// > Player player
        /// > Entity entity
        ///
        /// </summary>
        _0x9097EB6D4BB9A12A = 0x9097EB6D4BB9A12A,
        /// <summary>
        /// REMOVE_*
        ///
        /// > Player player
        /// > Entity entity
        ///
        /// </summary>
        _0x9F260BFB59ADBCA3 = 0x9F260BFB59ADBCA3,
        /// <summary>
        /// Resets values set by 0x70A382ADEC069DD3
        /// _RESET_VOIP_*
        ///
        ///
        /// </summary>
        _0x7148E0F43D11F0D9 = 0x7148E0F43D11F0D9,
        /// <summary>
        /// Might be voip related
        /// _SET_VOIP_*
        ///
        /// > float coordX
        /// > float coordY
        /// > float coordZ
        ///
        /// </summary>
        _0x70A382ADEC069DD3 = 0x70A382ADEC069DD3,
        CHANGE_PLAYER_PED = 0x048189FAC643DEEE,
        GET_PLAYER_RGB_COLOUR = 0xE902EF951DCE178F,
        _GET_NUMBER_OF_PLAYERS_IN_TEAM = 0x1FC200409F10E6F1,
        GET_PLAYER_NAME = 0x6D0DE6A7B5DA71F8,
        GET_PLAYER_WANTED_CENTRE_POSITION = 0x0C92BA89F1AF26F8,
        ARE_PLAYER_FLASHING_STARS_ABOUT_TO_DROP = 0xAFAF86043E5874E9,
        ARE_PLAYER_STARS_GREYED_OUT = 0x0A6EB355EE14A2DB,
        SET_DISPATCH_COPS_FOR_PLAYER = 0xDB172424876553F4,
        IS_PLAYER_WANTED_LEVEL_GREATER = 0x238DB2A2C23EE9EF,
        IS_PLAYER_DEAD = 0x424D4687FA1E5652,
        IS_PLAYER_PRESSING_HORN = 0xFA1E2BF8B10598F9,
        GET_PLAYER_WANTED_LEVEL = 0xE28E54788CE8F12D,
        SET_MAX_WANTED_LEVEL = 0xAA5F02DB48D704B9,
        SET_EVERYONE_IGNORE_PLAYER = 0x8EEDA153AD141BA4,
        SET_ALL_RANDOM_PEDS_FLEE = 0x056E0FE8534C2949,
        SET_ALL_RANDOM_PEDS_FLEE_THIS_FRAME = 0x471D2FF42A94B4F2,
        SET_IGNORE_LOW_PRIORITY_SHOCKING_EVENTS = 0x596976B02B6B5700,
        SET_WANTED_LEVEL_MULTIPLIER = 0x020E5F00CDA207BA,
        RESET_WANTED_LEVEL_DIFFICULTY = 0xB9D0DD990DC141DD,
        _GET_WANTED_LEVEL_PAROLE_DURATION = 0xA72200F51875FEA4,
        _SET_WANTED_LEVEL_HIDDEN_EVASION_TIME = 0x49B856B1360C47C7,
        START_FIRING_AMNESTY = 0xBF9BD71691857E48,
        REPORT_POLICE_SPOTTED_PLAYER = 0xDC64D2C53493ED12,
        CAN_PLAYER_START_MISSION = 0xDE7465A27D403C06,
        IS_PLAYER_READY_FOR_CUTSCENE = 0x908CBECC2CAA3690,
        IS_PLAYER_TARGETTING_ENTITY = 0x7912F7FC4F6264B6,
        IS_PLAYER_TARGETTING_ANYTHING = 0x78CFE51896B6B8A4,
        SET_PLAYER_SPRINT = 0xA01B8075D8B92DF4,
        RESET_PLAYER_STAMINA = 0xA6F312FCCE9C1DFE,
        RESTORE_PLAYER_STAMINA = 0xA352C1B864CAFD33,
        GET_PLAYER_SPRINT_STAMINA_REMAINING = 0x3F9F16F8E65A7ED7,
        GET_PLAYER_SPRINT_TIME_REMAINING = 0x1885BC9B108B4C99,
        GET_PLAYER_UNDERWATER_TIME_REMAINING = 0xA1FCF8E6AF40B731,
        _SET_PLAYER_UNDERWATER_TIME_REMAINING = 0xA0D3E4F7AAFB7E78,
        GET_PLAYER_MAX_ARMOUR = 0x92659B4CE1863CB3,
        IS_PLAYER_SCRIPT_CONTROL_ON = 0x8A876A65283DD7D7,
        RESET_PLAYER_ARREST_STATE = 0x2D03E13C460760D6,
        GET_TIME_SINCE_PLAYER_HIT_VEHICLE = 0x5D35ECF3A81A0EE0,
        GET_TIME_SINCE_PLAYER_HIT_PED = 0xE36A25322DC35F42,
        GET_TIME_SINCE_PLAYER_DROVE_ON_PAVEMENT = 0xD559D2BE9E37853B,
        GET_TIME_SINCE_PLAYER_DROVE_AGAINST_TRAFFIC = 0xDB89591E290D9182,
        IS_PLAYER_FREE_FOR_AMBIENT_TASK = 0xDCCFD3F106C36AB4,
        HAS_FORCE_CLEANUP_OCCURRED = 0xC968670BFACE42D9,
        FORCE_CLEANUP_FOR_THREAD_WITH_THIS_ID = 0xF745B37630DF176B,
        GET_CAUSE_OF_MOST_RECENT_FORCE_CLEANUP = 0x9A41CF4674A12272,
        SET_PLAYER_MAY_ONLY_ENTER_THIS_VEHICLE = 0x8026FF78F208978A,
        SET_PLAYER_MAY_NOT_ENTER_ANY_VEHICLE = 0x1DE37BBF9E9CC14A,
        IS_SYSTEM_UI_BEING_DISPLAYED = 0x5D511E3867C87139,
        _SET_PLAYER_INVINCIBLE_KEEP_RAGDOLL_ENABLED = 0x6BC97F4F4BB3C04B,
        REMOVE_PLAYER_HELMET = 0xF3AC26D3CC576528,
        GIVE_PLAYER_RAGDOLL_CONTROL = 0x3C49C870E66F0A28,
        SET_PLAYER_TARGET_LEVEL = 0x5702B917B99DB1CD,
        CLEAR_PLAYER_HAS_DAMAGED_AT_LEAST_ONE_PED = 0xF0B67A4DE6AB5F98,
        HAS_PLAYER_DAMAGED_AT_LEAST_ONE_PED = 0x20CE80B0C2BF4ACC,
        CLEAR_PLAYER_HAS_DAMAGED_AT_LEAST_ONE_NON_ANIMAL_PED = 0x4AACB96203D11A31,
        HAS_PLAYER_DAMAGED_AT_LEAST_ONE_NON_ANIMAL_PED = 0xE4B90F367BD81752,
        ASSISTED_MOVEMENT_CLOSE_ROUTE = 0xAEBF081FFC0A0E5E,
        ASSISTED_MOVEMENT_FLUSH_ROUTE = 0x8621390F0CDCFE1F,
        SET_PLAYER_FORCED_AIM = 0x0FEE4F80AC44A726,
        SET_PLAYER_FORCED_ZOOM = 0x75E7D505F2B15902,
        SET_PLAYER_FORCE_SKIP_AIM_INTRO = 0x7651BC64AE59E128,
        SET_DISABLE_AMBIENT_MELEE_MOVE = 0x2E8AABFA40A84F8C,
        _SET_SPECIAL_ABILITY = 0xB214D570EAD7F81A,
        SPECIAL_ABILITY_DEACTIVATE = 0xD6A953C6D1492057,
        SPECIAL_ABILITY_DEACTIVATE_FAST = 0x9CB5CE07A3968D5A,
        SPECIAL_ABILITY_RESET = 0x375F0E738F861A94,
        SPECIAL_ABILITY_CHARGE_ON_MISSION_FAILED = 0xC9A763D8FE87436A,
        SPECIAL_ABILITY_LOCK = 0x6A09D0D590A47D13,
        SPECIAL_ABILITY_UNLOCK = 0xF145F3BE2EFA9A3B,
        IS_SPECIAL_ABILITY_UNLOCKED = 0xC6017F6A6CDFA694,
        IS_SPECIAL_ABILITY_ACTIVE = 0x3E5F7FC85D854E15,
        IS_SPECIAL_ABILITY_METER_FULL = 0x05A1FE504B7F2587,
        ENABLE_SPECIAL_ABILITY = 0x181EC197DAEFE121,
        IS_SPECIAL_ABILITY_ENABLED = 0xB1D200FE26AEF3CB,
        SET_SPECIAL_ABILITY_MULTIPLIER = 0xA49C426ED0CA4AB7,
        UPDATE_PLAYER_TELEPORT = 0xE23D5873C2394C61,
        IS_PLAYER_TELEPORT_ACTIVE = 0x02B15662D7F8886F,
        GET_PLAYER_CURRENT_STEALTH_NOISE = 0x2F395D61F3A1F877,
        _GET_PLAYER_HEALTH_RECHARGE_LIMIT = 0x8BC515BAE4AAF8FF,
        _SET_PLAYER_HEALTH_RECHARGE_LIMIT = 0xC388A0F065F5BC34,
        _SET_PLAYER_FALL_DISTANCE = 0xEFD79FA81DFBA9CB,
        GET_PLAYER_PARACHUTE_PACK_TINT_INDEX = 0x6E9C742F340CE5A2,
        SET_PLAYER_HAS_RESERVE_PARACHUTE = 0x7DDAB28D31FAC363,
        GET_PLAYER_HAS_RESERVE_PARACHUTE = 0x5DDFE2FF727F3CA3,
        SET_PLAYER_CAN_LEAVE_PARACHUTE_SMOKE_TRAIL = 0xF401B182DBA8AF53,
        SET_PLAYER_PARACHUTE_SMOKE_TRAIL_COLOR = 0x8217FD371A4625CF,
        GET_PLAYER_PARACHUTE_SMOKE_TRAIL_COLOR = 0xEF56DBABD3CD4887,
        SET_PLAYER_NOISE_MULTIPLIER = 0xDB89EF50FF25FCE9,
        CAN_PED_HEAR_PLAYER = 0xF297383AA91DCA29,
        RESET_PLAYER_INPUT_GAIT = 0x19531C47A2ABD691,
        SET_AUTO_GIVE_PARACHUTE_WHEN_ENTER_PLANE = 0x9F343285A00B4BB6,
        SET_AUTO_GIVE_SCUBA_GEAR_WHEN_EXIT_VEHICLE = 0xD2B315B6689D537D,
        SET_PLAYER_STEALTH_PERCEPTION_MODIFIER = 0x4E9021C1FCDD507A,
        SET_PLAYER_SIMULATE_AIMING = 0xC54C95DA968EC5B5,
        SET_PLAYER_CLOTH_PIN_FRAMES = 0x749FADDF97DFE930,
        HAS_PLAYER_BEEN_SPOTTED_IN_STOLEN_VEHICLE = 0xD705740BB0A1CF4C,
        RESET_WORLD_BOUNDARY_FOR_PLAYER = 0xDA1DF03D5A315F4E,
        HAS_PLAYER_LEFT_THE_WORLD = 0xD55DDFB47991A294,
        SET_PLAYER_LEAVE_PED_BEHIND = 0xFF300C7649724A0B,
        CLEAR_PLAYER_PARACHUTE_VARIATION_OVERRIDE = 0x0F4CC924CF8C7B21,
        SET_PLAYER_PARACHUTE_MODEL_OVERRIDE = 0x977DB4641F6FC3DB,
        _SET_PLAYER_RESERVE_PARACHUTE_MODEL_OVERRIDE = 0x0764486AEDE748DB,
        _GET_PLAYER_PARACHUTE_MODEL_OVERRIDE = 0xC219887CA3E65C41,
        _GET_PLAYER_RESERVE_PARACHUTE_MODEL_OVERRIDE = 0x37FAAA68DCA9D08D,
        CLEAR_PLAYER_PARACHUTE_MODEL_OVERRIDE = 0x8753997EB5F6EE3F,
        _CLEAR_PLAYER_RESERVE_PARACHUTE_MODEL_OVERRIDE = 0x290D248E25815AE8,
        SET_PLAYER_PARACHUTE_PACK_MODEL_OVERRIDE = 0xDC80A4C2F18A2B64,
        CLEAR_PLAYER_PARACHUTE_PACK_MODEL_OVERRIDE = 0x10C54E4389C12B42,
        DISABLE_PLAYER_VEHICLE_REWARDS = 0xC142BE3BB9CE125F,
        SET_PLAYER_BLUETOOTH_STATE = 0x5DC40A8869C22141,
        IS_PLAYER_BLUETOOTH_ENABLE = 0x65FAEE425DE637B0,
        GET_PLAYER_FAKE_WANTED_LEVEL = 0x56105E599CAB0EFA,
        _SET_PLAYER_HOMING_ROCKET_DISABLED = 0xEE4EBDD2593BA844,
        _0x7E07C78925D5FD96 = 0x7E07C78925D5FD96,
        _0xDE45D1A1EF45EE61 = 0xDE45D1A1EF45EE61,
        _0xFAC75988A7D078D3 = 0xFAC75988A7D078D3,
        _0x823EC8E82BA45986 = 0x823EC8E82BA45986,
        _0x2F41A3BAE005E5FA = 0x2F41A3BAE005E5FA,
        _0x36F1B38855F2A8DF = 0x36F1B38855F2A8DF,
        _0xFFEE8FA29AB9A18E = 0xFFEE8FA29AB9A18E,
        _0xD821056B9ACF8052 = 0xD821056B9ACF8052,
        _0x31E90B8873A4CD3B = 0x31E90B8873A4CD3B,
        _0x9EDD76E87D5D51BA = 0x9EDD76E87D5D51BA,
        _0x55FCC0C390620314 = 0x55FCC0C390620314,
        _0x2382AB11450AE7BA = 0x2382AB11450AE7BA,
        _0x6E4361FF3E8CD7CA = 0x6E4361FF3E8CD7CA,
        _0x7BAE68775557AE0B = 0x7BAE68775557AE0B,
    }
}