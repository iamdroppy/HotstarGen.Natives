using System;
namespace Hotstar
{
    public enum FIRE : ulong
    { 
        /// <summary>
        /// Starts a fire:
        /// 
        /// xyz: Location of fire
        /// maxChildren: The max amount of times a fire can spread to other objects. Must be 25 or less, or the function will do nothing.
        /// isGasFire: Whether or not the fire is powered by gasoline.
        ///
        /// > float X
        /// > float Y
        /// > float Z
        /// > int maxChildren
        /// > BOOL isGasFire
        ///
        /// </summary>
        START_SCRIPT_FIRE = 0x6B83617E04503888,
        /// <summary>
        /// SET_FIRE_*
        ///
        /// > float p0
        ///
        /// </summary>
        _SET_FIRE_SPREAD_RATE = 0x8F390AC4155099BA,
        /// <summary>
        /// Returns TRUE if it found something. FALSE if not.
        ///
        /// > Vector3* outPosition
        /// > float x
        /// > float y
        /// > float z
        ///
        /// </summary>
        GET_CLOSEST_FIRE_POS = 0x352A9F6BCF90081F,
        /// <summary>
        /// BOOL isAudible = If explosion makes a sound.
        /// BOOL isInvisible = If the explosion is invisible or not.
        /// 
        /// explosionType: https://alloc8or.re/gta5/doc/enums/eExplosionTag.txt
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > int explosionType
        /// > float damageScale
        /// > BOOL isAudible
        /// > BOOL isInvisible
        /// > float cameraShake
        /// > BOOL noDamage
        ///
        /// </summary>
        ADD_EXPLOSION = 0xE3AD2BDBAEE269AC,
        /// <summary>
        /// isAudible: If explosion makes a sound.
        /// isInvisible: If the explosion is invisible or not.
        /// explosionType: See ADD_EXPLOSION.
        ///
        /// > Ped ped
        /// > float x
        /// > float y
        /// > float z
        /// > int explosionType
        /// > float damageScale
        /// > BOOL isAudible
        /// > BOOL isInvisible
        /// > float cameraShake
        ///
        /// </summary>
        ADD_OWNED_EXPLOSION = 0x172AA1B624FA1013,
        /// <summary>
        /// isAudible: If explosion makes a sound.
        /// isInvisible: If the explosion is invisible or not.
        /// explosionType: See ADD_EXPLOSION.
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > int explosionType
        /// > Hash explosionFx
        /// > float damageScale
        /// > BOOL isAudible
        /// > BOOL isInvisible
        /// > float cameraShake
        ///
        /// </summary>
        ADD_EXPLOSION_WITH_USER_VFX = 0x36DD3FE58B5E5212,
        /// <summary>
        /// explosionType: See ADD_EXPLOSION.
        ///
        /// > int explosionType
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        ///
        /// </summary>
        IS_EXPLOSION_IN_AREA = 0x2E2EBA0EE7CED0E0,
        /// <summary>
        /// explosionType: See ADD_EXPLOSION.
        ///
        /// > int explosionType
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        ///
        /// </summary>
        IS_EXPLOSION_ACTIVE_IN_AREA = 0x6070104B699B2EF4,
        /// <summary>
        /// explosionType: See ADD_EXPLOSION.
        ///
        /// > int explosionType
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        ///
        /// </summary>
        IS_EXPLOSION_IN_SPHERE = 0xAB0F816885B0E483,
        /// <summary>
        /// explosionType: See ADD_EXPLOSION.
        ///
        /// > int explosionType
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        ///
        /// </summary>
        _GET_ENTITY_INSIDE_EXPLOSION_SPHERE = 0xB3CD51E3DB86F176,
        /// <summary>
        /// explosionType: See ADD_EXPLOSION, -1 for any explosion type
        /// 
        ///
        /// > int explosionType
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > float width
        ///
        /// </summary>
        IS_EXPLOSION_IN_ANGLED_AREA = 0xA079A6C51525DC4B,
        /// <summary>
        /// Returns a handle to the first entity within the a circle spawned inside the 2 points from a radius.
        /// 
        /// explosionType: See ADD_EXPLOSION.
        ///
        /// > int explosionType
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > float radius
        ///
        /// </summary>
        _GET_ENTITY_INSIDE_EXPLOSION_AREA = 0x14BA4BA137AF6CEC,
        REMOVE_SCRIPT_FIRE = 0x7FF548385680673F,
        START_ENTITY_FIRE = 0xF6A9D9708F6F23DF,
        STOP_ENTITY_FIRE = 0x7F0DD2EBBB651AFF,
        IS_ENTITY_ON_FIRE = 0x28D3FED7190D3A0B,
        GET_NUMBER_OF_FIRES_IN_RANGE = 0x50CAD495A460B305,
        STOP_FIRE_IN_RANGE = 0x056A8A219B8E829F,
    }
}