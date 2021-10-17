using System;
namespace Hotstar
{
    public enum PATHFIND : ulong
    { 
        /// <summary>
        /// When nodeEnabled is set to false, all nodes in the area get disabled.
        /// `GET_VEHICLE_NODE_IS_SWITCHED_OFF` returns true afterwards.
        /// If it's true, `GET_VEHICLE_NODE_IS_SWITCHED_OFF` returns false.
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > BOOL nodeEnabled
        /// > BOOL unknown2
        ///
        /// </summary>
        SET_ROADS_IN_AREA = 0xBF1A602B5BA52FEE,
        /// <summary>
        /// unknown3 is related to `SEND_SCRIPT_WORLD_STATE_EVENT > CNetworkRoadNodeWorldStateData` in networked environments.
        /// See IS_POINT_IN_ANGLED_AREA for the definition of an angled area.
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > float width
        /// > BOOL unknown1
        /// > BOOL unknown2
        /// > BOOL unknown3
        ///
        /// </summary>
        SET_ROADS_IN_ANGLED_AREA = 0x1A5AA1208AF5DB59,
        /// <summary>
        /// Flags are:
        /// 1 = 1 = B02_IsFootpath
        /// 2 = 4 = !B15_InteractionUnk
        /// 4 = 0x20 = !B14_IsInterior
        /// 8 = 0x40 = !B07_IsWater
        /// 16 = 0x200 = B17_IsFlatGround
        /// When onGround == true outPosition is a position located on the nearest pavement.
        /// 
        /// When a safe coord could not be found the result of a function is false and outPosition == Vector3.Zero.
        /// 
        /// In the scripts these flags are used: 0, 14, 12, 16, 20, 21, 28. 0 is most commonly used, then 16. 
        /// 
        /// 16 works for me, 0 crashed the script.
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > BOOL onGround
        /// > Vector3* outPosition
        /// > int flags
        ///
        /// </summary>
        GET_SAFE_COORD_FOR_PED = 0xB61C8E878A4199CA,
        /// <summary>
        /// FYI: When falling through the map (or however you got under it) you will respawn when your player ped's height is <= -200.0 meters (I think you all know this) and when in a vehicle you will actually respawn at the closest vehicle node.
        /// 
        /// ----------
        /// 
        /// Vector3 nodePos;
        /// GET_CLOSEST_VEHICLE_NODE(x,y,z,&nodePos,...)
        /// 
        /// p4 is either 0, 1 or 8. 1 means any path/road. 0 means node in the middle of the closest main (asphalt) road.
        /// p5, p6 are always the same:
        /// 0x40400000 (3.0), 0
        /// p5 can also be 100.0 and p6 can be 2.5:
        /// PATHFIND::GET_CLOSEST_VEHICLE_NODE(a_0, &v_5, v_9, 100.0, 2.5)
        /// 
        /// Known node types: simple path/asphalt road, only asphalt road, water, under the map at always the same coords. 
        /// 
        /// The node types follows a pattern. For example, every fourth node is of the type water i.e. 3, 7, 11, 15, 19, 23, 27, 31, 35, 39... 239. Could not see any difference between nodes within certain types. 
        /// Starting at 2, every fourth node is under the map, always same coords.
        /// Same with only asphalt road (0, 4, 8, etc) and simple path/asphalt road (1, 5, 9, etc). 
        /// 
        /// gtaforums.com/topic/843561-pathfind-node-types
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > Vector3* outPosition
        /// > int nodeType
        /// > float p5
        /// > float p6
        ///
        /// </summary>
        GET_CLOSEST_VEHICLE_NODE = 0x240A18690AE96513,
        /// <summary>
        /// Get the closest vehicle node to a given position, unknown1 = 3.0, unknown2 = 0
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > Vector3* outPosition
        /// > float unknown1
        /// > int unknown2
        ///
        /// </summary>
        GET_CLOSEST_MAJOR_VEHICLE_NODE = 0x2EABE3B06F58C1BE,
        /// <summary>
        /// p5, p6 and p7 seems to be about the same as p4, p5 and p6 for GET_CLOSEST_VEHICLE_NODE. p6 and/or p7 has something to do with finding a node on the same path/road and same direction(at least for this native, something to do with the heading maybe). Edit this when you find out more.
        /// 
        /// p5 is either 1 or 12. 1 means any path/road. 12, 8, 0 means node in the middle of the closest main (asphalt) road.
        /// p6 is always 3.0
        /// p7 is always 0.
        /// 
        /// Known node types: simple path/asphalt road, only asphalt road, water, under the map at always the same coords. 
        /// 
        /// The node types follows a pattern. For example, every fourth node is of the type water i.e. 3, 7, 11, 15, 19, 23, 27, 31, 35, 39... 239. Could not see any difference between nodes within certain types. 
        /// Starting at 2, every fourth node is under the map, always same coords.
        /// Same with only asphalt road (0, 4, 8, etc) and simple path/asphalt road (1, 5, 9, etc).
        /// 
        /// gtaforums.com/topic/843561-pathfind-node-types
        /// 
        /// Example of usage, moving vehicle to closest path/road:
        /// Vector3 coords = ENTITY::GET_ENTITY_COORDS(playerVeh, true);
        /// Vector3 closestVehicleNodeCoords; 
        /// float roadHeading; 
        /// PATHFIND::GET_CLOSEST_VEHICLE_NODE_WITH_HEADING(coords.x, coords.y, coords.z, &closestVehicleNodeCoords, &roadHeading, 1, 3, 0); 
        /// ENTITY::SET_ENTITY_HEADING(playerVeh, roadHeading);
        /// ENTITY::SET_ENTITY_COORDS(playerVeh, closestVehicleNodeCoords.x, closestVehicleNodeCoords.y, closestVehicleNodeCoords.z, 1, 0, 0, 1);
        /// VEHICLE::SET_VEHICLE_ON_GROUND_PROPERLY(playerVeh);
        /// 
        /// ------------------------------------------------------------------
        /// C# Example (ins1de) : pastebin.com/fxtMWAHD
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > Vector3* outPosition
        /// > float* outHeading
        /// > int nodeType
        /// > float p6
        /// > int p7
        ///
        /// </summary>
        GET_CLOSEST_VEHICLE_NODE_WITH_HEADING = 0xFF071FB798B803B0,
        /// <summary>
        /// Returns the id.
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > int nth
        /// > int nodetype
        /// > float p5
        /// > float p6
        ///
        /// </summary>
        GET_NTH_CLOSEST_VEHICLE_NODE_ID = 0x22D7275A79FE8215,
        /// <summary>
        /// Get the nth closest vehicle node and its heading. (unknown2 = 9, unknown3 = 3.0, unknown4 = 2.5)
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > int nthClosest
        /// > Vector3* outPosition
        /// > float* outHeading
        /// > Any* unknown1
        /// > int unknown2
        /// > float unknown3
        /// > float unknown4
        ///
        /// </summary>
        GET_NTH_CLOSEST_VEHICLE_NODE_WITH_HEADING = 0x80CA6A8B6C094CC4,
        /// <summary>
        /// See gtaforums.com/topic/843561-pathfind-node-types for node type info. 0 = paved road only, 1 = any road, 3 = water
        /// 
        /// p10 always equals 3.0
        /// p11 always equals 0
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float desiredX
        /// > float desiredY
        /// > float desiredZ
        /// > int nthClosest
        /// > Vector3* outPosition
        /// > float* outHeading
        /// > int nodetype
        /// > float p10
        /// > Any p11
        ///
        /// </summary>
        GET_NTH_CLOSEST_VEHICLE_NODE_FAVOUR_DIRECTION = 0x45905BE8654AE067,
        /// <summary>
        /// MulleDK19: Gets the density and flags of the closest node to the specified position.
        /// Density is a value between 0 and 15, indicating how busy the road is.
        /// Flags is a bit field.
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > int* density
        /// > int* flags
        ///
        /// </summary>
        GET_VEHICLE_NODE_PROPERTIES = 0x0568566ACBB5DEDC,
        /// <summary>
        /// Returns true if the id is non zero.
        ///
        /// > int vehicleNodeId
        ///
        /// </summary>
        IS_VEHICLE_NODE_ID_VALID = 0x1EAF30FCFBF5AF74,
        /// <summary>
        /// Calling this with an invalid node id, will crash the game.
        /// Note that IS_VEHICLE_NODE_ID_VALID simply checks if nodeId is not zero. It does not actually ensure that the id is valid.
        /// Eg. IS_VEHICLE_NODE_ID_VALID(1) will return true, but will crash when calling GET_VEHICLE_NODE_POSITION().
        ///
        /// > int nodeId
        /// > Vector3* outPosition
        ///
        /// </summary>
        GET_VEHICLE_NODE_POSITION = 0x703123E5E7D429C2,
        /// <summary>
        /// Returns false for nodes that aren't used for GPS routes.
        /// Example:
        /// Nodes in Fort Zancudo and LSIA are false
        ///
        /// > int nodeID
        ///
        /// </summary>
        GET_VEHICLE_NODE_IS_GPS_ALLOWED = 0xA2AE5C478B96E3B6,
        /// <summary>
        /// Returns true when the node is Offroad. Alleys, some dirt roads, and carparks return true.
        /// Normal roads where plenty of Peds spawn will return false
        ///
        /// > int nodeID
        ///
        /// </summary>
        GET_VEHICLE_NODE_IS_SWITCHED_OFF = 0x4F5070AA58F69279,
        /// <summary>
        /// p1 seems to be always 1.0f in the scripts
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float p3
        /// > int p4
        /// > Vector3* p5
        /// > Vector3* p6
        /// > Any* p7
        /// > Any* p8
        /// > float* p9
        /// > BOOL p10
        ///
        /// </summary>
        GET_CLOSEST_ROAD = 0x132F52BBA570FE92,
        /// <summary>
        /// Toggles a global boolean, name is probably a hash collision but describes its functionality.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_ALL_PATHS_CACHE_BOUNDINGSTRUCT = 0x228E5C6AD4D74BFD,
        /// <summary>
        /// Activates Cayo Perico path nodes if passed `1`. GPS navigation will start working, maybe more stuff will change, not sure. It seems if you try to unload (pass `0`) when close to the island, your game might crash.
        ///
        /// > int type
        ///
        /// </summary>
        _SET_AI_GLOBAL_PATH_NODES_TYPE = 0xF74B1FFA4A15FBEA,
        /// <summary>
        /// ARE_*
        ///
        /// > float x1
        /// > float y1
        /// > float x2
        /// > float y2
        ///
        /// </summary>
        ARE_NODES_LOADED_FOR_AREA = 0xF7B79A50B905A30D,
        /// <summary>
        /// Used internally for long range tasks
        ///
        /// > float x1
        /// > float y1
        /// > float x2
        /// > float y2
        ///
        /// </summary>
        _REQUEST_PATHS_PREFER_ACCURATE_BOUNDINGSTRUCT = 0x07FB139B592FA687,
        /// <summary>
        /// missing a last parameter int p6 
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
        SET_ROADS_BACK_TO_ORIGINAL = 0x1EE7063B80FFC77C,
        /// <summary>
        /// See IS_POINT_IN_ANGLED_AREA for the definition of an angled area.
        /// bool p7 - always 1
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > float width
        /// > Any p7
        ///
        /// </summary>
        SET_ROADS_BACK_TO_ORIGINAL_IN_ANGLED_AREA = 0x0027501B9F3B407E,
        /// <summary>
        /// Determines the name of the street which is the closest to the given coordinates.
        /// 
        /// x,y,z - the coordinates of the street
        /// streetName - returns a hash to the name of the street the coords are on
        /// crossingRoad - if the coordinates are on an intersection, a hash to the name of the crossing road
        /// 
        /// Note: the names are returned as hashes, the strings can be returned using the function HUD::GET_STREET_NAME_FROM_HASH_KEY.
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > Hash* streetName
        /// > Hash* crossingRoad
        ///
        /// </summary>
        GET_STREET_NAME_AT_COORD = 0x2EB41072B4C1E4C0,
        /// <summary>
        /// p3 is 0 in the only game script occurrence (trevor3) but 1 doesn't seem to make a difference
        /// 
        /// distToNxJunction seems to be the distance in metres * 10.0f
        /// 
        /// direction:
        /// 0 = This happens randomly during the drive for seemingly no reason but if you consider that this native is only used in trevor3, it seems to mean "Next frame, stop whatever's being said and tell the player the direction."
        /// 1 = Route is being calculated or the player is going in the wrong direction
        /// 2 = Please Proceed the Highlighted Route
        /// 3 = In (distToNxJunction) Turn Left
        /// 4 = In (distToNxJunction) Turn Right
        /// 5 = In (distToNxJunction) Keep Straight
        /// 6 = In (distToNxJunction) Turn Sharply To The Left
        /// 7 = In (distToNxJunction) Turn Sharply To The Right
        /// 8 = Route is being recalculated or the navmesh is confusing. This happens randomly during the drive but consistently at {2044.0358, 2996.6116, 44.9717} if you face towards the bar and the route needs you to turn right. In that particular case, it could be a bug with how the turn appears to be 270 deg. CCW instead of "right." Either way, this seems to be the engine saying "I don't know the route right now."
        /// 
        /// return value set to 0 always
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > BOOL p3
        /// > int* direction
        /// > float* p5
        /// > float* distToNxJunction
        ///
        /// </summary>
        GENERATE_DIRECTIONS_TO_COORD = 0xF90125F1F79ECDF8,
        /// <summary>
        /// See: SET_BLIP_ROUTE
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_IGNORE_SECONDARY_ROUTE_NODES = 0x1FC289A0C3FF470F,
        /// <summary>
        /// Gets a value indicating whether the specified position is on a road.
        /// The vehicle parameter is not implemented (ignored).
        /// 
        /// -MulleDK19
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > Vehicle vehicle
        ///
        /// </summary>
        IS_POINT_ON_ROAD = 0x125BF4ABFC536B09,
        /// <summary>
        /// Gets the next zone that has been disabled using SET_GPS_DISABLED_ZONE_AT_INDEX.
        ///
        ///
        /// </summary>
        GET_NEXT_GPS_DISABLED_ZONE_INDEX = 0xD3A6A0EF48823A8C,
        /// <summary>
        /// Disables the GPS route displayed on the minimap while within a certain zone (area). When in a disabled zone and creating a waypoint, the GPS route is not shown on the minimap until you are outside of the zone. When disabled, the direct distance is shown on minimap opposed to distance to travel. Seems to only work before setting a waypoint.
        /// You can clear the disabled zone with CLEAR_GPS_DISABLED_ZONE_AT_INDEX.
        /// 
        /// **Setting a waypoint at the same coordinate:**
        /// Disabled Zone: https://i.imgur.com/P9VUuxM.png
        /// Enabled Zone (normal): https://i.imgur.com/BPi24aw.png
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > int index
        ///
        /// </summary>
        SET_GPS_DISABLED_ZONE_AT_INDEX = 0xD0BC1C6FB18EE154,
        /// <summary>
        /// Clears a disabled GPS route area from a certain index previously set using `SET_GPS_DISABLED_ZONE_AT_INDEX`.
        ///
        /// > int index
        ///
        /// </summary>
        CLEAR_GPS_DISABLED_ZONE_AT_INDEX = 0x2801D0012266DF07,
        /// <summary>
        /// IS_*
        ///
        ///
        /// </summary>
        _IS_NAVMESH_REQUIRED_REGION_OWNED_BY_ANY_THREAD = 0x705A844002B39DC0,
        /// <summary>
        /// Returns whether navmesh for the region is loaded. The region is a rectangular prism defined by it's top left deepest corner to it's bottom right shallowest corner.
        /// 
        /// If you can re-word this so it makes more sense, please do. I'm horrible with words sometimes...
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        ///
        /// </summary>
        IS_NAVMESH_LOADED_IN_AREA = 0xF813C7E63F9062A5,
        /// <summary>
        /// Returns CGameWorldHeightMap's maximum Z value at specified point (grid node).
        ///
        /// > float x
        /// > float y
        ///
        /// </summary>
        _GET_HEIGHTMAP_TOP_Z_FOR_POSITION = 0x29C24BFBED8AB8FB,
        /// <summary>
        /// Returns CGameWorldHeightMap's maximum Z among all grid nodes that intersect with the specified rectangle.
        ///
        /// > float x1
        /// > float y1
        /// > float x2
        /// > float y2
        ///
        /// </summary>
        _GET_HEIGHTMAP_TOP_Z_FOR_AREA = 0x8ABE8608576D9CE3,
        /// <summary>
        /// Returns CGameWorldHeightMap's minimum Z value at specified point (grid node).
        ///
        /// > float x
        /// > float y
        ///
        /// </summary>
        _GET_HEIGHTMAP_BOTTOM_Z_FOR_POSITION = 0x336511A34F2E5185,
        /// <summary>
        /// Returns CGameWorldHeightMap's minimum Z among all grid nodes that intersect with the specified rectangle.
        ///
        /// > float x1
        /// > float y1
        /// > float x2
        /// > float y2
        ///
        /// </summary>
        _GET_HEIGHTMAP_BOTTOM_Z_FOR_AREA = 0x3599D741C9AC6310,
        /// <summary>
        /// Calculates the travel distance between a set of points.
        /// 
        /// Doesn't seem to correlate with distance on gps sometimes.
        /// This function returns the value 100000.0 over long distances, seems to be a failure mode result, potentially occurring when not all path nodes are loaded into pathfind.
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        ///
        /// </summary>
        CALCULATE_TRAVEL_DISTANCE_BETWEEN_POINTS = 0xADD95C7005C4A197,
        SET_PED_PATHS_IN_AREA = 0x34F060F4BF92E018,
        GET_NTH_CLOSEST_VEHICLE_NODE = 0xE50E52416CCF948B,
        GET_NTH_CLOSEST_VEHICLE_NODE_ID_WITH_HEADING = 0x6448050E9C2A7207,
        SET_AMBIENT_PED_RANGE_MULTIPLIER_THIS_FRAME = 0x0B919E1FB47CC4E0,
        SET_PED_PATHS_BACK_TO_ORIGINAL = 0xE04B48F2CC926253,
        GET_RANDOM_VEHICLE_NODE = 0x93E0DB8440B73A7D,
        SET_IGNORE_NO_GPS_FLAG = 0x72751156E7678833,
        SET_GPS_DISABLED_ZONE = 0xDC20483CD3DD5201,
        GET_GPS_BLIP_ROUTE_LENGTH = 0xBBB45C3CF5C8AA85,
        GET_GPS_BLIP_ROUTE_FOUND = 0x869DAACBBE9FA006,
        _GET_ROAD_SIDE_POINT_WITH_HEADING = 0xA0F8A7517A273C05,
        _GET_POINT_ON_ROAD_SIDE = 0x16F46FB18C8009E4,
        ADD_NAVMESH_REQUIRED_REGION = 0x387EAD7EE42F6685,
        REMOVE_NAVMESH_REQUIRED_REGIONS = 0x916F0A3CDEC3445E,
        DISABLE_NAVMESH_IN_AREA = 0x4C8872D8CDBE1B8B,
        ARE_ALL_NAVMESH_REGIONS_LOADED = 0x8415D95B194A3AEA,
        ADD_NAVMESH_BLOCKING_OBJECT = 0xFCD5C8E06E502F5A,
        UPDATE_NAVMESH_BLOCKING_OBJECT = 0x109E99373F290687,
        REMOVE_NAVMESH_BLOCKING_OBJECT = 0x46399A7895957C0E,
        DOES_NAVMESH_BLOCKING_OBJECT_EXIST = 0x0EAEB0DB4B132399,
        _0xAA76052DDA9BFC3E = 0xAA76052DDA9BFC3E,
        _0xF3162836C28F9DA5 = 0xF3162836C28F9DA5,
        _0x01708E8DD3FF8C65 = 0x01708E8DD3FF8C65,
    }
}