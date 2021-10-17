using System;
namespace Hotstar
{
    public enum PHYSICS : ulong
    { 
        /// <summary>
        /// Creates a rope at the specific position, that extends in the specified direction when not attached to any entities.
        /// __
        /// 
        /// Add_Rope(pos.x,pos.y,pos.z,0.0,0.0,0.0,20.0,4,20.0,1.0,0.0,false,false,false,5.0,false,NULL)
        /// 
        /// When attached, Position<vector> does not matter
        /// When attached, Angle<vector> does not matter
        /// 
        /// Rope Type:
        /// 4 and bellow is a thick rope
        /// 5 and up are small metal wires
        /// 0 crashes the game
        /// 
        /// Max_length - Rope is forced to this length, generally best to keep this the same as your rope length.
        /// 
        /// windingSpeed - Speed the Rope is being winded, using native START_ROPE_WINDING. Set positive for winding and negative for unwinding.
        /// 
        /// Rigid - If max length is zero, and this is set to false the rope will become rigid (it will force a specific distance, what ever length is, between the objects).
        /// 
        /// breakable - Whether or not shooting the rope will break it.
        /// 
        /// unkPtr - unknown ptr, always 0 in orig scripts
        /// __
        /// 
        /// Lengths can be calculated like so:
        /// 
        /// float distance = abs(x1 - x2) + abs(y1 - y2) + abs(z1 - z2); // Rope length
        /// 
        /// 
        /// NOTES:
        /// 
        /// Rope does NOT interact with anything you attach it to, in some cases it make interact with the world AFTER it breaks (seems to occur if you set the type to -1).
        /// 
        /// Rope will sometimes contract and fall to the ground like you'd expect it to, but since it doesn't interact with the world the effect is just jaring.
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float rotX
        /// > float rotY
        /// > float rotZ
        /// > float length
        /// > int ropeType
        /// > float maxLength
        /// > float minLength
        /// > float windingSpeed
        /// > BOOL p11
        /// > BOOL p12
        /// > BOOL rigid
        /// > float p14
        /// > BOOL breakWhenShot
        /// > Any* unkPtr
        ///
        /// </summary>
        ADD_ROPE = 0xE832D760399EB220,
        /// <summary>
        /// Rope presets can be found in the gamefiles. One example is "ropeFamily3", it is NOT a hash but rather a string.
        ///
        /// > int ropeId
        /// > const char* rope_preset
        ///
        /// </summary>
        LOAD_ROPE_DATA = 0xCBB203C04D1ABD27,
        /// <summary>
        /// Attaches entity 1 to entity 2.
        ///
        /// > int ropeId
        /// > Entity ent1
        /// > Entity ent2
        /// > float ent1_x
        /// > float ent1_y
        /// > float ent1_z
        /// > float ent2_x
        /// > float ent2_y
        /// > float ent2_z
        /// > float length
        /// > BOOL p10
        /// > BOOL p11
        /// > Any* p12
        /// > Any* p13
        ///
        /// </summary>
        ATTACH_ENTITIES_TO_ROPE = 0x3D95EC8B6D940AC3,
        /// <summary>
        /// The position supplied can be anywhere, and the entity should anchor relative to that point from it's origin.
        ///
        /// > int ropeId
        /// > Entity entity
        /// > float x
        /// > float y
        /// > float z
        /// > BOOL p5
        ///
        /// </summary>
        ATTACH_ROPE_TO_ENTITY = 0x4B490A6832559A65,
        /// <summary>
        /// Loads rope textures for all ropes in the current scene.
        ///
        ///
        /// </summary>
        ROPE_LOAD_TEXTURES = 0x9B9039DBF2D258C1,
        /// <summary>
        /// Unloads rope textures for all ropes in the current scene.
        ///
        ///
        /// </summary>
        ROPE_UNLOAD_TEXTURES = 0x6CE36C35C1AC8163,
        /// <summary>
        /// Forces a rope to a certain length.
        ///
        /// > int ropeId
        /// > float length
        ///
        /// </summary>
        ROPE_FORCE_LENGTH = 0xD009F759A723DB1B,
        /// <summary>
        /// Reset a rope to a certain length.
        ///
        /// > int ropeId
        /// > float length
        ///
        /// </summary>
        ROPE_RESET_LENGTH = 0xC16DE94D9BEA14A0,
        /// <summary>
        /// GET_*
        ///
        /// > Object object
        ///
        /// </summary>
        _GET_HAS_OBJECT_FRAG_INST = 0x0C112765300C7E1E,
        /// <summary>
        /// Related to the lower-end of a vehicles fTractionCurve, e.g., from standing starts and acceleration from low/zero speeds.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_LAUNCH_CONTROL_ENABLED = 0xAA6A6098851C396F,
        /// <summary>
        /// ROPE_*
        ///
        /// > int* ropeId
        /// > BOOL p1
        ///
        /// </summary>
        _0xA1AE736541B0FCA3 = 0xA1AE736541B0FCA3,
        /// <summary>
        /// ROPE_*
        ///
        /// > int ropeId
        /// > BOOL p1
        ///
        /// </summary>
        _0x36CCB9BE67B970FD = 0x36CCB9BE67B970FD,
        /// <summary>
        /// IS_*
        ///
        /// > int* ropeId
        ///
        /// </summary>
        _0x84DE3B5FB3E666F0 = 0x84DE3B5FB3E666F0,
        /// <summary>
        /// Most likely ROPE_ATTACH_*
        ///
        /// > int ropeId
        /// > int p1
        /// > float p2
        /// > float p3
        /// > float p4
        /// > float p5
        /// > float p6
        /// > float p7
        /// > float p8
        /// > float p9
        /// > float p10
        /// > float p11
        /// > float p12
        /// > float p13
        ///
        /// </summary>
        _0xBC0CE682D4D05650 = 0xBC0CE682D4D05650,
        /// <summary>
        /// ROPE_*
        ///
        /// > int ropeId
        /// > int p1
        ///
        /// </summary>
        _0xB743F735C03D7810 = 0xB743F735C03D7810,
        /// <summary>
        /// RESET_*
        ///
        /// > Object object
        ///
        /// </summary>
        _0xCC6E963682533882 = 0xCC6E963682533882,
        /// <summary>
        /// SET_*
        ///
        /// > BOOL p0
        ///
        /// </summary>
        _0x9EBD751E5787BAF2 = 0x9EBD751E5787BAF2,
        DELETE_ROPE = 0x52B4829281364649,
        DELETE_CHILD_ROPE = 0xAA5D6B1888E4DB20,
        DOES_ROPE_EXIST = 0xFD5448BE3111ED96,
        ROPE_DRAW_SHADOW_ENABLED = 0xF159A63806BB5BA8,
        PIN_ROPE_VERTEX = 0x2B320CF14146B69A,
        UNPIN_ROPE_VERTEX = 0x4B5AE2EEE4A8F180,
        GET_ROPE_VERTEX_COUNT = 0x3655F544CD30F0B5,
        DETACH_ROPE_FROM_ENTITY = 0xBCF3026912A8647D,
        ROPE_SET_UPDATE_PINVERTS = 0xC8D667EE52114ABA,
        ROPE_SET_UPDATE_ORDER = 0xDC57A637A20006ED,
        GET_ROPE_LAST_VERTEX_COORD = 0x21BB0FBD3E217C2D,
        GET_ROPE_VERTEX_COORD = 0xEA61CA8E80F09E4D,
        START_ROPE_WINDING = 0x1461C72C889E343E,
        STOP_ROPE_WINDING = 0xCB2D4AB84A19AA7C,
        START_ROPE_UNWINDING_FRONT = 0x538D1179EC1AA9A9,
        STOP_ROPE_UNWINDING_FRONT = 0xFFF3A50779EFBBB3,
        ROPE_CONVERT_TO_SIMPLE = 0x5389D48EFA2F079A,
        ROPE_ARE_TEXTURES_LOADED = 0xF2D0E6A75CC05597,
        _DOES_ROPE_BELONG_TO_THIS_SCRIPT = 0x271C9D3ACA5D6409,
        ROPE_GET_DISTANCE_BETWEEN_ENDS = 0x73040398DFF9A4A6,
        APPLY_IMPULSE_TO_CLOTH = 0xE37F721824571784,
        SET_DAMPING = 0xEEA3B200A6FEB65B,
        ACTIVATE_PHYSICS = 0x710311ADF0E20730,
        SET_CGOFFSET = 0xD8FA3908D7B86904,
        GET_CGOFFSET = 0x8214A4B5A7A33612,
        SET_CG_AT_BOUNDCENTER = 0xBE520D9761FF811F,
        BREAK_ENTITY_GLASS = 0x2E648D16F6E308F3,
        SET_DISABLE_BREAKING = 0x5CEC1A84620E7D5B,
        SET_DISABLE_FRAG_DAMAGE = 0x01BA3AED21C16CFB,
        _SET_ENTITY_PROOF_UNK = 0x15F944730C832252,
        _0xB1B6216CA2E7B55E = 0xB1B6216CA2E7B55E,
    }
}