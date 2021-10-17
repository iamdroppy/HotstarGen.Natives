using System;
namespace Hotstar
{
    public enum OBJECT : ulong
    { 
        /// <summary>
        /// Deletes the specified object, then sets the handle pointed to by the pointer to NULL.
        ///
        /// > Object* object
        ///
        /// </summary>
        DELETE_OBJECT = 0x539E0AE3E6634B9F,
        /// <summary>
        /// Returns true if the object has finished moving.
        /// 
        /// If false, moves the object towards the specified X, Y and Z coordinates with the specified X, Y and Z speed.
        /// 
        /// See also: https://gtagmodding.com/opcode-database/opcode/034E/
        /// Has to be looped until it returns true.
        ///
        /// > Object object
        /// > float toX
        /// > float toY
        /// > float toZ
        /// > float speedX
        /// > float speedY
        /// > float speedZ
        /// > BOOL collision
        ///
        /// </summary>
        SLIDE_OBJECT = 0x2FDFF4107B8C1147,
        /// <summary>
        /// Overrides a flag on the object which determines if the object should be avoided by a vehicle in task CTaskVehicleGoToPointWithAvoidanceAutomobile.
        ///
        /// > Object object
        /// > BOOL toggle
        ///
        /// </summary>
        SET_OBJECT_FORCE_VEHICLES_TO_AVOID = 0x77F33F2CCF64B3AA,
        /// <summary>
        /// Has 8 params in the latest patches.
        /// 
        /// isMission - if true doesn't return mission objects
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        /// > Hash modelHash
        /// > BOOL isMission
        /// > BOOL p6
        /// > BOOL p7
        ///
        /// </summary>
        GET_CLOSEST_OBJECT_OF_TYPE = 0xE143FA2249364369,
        /// <summary>
        /// Hardcoded to not work in multiplayer.
        /// 
        /// 
        /// Used to lock/unlock doors to interior areas of the game.
        /// 
        /// (Possible) Door Types:
        /// 
        /// pastebin.com/9S2m3qA4
        /// 
        /// Heading is either 1, 0 or -1 in the scripts. Means default closed(0) or opened either into(1) or out(-1) of the interior.
        /// Locked means that the heading is locked.  
        /// p6 is always 0. 
        /// 
        /// 225 door types, model names and coords found in stripclub.c4:
        /// pastebin.com/gywnbzsH
        /// 
        /// get door info: pastebin.com/i14rbekD
        ///
        /// > Hash type
        /// > float x
        /// > float y
        /// > float z
        /// > BOOL locked
        /// > float heading
        /// > BOOL p6
        ///
        /// </summary>
        SET_STATE_OF_CLOSEST_DOOR_OF_TYPE = 0xF82D8F1926A02C3D,
        /// <summary>
        /// locked is 0 if no door is found
        /// locked is 0 if door is unlocked
        /// locked is 1 if door is found and unlocked.
        /// 
        /// -------------
        /// the locked bool is either 0(unlocked)(false) or 1(locked)(true)
        ///
        /// > Hash type
        /// > float x
        /// > float y
        /// > float z
        /// > BOOL* locked
        /// > float* heading
        ///
        /// </summary>
        GET_STATE_OF_CLOSEST_DOOR_OF_TYPE = 0xEDC1A5B84AEF33FF,
        /// <summary>
        /// Hardcoded not to work in multiplayer environments.
        /// When you set locked to 0 the door open and to 1 the door close
        /// OBJECT::_9B12F9A24FABEDB0(${prop_gate_prison_01}, 1845.0, 2605.0, 45.0, 0, 0.0, 50.0, 0);  //door open
        /// 
        /// OBJECT::_9B12F9A24FABEDB0(${prop_gate_prison_01}, 1845.0, 2605.0, 45.0, 1, 0.0, 50.0, 0);  //door close
        ///
        /// > Hash modelHash
        /// > float x
        /// > float y
        /// > float z
        /// > BOOL locked
        /// > float xRotMult
        /// > float yRotMult
        /// > float zRotMult
        ///
        /// </summary>
        _DOOR_CONTROL = 0x9B12F9A24FABEDB0,
        /// <summary>
        /// doorHash has to be unique. scriptDoor false; relies upon getNetworkGameScriptHandler. isLocal On true disables the creation CRequestDoorEvent's in DOOR_SYSTEM_SET_DOOR_STATE.
        /// p5 only set to true in single player native scripts.
        /// If scriptDoor is true, register the door on the script handler host (note: there's a hardcap on the number of script IDs that can be added to the system at a given time). If scriptDoor and isLocal are both false, the door is considered to be in a "Persists w/o netobj" state.
        /// 
        /// door hashes normally look like PROP_[int]_DOOR_[int] for interior doors and PROP_BUILDING_[int]_DOOR_[int] exterior doors but you can just make up your own hash if you want
        /// All doors need to be registered with ADD_DOOR_TO_SYSTEM before they can be manipulated with the door natives and the easiest way to get door models is just find the door in codewalker.
        /// 
        /// Example: AddDoorToSystem("PROP_43_DOOR_0", "hei_v_ilev_fh_heistdoor2", -1456.818, -520.5037, 69.67043, 0, 0, 0)
        ///
        /// > Hash doorHash
        /// > Hash modelHash
        /// > float x
        /// > float y
        /// > float z
        /// > BOOL p5
        /// > BOOL scriptDoor
        /// > BOOL isLocal
        ///
        /// </summary>
        ADD_DOOR_TO_SYSTEM = 0x6F8838D03D1DC226,
        /// <summary>
        /// CDoor and CDoorSystemData still internally allocated (and their associations between doorHash, modelHash, and coordinates).
        /// Only its NetObj removed and flag ``*(v2 + 192) |= 8u`` (1604 retail) toggled.
        ///
        /// > Hash doorHash
        ///
        /// </summary>
        REMOVE_DOOR_FROM_SYSTEM = 0x464D8E1427156FE4,
        /// <summary>
        /// Lockstates not applied and CNetObjDoor's not created until DOOR_SYSTEM_GET_IS_PHYSICS_LOADED returns true.
        /// `requestDoor` on true, and when door system is configured to, i.e., "persists w/o netobj", generate a CRequestDoorEvent.
        /// `forceUpdate` on true, forces an update on the door system (same path as netObjDoor_applyDoorStuff)
        /// Door lock states:
        /// 0: UNLOCKED
        /// 1: LOCKED
        /// 2: DOORSTATE_FORCE_LOCKED_UNTIL_OUT_OF_AREA
        /// 3: DOORSTATE_FORCE_UNLOCKED_THIS_FRAME
        /// 4: DOORSTATE_FORCE_LOCKED_THIS_FRAME
        /// 5: DOORSTATE_FORCE_OPEN_THIS_FRAME
        /// 6: DOORSTATE_FORCE_CLOSED_THIS_FRAME
        ///
        /// > Hash doorHash
        /// > int state
        /// > BOOL requestDoor
        /// > BOOL forceUpdate
        ///
        /// </summary>
        DOOR_SYSTEM_SET_DOOR_STATE = 0x6BAB9442830C7F53,
        /// <summary>
        /// Includes networking check: ownership vs. or the door itself **isn't** networked.
        /// `forceUpdate` on true invokes DOOR_SYSTEM_SET_DOOR_STATE otherwise requestDoor is unused.
        ///
        /// > Hash doorHash
        /// > float rate
        /// > BOOL requestDoor
        /// > BOOL forceUpdate
        ///
        /// </summary>
        DOOR_SYSTEM_SET_AUTOMATIC_RATE = 0x03C27E13B42A0E82,
        /// <summary>
        /// `forceUpdate` on true invokes DOOR_SYSTEM_SET_DOOR_STATE otherwise requestDoor is unused.
        ///
        /// > Hash doorHash
        /// > float distance
        /// > BOOL requestDoor
        /// > BOOL forceUpdate
        ///
        /// </summary>
        DOOR_SYSTEM_SET_AUTOMATIC_DISTANCE = 0x9BA001CB45CBF627,
        /// <summary>
        /// Sets the ajar angle of a door.
        /// Ranges from -1.0 to 1.0, and 0.0 is closed / default.
        /// `forceUpdate` on true invokes DOOR_SYSTEM_SET_DOOR_STATE otherwise requestDoor is unused.
        ///
        /// > Hash doorHash
        /// > float ajar
        /// > BOOL requestDoor
        /// > BOOL forceUpdate
        ///
        /// </summary>
        DOOR_SYSTEM_SET_OPEN_RATIO = 0xB6E6FBA95C7324AC,
        /// <summary>
        /// Includes networking check: ownership vs. or the door itself **isn't** networked.
        /// `forceUpdate` on true invokes DOOR_SYSTEM_SET_DOOR_STATE otherwise requestDoor is unused.
        ///
        /// > Hash doorHash
        /// > BOOL removed
        /// > BOOL requestDoor
        /// > BOOL forceUpdate
        ///
        /// </summary>
        DOOR_SYSTEM_SET_SPRING_REMOVED = 0xC485E07E4F0B7958,
        /// <summary>
        /// Includes networking check: ownership vs. or the door itself **isn't** networked.
        ///
        /// > Hash doorHash
        /// > BOOL toggle
        ///
        /// </summary>
        DOOR_SYSTEM_SET_HOLD_OPEN = 0xD9B71952F78A2640,
        /// <summary>
        /// if (OBJECT::IS_DOOR_REGISTERED_WITH_SYSTEM(doorHash)) 
        /// {
        ///     OBJECT::REMOVE_DOOR_FROM_SYSTEM(doorHash);
        /// }
        ///
        /// > Hash doorHash
        ///
        /// </summary>
        IS_DOOR_REGISTERED_WITH_SYSTEM = 0xC153C43EA202C8C1,
        /// <summary>
        /// Search radius: 0.5
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > Hash modelHash
        /// > Hash* outDoorHash
        ///
        /// </summary>
        DOOR_SYSTEM_FIND_EXISTING_DOOR = 0x589F80B325CC82C5,
        /// <summary>
        /// Despite the name, it does work for any entity type.
        ///
        /// > Hash garageHash
        /// > Entity entity
        /// > float p2
        /// > int p3
        ///
        /// </summary>
        IS_OBJECT_ENTIRELY_INSIDE_GARAGE = 0x372EF6699146A1E4,
        /// <summary>
        /// Despite the name, it does work for any entity type.
        ///
        /// > Hash garageHash
        /// > Entity entity
        /// > int p2
        ///
        /// </summary>
        IS_OBJECT_PARTIALLY_INSIDE_GARAGE = 0xF0EED5A6BC7B237A,
        /// <summary>
        /// CLEAR_*
        ///
        /// > Hash garageHash
        /// > BOOL isNetwork
        ///
        /// </summary>
        _CLEAR_GARAGE_AREA = 0xDA05194260CDCDF9,
        /// <summary>
        /// p5 is usually 0.
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        /// > Hash hash
        /// > BOOL p5
        ///
        /// </summary>
        DOES_OBJECT_OF_TYPE_EXIST_AT_COORDS = 0xBFA48E2FF417213F,
        /// <summary>
        /// An angled area is an X-Z oriented rectangle with three parameters:
        /// 1. origin: the mid-point along a base edge of the rectangle;
        /// 2. extent: the mid-point of opposite base edge on the other Z;
        /// 3. width: the length of the base edge; (named derived from logging strings ``CNetworkRoadNodeWorldStateData``).
        /// 
        /// The oriented rectangle can then be derived from the direction of the two points (``norm(origin - extent)``), its orthonormal, and the width, e.g:
        /// 1. golf_mp https://i.imgur.com/JhsQAK9.png
        /// 2. am_taxi https://i.imgur.com/TJWCZaT.jpg
        ///
        /// > float xPos
        /// > float yPos
        /// > float zPos
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > float width
        /// > BOOL debug
        /// > BOOL includeZ
        ///
        /// </summary>
        IS_POINT_IN_ANGLED_AREA = 0x2A70BAE8883E4C81,
        /// <summary>
        /// Overrides the climbing/blocking flags of the object, used in the native scripts mostly for "prop_dock_bouy_*"
        ///
        /// > Object object
        /// > BOOL toggle
        ///
        /// </summary>
        SET_OBJECT_ALLOW_LOW_LOD_BUOYANCY = 0x4D89D607CB3DD1D2,
        /// <summary>
        /// Adjust the physics parameters of a prop, or otherwise known as "object". This is useful for simulated gravity.
        /// 
        /// Other parameters seem to be unknown.
        /// 
        /// p2: seems to be weight and gravity related. Higher value makes the obj fall faster. Very sensitive?
        /// p3: seems similar to p2
        /// p4: makes obj fall slower the higher the value
        /// p5: similar to p4
        ///
        /// > Object object
        /// > float weight
        /// > float p2
        /// > float p3
        /// > float p4
        /// > float p5
        /// > float gravity
        /// > float p7
        /// > float p8
        /// > float p9
        /// > float p10
        /// > float buoyancy
        ///
        /// </summary>
        SET_OBJECT_PHYSICS_PARAMS = 0xF6DF6E90DE7DF90F,
        /// <summary>
        /// Requires a component_at_*_flsh to be attached to the weapon object
        ///
        /// > Object object
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_CREATE_WEAPON_OBJECT_LIGHT_SOURCE = 0xBCE595371A5FBAAF,
        /// <summary>
        /// Example:
        /// OBJECT::GET_RAYFIRE_MAP_OBJECT(-809.9619750976562, 170.919, 75.7406997680664, 3.0, "des_tvsmash");
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        /// > const char* name
        ///
        /// </summary>
        GET_RAYFIRE_MAP_OBJECT = 0xB48FCED898292E52,
        /// <summary>
        /// Defines the state of a destructible object.
        /// Use the GET_RAYFIRE_MAP_OBJECT native to find an object's handle with its name / coords.
        /// State 2 == object just spawned
        /// State 4 == Beginning of the animation
        /// State 6 == Start animation
        /// State 9 == End of the animation
        ///
        /// > Object object
        /// > int state
        ///
        /// </summary>
        SET_STATE_OF_RAYFIRE_MAP_OBJECT = 0x5C29F698D404C5E1,
        /// <summary>
        /// Get a destructible object's state.
        /// Substract 1 to get the real state.
        /// See SET_STATE_OF_RAYFIRE_MAP_OBJECT to see the different states
        /// For example, if the object just spawned (state 2), the native will return 3.
        ///
        /// > Object object
        ///
        /// </summary>
        GET_STATE_OF_RAYFIRE_MAP_OBJECT = 0x899BA936634A322E,
        /// <summary>
        /// Returns true if a destructible object with this handle exists, false otherwise.  
        ///
        /// > Object object
        ///
        /// </summary>
        DOES_RAYFIRE_MAP_OBJECT_EXIST = 0x52AF537A0C5B8AAD,
        /// <summary>
        /// `object`: The des-object handle to get the animation progress from.
        /// Return value is a float between 0.0 and 1.0, 0.0 is the beginning of the animation, 1.0 is the end. Value resets to 0.0 instantly after reaching 1.0.
        ///
        /// > Object object
        ///
        /// </summary>
        GET_RAYFIRE_MAP_OBJECT_ANIM_PHASE = 0x260EE4FDBDF4DB01,
        /// <summary>
        /// Pickup hashes: pastebin.com/8EuSv2r1
        /// 
        /// Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pickupTypes.json
        ///
        /// > Hash pickupHash
        /// > float posX
        /// > float posY
        /// > float posZ
        /// > int p4
        /// > int value
        /// > BOOL p6
        /// > Hash modelHash
        ///
        /// </summary>
        CREATE_PICKUP = 0xFBA08C503DD5FA58,
        /// <summary>
        /// Pickup hashes: pastebin.com/8EuSv2r1
        /// 
        /// flags:
        /// 8 (1 << 3): place on ground
        /// 512 (1 << 9): spin around
        /// 
        /// Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pickupTypes.json
        ///
        /// > Hash pickupHash
        /// > float posX
        /// > float posY
        /// > float posZ
        /// > float rotX
        /// > float rotY
        /// > float rotZ
        /// > int flag
        /// > int amount
        /// > Any p9
        /// > BOOL p10
        /// > Hash modelHash
        ///
        /// </summary>
        CREATE_PICKUP_ROTATE = 0x891804727E0A98B7,
        /// <summary>
        /// Used for doing money drop
        /// Pickup hashes: pastebin.com/8EuSv2r1
        /// 
        /// Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pickupTypes.json
        ///
        /// > Hash pickupHash
        /// > float posX
        /// > float posY
        /// > float posZ
        /// > int flags
        /// > int value
        /// > Hash modelHash
        /// > BOOL p7
        /// > BOOL p8
        ///
        /// </summary>
        CREATE_AMBIENT_PICKUP = 0x673966A0C0FD7171,
        /// <summary>
        /// Pickup hashes: pastebin.com/8EuSv2r1
        /// 
        /// Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pickupTypes.json
        ///
        /// > Hash pickupHash
        /// > float x
        /// > float y
        /// > float z
        /// > BOOL placeOnGround
        /// > Hash modelHash
        ///
        /// </summary>
        CREATE_PORTABLE_PICKUP = 0x2EAF1FDB2FB55698,
        /// <summary>
        /// Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pickupTypes.json
        ///
        /// > Hash pickupHash
        /// > float x
        /// > float y
        /// > float z
        /// > BOOL placeOnGround
        /// > Hash modelHash
        ///
        /// </summary>
        CREATE_NON_NETWORKED_PORTABLE_PICKUP = 0x125494B98A21AAF7,
        /// <summary>
        /// Pickup hashes: pastebin.com/8EuSv2r1
        /// 
        /// Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pickupTypes.json
        ///
        /// > Hash pickupHash
        ///
        /// </summary>
        REMOVE_ALL_PICKUPS_OF_TYPE = 0x27F9D613092159CF,
        /// <summary>
        /// Spawns one or more money pickups.
        /// 
        /// x: The X-component of the world position to spawn the money pickups at.
        /// y: The Y-component of the world position to spawn the money pickups at.
        /// z: The Z-component of the world position to spawn the money pickups at.
        /// value: The combined value of the pickups (in dollars).
        /// amount: The number of pickups to spawn.
        /// model: The model to use, or 0 for default money model.
        /// 
        /// Example:
        /// CREATE_MONEY_PICKUPS(x, y, z, 1000, 3, 0x684a97ae);
        /// 
        /// Spawns 3 spray cans that'll collectively give $1000 when picked up. (Three spray cans, each giving $334, $334, $332 = $1000).
        /// 
        /// ==============================================
        /// 
        /// Max is 2000 in MP. So if you put the amount to 20, but the value to $400,000 eg. They will only be able to pickup 20 - $2,000 bags. So, $40,000
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > int value
        /// > int amount
        /// > Hash model
        ///
        /// </summary>
        CREATE_MONEY_PICKUPS = 0x0589B5E791CE9B2B,
        /// <summary>
        /// Pickup hashes: pastebin.com/8EuSv2r1
        /// 
        /// Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pickupTypes.json
        ///
        /// > Hash pickupHash
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        ///
        /// </summary>
        DOES_PICKUP_OF_TYPE_EXIST_IN_AREA = 0xF9C36251F6E48E33,
        /// <summary>
        /// Disabling/enabling a player from getting pickups. From the scripts:
        /// 
        /// OBJECT::_616093EC6B139DD9(PLAYER::PLAYER_ID(), ${pickup_portable_package}, 0);
        /// OBJECT::_616093EC6B139DD9(PLAYER::PLAYER_ID(), ${pickup_portable_package}, 0);
        /// OBJECT::_616093EC6B139DD9(PLAYER::PLAYER_ID(), ${pickup_portable_package}, 1);
        /// OBJECT::_616093EC6B139DD9(PLAYER::PLAYER_ID(), ${pickup_portable_package}, 0);
        /// OBJECT::_616093EC6B139DD9(PLAYER::PLAYER_ID(), ${pickup_armour_standard}, 0);
        /// OBJECT::_616093EC6B139DD9(PLAYER::PLAYER_ID(), ${pickup_armour_standard}, 1);
        /// 
        /// SET_PLAYER_*
        /// 
        /// Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pickupTypes.json
        ///
        /// > Player player
        /// > Hash pickupHash
        /// > BOOL toggle
        ///
        /// </summary>
        _TOGGLE_USE_PICKUPS_FOR_PLAYER = 0x616093EC6B139DD9,
        /// <summary>
        /// Maximum amount of pickup models that can be disallowed is 30.
        /// 
        /// SET_LOCAL_PLAYER_*
        ///
        /// > Hash modelHash
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_LOCAL_PLAYER_CAN_USE_PICKUPS_WITH_THIS_MODEL = 0x88EAEC617CD26926,
        /// <summary>
        /// draws circular marker at pos
        /// -1 = none
        /// 0 = red
        /// 1 = green
        /// 2 = blue
        /// 3 = green larger
        /// 4 = nothing
        /// 5 = green small
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > int colorIndex
        ///
        /// </summary>
        RENDER_FAKE_PICKUP_GLOW = 0x3430676B11CDF21D,
        /// <summary>
        /// Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pickupTypes.json
        ///
        /// > Hash pickupHash
        ///
        /// </summary>
        GET_WEAPON_TYPE_FROM_PICKUP_TYPE = 0x08F96CA6C551AD51,
        /// <summary>
        /// Returns the pickup hash for the given weapon hash
        ///
        /// > Hash weaponHash
        ///
        /// </summary>
        _GET_PICKUP_HASH_FROM_WEAPON = 0xD6429A016084F1A5,
        /// <summary>
        /// enum ObjectPaintVariants
        /// {
        ///  Pacific = 0,
        ///   Azure = 1,
        ///     Nautical = 2,
        ///  Continental = 3,
        ///   Battleship = 4,
        ///    Intrepid = 5,
        ///  Uniform = 6,
        ///   Classico = 7,
        ///  Mediterranean = 8,
        ///     Command = 9,
        ///   Mariner = 10,
        ///  Ruby = 11,
        ///     Vintage = 12,
        ///  Pristine = 13,
        ///     Merchant = 14,
        ///     Voyager = 15
        /// };
        ///
        /// > Object object
        /// > int textureVariation
        ///
        /// </summary>
        _SET_OBJECT_TEXTURE_VARIATION = 0x971DA0055324D033,
        /// <summary>
        /// returns pickup hash.
        /// 
        /// Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pickupTypes.json
        ///
        /// > Hash pickupHash
        ///
        /// </summary>
        _GET_PICKUP_HASH = 0x5EAAD83F8CFB4575,
        /// <summary>
        /// is this like setting is as no longer needed?
        ///
        /// > Object object
        ///
        /// </summary>
        _MARK_OBJECT_FOR_DELETION = 0xADBE4809F19F927A,
        /// <summary>
        /// Activate the physics to: "xs_prop_arena_{flipper,wall,bollard,turntable,pit}"
        ///
        /// > Object object
        /// > BOOL toggle
        /// > int p2
        ///
        /// </summary>
        _SET_ENABLE_ARENA_PROP_PHYSICS = 0x911024442F4898F0,
        /// <summary>
        /// Some property related to gates. Native name between ``DOOR_SYSTEM_SET_AUTOMATIC_RATE`` and ``DOOR_SYSTEM_SET_DOOR_STATE``.
        ///
        /// > Hash doorHash
        /// > BOOL p1
        ///
        /// </summary>
        _0xA85A21582451E951 = 0xA85A21582451E951,
        /// <summary>
        /// Clears the fields sets by 0xC7F29CA00F46350E (1604 retail: 0x1424A7A10, 0x1424A7A11) and iterates over the global CDoor's bucket-list.
        /// Related to its "Pre-networked state"?
        ///
        ///
        /// </summary>
        _0x701FDA1E82076BA4 = 0x701FDA1E82076BA4,
        /// <summary>
        /// Sets a flag. A valid id is 0x157DC10D
        /// SET_FLAG_??
        ///
        /// > int id
        /// > BOOL toggle
        ///
        /// </summary>
        _0x659F9D71F52843F8 = 0x659F9D71F52843F8,
        /// <summary>
        /// Adds an area that seems to be related to pickup physics behavior.
        /// Max amount of areas is 10. Only works in multiplayer.
        /// 
        /// ADD_*
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        ///
        /// </summary>
        _0xD4A7A435B3710D05 = 0xD4A7A435B3710D05,
        /// <summary>
        /// Clears all areas created by 0xD4A7A435B3710D05
        /// 
        /// CLEAR_*
        ///
        ///
        /// </summary>
        _0xB7C6D80FB371659A = 0xB7C6D80FB371659A,
        /// <summary>
        /// A*
        /// 
        /// Full list of pickup types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pickupTypes.json
        ///
        /// > Hash pickupHash
        ///
        /// </summary>
        _0xFDC07C58E8AAB715 = 0xFDC07C58E8AAB715,
        /// <summary>
        /// Sets some bit of pickup
        /// SET_PICKUP_*
        ///
        /// > Pickup pickup
        /// > BOOL toggle
        ///
        /// </summary>
        _0x4C134B4DF76025D0 = 0x4C134B4DF76025D0,
        /// <summary>
        /// Sets some value of pickup
        /// SET_PICKUP_*
        ///
        /// > Pickup pickup
        /// > BOOL toggle
        ///
        /// </summary>
        _0xAA059C615DE9DD03 = 0xAA059C615DE9DD03,
        /// <summary>
        /// CLEAR_*
        ///
        ///
        /// </summary>
        _0xA2C1F5E92AFE49ED = 0xA2C1F5E92AFE49ED,
        /// <summary>
        /// SET_PICKUP_*
        ///
        /// > Pickup pickup
        ///
        /// </summary>
        _0x7813E8B8C4AE4799 = 0x7813E8B8C4AE4799,
        /// <summary>
        /// Sets some pickup flag?
        /// SET_PICKUP_*
        ///
        /// > Pickup pickup
        /// > BOOL toggle
        ///
        /// </summary>
        _0xBFFE53AE7E67FCDC = 0xBFFE53AE7E67FCDC,
        /// <summary>
        /// Sets entity+38 to C (when false) or 0xFF3f (when true)
        /// SET_ENTITY_??
        ///
        /// > Entity entity
        /// > BOOL toggle
        ///
        /// </summary>
        _0xD05A3241B9A86F19 = 0xD05A3241B9A86F19,
        /// <summary>
        /// GET_OBJECT_??
        ///
        /// > Object object
        ///
        /// </summary>
        _0xADF084FB8F075D06 = 0xADF084FB8F075D06,
        /// <summary>
        /// SET_OBJECT_*
        ///
        /// > Object object
        /// > BOOL toggle
        ///
        /// </summary>
        _0x3B2FD68DB5F8331C = 0x3B2FD68DB5F8331C,
        /// <summary>
        /// Sets some bit of object
        /// SET_OBJECT_*
        ///
        /// > Object object
        /// > BOOL toggle
        ///
        /// </summary>
        _0x734E1714D077DA9A = 0x734E1714D077DA9A,
        /// <summary>
        /// Sets some bit of object
        /// SET_OBJECT_*
        ///
        /// > Object object
        /// > BOOL p1
        ///
        /// </summary>
        _0x1A6CBB06E2D0D79D = 0x1A6CBB06E2D0D79D,
        /// <summary>
        /// Sets some flag of object
        /// SET_OBJECT_*
        ///
        /// > Object object
        /// > BOOL toggle
        ///
        /// </summary>
        _0x1C57C94A6446492A = 0x1C57C94A6446492A,
        /// <summary>
        /// Sets some bit of object
        /// SET_OBJECT_*
        ///
        /// > Object object
        /// > BOOL toggle
        ///
        /// </summary>
        _0xB5B7742424BD4445 = 0xB5B7742424BD4445,
        CREATE_OBJECT = 0x509D5878EB39E842,
        CREATE_OBJECT_NO_OFFSET = 0x9A294B2138ABB884,
        PLACE_OBJECT_ON_GROUND_PROPERLY = 0x58A850EAEE20FAA3,
        _PLACE_OBJECT_ON_GROUND_PROPERLY_2 = 0xD76EEEF746057FD6,
        SET_OBJECT_TARGETTABLE = 0x8A7391690F5AFD81,
        HAS_OBJECT_BEEN_BROKEN = 0x8ABFB70C49CC43E2,
        HAS_CLOSEST_OBJECT_OF_TYPE_BEEN_BROKEN = 0x761B0E69AC4D007E,
        HAS_CLOSEST_OBJECT_OF_TYPE_BEEN_COMPLETELY_DESTROYED = 0x46494A2475701343,
        _GET_OBJECT_OFFSET_FROM_COORDS = 0x163E252DE035A133,
        GET_COORDS_AND_ROTATION_OF_CLOSEST_OBJECT_OF_TYPE = 0x163F8B586BC95F2A,
        DOOR_SYSTEM_GET_DOOR_STATE = 0x160AA1B32F6139B8,
        DOOR_SYSTEM_GET_DOOR_PENDING_STATE = 0x4BC2854478F3A749,
        DOOR_SYSTEM_GET_OPEN_RATIO = 0x65499865FCA6E5EC,
        IS_DOOR_CLOSED = 0xC531EE8A1145A149,
        DOOR_SYSTEM_GET_IS_PHYSICS_LOADED = 0xDF97CDD4FC08FD34,
        IS_GARAGE_EMPTY = 0x90E47239EA1980B8,
        IS_PLAYER_ENTIRELY_INSIDE_GARAGE = 0x024A60DEB0EA69F0,
        IS_PLAYER_PARTIALLY_INSIDE_GARAGE = 0x1761DC5D8471CBAA,
        ARE_ENTITIES_ENTIRELY_INSIDE_GARAGE = 0x85B6C850546FDDE2,
        IS_ANY_ENTITY_ENTIRELY_INSIDE_GARAGE = 0x673ED815D6E323B7,
        CLEAR_OBJECTS_INSIDE_GARAGE = 0x190428512B240692,
        ENABLE_SAVING_IN_GARAGE = 0xF2E1A7133DD356A6,
        GET_OBJECT_FRAGMENT_DAMAGE_HEALTH = 0xB6FBFD079B8D0596,
        SET_ACTIVATE_OBJECT_PHYSICS_AS_SOON_AS_IT_IS_UNFROZEN = 0x406137F8EF90EAF5,
        IS_ANY_OBJECT_NEAR_POINT = 0x397DC58FF00298D1,
        IS_OBJECT_NEAR_POINT = 0x8C90FE4B381BA60A,
        REMOVE_OBJECT_HIGH_DETAIL_MODEL = 0x4A39DB43E47CF3AA,
        BREAK_OBJECT_FRAGMENT_CHILD = 0xE7E4C198B0185900,
        TRACK_OBJECT_VISIBILITY = 0xB252BC036B525623,
        IS_OBJECT_VISIBLE = 0x8B32ACE6326A7546,
        _SET_UNK_GLOBAL_BOOL_RELATED_TO_DAMAGE = 0xABDABF4E1EDECBFA,
        _CREATE_NON_NETWORKED_AMBIENT_PICKUP = 0x9C93764223E29C50,
        ATTACH_PORTABLE_PICKUP_TO_PED = 0x8DC39368BDD57755,
        DETACH_PORTABLE_PICKUP_FROM_PED = 0xCF463D1E9A0AECB1,
        _HIDE_PICKUP = 0x867458251D47CCB2,
        SET_MAX_NUM_PORTABLE_PICKUPS_CARRIED_BY_PLAYER = 0x0BF3B3BD47D79C08,
        SET_LOCAL_PLAYER_CAN_COLLECT_PORTABLE_PICKUPS = 0x78857FC65CADB909,
        GET_SAFE_PICKUP_COORDS = 0x6E16BC2503FF1FF0,
        GET_PICKUP_COORDS = 0x225B8B35C88029B3,
        HAS_PICKUP_BEEN_COLLECTED = 0x80EC48E6679313F9,
        REMOVE_PICKUP = 0x3288D8ACAECD2AB2,
        DOES_PICKUP_EXIST = 0xAFC1CA75AD4074D1,
        DOES_PICKUP_OBJECT_EXIST = 0xD9EFB6DBF7DAAEA3,
        GET_PICKUP_OBJECT = 0x5099BC55630B25AE,
        IS_OBJECT_A_PORTABLE_PICKUP = 0xFC481C641EBBD27D,
        IS_OBJECT_A_PICKUP = 0x0378C08504160D0D,
        SET_PICKUP_REGENERATION_TIME = 0x78015C9B4B3ECC9D,
        FORCE_PICKUP_REGENERATE = 0x758A5C1B3B1E1990,
        SET_TEAM_PICKUP_OBJECT = 0x53E0DF1A2A3CF0CA,
        PREVENT_COLLECTION_OF_PORTABLE_PICKUP = 0x92AEFB5F6E294023,
        SET_PICKUP_GENERATION_RANGE_MULTIPLIER = 0x318516E02DE3ECE2,
        _GET_PICKUP_GENERATION_RANGE_MULTIPLIER = 0xB3ECA65C7317F174,
        SET_PICKUP_UNCOLLECTABLE = 0x1C1B69FAE509BA97,
        SET_PICKUP_HIDDEN_WHEN_UNCOLLECTABLE = 0x3ED2B83AB2E82799,
        IS_PICKUP_WEAPON_OBJECT_VALID = 0x11D1E53A726891FE,
        _GET_OBJECT_TEXTURE_VARIATION = 0xE84EB93729C5F36A,
        _SET_TEXTURE_VARIATION_OF_CLOSEST_OBJECT_OF_TYPE = 0xF12E33034D887F66,
        _SET_OBJECT_LIGHT_COLOR = 0x5F048334B4A4E774,
        _SET_OBJECT_STUNT_PROP_SPEEDUP = 0x96EE0EBA0163DF80,
        _SET_OBJECT_STUNT_PROP_DURATION = 0xDF6CA0330F2E737B,
        SET_FORCE_OBJECT_THIS_FRAME = 0xF538081986E49E9D,
        _SET_ENABLE_ARENA_PROP_PHYSICS_ON_PED = 0xB20834A7DD3D8896,
        _GET_IS_ARENA_PROP_PHYSICS_DISABLED = 0x43C677F1E1158005,
        _0xAFE24E4D29249E4A = 0xAFE24E4D29249E4A,
        _0x2542269291C6AC84 = 0x2542269291C6AC84,
        _0x006E4B040ED37EC3 = 0x006E4B040ED37EC3,
        _0xE851471AEFC3374F = 0xE851471AEFC3374F,
        _0xC7F29CA00F46350E = 0xC7F29CA00F46350E,
        _0x66A49D021870FE88 = 0x66A49D021870FE88,
        _0xE05F6AEEFEB0BB02 = 0xE05F6AEEFEB0BB02,
        _0xF9C1681347C8BD15 = 0xF9C1681347C8BD15,
        _0xC6033D32241F6FB5 = 0xC6033D32241F6FB5,
        _0xEB6F1A9B5510A5D2 = 0xEB6F1A9B5510A5D2,
        _0x394CD08E31313C28 = 0x394CD08E31313C28,
        _0x826D1EE4D1CAFC78 = 0x826D1EE4D1CAFC78,
        _0x1E3F1B1B891A2AAA = 0x1E3F1B1B891A2AAA,
        _0x8DCA505A5C196F05 = 0x8DCA505A5C196F05,
        _0x27F248C3FEBFAAD3 = 0x27F248C3FEBFAAD3,
        _0x0596843B34B95CE5 = 0x0596843B34B95CE5,
        _0xA08FE5E49BDC39DD = 0xA08FE5E49BDC39DD,
        _0x62454A641B41F3C5 = 0x62454A641B41F3C5,
        _0x39A5FB7EAF150840 = 0x39A5FB7EAF150840,
        _0x834344A414C7C85D = 0x834344A414C7C85D,
        _0xDB41D07A45A6D4B7 = 0xDB41D07A45A6D4B7,
        _0x31F924B53EADDF65 = 0x31F924B53EADDF65,
        _0x858EC9FD25DE04AA = 0x858EC9FD25DE04AA,
        _0x8881C98A31117998 = 0x8881C98A31117998,
        _0x8CFF648FBD7330F1 = 0x8CFF648FBD7330F1,
        _0x46F3ADD1E2D5BAF2 = 0x46F3ADD1E2D5BAF2,
        _0x641F272B52E2F0F8 = 0x641F272B52E2F0F8,
        _0xF92099527DB8E2A7 = 0xF92099527DB8E2A7,
        _0x762DB2D380B48D04 = 0x762DB2D380B48D04,
        _0xB2D0BDE54F0E8E5A = 0xB2D0BDE54F0E8E5A,
        _0x31574B1B41268673 = 0x31574B1B41268673,
        _0x8CAAB2BD3EA58BD4 = 0x8CAAB2BD3EA58BD4,
        _0x63ECF581BC70E363 = 0x63ECF581BC70E363,
        _0x3BD770D281982DB5 = 0x3BD770D281982DB5,
    }
}