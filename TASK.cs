using System;
namespace Hotstar
{
    public enum TASK : ulong
    { 
        /// <summary>
        /// Stand still (?)
        ///
        /// > Ped ped
        /// > int ms
        ///
        /// </summary>
        TASK_PAUSE = 0xE73A266DB0CA9042,
        /// <summary>
        /// Makes the specified ped stand still for (time) milliseconds.
        ///
        /// > Ped ped
        /// > int time
        ///
        /// </summary>
        TASK_STAND_STILL = 0x919BE13EED931959,
        /// <summary>
        /// Definition is wrong. This has 4 parameters (Not sure when they were added. v350 has 2, v678 has 4).
        /// 
        /// v350: Ped ped, bool unused
        /// v678: Ped ped, bool unused, bool flag1, bool flag2
        /// 
        /// flag1 = super jump, flag2 = do nothing if flag1 is false and doubles super jump height if flag1 is true.
        ///
        /// > Ped ped
        /// > BOOL unused
        /// > Any p2
        /// > Any p3
        ///
        /// </summary>
        TASK_JUMP = 0x0AE4086104E067B1,
        /// <summary>
        /// In the scripts, p3 was always -1.
        /// 
        /// p3 seems to be duration or timeout of turn animation.
        /// Also facingPed can be 0 or -1 so ped will just raise hands up.
        ///
        /// > Ped ped
        /// > int duration
        /// > Ped facingPed
        /// > int p3
        /// > BOOL p4
        ///
        /// </summary>
        TASK_HANDS_UP = 0xF2EAB31979A7F910,
        /// <summary>
        /// The given ped will try to open the nearest door to 'seat'.
        /// Example: telling the ped to open the door for the driver seat does not necessarily mean it will open the driver door, it may choose to open the passenger door instead if that one is closer.
        ///
        /// > Ped ped
        /// > Vehicle vehicle
        /// > int timeOut
        /// > int seat
        /// > float speed
        ///
        /// </summary>
        TASK_OPEN_VEHICLE_DOOR = 0x965791A9A488A062,
        /// <summary>
        /// speed 1.0 = walk, 2.0 = run
        /// p5 1 = normal, 3 = teleport to vehicle, 16 = teleport directly into vehicle
        /// p6 is always 0
        /// 
        /// Usage of seat 
        /// -1 = driver
        /// 0 = passenger
        /// 1 = left back seat
        /// 2 = right back seat
        /// 3 = outside left
        /// 4 = outside right
        ///
        /// > Ped ped
        /// > Vehicle vehicle
        /// > int timeout
        /// > int seat
        /// > float speed
        /// > int flag
        /// > Any p6
        ///
        /// </summary>
        TASK_ENTER_VEHICLE = 0xC20E50AA46D09CA8,
        /// <summary>
        /// Flags from decompiled scripts:
        /// 0 = normal exit and closes door.
        /// 1 = normal exit and closes door.
        /// 16 = teleports outside, door kept closed.
        /// 64 = normal exit and closes door, maybe a bit slower animation than 0.
        /// 256 = normal exit but does not close the door.
        /// 4160 = ped is throwing himself out, even when the vehicle is still.
        /// 262144 = ped moves to passenger seat first, then exits normally
        /// 
        /// Others to be tried out: 320, 512, 131072.
        ///
        /// > Ped ped
        /// > Vehicle vehicle
        /// > int flags
        ///
        /// </summary>
        TASK_LEAVE_VEHICLE = 0xD3DBCE61A490BE02,
        /// <summary>
        /// Second parameter is unused.
        /// 
        /// second parameter was for jetpack in the early stages of gta and the hard coded code is now removed
        ///
        /// > Ped ped
        /// > BOOL p1
        /// > BOOL p2
        ///
        /// </summary>
        TASK_PARACHUTE = 0xD2F1C53C97EE81AB,
        /// <summary>
        /// makes ped parachute to coords x y z. Works well with PATHFIND::GET_SAFE_COORD_FOR_PED
        ///
        /// > Ped ped
        /// > float x
        /// > float y
        /// > float z
        ///
        /// </summary>
        TASK_PARACHUTE_TO_TARGET = 0xB33E291AFA6BD03A,
        /// <summary>
        /// Only appears twice in the scripts.
        /// 
        /// TASK::TASK_RAPPEL_FROM_HELI(PLAYER::PLAYER_PED_ID(), 0x41200000);
        /// TASK::TASK_RAPPEL_FROM_HELI(a_0, 0x41200000);
        ///
        /// > Ped ped
        /// > float p1
        ///
        /// </summary>
        TASK_RAPPEL_FROM_HELI = 0x09693B0312F91649,
        /// <summary>
        /// info about driving modes: HTTP://gtaforums.com/topic/822314-guide-driving-styles/
        /// ---------------------------------------------------------------
        /// Passing P6 value as floating value didn't throw any errors, though unsure what is it exactly, looks like radius or something.
        /// 
        /// P10 though, it is mentioned as float, however, I used bool and set it to true, that too worked.
        /// Here the e.g. code I used
        /// Function.Call(Hash.TASK_VEHICLE_DRIVE_TO_COORD, Ped, Vehicle, Cor X, Cor Y, Cor Z, 30f, 1f, Vehicle.GetHashCode(), 16777216, 1f, true);
        ///
        /// > Ped ped
        /// > Vehicle vehicle
        /// > float x
        /// > float y
        /// > float z
        /// > float speed
        /// > Any p6
        /// > Hash vehicleModel
        /// > int drivingMode
        /// > float stopRange
        /// > float p10
        ///
        /// </summary>
        TASK_VEHICLE_DRIVE_TO_COORD = 0xE2A2AA2F659D77A7,
        /// <summary>
        /// p6 always -1
        /// p7 always 10.0
        /// p8 always 1
        ///
        /// > Ped ped
        /// > Entity entity
        /// > float offsetX
        /// > float offsetY
        /// > float offsetZ
        /// > float movementSpeed
        /// > int timeout
        /// > float stoppingRange
        /// > BOOL persistFollowing
        ///
        /// </summary>
        TASK_FOLLOW_TO_OFFSET_OF_ENTITY = 0x304AE42E357B8C7E,
        /// <summary>
        /// Makes the specified ped achieve the specified heading.
        /// 
        /// pedHandle: The handle of the ped to assign the task to.
        /// heading: The desired heading.
        /// timeout: The time, in milliseconds, to allow the task to complete. If the task times out, it is cancelled, and the ped will stay at the heading it managed to reach in the time.
        ///
        /// > Ped ped
        /// > float heading
        /// > int timeout
        ///
        /// </summary>
        TASK_ACHIEVE_HEADING = 0x93B93A37987F1F3D,
        /// <summary>
        /// MulleKD19: Clears the current point route. Call this before TASK_EXTEND_ROUTE and TASK_FOLLOW_POINT_ROUTE.
        ///
        ///
        /// </summary>
        TASK_FLUSH_ROUTE = 0x841142A1376E9006,
        /// <summary>
        /// MulleKD19: Adds a new point to the current point route. Call TASK_FLUSH_ROUTE before the first call to this. Call TASK_FOLLOW_POINT_ROUTE to make the Ped go the route.
        /// 
        /// A maximum of 8 points can be added.
        ///
        /// > float x
        /// > float y
        /// > float z
        ///
        /// </summary>
        TASK_EXTEND_ROUTE = 0x1E7889778264843A,
        /// <summary>
        /// MulleKD19: Makes the ped go on the created point route.
        /// 
        /// ped: The ped to give the task to.
        /// speed: The speed to move at in m/s.
        /// int: Unknown. Can be 0, 1, 2 or 3.
        /// 
        /// Example:
        /// TASK_FLUSH_ROUTE();
        /// TASK_EXTEND_ROUTE(0f, 0f, 70f);
        /// TASK_EXTEND_ROUTE(10f, 0f, 70f);
        /// TASK_EXTEND_ROUTE(10f, 10f, 70f);
        /// TASK_FOLLOW_POINT_ROUTE(GET_PLAYER_PED(), 1f, 0);
        ///
        /// > Ped ped
        /// > float speed
        /// > int unknown
        ///
        /// </summary>
        TASK_FOLLOW_POINT_ROUTE = 0x595583281858626E,
        /// <summary>
        /// The entity will move towards the target until time is over (duration) or get in target's range (distance). p5 and p6 are unknown, but you could leave p5 = 1073741824 or 100 or even 0 (didn't see any difference but on the decompiled scripts, they use 1073741824 mostly) and p6 = 0
        /// 
        /// Note: I've only tested it on entity -> ped and target -> vehicle. It could work differently on other entities, didn't try it yet.
        /// 
        /// Example: TASK::TASK_GO_TO_ENTITY(pedHandle, vehicleHandle, 5000, 4.0, 100, 1073741824, 0)
        /// 
        /// Ped will run towards the vehicle for 5 seconds and stop when time is over or when he gets 4 meters(?) around the vehicle (with duration = -1, the task duration will be ignored).
        ///
        /// > Entity entity
        /// > Entity target
        /// > int duration
        /// > float distance
        /// > float speed
        /// > float p5
        /// > int p6
        ///
        /// </summary>
        TASK_GO_TO_ENTITY = 0x6A071245EB0D1882,
        /// <summary>
        /// Makes the specified ped flee the specified distance from the specified position.
        ///
        /// > Ped ped
        /// > float x
        /// > float y
        /// > float z
        /// > float distance
        /// > int time
        /// > BOOL p6
        /// > BOOL p7
        ///
        /// </summary>
        TASK_SMART_FLEE_COORD = 0x94587F17E9C365D5,
        /// <summary>
        /// Makes a ped run away from another ped (fleeTarget).
        /// 
        /// distance = ped will flee this distance.
        /// fleeTime = ped will flee for this amount of time, set to "-1" to flee forever
        ///
        /// > Ped ped
        /// > Ped fleeTarget
        /// > float distance
        /// > Any fleeTime
        /// > BOOL p4
        /// > BOOL p5
        ///
        /// </summary>
        TASK_SMART_FLEE_PED = 0x22B0D0E37CCB840D,
        /// <summary>
        /// Makes ped walk around the area.
        /// 
        /// set p1 to 10.0f and p2 to 10 if you want the ped to walk anywhere without a duration.
        ///
        /// > Ped ped
        /// > float p1
        /// > int p2
        ///
        /// </summary>
        TASK_WANDER_STANDARD = 0xBB9CE077274F6A1B,
        /// <summary>
        /// Modes:
        /// 0 - ignore heading
        /// 1 - park forward
        /// 2 - park backwards
        /// 
        /// Depending on the angle of approach, the vehicle can park at the specified heading or at its exact opposite (-180) angle.
        /// 
        /// Radius seems to define how close the vehicle has to be -after parking- to the position for this task considered completed. If the value is too small, the vehicle will try to park again until it's exactly where it should be. 20.0 Works well but lower values don't, like the radius is measured in centimeters or something.
        ///
        /// > Ped ped
        /// > Vehicle vehicle
        /// > float x
        /// > float y
        /// > float z
        /// > float heading
        /// > int mode
        /// > float radius
        /// > BOOL keepEngineOn
        ///
        /// </summary>
        TASK_VEHICLE_PARK = 0x0F3E34E968EA374E,
        /// <summary>
        /// known "killTypes" are: "AR_stealth_kill_knife" and "AR_stealth_kill_a".
        ///
        /// > Ped killer
        /// > Ped target
        /// > Hash actionType
        /// > float p3
        /// > Any p4
        ///
        /// </summary>
        TASK_STEALTH_KILL = 0xAA5DC05579D60BD9,
        /// <summary>
        /// If no timeout, set timeout to -1.
        ///
        /// > Ped ped
        /// > float x
        /// > float y
        /// > float z
        /// > float speed
        /// > int timeout
        /// > float stoppingRange
        /// > BOOL persistFollowing
        /// > float unk
        ///
        /// </summary>
        TASK_FOLLOW_NAV_MESH_TO_COORD = 0x15D3A79D4E44B913,
        /// <summary>
        /// Default modifier is 1.0, minimum is 0.0 and maximum is 10.0.
        ///
        /// > Ped ped
        /// > float modifier
        ///
        /// </summary>
        SET_PED_PATH_CLIMB_COST_MODIFIER = 0x88E32DB8C1A4AA4B,
        /// <summary>
        /// Needs to be looped! And yes, it does work and is not a hash collision.
        /// Birds will try to reach the given height.
        ///
        /// > float height
        ///
        /// </summary>
        SET_GLOBAL_MIN_BIRD_FLIGHT_HEIGHT = 0x6C6B148586F934F7,
        /// <summary>
        /// Looks like the last parameter returns true if the path has been calculated, while the first returns the remaining distance to the end of the path.
        /// Return value of native is the same as GET_NAVMESH_ROUTE_RESULT
        /// Looks like the native returns an int for the path's state:
        /// 1 - ???
        /// 2 - ???
        /// 3 - Finished Generating 
        ///
        /// > Ped ped
        /// > float* distanceRemaining
        /// > BOOL* isPathReady
        ///
        /// </summary>
        GET_NAVMESH_ROUTE_DISTANCE_REMAINING = 0xC6F5C0BCDC74D62D,
        /// <summary>
        /// See GET_NAVMESH_ROUTE_DISTANCE_REMAINING for more details.
        ///
        /// > Ped ped
        ///
        /// </summary>
        GET_NAVMESH_ROUTE_RESULT = 0x632E831F382A0FA8,
        /// <summary>
        /// example from fm_mission_controller
        /// 
        /// TASK::TASK_GO_TO_COORD_ANY_MEANS(l_649, sub_f7e86(-1, 0), 1.0, 0, 0, 786603, 0xbf800000);
        ///  
        ///
        /// > Ped ped
        /// > float x
        /// > float y
        /// > float z
        /// > float speed
        /// > Any p5
        /// > BOOL p6
        /// > int walkingStyle
        /// > float p8
        ///
        /// </summary>
        TASK_GO_TO_COORD_ANY_MEANS = 0x5BC448CB78FA3E88,
        /// <summary>
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        /// 
        /// float speed > normal speed is 8.0f
        /// ----------------------
        /// 
        /// float speedMultiplier > multiply the playback speed
        /// ----------------------
        /// 
        /// int duration: time in millisecond
        /// ----------------------
        /// -1 _ _ _ _ _ _ _> Default (see flag)
        /// 0 _ _ _ _ _ _ _ > Not play at all
        /// Small value _ _ > Slow down animation speed
        /// Other _ _ _ _ _ > freeze player control until specific time (ms) has 
        /// _ _ _ _ _ _ _ _ _ passed. (No effect if flag is set to be 
        /// _ _ _ _ _ _ _ _ _ controllable.)
        /// 
        /// int flag:
        /// ----------------------
        /// enum eAnimationFlags
        /// {
        ///  ANIM_FLAG_NORMAL = 0,
        ///    ANIM_FLAG_REPEAT = 1,
        ///    ANIM_FLAG_STOP_LAST_FRAME = 2,
        ///    ANIM_FLAG_UPPERBODY = 16,
        ///    ANIM_FLAG_ENABLE_PLAYER_CONTROL = 32,
        ///    ANIM_FLAG_CANCELABLE = 120,
        /// };
        /// Odd number : loop infinitely
        /// Even number : Freeze at last frame
        /// Multiple of 4: Freeze at last frame but controllable
        /// 
        /// 01 to 15 > Full body
        /// 10 to 31 > Upper body
        /// 32 to 47 > Full body > Controllable
        /// 48 to 63 > Upper body > Controllable
        /// ...
        /// 001 to 255 > Normal
        /// 256 to 511 > Garbled
        /// ...
        /// 
        /// playbackRate:
        /// 
        /// values are between 0.0 and 1.0
        /// 
        /// 
        /// lockX:  
        /// 
        /// 0 in most cases 1 for rcmepsilonism8 and rcmpaparazzo_3
        /// > 1 for mini@sprunk
        ///  
        /// 
        /// lockY:
        /// 
        /// 0 in most cases 
        /// 1 for missfam5_yoga, missfra1mcs_2_crew_react
        /// 
        /// 
        /// lockZ: 
        /// 
        ///     0 for single player 
        ///     Can be 1 but only for MP 
        ///
        /// > Ped ped
        /// > const char* animDictionary
        /// > const char* animationName
        /// > float blendInSpeed
        /// > float blendOutSpeed
        /// > int duration
        /// > int flag
        /// > float playbackRate
        /// > BOOL lockX
        /// > BOOL lockY
        /// > BOOL lockZ
        ///
        /// </summary>
        TASK_PLAY_ANIM = 0xEA47FE3719165B94,
        /// <summary>
        /// It's similar to TASK_PLAY_ANIM, except the first 6 floats let you specify the initial position and rotation of the task. (Ped gets teleported to the position).
        /// 
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        ///
        /// > Ped ped
        /// > const char* animDict
        /// > const char* animName
        /// > float posX
        /// > float posY
        /// > float posZ
        /// > float rotX
        /// > float rotY
        /// > float rotZ
        /// > float animEnterSpeed
        /// > float animExitSpeed
        /// > int duration
        /// > Any flag
        /// > float animTime
        /// > Any p14
        /// > Any p15
        ///
        /// </summary>
        TASK_PLAY_ANIM_ADVANCED = 0x83CDB10EA29B370B,
        /// <summary>
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        ///
        /// > Ped ped
        /// > const char* animDictionary
        /// > const char* animationName
        /// > float p3
        ///
        /// </summary>
        STOP_ANIM_TASK = 0x97FF36A1D40EA00A,
        /// <summary>
        /// From fm_mission_controller.c:
        /// reserve_network_mission_objects(get_num_reserved_mission_objects(0) + 1);
        ///            vVar28 = {0.094f, 0.02f, -0.005f};
        ///             vVar29 = {-92.24f, 63.64f, 150.24f};
        ///           func_253(&uVar30, joaat("prop_ld_case_01"), Global_1592429.imm_34757[iParam1 <268>], 1, 1, 0, 1);
        ///          set_entity_lod_dist(net_to_ent(uVar30), 500);
        ///          attach_entity_to_entity(net_to_ent(uVar30), iParam0, get_ped_bone_index(iParam0, 28422), vVar28, vVar29, 1, 0, 0, 0, 2, 1);
        ///            Var31.imm_4 = 1065353216;
        ///          Var31.imm_5 = 1065353216;
        ///          Var31.imm_9 = 1065353216;
        ///          Var31.imm_10 = 1065353216;
        ///             Var31.imm_14 = 1065353216;
        ///             Var31.imm_15 = 1065353216;
        ///             Var31.imm_17 = 1040187392;
        ///             Var31.imm_18 = 1040187392;
        ///             Var31.imm_19 = -1;
        ///             Var32.imm_4 = 1065353216;
        ///          Var32.imm_5 = 1065353216;
        ///          Var32.imm_9 = 1065353216;
        ///          Var32.imm_10 = 1065353216;
        ///             Var32.imm_14 = 1065353216;
        ///             Var32.imm_15 = 1065353216;
        ///             Var32.imm_17 = 1040187392;
        ///             Var32.imm_18 = 1040187392;
        ///             Var32.imm_19 = -1;
        ///             Var31 = 1;
        ///             Var31.imm_1 = "weapons@misc@jerrycan@mp_male";
        ///           Var31.imm_2 = "idle";
        ///            Var31.imm_20 = 1048633;
        ///            Var31.imm_4 = 0.5f;
        ///            Var31.imm_16 = get_hash_key("BONEMASK_ARMONLY_R");
        ///           task_scripted_animation(iParam0, &Var31, &Var32, &Var32, 0f, 0.25f);
        ///           set_model_as_no_longer_needed(joaat("prop_ld_case_01"));
        ///             remove_anim_dict("anim@heists@biolab@");
        ///
        /// > Ped ped
        /// > Any* p1
        /// > Any* p2
        /// > Any* p3
        /// > float p4
        /// > float p5
        ///
        /// </summary>
        TASK_SCRIPTED_ANIMATION = 0x126EF75F1E17ABE5,
        /// <summary>
        /// Looks like p1 may be a flag, still need to do some research, though.
        ///
        /// > Ped ped
        /// > int p1
        /// > BOOL p2
        ///
        /// </summary>
        STOP_ANIM_PLAYBACK = 0xEE08C992D238C5D1,
        /// <summary>
        /// Example from the scripts:
        /// TASK::TASK_PLAY_PHONE_GESTURE_ANIMATION(PLAYER::PLAYER_PED_ID(), v_3, v_2, v_4, 0.25, 0.25, 0, 0);
        /// 
        /// =========================================================
        /// ^^ No offense, but Idk how that would really help anyone.
        /// 
        /// As for the animDict & animation, they're both store in a global in all 5 scripts. So if anyone would be so kind as to read that global and comment what strings they use. Thanks.
        /// 
        /// Known boneMaskTypes'
        /// "BONEMASK_HEADONLY"
        /// "BONEMASK_HEAD_NECK_AND_ARMS"
        /// "BONEMASK_HEAD_NECK_AND_L_ARM"
        /// "BONEMASK_HEAD_NECK_AND_R_ARM"
        /// 
        /// p4 known args - 0.0f, 0.5f, 0.25f
        /// p5 known args - 0.0f, 0.25f
        /// p6 known args - 1 if a global if check is passed.
        /// p7 known args - 1 if a global if check is passed.
        /// 
        /// The values found above, I found within the 5 scripts this is ever called in. (fmmc_launcher, fm_deathmatch_controller, fm_impromptu_dm_controller, fm_mission_controller, and freemode).
        /// =========================================================
        /// 
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        ///
        /// > Ped ped
        /// > const char* animDict
        /// > const char* animation
        /// > const char* boneMaskType
        /// > float p4
        /// > float p5
        /// > BOOL p6
        /// > BOOL p7
        ///
        /// </summary>
        TASK_PLAY_PHONE_GESTURE_ANIMATION = 0x8FBB6758B3B3E9EC,
        /// <summary>
        /// Most probably plays a specific animation on vehicle. For example getting chop out of van etc...
        /// 
        /// Here's how its used - 
        /// 
        /// TASK::TASK_VEHICLE_PLAY_ANIM(l_325, "rcmnigel1b", "idle_speedo");
        /// 
        /// TASK::TASK_VEHICLE_PLAY_ANIM(l_556[0/*1*/], "missfra0_chop_drhome", "InCar_GetOutofBack_Speedo");
        /// 
        /// FYI : Speedo is the name of van in which chop was put in the mission.
        ///
        /// > Vehicle vehicle
        /// > const char* animationSet
        /// > const char* animationName
        ///
        /// </summary>
        TASK_VEHICLE_PLAY_ANIM = 0x69F5C3BD0F3EBD89,
        /// <summary>
        /// p5 = 0, p6 = 2
        ///
        /// > Entity entity
        /// > float x
        /// > float y
        /// > float z
        /// > int duration
        /// > Any p5
        /// > Any p6
        ///
        /// </summary>
        TASK_LOOK_AT_COORD = 0x6FA46612594F7973,
        /// <summary>
        /// param3: duration in ms, use -1 to look forever
        /// param4: using 2048 is fine
        /// param5: using 3 is fine
        ///
        /// > Ped ped
        /// > Entity lookAt
        /// > int duration
        /// > int unknown1
        /// > int unknown2
        ///
        /// </summary>
        TASK_LOOK_AT_ENTITY = 0x69F4BE8C8CC4796C,
        /// <summary>
        /// Not clear what it actually does, but here's how script uses it - 
        /// 
        /// if (OBJECT::HAS_PICKUP_BEEN_COLLECTED(...) 
        /// {
        ///  if(ENTITY::DOES_ENTITY_EXIST(PLAYER::PLAYER_PED_ID()))
        ///     {
        ///      TASK::TASK_CLEAR_LOOK_AT(PLAYER::PLAYER_PED_ID());
        ///   }
        ///  ...
        /// }
        /// 
        /// Another one where it doesn't "look" at current player - 
        /// 
        /// TASK::TASK_PLAY_ANIM(l_3ED, "missheist_agency2aig_2", "look_at_phone_a", 1000.0, -2.0, -1, 48, v_2, 0, 0, 0);
        /// PED::_2208438012482A1A(l_3ED, 0, 0);
        /// TASK::TASK_CLEAR_LOOK_AT(l_3ED);
        ///
        /// > Ped ped
        ///
        /// </summary>
        TASK_CLEAR_LOOK_AT = 0x0F804F1DB19B9689,
        /// <summary>
        /// returned values:
        /// 0 to 7 = task that's currently in progress, 0 meaning the first one.
        /// -1 no task sequence in progress.
        ///
        /// > Ped ped
        ///
        /// </summary>
        GET_SEQUENCE_PROGRESS = 0x00A9010CFE1E3533,
        /// <summary>
        /// Task index enum: https://alloc8or.re/gta5/doc/enums/eTaskTypeIndex.txt
        ///
        /// > Ped ped
        /// > int taskIndex
        ///
        /// </summary>
        GET_IS_TASK_ACTIVE = 0xB0760331C7AA4155,
        /// <summary>
        /// Gets the status of a script-assigned task.
        /// taskHash: https://alloc8or.re/gta5/doc/enums/eScriptTaskHash.txt
        ///
        /// > Ped ped
        /// > Hash taskHash
        ///
        /// </summary>
        GET_SCRIPT_TASK_STATUS = 0x77F1BEB8863288D5,
        /// <summary>
        /// https://alloc8or.re/gta5/doc/enums/eVehicleMissionType.txt
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_ACTIVE_VEHICLE_MISSION_TYPE = 0x534AEBA6E5ED4CAB,
        /// <summary>
        /// Flags are the same flags used in TASK_LEAVE_VEHICLE
        ///
        /// > Ped ped
        /// > int p1
        /// > int flags
        ///
        /// </summary>
        TASK_LEAVE_ANY_VEHICLE = 0x504D54DF3F6F2247,
        /// <summary>
        /// duration: the amount of time in milliseconds to do the task.  -1 will keep the task going until either another task is applied, or CLEAR_ALL_TASKS() is called with the ped
        ///
        /// > Ped ped
        /// > Entity entity
        /// > int duration
        /// > BOOL p3
        ///
        /// </summary>
        TASK_AIM_GUN_AT_ENTITY = 0x9B53BB6E8943AF53,
        /// <summary>
        /// duration: the amount of time in milliseconds to do the task. -1 will keep the task going until either another task is applied, or CLEAR_ALL_TASKS() is called with the ped
        ///
        /// > Ped ped
        /// > Entity entity
        /// > int duration
        ///
        /// </summary>
        TASK_TURN_PED_TO_FACE_ENTITY = 0x5AD23D40115353AC,
        /// <summary>
        /// Firing Pattern Hash Information: https://pastebin.com/Px036isB
        ///
        /// > Ped ped
        /// > float x
        /// > float y
        /// > float z
        /// > int duration
        /// > Hash firingPattern
        ///
        /// </summary>
        TASK_SHOOT_AT_COORD = 0x46A6CC01E0826106,
        /// <summary>
        /// Makes the specified ped shuffle to the next vehicle seat.
        /// The ped MUST be in a vehicle and the vehicle parameter MUST be the ped's current vehicle.
        ///
        /// > Ped ped
        /// > Vehicle vehicle
        /// > Any p2
        ///
        /// </summary>
        TASK_SHUFFLE_TO_NEXT_VEHICLE_SEAT = 0x7AA80209BDA643EB,
        /// <summary>
        /// duration in milliseconds
        ///
        /// > Ped ped
        /// > float x
        /// > float y
        /// > float z
        /// > int duration
        ///
        /// </summary>
        TASK_TURN_PED_TO_FACE_COORD = 0x1DDA930A0AC38571,
        /// <summary>
        /// '1 - brake
        /// '3 - brake + reverse
        /// '4 - turn left 90 + braking
        /// '5 - turn right 90 + braking
        /// '6 - brake strong (handbrake?) until time ends
        /// '7 - turn left + accelerate
        /// '7 - turn right + accelerate
        /// '9 - weak acceleration
        /// '10 - turn left + restore wheel pos to center in the end
        /// '11 - turn right + restore wheel pos to center in the end
        /// '13 - turn left + go reverse
        /// '14 - turn left + go reverse
        /// '16 - crash the game after like 2 seconds :)
        /// '17 - keep actual state, game crashed after few tries
        /// '18 - game crash
        /// '19 - strong brake + turn left/right
        /// '20 - weak brake + turn left then turn right
        /// '21 - weak brake + turn right then turn left
        /// '22 - brake + reverse
        /// '23 - accelerate fast
        /// '24 - brake
        /// '25 - brake turning left then when almost stopping it turns left more
        /// '26 - brake turning right then when almost stopping it turns right more
        /// '27 - brake until car stop or until time ends
        /// '28 - brake + strong reverse acceleration
        /// '30 - performs a burnout (brake until stop + brake and accelerate)
        /// '31 - accelerate + handbrake
        /// '32 - accelerate very strong
        /// 
        /// Seems to be this:
        /// Works on NPCs, but overrides their current task. If inside a task sequence (and not being the last task), "time" will work, otherwise the task will be performed forever until tasked with something else
        ///
        /// > Ped driver
        /// > Vehicle vehicle
        /// > int action
        /// > int time
        ///
        /// </summary>
        TASK_VEHICLE_TEMP_ACTION = 0xC429DCEEB339E129,
        /// <summary>
        /// missionType: https://alloc8or.re/gta5/doc/enums/eVehicleMissionType.txt
        ///
        /// > Ped driver
        /// > Vehicle vehicle
        /// > Vehicle vehicleTarget
        /// > int missionType
        /// > float p4
        /// > Any p5
        /// > float p6
        /// > float p7
        /// > BOOL DriveAgainstTraffic
        ///
        /// </summary>
        TASK_VEHICLE_MISSION = 0x659427E0EF36BCDE,
        /// <summary>
        /// See TASK_VEHICLE_MISSION
        ///
        /// > Ped ped
        /// > Vehicle vehicle
        /// > Ped pedTarget
        /// > int missionType
        /// > float maxSpeed
        /// > int drivingStyle
        /// > float minDistance
        /// > float p7
        /// > BOOL DriveAgainstTraffic
        ///
        /// </summary>
        TASK_VEHICLE_MISSION_PED_TARGET = 0x9454528DF15D657A,
        /// <summary>
        /// See TASK_VEHICLE_MISSION
        ///
        /// > Ped ped
        /// > Vehicle vehicle
        /// > float x
        /// > float y
        /// > float z
        /// > int p5
        /// > int p6
        /// > int p7
        /// > float p8
        /// > float p9
        /// > BOOL DriveAgainstTraffic
        ///
        /// </summary>
        TASK_VEHICLE_MISSION_COORS_TARGET = 0xF0AF20AA7731F8C3,
        /// <summary>
        /// Makes a ped follow the targetVehicle with <minDistance> in between.
        /// 
        /// note: minDistance is ignored if drivingstyle is avoiding traffic, but Rushed is fine.
        /// 
        /// Mode: The mode defines the relative position to the targetVehicle. The ped will try to position its vehicle there.
        /// -1 = behind
        /// 0 = ahead
        /// 1 = left
        /// 2 = right
        /// 3 = back left
        /// 4 = back right
        /// 
        /// if the target is closer than noRoadsDistance, the driver will ignore pathing/roads and follow you directly.
        /// 
        /// Driving Styles guide: gtaforums.com/topic/822314-guide-driving-styles/
        ///
        /// > Ped ped
        /// > Vehicle vehicle
        /// > Vehicle targetVehicle
        /// > int mode
        /// > float speed
        /// > int drivingStyle
        /// > float minDistance
        /// > int p7
        /// > float noRoadsDistance
        ///
        /// </summary>
        TASK_VEHICLE_ESCORT = 0x0FA6E4B75F302400,
        /// <summary>
        /// Makes a ped in a vehicle follow an entity (ped, vehicle, etc.)
        /// 
        /// drivingStyle: http://gtaforums.com/topic/822314-guide-driving-styles/
        ///
        /// > Ped driver
        /// > Vehicle vehicle
        /// > Entity targetEntity
        /// > float speed
        /// > int drivingStyle
        /// > int minDistance
        ///
        /// </summary>
        TASK_VEHICLE_FOLLOW = 0xFC545A9F0626E3B6,
        /// <summary>
        /// chases targetEnt fast and aggressively
        /// --
        /// Makes ped (needs to be in vehicle) chase targetEnt.
        ///
        /// > Ped driver
        /// > Entity targetEnt
        ///
        /// </summary>
        TASK_VEHICLE_CHASE = 0x3C08A8E30363B353,
        /// <summary>
        /// pilot, vehicle and altitude are rather self-explanatory.
        /// 
        /// p4: is unused variable in the function.
        /// 
        /// entityToFollow: you can provide a Vehicle entity or a Ped entity, the heli will protect them.
        /// 
        /// 'targetSpeed':  The pilot will dip the nose AS MUCH AS POSSIBLE so as to reach this value AS FAST AS POSSIBLE.  As such, you'll want to modulate it as opposed to calling it via a hard-wired, constant #.
        /// 
        /// 'radius' isn't just "stop within radius of X of target" like with ground vehicles.  In this case, the pilot will fly an entire circle around 'radius' and continue to do so.
        /// 
        /// NOT CONFIRMED:  p7 appears to be a FlyingStyle enum.  Still investigating it as of this writing, but playing around with values here appears to result in different -behavior- as opposed to offsetting coordinates, altitude, target speed, etc.
        /// 
        /// NOTE: If the pilot finds enemies, it will engage them until it kills them, but will return to protect the ped/vehicle given shortly thereafter.
        ///
        /// > Ped pilot
        /// > Vehicle vehicle
        /// > Entity entityToFollow
        /// > float targetSpeed
        /// > int p4
        /// > float radius
        /// > int altitude
        /// > int p7
        ///
        /// </summary>
        TASK_VEHICLE_HELI_PROTECT = 0x1E09C32048FEFD1C,
        /// <summary>
        /// Flag 8: Medium-aggressive boxing tactic with a bit of PIT
        /// Flag 1: Aggressive ramming of suspect
        /// Flag 2: Ram attempts
        /// Flag 32: Stay back from suspect, no tactical contact. Convoy-like.
        /// Flag 16: Ramming, seems to be slightly less aggressive than 1-2.
        ///
        /// > Ped ped
        /// > int flag
        /// > BOOL set
        ///
        /// </summary>
        SET_TASK_VEHICLE_CHASE_BEHAVIOR_FLAG = 0xCC665AAC360D31E7,
        /// <summary>
        /// Ped pilot should be in a heli.
        /// EntityToFollow can be a vehicle or Ped.
        /// 
        /// x,y,z appear to be how close to the EntityToFollow the heli should be. Scripts use 0.0, 0.0, 80.0. Then the heli tries to position itself 80 units above the EntityToFollow. If you reduce it to -5.0, it tries to go below (if the EntityToFollow is a heli or plane)
        /// 
        /// 
        /// NOTE: If the pilot finds enemies, it will engage them, then remain there idle, not continuing to chase the Entity given.
        ///
        /// > Ped pilot
        /// > Entity entityToFollow
        /// > float x
        /// > float y
        /// > float z
        ///
        /// </summary>
        TASK_HELI_CHASE = 0xAC83B1DB38D0ADA0,
        /// <summary>
        /// Seems to stop the engine
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _CLEAR_VEHICLE_TASKS = 0xDBBC7A2432524127,
        /// <summary>
        /// Used in am_vehicle_spawn.ysc and am_mp_submarine.ysc.
        /// 
        /// p0 is always 0, p5 is always 1
        /// 
        /// p1 is the vehicle handle of the submarine. Submarine must have a driver, but the ped handle is not passed to the native.
        /// 
        /// Speed can be set by calling SET_DRIVE_TASK_CRUISE_SPEED after
        ///
        /// > Any p0
        /// > Vehicle submarine
        /// > float x
        /// > float y
        /// > float z
        /// > Any p5
        ///
        /// </summary>
        TASK_SUBMARINE_GOTO_AND_STOP = 0xC22B40579A498CA4,
        /// <summary>
        /// Must have targetVehicle, targetPed, OR destination X/Y/Z set
        /// Will follow targeted vehicle/ped, or fly to destination
        /// Set whichever is not being used to 0
        /// 
        /// 
        /// Mission mode type:
        ///  - 4, 7: Forces heli to snap to the heading if set, flies to destination or tracks specified entity (mode 4 only works for coordinates, 7 works for coordinates OR ped/vehicle)
        ///  - 6: Attacks the target ped/vehicle with mounted weapons. If radius is set, will maintain that distance from target.
        ///  - 8: Makes the heli flee from the ped/vehicle/coordinate
        ///  - 9: Circles around target ped/vehicle, snaps to angle if set. Behavior flag (last parameter) of 2048 switches from counter-clockwise to clockwise circling. Does not work with coordinate destination.
        ///  - 10, 11: Follows ped/vehicle target and imitates target heading. Only works with ped/vehicle target, not coord target
        ///  - 19: Heli lands at specified coordinate, ignores heading (lands facing whatever direction it is facing when the task is started)
        ///  - 20: Makes the heli land when near target ped. It won't resume chasing.
        ///  - 21: Emulates a helicopter crash
        ///  - 23: makes the heli circle erratically around ped
        /// 
        /// 
        /// Heli will fly at maxSpeed (up to actual maximum speed defined by the model's handling config)
        /// You can use SET_DRIVE_TASK_CRUISE_SPEED to modulate the speed based on distance to the target without having to re-invoke the task native. Setting to 8.0 when close to the destination results in a much smoother approach.
        /// 
        /// If minHeight and maxHeight are set, heli will fly between those specified elevations, relative to ground level and any obstructions/buildings below. You can specify -1 for either if you only want to specify one. Usually it is easiest to leave maxHeight at -1, and specify a reasonable minHeight to ensure clearance over any obstacles. Note this MUST be passed as an INT, not a FLOAT. 
        /// 
        /// Radius affects how closely the heli will follow tracked ped/vehicle, and when circling (mission type 9) sets the radius (in meters) that it will circle the target from
        /// 
        /// Heading is -1.0 for default behavior, which will point the nose of the helicopter towards the destination. Set a heading and the heli will lock to that direction when near its destination/target, but may still turn towards the destination when flying at higher speed from a further distance.
        /// 
        /// Behavior Flags is a bitwise value that modifies the AI behavior. Not clear what all flags do, but here are some guesses/notes:
        ///    1: Forces heading to face E
        ///    2: Unknown
        ///    4: Tight circles around coordinate destination
        ///    8: Unknown
        ///   16: Circles around coordinate destination facing towards destination
        ///   32: Flys to normally, then lands at coordinate destination and stays on the ground (using mission type 4)
        ///   64: Ignores obstacles when flying, will follow at specified minHeight above ground level but will not avoid buildings, vehicles, etc.
        ///  128: Unknown
        ///  256: Unknown
        ///  512: Unknown
        /// 1024: Unknown 
        /// 2048: Reverses direction of circling (mission type 9) to clockwise
        /// 4096: Hugs closer to the ground, maintains minHeight from ground generally, but barely clears buildings and dips down more between buildings instead of taking a more efficient/safe route
        /// 8192: Unknown
        /// 
        /// Unk3 is a float value, you may see -1082130432 for this value in decompiled native scripts, this is the equivalent to -1.0f. Seems to affect acceleration/aggressiveness, but not sure exactly how it works. Higher value seems to result in lower acceleration/less aggressive flying. Almost always -1.0 in native scripts, occasionally 20.0 or 50.0. Setting to 400.0 seems to work well for making the pilot not overshoot the destination when using coordinate destination.
        /// 
        /// Notes updated by PNWParksFan, May 2021
        /// 
        ///
        /// > Ped pilot
        /// > Vehicle aircraft
        /// > Vehicle targetVehicle
        /// > Ped targetPed
        /// > float destinationX
        /// > float destinationY
        /// > float destinationZ
        /// > int missionFlag
        /// > float maxSpeed
        /// > float radius
        /// > float targetHeading
        /// > int maxHeight
        /// > int minHeight
        /// > float unk3
        /// > int behaviorFlags
        ///
        /// </summary>
        TASK_HELI_MISSION = 0xDAD029E187A2BEB4,
        /// <summary>
        /// EXAMPLE USAGE:
        /// 
        /// Fly around target (Precautiously, keeps high altitude):
        /// Function.Call(Hash.TASK_PLANE_MISSION, pilot, selectedAirplane, 0, 0, Target.X, Target.Y, Target.Z, 4, 100f, 0f, 90f, 0, 200f);
        /// 
        /// Fly around target (Dangerously, keeps VERY low altitude):
        /// Function.Call(Hash.TASK_PLANE_MISSION, pilot, selectedAirplane, 0, 0, Target.X, Target.Y, Target.Z, 4, 100f, 0f, 90f, 0, -500f);
        /// 
        /// Fly directly into target:
        /// Function.Call(Hash.TASK_PLANE_MISSION, pilot, selectedAirplane, 0, 0, Target.X, Target.Y, Target.Z, 4, 100f, 0f, 90f, 0, -5000f);
        /// 
        /// EXPANDED INFORMATION FOR ADVANCED USAGE (custom pilot)
        /// 
        /// 'physicsSpeed': (THIS IS NOT YOUR ORDINARY SPEED PARAMETER: READ!!)
        /// Think of this -first- as a radius value, not a true speed value.  The ACTUAL effective speed of the plane will be that of the maximum speed permissible to successfully fly in a -circle- with a radius of 'physicsSpeed'.  This also means that the plane must complete a circle before it can begin its "bombing run", its straight line pass towards the target.  p9 appears to influence the angle at which a "bombing run" begins, although I can't confirm yet.
        /// 
        /// VERY IMPORTANT: A "bombing run" will only occur if a plane can successfully determine a possible navigable route (the slower the value of 'physicsSpeed', the more precise the pilot can be due to less influence of physics on flightpath).  Otherwise, the pilot will continue to patrol around Destination (be it a dynamic Entity position vector or a fixed world coordinate vector.)
        /// 
        /// 0 = Plane's physics are almost entirely frozen, plane appears to "orbit" around precise destination point
        /// 1-299 = Blend of "frozen, small radius" vs. normal vs. "accelerated, hyperfast, large radius"
        /// 300+ =  Vehicle behaves entirely like a normal gameplay plane.
        /// 
        /// 'patrolBlend' (The lower the value, the more the Destination is treated as a "fly AT" rather than a "fly AROUND point".)
        /// 
        /// Scenario: Destination is an Entity on ground level, wide open field
        /// -5000 = Pilot kamikazes directly into Entity
        /// -1000 = Pilot flies extremely low -around- Entity, very prone to crashing
        /// -200 = Pilot flies lower than average around Entity.
        /// 0 = Pilot flies around Entity, normal altitude
        /// 200 = Pilot flies an extra eighty units or so higher than 0 while flying around Destination (this doesn't seem to correlate directly into distance units.)
        /// 
        /// -- Valid mission types found in the exe: --
        /// 
        /// 0 = None
        /// 1 = Unk
        /// 2 = CTaskVehicleRam
        /// 3 = CTaskVehicleBlock
        /// 4 = CTaskVehicleGoToPlane
        /// 5 = CTaskVehicleStop
        /// 6 = CTaskVehicleAttack
        /// 7 = CTaskVehicleFollow
        /// 8 = CTaskVehicleFleeAirborne
        /// 9= CTaskVehicleCircle
        /// 10 = CTaskVehicleEscort
        /// 15 = CTaskVehicleFollowRecording
        /// 16 = CTaskVehiclePoliceBehaviour
        /// 17 = CTaskVehicleCrash
        ///
        /// > Ped pilot
        /// > Vehicle aircraft
        /// > Vehicle targetVehicle
        /// > Ped targetPed
        /// > float destinationX
        /// > float destinationY
        /// > float destinationZ
        /// > int missionFlag
        /// > float angularDrag
        /// > float unk
        /// > float targetHeading
        /// > float maxZ
        /// > float minZ
        /// > Any p13
        ///
        /// </summary>
        TASK_PLANE_MISSION = 0x23703CD154E83B88,
        /// <summary>
        /// You need to call PED::SET_BLOCKING_OF_NON_TEMPORARY_EVENTS after TASK_BOAT_MISSION in order for the task to execute.
        /// 
        /// Working example
        /// float vehicleMaxSpeed = VEHICLE::_GET_VEHICLE_MAX_SPEED(ENTITY::GET_ENTITY_MODEL(pedVehicle));
        /// TASK::TASK_BOAT_MISSION(pedDriver, pedVehicle, 0, 0, waypointCoord.x, waypointCoord.y, waypointCoord.z, 4, vehicleMaxSpeed, 786469, -1.0, 7);
        /// PED::SET_BLOCKING_OF_NON_TEMPORARY_EVENTS(pedDriver, 1);
        /// 
        /// P8 appears to be driving style flag - see gtaforums.com/topic/822314-guide-driving-styles/ for documentation
        ///
        /// > Ped pedDriver
        /// > Vehicle boat
        /// > Any p2
        /// > Any p3
        /// > float x
        /// > float y
        /// > float z
        /// > Any p7
        /// > float maxSpeed
        /// > int drivingStyle
        /// > float p10
        /// > Any p11
        ///
        /// </summary>
        TASK_BOAT_MISSION = 0x15C86013127CE63F,
        /// <summary>
        /// Example:
        /// 
        /// TASK::TASK_DRIVE_BY(l_467[1/*22*/], PLAYER::PLAYER_PED_ID(), 0, 0.0, 0.0, 2.0, 300.0, 100, 0, ${firing_pattern_burst_fire_driveby});
        /// 
        /// 
        /// 
        /// 
        /// Needs working example. Doesn't seem to do anything.
        /// 
        /// I marked p2 as targetVehicle as all these shooting related tasks seem to have that in common.
        /// I marked p6 as distanceToShoot as if you think of GTA's Logic with the native SET_VEHICLE_SHOOT natives, it won't shoot till it gets within a certain distance of the target.
        /// I marked p7 as pedAccuracy as it seems it's mostly 100 (Completely Accurate), 75, 90, etc. Although this could be the ammo count within the gun, but I highly doubt it. I will change this comment once I find out if it's ammo count or not.
        ///
        /// > Ped driverPed
        /// > Ped targetPed
        /// > Vehicle targetVehicle
        /// > float targetX
        /// > float targetY
        /// > float targetZ
        /// > float distanceToShoot
        /// > int pedAccuracy
        /// > BOOL p8
        /// > Hash firingPattern
        ///
        /// </summary>
        TASK_DRIVE_BY = 0x2F8AF0E82773A171,
        /// <summary>
        /// For p1 & p2 (Ped, Vehicle). I could be wrong, as the only time this native is called in scripts is once and both are 0, but I assume this native will work like SET_MOUNTED_WEAPON_TARGET in which has the same exact amount of parameters and the 1st and last 3 parameters are right and the same for both natives.
        ///
        /// > Ped shootingPed
        /// > Ped targetPed
        /// > Vehicle targetVehicle
        /// > float x
        /// > float y
        /// > float z
        ///
        /// </summary>
        SET_DRIVEBY_TASK_TARGET = 0xE5B302114D8162EE,
        /// <summary>
        /// Forces the ped to use the mounted weapon.
        /// Returns false if task is not possible.
        ///
        /// > Ped ped
        ///
        /// </summary>
        CONTROL_MOUNTED_WEAPON = 0xDCFE42068FE0135A,
        /// <summary>
        /// Note: Look in decompiled scripts and the times that p1 and p2 aren't 0. They are filled with vars. If you look through out that script what other natives those vars are used in, you can tell p1 is a ped and p2 is a vehicle. Which most likely means if you want the mounted weapon to target a ped set targetVehicle to 0 or vice-versa.
        ///
        /// > Ped shootingPed
        /// > Ped targetPed
        /// > Vehicle targetVehicle
        /// > float x
        /// > float y
        /// > float z
        /// > Any p6
        /// > Any p7
        ///
        /// </summary>
        SET_MOUNTED_WEAPON_TARGET = 0xCCD892192C6D2BB9,
        /// <summary>
        /// Actually has 3 params, not 2.
        /// 
        /// p0: Ped
        /// p1: int (or bool?)
        /// p2: int
        ///
        /// > Ped ped
        /// > int p1
        /// > Any p2
        ///
        /// </summary>
        TASK_USE_MOBILE_PHONE = 0xBD2A8EC3AF4DE7DB,
        /// <summary>
        /// p2 tend to be 16, 17 or 1
        /// p3 to p7 tend to be 0.0
        ///
        /// > Ped ped
        /// > Ped target
        /// > Any p2
        /// > float p3
        /// > float p4
        /// > float p5
        /// > float p6
        /// > float p7
        ///
        /// </summary>
        TASK_CHAT_TO_PED = 0x8C338E0263E4FD19,
        /// <summary>
        /// Seat Numbers
        /// -------------------------------
        /// Driver = -1
        /// Any = -2
        /// Left-Rear = 1
        /// Right-Front = 0
        /// Right-Rear = 2
        /// Extra seats = 3-14(This may differ from vehicle type e.g. Firetruck Rear Stand, Ambulance Rear)
        ///
        /// > Ped ped
        /// > Vehicle vehicle
        /// > int seat
        ///
        /// </summary>
        TASK_WARP_PED_INTO_VEHICLE = 0x9A7D091411C5F684,
        /// <summary>
        /// //this part of the code is to determine at which entity the player is aiming, for example if you want to create a mod where you give orders to peds
        /// Entity aimedentity;
        /// Player player = PLAYER::PLAYER_ID();
        /// PLAYER::_GET_AIMED_ENTITY(player, &aimedentity);
        /// 
        /// //bg is an array of peds
        /// TASK::TASK_SHOOT_AT_ENTITY(bg[i], aimedentity, 5000, MISC::GET_HASH_KEY("FIRING_PATTERN_FULL_AUTO"));
        /// 
        /// in practical usage, getting the entity the player is aiming at and then task the peds to shoot at the entity, at a button press event would be better.
        /// 
        /// Firing Pattern Hash Information: https://pastebin.com/Px036isB
        ///
        /// > Entity entity
        /// > Entity target
        /// > int duration
        /// > Hash firingPattern
        ///
        /// </summary>
        TASK_SHOOT_AT_ENTITY = 0x08DA95E8298AE772,
        /// <summary>
        /// Climbs or vaults the nearest thing.
        ///
        /// > Ped ped
        /// > BOOL unused
        ///
        /// </summary>
        TASK_CLIMB = 0x89D9FCC2435112F1,
        /// <summary>
        /// Immediately stops the pedestrian from whatever it's doing. They stop fighting, animations, etc. they forget what they were doing.
        ///
        /// > Ped ped
        ///
        /// </summary>
        CLEAR_PED_TASKS_IMMEDIATELY = 0xAAA34F8A7CB32098,
        /// <summary>
        /// This native does absolutely nothing, just a nullsub
        ///
        /// > float p0
        ///
        /// </summary>
        SET_NEXT_DESIRED_MOVE_STATE = 0xF1B9F16E89E2C93A,
        /// <summary>
        /// eg
        /// 
        ///  TASK::TASK_GOTO_ENTITY_AIMING(v_2, PLAYER::PLAYER_PED_ID(), 5.0, 25.0);
        /// 
        /// ped = Ped you want to perform this task.
        /// target = the Entity they should aim at.
        /// distanceToStopAt = distance from the target, where the ped should stop to aim.
        /// StartAimingDist = distance where the ped should start to aim.
        ///
        /// > Ped ped
        /// > Entity target
        /// > float distanceToStopAt
        /// > float StartAimingDist
        ///
        /// </summary>
        TASK_GOTO_ENTITY_AIMING = 0xA9DA48FAB8A76C12,
        /// <summary>
        /// p1 is always GET_HASH_KEY("empty") in scripts, for the rare times this is used
        ///
        /// > Ped ped
        /// > Hash p1
        ///
        /// </summary>
        TASK_SET_DECISION_MAKER = 0xEB8517DDA73720DA,
        /// <summary>
        /// Checks if there is a cover point at position
        ///
        /// > float x
        /// > float y
        /// > float z
        ///
        /// </summary>
        DOES_SCRIPTED_COVER_POINT_EXIST_AT_COORDS = 0xA98B8E3C088E5A31,
        /// <summary>
        /// Makes the specified ped attack the target ped.
        /// p2 should be 0
        /// p3 should be 16
        ///
        /// > Ped ped
        /// > Ped targetPed
        /// > int p2
        /// > int p3
        ///
        /// </summary>
        TASK_COMBAT_PED = 0xF166E48407BAC484,
        /// <summary>
        /// from michael2:
        /// TASK::TASK_SEEK_COVER_TO_COORDS(ped, 967.5164794921875, -2121.603515625, 30.479299545288086, 978.94677734375, -2125.84130859375, 29.4752, -1, 1);
        /// 
        /// 
        /// appears to be shorter variation
        /// from michael3:
        /// TASK::TASK_SEEK_COVER_TO_COORDS(ped, -2231.011474609375, 263.6326599121094, 173.60195922851562, -1, 0);
        ///
        /// > Ped ped
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > Any p7
        /// > BOOL p8
        ///
        /// </summary>
        TASK_SEEK_COVER_TO_COORDS = 0x39246A6958EF072C,
        /// <summary>
        /// from armenian3.c4
        /// 
        /// TASK::TASK_PUT_PED_DIRECTLY_INTO_MELEE(PlayerPed, armenianPed, 0.0, -1.0, 0.0, 0);
        /// 
        ///
        /// > Ped ped
        /// > Ped meleeTarget
        /// > float p2
        /// > float p3
        /// > float p4
        /// > BOOL p5
        ///
        /// </summary>
        TASK_PUT_PED_DIRECTLY_INTO_MELEE = 0x1C6CD14A876FFE39,
        /// <summary>
        /// used in sequence task
        /// 
        /// both parameters seems to be always 0
        ///
        /// > BOOL p0
        /// > BOOL p1
        ///
        /// </summary>
        TASK_TOGGLE_DUCK = 0xAC96609B9995EDF8,
        /// <summary>
        /// From re_prisonvanbreak:
        /// 
        /// TASK::TASK_GUARD_CURRENT_POSITION(l_DD, 35.0, 35.0, 1);
        ///
        /// > Ped p0
        /// > float p1
        /// > float p2
        /// > BOOL p3
        ///
        /// </summary>
        TASK_GUARD_CURRENT_POSITION = 0x4A58A47A72E3FCB4,
        /// <summary>
        /// p0 - Guessing PedID
        /// p1, p2, p3 - XYZ?
        /// p4 - ???
        /// p5 - Maybe the size of sphere from XYZ?
        /// p6 - ???
        /// p7, p8, p9 - XYZ again?
        /// p10 - Maybe the size of sphere from second XYZ?
        ///
        /// > Ped p0
        /// > float p1
        /// > float p2
        /// > float p3
        /// > float p4
        /// > float p5
        /// > Any p6
        /// > float p7
        /// > float p8
        /// > float p9
        /// > float p10
        ///
        /// </summary>
        TASK_GUARD_SPHERE_DEFENSIVE_AREA = 0xC946FE14BE0EB5E2,
        /// <summary>
        /// scenarioName example: "WORLD_HUMAN_GUARD_STAND"
        ///
        /// > Ped ped
        /// > float x
        /// > float y
        /// > float z
        /// > float heading
        /// > const char* scenarioName
        ///
        /// </summary>
        TASK_STAND_GUARD = 0xAE032F8BBA959E90,
        /// <summary>
        /// This native is used to set the driving style for specific ped.
        /// 
        /// Driving styles id seems to be:
        /// 786468
        /// 262144
        /// 786469
        /// 
        /// http://gtaforums.com/topic/822314-guide-driving-styles/
        ///
        /// > Ped ped
        /// > int drivingStyle
        ///
        /// </summary>
        SET_DRIVE_TASK_DRIVING_STYLE = 0xDACE1BE37D88AF67,
        /// <summary>
        /// Plays a scenario on a Ped at their current location.
        /// 
        /// unkDelay - Usually 0 or -1, doesn't seem to have any effect. Might be a delay between sequences.
        /// playEnterAnim - Plays the "Enter" anim if true, otherwise plays the "Exit" anim. Scenarios that don't have any "Enter" anims won't play if this is set to true.
        /// 
        /// ----
        /// 
        /// From "am_hold_up.ysc.c4" at line 339:
        /// 
        /// TASK::TASK_START_SCENARIO_IN_PLACE(NETWORK::NET_TO_PED(l_8D._f4), sub_adf(), 0, 1);
        /// 
        /// I'm unsure of what the last two parameters are, however sub_adf() randomly returns 1 of 3 scenarios, those being:
        /// WORLD_HUMAN_SMOKING
        /// WORLD_HUMAN_HANG_OUT_STREET
        /// WORLD_HUMAN_STAND_MOBILE
        /// 
        /// This makes sense, as these are what I commonly see when going by a liquor store.
        /// -------------------------
        /// List of scenarioNames: pastebin.com/6mrYTdQv
        /// (^ Thank you so fucking much for this)
        /// 
        /// Also these:
        /// WORLD_FISH_FLEE
        /// DRIVE
        /// WORLD_HUMAN_HIKER
        /// WORLD_VEHICLE_ATTRACTOR
        /// WORLD_VEHICLE_BICYCLE_MOUNTAIN
        /// WORLD_VEHICLE_BIKE_OFF_ROAD_RACE
        /// WORLD_VEHICLE_BIKER
        /// WORLD_VEHICLE_CONSTRUCTION_PASSENGERS
        /// WORLD_VEHICLE_CONSTRUCTION_SOLO
        /// WORLD_VEHICLE_DRIVE_PASSENGERS
        /// WORLD_VEHICLE_DRIVE_SOLO
        /// WORLD_VEHICLE_EMPTY
        /// WORLD_VEHICLE_PARK_PARALLEL
        /// WORLD_VEHICLE_PARK_PERPENDICULAR_NOSE_IN
        /// WORLD_VEHICLE_POLICE_BIKE
        /// WORLD_VEHICLE_POLICE_CAR
        /// WORLD_VEHICLE_POLICE_NEXT_TO_CAR
        /// WORLD_VEHICLE_SALTON_DIRT_BIKE
        /// WORLD_VEHICLE_TRUCK_LOGS
        /// 
        /// Full list of ped scenarios by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/scenariosCompact.json
        ///
        /// > Ped ped
        /// > const char* scenarioName
        /// > int unkDelay
        /// > BOOL playEnterAnim
        ///
        /// </summary>
        TASK_START_SCENARIO_IN_PLACE = 0x142A02425FF02BD9,
        /// <summary>
        /// Full list of ped scenarios by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/scenariosCompact.json
        /// 
        /// Also a few more listed at TASK::TASK_START_SCENARIO_IN_PLACE just above.
        /// ---------------
        /// The first parameter in every scenario has always been a Ped of some sort. The second like TASK_START_SCENARIO_IN_PLACE is the name of the scenario. 
        /// 
        /// The next 4 parameters were harder to decipher. After viewing "hairdo_shop_mp.ysc.c4", and being confused from seeing the case in other scripts, they passed the first three of the arguments as one array from a function, and it looked like it was obviously x, y, and z.
        /// 
        /// I haven't seen the sixth parameter go to or over 360, making me believe that it is rotation, but I really can't confirm anything.
        /// 
        /// I have no idea what the last 3 parameters are, but I'll try to find out.
        /// 
        /// -going on the last 3 parameters, they appear to always be "0, 0, 1"
        /// 
        /// p6 -1 also used in scrips
        /// 
        /// p7 used for sitting scenarios
        /// 
        /// p8 teleports ped to position
        ///
        /// > Ped ped
        /// > const char* scenarioName
        /// > float x
        /// > float y
        /// > float z
        /// > float heading
        /// > int duration
        /// > BOOL sittingScenario
        /// > BOOL teleport
        ///
        /// </summary>
        TASK_START_SCENARIO_AT_POSITION = 0xFA4EFC79F69D4F07,
        /// <summary>
        /// Updated variables
        /// 
        /// An alternative to TASK::TASK_USE_NEAREST_SCENARIO_TO_COORD_WARP. Makes the ped walk to the scenario instead.
        ///
        /// > Ped ped
        /// > float x
        /// > float y
        /// > float z
        /// > float distance
        /// > int duration
        ///
        /// </summary>
        TASK_USE_NEAREST_SCENARIO_TO_COORD = 0x277F471BA9DB000B,
        /// <summary>
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        ///
        /// > Ped ped
        /// > const char* animDict
        /// > const char* animName
        ///
        /// </summary>
        PLAY_ANIM_ON_RUNNING_SCENARIO = 0x748040460F8DF5DC,
        /// <summary>
        /// Occurrences in the b617d scripts:
        /// 
        /// "ARMY_GUARD",
        /// "ARMY_HELI",
        /// "Cinema_Downtown",
        /// "Cinema_Morningwood",
        /// "Cinema_Textile",
        /// "City_Banks",
        /// "Countryside_Banks",
        /// "DEALERSHIP",
        /// "GRAPESEED_PLANES",
        /// "KORTZ_SECURITY",
        /// "LOST_BIKERS",
        /// "LSA_Planes",
        /// "LSA_Planes",
        /// "MP_POLICE",
        /// "Observatory_Bikers", 
        /// "POLICE_POUND1",
        /// "POLICE_POUND2",
        /// "POLICE_POUND3",
        /// "POLICE_POUND4",
        /// "POLICE_POUND5"
        /// "QUARRY",
        /// "SANDY_PLANES",
        /// "SCRAP_SECURITY",
        /// "SEW_MACHINE",
        /// "SOLOMON_GATE",
        /// "Triathlon_1_Start", 
        /// "Triathlon_2_Start", 
        /// "Triathlon_3_Start"
        /// 
        /// Sometimes used with IS_SCENARIO_GROUP_ENABLED:
        /// if (TASK::DOES_SCENARIO_GROUP_EXIST("Observatory_Bikers") && (!TASK::IS_SCENARIO_GROUP_ENABLED("Observatory_Bikers"))) {
        /// else if (TASK::IS_SCENARIO_GROUP_ENABLED("BLIMP")) {
        /// 
        ///
        /// > const char* scenarioGroup
        ///
        /// </summary>
        DOES_SCENARIO_GROUP_EXIST = 0xF9034C136C9E00D3,
        /// <summary>
        ///  Occurrences in the b617d scripts: 
        /// 
        ///  "ARMY_GUARD",
        ///  "ARMY_HELI",
        ///  "BLIMP",
        ///  "Cinema_Downtown",
        ///  "Cinema_Morningwood",
        ///  "Cinema_Textile",
        ///  "City_Banks",
        ///  "Countryside_Banks",
        ///  "DEALERSHIP",
        ///  "KORTZ_SECURITY",
        ///  "LSA_Planes",
        ///  "MP_POLICE",
        ///  "Observatory_Bikers",
        ///  "POLICE_POUND1",
        ///  "POLICE_POUND2",
        ///  "POLICE_POUND3",
        ///  "POLICE_POUND4",
        ///  "POLICE_POUND5",
        ///  "Rampage1",
        ///  "SANDY_PLANES",
        ///  "SCRAP_SECURITY",
        ///  "SEW_MACHINE",
        ///  "SOLOMON_GATE"
        /// 
        /// Sometimes used with DOES_SCENARIO_GROUP_EXIST:
        /// if (TASK::DOES_SCENARIO_GROUP_EXIST("Observatory_Bikers") &&   (!TASK::IS_SCENARIO_GROUP_ENABLED("Observatory_Bikers"))) {
        /// else if (TASK::IS_SCENARIO_GROUP_ENABLED("BLIMP")) {
        ///
        /// > const char* scenarioGroup
        ///
        /// </summary>
        IS_SCENARIO_GROUP_ENABLED = 0x367A09DED4E05B99,
        /// <summary>
        /// Occurrences in the b617d scripts: pastebin.com/Tvg2PRHU
        ///
        /// > const char* scenarioGroup
        /// > BOOL p1
        ///
        /// </summary>
        SET_SCENARIO_GROUP_ENABLED = 0x02C8E5B49848664E,
        /// <summary>
        /// Groups found in the scripts used with this native:
        /// 
        /// "AMMUNATION",
        /// "QUARRY",
        /// "Triathlon_1",
        /// "Triathlon_2",
        /// "Triathlon_3"
        ///
        /// > const char* scenarioGroup
        ///
        /// </summary>
        SET_EXCLUSIVE_SCENARIO_GROUP = 0x535E97E1F7FC0C6A,
        /// <summary>
        /// Occurrences in the b617d scripts:
        /// "PROP_HUMAN_SEAT_CHAIR",
        /// "WORLD_HUMAN_DRINKING",
        /// "WORLD_HUMAN_HANG_OUT_STREET",
        /// "WORLD_HUMAN_SMOKING",
        /// "WORLD_MOUNTAIN_LION_WANDER",
        /// "WORLD_HUMAN_DRINKING"
        /// 
        /// Sometimes used together with MISC::IS_STRING_NULL_OR_EMPTY in the scripts.
        /// 
        /// scenarioType could be the same as scenarioName, used in for example TASK::TASK_START_SCENARIO_AT_POSITION.
        /// 
        ///
        /// > const char* scenarioType
        ///
        /// </summary>
        IS_SCENARIO_TYPE_ENABLED = 0x3A815DB3EA088722,
        /// <summary>
        /// seems to enable/disable specific scenario-types from happening in the game world.
        /// 
        /// Here are some scenario types from the scripts:
        /// "WORLD_MOUNTAIN_LION_REST"                                             
        /// "WORLD_MOUNTAIN_LION_WANDER"                                            
        /// "DRIVE"                                                                  
        /// "WORLD_VEHICLE_POLICE_BIKE"                                             
        /// "WORLD_VEHICLE_POLICE_CAR"                                             
        /// "WORLD_VEHICLE_POLICE_NEXT_TO_CAR"                                        
        /// "WORLD_VEHICLE_DRIVE_SOLO"                                                 
        /// "WORLD_VEHICLE_BIKER"                                                      
        /// "WORLD_VEHICLE_DRIVE_PASSENGERS"                                           
        /// "WORLD_VEHICLE_SALTON_DIRT_BIKE"                                           
        /// "WORLD_VEHICLE_BICYCLE_MOUNTAIN"                                           
        /// "PROP_HUMAN_SEAT_CHAIR"                                             
        /// "WORLD_VEHICLE_ATTRACTOR"                                             
        /// "WORLD_HUMAN_LEANING"                                                 
        /// "WORLD_HUMAN_HANG_OUT_STREET"                                        
        /// "WORLD_HUMAN_DRINKING"                                                
        /// "WORLD_HUMAN_SMOKING"                                                
        /// "WORLD_HUMAN_GUARD_STAND"                                            
        /// "WORLD_HUMAN_CLIPBOARD"                                              
        /// "WORLD_HUMAN_HIKER"                                                  
        /// "WORLD_VEHICLE_EMPTY"                                                      
        /// "WORLD_VEHICLE_BIKE_OFF_ROAD_RACE"                                      
        /// "WORLD_HUMAN_PAPARAZZI"                                               
        /// "WORLD_VEHICLE_PARK_PERPENDICULAR_NOSE_IN"                            
        /// "WORLD_VEHICLE_PARK_PARALLEL"                                              
        /// "WORLD_VEHICLE_CONSTRUCTION_SOLO"                               
        /// "WORLD_VEHICLE_CONSTRUCTION_PASSENGERS"                                                                    
        /// "WORLD_VEHICLE_TRUCK_LOGS" 
        /// -alphazolam
        /// 
        /// scenarioType could be the same as scenarioName, used in for example TASK::TASK_START_SCENARIO_AT_POSITION.
        ///
        /// > const char* scenarioType
        /// > BOOL toggle
        ///
        /// </summary>
        SET_SCENARIO_TYPE_ENABLED = 0xEB47EC4E34FB7EE1,
        /// <summary>
        /// Used only once (am_mp_property_int)
        /// 
        /// ped was PLAYER_PED_ID()
        /// 
        /// Related to CTaskAmbientClips.
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_PLAYING_BASE_CLIP_IN_SCENARIO = 0x621C6E4729388E41,
        /// <summary>
        /// Appears only in fm_mission_controller and used only 3 times.
        /// 
        /// ped was always PLAYER_PED_ID()
        /// p1 was always true
        /// p2 was always true
        ///
        /// > Ped ped
        /// > BOOL p1
        /// > BOOL p2
        ///
        /// </summary>
        SET_PED_CAN_PLAY_AMBIENT_IDLES = 0x8FD89A6240813FD0,
        /// <summary>
        /// Despite its name, it only attacks ONE hated target. The one closest to the specified position.
        ///
        /// > Ped ped
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        /// > Any p5
        ///
        /// </summary>
        TASK_COMBAT_HATED_TARGETS_IN_AREA = 0x4CF5F55DAC3280A0,
        /// <summary>
        /// Despite its name, it only attacks ONE hated target. The one closest hated target.
        /// 
        /// p2 seems to be always 0
        ///
        /// > Ped ped
        /// > float radius
        /// > int p2
        ///
        /// </summary>
        TASK_COMBAT_HATED_TARGETS_AROUND_PED = 0x7BF835BB9E2698C8,
        /// <summary>
        /// In every case of this native, I've only seen the first parameter passed as 0, although I believe it's a Ped after seeing tasks around it using 0. That's because it's used in a Sequence Task.
        /// 
        /// The last 3 parameters are definitely coordinates after seeing them passed in other scripts, and even being used straight from the player's coordinates.
        /// ---
        /// It seems that - in the decompiled scripts - this native was used on a ped who was in a vehicle to throw a projectile out the window at the player. This is something any ped will naturally do if they have a throwable and they are doing driveby-combat (although not very accurately).
        /// It is possible, however, that this is how SWAT throws smoke grenades at the player when in cover.
        /// ----------------------------------------------------
        /// The first comment is right it definately is the ped as if you look in script finale_heist2b.c line 59628 in Xbox Scripts atleast you will see task_throw_projectile and the first param is Local_559[2 <14>] if you look above it a little bit line 59622 give_weapon_to_ped uses the same exact param Local_559[2 <14>] and we all know the first param of that native is ped. So it guaranteed has to be ped. 0 just may mean to use your ped by default for some reason.
        ///
        /// > Ped ped
        /// > float x
        /// > float y
        /// > float z
        /// > Any p4
        /// > Any p5
        ///
        /// </summary>
        TASK_THROW_PROJECTILE = 0x7285951DBF6B5A51,
        /// <summary>
        /// The 2nd param (unused) is not implemented.
        /// 
        /// -----------------------------------------------------------------------
        /// 
        /// The only occurrence I found in a R* script ("assassin_construction.ysc.c4"):
        /// 
        ///             if (((v_3 < v_4) && (TASK::GET_SCRIPT_TASK_STATUS(PLAYER::PLAYER_PED_ID(), 0x6a67a5cc) != 1)) && (v_5 > v_3)) {
        ///                 TASK::TASK_RELOAD_WEAPON(PLAYER::PLAYER_PED_ID(), 1);
        ///             }
        ///
        /// > Ped ped
        /// > BOOL unused
        ///
        /// </summary>
        TASK_RELOAD_WEAPON = 0x62D2916F56B9CD2D,
        /// <summary>
        /// EX: Function.Call(Ped1, Ped2, Time, 0);
        /// 
        /// The last parameter is always 0 for some reason I do not know. The first parameter is the pedestrian who will writhe to the pedestrian in the other parameter. The third paremeter is how long until the Writhe task ends. When the task ends, the ped will die. If set to -1, he will not die automatically, and the task will continue until something causes it to end. This can be being touched by an entity, being shot, explosion, going into ragdoll, having task cleared. Anything that ends the current task will kill the ped at this point.
        /// 
        /// 
        /// 
        /// MulleDK19: Third parameter does not appear to be time. The last parameter is not implemented (It's not used, regardless of value).
        ///
        /// > Ped ped
        /// > Ped target
        /// > int time
        /// > int p3
        /// > Any p4
        /// > Any p5
        ///
        /// </summary>
        TASK_WRITHE = 0xCDDC2B77CE54AC6E,
        /// <summary>
        /// This native checks if a ped is on the ground, in pain from a (gunshot) wound.
        /// Returns `true` if the ped is in writhe, `false` otherwise.
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_IN_WRITHE = 0xDEB6D52126E7D640,
        /// <summary>
        ///  patrolRoutes found in the b617d scripts:
        ///  "miss_Ass0",
        ///  "miss_Ass1",
        ///  "miss_Ass2",
        ///  "miss_Ass3",
        ///  "miss_Ass4",
        ///  "miss_Ass5",
        ///  "miss_Ass6",
        ///  "MISS_PATROL_6",
        ///  "MISS_PATROL_7",
        ///  "MISS_PATROL_8",
        ///  "MISS_PATROL_9",
        ///  "miss_Tower_01",
        ///  "miss_Tower_02",
        ///  "miss_Tower_03",
        ///  "miss_Tower_04",
        ///  "miss_Tower_05",
        ///  "miss_Tower_06",
        ///  "miss_Tower_07",
        ///  "miss_Tower_08",
        ///  "miss_Tower_10"
        ///
        /// > const char* patrolRoute
        ///
        /// </summary>
        OPEN_PATROL_ROUTE = 0xA36BFB5EE89F3D82,
        /// <summary>
        /// Example: 
        /// TASK::ADD_PATROL_ROUTE_NODE(2, "WORLD_HUMAN_GUARD_STAND", -193.4915, -2378.864990234375, 10.9719, -193.4915, -2378.864990234375, 10.9719, 3000);
        /// 
        /// p0 is between 0 and 4 in the scripts.
        /// 
        /// p1 is "WORLD_HUMAN_GUARD_STAND" or "StandGuard".
        /// 
        /// p2, p3 and p4 is only one parameter sometimes in the scripts. Most likely a Vector3 hence p2, p3 and p4 are coordinates. 
        /// Examples: 
        /// TASK::ADD_PATROL_ROUTE_NODE(1, "WORLD_HUMAN_GUARD_STAND", l_739[7/*3*/], 0.0, 0.0, 0.0, 0);
        /// 
        /// TASK::ADD_PATROL_ROUTE_NODE(1, "WORLD_HUMAN_GUARD_STAND", l_B0[17/*44*/]._f3, l_B0[17/*44*/]._f3, 2000);
        /// 
        /// p5, p6 and p7 are for example set to: 1599.0406494140625, 2713.392578125, 44.4309.
        /// 
        /// p8 is an int, often random set to for example: MISC::GET_RANDOM_INT_IN_RANGE(5000, 10000).
        ///
        /// > int p0
        /// > const char* p1
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > int p8
        ///
        /// </summary>
        ADD_PATROL_ROUTE_NODE = 0x8EDF950167586B7C,
        /// <summary>
        /// From the b617d scripts:
        /// 
        /// TASK::DELETE_PATROL_ROUTE("miss_merc0");
        /// TASK::DELETE_PATROL_ROUTE("miss_merc1");
        /// TASK::DELETE_PATROL_ROUTE("miss_merc2");
        /// TASK::DELETE_PATROL_ROUTE("miss_dock");
        ///
        /// > const char* patrolRoute
        ///
        /// </summary>
        DELETE_PATROL_ROUTE = 0x7767DD9D65E91319,
        /// <summary>
        /// After looking at some scripts the second parameter seems to be an id of some kind. Here are some I found from some R* scripts:
        /// 
        /// "miss_Tower_01" (this went from 01 - 10)
        /// "miss_Ass0" (0, 4, 6, 3)
        /// "MISS_PATROL_8"
        /// 
        /// I think they're patrol routes, but I'm not sure. And I believe the 3rd parameter is a BOOL, but I can't confirm other than only seeing 0 and 1 being passed.
        /// 
        /// 
        /// As far as I can see the patrol routes names such as "miss_Ass0" have been defined earlier in the scripts. This leads me to believe we can defined our own new patrol routes by following the same approach. 
        /// From the scripts
        /// 
        ///     TASK::OPEN_PATROL_ROUTE("miss_Ass0");
        ///     TASK::ADD_PATROL_ROUTE_NODE(0, "WORLD_HUMAN_GUARD_STAND", l_738[0/*3*/], -139.4076690673828, -993.4732055664062, 26.2754, MISC::GET_RANDOM_INT_IN_RANGE(5000, 10000));
        ///     TASK::ADD_PATROL_ROUTE_NODE(1, "WORLD_HUMAN_GUARD_STAND", l_738[1/*3*/], -116.1391830444336, -987.4984130859375, 26.38541030883789, MISC::GET_RANDOM_INT_IN_RANGE(5000, 10000));
        ///     TASK::ADD_PATROL_ROUTE_NODE(2, "WORLD_HUMAN_GUARD_STAND", l_738[2/*3*/], -128.46847534179688, -979.0340576171875, 26.2754, MISC::GET_RANDOM_INT_IN_RANGE(5000, 10000));
        ///     TASK::ADD_PATROL_ROUTE_LINK(0, 1);
        ///     TASK::ADD_PATROL_ROUTE_LINK(1, 2);
        ///     TASK::ADD_PATROL_ROUTE_LINK(2, 0);
        ///     TASK::CLOSE_PATROL_ROUTE();
        ///     TASK::CREATE_PATROL_ROUTE();
        /// 
        /// 
        ///
        /// > Ped ped
        /// > const char* p1
        /// > Any p2
        /// > BOOL p3
        /// > BOOL p4
        ///
        /// </summary>
        TASK_PATROL = 0xBDA5DF49D080FE4E,
        /// <summary>
        /// Makes the ped run to take cover
        ///
        /// > Ped ped
        ///
        /// </summary>
        TASK_STAY_IN_COVER = 0xE5DA8615A6180789,
        /// <summary>
        /// x, y, z: offset in world coords from some entity.
        ///
        /// > Ped ped
        /// > float x
        /// > float y
        /// > float z
        ///
        /// </summary>
        ADD_VEHICLE_SUBTASK_ATTACK_COORD = 0x5CF0D8F9BBA0DD75,
        /// <summary>
        /// Differs from TASK_VEHICLE_DRIVE_TO_COORDS in that it will pick the shortest possible road route without taking one-way streets and other "road laws" into consideration.
        /// 
        /// WARNING:
        /// A behaviorFlag value of 0 will result in a clunky, stupid driver!
        /// 
        /// Recommended settings:
        /// speed = 30.0f,
        /// behaviorFlag = 156, 
        /// stoppingRange = 5.0f;
        /// 
        /// If you simply want to have your driver move to a fixed location, call it only once, or, when necessary in the event of interruption. 
        /// 
        /// If using this to continually follow a Ped who is on foot:  You will need to run this in a tick loop.  Call it in with the Ped's updated coordinates every 20 ticks or so and you will have one hell of a smart, fast-reacting NPC driver -- provided he doesn't get stuck.  If your update frequency is too fast, the Ped may not have enough time to figure his way out of being stuck, and thus, remain stuck.  One way around this would be to implement an "anti-stuck" mechanism, which allows the driver to realize he's stuck, temporarily pause the tick, unstuck, then resume the tick.
        /// 
        /// EDIT:  This is being discussed in more detail at http://gtaforums.com/topic/818504-any-idea-on-how-to-make-peds-clever-and-insanely-fast-c/  
        ///
        /// > Ped ped
        /// > Vehicle vehicle
        /// > float x
        /// > float y
        /// > float z
        /// > float speed
        /// > int behaviorFlag
        /// > float stoppingRange
        ///
        /// </summary>
        TASK_VEHICLE_GOTO_NAVMESH = 0x195AEEB13CEFE2EE,
        /// <summary>
        /// movement_speed: mostly 2f, but also 1/1.2f, etc.
        /// p8: always false
        /// p9: 2f
        /// p10: 0.5f
        /// p11: true
        /// p12: 0 / 512 / 513, etc.
        /// p13: 0
        /// firing_pattern: ${firing_pattern_full_auto}, 0xC6EE6B4C
        ///
        /// > Ped ped
        /// > float x
        /// > float y
        /// > float z
        /// > float aimAtX
        /// > float aimAtY
        /// > float aimAtZ
        /// > float moveSpeed
        /// > BOOL p8
        /// > float p9
        /// > float p10
        /// > BOOL p11
        /// > Any flags
        /// > BOOL p13
        /// > Hash firingPattern
        ///
        /// </summary>
        TASK_GO_TO_COORD_WHILE_AIMING_AT_COORD = 0x11315AB3385B8AC0,
        /// <summary>
        /// The ped will walk or run towards goToLocation, aiming towards goToLocation or focusLocation (depending on the aimingFlag) and shooting if shootAtEnemies = true to any enemy in his path.
        /// 
        /// If the ped is closer than noRoadsDistance, the ped will ignore pathing/navmesh and go towards goToLocation directly. This could cause the ped to get stuck behind tall walls if the goToLocation is on the other side. To avoid this, use 0.0f and the ped will always use pathing/navmesh to reach his destination.
        /// 
        /// If the speed is set to 0.0f, the ped will just stand there while aiming, if set to 1.0f he will walk while aiming, 2.0f will run while aiming.
        /// 
        /// The ped will stop aiming when he is closer than distanceToStopAt to goToLocation.
        /// 
        /// I still can't figure out what unkTrue is used for. I don't notice any difference if I set it to false but in the decompiled scripts is always true.
        /// 
        /// I think that unkFlag, like the driving styles, could be a flag that "work as a list of 32 bits converted to a decimal integer. Each bit acts as a flag, and enables or disables a function". What leads me to this conclusion is the fact that in the decompiled scripts, unkFlag takes values like: 0, 1, 5 (101 in binary) and 4097 (4096 + 1 or 1000000000001 in binary). For now, I don't know what behavior enable or disable this possible flag so I leave it at 0.
        /// 
        /// Note: After some testing, using unkFlag = 16 (0x10) enables the use of sidewalks while moving towards goToLocation.
        /// 
        /// The aimingFlag takes 2 values: 0 to aim at the focusLocation, 1 to aim at where the ped is heading (goToLocation).
        /// 
        /// Example:
        /// 
        /// enum AimFlag
        /// {
        ///    AimAtFocusLocation,
        ///    AimAtGoToLocation
        /// };
        /// 
        /// Vector3 goToLocation1 = { 996.2867f, 0, -2143.044f, 0, 28.4763f, 0 }; // remember the padding.
        /// 
        /// Vector3 goToLocation2 = { 990.2867f, 0, -2140.044f, 0, 28.4763f, 0 }; // remember the padding.
        /// 
        /// Vector3 focusLocation = { 994.3478f, 0, -2136.118f, 0, 29.2463f, 0 }; // the coord z should be a little higher, around +1.0f to avoid aiming at the ground
        /// 
        /// // 1st example
        /// TASK::TASK_GO_TO_COORD_AND_AIM_AT_HATED_ENTITIES_NEAR_COORD(pedHandle, goToLocation1.x, goToLocation1.y, goToLocation1.z, focusLocation.x, focusLocation.y, focusLocation.z, 2.0f /*run*/, true /*shoot*/, 3.0f /*stop at*/, 0.0f /*noRoadsDistance*/, true /*always true*/, 0 /*possible flag*/, AimFlag::AimAtGoToLocation, -957453492 /*FullAuto pattern*/);
        /// 
        /// // 2nd example
        /// TASK::TASK_GO_TO_COORD_AND_AIM_AT_HATED_ENTITIES_NEAR_COORD(pedHandle, goToLocation2.x, goToLocation2.y, goToLocation2.z, focusLocation.x, focusLocation.y, focusLocation.z, 1.0f /*walk*/, false /*don't shoot*/, 3.0f /*stop at*/, 0.0f /*noRoadsDistance*/, true /*always true*/, 0 /*possible flag*/, AimFlag::AimAtFocusLocation, -957453492 /*FullAuto pattern*/);
        /// 
        /// 
        /// 1st example: The ped (pedhandle) will run towards goToLocation1. While running and aiming towards goToLocation1, the ped will shoot on sight to any enemy in his path, using "FullAuto" firing pattern. The ped will stop once he is closer than distanceToStopAt to goToLocation1.
        /// 
        /// 2nd example: The ped will walk towards goToLocation2. This time, while walking towards goToLocation2 and aiming at focusLocation, the ped will point his weapon on sight to any enemy in his path without shooting. The ped will stop once he is closer than distanceToStopAt to goToLocation2.
        ///
        /// > Ped pedHandle
        /// > float goToLocationX
        /// > float goToLocationY
        /// > float goToLocationZ
        /// > float focusLocationX
        /// > float focusLocationY
        /// > float focusLocationZ
        /// > float speed
        /// > BOOL shootAtEnemies
        /// > float distanceToStopAt
        /// > float noRoadsDistance
        /// > BOOL unkTrue
        /// > int unkFlag
        /// > int aimingFlag
        /// > Hash firingPattern
        ///
        /// </summary>
        TASK_GO_TO_COORD_AND_AIM_AT_HATED_ENTITIES_NEAR_COORD = 0xA55547801EB331FC,
        /// <summary>
        /// shootatEntity:
        /// If true, peds will shoot at Entity till it is dead.
        /// If false, peds will just walk till they reach the entity and will cease shooting.
        ///
        /// > Ped ped
        /// > Entity entityToWalkTo
        /// > Entity entityToAimAt
        /// > float speed
        /// > BOOL shootatEntity
        /// > float p5
        /// > float p6
        /// > BOOL p7
        /// > BOOL p8
        /// > Hash firingPattern
        ///
        /// </summary>
        TASK_GO_TO_ENTITY_WHILE_AIMING_AT_ENTITY = 0x97465886D35210E9,
        /// <summary>
        /// Makes the ped ragdoll like when falling from a great height
        ///
        /// > Ped ped
        /// > Any p1
        /// > Any p2
        /// > Any p3
        ///
        /// </summary>
        SET_HIGH_FALL_TASK = 0x8C825BDC7741D37C,
        /// <summary>
        /// Full list of waypoint recordings by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/waypointRecordings.json
        /// For a full list of the points, see here: goo.gl/wIH0vn
        /// 
        /// Max number of loaded recordings is 32.
        ///
        /// > const char* name
        ///
        /// </summary>
        REQUEST_WAYPOINT_RECORDING = 0x9EEFB62EB27B5792,
        /// <summary>
        /// Full list of waypoint recordings by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/waypointRecordings.json
        ///
        /// > const char* name
        ///
        /// </summary>
        GET_IS_WAYPOINT_RECORDING_LOADED = 0xCB4E8BE8A0063C5D,
        /// <summary>
        /// Full list of waypoint recordings by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/waypointRecordings.json
        ///
        /// > const char* name
        ///
        /// </summary>
        REMOVE_WAYPOINT_RECORDING = 0xFF1B8B4AA1C25DC8,
        /// <summary>
        /// Full list of waypoint recordings by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/waypointRecordings.json
        /// For a full list of the points, see here: goo.gl/wIH0vn
        ///
        /// > const char* name
        /// > int* points
        ///
        /// </summary>
        WAYPOINT_RECORDING_GET_NUM_POINTS = 0x5343532C01A07234,
        /// <summary>
        /// Full list of waypoint recordings by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/waypointRecordings.json
        /// For a full list of the points, see here: goo.gl/wIH0vn
        ///
        /// > const char* name
        /// > int point
        /// > Vector3* coord
        ///
        /// </summary>
        WAYPOINT_RECORDING_GET_COORD = 0x2FB897405C90B361,
        /// <summary>
        /// Full list of waypoint recordings by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/waypointRecordings.json
        ///
        /// > const char* name
        /// > int point
        ///
        /// </summary>
        WAYPOINT_RECORDING_GET_SPEED_AT_POINT = 0x005622AEBC33ACA9,
        /// <summary>
        /// Full list of waypoint recordings by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/waypointRecordings.json
        /// For a full list of the points, see here: goo.gl/wIH0vn
        ///
        /// > const char* name
        /// > float x
        /// > float y
        /// > float z
        /// > int* point
        ///
        /// </summary>
        WAYPOINT_RECORDING_GET_CLOSEST_WAYPOINT = 0xB629A298081F876F,
        /// <summary>
        /// Routes: "1_FIBStairs", "2_FIBStairs", "3_FIBStairs", "4_FIBStairs", "5_FIBStairs", "5_TowardsFire", "6a_FIBStairs", "7_FIBStairs", "8_FIBStairs", "Aprtmnt_1", "AssAfterLift", "ATM_1", "coroner2", "coroner_stairs", "f5_jimmy1", "fame1", "family5b", "family5c", "Family5d", "family5d", "FIB_Glass1", "FIB_Glass2", "FIB_Glass3", "finaBroute1A", "finalb1st", "finalB1sta", "finalbround", "finalbroute2", "Hairdresser1", "jan_foyet_ft_door", "Jo_3", "Lemar1", "Lemar2", "mansion_1", "Mansion_1", "pols_1", "pols_2", "pols_3", "pols_4", "pols_5", "pols_6", "pols_7", "pols_8", "Pro_S1", "Pro_S1a", "Pro_S2", "Towards_case", "trev_steps", "tunrs1", "tunrs2", "tunrs3", "Wave01457s"
        ///
        /// > const char* route
        ///
        /// </summary>
        ASSISTED_MOVEMENT_REQUEST_ROUTE = 0x817268968605947A,
        /// <summary>
        /// task_vehicle_follow_waypoint_recording(Ped p0, Vehicle p1, string p2, int p3, int p4, int p5, int p6, float.x p7, float.Y p8, float.Z p9, bool p10, int p11)
        /// 
        /// p2 = Waypoint recording string (found in update\update.rpf\x64\levels\gta5\waypointrec.rpf
        /// p3 = 786468
        /// p4 = 0
        /// p5 = 16
        /// p6 = -1 (angle?)
        /// p7/8/9 = usually v3.zero
        /// p10 = bool (repeat?)
        /// p11 = 1073741824
        /// 
        /// -khorio
        /// 
        /// Full list of waypoint recordings by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/waypointRecordings.json
        ///
        /// > Ped ped
        /// > Vehicle vehicle
        /// > const char* WPRecording
        /// > int p3
        /// > int p4
        /// > int p5
        /// > int p6
        /// > float p7
        /// > BOOL p8
        /// > float p9
        ///
        /// </summary>
        TASK_VEHICLE_FOLLOW_WAYPOINT_RECORDING = 0x3123FAA6DB1CF7ED,
        /// <summary>
        /// I cant believe I have to define this, this is one of the best natives.
        /// 
        /// It makes the ped ignore basically all shocking events around it. Occasionally the ped may comment or gesture, but other than that they just continue their daily activities. This includes shooting and wounding the ped. And - most importantly - they do not flee.
        /// 
        /// Since it is a task, every time the native is called the ped will stop for a moment. 
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        TASK_SET_BLOCKING_OF_NON_TEMPORARY_EVENTS = 0x90D2156198831D69,
        /// <summary>
        /// p2 always false
        /// 
        /// [30/03/2017] ins1de :
        /// 
        /// See FORCE_PED_MOTION_STATE
        ///
        /// > Ped ped
        /// > Hash state
        /// > BOOL p2
        ///
        /// </summary>
        TASK_FORCE_MOTION_STATE = 0x4F056E1AFFEF17AB,
        /// <summary>
        /// Example:
        /// TASK::TASK_MOVE_NETWORK_BY_NAME(PLAYER::PLAYER_PED_ID(), "arm_wrestling_sweep_paired_a_rev3", 0.0f, true, "mini@arm_wrestling", 0);
        ///
        /// > Ped ped
        /// > const char* task
        /// > float multiplier
        /// > BOOL p3
        /// > const char* animDict
        /// > int flags
        ///
        /// </summary>
        TASK_MOVE_NETWORK_BY_NAME = 0x2D537BA194896636,
        /// <summary>
        /// Example:
        /// TASK::TASK_MOVE_NETWORK_ADVANCED_BY_NAME(PLAYER::PLAYER_PED_ID(), "minigame_tattoo_michael_parts", 324.13f, 181.29f, 102.6f, 0.0f, 0.0f, 22.32f, 2, 0, false, 0, 0);
        ///
        /// > Ped ped
        /// > const char* p1
        /// > float p2
        /// > float p3
        /// > float p4
        /// > float p5
        /// > float p6
        /// > float p7
        /// > Any p8
        /// > float p9
        /// > BOOL p10
        /// > const char* animDict
        /// > int flags
        ///
        /// </summary>
        TASK_MOVE_NETWORK_ADVANCED_BY_NAME = 0xD5B35BEA41919ACB,
        /// <summary>
        /// Used only once in the scripts (am_mp_nightclub)
        ///
        /// > Ped ped
        /// > const char* p1
        /// > Any* data
        /// > float p3
        /// > BOOL p4
        /// > const char* animDict
        /// > int flags
        ///
        /// </summary>
        _TASK_MOVE_NETWORK_BY_NAME_WITH_INIT_PARAMS = 0x3D45B0B355C5E0C9,
        /// <summary>
        /// p0 - PLAYER::PLAYER_PED_ID();
        /// p1 - "Phase", "Wobble", "x_axis","y_axis","introphase","speed".
        /// p2 - From what i can see it goes up to 1f (maybe).
        /// 
        /// -LcGamingHD
        /// 
        /// Example: TASK::_D5BB4025AE449A4E(PLAYER::PLAYER_PED_ID(), "Phase", 0.5);
        ///
        /// > Ped ped
        /// > const char* signalName
        /// > float value
        ///
        /// </summary>
        SET_TASK_MOVE_NETWORK_SIGNAL_FLOAT = 0xD5BB4025AE449A4E,
        /// <summary>
        /// What's strafing?
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_STRAFING = 0xE45B7F222DE47E09,
        /// <summary>
        ///  TASK::TASK_SYNCHRONIZED_SCENE(ped, scene, "creatures@rottweiler@in_vehicle@std_car", "get_in", 1000.0, -8.0, 4, 0, 0x447a0000, 0);
        /// 
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        ///
        /// > Ped ped
        /// > int scene
        /// > const char* animDictionary
        /// > const char* animationName
        /// > float speed
        /// > float speedMultiplier
        /// > int duration
        /// > int flag
        /// > float playbackRate
        /// > Any p9
        ///
        /// </summary>
        TASK_SYNCHRONIZED_SCENE = 0xEEA929141F699854,
        /// <summary>
        /// This function is called on peds in vehicles.
        /// 
        /// anim: animation name
        /// p2, p3, p4: "sweep_low", "sweep_med" or "sweep_high"
        /// p5: no idea what it does but is usually -1
        ///
        /// > Ped ped
        /// > const char* anim
        /// > const char* p2
        /// > const char* p3
        /// > const char* p4
        /// > int p5
        /// > Vehicle vehicle
        /// > float p7
        /// > float p8
        ///
        /// </summary>
        TASK_SWEEP_AIM_ENTITY = 0x2047C02158D6405A,
        /// <summary>
        /// Example from "me_amanda1.ysc.c4":
        /// TASK::TASK_ARREST_PED(l_19F /* This is a Ped */ , PLAYER::PLAYER_PED_ID());
        /// 
        /// Example from "armenian1.ysc.c4":
        /// if (!PED::IS_PED_INJURED(l_B18[0/*1*/])) {
        ///     TASK::TASK_ARREST_PED(l_B18[0/*1*/], PLAYER::PLAYER_PED_ID());
        /// }
        /// 
        /// I would love to have time to experiment to see if a player Ped can arrest another Ped. Might make for a good cop mod.
        /// 
        /// 
        /// Looks like only the player can be arrested this way. Peds react and try to arrest you if you task them, but the player charater doesn't do anything if tasked to arrest another ped.
        ///
        /// > Ped ped
        /// > Ped target
        ///
        /// </summary>
        TASK_ARREST_PED = 0xF3B9A78A178572B1,
        /// <summary>
        /// This function is hard-coded to always return 0.
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_BEING_ARRESTED = 0x90A09F3A45FED688,
        /// <summary>
        /// IS_*
        ///
        /// > Ped ped
        ///
        /// </summary>
        _0x3E38E28A1D80DDF6 = 0x3E38E28A1D80DDF6,
        /// <summary>
        /// CLEAR_*
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _0x53DDC75BC3AC0A90 = 0x53DDC75BC3AC0A90,
        /// <summary>
        /// REMOVE_*
        ///
        /// > float x
        /// > float y
        /// > float z
        ///
        /// </summary>
        _0xFA83CA6776038F64 = 0xFA83CA6776038F64,
        /// <summary>
        /// Used only once in the scripts (fm_mission_controller) like so:
        /// 
        /// TASK::_0xAB13A5565480B6D9(iLocal_3160, "Cutting");
        /// 
        /// SET_*
        ///
        /// > Ped ped
        /// > const char* p1
        ///
        /// </summary>
        _0xAB13A5565480B6D9 = 0xAB13A5565480B6D9,
        /// <summary>
        /// Doesn't actually return anything.
        ///
        /// > Ped ped
        /// > BOOL p1
        ///
        /// </summary>
        _0x0FFB3C758E8C07B9 = 0x0FFB3C758E8C07B9,
        TASK_COWER = 0x3EB1FE9E8E908E15,
        UPDATE_TASK_HANDS_UP_DURATION = 0xA98FCAFD7893C834,
        TASK_GET_OFF_BOAT = 0x9C00E77AF14B2DFF,
        TASK_SKY_DIVE = 0x601736CFE536B0A0,
        SET_PARACHUTE_TASK_TARGET = 0xC313379AF0FCEDA7,
        SET_PARACHUTE_TASK_THRUST = 0x0729BAC1B8C64317,
        TASK_VEHICLE_DRIVE_TO_COORD_LONGRANGE = 0x158BB33F920D360C,
        TASK_VEHICLE_DRIVE_WANDER = 0x480142959D337D00,
        TASK_GO_STRAIGHT_TO_COORD = 0xD76B57B44F1E6F8B,
        TASK_GO_STRAIGHT_TO_COORD_RELATIVE_TO_ENTITY = 0x61E360B7E040D12E,
        TASK_REACT_AND_FLEE_PED = 0x72C896464915D1B1,
        TASK_SHOCKING_EVENT_REACT = 0x452419CBD838065B,
        TASK_WANDER_IN_AREA = 0xE054346CA3A0F315,
        TASK_WANDER_SPECIFIC = 0x6919A2F136426098,
        TASK_PLANT_BOMB = 0x965FEC691D55E9BF,
        TASK_FOLLOW_NAV_MESH_TO_COORD_ADVANCED = 0x17F58B88D085DBAC,
        SET_PED_PATH_CAN_USE_CLIMBOVERS = 0x8E06A6FE76C9EFF4,
        SET_PED_PATH_CAN_USE_LADDERS = 0x77A5B103C87F476E,
        SET_PED_PATH_CAN_DROP_FROM_HEIGHT = 0xE361C5C71C431A4F,
        SET_PED_PATH_MAY_ENTER_WATER = 0xF35425A4204367EC,
        SET_PED_PATH_PREFER_TO_AVOID_WATER = 0x38FE1EC73743793C,
        SET_PED_PATH_AVOID_FIRE = 0x4455517B28441E60,
        TASK_GO_TO_COORD_ANY_MEANS_EXTRA_PARAMS = 0x1DD45F9ECFDB1BC9,
        TASK_GO_TO_COORD_ANY_MEANS_EXTRA_PARAMS_WITH_CRUISE_SPEED = 0xB8ECD61F531A7B02,
        PLAY_ENTITY_SCRIPTED_ANIM = 0x77A1EEC547E7FCF1,
        SET_ANIM_WEIGHT = 0x207F1A47C0342F48,
        _SET_ANIM_PLAYBACK_TIME = 0xDDF3CB5A0A4C0B49,
        SET_ANIM_RATE = 0x032D49C5E359C847,
        SET_ANIM_LOOPED = 0x70033C3CC29A1FF4,
        TASK_STOP_PHONE_GESTURE_ANIMATION = 0x3FA00D4F4641BFAE,
        IS_PLAYING_PHONE_GESTURE_ANIM = 0xB8EBB1E9D3588C10,
        GET_PHONE_GESTURE_ANIM_CURRENT_TIME = 0x47619ABE8B268C60,
        GET_PHONE_GESTURE_ANIM_TOTAL_TIME = 0x1EE0F68A7C25DEC6,
        OPEN_SEQUENCE_TASK = 0xE8854A4326B9E12B,
        CLOSE_SEQUENCE_TASK = 0x39E72BC99E6360CB,
        TASK_PERFORM_SEQUENCE = 0x5ABA3986D90D8A3B,
        TASK_PERFORM_SEQUENCE_LOCALLY = 0x8C33220C8D78CA0D,
        CLEAR_SEQUENCE_TASK = 0x3841422E9C488D8C,
        SET_SEQUENCE_TO_REPEAT = 0x58C70CF3A41E4AE7,
        TASK_AIM_GUN_SCRIPTED = 0x7A192BE16D373D00,
        TASK_AIM_GUN_SCRIPTED_WITH_TARGET = 0x8605AF0DE8B3A5AC,
        UPDATE_TASK_AIM_GUN_SCRIPTED_TARGET = 0x9724FB59A3E72AD0,
        GET_CLIP_SET_FOR_SCRIPTED_GUN_TASK = 0x3A8CADC7D37AACC5,
        /// <summary>
        /// 
        /// 
        ///
        /// > Ped ped
        /// > float x
        /// > float y
        /// > float z
        /// > int time
        /// > BOOL p5
        /// > BOOL p6
        ///
        /// </summary>
        TASK_AIM_GUN_AT_COORD = 0x6671F3EEC681BDA1,
        CLEAR_PED_TASKS = 0xE1EF3C1216AFF2CD,
        CLEAR_PED_SECONDARY_TASK = 0x176CECF6F920D707,
        TASK_EVERYONE_LEAVE_VEHICLE = 0x7F93691AB4B92272,
        TASK_GOTO_ENTITY_OFFSET = 0xE39B4FF4FDEBDE27,
        TASK_GOTO_ENTITY_OFFSET_XY = 0x338E7EF52B6095A9,
        SET_TASK_VEHICLE_CHASE_IDEAL_PURSUIT_DISTANCE = 0x639B642FACBE4EDD,
        TASK_PLANE_CHASE = 0x2D2386F273FF7A25,
        TASK_PLANE_LAND = 0xBF19721FA34D32C0,
        TASK_PLANE_GOTO_PRECISE_VTOL = 0xF7F9DCCA89E7505B,
        TASK_HELI_ESCORT_HELI = 0xB385523325077210,
        TASK_PLANE_TAXI = 0x92C360B5F15D2302,
        CLEAR_DRIVEBY_TASK_UNDERNEATH_DRIVING_TASK = 0xC35B5CDB2824CF69,
        IS_DRIVEBY_TASK_UNDERNEATH_DRIVING_TASK = 0x8785E6E40C7A8818,
        IS_MOUNTED_WEAPON_TASK_UNDERNEATH_DRIVING_TASK = 0xA320EF046186FA3B,
        TASK_USE_MOBILE_PHONE_TIMED = 0x5EE02954A14C69DB,
        TASK_CLIMB_LADDER = 0xB6C987F9285A3814,
        TASK_RAPPEL_DOWN_WALL = 0xEAF66ACDDC794793,
        TASK_PERFORM_SEQUENCE_FROM_PROGRESS = 0x89221B16730234F0,
        SET_PED_DESIRED_MOVE_BLEND_RATIO = 0x1E982AC8716912C5,
        GET_PED_DESIRED_MOVE_BLEND_RATIO = 0x8517D4A6CA8513ED,
        TASK_SET_SPHERE_DEFENSIVE_AREA = 0x933C06518B52A9A4,
        TASK_CLEAR_DEFENSIVE_AREA = 0x95A6C46A31D1917D,
        TASK_PED_SLIDE_TO_COORD = 0xD04FE6765D990A06,
        TASK_PED_SLIDE_TO_COORD_HDG_RATE = 0x5A4A6A6D3DC64F52,
        ADD_COVER_POINT = 0xD5C12A75C7B9497F,
        REMOVE_COVER_POINT = 0xAE287C923D891715,
        GET_SCRIPTED_COVER_POINT_COORDS = 0x594A1028FC2A3E85,
        TASK_COMBAT_PED_TIMED = 0x944F30DCB7096BDE,
        TASK_SEEK_COVER_FROM_POS = 0x75AC2B60386D89F2,
        TASK_SEEK_COVER_FROM_PED = 0x84D32B3BEC531324,
        TASK_SEEK_COVER_TO_COVER_POINT = 0xD43D95C7A869447F,
        TASK_PUT_PED_DIRECTLY_INTO_COVER = 0x4172393E6BE1FECE,
        TASK_EXIT_COVER = 0x79B258E397854D29,
        TASK_GUARD_ASSIGNED_DEFENSIVE_AREA = 0xD2A207EEBDF9889B,
        SET_DRIVE_TASK_CRUISE_SPEED = 0x5C9B84BD7D31D908,
        SET_DRIVE_TASK_MAX_CRUISE_SPEED = 0x404A5AA9B9F0B746,
        ADD_COVER_BLOCKING_AREA = 0x45C597097DD7CB81,
        REMOVE_ALL_COVER_BLOCKING_AREAS = 0xDB6708C0B46F56D8,
        TASK_USE_NEAREST_SCENARIO_TO_COORD_WARP = 0x58E2E0F23F6B76C3,
        TASK_USE_NEAREST_SCENARIO_CHAIN_TO_COORD = 0x9FDA1B3D7E7028B3,
        TASK_USE_NEAREST_SCENARIO_CHAIN_TO_COORD_WARP = 0x97A28E63F0BA5631,
        DOES_SCENARIO_EXIST_IN_AREA = 0x5A59271FFADD33C1,
        DOES_SCENARIO_OF_TYPE_EXIST_IN_AREA = 0x0A9D0C2A3BBC86C1,
        IS_SCENARIO_OCCUPIED = 0x788756D73AC2E07C,
        PED_HAS_USE_SCENARIO_TASK = 0x295E3CCEC879CCD7,
        RESET_SCENARIO_GROUPS_ENABLED = 0xDD902D0349AFAD3A,
        RESET_EXCLUSIVE_SCENARIO_GROUP = 0x4202BBCB8684563D,
        RESET_SCENARIO_TYPES_ENABLED = 0x0D40EE2A7F2B2D6D,
        IS_PED_ACTIVE_IN_SCENARIO = 0xAA135F9482C82CC3,
        TASK_COMBAT_HATED_TARGETS_AROUND_PED_TIMED = 0x2BBA30B854534A0C,
        TASK_SWAP_WEAPON = 0xA21C51255B205245,
        IS_PED_GETTING_UP = 0x2A74E1D5F2F00EEC,
        CLOSE_PATROL_ROUTE = 0xB043ECA801B8CBC1,
        ADD_PATROL_ROUTE_LINK = 0x23083260DEC3A551,
        CREATE_PATROL_ROUTE = 0xAF8A443CCC8018DC,
        ADD_VEHICLE_SUBTASK_ATTACK_PED = 0x85F462BADC7DA47F,
        TASK_VEHICLE_SHOOT_AT_PED = 0x10AB107B887214D8,
        TASK_VEHICLE_AIM_AT_PED = 0xE41885592B08B097,
        TASK_VEHICLE_SHOOT_AT_COORD = 0x5190796ED39C9B6D,
        TASK_VEHICLE_AIM_AT_COORD = 0x447C1E9EF844BC0F,
        TASK_GO_TO_COORD_WHILE_AIMING_AT_ENTITY = 0xB2A16444EAD9AE47,
        TASK_GO_TO_ENTITY_WHILE_AIMING_AT_COORD = 0x04701832B739DCE5,
        TASK_FOLLOW_WAYPOINT_RECORDING = 0x0759591819534F7B,
        IS_WAYPOINT_PLAYBACK_GOING_ON_FOR_PED = 0xE03B3F2D3DC59B64,
        GET_PED_WAYPOINT_PROGRESS = 0x2720AAA75001E094,
        GET_PED_WAYPOINT_DISTANCE = 0xE6A877C64CAF1BC5,
        SET_PED_WAYPOINT_ROUTE_OFFSET = 0xED98E10B0AFCE4B4,
        GET_WAYPOINT_DISTANCE_ALONG_ROUTE = 0xA5B769058763E497,
        WAYPOINT_PLAYBACK_GET_IS_PAUSED = 0x701375A7D43F01CB,
        WAYPOINT_PLAYBACK_PAUSE = 0x0F342546AA06FED5,
        WAYPOINT_PLAYBACK_RESUME = 0x244F70C84C547D2D,
        WAYPOINT_PLAYBACK_OVERRIDE_SPEED = 0x7D7D2B47FA788E85,
        WAYPOINT_PLAYBACK_USE_DEFAULT_SPEED = 0x6599D834B12D0800,
        USE_WAYPOINT_RECORDING_AS_ASSISTED_MOVEMENT_ROUTE = 0x5A353B8E6B1095B5,
        WAYPOINT_PLAYBACK_START_AIMING_AT_PED = 0x20E330937C399D29,
        WAYPOINT_PLAYBACK_START_AIMING_AT_COORD = 0x8968400D900ED8B3,
        WAYPOINT_PLAYBACK_START_SHOOTING_AT_PED = 0xE70BA7B90F8390DC,
        WAYPOINT_PLAYBACK_START_SHOOTING_AT_COORD = 0x057A25CFCC9DB671,
        WAYPOINT_PLAYBACK_STOP_AIMING_OR_SHOOTING = 0x47EFA040EBB8E2EA,
        ASSISTED_MOVEMENT_REMOVE_ROUTE = 0x3548536485DD792B,
        ASSISTED_MOVEMENT_IS_ROUTE_LOADED = 0x60F9A4393A21F741,
        ASSISTED_MOVEMENT_SET_ROUTE_PROPERTIES = 0xD5002D78B7162E1B,
        ASSISTED_MOVEMENT_OVERRIDE_LOAD_DISTANCE_THIS_FRAME = 0x13945951E16EF912,
        IS_WAYPOINT_PLAYBACK_GOING_ON_FOR_VEHICLE = 0xF5134943EA29868C,
        GET_VEHICLE_WAYPOINT_PROGRESS = 0x9824CFF8FC66E159,
        GET_VEHICLE_WAYPOINT_TARGET_POINT = 0x416B62AC8B9E5BBD,
        VEHICLE_WAYPOINT_PLAYBACK_PAUSE = 0x8A4E6AC373666BC5,
        VEHICLE_WAYPOINT_PLAYBACK_RESUME = 0xDC04FCAA7839D492,
        VEHICLE_WAYPOINT_PLAYBACK_USE_DEFAULT_SPEED = 0x5CEB25A7D2848963,
        VEHICLE_WAYPOINT_PLAYBACK_OVERRIDE_SPEED = 0x121F0593E0A431D7,
        IS_TASK_MOVE_NETWORK_ACTIVE = 0x921CE12C489C4C41,
        IS_TASK_MOVE_NETWORK_READY_FOR_TRANSITION = 0x30ED88D5E0C56A37,
        REQUEST_TASK_MOVE_NETWORK_STATE_TRANSITION = 0xD01015C7316AE176,
        GET_TASK_MOVE_NETWORK_STATE = 0x717E4D1F2048376D,
        _SET_TASK_MOVE_NETWORK_SIGNAL_FLOAT_2 = 0x373EF409B82697A3,
        SET_TASK_MOVE_NETWORK_SIGNAL_BOOL = 0xB0A6CFD2C69C1088,
        _GET_TASK_MOVE_NETWORK_SIGNAL_FLOAT = 0x44AB0B3AFECCE242,
        GET_TASK_MOVE_NETWORK_SIGNAL_BOOL = 0xA7FFBA498E4AAF67,
        GET_TASK_MOVE_NETWORK_EVENT = 0xB4F47213DF45A64C,
        IS_MOVE_BLEND_RATIO_STILL = 0x349CE7B56DAFD95C,
        IS_MOVE_BLEND_RATIO_WALKING = 0xF133BBBE91E1691F,
        IS_MOVE_BLEND_RATIO_RUNNING = 0xD4D8636C0199A939,
        IS_MOVE_BLEND_RATIO_SPRINTING = 0x24A2AD74FA9814E2,
        IS_PED_STILL = 0xAC29253EEF8F0180,
        IS_PED_WALKING = 0xDE4C184B2B9B071A,
        IS_PED_RUNNING = 0xC5286FFC176F28A2,
        IS_PED_SPRINTING = 0x57E457CD2C0FC168,
        TASK_AGITATED_ACTION = 0x19D1B791CB3670FE,
        UPDATE_TASK_SWEEP_AIM_ENTITY = 0xE4973DBDBE6E44B3,
        TASK_SWEEP_AIM_POSITION = 0x7AFE8FDC10BC07D2,
        UPDATE_TASK_SWEEP_AIM_POSITION = 0xBB106883F5201FC4,
        IS_PED_RUNNING_ARREST_TASK = 0x3DC52677769B4AE0,
        UNCUFF_PED = 0x67406F2C8F87FC4F,
        IS_PED_CUFFED = 0x74E559B3BC910685,
        _0x6100B3CEFD43452E = 0x6100B3CEFD43452E,
        _0x9D252648778160DF = 0x9D252648778160DF,
        _0x1F351CF1C6475734 = 0x1F351CF1C6475734,
        _0x29682E2CCF21E9B5 = 0x29682E2CCF21E9B5,
        _0x8423541E8B3A1589 = 0x8423541E8B3A1589,
        _0x8634CEF2522D987B = 0x8634CEF2522D987B,
    }
}