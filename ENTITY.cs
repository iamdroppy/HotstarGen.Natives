using System;
namespace Hotstar
{
    public enum ENTITY : ulong
    { 
        /// <summary>
        /// Checks whether an entity exists in the game world.
        ///
        /// > Entity entity
        ///
        /// </summary>
        DOES_ENTITY_EXIST = 0x7239B21A38F536BA,
        /// <summary>
        /// P3 is always 3 as far as i cant tell
        /// 
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        ///
        /// > Entity entity
        /// > const char* animDict
        /// > const char* animName
        /// > int p3
        ///
        /// </summary>
        HAS_ENTITY_ANIM_FINISHED = 0x20B711662962B472,
        /// <summary>
        /// Entity 1 = Victim
        /// Entity 2 = Attacker
        /// 
        /// p2 seems to always be 1
        ///
        /// > Entity entity1
        /// > Entity entity2
        /// > BOOL p2
        ///
        /// </summary>
        HAS_ENTITY_BEEN_DAMAGED_BY_ENTITY = 0xC86D67D52A707CF8,
        /// <summary>
        /// traceType is always 17 in the scripts.
        /// 
        /// There is other codes used for traceType:
        /// 19 - in jewelry_prep1a
        /// 126 - in am_hunt_the_beast
        /// 256 & 287 - in fm_mission_controller
        ///
        /// > Entity entity1
        /// > Entity entity2
        /// > int traceType
        ///
        /// </summary>
        HAS_ENTITY_CLEAR_LOS_TO_ENTITY = 0xFCDFF7B72D23A1AC,
        /// <summary>
        /// Has the entity1 got a clear line of sight to the other entity2 from the direction entity1 is facing.
        /// This is one of the most CPU demanding BOOL natives in the game; avoid calling this in things like nested for-loops
        ///
        /// > Entity entity1
        /// > Entity entity2
        ///
        /// </summary>
        HAS_ENTITY_CLEAR_LOS_TO_ENTITY_IN_FRONT = 0x0267D00AF114F17A,
        /// <summary>
        /// Called on tick.
        /// Tested with vehicles, returns true whenever the vehicle is touching any entity.
        /// 
        /// Note: for vehicles, the wheels can touch the ground and it will still return false, but if the body of the vehicle touches the ground, it will return true.
        ///
        /// > Entity entity
        ///
        /// </summary>
        HAS_ENTITY_COLLIDED_WITH_ANYTHING = 0x8BAD02F0368D9E14,
        /// <summary>
        /// Based on carmod_shop script decompile this takes a vehicle parameter. It is called when repair is done on initial enter.
        ///
        /// > Entity entity
        ///
        /// </summary>
        FORCE_ENTITY_AI_AND_ANIMATION_UPDATE = 0x40FDEDB72F8293B2,
        /// <summary>
        /// Returns a float value representing animation's current playtime with respect to its total playtime. This value increasing in a range from [0 to 1] and wrap back to 0 when it reach 1.
        /// 
        /// Example:
        /// 0.000000 - mark the starting of animation.
        /// 0.500000 - mark the midpoint of the animation.
        /// 1.000000 - mark the end of animation.
        /// 
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        ///
        /// > Entity entity
        /// > const char* animDict
        /// > const char* animName
        ///
        /// </summary>
        GET_ENTITY_ANIM_CURRENT_TIME = 0x346D81500D088F42,
        /// <summary>
        /// Returns a float value representing animation's total playtime in milliseconds.
        /// 
        /// Example:
        /// GET_ENTITY_ANIM_TOTAL_TIME(PLAYER_ID(),"amb@world_human_yoga@female@base","base_b") 
        /// return 20800.000000
        /// 
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        ///
        /// > Entity entity
        /// > const char* animDict
        /// > const char* animName
        ///
        /// </summary>
        GET_ENTITY_ANIM_TOTAL_TIME = 0x50BD2730B191E360,
        /// <summary>
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        ///
        /// > const char* animDict
        /// > const char* animName
        ///
        /// </summary>
        GET_ANIM_DURATION = 0xFEDDF04D62B8D790,
        /// <summary>
        /// Gets the current coordinates for a specified entity.
        /// `entity` = The entity to get the coordinates from.
        /// `alive` = Unused by the game, potentially used by debug builds of GTA in order to assert whether or not an entity was alive.
        ///
        /// > Entity entity
        /// > BOOL alive
        ///
        /// </summary>
        GET_ENTITY_COORDS = 0x3FEF770D40960D5A,
        /// <summary>
        /// Gets the entity's forward vector.
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_ENTITY_FORWARD_VECTOR = 0x0A794A5A57F8DF91,
        /// <summary>
        /// Gets the X-component of the entity's forward vector.
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_ENTITY_FORWARD_X = 0x8BB4EF4214E0E6D5,
        /// <summary>
        /// Gets the Y-component of the entity's forward vector.
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_ENTITY_FORWARD_Y = 0x866A4A5FAE349510,
        /// <summary>
        /// Returns the heading of the entity in degrees. Also know as the "Yaw" of an entity.
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_ENTITY_HEADING = 0xE83D4F9BA2A38914,
        /// <summary>
        /// Gets the heading of the entity physics in degrees, which tends to be more accurate than just "GET_ENTITY_HEADING". This can be clearly seen while, for example, ragdolling a ped/player.
        /// 
        /// NOTE: The name and description of this native are based on independent research. If you find this native to be more suitable under a different name and/or described differently, please feel free to do so.
        /// 
        /// GET_ENTITY_HEADING_*
        ///
        /// > Entity entity
        ///
        /// </summary>
        _GET_ENTITY_PHYSICS_HEADING = 0x846BF6291198A71E,
        /// <summary>
        /// Returns an integer value of entity's current health.
        /// 
        /// Example of range for ped:
        /// - Player [0 to 200]
        /// - Ped [100 to 200]
        /// - Vehicle [0 to 1000]
        /// - Object [0 to 1000]
        /// 
        /// Health is actually a float value but this native casts it to int.
        /// In order to get the actual value, do:
        /// float health = *(float *)(entityAddress + 0x280);
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_ENTITY_HEALTH = 0xEEF059FAD016D209,
        /// <summary>
        /// Return an integer value of entity's maximum health.
        /// 
        /// Example:
        /// - Player = 200
        /// - Ped = 150
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_ENTITY_MAX_HEALTH = 0x15D757606D170C3C,
        /// <summary>
        /// For instance: ENTITY::SET_ENTITY_MAX_HEALTH(PLAYER::PLAYER_PED_ID(), 200); // director_mode.c4: 67849
        ///
        /// > Entity entity
        /// > int value
        ///
        /// </summary>
        SET_ENTITY_MAX_HEALTH = 0x166E7CF68597D8B5,
        /// <summary>
        /// Return height (z-dimension) above ground. 
        /// Example: The pilot in a titan plane is 1.844176 above ground.
        /// 
        /// How can i convert it to meters?
        /// Everything seems to be in meters, probably this too.
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_ENTITY_HEIGHT_ABOVE_GROUND = 0x1DD55701034110E5,
        /// <summary>
        /// Returns the model hash from the entity
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_ENTITY_MODEL = 0x9F47B058362C84B5,
        /// <summary>
        /// Converts world coords (posX - Z) to coords relative to the entity
        /// 
        /// Example:
        /// posX is given as 50
        /// entity's x coord is 40
        /// the returned x coord will then be 10 or -10, not sure haven't used this in a while (think it is 10 though).
        ///
        /// > Entity entity
        /// > float posX
        /// > float posY
        /// > float posZ
        ///
        /// </summary>
        GET_OFFSET_FROM_ENTITY_GIVEN_WORLD_COORDS = 0x2274BC1C4885E333,
        /// <summary>
        /// Offset values are relative to the entity.
        /// 
        /// x = left/right
        /// y = forward/backward
        /// z = up/down
        ///
        /// > Entity entity
        /// > float offsetX
        /// > float offsetY
        /// > float offsetZ
        ///
        /// </summary>
        GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS = 0x1899F328B0E12848,
        /// <summary>
        /// w is the correct parameter name!
        ///
        /// > Entity entity
        /// > float* x
        /// > float* y
        /// > float* z
        /// > float* w
        ///
        /// </summary>
        GET_ENTITY_QUATERNION = 0x7B3703D2D32DFA18,
        /// <summary>
        /// Displays the current ROLL axis of the entity [-180.0000/180.0000+]
        /// (Sideways Roll) such as a vehicle tipped on its side
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_ENTITY_ROLL = 0x831E0242595560DF,
        /// <summary>
        /// rotationOrder is the order yaw, pitch and roll is applied. Usually 2. Returns a vector where the Z coordinate is the yaw.
        /// 
        /// rotationOrder refers to the order yaw pitch roll is applied; value ranges from 0 to 5 and is usually *2* in scripts.
        /// What you use for rotationOrder when getting must be the same as rotationOrder when setting the rotation.
        /// 
        /// What it returns is the yaw on the z part of the vector, which makes sense considering R* considers z as vertical. Here's a picture for those of you who don't understand pitch, yaw, and roll: www.allstar.fiu.edu/aero/images/pic5-1.gif
        /// 
        /// Rotation Orders:
        /// 0: ZYX - Rotate around the z-axis, then the y-axis and finally the x-axis.
        /// 1: YZX - Rotate around the y-axis, then the z-axis and finally the x-axis.
        /// 2: ZXY - Rotate around the z-axis, then the x-axis and finally the y-axis.
        /// 3: XZY - Rotate around the x-axis, then the z-axis and finally the y-axis.
        /// 4: YXZ - Rotate around the y-axis, then the x-axis and finally the z-axis.
        /// 5: XYZ - Rotate around the x-axis, then the y-axis and finally the z-axis.
        ///
        /// > Entity entity
        /// > int rotationOrder
        ///
        /// </summary>
        GET_ENTITY_ROTATION = 0xAFBD61CC738D9EB9,
        /// <summary>
        /// All ambient entities in-world seem to have the same value for the second argument (Any *script), depending on when the scripthook was activated/re-activated. I've seen numbers from ~5 to almost 70 when the value was translated with to_string. The function return value seems to always be 0.
        ///
        /// > Entity entity
        /// > ScrHandle* script
        ///
        /// </summary>
        GET_ENTITY_SCRIPT = 0xA6E9C38DB51D7748,
        /// <summary>
        /// result is in meters per second
        /// 
        /// ------------------------------------------------------------
        /// So would the conversion to mph and km/h, be along the lines of this.
        /// 
        /// float speed = GET_ENTITY_SPEED(veh);
        /// float kmh = (speed * 3.6);
        /// float mph = (speed * 2.236936);
        /// ------------------------------------------------------------
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_ENTITY_SPEED = 0xD5037BA82E12416F,
        /// <summary>
        /// Relative can be used for getting speed relative to the frame of the vehicle, to determine for example, if you are going in reverse (-y speed) or not (+y speed). 
        ///
        /// > Entity entity
        /// > BOOL relative
        ///
        /// </summary>
        GET_ENTITY_SPEED_VECTOR = 0x9A8D700A51CB7B0D,
        /// <summary>
        /// Simply returns whatever is passed to it (Regardless of whether the handle is valid or not).
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_OBJECT_INDEX_FROM_ENTITY_INDEX = 0xD7E3B9735C0F89D6,
        /// <summary>
        /// Simply returns whatever is passed to it (Regardless of whether the handle is valid or not).
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_PED_INDEX_FROM_ENTITY_INDEX = 0x04A2A40C73395041,
        /// <summary>
        /// Simply returns whatever is passed to it (Regardless of whether the handle is valid or not).
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_VEHICLE_INDEX_FROM_ENTITY_INDEX = 0x4B53F92932ADFAC0,
        /// <summary>
        /// Returns the coordinates of an entity-bone.
        ///
        /// > Entity entity
        /// > int boneIndex
        ///
        /// </summary>
        GET_WORLD_POSITION_OF_ENTITY_BONE = 0x44A8FCB8ED227738,
        /// <summary>
        /// Returns:
        /// 0 = no entity
        /// 1 = ped
        /// 2 = vehicle
        /// 3 = object
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_ENTITY_TYPE = 0x8ACD366038D14505,
        /// <summary>
        /// A population type, from the following enum: https://alloc8or.re/gta5/doc/enums/ePopulationType.txt
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_ENTITY_POPULATION_TYPE = 0xF6F5161F4534EDFF,
        /// <summary>
        /// Checks if entity is within x/y/zSize distance of x/y/z. 
        /// 
        /// Last three are unknown ints, almost always p7 = 0, p8 = 1, p9 = 0
        ///
        /// > Entity entity
        /// > float xPos
        /// > float yPos
        /// > float zPos
        /// > float xSize
        /// > float ySize
        /// > float zSize
        /// > BOOL p7
        /// > BOOL p8
        /// > int p9
        ///
        /// </summary>
        IS_ENTITY_AT_COORD = 0x20B60995556D004F,
        /// <summary>
        /// Checks if entity1 is within the box defined by x/y/zSize of entity2.
        /// 
        /// Last three parameters are almost alwasy p5 = 0, p6 = 1, p7 = 0
        ///
        /// > Entity entity1
        /// > Entity entity2
        /// > float xSize
        /// > float ySize
        /// > float zSize
        /// > BOOL p5
        /// > BOOL p6
        /// > int p7
        ///
        /// </summary>
        IS_ENTITY_AT_ENTITY = 0x751B70C3D034E187,
        /// <summary>
        /// Whether the entity is attached to any other entity.
        ///
        /// > Entity entity
        ///
        /// </summary>
        IS_ENTITY_ATTACHED = 0xB346476EF1A64897,
        /// <summary>
        /// `p8` is a debug flag invoking functions in the same path as ``DRAW_MARKER``
        /// `p10` is some entity flag check, also used in `IS_ENTITY_AT_ENTITY`, `IS_ENTITY_IN_AREA`, and `IS_ENTITY_AT_COORD`.
        /// See IS_POINT_IN_ANGLED_AREA for the definition of an angled area.
        ///
        /// > Entity entity
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > float width
        /// > BOOL debug
        /// > BOOL includeZ
        /// > Any p10
        ///
        /// </summary>
        IS_ENTITY_IN_ANGLED_AREA = 0x51210CED3DA1C78A,
        /// <summary>
        /// Full list of zones by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/zones.json
        ///
        /// > Entity entity
        /// > const char* zone
        ///
        /// </summary>
        IS_ENTITY_IN_ZONE = 0xB6463CF6AF527071,
        /// <summary>
        /// Get how much of the entity is submerged.  1.0f is whole entity.
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_ENTITY_SUBMERGED_LEVEL = 0xE81AFC1BC4CC41CE,
        /// <summary>
        /// Returns true if the entity is in between the minimum and maximum values for the 2d screen coords. 
        /// This means that it will return true even if the entity is behind a wall for example, as long as you're looking at their location. 
        /// Chipping
        ///
        /// > Entity entity
        ///
        /// </summary>
        IS_ENTITY_ON_SCREEN = 0xE659E47AF827484B,
        /// <summary>
        /// See also PED::IS_SCRIPTED_SCENARIO_PED_USING_CONDITIONAL_ANIM 0x6EC47A344923E1ED 0x3C30B447
        /// 
        /// Taken from ENTITY::IS_ENTITY_PLAYING_ANIM(PLAYER::PLAYER_PED_ID(), "creatures@shark@move", "attack_player", 3)
        /// 
        /// p4 is always 3 in the scripts.
        /// 
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        ///
        /// > Entity entity
        /// > const char* animDict
        /// > const char* animName
        /// > int taskFlag
        ///
        /// </summary>
        IS_ENTITY_PLAYING_ANIM = 0x1F0B79228E461EC9,
        /// <summary>
        /// a static ped will not react to natives like "APPLY_FORCE_TO_ENTITY" or "SET_ENTITY_VELOCITY" and oftentimes will not react to task-natives like "TASK::TASK_COMBAT_PED". The only way I know of to make one of these peds react is to ragdoll them (or sometimes to use CLEAR_PED_TASKS_IMMEDIATELY(). Static peds include almost all far-away peds, beach-combers, peds in certain scenarios, peds crossing a crosswalk, peds walking to get back into their cars, and others. If anyone knows how to make a ped non-static without ragdolling them, please edit this with the solution.
        /// 
        /// how can I make an entity static???
        ///
        /// > Entity entity
        ///
        /// </summary>
        IS_ENTITY_STATIC = 0x1218E6886D3D8327,
        /// <summary>
        /// Applies a force to the specified entity.
        /// 
        /// **List of force types (p1)**:
        /// public enum ForceType
        /// {
        ///     MinForce = 0,
        ///     MaxForceRot = 1,
        ///     MinForce2 = 2,
        ///     MaxForceRot2 = 3,
        ///     ForceNoRot = 4,
        ///     ForceRotPlusForce = 5
        /// }
        /// Research/documentation on the gtaforums can be found here https://gtaforums.com/topic/885669-precisely-define-object-physics/) and here https://gtaforums.com/topic/887362-apply-forces-and-momentums-to-entityobject/.
        /// 
        /// p6/relative - makes the xyz force not relative to world coords, but to something else
        /// p7/highForce - setting false will make the force really low
        ///
        /// > Entity entity
        /// > int forceType
        /// > float x
        /// > float y
        /// > float z
        /// > BOOL p5
        /// > BOOL isDirectionRel
        /// > BOOL isForceRel
        /// > BOOL p8
        ///
        /// </summary>
        APPLY_FORCE_TO_ENTITY_CENTER_OF_MASS = 0x18FF00FC7EFF559E,
        /// <summary>
        /// Documented here:
        /// gtaforums.com/topic/885669-precisely-define-object-physics/
        /// gtaforums.com/topic/887362-apply-forces-and-momentums-to-entityobject/
        /// 
        /// forceFlags:
        /// First bit (lowest): Strong force flag, factor 100
        /// Second bit: Unkown flag
        /// Third bit: Momentum flag=1 (vector (x,y,z) is a momentum, more research needed)
        /// If higher bits are unequal 0 the function doesn't applay any forces at all.
        /// (As integer possible values are 0-7)
        /// 
        /// 0: weak force
        /// 1: strong force
        /// 2: same as 0 (2nd bit?)
        /// 3: same as 1
        /// 4: weak momentum
        /// 5: strong momentum
        /// 6: same as 4
        /// 7: same as 5
        /// 
        /// isLocal: vector defined in local (body-fixed) coordinate frame
        /// isMassRel: if true the force gets multiplied with the objects mass (this is why it was known as highForce) and different objects will have the same acceleration.
        /// 
        /// p8 !!! Whenever I set this !=0, my script stopped.
        ///
        /// > Entity entity
        /// > int forceFlags
        /// > float x
        /// > float y
        /// > float z
        /// > float offX
        /// > float offY
        /// > float offZ
        /// > int boneIndex
        /// > BOOL isDirectionRel
        /// > BOOL ignoreUpVec
        /// > BOOL isForceRel
        /// > BOOL p12
        /// > BOOL p13
        ///
        /// </summary>
        APPLY_FORCE_TO_ENTITY = 0xC5F68BE9613E2D18,
        /// <summary>
        /// Attaches entity1 to bone (boneIndex) of entity2.
        /// 
        /// boneIndex - this is different to boneID, use GET_PED_BONE_INDEX to get the index from the ID. use the index for attaching to specific bones. entity1 will be attached to entity2's centre if bone index given doesn't correspond to bone indexes for that entity type.
        /// 
        /// useSoftPinning - if set to false attached entity will not detach when fixed
        /// collision - controls collision between the two entities (FALSE disables collision).
        /// isPed - pitch doesnt work when false and roll will only work on negative numbers (only peds)
        /// vertexIndex - position of vertex
        /// fixedRot - if false it ignores entity vector 
        /// 
        ///
        /// > Entity entity1
        /// > Entity entity2
        /// > int boneIndex
        /// > float xPos
        /// > float yPos
        /// > float zPos
        /// > float xRot
        /// > float yRot
        /// > float zRot
        /// > BOOL p9
        /// > BOOL useSoftPinning
        /// > BOOL collision
        /// > BOOL isPed
        /// > int vertexIndex
        /// > BOOL fixedRot
        ///
        /// </summary>
        ATTACH_ENTITY_TO_ENTITY = 0x6B9BBD38AB0796DF,
        /// <summary>
        /// breakForce is the amount of force required to break the bond.
        /// p14 - is always 1 in scripts
        /// p15 - is 1 or 0 in scripts - unknoun what it does
        /// p16 - controls collision between the two entities (FALSE disables collision).
        /// p17 - do not teleport entity to be attached to the position of the bone Index of the target entity (if 1, entity will not be teleported to target bone)
        /// p18 - is always 2 in scripts.
        /// 
        /// 
        ///
        /// > Entity entity1
        /// > Entity entity2
        /// > int boneIndex1
        /// > int boneIndex2
        /// > float xPos1
        /// > float yPos1
        /// > float zPos1
        /// > float xPos2
        /// > float yPos2
        /// > float zPos2
        /// > float xRot
        /// > float yRot
        /// > float zRot
        /// > float breakForce
        /// > BOOL fixedRot
        /// > BOOL p15
        /// > BOOL collision
        /// > BOOL p17
        /// > int p18
        ///
        /// </summary>
        ATTACH_ENTITY_TO_ENTITY_PHYSICALLY = 0xC3675780C92F90F9,
        /// <summary>
        /// Called to update entity attachments.
        ///
        /// > Entity entity
        ///
        /// </summary>
        PROCESS_ENTITY_ATTACHMENTS = 0xF4080490ADC51C6F,
        /// <summary>
        /// Returns the index of the bone. If the bone was not found, -1 will be returned. 
        /// 
        /// list:
        /// pastebin.com/D7JMnX1g
        /// 
        /// BoneNames:
        ///   chassis,
        ///   windscreen,
        ///    seat_pside_r,
        ///  seat_dside_r,
        ///  bodyshell,
        ///     suspension_lm,
        ///     suspension_lr,
        ///     platelight,
        ///    attach_female,
        ///     attach_male,
        ///   bonnet,
        ///    boot,
        ///  chassis_dummy,  //Center of the dummy
        ///  chassis_Control,    //Not found yet
        ///    door_dside_f,   //Door left, front
        ///     door_dside_r,   //Door left, back
        ///  door_pside_f,   //Door right, front
        ///    door_pside_r,   //Door right, back
        ///     Gun_GripR,
        ///     windscreen_f,
        ///  platelight, //Position where the light above the numberplate is located
        ///    VFX_Emitter,
        ///   window_lf,  //Window left, front
        ///   window_lr,  //Window left, back
        ///    window_rf,  //Window right, front
        ///  window_rr,  //Window right, back
        ///   engine, //Position of the engine
        ///   gun_ammo,
        ///  ROPE_ATTATCH,   //Not misspelled. In script "finale_heist2b.c4".
        ///     wheel_lf,   //Wheel left, front
        ///    wheel_lr,   //Wheel left, back
        ///     wheel_rf,   //Wheel right, front
        ///   wheel_rr,   //Wheel right, back
        ///    exhaust,    //Exhaust. shows only the position of the stock-exhaust
        ///    overheat,   //A position on the engine(not exactly sure, how to name it)
        ///   misc_e, //Not a car-bone.
        ///  seat_dside_f,   //Driver-seat
        ///  seat_pside_f,   //Seat next to driver
        ///  Gun_Nuzzle,
        ///    seat_r
        /// 
        /// I doubt that the function is case-sensitive, since I found a "Chassis" and a "chassis". - Just tested: Definitely not case-sensitive.
        /// 
        /// 
        ///
        /// > Entity entity
        /// > const char* boneName
        ///
        /// </summary>
        GET_ENTITY_BONE_INDEX_BY_NAME = 0xFB71170B7E76ACBA,
        /// <summary>
        /// Deletes the specified entity, then sets the handle pointed to by the pointer to NULL.
        ///
        /// > Entity* entity
        ///
        /// </summary>
        DELETE_ENTITY = 0xAE3CBE5BF394C9C9,
        /// <summary>
        /// If `collision` is set to true, both entities won't collide with the other until the distance between them is above 4 meters.
        /// Set `dynamic` to true to keep velocity after dettaching
        ///
        /// > Entity entity
        /// > BOOL dynamic
        /// > BOOL collision
        ///
        /// </summary>
        DETACH_ENTITY = 0x961AC54BF0613F5D,
        /// <summary>
        /// Freezes or unfreezes an entity preventing its coordinates to change by the player if set to `true`. You can still change the entity position using SET_ENTITY_COORDS.
        ///
        /// > Entity entity
        /// > BOOL toggle
        ///
        /// </summary>
        FREEZE_ENTITY_POSITION = 0x428CA6DBD1094446,
        /// <summary>
        /// True means it can be deleted by the engine when switching lobbies/missions/etc, false means the script is expected to clean it up.
        ///
        /// > Entity entity
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_ENTITY_CLEANUP_BY_ENGINE = 0x3910051CCECDB00C,
        /// <summary>
        /// delta and bitset are guessed fields. They are based on the fact that most of the calls have 0 or nil field types passed in.
        /// 
        /// The only time bitset has a value is 0x4000 and the only time delta has a value is during stealth with usually <1.0f values.
        /// 
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        ///
        /// > Entity entity
        /// > const char* animName
        /// > const char* animDict
        /// > float p3
        /// > BOOL loop
        /// > BOOL stayInAnim
        /// > BOOL p6
        /// > float delta
        /// > Any bitset
        ///
        /// </summary>
        PLAY_ENTITY_ANIM = 0x7FB218262B810701,
        /// <summary>
        /// p4 and p7 are usually 1000.0f.
        /// 
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        ///
        /// > Entity entity
        /// > int syncedScene
        /// > const char* animation
        /// > const char* propName
        /// > float p4
        /// > float p5
        /// > Any p6
        /// > float p7
        ///
        /// </summary>
        PLAY_SYNCHRONIZED_ENTITY_ANIM = 0xC77720A12FE14A86,
        /// <summary>
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        ///
        /// > float p0
        /// > float p1
        /// > float p2
        /// > float p3
        /// > Any p4
        /// > Any p5
        /// > Any* p6
        /// > Any* p7
        /// > float p8
        /// > float p9
        /// > Any p10
        /// > float p11
        ///
        /// </summary>
        PLAY_SYNCHRONIZED_MAP_ENTITY_ANIM = 0xB9C54555ED30FBC4,
        /// <summary>
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        /// 
        /// RAGEPluginHook list: docs.ragepluginhook.net/html/62951c37-a440-478c-b389-c471230ddfc5.htm
        ///
        /// > Entity entity
        /// > const char* animation
        /// > const char* animGroup
        /// > float p3
        ///
        /// </summary>
        STOP_ENTITY_ANIM = 0x28004F88151E03E0,
        /// <summary>
        /// p1 sync task id?
        ///
        /// > Entity entity
        /// > float p1
        /// > BOOL p2
        ///
        /// </summary>
        STOP_SYNCHRONIZED_ENTITY_ANIM = 0x43D3807C077261E3,
        /// <summary>
        /// if (ENTITY::HAS_ANIM_EVENT_FIRED(PLAYER::PLAYER_PED_ID(), MISC::GET_HASH_KEY("CreateObject")))
        ///
        /// > Entity entity
        /// > Hash actionHash
        ///
        /// </summary>
        HAS_ANIM_EVENT_FIRED = 0xEAF4CD9EA3E7E922,
        /// <summary>
        /// In the script "player_scene_t_bbfight.c4":
        /// "if (ENTITY::FIND_ANIM_EVENT_PHASE(&l_16E, &l_19F[v_4/*16*/], v_9, &v_A, &v_B))"
        /// -- &l_16E (p0) is requested as an anim dictionary earlier in the script.
        /// -- &l_19F[v_4/*16*/] (p1) is used in other natives in the script as the "animation" param.
        /// -- v_9 (p2) is instantiated as "victim_fall"; I'm guessing that's another anim
        /// --v_A and v_B (p3 & p4) are both set as -1.0, but v_A is used immediately after this native for: 
        /// "if (v_A < ENTITY::GET_ENTITY_ANIM_CURRENT_TIME(...))"
        /// Both v_A and v_B are seemingly used to contain both Vector3's and floats, so I can't say what either really is other than that they are both output parameters. p4 looks more like a *Vector3 though
        /// -alphazolam
        /// 
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        ///
        /// > const char* animDictionary
        /// > const char* animName
        /// > const char* p2
        /// > Any* p3
        /// > Any* p4
        ///
        /// </summary>
        FIND_ANIM_EVENT_PHASE = 0x07F1BE2BCCAA27A7,
        /// <summary>
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        ///
        /// > Entity entity
        /// > const char* animDictionary
        /// > const char* animName
        /// > float time
        ///
        /// </summary>
        SET_ENTITY_ANIM_CURRENT_TIME = 0x4487C259F0F70977,
        /// <summary>
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        ///
        /// > Entity entity
        /// > const char* animDictionary
        /// > const char* animName
        /// > float speedMultiplier
        ///
        /// </summary>
        SET_ENTITY_ANIM_SPEED = 0x28D1A16553C51776,
        /// <summary>
        /// Makes the specified entity (ped, vehicle or object) persistent. Persistent entities will not automatically be removed by the engine.
        /// 
        /// p1 has no effect when either its on or off 
        /// maybe a quick disassembly will tell us what it does
        /// 
        /// p2 has no effect when either its on or off 
        /// maybe a quick disassembly will tell us what it does
        ///
        /// > Entity entity
        /// > BOOL p1
        /// > BOOL p2
        ///
        /// </summary>
        SET_ENTITY_AS_MISSION_ENTITY = 0xAD738C3085FE7E11,
        /// <summary>
        /// Marks the specified entity (ped, vehicle or object) as no longer needed.
        /// Entities marked as no longer needed, will be deleted as the engine sees fit.
        ///
        /// > Entity* entity
        ///
        /// </summary>
        SET_ENTITY_AS_NO_LONGER_NEEDED = 0xB736A491E64A32CF,
        /// <summary>
        /// This is an alias of SET_ENTITY_AS_NO_LONGER_NEEDED.
        ///
        /// > Ped* ped
        ///
        /// </summary>
        SET_PED_AS_NO_LONGER_NEEDED = 0x2595DD4236549CE3,
        /// <summary>
        /// This is an alias of SET_ENTITY_AS_NO_LONGER_NEEDED.
        ///
        /// > Vehicle* vehicle
        ///
        /// </summary>
        SET_VEHICLE_AS_NO_LONGER_NEEDED = 0x629BFA74418D6239,
        /// <summary>
        /// This is an alias of SET_ENTITY_AS_NO_LONGER_NEEDED.
        ///
        /// > Object* object
        ///
        /// </summary>
        SET_OBJECT_AS_NO_LONGER_NEEDED = 0x3AE22DEB5BA5A3E6,
        /// <summary>
        /// Sets whether the entity can be targeted without being in line-of-sight.
        ///
        /// > Entity entity
        /// > BOOL toggle
        ///
        /// </summary>
        SET_ENTITY_CAN_BE_TARGETED_WITHOUT_LOS = 0xD3997889736FD899,
        /// <summary>
        /// p7 is always 1 in the scripts. Set to 1, an area around the destination coords for the moved entity is cleared from other entities. 
        ///  
        /// Often ends with 1, 0, 0, 1); in the scripts. It works. 
        /// 
        /// Axis - Invert Axis Flags
        ///
        /// > Entity entity
        /// > float xPos
        /// > float yPos
        /// > float zPos
        /// > BOOL xAxis
        /// > BOOL yAxis
        /// > BOOL zAxis
        /// > BOOL clearArea
        ///
        /// </summary>
        SET_ENTITY_COORDS = 0x06843DA7060A026B,
        /// <summary>
        /// Axis - Invert Axis Flags
        ///
        /// > Entity entity
        /// > float xPos
        /// > float yPos
        /// > float zPos
        /// > BOOL xAxis
        /// > BOOL yAxis
        /// > BOOL zAxis
        ///
        /// </summary>
        SET_ENTITY_COORDS_NO_OFFSET = 0x239A3351AC1DA385,
        /// <summary>
        /// Set the heading of an entity in degrees also known as "Yaw".
        ///
        /// > Entity entity
        /// > float heading
        ///
        /// </summary>
        SET_ENTITY_HEADING = 0x8E2530AA8ADA980E,
        /// <summary>
        /// health >= 0
        /// male ped ~= 100 - 200
        /// female ped ~= 0 - 100
        ///
        /// > Entity entity
        /// > int health
        /// > int p2
        ///
        /// </summary>
        SET_ENTITY_HEALTH = 0x6B76DC1F3AE6E6A3,
        /// <summary>
        /// Sets a ped or an object totally invincible. It doesn't take any kind of damage. Peds will not ragdoll on explosions and the tazer animation won't apply either.
        /// 
        /// If you use this for a ped and you want Ragdoll to stay enabled, then do:
        /// *(DWORD *)(pedAddress + 0x188) |= (1 << 9);
        /// 
        /// Use this if you want to get the invincibility status:
        ///   bool IsPedInvincible(Ped ped)
        ///  {
        ///      auto addr = getScriptHandleBaseAddress(ped);    
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
        /// > Entity entity
        /// > BOOL toggle
        ///
        /// </summary>
        SET_ENTITY_INVINCIBLE = 0x3882114BDE571AD4,
        /// <summary>
        /// Loads collision grid for an entity spawned outside of a player's loaded area. This allows peds to execute tasks rather than sit dormant because of a lack of a physics grid.
        /// Certainly not the main usage of this native but when set to true for a Vehicle, it will prevent the vehicle to explode if it is spawned far away from the player.
        ///
        /// > Entity entity
        /// > BOOL toggle
        /// > Any p2
        ///
        /// </summary>
        SET_ENTITY_LOAD_COLLISION_FLAG = 0x0DC7CABAB1E9B67E,
        /// <summary>
        /// Enable / disable each type of damage.
        /// 
        /// Can't get drownProof to work.
        /// --------------
        /// p7 is to to '1' in am_mp_property_ext/int: entity::set_entity_proofs(uParam0->f_19, true, true, true, true, true, true, 1, true);
        /// 
        ///
        /// > Entity entity
        /// > BOOL bulletProof
        /// > BOOL fireProof
        /// > BOOL explosionProof
        /// > BOOL collisionProof
        /// > BOOL meleeProof
        /// > BOOL p6
        /// > BOOL p7
        /// > BOOL drownProof
        ///
        /// </summary>
        SET_ENTITY_PROOFS = 0xFAEE099C6F890BB8,
        /// <summary>
        /// w is the correct parameter name!
        ///
        /// > Entity entity
        /// > float x
        /// > float y
        /// > float z
        /// > float w
        ///
        /// </summary>
        SET_ENTITY_QUATERNION = 0x77B21BE7AC540F07,
        /// <summary>
        /// rotationOrder refers to the order yaw pitch roll is applied
        /// value ranges from 0 to 5. What you use for rotationOrder when setting must be the same as rotationOrder when getting the rotation. 
        /// Unsure what value corresponds to what rotation order, more testing will be needed for that.
        /// For the most part R* uses 1 or 2 as the order.
        /// p5 is usually set as true
        /// 
        ///
        /// > Entity entity
        /// > float pitch
        /// > float roll
        /// > float yaw
        /// > int rotationOrder
        /// > BOOL p5
        ///
        /// </summary>
        SET_ENTITY_ROTATION = 0x8524A8B0171D5E07,
        /// <summary>
        /// unk was always 0.
        ///
        /// > Entity entity
        /// > BOOL toggle
        /// > BOOL unk
        ///
        /// </summary>
        SET_ENTITY_VISIBLE = 0xEA1C610A04DB6BBB,
        /// <summary>
        /// Note that the third parameter(denoted as z) is "up and down" with positive numbers encouraging upwards movement.
        ///
        /// > Entity entity
        /// > float x
        /// > float y
        /// > float z
        ///
        /// </summary>
        SET_ENTITY_VELOCITY = 0x1C99BB7B6E96D16F,
        /// <summary>
        /// LOD distance can be 0 to 0xFFFF (higher values will result in 0xFFFF) as it is actually stored as a 16-bit value (aka uint16_t).
        ///
        /// > Entity entity
        /// > int value
        ///
        /// </summary>
        SET_ENTITY_LOD_DIST = 0x5927F96A78577363,
        /// <summary>
        /// Returns the LOD distance of an entity.
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_ENTITY_LOD_DIST = 0x4159C2762B5791D6,
        /// <summary>
        /// skin - everything alpha except skin
        /// Set entity alpha level. Ranging from 0 to 255 but chnages occur after every 20 percent (after every 51).
        ///
        /// > Entity entity
        /// > int alphaLevel
        /// > BOOL skin
        ///
        /// </summary>
        SET_ENTITY_ALPHA = 0x44A0870B7E92D7C0,
        /// <summary>
        /// Example here: www.gtaforums.com/topic/830463-help-with-turning-lights-green-and-causing-peds-to-crash-into-each-other/#entry1068211340
        /// 
        /// 0 = green
        /// 1 = red
        /// 2 = yellow
        /// 3 = reset changes
        /// changing lights may not change the behavior of vehicles
        ///
        /// > Entity entity
        /// > int state
        ///
        /// </summary>
        SET_ENTITY_TRAFFICLIGHT_OVERRIDE = 0x57C5DB656185EAC4,
        /// <summary>
        /// Only works with objects!
        /// Network players do not see changes done with this.
        /// - Did ya try modifying p6 lol
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        /// > Hash originalModel
        /// > Hash newModel
        /// > BOOL p6
        ///
        /// </summary>
        CREATE_MODEL_SWAP = 0x92C47782FDA8B2A3,
        /// <summary>
        /// p5 = sets as true in scripts
        /// Same as the comment for CREATE_MODEL_SWAP unless for some reason p5 affects it this only works with objects as well.
        /// 
        /// Network players do not see changes done with this.
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        /// > Hash modelHash
        /// > BOOL p5
        ///
        /// </summary>
        CREATE_MODEL_HIDE = 0x8A97BCA30A0CE478,
        /// <summary>
        /// This native makes entities visible that are hidden by the native CREATE_MODEL_HIDE.
        /// p5 should be false, true does nothing
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        /// > Hash modelHash
        /// > BOOL p5
        ///
        /// </summary>
        REMOVE_MODEL_HIDE = 0xD9E3006FB3CBD765,
        /// <summary>
        /// Calling this function disables collision between two entities.
        /// The importance of the order for entity1 and entity2 is unclear.
        /// The third parameter, `thisFrame`, decides whether the collision is to be disabled until it is turned back on, or if it's just this frame.
        ///
        /// > Entity entity1
        /// > Entity entity2
        /// > BOOL thisFrameOnly
        ///
        /// </summary>
        SET_ENTITY_NO_COLLISION_ENTITY = 0xA53ED5520C07654A,
        /// <summary>
        /// p1 always false.
        ///
        /// > Entity entity
        /// > BOOL toggle
        ///
        /// </summary>
        SET_CAN_AUTO_VAULT_ON_ENTITY = 0xE12ABE5E3A389A6C,
        /// <summary>
        /// p1 always false.
        ///
        /// > Entity entity
        /// > BOOL toggle
        ///
        /// </summary>
        SET_CAN_CLIMB_ON_ENTITY = 0xA80AE305E0A3044F,
        /// <summary>
        /// SET_ENTITY_*
        ///
        /// > Entity entity
        /// > BOOL p1
        ///
        /// </summary>
        _SET_ENTITY_DECALS_DISABLED = 0x2C2E3DC128F44309,
        /// <summary>
        /// Gets the world rotation of the specified bone of the specified entity.
        ///
        /// > Entity entity
        /// > int boneIndex
        ///
        /// </summary>
        _GET_ENTITY_BONE_ROTATION = 0xCE6294A232D03786,
        /// <summary>
        /// Gets the world rotation of the specified bone of the specified entity.
        /// This native is used in casinoroulette.c but I don't know yet what is the difference with _GET_ENTITY_BONE_ROTATION
        ///
        /// > Entity entity
        /// > int boneIndex
        ///
        /// </summary>
        _GET_ENTITY_BONE_POSITION_2 = 0x46F8696933A63C9B,
        /// <summary>
        /// Gets the local rotation of the specified bone of the specified entity.
        ///
        /// > Entity entity
        /// > int boneIndex
        ///
        /// </summary>
        _GET_ENTITY_BONE_ROTATION_LOCAL = 0xBD8D32550E5CEBFE,
        /// <summary>
        /// ENABLE_*
        ///
        /// > Entity entity
        ///
        /// </summary>
        _ENABLE_ENTITY_UNK = 0x6CE177D014502E8A,
        /// <summary>
        /// GET_ENTITY_*
        /// 
        /// Seems to return the handle of the entity's portable pickup.
        ///
        /// > Entity entity
        /// > Hash modelHash
        ///
        /// </summary>
        _GET_ENTITY_PICKUP = 0x1F922734E259BD26,
        /// <summary>
        /// SET_ENTITY_R*
        ///
        /// > Entity entity
        /// > BOOL toggle
        ///
        /// </summary>
        _0x694E00132F2823ED = 0x694E00132F2823ED,
        /// <summary>
        /// SET_ENTITY_*
        ///
        /// > Entity entity
        /// > BOOL toggle
        ///
        /// </summary>
        _0xC34BC448DA29F5E9 = 0xC34BC448DA29F5E9,
        /// <summary>
        /// SET_ENTITY_M*
        ///
        /// > Entity entity
        /// > BOOL p1
        ///
        /// </summary>
        _0xE66377CDDADA4810 = 0xE66377CDDADA4810,
        /// <summary>
        /// Only called once in the scripts.
        /// 
        /// Related to weapon objects.
        /// 
        ///
        /// > Entity entity
        /// > float p1
        ///
        /// </summary>
        _0x5C3B791D580E0BC2 = 0x5C3B791D580E0BC2,
        /// <summary>
        /// Related to cutscene entities. Unsure about the use.
        /// 
        /// SET_ENTITY_*
        ///
        /// > Entity entity
        ///
        /// </summary>
        _0x78E8E3A640178255 = 0x78E8E3A640178255,
        /// <summary>
        /// SET_*
        /// 
        /// Only called within 1 script for x360. 'fm_mission_controller' and it used on an object. 
        /// 
        /// Ran after these 2 natives,
        /// set_object_targettable(uParam0, 0);
        /// set_entity_invincible(uParam0, 1);
        ///
        /// > Entity entity
        /// > BOOL toggle
        ///
        /// </summary>
        _0xDC6F8601FAF2E893 = 0xDC6F8601FAF2E893,
        /// <summary>
        /// SET_ENTITY_*
        ///
        /// > Entity entity
        /// > BOOL p1
        ///
        /// </summary>
        _0x1A092BB0C3808B96 = 0x1A092BB0C3808B96,
        /// <summary>
        /// Puts pickup2 ptr somewhere in pickup?
        ///
        /// > Pickup pickup
        /// > Pickup pickup2
        ///
        /// </summary>
        _0x68B562E124CC0AEF = 0x68B562E124CC0AEF,
        /// <summary>
        /// Sets 32nd bit of pickup+188
        /// SET_PICKUP_??
        ///
        /// > Pickup pickup
        /// > BOOL toggle
        ///
        /// </summary>
        _0xD7B80E7C3BEFC396 = 0xD7B80E7C3BEFC396,
        DOES_ENTITY_BELONG_TO_THIS_SCRIPT = 0xDDE6DF5AE89981D2,
        DOES_ENTITY_HAVE_DRAWABLE = 0x060D6E96F8B8E48D,
        DOES_ENTITY_HAVE_PHYSICS = 0xDA95EA3317CC5064,
        HAS_ENTITY_BEEN_DAMAGED_BY_ANY_OBJECT = 0x95EB9964FF5C5C65,
        HAS_ENTITY_BEEN_DAMAGED_BY_ANY_PED = 0x605F5A140F202491,
        HAS_ENTITY_BEEN_DAMAGED_BY_ANY_VEHICLE = 0xDFD5033FDBA0A9C8,
        _HAS_ENTITY_CLEAR_LOS_TO_ENTITY_2 = 0x394BDE2A7BBA031E,
        GET_LAST_MATERIAL_HIT_BY_ENTITY = 0x5C3D0A935F535C4C,
        GET_COLLISION_NORMAL_OF_LAST_HIT_FOR_ENTITY = 0xE465D4AB7CA6AE72,
        GET_ENTITY_ATTACHED_TO = 0x48C2BED9180FE123,
        GET_ENTITY_HEIGHT = 0x5A504562485944DD,
        GET_ENTITY_MATRIX = 0xECB2FC7235A7D137,
        GET_ENTITY_PITCH = 0xD45DC2893621E1FE,
        GET_ENTITY_ROTATION_VELOCITY = 0x213B91045D09B983,
        GET_ENTITY_UPRIGHT_VALUE = 0x95EED5A694951F9F,
        GET_ENTITY_VELOCITY = 0x4805D2B1D8CF94A9,
        GET_NEAREST_PLAYER_TO_ENTITY = 0x7196842CB375CDB3,
        GET_NEAREST_PLAYER_TO_ENTITY_ON_TEAM = 0x4DC9A62F844D9337,
        IS_AN_ENTITY = 0x731EC8A916BD11A1,
        IS_ENTITY_A_PED = 0x524AC5ECEA15343E,
        IS_ENTITY_A_MISSION_ENTITY = 0x0A7B270912999B3C,
        IS_ENTITY_A_VEHICLE = 0x6AC7003FA6E5575E,
        IS_ENTITY_AN_OBJECT = 0x8D68C8FD0FACA94E,
        IS_ENTITY_ATTACHED_TO_ANY_OBJECT = 0xCF511840CEEDE0CC,
        IS_ENTITY_ATTACHED_TO_ANY_PED = 0xB1632E9A5F988D11,
        IS_ENTITY_ATTACHED_TO_ANY_VEHICLE = 0x26AA915AD89BFB4B,
        IS_ENTITY_ATTACHED_TO_ENTITY = 0xEFBE71898A993728,
        IS_ENTITY_DEAD = 0x5F9532F3B5CC2551,
        IS_ENTITY_IN_AIR = 0x886E37EC497200B6,
        IS_ENTITY_IN_AREA = 0x54736AA40E271165,
        IS_ENTITY_IN_WATER = 0xCFB0A0D8EDD145A3,
        IS_ENTITY_TOUCHING_ENTITY = 0x17FFC1B2BA35A494,
        IS_ENTITY_TOUCHING_MODEL = 0x0F42323798A58C8C,
        IS_ENTITY_UPRIGHT = 0x5333F526F6AB19AA,
        IS_ENTITY_UPSIDEDOWN = 0x1DBD58820FA61D71,
        IS_ENTITY_VISIBLE = 0x47D6F43D77935C75,
        IS_ENTITY_VISIBLE_TO_SCRIPT = 0xD796CB5BA8F20E32,
        IS_ENTITY_OCCLUDED = 0xE31C2C72B8692B64,
        WOULD_ENTITY_BE_OCCLUDED = 0xEE5D2A122E09EC42,
        IS_ENTITY_WAITING_FOR_WORLD_COLLISION = 0xD05BFF0C0A12C68F,
        _ATTACH_ENTITY_BONE_TO_ENTITY_BONE = 0x5C48B75732C8456C,
        _ATTACH_ENTITY_BONE_TO_ENTITY_BONE_PHYSICALLY = 0xFD1695C5D3B05439,
        CLEAR_ENTITY_LAST_DAMAGE_ENTITY = 0xA72CD9CA74A5ECBA,
        STOP_SYNCHRONIZED_MAP_ENTITY_ANIM = 0x11E79CAB7183B6F5,
        SET_ENTITY_CAN_BE_DAMAGED = 0x1760FFA8AB074D66,
        _GET_ENTITY_CAN_BE_DAMAGED = 0xD95CC5D2AB15A09F,
        SET_ENTITY_CAN_BE_DAMAGED_BY_RELATIONSHIP_GROUP = 0xE22D8FDE858B8119,
        SET_ENTITY_COLLISION = 0x1A9205C1B9EE827F,
        GET_ENTITY_COLLISION_DISABLED = 0xCCF1E97BEFDAE480,
        SET_ENTITY_COMPLETELY_DISABLE_COLLISION = 0x9EBC85ED0FFFE51C,
        SET_ENTITY_COORDS_WITHOUT_PLANTS_RESET = 0x621873ECE1178967,
        SET_ENTITY_DYNAMIC = 0x1718DE8E3F2823CA,
        SET_ENTITY_IS_TARGET_PRIORITY = 0xEA02E132F5C68722,
        SET_ENTITY_LIGHTS = 0x7CFBA6A80BDF3874,
        HAS_COLLISION_LOADED_AROUND_ENTITY = 0xE9676F61BC0B3321,
        SET_ENTITY_MAX_SPEED = 0x0E46A3FCBDE2A1B1,
        SET_ENTITY_ONLY_DAMAGED_BY_PLAYER = 0x79F020FF9EDC0748,
        SET_ENTITY_ONLY_DAMAGED_BY_RELATIONSHIP_GROUP = 0x7022BD828FA0B082,
        _GET_ENTITY_PROOFS = 0xBE8CD9BE829BBEBF,
        SET_ENTITY_RECORDS_COLLISIONS = 0x0A50A1EEDAD01E65,
        _SET_ENTITY_ANGULAR_VELOCITY = 0x8339643499D1222E,
        SET_ENTITY_HAS_GRAVITY = 0x4A4722448F18EEF5,
        GET_ENTITY_ALPHA = 0x5A47B3B5E63E94C6,
        RESET_ENTITY_ALPHA = 0x9B1E824FFBB7027A,
        SET_ENTITY_ALWAYS_PRERENDER = 0xACAD101E1FB66689,
        SET_ENTITY_RENDER_SCORCHED = 0x730F5F8D3F0F2050,
        REMOVE_MODEL_SWAP = 0x033C0F9A64E229AE,
        CREATE_MODEL_HIDE_EXCLUDING_SCRIPT_OBJECTS = 0x3A52AE588830BF7F,
        CREATE_FORCED_OBJECT = 0x150E808B375A385A,
        REMOVE_FORCED_OBJECT = 0x61B6775E83C0DB6F,
        SET_ENTITY_MOTION_BLUR = 0x295D82A8559F9150,
        _GET_ENTITY_BONE_COUNT = 0xB328DCC3A3AA401B,
        _0x352E2B5CF420BF3B = 0x352E2B5CF420BF3B,
        _0x490861B88F4FD846 = 0x490861B88F4FD846,
        _0xCEA7C8E1B48FF68C = 0xCEA7C8E1B48FF68C,
        _0xB17BC6453F6CF5AC = 0xB17BC6453F6CF5AC,
        _0x36F32DE87082343E = 0x36F32DE87082343E,
    }
}