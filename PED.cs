using System;
namespace Hotstar
{
    public enum PED : ulong
    { 
        /// <summary>
        /// https://alloc8or.re/gta5/doc/enums/ePedType.txt
        /// 
        /// Full list of peds by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/peds.json
        ///
        /// > int pedType
        /// > Hash modelHash
        /// > float x
        /// > float y
        /// > float z
        /// > float heading
        /// > BOOL isNetwork
        /// > BOOL bScriptHostPed
        ///
        /// </summary>
        CREATE_PED = 0xD49F9B0955C367DE,
        /// <summary>
        /// Deletes the specified ped, then sets the handle pointed to by the pointer to NULL.
        ///
        /// > Ped* ped
        ///
        /// </summary>
        DELETE_PED = 0x9614299DCB53E54B,
        /// <summary>
        /// Copies ped's components and props to targetPed.
        ///
        /// > Ped ped
        /// > Ped targetPed
        ///
        /// </summary>
        CLONE_PED_TO_TARGET = 0xE952D6431689AD9A,
        /// <summary>
        /// Gets a value indicating whether the specified ped is in the specified vehicle.
        /// 
        /// If 'atGetIn' is false, the function will not return true until the ped is sitting in the vehicle and is about to close the door. If it's true, the function returns true the moment the ped starts to get onto the seat (after opening the door). Eg. if false, and the ped is getting into a submersible, the function will not return true until the ped has descended down into the submersible and gotten into the seat, while if it's true, it'll return true the moment the hatch has been opened and the ped is about to descend into the submersible.
        ///
        /// > Ped ped
        /// > Vehicle vehicle
        /// > BOOL atGetIn
        ///
        /// </summary>
        IS_PED_IN_VEHICLE = 0xA3EE4A07279BB9DB,
        /// <summary>
        /// Gets a value indicating whether the specified ped is in any vehicle.
        /// 
        /// If 'atGetIn' is false, the function will not return true until the ped is sitting in the vehicle and is about to close the door. If it's true, the function returns true the moment the ped starts to get onto the seat (after opening the door). Eg. if false, and the ped is getting into a submersible, the function will not return true until the ped has descended down into the submersible and gotten into the seat, while if it's true, it'll return true the moment the hatch has been opened and the ped is about to descend into the submersible.
        ///
        /// > Ped ped
        /// > BOOL atGetIn
        ///
        /// </summary>
        IS_PED_IN_ANY_VEHICLE = 0x997ABD671D25CA0B,
        /// <summary>
        /// xyz - relative to the world origin.
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        ///
        /// </summary>
        IS_COP_PED_IN_AREA_3D = 0x16EC4839969F9F5E,
        /// <summary>
        /// Gets a value indicating whether this ped's health is below its injured threshold.
        /// 
        /// The default threshold is 100.
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_INJURED = 0x84A2DD9AC37C35C1,
        /// <summary>
        /// Returns whether the specified ped is hurt.
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_HURT = 0x5983BB449D7FDB12,
        /// <summary>
        /// Gets a value indicating whether this ped's health is below its fatally injured threshold. The default threshold is 100.
        /// If the handle is invalid, the function returns true.
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_FATALLY_INJURED = 0xD839450756ED5A80,
        /// <summary>
        /// Seems to consistently return true if the ped is dead.
        /// 
        /// p1 is always passed 1 in the scripts.
        /// 
        /// I suggest to remove "OR_DYING" part, because it does not detect dying phase.
        /// 
        /// That's what the devs call it, cry about it.
        /// 
        /// lol
        ///
        /// > Ped ped
        /// > BOOL p1
        ///
        /// </summary>
        IS_PED_DEAD_OR_DYING = 0x3317DEDB88C95038,
        /// <summary>
        /// Returns whether the specified ped is reloading.
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_RELOADING = 0x24B100C68C645951,
        /// <summary>
        /// Returns true if the given ped has a valid pointer to CPlayerInfo in its CPed class. That's all.
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_A_PLAYER = 0x12534C348C6CB68B,
        /// <summary>
        /// pedType: see CREATE_PED
        /// 
        /// Full list of peds by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/peds.json
        ///
        /// > Vehicle vehicle
        /// > int pedType
        /// > Hash modelHash
        /// > int seat
        /// > BOOL isNetwork
        /// > BOOL bScriptHostPed
        ///
        /// </summary>
        CREATE_PED_INSIDE_VEHICLE = 0x7DD959874C1FD534,
        /// <summary>
        /// angle is ped's view cone
        ///
        /// > Ped ped
        /// > Ped otherPed
        /// > float angle
        ///
        /// </summary>
        IS_PED_FACING_PED = 0xD71649DB0A545AA3,
        /// <summary>
        /// Notes: The function only returns true while the ped is: 
        /// A.) Swinging a random melee attack (including pistol-whipping)
        /// 
        /// B.) Reacting to being hit by a melee attack (including pistol-whipping)
        /// 
        /// C.) Is locked-on to an enemy (arms up, strafing/skipping in the default fighting-stance, ready to dodge+counter). 
        /// 
        /// You don't have to be holding the melee-targetting button to be in this stance; you stay in it by default for a few seconds after swinging at someone. If you do a sprinting punch, it returns true for the duration of the punch animation and then returns false again, even if you've punched and made-angry many peds
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_IN_MELEE_COMBAT = 0x4E209B2C1EAD5159,
        /// <summary>
        /// Returns true if the ped doesn't do any movement. If the ped is being pushed forwards by using APPLY_FORCE_TO_ENTITY for example, the function returns false.
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_STOPPED = 0x530944F6F4B8A214,
        /// <summary>
        /// Returns whether the specified ped is shooting.
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_SHOOTING = 0x34616828CD07F1A1,
        /// <summary>
        /// accuracy = 0-100, 100 being perfectly accurate
        ///
        /// > Ped ped
        /// > int accuracy
        ///
        /// </summary>
        SET_PED_ACCURACY = 0x7AEFB85C1D49DEB6,
        /// <summary>
        /// Forces the ped to fall back and kills it.
        /// 
        /// It doesn't really explode the ped's head but it kills the ped
        ///
        /// > Ped ped
        /// > Hash weaponHash
        ///
        /// </summary>
        EXPLODE_PED_HEAD = 0x2D05CED3A38D0F3A,
        /// <summary>
        /// Judging purely from a quick disassembly, if the ped is in a vehicle, the ped will be deleted immediately. If not, it'll be marked as no longer needed. - very elegant..
        ///
        /// > Ped* ped
        ///
        /// </summary>
        REMOVE_PED_ELEGANTLY = 0xAC6D445B994DF95E,
        /// <summary>
        /// Same as SET_PED_ARMOUR, but ADDS 'amount' to the armor the Ped already has.
        ///
        /// > Ped ped
        /// > int amount
        ///
        /// </summary>
        ADD_ARMOUR_TO_PED = 0x5BA652A0CD14DF2F,
        /// <summary>
        /// Sets the armor of the specified ped.
        /// 
        /// ped: The Ped to set the armor of.
        /// amount: A value between 0 and 100 indicating the value to set the Ped's armor to.
        ///
        /// > Ped ped
        /// > int amount
        ///
        /// </summary>
        SET_PED_ARMOUR = 0xCEA04D83135264CC,
        /// <summary>
        /// Ped: The ped to warp.
        /// vehicle: The vehicle to warp the ped into.
        /// Seat_Index: [-1 is driver seat, -2 first free passenger seat]
        /// 
        /// Moreinfo of Seat Index
        /// DriverSeat = -1
        /// Passenger = 0
        /// Left Rear = 1
        /// RightRear = 2
        ///
        /// > Ped ped
        /// > Vehicle vehicle
        /// > int seatIndex
        ///
        /// </summary>
        SET_PED_INTO_VEHICLE = 0xF75B0D629E1C063D,
        /// <summary>
        /// vb.net
        /// Dim ped_handle As Integer
        ///                     With Game.Player.Character
        ///                         Dim pos As Vector3 = .Position + .ForwardVector * 3
        ///                         ped_handle = Native.Function.Call(Of Integer)(Hash.CREATE_RANDOM_PED, pos.X, pos.Y, pos.Z)
        ///                     End With
        /// 
        /// Creates a Ped at the specified location, returns the Ped Handle.  
        /// Ped will not act until SET_PED_AS_NO_LONGER_NEEDED is called.
        ///
        /// > float posX
        /// > float posY
        /// > float posZ
        ///
        /// </summary>
        CREATE_RANDOM_PED = 0xB4AC7D0CF06BFE8F,
        /// <summary>
        /// Returns true/false if the ped is/isn't male.
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_MALE = 0x6D9F5FAA7488BA46,
        /// <summary>
        /// Returns true/false if the ped is/isn't humanoid.
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_HUMAN = 0xB980061DA992779D,
        /// <summary>
        /// Gets the vehicle the specified Ped is in. Returns 0 if the ped is/was not in a vehicle.
        /// If the Ped is not in a vehicle and includeLastVehicle is true, the vehicle they were last in is returned.
        ///
        /// > Ped ped
        /// > BOOL includeLastVehicle
        ///
        /// </summary>
        GET_VEHICLE_PED_IS_IN = 0x9A9112A0FE9A4713,
        /// <summary>
        /// Resets the value for the last vehicle driven by the Ped.
        ///
        /// > Ped ped
        ///
        /// </summary>
        RESET_PED_LAST_VEHICLE = 0xBB8DE8CF6A8DD8BB,
        /// <summary>
        /// The distance between these points, is the diagonal of a box (remember it's 3D).
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        ///
        /// </summary>
        SET_PED_NON_CREATION_AREA = 0xEE01041D559983EA,
        /// <summary>
        /// Same function call as PED::GET_MOUNT, aka just returns 0
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_ON_MOUNT = 0x460BC76A0E10655E,
        /// <summary>
        /// 
        /// Function just returns 0
        /// void __fastcall ped__get_mount(NativeContext *a1)
        /// {
        ///   NativeContext *v1; // rbx@1
        /// 
        ///   v1 = a1;
        ///   GetAddressOfPedFromScriptHandle(a1->Args->Arg1);
        ///   v1->Returns->Item1= 0;
        /// }
        ///
        /// > Ped ped
        ///
        /// </summary>
        GET_MOUNT = 0xE7E11B8DCBED1058,
        /// <summary>
        /// Gets a value indicating whether the specified ped is on top of any vehicle.
        /// 
        /// Return 1 when ped is on vehicle.
        /// Return 0 when ped is not on a vehicle.
        /// 
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_ON_VEHICLE = 0x67722AEB798E5FAB,
        /// <summary>
        /// Maximum possible amount of money on MP is 2000. ~JX
        /// 
        /// -----------------------------------------------------------------------------
        /// 
        /// Maximum amount that a ped can theoretically have is 65535 (0xFFFF) since the amount is stored as an unsigned short (uint16_t) value.
        ///
        /// > Ped ped
        /// > int amount
        ///
        /// </summary>
        SET_PED_MONEY = 0xA9C8960E8684C1B5,
        /// <summary>
        /// Ped no longer takes critical damage modifiers if set to FALSE.
        /// Example: Headshotting a player no longer one shots them. Instead they will take the same damage as a torso shot.
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        SET_PED_SUFFERS_CRITICAL_HITS = 0xEBD76F2359F190AC,
        /// <summary>
        /// Detect if ped is sitting in the specified vehicle
        /// [True/False]
        ///
        /// > Ped ped
        /// > Vehicle vehicle
        ///
        /// </summary>
        IS_PED_SITTING_IN_VEHICLE = 0xA808AA1D79230FC2,
        /// <summary>
        /// Detect if ped is in any vehicle
        /// [True/False]
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_SITTING_IN_ANY_VEHICLE = 0x826AA586EDB9FEF8,
        /// <summary>
        /// IS_PED_*
        /// 
        /// Returns true if the ped is currently opening a door (CTaskOpenDoor).
        ///
        /// > Ped ped
        ///
        /// </summary>
        _IS_PED_OPENING_A_DOOR = 0x26AF0E8E30BD2A2C,
        /// <summary>
        /// Returns:
        /// 
        /// -1: Normal
        /// 0: Wearing parachute on back
        /// 1: Parachute opening
        /// 2: Parachute open
        /// 3: Falling to doom (e.g. after exiting parachute)
        /// 
        /// Normal means no parachute?
        ///
        /// > Ped ped
        ///
        /// </summary>
        GET_PED_PARACHUTE_STATE = 0x79CFD9827CC979B6,
        /// <summary>
        /// -1: no landing
        /// 0: landing on both feet
        /// 1: stumbling
        /// 2: rolling
        /// 3: ragdoll
        ///
        /// > Ped ped
        ///
        /// </summary>
        GET_PED_PARACHUTE_LANDING_TYPE = 0x8B9F1FC6AE8166C0,
        /// <summary>
        /// This is the SET_CHAR_DUCKING from GTA IV, that makes Peds duck. This function does nothing in GTA V. It cannot set the ped as ducking in vehicles, and IS_PED_DUCKING will always return false.
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        SET_PED_DUCKING = 0x030983CA930B692D,
        /// <summary>
        /// This native refers to the field of vision the ped has below them, starting at 0 degrees. The angle value should be negative.
        /// -90f should let the ped see 90 degrees below them, for example.
        ///
        /// > Ped ped
        /// > float angle
        ///
        /// </summary>
        SET_PED_VISUAL_FIELD_MIN_ELEVATION_ANGLE = 0x7A276EB2C224D70F,
        /// <summary>
        /// This native refers to the field of vision the ped has above them, starting at 0 degrees. 90f would let the ped see enemies directly above of them.
        ///
        /// > Ped ped
        /// > float angle
        ///
        /// </summary>
        SET_PED_VISUAL_FIELD_MAX_ELEVATION_ANGLE = 0x78D0B67629D75856,
        /// <summary>
        /// p1 is usually 0 in the scripts. action is either 0 or a pointer to "DEFAULT_ACTION".
        ///
        /// > Ped ped
        /// > BOOL p1
        /// > const char* action
        ///
        /// </summary>
        SET_PED_STEALTH_MOVEMENT = 0x88CBB5CEB96B7BD2,
        /// <summary>
        /// Returns whether the entity is in stealth mode
        ///
        /// > Ped ped
        ///
        /// </summary>
        GET_PED_STEALTH_MOVEMENT = 0x7C2AC9CA66575FBF,
        /// <summary>
        /// Creates a new ped group.
        /// Groups can contain up to 8 peds.
        /// 
        /// The parameter is unused.
        /// 
        /// Returns a handle to the created group, or 0 if a group couldn't be created.
        ///
        /// > int unused
        ///
        /// </summary>
        CREATE_GROUP = 0x90370EBE0FEE1A3D,
        /// <summary>
        /// This only will teleport the ped to the group leader if the group leader teleports (sets coords).
        /// 
        /// Only works in singleplayer
        ///
        /// > Ped pedHandle
        /// > int groupHandle
        /// > BOOL toggle
        ///
        /// </summary>
        SET_PED_CAN_TELEPORT_TO_GROUP_LEADER = 0x2E2F4240B3F24647,
        /// <summary>
        /// Sets the range at which members will automatically leave the group.
        ///
        /// > int groupHandle
        /// > float separationRange
        ///
        /// </summary>
        SET_GROUP_SEPARATION_RANGE = 0x4102C7858CFEE4E4,
        /// <summary>
        /// Ped will stay on the ground after being stunned for at lest ms time. (in milliseconds)
        ///
        /// > Ped ped
        /// > int ms
        ///
        /// </summary>
        SET_PED_MIN_GROUND_TIME_FOR_STUNGUN = 0xFA0675AB151073FA,
        /// <summary>
        /// Checks to see if ped and target are in combat with eachother. Only goes one-way: if target is engaged in combat with ped but ped has not yet reacted, the function will return false until ped starts fighting back.
        /// 
        /// p1 is usually 0 in the scripts because it gets the ped id during the task sequence. For instance: PED::IS_PED_IN_COMBAT(l_42E[4/*14*/], PLAYER::PLAYER_PED_ID()) // armenian2.ct4: 43794
        ///
        /// > Ped ped
        /// > Ped target
        ///
        /// </summary>
        IS_PED_IN_COMBAT = 0x4859F1FC66A6278E,
        /// <summary>
        /// p1 is always 0
        ///
        /// > Ped ped
        /// > int p1
        ///
        /// </summary>
        IS_PED_BEING_STUNNED = 0x4FBACCE3B4138EE8,
        /// <summary>
        /// p1 is nearly always 0 in the scripts. 
        ///
        /// > Ped ped
        /// > BOOL exceptUseWeapon
        ///
        /// </summary>
        IS_PED_IN_COVER = 0x60DFD0691A170B88,
        /// <summary>
        /// i could be time. Only example in the decompiled scripts uses it as -1.
        ///
        /// > Ped ped
        /// > BOOL pinned
        /// > int i
        ///
        /// </summary>
        SET_PED_PINNED_DOWN = 0xAAD6D1ACF08F4612,
        /// <summary>
        /// Returns the Entity (Ped, Vehicle, or ?Object?) that killed the 'ped'
        /// 
        /// Is best to check if the Ped is dead before asking for its killer.
        ///
        /// > Ped ped
        ///
        /// </summary>
        GET_PED_SOURCE_OF_DEATH = 0x93C8B64DEB84728C,
        /// <summary>
        /// Returns the hash of the weapon/model/object that killed the ped.
        ///
        /// > Ped ped
        ///
        /// </summary>
        GET_PED_CAUSE_OF_DEATH = 0x16FFE42AB2D2DC59,
        /// <summary>
        /// Sets the relationship between two groups. This should be called twice (once for each group).
        /// 
        /// Relationship types:
        /// 0 = Companion
        /// 1 = Respect
        /// 2 = Like
        /// 3 = Neutral
        /// 4 = Dislike
        /// 5 = Hate
        /// 255 = Pedestrians
        /// 
        /// Example:
        /// PED::SET_RELATIONSHIP_BETWEEN_GROUPS(2, l_1017, 0xA49E591C);
        /// PED::SET_RELATIONSHIP_BETWEEN_GROUPS(2, 0xA49E591C, l_1017);
        ///
        /// > int relationship
        /// > Hash group1
        /// > Hash group2
        ///
        /// </summary>
        SET_RELATIONSHIP_BETWEEN_GROUPS = 0xBF25EB89375A37AD,
        /// <summary>
        /// Clears the relationship between two groups. This should be called twice (once for each group).
        /// 
        /// Relationship types:
        /// 0 = Companion
        /// 1 = Respect
        /// 2 = Like
        /// 3 = Neutral
        /// 4 = Dislike
        /// 5 = Hate
        /// 255 = Pedestrians
        /// (Credits: Inco)
        /// 
        /// Example:
        /// PED::CLEAR_RELATIONSHIP_BETWEEN_GROUPS(2, l_1017, 0xA49E591C);
        /// PED::CLEAR_RELATIONSHIP_BETWEEN_GROUPS(2, 0xA49E591C, l_1017);
        ///
        /// > int relationship
        /// > Hash group1
        /// > Hash group2
        ///
        /// </summary>
        CLEAR_RELATIONSHIP_BETWEEN_GROUPS = 0x5E29243FB56FC6D4,
        /// <summary>
        /// Can't select void. This function returns nothing. The hash of the created relationship group is output in the second parameter.
        ///
        /// > const char* name
        /// > Hash* groupHash
        ///
        /// </summary>
        ADD_RELATIONSHIP_GROUP = 0xF372BC22FCB88606,
        /// <summary>
        /// Gets the relationship between two peds. This should be called twice (once for each ped).
        /// 
        /// Relationship types:
        /// 0 = Companion
        /// 1 = Respect
        /// 2 = Like
        /// 3 = Neutral
        /// 4 = Dislike
        /// 5 = Hate
        /// 255 = Pedestrians
        /// (Credits: Inco)
        /// 
        /// Example:
        /// PED::GET_RELATIONSHIP_BETWEEN_PEDS(2, l_1017, 0xA49E591C);
        /// PED::GET_RELATIONSHIP_BETWEEN_PEDS(2, 0xA49E591C, l_1017);
        ///
        /// > Ped ped1
        /// > Ped ped2
        ///
        /// </summary>
        GET_RELATIONSHIP_BETWEEN_PEDS = 0xEBA5AD3A0EAF7121,
        /// <summary>
        /// Gets the relationship between two groups. This should be called twice (once for each group).
        /// 
        /// Relationship types:
        /// 0 = Companion
        /// 1 = Respect
        /// 2 = Like
        /// 3 = Neutral
        /// 4 = Dislike
        /// 5 = Hate
        /// 255 = Pedestrians
        /// 
        /// Example:
        /// PED::GET_RELATIONSHIP_BETWEEN_GROUPS(l_1017, 0xA49E591C);
        /// PED::GET_RELATIONSHIP_BETWEEN_GROUPS(0xA49E591C, l_1017);
        ///
        /// > Hash group1
        /// > Hash group2
        ///
        /// </summary>
        GET_RELATIONSHIP_BETWEEN_GROUPS = 0x9E6B70061662AE5C,
        /// <summary>
        /// FIRING_PATTERN_BURST_FIRE = 0xD6FF6D61 ( 1073727030 )
        /// FIRING_PATTERN_BURST_FIRE_IN_COVER = 0x026321F1 ( 40051185 )
        /// FIRING_PATTERN_BURST_FIRE_DRIVEBY = 0xD31265F2 ( -753768974 )
        /// FIRING_PATTERN_FROM_GROUND = 0x2264E5D6 ( 577037782 )
        /// FIRING_PATTERN_DELAY_FIRE_BY_ONE_SEC = 0x7A845691 ( 2055493265 )
        /// FIRING_PATTERN_FULL_AUTO = 0xC6EE6B4C ( -957453492 )
        /// FIRING_PATTERN_SINGLE_SHOT = 0x5D60E4E0 ( 1566631136 )
        /// FIRING_PATTERN_BURST_FIRE_PISTOL = 0xA018DB8A ( -1608983670 )
        /// FIRING_PATTERN_BURST_FIRE_SMG = 0xD10DADEE ( 1863348768 )
        /// FIRING_PATTERN_BURST_FIRE_RIFLE = 0x9C74B406 ( -1670073338 )
        /// FIRING_PATTERN_BURST_FIRE_MG = 0xB573C5B4 ( -1250703948 )
        /// FIRING_PATTERN_BURST_FIRE_PUMPSHOTGUN = 0x00BAC39B ( 12239771 )
        /// FIRING_PATTERN_BURST_FIRE_HELI = 0x914E786F ( -1857128337 )
        /// FIRING_PATTERN_BURST_FIRE_MICRO = 0x42EF03FD ( 1122960381 )
        /// FIRING_PATTERN_SHORT_BURSTS = 0x1A92D7DF ( 445831135 )
        /// FIRING_PATTERN_SLOW_FIRE_TANK = 0xE2CA3A71 ( -490063247 )
        /// 
        /// if anyone is interested firing pattern info: pastebin.com/Px036isB
        ///
        /// > Ped ped
        /// > Hash patternHash
        ///
        /// </summary>
        SET_PED_FIRING_PATTERN = 0x9AC577F5A12AD8A9,
        /// <summary>
        /// shootRate 0-1000
        ///
        /// > Ped ped
        /// > int shootRate
        ///
        /// </summary>
        SET_PED_SHOOT_RATE = 0x614DA022990752DC,
        /// <summary>
        /// combatType can be between 0-14. See GET_COMBAT_FLOAT below for a list of possible parameters.
        ///
        /// > Ped ped
        /// > int combatType
        /// > float p2
        ///
        /// </summary>
        SET_COMBAT_FLOAT = 0xFF41B4B141ED981C,
        /// <summary>
        /// p0: Ped Handle
        /// p1: int i | 0 <= i <= 27
        /// 
        /// p1 probably refers to the attributes configured in combatbehavior.meta. There are 13. Example:
        /// 
        /// <BlindFireChance value="0.1"/>
        /// <WeaponShootRateModifier value="1.0"/>
        /// <TimeBetweenBurstsInCover value="1.25"/>
        /// <BurstDurationInCover value="2.0"/>
        /// <TimeBetweenPeeks value="10.0"/>
        /// <WeaponAccuracy value="0.18"/>
        /// <FightProficiency value="0.8"/>
        /// <StrafeWhenMovingChance value="1.0"/>
        /// <WalkWhenStrafingChance value="0.0"/>
        /// <AttackWindowDistanceForCover value="55.0"/>
        /// <TimeToInvalidateInjuredTarget value="9.0"/>
        /// <TriggerChargeTime_Near value="4.0"/>
        /// <TriggerChargeTime_Far value="10.0"/>
        /// 
        /// -------------Confirmed by editing combatbehavior.meta:
        /// p1:
        /// 0=BlindFireChance
        /// 1=BurstDurationInCover
        /// 3=TimeBetweenBurstsInCover
        /// 4=TimeBetweenPeeks
        /// 5=StrafeWhenMovingChance
        /// 8=WalkWhenStrafingChance
        /// 11=AttackWindowDistanceForCover
        /// 12=TimeToInvalidateInjuredTarget
        /// 16=OptimalCoverDistance
        /// 
        ///
        /// > Ped ped
        /// > int p1
        ///
        /// </summary>
        GET_COMBAT_FLOAT = 0x52DFF8A10508090A,
        /// <summary>
        /// p1 may be a BOOL representing whether or not the group even exists
        ///
        /// > int groupID
        /// > Any* unknown
        /// > int* sizeInMembers
        ///
        /// </summary>
        GET_GROUP_SIZE = 0x8DE69FE35CA09A45,
        /// <summary>
        /// Returns the group id of which the specified ped is a member of.
        ///
        /// > Ped ped
        ///
        /// </summary>
        GET_PED_GROUP_INDEX = 0xF162E133B4E7A675,
        /// <summary>
        /// 0: Default
        /// 1: Circle Around Leader
        /// 2: Alternative Circle Around Leader
        /// 3: Line, with Leader at center
        ///
        /// > int groupId
        /// > int formationType
        ///
        /// </summary>
        SET_GROUP_FORMATION = 0xCE2F5FC3AF7E8C1E,
        /// <summary>
        /// Gets ID of vehicle player using. It means it can get ID at any interaction with vehicle. Enter\exit for example. And that means it is faster than GET_VEHICLE_PED_IS_IN but less safe.
        ///
        /// > Ped ped
        ///
        /// </summary>
        GET_VEHICLE_PED_IS_USING = 0x6094AD011A2EA87D,
        /// <summary>
        /// enable or disable the gravity of a ped
        /// 
        /// Examples:
        /// PED::SET_PED_GRAVITY(PLAYER::PLAYER_PED_ID(), 0x00000001);
        /// PED::SET_PED_GRAVITY(Local_289[iVar0 /*20*/], 0x00000001);
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        SET_PED_GRAVITY = 0x9FF447B6B6AD960A,
        /// <summary>
        /// damages a ped with the given amount
        ///
        /// > Ped ped
        /// > int damageAmount
        /// > BOOL p2
        /// > Any p3
        ///
        /// </summary>
        APPLY_DAMAGE_TO_PED = 0x697157CED63F18D4,
        /// <summary>
        /// GET_TIME_*
        ///
        /// > Ped ped
        /// > Hash weaponHash
        ///
        /// </summary>
        _GET_TIME_OF_LAST_PED_WEAPON_DAMAGE = 0x36B77BB84687C318,
        /// <summary>
        /// https://alloc8or.re/gta5/doc/enums/ePedType.txt
        ///
        /// > Ped ped
        ///
        /// </summary>
        GET_PED_TYPE = 0xFF059E1E4C01E63C,
        /// <summary>
        /// Turns the desired ped into a cop. If you use this on the player ped, you will become almost invisible to cops dispatched for you. You will also report your own crimes, get a generic cop voice, get a cop-vision-cone on the radar, and you will be unable to shoot at other cops. SWAT and Army will still shoot at you. Toggling ped as "false" has no effect; you must change p0's ped model to disable the effect.
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        SET_PED_AS_COP = 0xBB03C38DD3FB7FFD,
        /// <summary>
        /// sets the maximum health of a ped
        /// 
        /// I think it's never been used in any script
        ///
        /// > Ped ped
        /// > int value
        ///
        /// </summary>
        SET_PED_MAX_HEALTH = 0xF5F6378C4F3419D3,
        /// <summary>
        /// seatIndex must be <= 2
        ///
        /// > Ped ped
        /// > Vehicle vehicle
        /// > int seatIndex
        /// > int flags
        /// > Any p4
        ///
        /// </summary>
        SET_PED_VEHICLE_FORCED_SEAT_USAGE = 0x952F06BEECD775CC,
        /// <summary>
        /// state: https://alloc8or.re/gta5/doc/enums/eKnockOffVehicle.txt
        ///
        /// > Ped ped
        /// > int state
        ///
        /// </summary>
        SET_PED_CAN_BE_KNOCKED_OFF_VEHICLE = 0x7A6535691B477C48,
        /// <summary>
        /// from fm_mission_controller.c4 (variable names changed for clarity):
        /// 
        /// int groupID = PLAYER::GET_PLAYER_GROUP(PLAYER::PLAYER_ID());
        /// PED::GET_GROUP_SIZE(group, &unused, &groupSize);
        /// if (groupSize >= 1) {
        /// . . . . for (int memberNumber = 0; memberNumber < groupSize; memberNumber++) {
        /// . . . . . . . . Ped ped1 = PED::GET_PED_AS_GROUP_MEMBER(groupID, memberNumber);
        /// . . . . . . . . //and so on
        ///
        /// > int groupID
        /// > int memberNumber
        ///
        /// </summary>
        GET_PED_AS_GROUP_MEMBER = 0x51455483CF23ED97,
        /// <summary>
        /// teleports ped to coords along with the vehicle ped is in
        ///
        /// > Ped ped
        /// > float posX
        /// > float posY
        /// > float posZ
        ///
        /// </summary>
        SET_PED_COORDS_KEEP_VEHICLE = 0x9AFEFF481A85AB2E,
        /// <summary>
        /// ped can not pull out a weapon when true
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        SET_ENABLE_HANDCUFFS = 0xDF1AF8B5D56542FA,
        /// <summary>
        /// Used with SET_ENABLE_HANDCUFFS in decompiled scripts. From my observations, I have noticed that while being ragdolled you are not able to get up but you can still run. Your legs can also bend.
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        SET_ENABLE_BOUND_ANKLES = 0xC52E0F855C58FC2E,
        /// <summary>
        /// Enables diving motion when underwater.
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        SET_ENABLE_SCUBA = 0xF99F62004024D506,
        /// <summary>
        /// Setting ped to true allows the ped to shoot "friendlies".
        /// 
        /// p2 set to true when toggle is also true seams to make peds permanently unable to aim at, even if you set p2 back to false.
        /// 
        /// p1 = false & p2 = false for unable to aim at.
        /// p1 = true & p2 = false for able to aim at. 
        ///
        /// > Ped ped
        /// > BOOL toggle
        /// > BOOL p2
        ///
        /// </summary>
        SET_CAN_ATTACK_FRIENDLY = 0xB3B1CB349FF9C75D,
        /// <summary>
        /// Returns the ped's alertness (0-3).
        /// 
        /// Values : 
        /// 
        /// 0 : Neutral
        /// 1 : Heard something (gun shot, hit, etc)
        /// 2 : Knows (the origin of the event)
        /// 3 : Fully alerted (is facing the event?)
        /// 
        /// If the Ped does not exist, returns -1.
        ///
        /// > Ped ped
        ///
        /// </summary>
        GET_PED_ALERTNESS = 0xF6AA118530443FD2,
        /// <summary>
        /// value ranges from 0 to 3.
        ///
        /// > Ped ped
        /// > int value
        ///
        /// </summary>
        SET_PED_ALERTNESS = 0xDBA71115ED9941A6,
        /// <summary>
        /// transitionSpeed is the time in seconds it takes to transition from one movement clipset to another.	ransitionSpeed is usually 1.0f
        /// 
        /// List of movement clipsets:
        /// Thanks to elsewhat for list.
        /// 
        ///  "ANIM_GROUP_MOVE_BALLISTIC"
        ///  "ANIM_GROUP_MOVE_LEMAR_ALLEY"
        ///  "clipset@move@trash_fast_turn"
        ///  "FEMALE_FAST_RUNNER"
        ///  "missfbi4prepp1_garbageman"
        ///  "move_characters@franklin@fire"
        ///  "move_characters@Jimmy@slow@"
        ///  "move_characters@michael@fire"
        ///  "move_f@flee@a"
        ///  "move_f@scared"
        ///  "move_f@sexy@a"
        ///  "move_heist_lester"
        ///  "move_injured_generic"
        ///  "move_lester_CaneUp"
        ///  "move_m@bag"
        ///  "MOVE_M@BAIL_BOND_NOT_TAZERED"
        ///  "MOVE_M@BAIL_BOND_TAZERED"
        ///  "move_m@brave"
        ///  "move_m@casual@d"
        ///  "move_m@drunk@moderatedrunk"
        ///  "MOVE_M@DRUNK@MODERATEDRUNK"
        ///  "MOVE_M@DRUNK@MODERATEDRUNK_HEAD_UP"
        ///  "MOVE_M@DRUNK@SLIGHTLYDRUNK"
        ///  "MOVE_M@DRUNK@VERYDRUNK"
        ///  "move_m@fire"
        ///  "move_m@gangster@var_e"
        ///  "move_m@gangster@var_f"
        ///  "move_m@gangster@var_i"
        ///  "move_m@JOG@"
        ///  "MOVE_M@PRISON_GAURD"
        ///  "MOVE_P_M_ONE"
        ///  "MOVE_P_M_ONE_BRIEFCASE"
        ///  "move_p_m_zero_janitor"
        ///  "move_p_m_zero_slow"
        ///  "move_ped_bucket"
        ///  "move_ped_crouched"
        ///  "move_ped_mop"
        ///  "MOVE_M@FEMME@"
        ///  "MOVE_F@FEMME@"
        ///  "MOVE_M@GANGSTER@NG"
        ///  "MOVE_F@GANGSTER@NG"
        ///  "MOVE_M@POSH@"
        ///  "MOVE_F@POSH@"
        ///  "MOVE_M@TOUGH_GUY@"
        ///  "MOVE_F@TOUGH_GUY@"
        /// 
        /// ~ NotCrunchyTaco
        /// 
        /// Full list of movement clipsets by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/movementClipsetsCompact.json
        ///
        /// > Ped ped
        /// > const char* clipSet
        /// > float transitionSpeed
        ///
        /// </summary>
        SET_PED_MOVEMENT_CLIPSET = 0xAF8A94EDE7712BEF,
        /// <summary>
        /// If p1 is 0.0, I believe you are back to normal. 
        /// If p1 is 1.0, it looks like you can only rotate the ped, not walk.
        /// 
        /// Using the following code to reset back to normal
        /// PED::RESET_PED_MOVEMENT_CLIPSET(PLAYER::PLAYER_PED_ID(), 0.0);
        ///
        /// > Ped ped
        /// > float p1
        ///
        /// </summary>
        RESET_PED_MOVEMENT_CLIPSET = 0xAA74EC0CB0AAEA2C,
        /// <summary>
        /// Full list of movement clipsets by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/movementClipsetsCompact.json
        ///
        /// > Ped ped
        /// > const char* clipSet
        ///
        /// </summary>
        SET_PED_STRAFE_CLIPSET = 0x29A28F3F8CF6D854,
        /// <summary>
        /// Found in the b617d scripts:
        /// PED::_9DBA107B4937F809(v_7, "trevor_heist_cover_2h");
        /// 
        /// SET_PED_MO*
        ///
        /// > Ped ped
        /// > const char* p1
        ///
        /// </summary>
        _SET_PED_COVER_CLIPSET_OVERRIDE = 0x9DBA107B4937F809,
        /// <summary>
        /// CLEAR_PED_*
        ///
        /// > Ped ped
        ///
        /// </summary>
        _CLEAR_PED_COVER_CLIPSET_OVERRIDE = 0xC79196DCB36F6121,
        /// <summary>
        /// PED::SET_PED_IN_VEHICLE_CONTEXT(l_128, MISC::GET_HASH_KEY("MINI_PROSTITUTE_LOW_PASSENGER"));
        /// PED::SET_PED_IN_VEHICLE_CONTEXT(l_128, MISC::GET_HASH_KEY("MINI_PROSTITUTE_LOW_RESTRICTED_PASSENGER"));
        /// PED::SET_PED_IN_VEHICLE_CONTEXT(l_3212, MISC::GET_HASH_KEY("MISS_FAMILY1_JIMMY_SIT"));
        /// PED::SET_PED_IN_VEHICLE_CONTEXT(l_3212, MISC::GET_HASH_KEY("MISS_FAMILY1_JIMMY_SIT_REAR"));
        /// PED::SET_PED_IN_VEHICLE_CONTEXT(l_95, MISC::GET_HASH_KEY("MISS_FAMILY2_JIMMY_BICYCLE"));
        /// PED::SET_PED_IN_VEHICLE_CONTEXT(num3, MISC::GET_HASH_KEY("MISSFBI2_MICHAEL_DRIVEBY"));
        /// PED::SET_PED_IN_VEHICLE_CONTEXT(PLAYER::PLAYER_PED_ID(), MISC::GET_HASH_KEY("MISS_ARMENIAN3_FRANKLIN_TENSE"));
        /// PED::SET_PED_IN_VEHICLE_CONTEXT(PLAYER::PLAYER_PED_ID(), MISC::GET_HASH_KEY("MISSFBI5_TREVOR_DRIVING"));
        ///
        /// > Ped ped
        /// > Hash context
        ///
        /// </summary>
        SET_PED_IN_VEHICLE_CONTEXT = 0x530071295899A8C6,
        /// <summary>
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        ///
        /// > Ped ped
        /// > const char* animDict
        /// > const char* anim
        ///
        /// </summary>
        IS_SCRIPTED_SCENARIO_PED_USING_CONDITIONAL_ANIM = 0x6EC47A344923E1ED,
        /// <summary>
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        /// 
        /// Full list of movement clipsets by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/movementClipsetsCompact.json
        ///
        /// > Ped ped
        /// > const char* animDict
        /// > const char* animName
        /// > float p3
        /// > BOOL p4
        ///
        /// </summary>
        SET_PED_ALTERNATE_WALK_ANIM = 0x6C60394CB4F75E9A,
        /// <summary>
        /// stance:
        /// 0 = idle
        /// 1 = walk
        /// 2 = running
        /// 
        /// p5 = usually set to true
        /// 
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        /// 
        /// Full list of movement clipsets by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/movementClipsetsCompact.json
        ///
        /// > Ped ped
        /// > int stance
        /// > const char* animDictionary
        /// > const char* animationName
        /// > float p4
        /// > BOOL p5
        ///
        /// </summary>
        SET_PED_ALTERNATE_MOVEMENT_ANIM = 0x90A43CC281FFAB46,
        /// <summary>
        /// From the scripts:
        /// PED::SET_PED_GESTURE_GROUP(PLAYER::PLAYER_PED_ID(),
        /// "ANIM_GROUP_GESTURE_MISS_FRA0");
        /// PED::SET_PED_GESTURE_GROUP(PLAYER::PLAYER_PED_ID(),
        /// "ANIM_GROUP_GESTURE_MISS_DocksSetup1");
        ///
        /// > Ped ped
        /// > const char* animGroupGesture
        ///
        /// </summary>
        SET_PED_GESTURE_GROUP = 0xDDF803377F94AAA8,
        /// <summary>
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        ///
        /// > const char* animDict
        /// > const char* animName
        /// > float x
        /// > float y
        /// > float z
        /// > float xRot
        /// > float yRot
        /// > float zRot
        /// > float p8
        /// > int p9
        ///
        /// </summary>
        GET_ANIM_INITIAL_OFFSET_POSITION = 0xBE22B26DD764C040,
        /// <summary>
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        ///
        /// > const char* animDict
        /// > const char* animName
        /// > float x
        /// > float y
        /// > float z
        /// > float xRot
        /// > float yRot
        /// > float zRot
        /// > float p8
        /// > int p9
        ///
        /// </summary>
        GET_ANIM_INITIAL_OFFSET_ROTATION = 0x4B805E6046EE9E47,
        /// <summary>
        /// Ids
        /// 0 - Head
        /// 1 - Beard
        /// 2 - Hair
        /// 3 - Torso
        /// 4 - Legs
        /// 5 - Hands
        /// 6 - Foot
        /// 7 - ------
        /// 8 - Accessories 1
        /// 9 - Accessories 2
        /// 10- Decals
        /// 11 - Auxiliary parts for torso
        ///
        /// > Ped ped
        /// > int componentId
        ///
        /// </summary>
        GET_PED_DRAWABLE_VARIATION = 0x67F3780DD425D4FC,
        /// <summary>
        /// List of component/props ID
        /// gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
        ///
        /// > Ped ped
        /// > int componentId
        ///
        /// </summary>
        GET_NUMBER_OF_PED_DRAWABLE_VARIATIONS = 0x27561561732A7842,
        /// <summary>
        /// List of component/props ID
        /// gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
        ///
        /// > Ped ped
        /// > int componentId
        ///
        /// </summary>
        GET_PED_TEXTURE_VARIATION = 0x04A355E041E004E6,
        /// <summary>
        /// List of component/props ID
        /// gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
        ///
        /// > Ped ped
        /// > int componentId
        /// > int drawableId
        ///
        /// </summary>
        GET_NUMBER_OF_PED_TEXTURE_VARIATIONS = 0x8F7156A3142A6BAD,
        /// <summary>
        /// List of component/props ID
        /// gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
        ///
        /// > Ped ped
        /// > int propId
        ///
        /// </summary>
        GET_NUMBER_OF_PED_PROP_DRAWABLE_VARIATIONS = 0x5FAF9754E789FB47,
        /// <summary>
        /// Need to check behavior when drawableId = -1
        /// 
        /// - Doofy.Ass
        /// Why this function doesn't work and return nill value?
        /// GET_NUMBER_OF_PED_PROP_TEXTURE_VARIATIONS(PLAYER.PLAYER_PED_ID(), 0, 5)
        /// 
        /// tick: scripts/addins/menu_execute.lua:51: attempt to call field 'GET_NUMBER_OF_PED_PROP_TEXTURE_VARIATIONS' (a nil value)
        /// 
        /// 
        /// List of component/props ID
        /// gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
        ///
        /// > Ped ped
        /// > int propId
        /// > int drawableId
        ///
        /// </summary>
        GET_NUMBER_OF_PED_PROP_TEXTURE_VARIATIONS = 0xA6E7F1CEB523E171,
        /// <summary>
        /// List of component/props ID
        /// gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
        ///
        /// > Ped ped
        /// > int componentId
        ///
        /// </summary>
        GET_PED_PALETTE_VARIATION = 0xE3DD5F2A84B42281,
        /// <summary>
        /// Checks if the component variation is valid, this works great for randomizing components using loops.
        /// 
        /// List of component/props ID
        /// gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
        /// 
        /// Full list of ped components by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pedComponentVariations.json
        ///
        /// > Ped ped
        /// > int componentId
        /// > int drawableId
        /// > int textureId
        ///
        /// </summary>
        IS_PED_COMPONENT_VARIATION_VALID = 0xE825F6B6CEA7671D,
        /// <summary>
        /// paletteId: 0 to 3.
        /// 
        /// componentId:
        /// enum ePedVarComp
        /// {
        /// 	PV_COMP_INVALID = -1,
        /// 	PV_COMP_HEAD,
        /// 	PV_COMP_BERD,
        /// 	PV_COMP_HAIR,
        /// 	PV_COMP_UPPR,
        /// 	PV_COMP_LOWR,
        /// 	PV_COMP_HAND,
        /// 	PV_COMP_FEET,
        /// 	PV_COMP_TEEF,
        /// 	PV_COMP_ACCS,
        /// 	PV_COMP_TASK,
        /// 	PV_COMP_DECL,
        /// 	PV_COMP_JBIB,
        /// 	PV_COMP_MAX
        /// };
        /// 
        /// Examples: https://gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
        /// 
        /// Full list of ped components by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pedComponentVariations.json
        ///
        /// > Ped ped
        /// > int componentId
        /// > int drawableId
        /// > int textureId
        /// > int paletteId
        ///
        /// </summary>
        SET_PED_COMPONENT_VARIATION = 0x262B14F48D29DE80,
        /// <summary>
        /// p1 is always 0 in R* scripts.
        /// 
        /// List of component/props ID
        /// gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
        ///
        /// > Ped ped
        /// > int p1
        ///
        /// </summary>
        SET_PED_RANDOM_COMPONENT_VARIATION = 0xC8A9481A01E63C28,
        /// <summary>
        /// List of component/props ID
        /// gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
        ///
        /// > Ped ped
        ///
        /// </summary>
        SET_PED_RANDOM_PROPS = 0xC44AA05345C992C6,
        /// <summary>
        /// Sets Ped Default Clothes
        ///
        /// > Ped ped
        ///
        /// </summary>
        SET_PED_DEFAULT_COMPONENT_VARIATION = 0x45EEE61580806D63,
        /// <summary>
        /// The "shape" parameters control the shape of the ped's face. The "skin" parameters control the skin tone. ShapeMix and skinMix control how much the first and second IDs contribute,(typically mother and father.) ThirdMix overrides the others in favor of the third IDs. IsParent is set for "children" of the player character's grandparents during old-gen character creation. It has unknown effect otherwise.
        /// 
        /// The IDs start at zero and go Male Non-DLC, Female Non-DLC, Male DLC, and Female DLC.
        /// 
        /// !!!Can someone add working example for this???
        /// 
        /// try this:
        ///        headBlendData headData;
        ///        GET_PED_HEAD_BLEND_DATA(PLAYER_PED_ID(), &headData);
        /// 
        ///        SET_PED_HEAD_BLEND_DATA(PLAYER_PED_ID(), headData.shapeFirst, headData.shapeSecond, headData.shapeThird, headData.skinFirst, headData.skinSecond
        ///           , headData.skinThird, headData.shapeMix, headData.skinMix, headData.skinThird, 0);
        /// 
        /// 
        /// For more info please refer to this topic. 
        /// gtaforums.com/topic/858970-all-gtao-face-ids-pedset-ped-head-blend-data-explained
        ///
        /// > Ped ped
        /// > int shapeFirstID
        /// > int shapeSecondID
        /// > int shapeThirdID
        /// > int skinFirstID
        /// > int skinSecondID
        /// > int skinThirdID
        /// > float shapeMix
        /// > float skinMix
        /// > float thirdMix
        /// > BOOL isParent
        ///
        /// </summary>
        SET_PED_HEAD_BLEND_DATA = 0x9414E18B9434C2FE,
        /// <summary>
        /// The pointer is to a padded struct that matches the arguments to SET_PED_HEAD_BLEND_DATA(...). There are 4 bytes of padding after each field.
        /// pass this struct in the second parameter 
        /// typedef struct
        /// {
        ///         int shapeFirst, shapeSecond, shapeThird; 
        ///         int skinFirst, skinSecond, skinThird; 
        ///    float shapeMix, skinMix, thirdMix;
        /// } headBlendData;
        ///
        /// > Ped ped
        /// > Any* headBlendData
        ///
        /// </summary>
        GET_PED_HEAD_BLEND_DATA = 0x2746BD9D88C5C5D0,
        /// <summary>
        /// See SET_PED_HEAD_BLEND_DATA().
        ///
        /// > Ped ped
        /// > float shapeMix
        /// > float skinMix
        /// > float thirdMix
        ///
        /// </summary>
        UPDATE_PED_HEAD_BLEND_DATA = 0x723538F61C647C5A,
        /// <summary>
        /// Used for freemode (online) characters.
        /// 
        /// For some reason, the scripts use a rounded float for the index.
        /// Indexes:
        /// 1. black
        /// 2. very light blue/green
        /// 3. dark blue
        /// 4. brown
        /// 5. darker brown
        /// 6. light brown
        /// 7. blue
        /// 8. light blue
        /// 9. pink
        /// 10. yellow
        /// 11. purple
        /// 12. black
        /// 13. dark green
        /// 14. light brown
        /// 15. yellow/black pattern
        /// 16. light colored spiral pattern
        /// 17. shiny red
        /// 18. shiny half blue/half red
        /// 19. half black/half light blue
        /// 20. white/red perimter
        /// 21. green snake
        /// 22. red snake
        /// 23. dark blue snake
        /// 24. dark yellow
        /// 25. bright yellow
        /// 26. all black
        /// 28. red small pupil
        /// 29. devil blue/black
        /// 30. white small pupil
        /// 31. glossed over
        ///
        /// > Ped ped
        /// > int index
        ///
        /// </summary>
        _SET_PED_EYE_COLOR = 0x50B56988B170AFDF,
        /// <summary>
        /// A getter for _SET_PED_EYE_COLOR. Returns -1 if fails to get.
        ///
        /// > Ped ped
        ///
        /// </summary>
        _GET_PED_EYE_COLOR = 0x76BBA2CEE66D47E9,
        /// <summary>
        /// OverlayID ranges from 0 to 12, index from 0 to _GET_NUM_OVERLAY_VALUES(overlayID)-1, and opacity from 0.0 to 1.0. 
        /// 
        /// overlayID       Part                  Index, to disable
        /// 0               Blemishes             0 - 23, 255
        /// 1               Facial Hair           0 - 28, 255
        /// 2               Eyebrows              0 - 33, 255
        /// 3               Ageing                0 - 14, 255
        /// 4               Makeup                0 - 74, 255
        /// 5               Blush                 0 - 6, 255
        /// 6               Complexion            0 - 11, 255
        /// 7               Sun Damage            0 - 10, 255
        /// 8               Lipstick              0 - 9, 255
        /// 9               Moles/Freckles        0 - 17, 255
        /// 10              Chest Hair            0 - 16, 255
        /// 11              Body Blemishes        0 - 11, 255
        /// 12              Add Body Blemishes    0 - 1, 255
        ///
        /// > Ped ped
        /// > int overlayID
        /// > int index
        /// > float opacity
        ///
        /// </summary>
        SET_PED_HEAD_OVERLAY = 0x48F44967FA05CC1E,
        /// <summary>
        /// Likely a char, if that overlay is not set, e.i. "None" option, returns 255;
        /// 
        /// This might be the once removed native GET_PED_HEAD_OVERLAY.
        ///
        /// > Ped ped
        /// > int overlayID
        ///
        /// </summary>
        _GET_PED_HEAD_OVERLAY_VALUE = 0xA60EF3B6461A4D43,
        /// <summary>
        /// Used with freemode (online) characters.
        ///
        /// > int overlayID
        ///
        /// </summary>
        GET_PED_HEAD_OVERLAY_NUM = 0xCF1CE768BB43480E,
        /// <summary>
        /// Used for freemode (online) characters.
        /// 
        /// ColorType is 1 for eyebrows, beards, and chest hair; 2 for blush and lipstick; and 0 otherwise, though not called in those cases.
        /// 
        /// Called after SET_PED_HEAD_OVERLAY().
        ///
        /// > Ped ped
        /// > int overlayID
        /// > int colorType
        /// > int colorID
        /// > int secondColorID
        ///
        /// </summary>
        _SET_PED_HEAD_OVERLAY_COLOR = 0x497BF74A7B9CB952,
        /// <summary>
        /// Used for freemode (online) characters.
        ///
        /// > Ped ped
        /// > int colorID
        /// > int highlightColorID
        ///
        /// </summary>
        _SET_PED_HAIR_COLOR = 0x4CFFC65454C93A49,
        /// <summary>
        /// Used for freemode (online) characters.
        ///
        ///
        /// </summary>
        _GET_NUM_HAIR_COLORS = 0xE5C0CF872C2AD150,
        /// <summary>
        /// Input: Haircolor index, value between 0 and 63 (inclusive).
        /// Output: RGB values for the haircolor specified in the input.
        /// 
        /// This is used with the hair color swatches scaleform.
        /// Use `_0x013E5CFC38CD5387` to get the makeup colors.
        ///
        /// > int hairColorIndex
        /// > int* outR
        /// > int* outG
        /// > int* outB
        ///
        /// </summary>
        _GET_PED_HAIR_RGB_COLOR = 0x4852FC386E2E1BB5,
        /// <summary>
        /// Input: Makeup color index, value between 0 and 63 (inclusive).
        /// Output: RGB values for the makeup color specified in the input.
        /// 
        /// This is used with the makeup color swatches scaleform.
        /// Use `_0x4852FC386E2E1BB5` to get the hair colors.
        ///
        /// > int makeupColorIndex
        /// > int* outR
        /// > int* outG
        /// > int* outB
        ///
        /// </summary>
        _GET_PED_MAKEUP_RGB_COLOR = 0x013E5CFC38CD5387,
        /// <summary>
        /// Sets the various freemode face features, e.g. nose length, chin shape. Scale ranges from -1.0 to 1.0.
        /// 
        /// Index can be 0 - 19
        /// 
        /// SET_PED_M* 
        /// 
        /// Here is the list of names. It starts at 0 and runs in sequence 
        /// 
        /// Face_Feature 
        /// 
        /// Nose_Width
        /// 
        /// Nose_Peak_Hight
        /// 
        /// Nose_Peak_Lenght
        /// 
        /// Nose_Bone_High
        /// 
        /// Nose_Peak_Lowering
        /// 
        /// Nose_Bone_Twist
        /// 
        /// EyeBrown_High
        /// 
        /// EyeBrown_Forward
        /// 
        /// Cheeks_Bone_High
        /// 
        /// Cheeks_Bone_Width 
        /// 
        /// Cheeks_Width
        /// 
        /// Eyes_Openning 
        /// 
        /// Lips_Thickness
        /// 
        /// Jaw_Bone_Width: Bone size to sides 
        /// 
        /// Jaw_Bone_Back_Lenght: Bone size to back 
        /// 
        /// Chimp_Bone_Lowering: Go Down
        /// 
        /// Chimp_Bone_Lenght: Go forward
        /// 
        /// Chimp_Bone_Width
        /// 
        /// Chimp_Hole
        /// 
        /// Neck_Thikness
        ///
        /// > Ped ped
        /// > int index
        /// > float scale
        ///
        /// </summary>
        _SET_PED_FACE_FEATURE = 0x71A5C1DBA060049E,
        /// <summary>
        /// p4 seems to vary from 0 to 3.
        /// Preview: https://gfycat.com/MaleRareAmazonparrot
        ///
        /// > Ped ped
        /// > int r
        /// > int g
        /// > int b
        /// > int id
        ///
        /// </summary>
        SET_HEAD_BLEND_PALETTE_COLOR = 0xCC9682B8951C5229,
        /// <summary>
        /// Type equals 0 for male non-dlc, 1 for female non-dlc, 2 for male dlc, and 3 for female dlc.
        /// 
        /// Used when calling SET_PED_HEAD_BLEND_DATA.
        ///
        /// > int type
        ///
        /// </summary>
        GET_PED_HEAD_BLEND_FIRST_INDEX = 0x68D353AB88B97E0C,
        /// <summary>
        /// Type equals 0 for male non-dlc, 1 for female non-dlc, 2 for male dlc, and 3 for female dlc.
        ///
        /// > int type
        ///
        /// </summary>
        GET_PED_HEAD_BLEND_NUM_HEADS = 0x5EF37013A6539C9D,
        /// <summary>
        /// from extreme3.c4
        /// PED::_39D55A620FCB6A3A(PLAYER::PLAYER_PED_ID(), 8, PED::GET_PED_DRAWABLE_VARIATION(PLAYER::PLAYER_PED_ID(), 8), PED::GET_PED_TEXTURE_VARIATION(PLAYER::PLAYER_PED_ID(), 8));
        /// 
        /// p1 is probably componentId
        ///
        /// > Ped ped
        /// > int slot
        /// > int drawableId
        /// > int textureId
        ///
        /// </summary>
        SET_PED_PRELOAD_VARIATION_DATA = 0x39D55A620FCB6A3A,
        /// <summary>
        /// List of component/props ID
        /// gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
        ///
        /// > Ped ped
        /// > int componentId
        /// > int drawableId
        /// > int TextureId
        ///
        /// </summary>
        SET_PED_PRELOAD_PROP_DATA = 0x2B16A3BFF1FBCE49,
        /// <summary>
        /// List of component/props ID
        /// gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
        ///
        /// > Ped ped
        /// > int componentId
        ///
        /// </summary>
        GET_PED_PROP_INDEX = 0x898CC20EA75BACD8,
        /// <summary>
        /// ComponentId can be set to various things based on what category you're wanting to set
        /// enum PedPropsData
        /// {
        ///     PED_PROP_HATS = 0,
        ///     PED_PROP_GLASSES = 1,
        ///  PED_PROP_EARS = 2,
        ///     PED_PROP_WATCHES = 3,
        /// };
        /// Usage: SET_PED_PROP_INDEX(playerPed, PED_PROP_HATS, GET_NUMBER_OF_PED_PROP_DRAWABLE_VARIATIONS(playerPed, PED_PROP_HATS), GET_NUMBER_OF_PED_PROP_TEXTURE_VARIATIONS(playerPed, PED_PROP_HATS, 0), TRUE);
        /// 
        /// List of component/props ID
        /// gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
        ///
        /// > Ped ped
        /// > int componentId
        /// > int drawableId
        /// > int TextureId
        /// > BOOL attach
        ///
        /// </summary>
        SET_PED_PROP_INDEX = 0x93376B65A266EB5F,
        /// <summary>
        /// List of component/props ID
        /// gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
        ///
        /// > Ped ped
        /// > BOOL p1
        /// > BOOL p2
        /// > BOOL p3
        /// > BOOL p4
        ///
        /// </summary>
        KNOCK_OFF_PED_PROP = 0x6FD7816A36615F48,
        /// <summary>
        /// List of component/props ID
        /// gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
        ///
        /// > Ped ped
        /// > int propId
        ///
        /// </summary>
        CLEAR_PED_PROP = 0x0943E5B8E078E76E,
        /// <summary>
        /// List of component/props ID
        /// gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
        ///
        /// > Ped ped
        ///
        /// </summary>
        CLEAR_ALL_PED_PROPS = 0xCD8A7537A9B52F06,
        /// <summary>
        /// List of component/props ID
        /// gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
        ///
        /// > Ped ped
        /// > int componentId
        ///
        /// </summary>
        GET_PED_PROP_TEXTURE_INDEX = 0xE131A28626F81AB2,
        /// <summary>
        /// This native sets a scuba mask for freemode models and an oxygen bottle for player_* models. It works on freemode and player_* models.
        ///
        /// > Ped ped
        ///
        /// </summary>
        _SET_PED_SCUBA_GEAR_VARIATION = 0x36C6984C3ED0C911,
        /// <summary>
        /// Removes the scubagear (for mp male: component id: 8, drawableId: 123, textureId: any) from peds. Does not play the 'remove scuba gear' animation, but instantly removes it.
        ///
        /// > Ped ped
        ///
        /// </summary>
        CLEAR_PED_SCUBA_GEAR_VARIATION = 0xB50EB4CCB29704AC,
        /// <summary>
        /// works with TASK::TASK_SET_BLOCKING_OF_NON_TEMPORARY_EVENTS to make a ped completely oblivious to all events going on around him
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        SET_BLOCKING_OF_NON_TEMPORARY_EVENTS = 0x9F8AA94D6D97DBF4,
        /// <summary>
        /// PED::REGISTER_TARGET(l_216, PLAYER::PLAYER_PED_ID()); from re_prisonbreak.txt.
        /// 
        /// l_216 = RECSBRobber1
        ///
        /// > Ped ped
        /// > Ped target
        ///
        /// </summary>
        REGISTER_TARGET = 0x2F25D9AEFA34FBA2,
        /// <summary>
        /// Based on TASK_COMBAT_HATED_TARGETS_AROUND_PED, the parameters are likely similar (PedHandle, and area to attack in).
        ///
        /// > Ped ped
        /// > float radius
        ///
        /// </summary>
        REGISTER_HATED_TARGETS_AROUND_PED = 0x9222F300BF8354FE,
        /// <summary>
        /// Gets a random ped in the x/y/zRadius near the x/y/z coordinates passed. 
        /// 
        /// Ped Types:
        /// Any = -1
        /// Player = 1
        /// Male = 4 
        /// Female = 5 
        /// Cop = 6
        /// Human = 26
        /// SWAT = 27 
        /// Animal = 28
        /// Army = 29
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float xRadius
        /// > float yRadius
        /// > float zRadius
        /// > int pedType
        ///
        /// </summary>
        GET_RANDOM_PED_AT_COORD = 0x876046A8E3A4B71C,
        /// <summary>
        /// Gets the closest ped in a radius.
        /// 
        /// Ped Types:
        /// Any ped = -1
        /// Player = 1
        /// Male = 4 
        /// Female = 5 
        /// Cop = 6
        /// Human = 26
        /// SWAT = 27 
        /// Animal = 28
        /// Army = 29
        /// 
        /// ------------------
        /// P4 P5 P7 P8
        /// 1  0  x  x  = return nearest walking Ped
        /// 1  x  0  x  = return nearest walking Ped
        /// x  1  1  x  = return Ped you are using
        /// 0  0  x  x  = no effect
        /// 0  x  0  x  = no effect
        /// 
        /// x = can be 1 or 0. Does not have any obvious changes.
        /// 
        /// This function does not return ped who is:
        /// 1. Standing still
        /// 2. Driving
        /// 3. Fleeing
        /// 4. Attacking
        /// 
        /// This function only work if the ped is:
        /// 1. walking normally.
        /// 2. waiting to cross a road.
        /// 
        /// Note: PED::GET_PED_NEARBY_PEDS works for more peds.
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        /// > BOOL p4
        /// > BOOL p5
        /// > Ped* outPed
        /// > BOOL p7
        /// > BOOL p8
        /// > int pedType
        ///
        /// </summary>
        GET_CLOSEST_PED = 0xC33AB876A77F8164,
        /// <summary>
        /// Sets a value indicating whether scenario peds should be returned by the next call to a command that returns peds. Eg. GET_CLOSEST_PED.
        ///
        /// > BOOL value
        ///
        /// </summary>
        SET_SCENARIO_PEDS_TO_BE_RETURNED_BY_NEXT_COMMAND = 0x14F19A8782C8071E,
        /// <summary>
        /// Scripts use 0.2, 0.5 and 1.0. Value must be >= 0.0 && <= 1.0
        ///
        /// > Ped driver
        /// > float modifier
        ///
        /// </summary>
        SET_DRIVER_RACING_MODIFIER = 0xDED5AF5A0EA4B297,
        /// <summary>
        /// The function specifically verifies the value is equal to, or less than 1.0f. If it is greater than 1.0f, the function does nothing at all.
        ///
        /// > Ped driver
        /// > float ability
        ///
        /// </summary>
        SET_DRIVER_ABILITY = 0xB195FFA8042FC5C3,
        /// <summary>
        /// range 0.0f - 1.0f
        ///
        /// > Ped driver
        /// > float aggressiveness
        ///
        /// </summary>
        SET_DRIVER_AGGRESSIVENESS = 0xA731F608CA104E3C,
        /// <summary>
        /// Prevents the ped from going limp.
        /// 
        /// [Example: Can prevent peds from falling when standing on moving vehicles.]
        ///
        /// > Ped ped
        ///
        /// </summary>
        CAN_PED_RAGDOLL = 0x128F79EDCECE4FD5,
        /// <summary>
        /// p4/p5: Unused in TU27
        /// Ragdoll Types:
        /// **0**: CTaskNMRelax
        /// **1**: CTaskNMScriptControl: Hardcoded not to work in networked environments.
        /// **Else**: CTaskNMBalance
        /// time1- Time(ms) Ped is in ragdoll mode; only applies to ragdoll types 0 and not 1.
        /// 
        /// time2- Unknown time, in milliseconds
        /// 
        /// ragdollType-
        /// 0 : Normal ragdoll
        /// 1 : Falls with stiff legs/body
        /// 2 : Narrow leg stumble(may not fall)
        /// 3 : Wide leg stumble(may not fall)
        /// 
        /// p4, p5, p6- No idea. In R*'s scripts they are usually either "true, true, false" or "false, false, false".
        /// 
        /// 
        /// 
        /// 
        /// EDIT 3/11/16: unclear what 'mircoseconds' mean-- a microsecond is 1000x a ms, so time2 must be 1000x time1?  more testing needed.  -sob
        /// 
        /// Edit Mar 21, 2017: removed part about time2 being the microseconds version of time1. this just isn't correct. time2 is in milliseconds, and time1 and time2 don't seem to be connected in any way.
        ///
        /// > Ped ped
        /// > int time1
        /// > int time2
        /// > int ragdollType
        /// > BOOL p4
        /// > BOOL p5
        /// > BOOL p6
        ///
        /// </summary>
        SET_PED_TO_RAGDOLL = 0xAE99FB955581844A,
        /// <summary>
        /// Return variable is never used in R*'s scripts.
        /// 
        /// Not sure what p2 does. It seems like it would be a time judging by it's usage in R*'s scripts, but didn't seem to affect anything in my testings.
        /// 
        /// x, y, and z are coordinates, most likely to where the ped will fall.
        /// 
        /// p7 is probably the force of the fall, but untested, so I left the variable name the same.
        /// 
        /// p8 to p13 are always 0f in R*'s scripts.
        /// 
        /// (Simplified) Example of the usage of the function from R*'s scripts:
        /// ped::set_ped_to_ragdoll_with_fall(ped, 1500, 2000, 1, -entity::get_entity_forward_vector(ped), 1f, 0f, 0f, 0f, 0f, 0f, 0f);
        /// 
        ///
        /// > Ped ped
        /// > int time
        /// > int p2
        /// > int ragdollType
        /// > float x
        /// > float y
        /// > float z
        /// > float p7
        /// > float p8
        /// > float p9
        /// > float p10
        /// > float p11
        /// > float p12
        /// > float p13
        ///
        /// </summary>
        SET_PED_TO_RAGDOLL_WITH_FALL = 0xD76632D99E4966C8,
        /// <summary>
        /// Causes Ped to ragdoll on collision with any object (e.g Running into trashcan). If applied to player you will sometimes trip on the sidewalk.
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        SET_PED_RAGDOLL_ON_COLLISION = 0xF0A4F1BBF4FA7497,
        /// <summary>
        /// If the ped handle passed through the parenthesis is in a ragdoll state this will return true.
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_RAGDOLL = 0x47E4E977581C5B55,
        /// <summary>
        /// Works for both player and peds, but some flags don't seem to work for the player (1, for example)
        /// 
        /// 1 - Blocks ragdolling when shot.
        /// 2 - Blocks ragdolling when hit by a vehicle. The ped still might play a falling animation.
        /// 4 - Blocks ragdolling when set on fire.
        /// 
        /// -----------------------------------------------------------------------
        /// 
        /// There seem to be 26 flags
        ///
        /// > Ped ped
        /// > int flags
        ///
        /// </summary>
        SET_RAGDOLL_BLOCKING_FLAGS = 0x26695EC767728D84,
        /// <summary>
        /// There seem to be 26 flags
        ///
        /// > Ped ped
        /// > int flags
        ///
        /// </summary>
        CLEAR_RAGDOLL_BLOCKING_FLAGS = 0xD86D101FCFD00A4B,
        /// <summary>
        /// Ped will no longer get angry when you stay near him.
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        REMOVE_PED_DEFENSIVE_AREA = 0x74D4E028107450A9,
        /// <summary>
        /// It will revive/cure the injured ped. The condition is ped must not be dead.
        /// 
        /// Upon setting and converting the health int, found, if health falls below 5, the ped will lay on the ground in pain(Maximum default health is 100).
        /// 
        /// This function is well suited there.
        ///
        /// > Ped ped
        ///
        /// </summary>
        REVIVE_INJURED_PED = 0x8D8ACD8388CD99CE,
        /// <summary>
        /// This function will simply bring the dead person back to life.
        /// 
        /// Try not to use it alone, since using this function alone, will make peds fall through ground in hell(well for the most of the times).
        /// 
        /// Instead, before calling this function, you may want to declare the position, where your Resurrected ped to be spawn at.(For instance, Around 2 floats of Player's current position.) 
        /// 
        /// Also, disabling any assigned task immediately helped in the number of scenarios, where If you want peds to perform certain decided tasks.
        ///
        /// > Ped ped
        ///
        /// </summary>
        RESURRECT_PED = 0x71BC8E838B9C6035,
        /// <summary>
        /// NOTE: Debugging functions are not present in the retail version of the game.
        /// 
        /// *untested but char *name could also be a hash for a localized string
        ///
        /// > Ped ped
        /// > const char* name
        ///
        /// </summary>
        SET_PED_NAME_DEBUG = 0x98EFA132A4117BE1,
        /// <summary>
        /// Gets the offset the specified ped has moved since the previous tick.
        /// 
        /// If worldSpace is false, the returned offset is relative to the ped. That is, if the ped has moved 1 meter right and 5 meters forward, it'll return 1,5,0.
        /// 
        /// If worldSpace is true, the returned offset is relative to the world. That is, if the ped has moved 1 meter on the X axis and 5 meters on the Y axis, it'll return 1,5,0.
        ///
        /// > Ped ped
        /// > BOOL worldSpace
        ///
        /// </summary>
        GET_PED_EXTRACTED_DISPLACEMENT = 0xE0AF41401ADF87E3,
        /// <summary>
        /// woundTypes:
        /// - soak_splat
        /// - wound_sheet
        /// - BulletSmall
        /// - BulletLarge
        /// - ShotgunSmall
        /// - ShotgunSmallMonolithic
        /// - ShotgunLarge
        /// - ShotgunLargeMonolithic
        /// - NonFatalHeadshot
        /// - stab
        /// - BasicSlash
        /// - Scripted_Ped_Splash_Back
        /// - BackSplash
        ///
        /// > Ped ped
        /// > int boneIndex
        /// > float xRot
        /// > float yRot
        /// > float zRot
        /// > const char* woundType
        ///
        /// </summary>
        APPLY_PED_BLOOD = 0x83F7E01C7B769A26,
        /// <summary>
        /// enum eDamageZone
        /// {
        /// 	DZ_Torso = 0,
        /// 	DZ_Head,
        /// 	DZ_LeftArm,
        /// 	DZ_RightArm,
        /// 	DZ_LeftLeg,
        /// 	DZ_RightLeg,
        /// };
        /// 
        /// Decal Names:
        /// scar
        /// blushing
        /// cs_flush_anger
        /// cs_flush_anger_face
        /// bruise
        /// bruise_large
        /// herpes
        /// ArmorBullet
        /// basic_dirt_cloth
        /// basic_dirt_skin
        /// cs_trev1_dirt
        /// 
        /// APPLY_PED_DAMAGE_DECAL(ped, 1, 0.5f, 0.513f, 0f, 1f, unk, 0, 0, "blushing");
        ///
        /// > Ped ped
        /// > int damageZone
        /// > float xOffset
        /// > float yOffset
        /// > float heading
        /// > float scale
        /// > float alpha
        /// > int variation
        /// > BOOL fadeIn
        /// > const char* decalName
        ///
        /// </summary>
        APPLY_PED_DAMAGE_DECAL = 0x397C38AA7B4A5F83,
        /// <summary>
        /// Damage Packs:
        /// 
        /// "SCR_TrevorTreeBang"
        /// "HOSPITAL_0"
        /// "HOSPITAL_1"
        /// "HOSPITAL_2"
        /// "HOSPITAL_3"
        /// "HOSPITAL_4"
        /// "HOSPITAL_5"
        /// "HOSPITAL_6"
        /// "HOSPITAL_7"
        /// "HOSPITAL_8"
        /// "HOSPITAL_9"
        /// "SCR_Dumpster"
        /// "BigHitByVehicle"
        /// "SCR_Finale_Michael_Face"
        /// "SCR_Franklin_finb"
        /// "SCR_Finale_Michael"
        /// "SCR_Franklin_finb2"
        /// "Explosion_Med"
        /// "SCR_Torture"
        /// "SCR_TracySplash"
        /// "Skin_Melee_0"
        /// 
        /// Additional damage packs:
        /// 
        /// gist.github.com/alexguirre/f3f47f75ddcf617f416f3c8a55ae2227
        ///
        /// > Ped ped
        /// > const char* damagePack
        /// > float damage
        /// > float mult
        ///
        /// </summary>
        APPLY_PED_DAMAGE_PACK = 0x46DF918788CB093F,
        /// <summary>
        /// Somehow related to changing ped's clothes.
        ///
        /// > Ped ped
        /// > int p1
        ///
        /// </summary>
        CLEAR_PED_BLOOD_DAMAGE_BY_ZONE = 0x56E3B78C5408D9F4,
        /// <summary>
        /// p1: from 0 to 5 in the b617d scripts.
        /// p2: "blushing" and "ALL" found in the b617d scripts.
        ///
        /// > Ped ped
        /// > int p1
        /// > const char* p2
        ///
        /// </summary>
        CLEAR_PED_DAMAGE_DECAL_BY_ZONE = 0x523C79AEEFCC4A2A,
        /// <summary>
        /// It clears the wetness of the selected Ped/Player. Clothes have to be wet to notice the difference.
        ///
        /// > Ped ped
        ///
        /// </summary>
        CLEAR_PED_WETNESS = 0x9C720776DAA43E7E,
        /// <summary>
        /// It adds the wetness level to the player clothing/outfit. As if player just got out from water surface.
        /// 
        /// 
        ///
        /// > Ped ped
        /// > float height
        ///
        /// </summary>
        SET_PED_WETNESS_HEIGHT = 0x44CB6447D2571AA0,
        /// <summary>
        /// combined with PED::SET_PED_WETNESS_HEIGHT(), this native makes the ped drenched in water up to the height specified in the other function
        ///
        /// > Ped ped
        ///
        /// </summary>
        SET_PED_WETNESS_ENABLED_THIS_FRAME = 0xB5485E4907B53019,
        /// <summary>
        /// Sweat is set to 100.0 or 0.0 in the decompiled scripts.
        ///
        /// > Ped ped
        /// > float sweat
        ///
        /// </summary>
        SET_PED_SWEAT = 0x27B0405F59637D1F,
        /// <summary>
        /// Applies an Item from a PedDecorationCollection to a ped. These include tattoos and shirt decals.
        /// 
        /// collection - PedDecorationCollection filename hash
        /// overlay - Item name hash
        /// 
        /// Example:
        /// Entry inside "mpbeach_overlays.xml" -
        /// <Item>
        ///   <uvPos x="0.500000" y="0.500000" />
        ///   <scale x="0.600000" y="0.500000" />
        ///   <rotation value="0.000000" />
        ///   <nameHash>FM_Hair_Fuzz</nameHash>
        ///   <txdHash>mp_hair_fuzz</txdHash>
        ///   <txtHash>mp_hair_fuzz</txtHash>
        ///   <zone>ZONE_HEAD</zone>
        ///   <type>TYPE_TATTOO</type>
        ///   <faction>FM</faction>
        ///   <garment>All</garment>
        ///   <gender>GENDER_DONTCARE</gender>
        ///   <award />
        ///   <awardLevel />
        /// </Item>
        /// 
        /// Code:
        /// PED::_0x5F5D1665E352A839(PLAYER::PLAYER_PED_ID(), MISC::GET_HASH_KEY("mpbeach_overlays"), MISC::GET_HASH_KEY("fm_hair_fuzz"))
        /// 
        /// Full list of ped overlays / decorations by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pedOverlayCollections.json
        ///
        /// > Ped ped
        /// > Hash collection
        /// > Hash overlay
        ///
        /// </summary>
        ADD_PED_DECORATION_FROM_HASHES = 0x5F5D1665E352A839,
        /// <summary>
        /// Full list of ped overlays / decorations by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pedOverlayCollections.json
        ///
        /// > Ped ped
        /// > Hash collection
        /// > Hash overlay
        ///
        /// </summary>
        ADD_PED_DECORATION_FROM_HASHES_IN_CORONA = 0x5619BFA07CFD7833,
        /// <summary>
        /// Returns the zoneID for the overlay if it is a member of collection.
        /// enum ePedDecorationZone
        /// {
        /// 	ZONE_TORSO = 0,
        /// 	ZONE_HEAD = 1,
        /// 	ZONE_LEFT_ARM = 2,
        /// 	ZONE_RIGHT_ARM = 3,
        /// 	ZONE_LEFT_LEG = 4,
        /// 	ZONE_RIGHT_LEG = 5,
        /// 	ZONE_MEDALS = 6,
        /// 	ZONE_INVALID = 7
        /// };
        /// 
        /// Full list of ped overlays / decorations by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pedOverlayCollections.json
        ///
        /// > Hash collection
        /// > Hash overlay
        ///
        /// </summary>
        GET_PED_DECORATION_ZONE_FROM_HASHES = 0x9FD452BFBE7A7A8B,
        /// <summary>
        /// Despite this function's name, it simply returns whether the specified handle is a Ped.
        ///
        /// > Ped ped
        ///
        /// </summary>
        WAS_PED_SKELETON_UPDATED = 0x11B499C1E0FF8559,
        /// <summary>
        /// Gets the position of the specified bone of the specified ped.
        /// 
        /// ped: The ped to get the position of a bone from.
        /// boneId: The ID of the bone to get the position from. This is NOT the index.
        /// offsetX: The X-component of the offset to add to the position relative to the bone's rotation.
        /// offsetY: The Y-component of the offset to add to the position relative to the bone's rotation.
        /// offsetZ: The Z-component of the offset to add to the position relative to the bone's rotation.
        ///
        /// > Ped ped
        /// > int boneId
        /// > float offsetX
        /// > float offsetY
        /// > float offsetZ
        ///
        /// </summary>
        GET_PED_BONE_COORDS = 0x17C07FC640E86B4E,
        /// <summary>
        /// Creates a new NaturalMotion message.
        /// 
        /// startImmediately: If set to true, the character will perform the message the moment it receives it by GIVE_PED_NM_MESSAGE. If false, the Ped will get the message but won't perform it yet. While it's a boolean value, if negative, the message will not be initialized.
        /// messageId: The ID of the NaturalMotion message.
        /// 
        /// If a message already exists, this function does nothing. A message exists until the point it has been successfully dispatched by GIVE_PED_NM_MESSAGE.
        ///
        /// > BOOL startImmediately
        /// > int messageId
        ///
        /// </summary>
        CREATE_NM_MESSAGE = 0x418EF2A1BCE56685,
        /// <summary>
        /// Sends the message that was created by a call to CREATE_NM_MESSAGE to the specified Ped.
        /// 
        /// If a message hasn't been created already, this function does nothing.
        /// If the Ped is not ragdolled with Euphoria enabled, this function does nothing.
        /// The following call can be used to ragdoll the Ped with Euphoria enabled: SET_PED_TO_RAGDOLL(ped, 4000, 5000, 1, 1, 1, 0);
        /// 
        /// Call order:
        /// SET_PED_TO_RAGDOLL
        /// CREATE_NM_MESSAGE
        /// GIVE_PED_NM_MESSAGE
        /// 
        /// Multiple messages can be chained. Eg. to make the ped stagger and swing his arms around, the following calls can be made:
        /// SET_PED_TO_RAGDOLL(ped, 4000, 5000, 1, 1, 1, 0);
        /// CREATE_NM_MESSAGE(true, 0); // stopAllBehaviours - Stop all other behaviours, in case the Ped is already doing some Euphoria stuff.
        /// GIVE_PED_NM_MESSAGE(ped); // Dispatch message to Ped.
        /// CREATE_NM_MESSAGE(true, 1151); // staggerFall - Attempt to walk while falling.
        /// GIVE_PED_NM_MESSAGE(ped); // Dispatch message to Ped.
        /// CREATE_NM_MESSAGE(true, 372); // armsWindmill - Swing arms around.
        /// GIVE_PED_NM_MESSAGE(ped); // Dispatch message to Ped.
        ///
        /// > Ped ped
        ///
        /// </summary>
        GIVE_PED_NM_MESSAGE = 0xB158DFCCC56E5C5B,
        /// <summary>
        /// Full list of ped scenarios by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/scenariosCompact.json
        ///
        /// > Ped ped
        /// > const char* scenario
        ///
        /// </summary>
        IS_PED_USING_SCENARIO = 0x1BF094736DD62C2E,
        /// <summary>
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        ///
        /// > Ped ped
        /// > const char* animName
        /// > const char* animDict
        ///
        /// </summary>
        PLAY_FACIAL_ANIM = 0xE1E65CA8AC9C00ED,
        /// <summary>
        /// Clipsets:
        /// facials@gen_female@base
        /// facials@gen_male@base
        /// facials@p_m_zero@base
        /// 
        /// Typically followed with SET_FACIAL_IDLE_ANIM_OVERRIDE:
        /// mood_drunk_1
        /// mood_stressed_1
        /// mood_happy_1
        /// mood_talking_1
        /// 
        ///
        /// > Ped ped
        /// > const char* animDict
        ///
        /// </summary>
        _SET_FACIAL_CLIPSET_OVERRIDE = 0x5687C7F05B39E401,
        /// <summary>
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        ///
        /// > Ped ped
        /// > const char* animName
        /// > const char* animDict
        ///
        /// </summary>
        SET_FACIAL_IDLE_ANIM_OVERRIDE = 0xFFC24B988B938B38,
        /// <summary>
        /// p2 usually 0
        ///
        /// > Ped ped
        /// > BOOL toggle
        /// > BOOL p2
        ///
        /// </summary>
        SET_PED_CAN_PLAY_VISEME_ANIMS = 0xF833DDBA3B104D43,
        /// <summary>
        /// This is only called once in the scripts.
        /// 
        /// sub_1CD9(&l_49, 0, getElem(3, &l_34, 4), "MICHAEL", 0, 1);
        ///                     sub_1CA8("WORLD_HUMAN_SMOKING", 2);
        ///                     PED::SET_PED_PRIMARY_LOOKAT(getElem(3, &l_34, 4), PLAYER::PLAYER_PED_ID());
        ///
        /// > Ped ped
        /// > Ped lookAt
        ///
        /// </summary>
        SET_PED_PRIMARY_LOOKAT = 0xCD17B554996A8D9E,
        /// <summary>
        /// enum ePedConfigFlags
        /// {
        /// 	_CPED_CONFIG_FLAG_0x67D1A445 = 0,
        /// 	_CPED_CONFIG_FLAG_0xC63DE95E = 1,
        /// 	CPED_CONFIG_FLAG_NoCriticalHits = 2,
        /// 	CPED_CONFIG_FLAG_DrownsInWater = 3,
        /// 	CPED_CONFIG_FLAG_DisableReticuleFixedLockon = 4,
        /// 	_CPED_CONFIG_FLAG_0x37D196F4 = 5,
        /// 	_CPED_CONFIG_FLAG_0xE2462399 = 6,
        /// 	CPED_CONFIG_FLAG_UpperBodyDamageAnimsOnly = 7,
        /// 	_CPED_CONFIG_FLAG_0xEDDEB838 = 8,
        /// 	_CPED_CONFIG_FLAG_0xB398B6FD = 9,
        /// 	_CPED_CONFIG_FLAG_0xF6664E68 = 10,
        /// 	_CPED_CONFIG_FLAG_0xA05E7CA3 = 11,
        /// 	_CPED_CONFIG_FLAG_0xCE394045 = 12,
        /// 	CPED_CONFIG_FLAG_NeverLeavesGroup = 13,
        /// 	_CPED_CONFIG_FLAG_0xCD8D1411 = 14,
        /// 	_CPED_CONFIG_FLAG_0xB031F1A9 = 15,
        /// 	_CPED_CONFIG_FLAG_0xFE65BEE3 = 16,
        /// 	CPED_CONFIG_FLAG_BlockNonTemporaryEvents = 17,
        /// 	_CPED_CONFIG_FLAG_0x380165BD = 18,
        /// 	_CPED_CONFIG_FLAG_0x07C045C7 = 19,
        /// 	_CPED_CONFIG_FLAG_0x583B5E2D = 20,
        /// 	_CPED_CONFIG_FLAG_0x475EDA58 = 21,
        /// 	_CPED_CONFIG_FLAG_0x8629D05B = 22,
        /// 	_CPED_CONFIG_FLAG_0x1522968B = 23,
        /// 	CPED_CONFIG_FLAG_IgnoreSeenMelee = 24,
        /// 	_CPED_CONFIG_FLAG_0x4CC09C4B = 25,
        /// 	_CPED_CONFIG_FLAG_0x034F3053 = 26,
        /// 	_CPED_CONFIG_FLAG_0xD91BA7CC = 27,
        /// 	_CPED_CONFIG_FLAG_0x5C8DC66E = 28,
        /// 	_CPED_CONFIG_FLAG_0x8902EAA0 = 29,
        /// 	_CPED_CONFIG_FLAG_0x6580B9D2 = 30,
        /// 	_CPED_CONFIG_FLAG_0x0EF7A297 = 31,
        /// 	_CPED_CONFIG_FLAG_CanFlyThruWindscreen = 32, // 0x6BF86E5B
        /// 	CPED_CONFIG_FLAG_DieWhenRagdoll = 33,
        /// 	CPED_CONFIG_FLAG_HasHelmet = 34,
        /// 	CPED_CONFIG_FLAG_UseHelmet = 35,
        /// 	_CPED_CONFIG_FLAG_0xEEB3D630 = 36,
        /// 	_CPED_CONFIG_FLAG_0xB130D17B = 37,
        /// 	_CPED_CONFIG_FLAG_0x5F071200 = 38,
        /// 	CPED_CONFIG_FLAG_DisableEvasiveDives = 39,
        /// 	_CPED_CONFIG_FLAG_0xC287AAFF = 40,
        /// 	_CPED_CONFIG_FLAG_0x203328CC = 41,
        /// 	CPED_CONFIG_FLAG_DontInfluenceWantedLevel = 42,
        /// 	CPED_CONFIG_FLAG_DisablePlayerLockon = 43,
        /// 	CPED_CONFIG_FLAG_DisableLockonToRandomPeds = 44,
        /// 	_CPED_CONFIG_FLAG_0xEC4A8ACF = 45,
        /// 	_CPED_CONFIG_FLAG_0xDB115BFA = 46,
        /// 	CPED_CONFIG_FLAG_PedBeingDeleted = 47,
        /// 	CPED_CONFIG_FLAG_BlockWeaponSwitching = 48,
        /// 	_CPED_CONFIG_FLAG_0xF8E99565 = 49,
        /// 	_CPED_CONFIG_FLAG_0xDD17FEE6 = 50,
        /// 	_CPED_CONFIG_FLAG_0x7ED9B2C9 = 51,
        /// 	_CPED_CONFIG_FLAG_NoCollison = 52, // 0x655E8618
        /// 	_CPED_CONFIG_FLAG_0x5A6C1F6E = 53,
        /// 	_CPED_CONFIG_FLAG_0xD749FC41 = 54,
        /// 	_CPED_CONFIG_FLAG_0x357F63F3 = 55,
        /// 	_CPED_CONFIG_FLAG_0xC5E60961 = 56,
        /// 	_CPED_CONFIG_FLAG_0x29275C3E = 57,
        /// 	CPED_CONFIG_FLAG_IsFiring = 58,
        /// 	CPED_CONFIG_FLAG_WasFiring = 59,
        /// 	CPED_CONFIG_FLAG_IsStanding = 60,
        /// 	CPED_CONFIG_FLAG_WasStanding = 61,
        /// 	CPED_CONFIG_FLAG_InVehicle = 62,
        /// 	CPED_CONFIG_FLAG_OnMount = 63,
        /// 	CPED_CONFIG_FLAG_AttachedToVehicle = 64,
        /// 	CPED_CONFIG_FLAG_IsSwimming = 65,
        /// 	CPED_CONFIG_FLAG_WasSwimming = 66,
        /// 	CPED_CONFIG_FLAG_IsSkiing = 67,
        /// 	CPED_CONFIG_FLAG_IsSitting = 68,
        /// 	CPED_CONFIG_FLAG_KilledByStealth = 69,
        /// 	CPED_CONFIG_FLAG_KilledByTakedown = 70,
        /// 	CPED_CONFIG_FLAG_Knockedout = 71,
        /// 	_CPED_CONFIG_FLAG_0x3E3C4560 = 72,
        /// 	_CPED_CONFIG_FLAG_0x2994C7B7 = 73,
        /// 	_CPED_CONFIG_FLAG_0x6D59D275 = 74,
        /// 	CPED_CONFIG_FLAG_UsingCoverPoint = 75,
        /// 	CPED_CONFIG_FLAG_IsInTheAir = 76,
        /// 	_CPED_CONFIG_FLAG_0x2D493FB7 = 77,
        /// 	CPED_CONFIG_FLAG_IsAimingGun = 78,
        /// 	_CPED_CONFIG_FLAG_0x14D69875 = 79,
        /// 	_CPED_CONFIG_FLAG_0x40B05311 = 80,
        /// 	_CPED_CONFIG_FLAG_0x8B230BC5 = 81,
        /// 	_CPED_CONFIG_FLAG_0xC74E5842 = 82,
        /// 	_CPED_CONFIG_FLAG_0x9EA86147 = 83,
        /// 	_CPED_CONFIG_FLAG_0x674C746C = 84,
        /// 	_CPED_CONFIG_FLAG_0x3E56A8C2 = 85,
        /// 	_CPED_CONFIG_FLAG_0xC144A1EF = 86,
        /// 	_CPED_CONFIG_FLAG_0x0548512D = 87,
        /// 	_CPED_CONFIG_FLAG_0x31C93909 = 88,
        /// 	_CPED_CONFIG_FLAG_0xA0269315 = 89,
        /// 	_CPED_CONFIG_FLAG_0xD4D59D4D = 90,
        /// 	_CPED_CONFIG_FLAG_0x411D4420 = 91,
        /// 	_CPED_CONFIG_FLAG_0xDF4AEF0D = 92,
        /// 	CPED_CONFIG_FLAG_ForcePedLoadCover = 93,
        /// 	_CPED_CONFIG_FLAG_0x300E4CD3 = 94,
        /// 	_CPED_CONFIG_FLAG_0xF1C5BF04 = 95,
        /// 	_CPED_CONFIG_FLAG_0x89C2EF13 = 96,
        /// 	CPED_CONFIG_FLAG_VaultFromCover = 97,
        /// 	_CPED_CONFIG_FLAG_0x02A852C8 = 98,
        /// 	_CPED_CONFIG_FLAG_0x3D9407F1 = 99,
        /// 	_CPED_CONFIG_FLAG_IsDrunk = 100, // 0x319B4558
        /// 	CPED_CONFIG_FLAG_ForcedAim = 101,
        /// 	_CPED_CONFIG_FLAG_0xB942D71A = 102,
        /// 	_CPED_CONFIG_FLAG_0xD26C55A8 = 103,
        /// 	_CPED_CONFIG_FLAG_0xB89E703B = 104,
        /// 	CPED_CONFIG_FLAG_ForceReload = 105,
        /// 	_CPED_CONFIG_FLAG_0xD9E73DA2 = 106,
        /// 	_CPED_CONFIG_FLAG_0xFF71DC2C = 107,
        /// 	_CPED_CONFIG_FLAG_0x1E27E8D8 = 108,
        /// 	_CPED_CONFIG_FLAG_0xF2C53966 = 109,
        /// 	_CPED_CONFIG_FLAG_0xC4DBE247 = 110,
        /// 	_CPED_CONFIG_FLAG_0x83C0A4BF = 111,
        /// 	_CPED_CONFIG_FLAG_0x0E0FAF8C = 112,
        /// 	_CPED_CONFIG_FLAG_0x26616660 = 113,
        /// 	_CPED_CONFIG_FLAG_0x43B80B79 = 114,
        /// 	_CPED_CONFIG_FLAG_0x0D2A9309 = 115,
        /// 	_CPED_CONFIG_FLAG_0x12C1C983 = 116,
        /// 	CPED_CONFIG_FLAG_BumpedByPlayer = 117,
        /// 	_CPED_CONFIG_FLAG_0xE586D504 = 118,
        /// 	_CPED_CONFIG_FLAG_0x52374204 = 119,
        /// 	CPED_CONFIG_FLAG_IsHandCuffed = 120,
        /// 	CPED_CONFIG_FLAG_IsAnkleCuffed = 121,
        /// 	CPED_CONFIG_FLAG_DisableMelee = 122,
        /// 	_CPED_CONFIG_FLAG_0xFE714397 = 123,
        /// 	_CPED_CONFIG_FLAG_0xB3E660BD = 124,
        /// 	_CPED_CONFIG_FLAG_0x5FED6BFD = 125,
        /// 	_CPED_CONFIG_FLAG_0xC9D6F66F = 126,
        /// 	_CPED_CONFIG_FLAG_0x519BC986 = 127,
        /// 	CPED_CONFIG_FLAG_CanBeAgitated = 128,
        /// 	_CPED_CONFIG_FLAG_0x9A4B617C = 129,
        /// 	_CPED_CONFIG_FLAG_0xDAB70E9F = 130,
        /// 	_CPED_CONFIG_FLAG_0xE569438A = 131,
        /// 	_CPED_CONFIG_FLAG_0xBBC77D6D = 132,
        /// 	_CPED_CONFIG_FLAG_0xCB59EF0F = 133,
        /// 	_CPED_CONFIG_FLAG_0x8C5EA971 = 134,
        /// 	CPED_CONFIG_FLAG_IsScuba = 135,
        /// 	CPED_CONFIG_FLAG_WillArrestRatherThanJack = 136,
        /// 	_CPED_CONFIG_FLAG_0xDCE59B58 = 137,
        /// 	CPED_CONFIG_FLAG_RidingTrain = 138,
        /// 	CPED_CONFIG_FLAG_ArrestResult = 139,
        /// 	CPED_CONFIG_FLAG_CanAttackFriendly = 140,
        /// 	_CPED_CONFIG_FLAG_0x98A4BE43 = 141,
        /// 	_CPED_CONFIG_FLAG_0x6901E731 = 142,
        /// 	_CPED_CONFIG_FLAG_0x9EC9BF6C = 143,
        /// 	_CPED_CONFIG_FLAG_0x42841A8F = 144,
        /// 	CPED_CONFIG_FLAG_ShootingAnimFlag = 145,
        /// 	CPED_CONFIG_FLAG_DisableLadderClimbing = 146,
        /// 	CPED_CONFIG_FLAG_StairsDetected = 147,
        /// 	CPED_CONFIG_FLAG_SlopeDetected = 148,
        /// 	_CPED_CONFIG_FLAG_0x1A15670B = 149,
        /// 	_CPED_CONFIG_FLAG_0x61786EE5 = 150,
        /// 	_CPED_CONFIG_FLAG_0xCB9186BD = 151,
        /// 	_CPED_CONFIG_FLAG_0xF0710152 = 152,
        /// 	_CPED_CONFIG_FLAG_0x43DFE310 = 153,
        /// 	_CPED_CONFIG_FLAG_0xC43C624E = 154,
        /// 	CPED_CONFIG_FLAG_CanPerformArrest = 155,
        /// 	CPED_CONFIG_FLAG_CanPerformUncuff = 156,
        /// 	CPED_CONFIG_FLAG_CanBeArrested = 157,
        /// 	_CPED_CONFIG_FLAG_0xF7960FF5 = 158,
        /// 	_CPED_CONFIG_FLAG_0x59564113 = 159,
        /// 	_CPED_CONFIG_FLAG_0x0C6C3099 = 160,
        /// 	_CPED_CONFIG_FLAG_0x645F927A = 161,
        /// 	_CPED_CONFIG_FLAG_0xA86549B9 = 162,
        /// 	_CPED_CONFIG_FLAG_0x8AAF337A = 163,
        /// 	_CPED_CONFIG_FLAG_0x13BAA6E7 = 164,
        /// 	_CPED_CONFIG_FLAG_0x5FB9D1F5 = 165,
        /// 	CPED_CONFIG_FLAG_IsInjured = 166,
        /// 	_CPED_CONFIG_FLAG_0x6398A20B = 167,
        /// 	_CPED_CONFIG_FLAG_0xD8072639 = 168,
        /// 	_CPED_CONFIG_FLAG_0xA05B1845 = 169,
        /// 	_CPED_CONFIG_FLAG_0x83F6D220 = 170,
        /// 	_CPED_CONFIG_FLAG_0xD8430331 = 171,
        /// 	_CPED_CONFIG_FLAG_0x4B547520 = 172,
        /// 	_CPED_CONFIG_FLAG_0xE66E1406 = 173,
        /// 	_CPED_CONFIG_FLAG_0x1C4BFE0C = 174,
        /// 	_CPED_CONFIG_FLAG_0x90008BFA = 175,
        /// 	_CPED_CONFIG_FLAG_0x07C7A910 = 176,
        /// 	_CPED_CONFIG_FLAG_0xF15F8191 = 177,
        /// 	_CPED_CONFIG_FLAG_0xCE4E8BE2 = 178,
        /// 	_CPED_CONFIG_FLAG_0x1D46E4F2 = 179,
        /// 	CPED_CONFIG_FLAG_IsInCustody = 180,
        /// 	_CPED_CONFIG_FLAG_0xE4FD9B3A = 181,
        /// 	_CPED_CONFIG_FLAG_0x67AE0812 = 182,
        /// 	CPED_CONFIG_FLAG_IsAgitated = 183,
        /// 	CPED_CONFIG_FLAG_PreventAutoShuffleToDriversSeat = 184,
        /// 	_CPED_CONFIG_FLAG_0x7B2D325E = 185,
        /// 	CPED_CONFIG_FLAG_EnableWeaponBlocking = 186,
        /// 	CPED_CONFIG_FLAG_HasHurtStarted = 187,
        /// 	CPED_CONFIG_FLAG_DisableHurt = 188,
        /// 	CPED_CONFIG_FLAG_PlayerIsWeird = 189,
        /// 	_CPED_CONFIG_FLAG_0x32FC208B = 190,
        /// 	_CPED_CONFIG_FLAG_0x0C296E5A = 191,
        /// 	_CPED_CONFIG_FLAG_0xE63B73EC = 192,
        /// 	_CPED_CONFIG_FLAG_0x04E9CC80 = 193,
        /// 	CPED_CONFIG_FLAG_UsingScenario = 194,
        /// 	CPED_CONFIG_FLAG_VisibleOnScreen = 195,
        /// 	_CPED_CONFIG_FLAG_0xD88C58A1 = 196,
        /// 	_CPED_CONFIG_FLAG_0x5A3DCF43 = 197,
        /// 	_CPED_CONFIG_FLAG_0xEA02B420 = 198,
        /// 	_CPED_CONFIG_FLAG_0x3F559CFF = 199,
        /// 	_CPED_CONFIG_FLAG_0x8C55D029 = 200,
        /// 	_CPED_CONFIG_FLAG_0x5E6466F6 = 201,
        /// 	_CPED_CONFIG_FLAG_0xEB5AD706 = 202,
        /// 	_CPED_CONFIG_FLAG_0x0EDDDDE7 = 203,
        /// 	_CPED_CONFIG_FLAG_0xA64F7B1D = 204,
        /// 	_CPED_CONFIG_FLAG_0x48532CBA = 205,
        /// 	_CPED_CONFIG_FLAG_0xAA25A9E7 = 206,
        /// 	_CPED_CONFIG_FLAG_0x415B26B9 = 207,
        /// 	CPED_CONFIG_FLAG_DisableExplosionReactions = 208,
        /// 	CPED_CONFIG_FLAG_DodgedPlayer = 209,
        /// 	_CPED_CONFIG_FLAG_0x67405504 = 210,
        /// 	_CPED_CONFIG_FLAG_0x75DDD68C = 211,
        /// 	_CPED_CONFIG_FLAG_0x2AD879B4 = 212,
        /// 	_CPED_CONFIG_FLAG_0x51486F91 = 213,
        /// 	_CPED_CONFIG_FLAG_0x32F79E21 = 214,
        /// 	_CPED_CONFIG_FLAG_0xBF099213 = 215,
        /// 	_CPED_CONFIG_FLAG_0x054AC8E2 = 216,
        /// 	_CPED_CONFIG_FLAG_0x14E495CC = 217,
        /// 	_CPED_CONFIG_FLAG_0x3C7DF9DF = 218,
        /// 	_CPED_CONFIG_FLAG_0x848FFEF2 = 219,
        /// 	CPED_CONFIG_FLAG_DontEnterLeadersVehicle = 220,
        /// 	_CPED_CONFIG_FLAG_0x2618E1CF = 221,
        /// 	_CPED_CONFIG_FLAG_0x84F722FA = 222,
        /// 	_CPED_CONFIG_FLAG_Shrink = 223, // 0xD1B87B1F
        /// 	_CPED_CONFIG_FLAG_0x728AA918 = 224,
        /// 	CPED_CONFIG_FLAG_DisablePotentialToBeWalkedIntoResponse = 225,
        /// 	CPED_CONFIG_FLAG_DisablePedAvoidance = 226,
        /// 	_CPED_CONFIG_FLAG_0x59E91185 = 227,
        /// 	_CPED_CONFIG_FLAG_0x1EA7225F = 228,
        /// 	CPED_CONFIG_FLAG_DisablePanicInVehicle = 229,
        /// 	_CPED_CONFIG_FLAG_0x6DCA7D88 = 230,
        /// 	_CPED_CONFIG_FLAG_0xFC3E572D = 231,
        /// 	_CPED_CONFIG_FLAG_0x08E9F9CF = 232,
        /// 	_CPED_CONFIG_FLAG_0x2D3BA52D = 233,
        /// 	_CPED_CONFIG_FLAG_0xFD2F53EA = 234,
        /// 	_CPED_CONFIG_FLAG_0x31A1B03B = 235,
        /// 	CPED_CONFIG_FLAG_IsHoldingProp = 236,
        /// 	CPED_CONFIG_FLAG_BlocksPathingWhenDead = 237,
        /// 	_CPED_CONFIG_FLAG_0xCE57C9A3 = 238,
        /// 	_CPED_CONFIG_FLAG_0x26149198 = 239,
        /// 	_CPED_CONFIG_FLAG_0x1B33B598 = 240,
        /// 	_CPED_CONFIG_FLAG_0x719B6E87 = 241,
        /// 	_CPED_CONFIG_FLAG_0x13E8E8E8 = 242,
        /// 	_CPED_CONFIG_FLAG_0xF29739AE = 243,
        /// 	_CPED_CONFIG_FLAG_0xABEA8A74 = 244,
        /// 	_CPED_CONFIG_FLAG_0xB60EA2BA = 245,
        /// 	_CPED_CONFIG_FLAG_0x536B0950 = 246,
        /// 	_CPED_CONFIG_FLAG_0x0C754ACA = 247,
        /// 	CPED_CONFIG_FLAG_CanPlayInCarIdles = 248,
        /// 	_CPED_CONFIG_FLAG_0x12659168 = 249,
        /// 	_CPED_CONFIG_FLAG_0x1BDF2F04 = 250,
        /// 	_CPED_CONFIG_FLAG_0x7728FAA3 = 251,
        /// 	_CPED_CONFIG_FLAG_0x6A807ED8 = 252,
        /// 	CPED_CONFIG_FLAG_OnStairs = 253,
        /// 	_CPED_CONFIG_FLAG_0xE1A2F73F = 254,
        /// 	_CPED_CONFIG_FLAG_0x5B3697C8 = 255,
        /// 	_CPED_CONFIG_FLAG_0xF1EB20A9 = 256,
        /// 	_CPED_CONFIG_FLAG_0x8B7DF407 = 257,
        /// 	_CPED_CONFIG_FLAG_0x329DCF1A = 258,
        /// 	_CPED_CONFIG_FLAG_0x8D90DD1B = 259,
        /// 	_CPED_CONFIG_FLAG_0xB8A292B7 = 260,
        /// 	_CPED_CONFIG_FLAG_0x8374B087 = 261,
        /// 	_CPED_CONFIG_FLAG_0x2AF558F0 = 262,
        /// 	_CPED_CONFIG_FLAG_0x82251455 = 263,
        /// 	_CPED_CONFIG_FLAG_0x30CF498B = 264,
        /// 	_CPED_CONFIG_FLAG_0xE1CD50AF = 265,
        /// 	_CPED_CONFIG_FLAG_0x72E4AE48 = 266,
        /// 	_CPED_CONFIG_FLAG_0xC2657EA1 = 267,
        /// 	_CPED_CONFIG_FLAG_0x29FF6030 = 268,
        /// 	_CPED_CONFIG_FLAG_0x8248A5EC = 269,
        /// 	CPED_CONFIG_FLAG_OnStairSlope = 270,
        /// 	_CPED_CONFIG_FLAG_0xA0897933 = 271,
        /// 	CPED_CONFIG_FLAG_DontBlipCop = 272,
        /// 	CPED_CONFIG_FLAG_ClimbedShiftedFence = 273,
        /// 	_CPED_CONFIG_FLAG_0xF7823618 = 274,
        /// 	_CPED_CONFIG_FLAG_0xDC305CCE = 275,
        /// 	CPED_CONFIG_FLAG_EdgeDetected = 276,
        /// 	_CPED_CONFIG_FLAG_0x92B67896 = 277,
        /// 	_CPED_CONFIG_FLAG_0xCAD677C9 = 278,
        /// 	CPED_CONFIG_FLAG_AvoidTearGas = 279,
        /// 	_CPED_CONFIG_FLAG_0x5276AC7B = 280,
        /// 	_CPED_CONFIG_FLAG_NoWrithe = 281, // 0x1032692A
        /// 	_CPED_CONFIG_FLAG_0xDA23E7F1 = 282,
        /// 	_CPED_CONFIG_FLAG_0x9139724D = 283,
        /// 	_CPED_CONFIG_FLAG_0xA1457461 = 284,
        /// 	_CPED_CONFIG_FLAG_0x4186E095 = 285,
        /// 	_CPED_CONFIG_FLAG_0xAC68E2EB = 286,
        /// 	CPED_CONFIG_FLAG_RagdollingOnBoat = 287,
        /// 	CPED_CONFIG_FLAG_HasBrandishedWeapon = 288,
        /// 	_CPED_CONFIG_FLAG_0x1B9EE8A1 = 289,
        /// 	_CPED_CONFIG_FLAG_0xF3F5758C = 290,
        /// 	_CPED_CONFIG_FLAG_0x2A9307F1 = 291,
        /// 	_CPED_CONFIG_FLAG_FreezePosition = 292, // 0x7403D216
        /// 	_CPED_CONFIG_FLAG_0xA06A3C6C = 293,
        /// 	CPED_CONFIG_FLAG_DisableShockingEvents = 294,
        /// 	_CPED_CONFIG_FLAG_0xF8DA25A5 = 295,
        /// 	_CPED_CONFIG_FLAG_0x7EF55802 = 296,
        /// 	_CPED_CONFIG_FLAG_0xB31F1187 = 297,
        /// 	_CPED_CONFIG_FLAG_0x84315402 = 298,
        /// 	_CPED_CONFIG_FLAG_0x0FD69867 = 299,
        /// 	_CPED_CONFIG_FLAG_0xC7829B67 = 300,
        /// 	CPED_CONFIG_FLAG_DisablePedConstraints = 301,
        /// 	_CPED_CONFIG_FLAG_0x6D23CF25 = 302,
        /// 	_CPED_CONFIG_FLAG_0x2ADA871B = 303,
        /// 	_CPED_CONFIG_FLAG_0x47BC8A58 = 304,
        /// 	_CPED_CONFIG_FLAG_0xEB692FA5 = 305,
        /// 	_CPED_CONFIG_FLAG_0x4A133C50 = 306,
        /// 	_CPED_CONFIG_FLAG_0xC58099C3 = 307,
        /// 	_CPED_CONFIG_FLAG_0xF3D76D41 = 308,
        /// 	_CPED_CONFIG_FLAG_0xB0EEE9F2 = 309,
        /// 	CPED_CONFIG_FLAG_IsInCluster = 310,
        /// 	_CPED_CONFIG_FLAG_0x0FA153EF = 311,
        /// 	_CPED_CONFIG_FLAG_0xD73F5CD3 = 312,
        /// 	_CPED_CONFIG_FLAG_0xD4136C22 = 313,
        /// 	_CPED_CONFIG_FLAG_0xE404CA6B = 314,
        /// 	_CPED_CONFIG_FLAG_0xB9597446 = 315,
        /// 	_CPED_CONFIG_FLAG_0xD5C98277 = 316,
        /// 	_CPED_CONFIG_FLAG_0xD5060A9C = 317,
        /// 	_CPED_CONFIG_FLAG_0x3E5F1CBB = 318,
        /// 	_CPED_CONFIG_FLAG_0xD8BE1D54 = 319,
        /// 	_CPED_CONFIG_FLAG_0x0B1F191F = 320,
        /// 	_CPED_CONFIG_FLAG_0xC995167A = 321,
        /// 	CPED_CONFIG_FLAG_HasHighHeels = 322,
        /// 	_CPED_CONFIG_FLAG_0x86B01E54 = 323,
        /// 	_CPED_CONFIG_FLAG_0x3A56FE15 = 324,
        /// 	_CPED_CONFIG_FLAG_0xC03B736C = 325, // SpawnedAtScenario?
        /// 	_CPED_CONFIG_FLAG_0xBBF47729 = 326,
        /// 	_CPED_CONFIG_FLAG_0x22B668A8 = 327,
        /// 	_CPED_CONFIG_FLAG_0x2624D4D4 = 328,
        /// 	CPED_CONFIG_FLAG_DisableTalkTo = 329,
        /// 	CPED_CONFIG_FLAG_DontBlip = 330,
        /// 	CPED_CONFIG_FLAG_IsSwitchingWeapon = 331,
        /// 	_CPED_CONFIG_FLAG_0x630F55F3 = 332,
        /// 	_CPED_CONFIG_FLAG_0x150468FD = 333,
        /// 	_CPED_CONFIG_FLAG_0x914EBD6B = 334,
        /// 	_CPED_CONFIG_FLAG_0x79AF3B6D = 335,
        /// 	_CPED_CONFIG_FLAG_0x75C7A632 = 336,
        /// 	_CPED_CONFIG_FLAG_0x52D530E2 = 337,
        /// 	_CPED_CONFIG_FLAG_0xDB2A90E0 = 338,
        /// 	_CPED_CONFIG_FLAG_0x5922763D = 339,
        /// 	_CPED_CONFIG_FLAG_0x12ADB567 = 340,
        /// 	_CPED_CONFIG_FLAG_0x105C8518 = 341,
        /// 	_CPED_CONFIG_FLAG_0x106F703D = 342,
        /// 	_CPED_CONFIG_FLAG_0xED152C3E = 343,
        /// 	_CPED_CONFIG_FLAG_0xA0EFE6A8 = 344,
        /// 	_CPED_CONFIG_FLAG_0xBF348C82 = 345,
        /// 	_CPED_CONFIG_FLAG_0xCDDFE830 = 346,
        /// 	_CPED_CONFIG_FLAG_0x7B59BD9B = 347,
        /// 	_CPED_CONFIG_FLAG_0x0124C788 = 348,
        /// 	CPED_CONFIG_FLAG_EquipJetpack = 349,
        /// 	_CPED_CONFIG_FLAG_0x08D361A5 = 350,
        /// 	_CPED_CONFIG_FLAG_0xE13D1F7C = 351,
        /// 	_CPED_CONFIG_FLAG_0x40E25FB9 = 352,
        /// 	_CPED_CONFIG_FLAG_0x930629D9 = 353,
        /// 	_CPED_CONFIG_FLAG_0xECCF0C7F = 354,
        /// 	_CPED_CONFIG_FLAG_0xB6E9613B = 355,
        /// 	_CPED_CONFIG_FLAG_0x490C0478 = 356,
        /// 	_CPED_CONFIG_FLAG_0xE8865BEA = 357,
        /// 	_CPED_CONFIG_FLAG_0xF3C34A29 = 358,
        /// 	CPED_CONFIG_FLAG_IsDuckingInVehicle = 359,
        /// 	_CPED_CONFIG_FLAG_0xF660E115 = 360,
        /// 	_CPED_CONFIG_FLAG_0xAB0E6DED = 361,
        /// 	CPED_CONFIG_FLAG_HasReserveParachute = 362,
        /// 	CPED_CONFIG_FLAG_UseReserveParachute = 363,
        /// 	_CPED_CONFIG_FLAG_0x5C5D9CD3 = 364,
        /// 	_CPED_CONFIG_FLAG_0x8F7701F3 = 365,
        /// 	_CPED_CONFIG_FLAG_0xBC4436AD = 366,
        /// 	_CPED_CONFIG_FLAG_0xD7E07D37 = 367,
        /// 	_CPED_CONFIG_FLAG_0x03C4FD24 = 368,
        /// 	_CPED_CONFIG_FLAG_0x7675789A = 369,
        /// 	_CPED_CONFIG_FLAG_0xB7288A88 = 370,
        /// 	_CPED_CONFIG_FLAG_0xC06B6291 = 371,
        /// 	_CPED_CONFIG_FLAG_0x95A4A805 = 372,
        /// 	_CPED_CONFIG_FLAG_0xA8E9A042 = 373,
        /// 	CPED_CONFIG_FLAG_NeverLeaveTrain = 374,
        /// 	_CPED_CONFIG_FLAG_0xBAC674B3 = 375,
        /// 	_CPED_CONFIG_FLAG_0x147F1FFB = 376,
        /// 	_CPED_CONFIG_FLAG_0x4376DD79 = 377,
        /// 	_CPED_CONFIG_FLAG_0xCD3DB518 = 378,
        /// 	_CPED_CONFIG_FLAG_0xFE4BA4B6 = 379,
        /// 	_CPED_CONFIG_FLAG_0x5DF03A55 = 380,
        /// 	_CPED_CONFIG_FLAG_0xBCD816CD = 381,
        /// 	_CPED_CONFIG_FLAG_0xCF02DD69 = 382,
        /// 	_CPED_CONFIG_FLAG_0xF73AFA2E = 383,
        /// 	_CPED_CONFIG_FLAG_0x80B9A9D0 = 384,
        /// 	_CPED_CONFIG_FLAG_0xF601F7EE = 385,
        /// 	_CPED_CONFIG_FLAG_0xA91350FC = 386,
        /// 	_CPED_CONFIG_FLAG_0x3AB23B96 = 387,
        /// 	CPED_CONFIG_FLAG_IsClimbingLadder = 388,
        /// 	CPED_CONFIG_FLAG_HasBareFeet = 389,
        /// 	_CPED_CONFIG_FLAG_0xB4B1CD4C = 390,
        /// 	_CPED_CONFIG_FLAG_0x5459AFB8 = 391,
        /// 	_CPED_CONFIG_FLAG_0x54F27667 = 392,
        /// 	_CPED_CONFIG_FLAG_0xC11D3E8F = 393,
        /// 	_CPED_CONFIG_FLAG_0x5419EB3E = 394,
        /// 	_CPED_CONFIG_FLAG_0x82D8DBB4 = 395,
        /// 	_CPED_CONFIG_FLAG_0x33B02D2F = 396,
        /// 	_CPED_CONFIG_FLAG_0xAE66176D = 397,
        /// 	_CPED_CONFIG_FLAG_0xA2692593 = 398,
        /// 	_CPED_CONFIG_FLAG_0x714C7E31 = 399,
        /// 	_CPED_CONFIG_FLAG_0xEC488AC7 = 400,
        /// 	_CPED_CONFIG_FLAG_0xAE398504 = 401,
        /// 	_CPED_CONFIG_FLAG_0xABC58D72 = 402,
        /// 	_CPED_CONFIG_FLAG_0x5E5B9591 = 403,
        /// 	_CPED_CONFIG_FLAG_0x6BA1091E = 404,
        /// 	_CPED_CONFIG_FLAG_0x77840177 = 405,
        /// 	_CPED_CONFIG_FLAG_0x1C7ACAC4 = 406,
        /// 	_CPED_CONFIG_FLAG_0x124420E9 = 407,
        /// 	_CPED_CONFIG_FLAG_0x75A65587 = 408,
        /// 	_CPED_CONFIG_FLAG_0xDFD2D55B = 409,
        /// 	_CPED_CONFIG_FLAG_0xBDD39919 = 410,
        /// 	_CPED_CONFIG_FLAG_0x43DEC267 = 411,
        /// 	_CPED_CONFIG_FLAG_0xE42B7797 = 412,
        /// 	CPED_CONFIG_FLAG_IsHolsteringWeapon = 413,
        /// 	_CPED_CONFIG_FLAG_0x4F8149F5 = 414,
        /// 	_CPED_CONFIG_FLAG_0xDD9ECA7A = 415,
        /// 	_CPED_CONFIG_FLAG_0x9E7EF9D2 = 416,
        /// 	_CPED_CONFIG_FLAG_0x2C6ED942 = 417,
        /// 	CPED_CONFIG_FLAG_IsSwitchingHelmetVisor = 418,
        /// 	_CPED_CONFIG_FLAG_0xA488727D = 419,
        /// 	_CPED_CONFIG_FLAG_0xCFF5F6DE = 420,
        /// 	_CPED_CONFIG_FLAG_0x6D614599 = 421,
        /// 	CPED_CONFIG_FLAG_DisableVehicleCombat = 422,
        /// 	_CPED_CONFIG_FLAG_0xFE401D26 = 423,
        /// 	CPED_CONFIG_FLAG_FallsLikeAircraft = 424,
        /// 	_CPED_CONFIG_FLAG_0x2B42AE82 = 425,
        /// 	_CPED_CONFIG_FLAG_0x7A95734F = 426,
        /// 	_CPED_CONFIG_FLAG_0xDF4D8617 = 427,
        /// 	_CPED_CONFIG_FLAG_0x578F1F14 = 428,
        /// 	CPED_CONFIG_FLAG_DisableStartEngine = 429,
        /// 	CPED_CONFIG_FLAG_IgnoreBeingOnFire = 430,
        /// 	_CPED_CONFIG_FLAG_0x153C9500 = 431,
        /// 	_CPED_CONFIG_FLAG_0xCB7A632E = 432,
        /// 	_CPED_CONFIG_FLAG_0xDE727981 = 433,
        /// 	CPED_CONFIG_FLAG_DisableHomingMissileLockon = 434,
        /// 	_CPED_CONFIG_FLAG_0x12BBB935 = 435,
        /// 	_CPED_CONFIG_FLAG_0xAD0A1277 = 436,
        /// 	_CPED_CONFIG_FLAG_0xEA6AA46A = 437,
        /// 	CPED_CONFIG_FLAG_DisableHelmetArmor = 438,
        /// 	_CPED_CONFIG_FLAG_0xCB7F3A1E = 439,
        /// 	_CPED_CONFIG_FLAG_0x50178878 = 440,
        /// 	_CPED_CONFIG_FLAG_0x051B4F0D = 441,
        /// 	_CPED_CONFIG_FLAG_0x2FC3DECC = 442,
        /// 	_CPED_CONFIG_FLAG_0xC0030B0B = 443,
        /// 	_CPED_CONFIG_FLAG_0xBBDAF1E9 = 444,
        /// 	_CPED_CONFIG_FLAG_0x944FE59C = 445,
        /// 	_CPED_CONFIG_FLAG_0x506FBA39 = 446,
        /// 	_CPED_CONFIG_FLAG_0xDD45FE84 = 447,
        /// 	_CPED_CONFIG_FLAG_0xE698AE75 = 448,
        /// 	_CPED_CONFIG_FLAG_0x199633F8 = 449,
        /// 	CPED_CONFIG_FLAG_PedIsArresting = 450,
        /// 	CPED_CONFIG_FLAG_IsDecoyPed = 451,
        /// 	_CPED_CONFIG_FLAG_0x3A251D83 = 452,
        /// 	_CPED_CONFIG_FLAG_0xA56F6986 = 453,
        /// 	_CPED_CONFIG_FLAG_0x1D19C622 = 454,
        /// 	_CPED_CONFIG_FLAG_0xB68D3EAB = 455,
        /// 	CPED_CONFIG_FLAG_CanBeIncapacitated = 456,
        /// 	_CPED_CONFIG_FLAG_0x4BD5EBAD = 457,
        /// 	_CPED_CONFIG_FLAG_0xFCC5EBC5 = 458
        /// };
        ///
        /// > Ped ped
        /// > int flagId
        /// > BOOL value
        ///
        /// </summary>
        SET_PED_CONFIG_FLAG = 0x1913FE4CBF41C463,
        /// <summary>
        /// PED::SET_PED_RESET_FLAG(PLAYER::PLAYER_PED_ID(), 240, 1);
        /// Known values:
        /// PRF_PreventGoingIntoStillInVehicleState = 236 *(fanatic2.c)*
        ///
        /// > Ped ped
        /// > int flagId
        /// > BOOL doReset
        ///
        /// </summary>
        SET_PED_RESET_FLAG = 0xC1E8A365BF3B29F2,
        /// <summary>
        /// See SET_PED_CONFIG_FLAG
        ///
        /// > Ped ped
        /// > int flagId
        /// > BOOL p2
        ///
        /// </summary>
        GET_PED_CONFIG_FLAG = 0x7EE53118C892B513,
        /// <summary>
        /// Presumably returns the Entity that the Ped is currently diving out of the way of.
        /// 
        /// var num3;
        ///     if (PED::IS_PED_EVASIVE_DIVING(A_0, &num3) != 0)
        ///         if (ENTITY::IS_ENTITY_A_VEHICLE(num3) != 0)
        ///
        /// > Ped ped
        /// > Entity* evadingEntity
        ///
        /// </summary>
        IS_PED_EVASIVE_DIVING = 0x414641C26E105898,
        /// <summary>
        /// Full list of peds by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/peds.json
        ///
        /// > Hash modelHash
        /// > BOOL toggle
        ///
        /// </summary>
        SET_PED_MODEL_IS_SUPPRESSED = 0xE163A4BCE4DE6F11,
        /// <summary>
        /// PoliceMotorcycleHelmet   1024    
        /// RegularMotorcycleHelmet   4096    
        /// FiremanHelmet 16384   
        /// PilotHeadset  32768   
        /// PilotHelmet   65536
        /// --
        /// p2 is generally 4096 or 16384 in the scripts. p1 varies between 1 and 0.
        ///
        /// > Ped ped
        /// > BOOL cannotRemove
        /// > int helmetFlag
        /// > int textureIndex
        ///
        /// </summary>
        GIVE_PED_HELMET = 0x54C7C4A94367717E,
        /// <summary>
        /// List of component/props ID
        /// gtaxscripting.blogspot.com/2016/04/gta-v-peds-component-and-props.html
        ///
        /// > Ped ped
        /// > int propIndex
        /// > BOOL p2
        ///
        /// </summary>
        SET_PED_HELMET_PROP_INDEX = 0x26D83693ED99291C,
        /// <summary>
        /// Returns true if the ped passed through the parenthesis is wearing a helmet.
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_WEARING_HELMET = 0xF33BDFE19B309B19,
        /// <summary>
        /// It simply makes the said ped to cower behind cover object(wall, desk, car)
        /// 
        /// Peds flee attributes must be set to not to flee, first. Else, most of the peds, will just flee from gunshot sounds or any other panic situations.
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        SET_PED_CAN_COWER_IN_COVER = 0xCB7553CDCEF4A735,
        /// <summary>
        /// This native does absolutely nothing, just a nullsub
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        SET_PED_PLAYS_HEAD_ON_HORN_ANIM_WHEN_DIES_IN_VEHICLE = 0x94D94BF1A75AED3D,
        /// <summary>
        /// "IK" stands for "Inverse kinematics." I assume this has something to do with how the ped uses his legs to balance. In the scripts, the second parameter is always an int with a value of 2, 0, or sometimes 1
        ///
        /// > Ped ped
        /// > int mode
        ///
        /// </summary>
        SET_PED_LEG_IK_MODE = 0xC396F5B86FF9FEBD,
        /// <summary>
        /// enum eCombatMovement // 0x4F456B61
        /// {
        /// 	CM_Stationary,
        /// 	CM_Defensive,
        /// 	CM_WillAdvance,
        /// 	CM_WillRetreat
        /// };
        ///
        /// > Ped ped
        /// > int combatMovement
        ///
        /// </summary>
        SET_PED_COMBAT_MOVEMENT = 0x4D9CA1009AFBD057,
        /// <summary>
        /// See SET_PED_COMBAT_MOVEMENT
        ///
        /// > Ped ped
        ///
        /// </summary>
        GET_PED_COMBAT_MOVEMENT = 0xDEA92412FCAEB3F5,
        /// <summary>
        /// enum eCombatAbility // 0xE793438C
        /// {
        /// 	CA_Poor,
        /// 	CA_Average,
        /// 	CA_Professional,
        /// 	CA_NumTypes
        /// };
        ///
        /// > Ped ped
        /// > int abilityLevel
        ///
        /// </summary>
        SET_PED_COMBAT_ABILITY = 0xC7622C0D36B2FDA8,
        /// <summary>
        /// enum eCombatRange // 0xB69160F5
        /// {
        /// 	CR_Near,
        /// 	CR_Medium,
        /// 	CR_Far,
        /// 	CR_VeryFar,
        /// 	CR_NumRanges
        /// };
        ///
        /// > Ped ped
        /// > int combatRange
        ///
        /// </summary>
        SET_PED_COMBAT_RANGE = 0x3C606747B23E497B,
        /// <summary>
        /// See SET_PED_COMBAT_RANGE
        ///
        /// > Ped ped
        ///
        /// </summary>
        GET_PED_COMBAT_RANGE = 0xF9D9F7F2DB8E2FA0,
        /// <summary>
        /// enum eCombatAttributes // 0x0E8E7201
        /// {
        /// 	BF_CanUseCover = 0,
        /// 	BF_CanUseVehicles = 1,
        /// 	BF_CanDoDrivebys = 2,
        /// 	BF_CanLeaveVehicle = 3,
        /// 	BF_CanUseDynamicStrafeDecisions = 4,
        /// 	BF_AlwaysFight = 5,
        /// 	BF_0x66BB9FCC = 6,
        /// 	BF_0x6837DA41 = 7,
        /// 	BF_0xB4A13A5A = 8,
        /// 	BF_0xEE326AAD = 9,
        /// 	BF_0x7DF2CCFA = 10,
        /// 	BF_0x0036D422 = 11,
        /// 	BF_BlindFireWhenInCover = 12,
        /// 	BF_Aggressive = 13,
        /// 	BF_CanInvestigate = 14,
        /// 	BF_HasRadio = 15,
        /// 	BF_0x6BDE28D1 = 16,
        /// 	BF_AlwaysFlee = 17,
        /// 	BF_0x7852797D = 18,
        /// 	BF_0x33497B95 = 19,
        /// 	BF_CanTauntInVehicle = 20,
        /// 	BF_CanChaseTargetOnFoot = 21,
        /// 	BF_WillDragInjuredPedsToSafety = 22,
        /// 	BF_0xCD7168B8 = 23,
        /// 	BF_UseProximityFiringRate = 24,
        /// 	BF_0x48F914F8 = 25,
        /// 	BF_0x2EA543D0 = 26,
        /// 	BF_PerfectAccuracy = 27,
        /// 	BF_CanUseFrustratedAdvance = 28,
        /// 	BF_0x3D131AC1 = 29,
        /// 	BF_0x3AD95F27 = 30,
        /// 	BF_MaintainMinDistanceToTarget = 31,
        /// 	BF_0xEAD68AD2 = 32,
        /// 	BF_0xA206C2E0 = 33,
        /// 	BF_CanUsePeekingVariations = 34,
        /// 	BF_0xA5715184 = 35,
        /// 	BF_0xD5265533 = 36,
        /// 	BF_0x2B84C2BF = 37,
        /// 	BF_DisableBulletReactions = 38,
        /// 	BF_CanBust = 39,
        /// 	BF_0xAA525726 = 40,
        /// 	BF_CanCommandeerVehicles = 41,
        /// 	BF_CanFlank = 42,
        /// 	BF_SwitchToAdvanceIfCantFindCover = 43,
        /// 	BF_SwitchToDefensiveIfInCover = 44,
        /// 	BF_0xEB4786A0 = 45,
        /// 	BF_CanFightArmedPedsWhenNotArmed = 46,
        /// 	BF_0xA08E9402 = 47,
        /// 	BF_0x952EAD7D = 48,
        /// 	BF_UseEnemyAccuracyScaling = 49,
        /// 	BF_CanCharge = 50,
        /// 	BF_0xDA8C2BD3 = 51,
        /// 	BF_0x6562F017 = 52,
        /// 	BF_0xA2C3D53B = 53,
        /// 	BF_AlwaysEquipBestWeapon = 54,
        /// 	BF_CanSeeUnderwaterPeds = 55,
        /// 	BF_0xF619486B = 56,
        /// 	BF_0x61EB63A3 = 57,
        /// 	BF_DisableFleeFromCombat = 58,
        /// 	BF_0x8976D12B = 59,
        /// 	BF_CanThrowSmokeGrenade = 60,
        /// 	BF_NonMissionPedsFleeFromThisPedUnlessArmed = 61,
        /// 	BF_0x5452A10C = 62,
        /// 	BF_FleesFromInvincibleOpponents = 63,
        /// 	BF_DisableBlockFromPursueDuringVehicleChase = 64,
        /// 	BF_DisableSpinOutDuringVehicleChase = 65,
        /// 	BF_DisableCruiseInFrontDuringBlockDuringVehicleChase = 66,
        /// 	BF_0x0B404731 = 67,
        /// 	BF_DisableReactToBuddyShot = 68,
        /// 	BF_0x7FFD6AEB = 69,
        /// 	BF_0x51F4AEF8 = 70,
        /// 	BF_PermitChargeBeyondDefensiveArea = 71,
        /// 	BF_0x63E0A8E2 = 72,
        /// 	BF_0xDF974436 = 73,
        /// 	BF_0x556C080B = 74,
        /// 	BF_0xA4D50035 = 75,
        /// 	BF_SetDisableShoutTargetPositionOnCombatStart = 76,
        /// 	BF_DisableRespondedToThreatBroadcast = 77,
        /// 	BF_0xCBB01765 = 78,
        /// 	BF_0x4F862ED4 = 79,
        /// 	BF_0xEF9C7C40 = 80,
        /// 	BF_0xE51B494F = 81,
        /// 	BF_0x054D0199 = 82,
        /// 	BF_0xD36BCE94 = 83,
        /// 	BF_0xFB11F690 = 84,
        /// 	BF_0xD208A9AD = 85,
        /// 	BF_AllowDogFighting = 86,
        /// 	BF_0x07A6E531 = 87,
        /// 	BF_0x34F9317B = 88,
        /// 	BF_0x4240F5A9 = 89,
        /// 	BF_0xEE129DBD = 90,
        /// 	BF_0x053AEAD9 = 91
        /// };
        ///
        /// > Ped ped
        /// > int attributeId
        /// > BOOL enabled
        ///
        /// </summary>
        SET_PED_COMBAT_ATTRIBUTES = 0x9F7794730795E019,
        /// <summary>
        /// enum eTargetLossResponseType
        /// {
        /// 	TLR_ExitTask,
        /// 	TLR_NeverLoseTarget,
        /// 	TLR_SearchForTarget
        /// };
        ///
        /// > Ped ped
        /// > int responseType
        ///
        /// </summary>
        SET_PED_TARGET_LOSS_RESPONSE = 0x0703B9079823DA4A,
        /// <summary>
        /// bit 15 (0x8000) = force cower
        ///
        /// > Ped ped
        /// > int attributeFlags
        /// > BOOL enable
        ///
        /// </summary>
        SET_PED_FLEE_ATTRIBUTES = 0x70A2D1137C8ED7C9,
        /// <summary>
        /// p1: Only "CODE_HUMAN_STAND_COWER" found in the b617d scripts.
        ///
        /// > Ped ped
        /// > const char* p1
        ///
        /// </summary>
        SET_PED_COWER_HASH = 0xA549131166868ED3,
        /// <summary>
        /// returns whether or not a ped is visible within your FOV, not this check auto's to false after a certain distance.
        /// 
        /// 
        /// Target needs to be tracked.. won't work otherwise.
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_TRACKED_PED_VISIBLE = 0x91C8E617F64188AC,
        /// <summary>
        /// no bone= -1
        /// 
        /// boneIds:
        ///         SKEL_ROOT = 0x0,
        ///    SKEL_Pelvis = 0x2e28,
        ///  SKEL_L_Thigh = 0xe39f,
        ///     SKEL_L_Calf = 0xf9bb,
        ///  SKEL_L_Foot = 0x3779,
        ///  SKEL_L_Toe0 = 0x83c,
        ///   IK_L_Foot = 0xfedd,
        ///    PH_L_Foot = 0xe175,
        ///    MH_L_Knee = 0xb3fe,
        ///    SKEL_R_Thigh = 0xca72,
        ///     SKEL_R_Calf = 0x9000,
        ///  SKEL_R_Foot = 0xcc4d,
        ///  SKEL_R_Toe0 = 0x512d,
        ///  IK_R_Foot = 0x8aae,
        ///    PH_R_Foot = 0x60e6,
        ///    MH_R_Knee = 0x3fcf,
        ///    RB_L_ThighRoll = 0x5c57,
        ///   RB_R_ThighRoll = 0x192a,
        ///   SKEL_Spine_Root = 0xe0fd,
        ///  SKEL_Spine0 = 0x5c01,
        ///  SKEL_Spine1 = 0x60f0,
        ///  SKEL_Spine2 = 0x60f1,
        ///  SKEL_Spine3 = 0x60f2,
        ///  SKEL_L_Clavicle = 0xfcd9,
        ///  SKEL_L_UpperArm = 0xb1c5,
        ///  SKEL_L_Forearm = 0xeeeb,
        ///   SKEL_L_Hand = 0x49d9,
        ///  SKEL_L_Finger00 = 0x67f2,
        ///  SKEL_L_Finger01 = 0xff9,
        ///   SKEL_L_Finger02 = 0xffa,
        ///   SKEL_L_Finger10 = 0x67f3,
        ///  SKEL_L_Finger11 = 0x1049,
        ///  SKEL_L_Finger12 = 0x104a,
        ///  SKEL_L_Finger20 = 0x67f4,
        ///  SKEL_L_Finger21 = 0x1059,
        ///  SKEL_L_Finger22 = 0x105a,
        ///  SKEL_L_Finger30 = 0x67f5,
        ///  SKEL_L_Finger31 = 0x1029,
        ///  SKEL_L_Finger32 = 0x102a,
        ///  SKEL_L_Finger40 = 0x67f6,
        ///  SKEL_L_Finger41 = 0x1039,
        ///  SKEL_L_Finger42 = 0x103a,
        ///  PH_L_Hand = 0xeb95,
        ///    IK_L_Hand = 0x8cbd,
        ///    RB_L_ForeArmRoll = 0xee4f,
        ///     RB_L_ArmRoll = 0x1470,
        ///     MH_L_Elbow = 0x58b7,
        ///   SKEL_R_Clavicle = 0x29d2,
        ///  SKEL_R_UpperArm = 0x9d4d,
        ///  SKEL_R_Forearm = 0x6e5c,
        ///   SKEL_R_Hand = 0xdead,
        ///  SKEL_R_Finger00 = 0xe5f2,
        ///  SKEL_R_Finger01 = 0xfa10,
        ///  SKEL_R_Finger02 = 0xfa11,
        ///  SKEL_R_Finger10 = 0xe5f3,
        ///  SKEL_R_Finger11 = 0xfa60,
        ///  SKEL_R_Finger12 = 0xfa61,
        ///  SKEL_R_Finger20 = 0xe5f4,
        ///  SKEL_R_Finger21 = 0xfa70,
        ///  SKEL_R_Finger22 = 0xfa71,
        ///  SKEL_R_Finger30 = 0xe5f5,
        ///  SKEL_R_Finger31 = 0xfa40,
        ///  SKEL_R_Finger32 = 0xfa41,
        ///  SKEL_R_Finger40 = 0xe5f6,
        ///  SKEL_R_Finger41 = 0xfa50,
        ///  SKEL_R_Finger42 = 0xfa51,
        ///  PH_R_Hand = 0x6f06,
        ///    IK_R_Hand = 0x188e,
        ///    RB_R_ForeArmRoll = 0xab22,
        ///     RB_R_ArmRoll = 0x90ff,
        ///     MH_R_Elbow = 0xbb0,
        ///    SKEL_Neck_1 = 0x9995,
        ///  SKEL_Head = 0x796e,
        ///    IK_Head = 0x322c,
        ///  FACIAL_facialRoot = 0xfe2c,
        ///    FB_L_Brow_Out_000 = 0xe3db,
        ///    FB_L_Lid_Upper_000 = 0xb2b6,
        ///   FB_L_Eye_000 = 0x62ac,
        ///     FB_L_CheekBone_000 = 0x542e,
        ///   FB_L_Lip_Corner_000 = 0x74ac,
        ///  FB_R_Lid_Upper_000 = 0xaa10,
        ///   FB_R_Eye_000 = 0x6b52,
        ///     FB_R_CheekBone_000 = 0x4b88,
        ///   FB_R_Brow_Out_000 = 0x54c,
        ///     FB_R_Lip_Corner_000 = 0x2ba6,
        ///  FB_Brow_Centre_000 = 0x9149,
        ///   FB_UpperLipRoot_000 = 0x4ed2,
        ///  FB_UpperLip_000 = 0xf18f,
        ///  FB_L_Lip_Top_000 = 0x4f37,
        ///     FB_R_Lip_Top_000 = 0x4537,
        ///     FB_Jaw_000 = 0xb4a0,
        ///   FB_LowerLipRoot_000 = 0x4324,
        ///  FB_LowerLip_000 = 0x508f,
        ///  FB_L_Lip_Bot_000 = 0xb93b,
        ///     FB_R_Lip_Bot_000 = 0xc33b,
        ///     FB_Tongue_000 = 0xb987,
        ///    RB_Neck_1 = 0x8b93,
        ///    IK_Root = 0xdd1c
        ///
        /// > Ped ped
        /// > int boneId
        ///
        /// </summary>
        GET_PED_BONE_INDEX = 0x3F428D08BE5AAE31,
        /// <summary>
        /// Values look to be between 0.0 and 1.0
        /// From decompiled scripts: 0.0, 0.6, 0.65, 0.8, 1.0
        /// 
        /// You are correct, just looked in IDA it breaks from the function if it's less than 0.0f or greater than 1.0f.
        ///
        /// > Ped ped
        /// > float value
        ///
        /// </summary>
        SET_PED_ENVEFF_SCALE = 0xBF29516833893561,
        /// <summary>
        /// Something related to the environmental effects natives.
        /// In the "agency_heist3b" script, p1 - p3 are always under 100 - usually they are {87, 81, 68}. If SET_PED_ENVEFF_SCALE is set to 0.65 (instead of the usual 1.0), they use {74, 69, 60}
        ///
        /// > Ped ped
        /// > int p1
        /// > int p2
        /// > int p3
        ///
        /// </summary>
        SET_PED_ENVEFF_COLOR_MODULATOR = 0xD69411AA0CEBF9E9,
        /// <summary>
        /// intensity: 0.0f - 1.0f
        /// 
        /// This native sets the emissive intensity for the given ped. It is used for different 'glow' levels on illuminated clothing.
        ///
        /// > Ped ped
        /// > float intensity
        ///
        /// </summary>
        _SET_PED_EMISSIVE_INTENSITY = 0x4E90D746056E273D,
        /// <summary>
        /// Use 0x4E90D746056E273D to set the illuminated clothing glow intensity for a specific ped.
        /// Returns a float between 0.0 and 1.0 representing the current illuminated clothing glow intensity.
        ///
        /// > Ped ped
        ///
        /// </summary>
        _GET_PED_EMISSIVE_INTENSITY = 0x1461B28A06717D68,
        /// <summary>
        /// Enable/disable ped shadow (ambient occlusion). https://gfycat.com/thankfulesteemedgecko
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        SET_PED_AO_BLOB_RENDERING = 0x2B5AA717A181FB4C,
        /// <summary>
        /// p6 always 2 (but it doesnt seem to matter...)
        /// 
        /// roll and pitch 0
        /// yaw to Ped.rotation
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float roll
        /// > float pitch
        /// > float yaw
        /// > int p6
        ///
        /// </summary>
        CREATE_SYNCHRONIZED_SCENE = 0x8C18E0F9080ADD73,
        /// <summary>
        /// Returns true if a synchronized scene is running
        ///
        /// > int sceneId
        ///
        /// </summary>
        IS_SYNCHRONIZED_SCENE_RUNNING = 0x25D39B935A038A26,
        /// <summary>
        /// Regarding p2, p3 and p4: Most common is 0, 0, 0); followed by 0, 1, 0); and 1, 1, 0); in R* scripts. p4 is very rarely something other than 0.
        /// 
        /// enum eMotionState // 0x92A659FE
        /// {
        /// 	MotionState_None = 0xEE717723,
        /// 	MotionState_Idle = 0x9072A713,
        /// 	MotionState_Walk = 0xD827C3DB,
        /// 	MotionState_Run = 0xFFF7E7A4,
        /// 	MotionState_Sprint = 0xBD8817DB,
        /// 	MotionState_Crouch_Idle = 0x43FB099E,
        /// 	MotionState_Crouch_Walk = 0x08C31A98,
        /// 	MotionState_Crouch_Run = 0x3593CF09,
        /// 	MotionState_DoNothing = 0x0EC17E58,
        /// 	MotionState_AnimatedVelocity = 0x551AAC43,
        /// 	MotionState_InVehicle = 0x94D9D58D,
        /// 	MotionState_Aiming = 0x3F67C6AF,
        /// 	MotionState_Diving_Idle = 0x4848CDED,
        /// 	MotionState_Diving_Swim = 0x916E828C,
        /// 	MotionState_Swimming_TreadWater = 0xD1BF11C7,
        /// 	MotionState_Dead = 0x0DBB071C,
        /// 	MotionState_Stealth_Idle = 0x422D7A25,
        /// 	MotionState_Stealth_Walk = 0x042AB6A2,
        /// 	MotionState_Stealth_Run = 0xFB0B79E1,
        /// 	MotionState_Parachuting = 0xBAC0F10B,
        /// 	MotionState_ActionMode_Idle = 0xDA40A0DC,
        /// 	MotionState_ActionMode_Walk = 0xD2905EA7,
        /// 	MotionState_ActionMode_Run = 0x31BADE14,
        /// 	MotionState_Jetpack = 0x535E6A5E
        /// };
        ///
        /// > Ped ped
        /// > Hash motionStateHash
        /// > BOOL p2
        /// > int p3
        /// > BOOL p4
        ///
        /// </summary>
        FORCE_PED_MOTION_STATE = 0xF28965D04F570DCA,
        /// <summary>
        /// Min: 0.00
        /// Max: 10.00
        /// 
        /// Can be used in combo with fast run cheat.
        /// 
        /// When value is set to 10.00:
        /// Sprinting without fast run cheat: 66 m/s
        /// Sprinting with fast run cheat: 77 m/s
        /// 
        /// Needs to be looped!
        /// 
        /// Note: According to IDA for the Xbox360 xex, when they check bgt they seem to have the min to 0.0f, but the max set to 1.15f not 10.0f.
        ///
        /// > Ped ped
        /// > float value
        ///
        /// </summary>
        SET_PED_MOVE_RATE_OVERRIDE = 0x085BF80FA50A39D1,
        /// <summary>
        /// Returns size of array, passed into the second variable.
        /// 
        /// See below for usage information.
        /// 
        /// This function actually requires a struct, where the first value is the maximum number of elements to return.  Here is a sample of how I was able to get it to work correctly, without yet knowing the struct format.
        /// 
        /// //Setup the array
        ///  const int numElements = 10;
        ///    const int arrSize = numElements * 2 + 2;
        ///   Any veh[arrSize];
        ///  //0 index is the size of the array
        ///     veh[0] = numElements;
        /// 
        ///    int count = PED::GET_PED_NEARBY_VEHICLES(PLAYER::PLAYER_PED_ID(), veh);
        /// 
        ///  if (veh != NULL)
        ///   {
        ///      //Simple loop to go through results
        ///        for (int i = 0; i < count; i++)
        ///         {
        ///          int offsettedID = i * 2 + 2;
        ///           //Make sure it exists
        ///          if (veh[offsettedID] != NULL && ENTITY::DOES_ENTITY_EXIST(veh[offsettedID]))
        ///           {
        ///              //Do something
        ///             }
        ///      }
        ///  }  
        ///
        /// > Ped ped
        /// > int* sizeAndVehs
        ///
        /// </summary>
        GET_PED_NEARBY_VEHICLES = 0xCFF869CBFA210D82,
        /// <summary>
        /// sizeAndPeds - is a pointer to an array. The array is filled with peds found nearby the ped supplied to the first argument.
        /// ignore - ped type to ignore
        /// 
        /// Return value is the number of peds found and added to the array passed.
        /// 
        /// -----------------------------------
        /// 
        /// To make this work in most menu bases at least in C++ do it like so,
        /// 
        ///  Formatted Example: pastebin.com/D8an9wwp
        /// 
        /// -----------------------------------
        /// 
        /// Example: gtaforums.com/topic/789788-function-args-to-pedget-ped-nearby-peds/?p=1067386687
        ///
        /// > Ped ped
        /// > int* sizeAndPeds
        /// > int ignore
        ///
        /// </summary>
        GET_PED_NEARBY_PEDS = 0x23F8F5FC7E8C4A6B,
        /// <summary>
        /// p2 is usually -1 in the scripts. action is either 0 or "DEFAULT_ACTION".
        ///
        /// > Ped ped
        /// > BOOL p1
        /// > int p2
        /// > const char* action
        ///
        /// </summary>
        SET_PED_USING_ACTION_MODE = 0xD75ACCF5E0FB5367,
        /// <summary>
        /// name: "MP_FEMALE_ACTION" found multiple times in the b617d scripts.
        ///
        /// > Ped ped
        /// > const char* name
        ///
        /// </summary>
        SET_MOVEMENT_MODE_OVERRIDE = 0x781DE8FA214E87D2,
        /// <summary>
        /// Overrides the ped's collision capsule radius for the current tick.
        /// Must be called every tick to be effective.
        /// 
        /// Setting this to 0.001 will allow warping through some objects.
        ///
        /// > Ped ped
        /// > float value
        ///
        /// </summary>
        SET_PED_CAPSULE = 0x364DF566EC833DE2,
        /// <summary>
        /// gtaforums.com/topic/885580-ped-headshotmugshot-txd/
        ///
        /// > Ped ped
        ///
        /// </summary>
        REGISTER_PEDHEADSHOT = 0x4462658788425076,
        /// <summary>
        /// Similar to REGISTER_PEDHEADSHOT but creates a transparent background instead of black. Example: https://i.imgur.com/iHz8ztn.png
        ///
        /// > Ped ped
        ///
        /// </summary>
        REGISTER_PEDHEADSHOT_TRANSPARENT = 0x953563CE563143AF,
        /// <summary>
        /// gtaforums.com/topic/885580-ped-headshotmugshot-txd/
        ///
        /// > int id
        ///
        /// </summary>
        UNREGISTER_PEDHEADSHOT = 0x96B1361D9B24C2FF,
        /// <summary>
        /// gtaforums.com/topic/885580-ped-headshotmugshot-txd/
        ///
        /// > int id
        ///
        /// </summary>
        IS_PEDHEADSHOT_VALID = 0xA0A9668F158129A2,
        /// <summary>
        /// gtaforums.com/topic/885580-ped-headshotmugshot-txd/
        ///
        /// > int id
        ///
        /// </summary>
        IS_PEDHEADSHOT_READY = 0x7085228842B13A67,
        /// <summary>
        /// gtaforums.com/topic/885580-ped-headshotmugshot-txd/
        ///
        /// > int id
        ///
        /// </summary>
        GET_PEDHEADSHOT_TXD_STRING = 0xDB4EACD4AD0A5D6B,
        /// <summary>
        /// Toggles config flag CPED_CONFIG_FLAG_CanPlayInCarIdles.
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_PED_CAN_PLAY_IN_CAR_IDLES = 0x820E9892A77E97CD,
        /// <summary>
        /// Min and max are usually 100.0 and 200.0
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float min
        /// > float max
        ///
        /// </summary>
        SET_POP_CONTROL_SPHERE_THIS_FRAME = 0xD8C3BE3EE94CAF2D,
        /// <summary>
        /// SET_A*
        ///
        /// > float multiplier
        ///
        /// </summary>
        _0x87DDEB611B329A9C = 0x87DDEB611B329A9C,
        /// <summary>
        /// SET_PED_ALLOW*
        /// 
        /// toggle was always false except in one instance (b678).
        /// 
        /// The one time this is set to true seems to do with when you fail the mission.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _0xF2BEBCDFAFDAA19E = 0xF2BEBCDFAFDAA19E,
        /// <summary>
        /// Related to Peds dropping pickup_health_snack; p0 is a value between [0.0, 1.0] that corresponds to drop rate
        ///
        /// > float p0
        /// > Any p1
        ///
        /// </summary>
        _0xFF4803BC019852D9 = 0xFF4803BC019852D9,
        /// <summary>
        /// SET_PED_*
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        _0xAFC976FD0580C7B3 = 0xAFC976FD0580C7B3,
        /// <summary>
        /// SET_PED_*
        /// 
        /// Has most likely to do with some shooting attributes as it sets the float which is in the same range as shootRate.
        ///
        /// > Ped ped
        /// > float unk
        ///
        /// </summary>
        _0xEC4B4B3B9908052A = 0xEC4B4B3B9908052A,
        /// <summary>
        /// Does something with ped relationships
        ///
        /// > Ped ped
        /// > Any p1
        /// > float p2
        /// > Hash hash
        /// > Any p4
        /// > Any p5
        ///
        /// </summary>
        _0xAD27D957598E49E9 = 0xAD27D957598E49E9,
        /// <summary>
        /// This native does absolutely nothing, just a nullsub
        ///
        /// > Any p0
        /// > Any p1
        ///
        /// </summary>
        _0xB282749D5E028163 = 0xB282749D5E028163,
        /// <summary>
        /// SET_PED_ALLOW*
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        _0x49E50BDB8BA4DAB2 = 0x49E50BDB8BA4DAB2,
        /// <summary>
        /// CLEAR_PED_*
        ///
        /// > Ped ped
        ///
        /// </summary>
        _0x80054D7FCC70EEC6 = 0x80054D7FCC70EEC6,
        /// <summary>
        /// GET_*
        ///
        /// > Any p0
        ///
        /// </summary>
        _0x1E77FA7A62EE6C4C = 0x1E77FA7A62EE6C4C,
        /// <summary>
        /// GET_*
        ///
        /// > Any p0
        ///
        /// </summary>
        _0xF033419D1B81FAE8 = 0xF033419D1B81FAE8,
        /// <summary>
        /// p1 was always 1 (true).
        /// 
        /// Kicks the ped from the current vehicle and keeps the rendering-focus on this ped (also disables its collision). If doing this for your player ped, you'll still be able to drive the vehicle.
        /// 
        /// Actual name begins with 'S'
        ///
        /// > Ped ped
        /// > BOOL p1
        ///
        /// </summary>
        _0xF9ACF4A08098EA25 = 0xF9ACF4A08098EA25,
        /// <summary>
        /// Only appears in lamar1 script.
        ///
        /// > Ped ped
        /// > int p1
        ///
        /// </summary>
        _0x1A330D297AAC6BC1 = 0x1A330D297AAC6BC1,
        /// <summary>
        /// SET_PED_STE*
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        _0x2016C603D6B8987C = 0x2016C603D6B8987C,
        /// <summary>
        /// REQUEST_*
        ///
        /// > Ped ped
        /// > BOOL p1
        ///
        /// </summary>
        _0xCD018C591F94CB43 = 0xCD018C591F94CB43,
        /// <summary>
        /// REQUEST_*
        ///
        /// > Ped ped
        /// > BOOL p1
        ///
        /// </summary>
        _0x75BA1CB3B7D40CAF = 0x75BA1CB3B7D40CAF,
        /// <summary>
        /// GET_*
        ///
        /// > Ped ped
        ///
        /// </summary>
        _0x511F1A683387C7E2 = 0x511F1A683387C7E2,
        /// <summary>
        /// In agency_heist3b.c4, its like this 90% of the time:
        /// 
        /// PED::_110F526AB784111F(ped, 0.099);
        /// PED::SET_PED_ENVEFF_SCALE(ped, 1.0);
        /// PED::_D69411AA0CEBF9E9(ped, 87, 81, 68);
        /// PED::SET_ENABLE_PED_ENVEFF_SCALE(ped, 1);
        /// 
        /// and its like this 10% of the time:
        /// 
        /// PED::_110F526AB784111F(ped, 0.2);
        /// PED::SET_PED_ENVEFF_SCALE(ped, 0.65);
        /// PED::_D69411AA0CEBF9E9(ped, 74, 69, 60);
        /// PED::SET_ENABLE_PED_ENVEFF_SCALE(ped, 1);
        ///
        /// > Ped ped
        /// > float p1
        ///
        /// </summary>
        _0x110F526AB784111F = 0x110F526AB784111F,
        /// <summary>
        /// This native does absolutely nothing, just a nullsub
        ///
        /// > Any p0
        /// > Any p1
        ///
        /// </summary>
        _0x1216E0BFA72CC703 = 0x1216E0BFA72CC703,
        /// <summary>
        /// Checks if the specified unknown flag is set in the ped's model.
        /// The engine itself seems to exclusively check for flags 1 and 4 (Might be inlined code of the check that checks for other flags).
        /// Game scripts exclusively check for flags 1 and 4.
        ///
        /// > Ped ped
        /// > int flag
        ///
        /// </summary>
        _0x46B05BCAE43856B0 = 0x46B05BCAE43856B0,
        /// <summary>
        /// FORCE_*
        ///
        /// > Ped ped
        ///
        /// </summary>
        _0xED3C76ADFA6D07C4 = 0xED3C76ADFA6D07C4,
        /// <summary>
        /// SET_A*
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        _0xFAB944D4D481ACCB = 0xFAB944D4D481ACCB,
        CLONE_PED = 0xEF29A16337FACADB,
        _CLONE_PED_EX = 0x668FD40BCBA5DE48,
        _CLONE_PED_TO_TARGET_EX = 0x148B08C2D2ACB884,
        IS_PED_IN_MODEL = 0x796D90EFB19AA332,
        IS_CONVERSATION_PED_DEAD = 0xE0A0AEC214B1FABA,
        IS_PED_AIMING_FROM_COVER = 0x3998B1276A3300E5,
        SET_PED_DESIRED_HEADING = 0xAA5A7ECE2AA8FE70,
        _FREEZE_PED_CAMERA_ROTATION = 0xFF287323B0E2C69A,
        IS_PED_SHOOTING_IN_AREA = 0x7E9DFE24AC1E58EF,
        IS_ANY_PED_SHOOTING_IN_AREA = 0xA0D3D71EA1086C55,
        GET_PED_ACCURACY = 0x37F4AD56ECBC0CD6,
        IS_PED_MODEL = 0xC9D55B1A358A5BF7,
        SET_PED_ALLOW_VEHICLES_OVERRIDE = 0x3C028C636A414ED9,
        CAN_CREATE_RANDOM_PED = 0x3E8349C08E4B82E4,
        CREATE_RANDOM_PED_AS_DRIVER = 0x9B62392B474F44A0,
        CAN_CREATE_RANDOM_DRIVER = 0xB8EB95E5B4E56978,
        CAN_CREATE_RANDOM_BIKE_RIDER = 0xEACEEDA81751915C,
        SET_PED_MOVE_ANIMS_BLEND_OUT = 0x9E8C908F41584ECD,
        SET_PED_CAN_BE_DRAGGED_OUT = 0xC1670E958EEE24E5,
        SET_PED_DENSITY_MULTIPLIER_THIS_FRAME = 0x95E3D6257B166CF2,
        SET_SCENARIO_PED_DENSITY_MULTIPLIER_THIS_FRAME = 0x7A556143A1C03898,
        SET_SCRIPTED_CONVERSION_COORD_THIS_FRAME = 0x5086C7843552CF85,
        CLEAR_PED_NON_CREATION_AREA = 0x2E05208086BA0651,
        INSTANTLY_FILL_PED_POPULATION = 0x4759CC730F947C81,
        IS_PED_ON_SPECIFIC_VEHICLE = 0xEC5F66E459AF3BB2,
        GET_PED_MONEY = 0x3F69145BBA87BAE7,
        SET_AMBIENT_PEDS_DROP_MONEY = 0x6B0E6172C9A4D902,
        IS_PED_ON_FOOT = 0x01FEE67DB37F59B2,
        IS_PED_ON_ANY_BIKE = 0x94495889E22C6479,
        IS_PED_PLANTING_BOMB = 0xC70B5FAE151982D8,
        GET_DEAD_PED_PICKUP_COORDS = 0xCD5003B097200F36,
        IS_PED_IN_ANY_BOAT = 0x2E0E1C2B4F6CB339,
        IS_PED_IN_ANY_SUB = 0xFBFC01CCFB35D99E,
        IS_PED_IN_ANY_HELI = 0x298B91AE825E5705,
        IS_PED_IN_ANY_PLANE = 0x5FFF4CFC74D8FB80,
        IS_PED_IN_FLYING_VEHICLE = 0x9134873537FA419C,
        SET_PED_DIES_IN_WATER = 0x56CEF0AC79073BDE,
        SET_PED_DIES_IN_SINKING_VEHICLE = 0xD718A22995E2B4BC,
        GET_PED_ARMOUR = 0x9483AF821605B1D8,
        SET_PED_STAY_IN_VEHICLE_WHEN_JACKED = 0xEDF4079F9D54C9A1,
        SET_PED_CAN_BE_SHOT_IN_VEHICLE = 0xC7EF1BA83230BA07,
        GET_PED_LAST_DAMAGE_BONE = 0xD75960F6BD9EA49C,
        CLEAR_PED_LAST_DAMAGE_BONE = 0x8EF6B7AC68E2F01B,
        SET_AI_WEAPON_DAMAGE_MODIFIER = 0x1B1E2A40A65B8521,
        RESET_AI_WEAPON_DAMAGE_MODIFIER = 0xEA16670E7BA4743C,
        SET_AI_MELEE_WEAPON_DAMAGE_MODIFIER = 0x66460DEDDD417254,
        RESET_AI_MELEE_WEAPON_DAMAGE_MODIFIER = 0x46E56A7CD1D63C3F,
        SET_PED_CAN_BE_TARGETTED = 0x63F58F7C80513AAD,
        SET_PED_CAN_BE_TARGETTED_BY_TEAM = 0xBF1CA77833E58F2C,
        SET_PED_CAN_BE_TARGETTED_BY_PLAYER = 0x66B57B72E0836A76,
        IS_PED_IN_ANY_POLICE_VEHICLE = 0x0BD04E29640C9C12,
        FORCE_PED_TO_OPEN_PARACHUTE = 0x16E42E800B472221,
        IS_PED_IN_PARACHUTE_FREE_FALL = 0x7DCE8BDA0F1C1200,
        IS_PED_FALLING = 0xFB92A102F1C4DFA3,
        IS_PED_JUMPING = 0xCEDABC5900A0BF97,
        IS_PED_CLIMBING = 0x53E8CB4F48BFE623,
        IS_PED_VAULTING = 0x117C70D1F5730B5E,
        IS_PED_DIVING = 0x5527B8246FEF9B11,
        IS_PED_JUMPING_OUT_OF_VEHICLE = 0x433DDFFE2044B636,
        SET_PED_PARACHUTE_TINT_INDEX = 0x333FC8DB079B7186,
        GET_PED_PARACHUTE_TINT_INDEX = 0xEAF5F7E5AE7C6C9D,
        SET_PED_RESERVE_PARACHUTE_TINT_INDEX = 0xE88DA0751C22A2AD,
        CREATE_PARACHUTE_BAG_OBJECT = 0x8C4F3BF23B6237DB,
        IS_PED_DUCKING = 0xD125AE748725C6BC,
        IS_PED_IN_ANY_TAXI = 0x6E575D6A898AB852,
        SET_PED_ID_RANGE = 0xF107E836A70DCE05,
        SET_PED_HIGHLY_PERCEPTIVE = 0x52D59AB61DDC05DD,
        SET_PED_SEEING_RANGE = 0xF29CF591C4BF6CEE,
        SET_PED_HEARING_RANGE = 0x33A8F7F7D5F7F33C,
        SET_PED_VISUAL_FIELD_MIN_ANGLE = 0x2DB492222FB21E26,
        SET_PED_VISUAL_FIELD_MAX_ANGLE = 0x70793BDCA1E854D4,
        SET_PED_VISUAL_FIELD_PERIPHERAL_RANGE = 0x9C74B0BC831B753A,
        SET_PED_VISUAL_FIELD_CENTER_ANGLE = 0x3B6405E8AB34A907,
        _GET_PED_VISUAL_FIELD_CENTER_ANGLE = 0xEF2C71A32CAD5FBD,
        SET_PED_AS_GROUP_LEADER = 0x2A7819605465FBCE,
        SET_PED_AS_GROUP_MEMBER = 0x9F3480FE65DB31B5,
        REMOVE_GROUP = 0x8EB2F69076AF7053,
        REMOVE_PED_FROM_GROUP = 0xED74007FFB146BC2,
        IS_PED_GROUP_MEMBER = 0x9BB01E3834671191,
        IS_PED_HANGING_ON_TO_VEHICLE = 0x1C86D8AEF8254B78,
        IS_PED_PRONE = 0xD6A86331A537A7B9,
        _GET_PED_TASK_COMBAT_TARGET = 0x32C27A11307B01CC,
        CAN_PED_IN_COMBAT_SEE_TARGET = 0xEAD42DE3610D0721,
        IS_PED_DOING_DRIVEBY = 0xB2C086CC1BF8F2BF,
        IS_PED_JACKING = 0x4AE4FF911DFB61DA,
        IS_PED_BEING_JACKED = 0x9A497FE2DF198913,
        GET_PEDS_JACKER = 0x9B128DC36C1E04CF,
        GET_JACK_TARGET = 0x5486A79D9FBD342D,
        IS_PED_FLEEING = 0xBBCCE00B381F8482,
        IS_PED_IN_COVER_FACING_LEFT = 0x845333B3150583AB,
        IS_PED_IN_HIGH_COVER = 0x6A03BF943D767C93,
        IS_PED_GOING_INTO_COVER = 0x9F65DBC537E59AD5,
        GET_SEAT_PED_IS_TRYING_TO_ENTER = 0x6F4C85ACD641BCD2,
        GET_VEHICLE_PED_IS_TRYING_TO_ENTER = 0x814FA8BE5449445D,
        GET_PED_TIME_OF_DEATH = 0x1E98817B311AE98A,
        SET_PED_RELATIONSHIP_GROUP_DEFAULT_HASH = 0xADB3F206518799E8,
        SET_PED_RELATIONSHIP_GROUP_HASH = 0xC80A74AC829DDD92,
        REMOVE_RELATIONSHIP_GROUP = 0xB6BA2444AB393DA2,
        _DOES_RELATIONSHIP_GROUP_EXIST = 0xCC6E3B6BB69501F1,
        GET_PED_RELATIONSHIP_GROUP_DEFAULT_HASH = 0x42FDD0F017B1E38E,
        GET_PED_RELATIONSHIP_GROUP_HASH = 0x7DBDD04862D95F04,
        _SET_RELATIONSHIP_GROUP_DONT_AFFECT_WANTED_LEVEL = 0x5615E0C5EB2BC6E2,
        SET_PED_CAN_BE_TARGETED_WITHOUT_LOS = 0x4328652AE5769C71,
        SET_PED_TO_INFORM_RESPECTED_FRIENDS = 0x112942C6E708F70B,
        IS_PED_RESPONDING_TO_EVENT = 0x625B774D75C87068,
        _GET_PED_EVENT_DATA = 0xBA656A3BB01BDEA3,
        DOES_GROUP_EXIST = 0x7C6B0C22F9F40BBE,
        IS_PED_IN_GROUP = 0x5891CAC5D4ACFF74,
        GET_PLAYER_PED_IS_FOLLOWING = 0x6A3975DEA89F9A17,
        SET_GROUP_FORMATION_SPACING = 0x1D9D45004C28C916,
        RESET_GROUP_FORMATION_DEFAULT_SPACING = 0x63DAB4CCB3273205,
        GET_VEHICLE_PED_IS_ENTERING = 0xF92691AED837A5FC,
        SET_PED_ALLOWED_TO_DUCK = 0xDA1F1B7BE1A8766F,
        SET_PED_NEVER_LEAVES_GROUP = 0x3DBFC55D5C9BB447,
        GET_PED_MAX_HEALTH = 0x4700A416E8324EF3,
        SET_PED_MAX_TIME_IN_WATER = 0x43C851690662113D,
        SET_PED_MAX_TIME_UNDERWATER = 0x6BA428C528D9E522,
        CLEAR_ALL_PED_VEHICLE_FORCED_SEAT_USAGE = 0xE6CA85E7259CE16B,
        CAN_KNOCK_PED_OFF_VEHICLE = 0x51AC07A44D4F5B8A,
        KNOCK_PED_OFF_VEHICLE = 0x45BBCBA77C29A841,
        SET_PED_COORDS_NO_GANG = 0x87052FE446E07247,
        GET_PED_AS_GROUP_LEADER = 0x5CCE68DBD5FE93EC,
        SET_PED_KEEP_TASK = 0x971D38760FBC02EF,
        IS_PED_SWIMMING = 0x9DE327631295B4C2,
        IS_PED_SWIMMING_UNDER_WATER = 0xC024869A53992F34,
        SET_PED_DIES_IN_VEHICLE = 0x2A30922C90C9B42C,
        SET_CREATE_RANDOM_COPS = 0x102E68B2024D536D,
        SET_CREATE_RANDOM_COPS_NOT_ON_SCENARIOS = 0x8A4986851C4EF6E7,
        SET_CREATE_RANDOM_COPS_ON_SCENARIOS = 0x444CB7D7DBE6973D,
        CAN_CREATE_RANDOM_COPS = 0x5EE2CAFF7F17770D,
        SET_PED_AS_ENEMY = 0x02A0C9720B854BFA,
        SET_PED_CAN_SMASH_GLASS = 0x1CCE141467FF42A2,
        IS_PED_IN_ANY_TRAIN = 0x6F972C1AB75A1ED0,
        IS_PED_GETTING_INTO_A_VEHICLE = 0xBB062B2B5722478E,
        IS_PED_TRYING_TO_ENTER_A_LOCKED_VEHICLE = 0x44D28D5DDFE5F68C,
        SET_PED_GET_OUT_UPSIDE_DOWN_VEHICLE = 0xBC0ED94165A48BC2,
        RESET_PED_STRAFE_CLIPSET = 0x20510814175EA477,
        SET_PED_WEAPON_MOVEMENT_CLIPSET = 0x2622E35B77D3ACA2,
        RESET_PED_WEAPON_MOVEMENT_CLIPSET = 0x97B0DB5B4AA74E77,
        SET_PED_DRIVE_BY_CLIPSET_OVERRIDE = 0xED34AB6C5CB36520,
        CLEAR_PED_DRIVE_BY_CLIPSET_OVERRIDE = 0x4AFE3690D7E0B5AC,
        RESET_PED_IN_VEHICLE_CONTEXT = 0x22EF8FF8778030EB,
        CLEAR_PED_ALTERNATE_WALK_ANIM = 0x8844BBFCE30AA9E9,
        CLEAR_PED_ALTERNATE_MOVEMENT_ANIM = 0xD8D19675ED5FBDCE,
        SET_PED_BLEND_FROM_PARENTS = 0x137BBD05230DB22D,
        _GET_NUM_MAKEUP_COLORS = 0xD1F7CA1535D22818,
        _IS_PED_HAIR_COLOR_VALID_2 = 0xED6D8E27A43B8CDE,
        _IS_PED_LIPSTICK_COLOR_VALID_2 = 0x3E802F11FBE27674,
        _IS_PED_BLUSH_COLOR_VALID_2 = 0xF41B5D290C99A3D6,
        _IS_PED_HAIR_COLOR_VALID = 0xE0D36E5D9E99CC21,
        _IS_PED_LIPSTICK_COLOR_VALID = 0x0525A2C2562F3CD4,
        _IS_PED_BLUSH_COLOR_VALID = 0x604E810189EE3A59,
        _IS_PED_BODY_BLEMISH_VALID = 0x09E7ECA981D9B210,
        HAS_PED_HEAD_BLEND_FINISHED = 0x654CD0A825161131,
        FINALIZE_HEAD_BLEND = 0x4668D80430D6C299,
        DISABLE_HEAD_BLEND_PALETTE_COLOR = 0xA21C118553BBDF02,
        HAS_PED_PRELOAD_VARIATION_DATA_FINISHED = 0x66680A92700F43DF,
        RELEASE_PED_PRELOAD_VARIATION_DATA = 0x5AAB586FFEC0FD96,
        HAS_PED_PRELOAD_PROP_DATA_FINISHED = 0x784002A632822099,
        RELEASE_PED_PRELOAD_PROP_DATA = 0xF79F9DEF0AADE61A,
        DROP_AMBIENT_PROP = 0xAFF4710E2A0A6C12,
        CLEAR_PED_PARACHUTE_PACK_VARIATION = 0x1280804F7CFD2D6C,
        SET_PED_BOUNDS_ORIENTATION = 0x4F5F651ACCC9C4CF,
        IS_PED_RUNNING_RAGDOLL_TASK = 0xE3B6097CC25AA69E,
        SET_PED_RAGDOLL_FORCE_FALL = 0x01F6594B923B9251,
        RESET_PED_RAGDOLL_TIMER = 0x9FA4664CF62E47E8,
        SET_PED_CAN_RAGDOLL = 0xB128377056A54E2A,
        IS_PED_RUNNING_MELEE_TASK = 0xD1871251F3B5ACD7,
        IS_PED_RUNNING_MOBILE_PHONE_TASK = 0x2AFE52F782F25775,
        IS_MOBILE_PHONE_TO_PED_EAR = 0xA3F3564A5B3646C0,
        SET_PED_ANGLED_DEFENSIVE_AREA = 0xC7F76DF27A5045A1,
        SET_PED_SPHERE_DEFENSIVE_AREA = 0x9D3151A373974804,
        SET_PED_DEFENSIVE_SPHERE_ATTACHED_TO_PED = 0xF9B8F91AAD3B953E,
        SET_PED_DEFENSIVE_SPHERE_ATTACHED_TO_VEHICLE = 0xE4723DB6E736CCFF,
        SET_PED_DEFENSIVE_AREA_ATTACHED_TO_PED = 0x4EF47FE21698A8B6,
        SET_PED_DEFENSIVE_AREA_DIRECTION = 0x413C6C763A4AFFAD,
        GET_PED_DEFENSIVE_AREA_POSITION = 0x3C06B8786DD94CD1,
        IS_PED_DEFENSIVE_AREA_ACTIVE = 0xBA63D9FE45412247,
        SET_PED_PREFERRED_COVER_SET = 0x8421EB4DA7E391B9,
        REMOVE_PED_PREFERRED_COVER_SET = 0xFDDB234CF74073D9,
        SET_PED_DIES_WHEN_INJURED = 0x5BA7919BED300023,
        SET_PED_ENABLE_WEAPON_BLOCKING = 0x97A790315D3831FD,
        RESET_PED_VISIBLE_DAMAGE = 0x3AC1F7B898F30C05,
        APPLY_PED_BLOOD_DAMAGE_BY_ZONE = 0x816F6981C60BF53B,
        APPLY_PED_BLOOD_BY_ZONE = 0x3311E47B91EDCBBC,
        APPLY_PED_BLOOD_SPECIFIC = 0xEF0D582CBF2D9B0F,
        CLEAR_PED_BLOOD_DAMAGE = 0x8FE22675A5A45817,
        HIDE_PED_BLOOD_DAMAGE_BY_ZONE = 0x62AB793144DE75DC,
        GET_PED_DECORATIONS_STATE = 0x71EAB450D86954A1,
        CLEAR_PED_ENV_DIRT = 0x6585D955A68452A5,
        CLEAR_PED_DECORATIONS = 0x0E5173C163976E38,
        CLEAR_PED_DECORATIONS_LEAVE_SCARS = 0xE3B27E70CEAB9F0C,
        ADD_SCENARIO_BLOCKING_AREA = 0x1B5C85C612E5256E,
        REMOVE_SCENARIO_BLOCKING_AREAS = 0xD37401D78A929A49,
        REMOVE_SCENARIO_BLOCKING_AREA = 0x31D16B74C6E29D66,
        SET_SCENARIO_PEDS_SPAWN_IN_SPHERE_AREA = 0x28157D43CF600981,
        _DOES_SCENARIO_BLOCKING_AREA_EXIST = 0x8A24B067D175A7BD,
        IS_PED_USING_ANY_SCENARIO = 0x57AB4A3080F85143,
        SET_PED_PANIC_EXIT_SCENARIO = 0xFE07FF6495D52E2A,
        _SET_PED_SHOULD_PLAY_DIRECTED_SCENARIO_EXIT = 0xEC6935EBE0847B90,
        SET_PED_SHOULD_PLAY_NORMAL_SCENARIO_EXIT = 0xA3A9299C4F2ADB98,
        SET_PED_SHOULD_PLAY_IMMEDIATE_SCENARIO_EXIT = 0xF1C03A5352243A30,
        SET_PED_SHOULD_PLAY_FLEE_SCENARIO_EXIT = 0xEEED8FAFEC331A70,
        CLEAR_FACIAL_IDLE_ANIM_OVERRIDE = 0x726256CC1EEB182F,
        SET_PED_CAN_PLAY_GESTURE_ANIMS = 0xBAF20C5432058024,
        _SET_PED_CAN_PLAY_INJURED_ANIMS = 0x33A60D8BDD6E508C,
        SET_PED_CAN_PLAY_AMBIENT_ANIMS = 0x6373D1349925A70E,
        SET_PED_CAN_PLAY_AMBIENT_BASE_ANIMS = 0x0EB0585D15254740,
        SET_PED_CAN_ARM_IK = 0x6C3B4D6D13B4C841,
        SET_PED_CAN_HEAD_IK = 0xC11C18092C5530DC,
        SET_PED_CAN_LEG_IK = 0x73518ECE2485412B,
        SET_PED_CAN_TORSO_IK = 0xF2B7106D37947CE0,
        SET_PED_CAN_TORSO_REACT_IK = 0xF5846EDB26A98A24,
        SET_PED_CAN_USE_AUTO_CONVERSATION_LOOKAT = 0xEC4686EC06434678,
        IS_PED_HEADTRACKING_PED = 0x5CD3CB88A7F8850D,
        IS_PED_HEADTRACKING_ENTITY = 0x813A0A7C9D2E831F,
        SET_PED_CLOTH_PACKAGE_INDEX = 0x78C4E9961DB3EB5B,
        SET_PED_CLOTH_PRONE = 0x82A3D6D9CC2CB8E3,
        GET_PED_RESET_FLAG = 0xAF9E59B1B1FBF2A0,
        SET_PED_GROUP_MEMBER_PASSENGER_INDEX = 0x0BDDB8D9EC6BCF3C,
        SET_PED_CAN_EVASIVE_DIVE = 0x6B7A646C242A7059,
        SET_PED_SHOOTS_AT_COORD = 0x96A05E4FB321B1BA,
        STOP_ANY_PED_MODEL_BEING_SUPPRESSED = 0xB47BD05FA66B40CF,
        SET_PED_CAN_BE_TARGETED_WHEN_INJURED = 0x638C03B0F9878F57,
        SET_PED_GENERATES_DEAD_BODY_EVENTS = 0x7FB17BA2E7DECA5B,
        _BLOCK_PED_DEAD_BODY_SHOCKING_EVENTS = 0xE43A13C9E4CCCBCF,
        SET_PED_CAN_RAGDOLL_FROM_PLAYER_IMPACT = 0xDF993EE5E90ABA25,
        REMOVE_PED_HELMET = 0xA7B2458D0AD6DED8,
        IS_PED_TAKING_OFF_HELMET = 0x14590DDBEDB1EC85,
        SET_PED_HELMET = 0x560A43136EB58105,
        SET_PED_HELMET_FLAG = 0xC0E78D5C2CE3EB25,
        _SET_PED_HELMET_UNK = 0x3F7325574E41B44D,
        _IS_PED_HELMET_UNK = 0xB9496CE47546DB2C,
        SET_PED_HELMET_TEXTURE_INDEX = 0xF1550C4BD22582E2,
        CLEAR_PED_STORED_HAT_PROP = 0x687C0B594907D2E8,
        GET_PED_HELMET_STORED_HAT_PROP_INDEX = 0x451294E859ECC018,
        GET_PED_HELMET_STORED_HAT_TEX_INDEX = 0x9D728C1E12BF5518,
        SET_PED_TO_LOAD_COVER = 0x332B562EEDA62399,
        SET_PED_CAN_PEEK_IN_COVER = 0xC514825C507E3736,
        SET_PED_MOTION_BLUR = 0x0A986918B102B448,
        SET_PED_CAN_SWITCH_WEAPON = 0xED7F7EFE9FABF340,
        SET_PED_DIES_INSTANTLY_IN_WATER = 0xEEB64139BA29A7CF,
        STOP_PED_WEAPON_FIRING_WHEN_DROPPED = 0xC158D28142A34608,
        SET_SCRIPTED_ANIM_SEAT_OFFSET = 0x5917BBA32D06C230,
        IS_PED_PERFORMING_MELEE_ACTION = 0xDCCA191DF9980FD7,
        IS_PED_PERFORMING_STEALTH_KILL = 0xFD4CCDBCC59941B7,
        IS_PED_PERFORMING_DEPENDENT_COMBO_LIMIT = 0xEBD0EDBA5BE957CF,
        IS_PED_BEING_STEALTH_KILLED = 0x863B23EFDE9C5DF2,
        GET_MELEE_TARGET_FOR_PED = 0x18A3E9EE1297FD39,
        WAS_PED_KILLED_BY_STEALTH = 0xF9800AA1A771B000,
        WAS_PED_KILLED_BY_TAKEDOWN = 0x7F08E26039C7347C,
        WAS_PED_KNOCKED_OUT = 0x61767F73EACEED21,
        SET_PED_STEERS_AROUND_PEDS = 0x46F2193B3AD1D891,
        SET_PED_STEERS_AROUND_OBJECTS = 0x1509C089ADC208BF,
        SET_PED_STEERS_AROUND_VEHICLES = 0xEB6FB9D48DDE23EC,
        SET_PED_INCREASED_AVOIDANCE_RADIUS = 0x570389D1C3DE3C6B,
        SET_PED_BLOCKS_PATHING_WHEN_DEAD = 0x576594E8D64375E2,
        IS_ANY_PED_NEAR_POINT = 0x083961498679DC9F,
        FORCE_PED_AI_AND_ANIMATION_UPDATE = 0x2208438012482A1A,
        IS_PED_HEADING_TOWARDS_POSITION = 0xFCF37A457CB96DC0,
        REQUEST_PED_VISIBILITY_TRACKING = 0x7D7A2E43E74E2EB8,
        REQUEST_PED_VEHICLE_VISIBILITY_TRACKING = 0x2BC338A7B21F4608,
        IS_PED_TRACKED = 0x4C5E1F087CD10BB7,
        HAS_PED_RECEIVED_EVENT = 0x8507BCB710FA6DC0,
        CAN_PED_SEE_HATED_PED = 0x6CD5A433374D4CFB,
        GET_PED_RAGDOLL_BONE_INDEX = 0x2057EF813397A772,
        GET_PED_ENVEFF_SCALE = 0x9C14D30395A51A3C,
        SET_ENABLE_PED_ENVEFF_SCALE = 0xD2C5AA0C0E8D0F1E,
        _IS_PED_SHADER_EFFECT_VALID = 0x81AA517FBBA05D39,
        _CREATE_SYNCHRONIZED_SCENE_2 = 0x62EC273D00187DCA,
        SET_SYNCHRONIZED_SCENE_ORIGIN = 0x6ACF6B7225801CD7,
        SET_SYNCHRONIZED_SCENE_PHASE = 0x734292F4F0ABF6D0,
        GET_SYNCHRONIZED_SCENE_PHASE = 0xE4A310B1D7FA73CC,
        SET_SYNCHRONIZED_SCENE_RATE = 0xB6C49F8A5E295A5D,
        GET_SYNCHRONIZED_SCENE_RATE = 0xD80932D577274D40,
        SET_SYNCHRONIZED_SCENE_LOOPED = 0xD9A897A4C6C2974F,
        IS_SYNCHRONIZED_SCENE_LOOPED = 0x62522002E0C391BA,
        SET_SYNCHRONIZED_SCENE_HOLD_LAST_FRAME = 0x394B9CD12435C981,
        IS_SYNCHRONIZED_SCENE_HOLD_LAST_FRAME = 0x7F2F4F13AC5257EF,
        ATTACH_SYNCHRONIZED_SCENE_TO_ENTITY = 0x272E4723B56A3B96,
        DETACH_SYNCHRONIZED_SCENE = 0x6D38F1F04CBB37EA,
        _DISPOSE_SYNCHRONIZED_SCENE = 0xCD9CC7E200A52A6F,
        _GET_PED_CURRENT_MOVEMENT_SPEED = 0xF60165E1D2C5370B,
        SET_PED_MAX_MOVE_BLEND_RATIO = 0x433083750C5E064A,
        SET_PED_MIN_MOVE_BLEND_RATIO = 0x01A898D26E2333DD,
        HAVE_ALL_STREAMING_REQUESTS_COMPLETED = 0x7350823473013C02,
        IS_PED_USING_ACTION_MODE = 0x00E73468D085F745,
        _REGISTER_PEDHEADSHOT_3 = 0xBA8805A1108A2515,
        REQUEST_PEDHEADSHOT_IMG_UPLOAD = 0xF0DAEF2F545BEE25,
        RELEASE_PEDHEADSHOT_IMG_UPLOAD = 0x5D517B27CF6ECD04,
        IS_PEDHEADSHOT_IMG_UPLOAD_AVAILABLE = 0xEBB376779A760AA8,
        HAS_PEDHEADSHOT_IMG_UPLOAD_FAILED = 0x876928DDDFCCC9CD,
        HAS_PEDHEADSHOT_IMG_UPLOAD_SUCCEEDED = 0xE8A169E666CBC541,
        SET_PED_HEATSCALE_OVERRIDE = 0xC1F6EBF9A3D55538,
        DISABLE_PED_HEATSCALE_OVERRIDE = 0x600048C60D5C2C51,
        SPAWNPOINTS_START_SEARCH = 0x2DF9038C90AD5264,
        SPAWNPOINTS_START_SEARCH_IN_ANGLED_AREA = 0xB2AFF10216DEFA2F,
        SPAWNPOINTS_CANCEL_SEARCH = 0xFEE4A5459472A9F8,
        SPAWNPOINTS_IS_SEARCH_ACTIVE = 0x3C67506996001F5E,
        SPAWNPOINTS_IS_SEARCH_COMPLETE = 0xA586FBEB32A53DBB,
        SPAWNPOINTS_IS_SEARCH_FAILED = 0xF445DE8DA80A1792,
        SPAWNPOINTS_GET_NUM_SEARCH_RESULTS = 0xA635C11B8C44AFC2,
        SPAWNPOINTS_GET_SEARCH_RESULT = 0x280C7E3AC7F56E90,
        SPAWNPOINTS_GET_SEARCH_RESULT_FLAGS = 0xB782F8238512BAD5,
        SET_IK_TARGET = 0xC32779C16FCEECD9,
        REQUEST_ACTION_MODE_ASSET = 0x290E2780BB7AA598,
        HAS_ACTION_MODE_ASSET_LOADED = 0xE4B5F4BF2CB24E65,
        REMOVE_ACTION_MODE_ASSET = 0x13E940F88470FA51,
        REQUEST_STEALTH_MODE_ASSET = 0x2A0A62FCDEE16D4F,
        HAS_STEALTH_MODE_ASSET_LOADED = 0xE977FC5B08AF3441,
        REMOVE_STEALTH_MODE_ASSET = 0x9219857D21F0E842,
        SET_PED_LOD_MULTIPLIER = 0xDC2C5C242AAC342B,
        SET_PED_CAN_LOSE_PROPS_ON_DAMAGE = 0xE861D0B05C7662B8,
        SET_FORCE_FOOTSTEP_UPDATE = 0x129466ED55140F8D,
        SET_FORCE_STEP_TYPE = 0xCB968B53FC7F916D,
        IS_ANY_HOSTILE_PED_NEAR_POINT = 0x68772DB2B2526F9F,
        IS_TARGET_PED_IN_PERCEPTION_AREA = 0x06087579E7AA85A9,
        _IS_PED_SWAPPING_WEAPON = 0x3795688A307E1EB6,
        _SET_ENABLE_SCUBA_GEAR_LIGHT = 0xEE2476B9EE4A094F,
        _IS_SCUBA_GEAR_LIGHT_ENABLED = 0x88274C11CF0D866D,
        _CLEAR_FACIAL_CLIPSET_OVERRIDE = 0x637822DC2AFEEBF8,
        _0x5A7F62FDA59759BD = 0x5A7F62FDA59759BD,
        _0x9911F4A24485F653 = 0x9911F4A24485F653,
        _0x2F3C3D9F50681DE4 = 0x2F3C3D9F50681DE4,
        _0x061CB768363D6424 = 0x061CB768363D6424,
        _0xFD325494792302D7 = 0xFD325494792302D7,
        _0x412F1364FA066CFB = 0x412F1364FA066CFB,
        _0x451D05012CCEC234 = 0x451D05012CCEC234,
        _0x2F074C904D85129E = 0x2F074C904D85129E,
        _0x733C87D4CE22BEA2 = 0x733C87D4CE22BEA2,
        _0x5407B7288D0478B7 = 0x5407B7288D0478B7,
        _0x336B3D200AB007CB = 0x336B3D200AB007CB,
        _0x2735233A786B1BEF = 0x2735233A786B1BEF,
        _0x9E30E91FB03A2CAF = 0x9E30E91FB03A2CAF,
        _0xEA9960D07DADCF10 = 0xEA9960D07DADCF10,
        _0xAAA6A3698A69E048 = 0xAAA6A3698A69E048,
        _0xC56FBF2F228E1DAC = 0xC56FBF2F228E1DAC,
        _0xFEC9A3B1820F3331 = 0xFEC9A3B1820F3331,
        _0x03EA03AF85A85CB7 = 0x03EA03AF85A85CB7,
        _0x2B694AFCF64E6994 = 0x2B694AFCF64E6994,
        _0x9A77DFD295E29B09 = 0x9A77DFD295E29B09,
        _0x25361A96E0F7E419 = 0x25361A96E0F7E419,
        _0x425AECF167663F48 = 0x425AECF167663F48,
        _0x5B6010B3CBC29095 = 0x5B6010B3CBC29095,
        _0xCEDA60A74219D064 = 0xCEDA60A74219D064,
        _0xC30BDAEE47256C13 = 0xC30BDAEE47256C13,
        _0xC2EE020F5FB4DB53 = 0xC2EE020F5FB4DB53,
        _0x6647C5F6F5792496 = 0x6647C5F6F5792496,
        _0xA660FAF550EB37E5 = 0xA660FAF550EB37E5,
        _0x3E9679C1DFCF422C = 0x3E9679C1DFCF422C,
        _0xF2385935BFFD4D92 = 0xF2385935BFFD4D92,
        _0xA9B61A329BFDCBEA = 0xA9B61A329BFDCBEA,
        _0xA52D5247A4227E14 = 0xA52D5247A4227E14,
        _0x9C6A6C19B6C0C496 = 0x9C6A6C19B6C0C496,
        _0x2DFC81C9B9608549 = 0x2DFC81C9B9608549,
        _0xE906EC930F5FE7C8 = 0xE906EC930F5FE7C8,
        _0xB8B52E498014F5B0 = 0xB8B52E498014F5B0,
        _0x0B3E35AC043707D9 = 0x0B3E35AC043707D9,
        _0xD33DAA36272177C4 = 0xD33DAA36272177C4,
        _0x711794453CFD692B = 0x711794453CFD692B,
        _0x83A169EABCDB10A2 = 0x83A169EABCDB10A2,
        _0x288DF530C92DAD6F = 0x288DF530C92DAD6F,
        _0x0F62619393661D6E = 0x0F62619393661D6E,
        _0xDFE68C4B787E1BFB = 0xDFE68C4B787E1BFB,
    }
}