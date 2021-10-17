using System;
namespace Hotstar
{
    public enum SHAPETEST : ulong
    { 
        /// <summary>
        /// Asynchronously starts a line-of-sight (raycast) world probe shape test.
        /// 
        /// Use the handle with 0x3D87450E15D98694 or 0x65287525D951F6BE until it returns 0 or 2.
        /// 
        /// p8 is a bit mask with bits 1, 2 and/or 4, relating to collider types; 4 should usually be used.
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > int flags
        /// > Entity entity
        /// > int p8
        ///
        /// </summary>
        START_SHAPE_TEST_LOS_PROBE = 0x7EE9F5D83DD4F90E,
        /// <summary>
        /// Does the same as 0x7EE9F5D83DD4F90E, except blocking until the shape test completes.
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > int flags
        /// > Entity entity
        /// > int p8
        ///
        /// </summary>
        START_EXPENSIVE_SYNCHRONOUS_SHAPE_TEST_LOS_PROBE = 0x377906D8A31E5586,
        /// <summary>
        /// Raycast from point to point, where the ray has a radius. 
        /// 
        /// flags:
        /// vehicles=10
        /// peds =12
        /// 
        /// Iterating through flags yields many ped / vehicle/ object combinations
        /// 
        /// p9 = 7, but no idea what it does
        /// 
        /// Entity is an entity to ignore
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > float radius
        /// > int flags
        /// > Entity entity
        /// > int p9
        ///
        /// </summary>
        START_SHAPE_TEST_CAPSULE = 0x28579D1B8F8AAC80,
        /// <summary>
        /// Actual name starts with START_SHAPE_TEST_??? and it returns a ShapeTest handle that can be used with GET_SHAPE_TEST_RESULT.
        /// 
        /// In its only usage in game scripts its called with flag set to 511, entity to player_ped_id and flag2 set to 7
        ///
        /// > Vector3* pVec1
        /// > Vector3* pVec2
        /// > int flag
        /// > Entity entity
        /// > int flag2
        ///
        /// </summary>
        _START_SHAPE_TEST_SURROUNDING_COORDS = 0xFF6BE494C7987F34,
        /// <summary>
        /// Returns the result of a shape test: 0 if the handle is invalid, 1 if the shape test is still pending, or 2 if the shape test has completed, and the handle should be invalidated.
        /// 
        /// When used with an asynchronous shape test, this native should be looped until returning 0 or 2, after which the handle is invalidated.
        ///
        /// > int shapeTestHandle
        /// > BOOL* hit
        /// > Vector3* endCoords
        /// > Vector3* surfaceNormal
        /// > Entity* entityHit
        ///
        /// </summary>
        GET_SHAPE_TEST_RESULT = 0x3D87450E15D98694,
        /// <summary>
        /// Returns the result of a shape test, also returning the material of any touched surface.
        /// 
        /// When used with an asynchronous shape test, this native should be looped until returning 0 or 2, after which the handle is invalidated.
        /// 
        /// Unless the return value is 2, the other return values are undefined.
        ///
        /// > int shapeTestHandle
        /// > BOOL* hit
        /// > Vector3* endCoords
        /// > Vector3* surfaceNormal
        /// > Hash* materialHash
        /// > Entity* entityHit
        ///
        /// </summary>
        GET_SHAPE_TEST_RESULT_INCLUDING_MATERIAL = 0x65287525D951F6BE,
        /// <summary>
        /// Invalidates the entity handle passed by removing the fwScriptGuid from the entity. This should be used when receiving an ambient entity from shape testing natives, but can also be used for other natives returning an 'irrelevant' entity handle.
        ///
        /// > Entity entityHit
        ///
        /// </summary>
        RELEASE_SCRIPT_GUID_FROM_ENTITY = 0x2B3334BCA57CD799,
        START_SHAPE_TEST_BOUNDING_BOX = 0x052837721A854EC7,
        START_SHAPE_TEST_BOX = 0xFE466162C4401D18,
        START_SHAPE_TEST_BOUND = 0x37181417CE7C8900,
        START_SHAPE_TEST_SWEPT_SPHERE = 0xE6AC6C45FBE83004,
    }
}