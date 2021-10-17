using System;
namespace Hotstar
{
    public enum EVENT : ulong
    { 
        /// <summary>
        /// eventType: https://alloc8or.re/gta5/doc/enums/eEventType.txt
        ///
        /// > Hash name
        /// > int eventType
        ///
        /// </summary>
        CLEAR_DECISION_MAKER_EVENT_RESPONSE = 0x4FC9381A7AEE8968,
        /// <summary>
        /// eventType: https://alloc8or.re/gta5/doc/enums/eEventType.txt
        /// 
        /// This is limited to 4 blocked events at a time.
        ///
        /// > Hash name
        /// > int eventType
        ///
        /// </summary>
        BLOCK_DECISION_MAKER_EVENT = 0xE42FCDFD0E4196F7,
        /// <summary>
        /// eventType: https://alloc8or.re/gta5/doc/enums/eEventType.txt
        ///
        /// > Hash name
        /// > int eventType
        ///
        /// </summary>
        UNBLOCK_DECISION_MAKER_EVENT = 0xD7CD9CF34F2C99E8,
        /// <summary>
        /// eventType: https://alloc8or.re/gta5/doc/enums/eEventType.txt
        ///
        /// > int eventType
        /// > float x
        /// > float y
        /// > float z
        /// > float duration
        ///
        /// </summary>
        ADD_SHOCKING_EVENT_AT_POSITION = 0xD9F8455409B525E9,
        /// <summary>
        /// eventType: https://alloc8or.re/gta5/doc/enums/eEventType.txt
        ///
        /// > int eventType
        /// > Entity entity
        /// > float duration
        ///
        /// </summary>
        ADD_SHOCKING_EVENT_FOR_ENTITY = 0x7FD8F3BE76F89422,
        /// <summary>
        /// eventType: https://alloc8or.re/gta5/doc/enums/eEventType.txt
        ///
        /// > int eventType
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        ///
        /// </summary>
        IS_SHOCKING_EVENT_IN_SPHERE = 0x1374ABB7C15BAB92,
        /// <summary>
        /// eventType: https://alloc8or.re/gta5/doc/enums/eEventType.txt
        ///
        /// > int eventType
        ///
        /// </summary>
        SUPPRESS_SHOCKING_EVENT_TYPE_NEXT_FRAME = 0x3FD2EC8BF1F1CF30,
        SET_DECISION_MAKER = 0xB604A2942ADED0EE,
        REMOVE_SHOCKING_EVENT = 0x2CDA538C44C6CCE5,
        REMOVE_ALL_SHOCKING_EVENTS = 0xEAABE8FDFA21274C,
        REMOVE_SHOCKING_EVENT_SPAWN_BLOCKING_AREAS = 0x340F1415B68AEADE,
        SUPPRESS_SHOCKING_EVENTS_NEXT_FRAME = 0x2F9A292AD0A3BD89,
        SUPPRESS_AGITATION_EVENTS_NEXT_FRAME = 0x5F3B7749C112D552,
    }
}