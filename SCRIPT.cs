using System;
namespace Hotstar
{
    public enum SCRIPT : ulong
    { 
        /// <summary>
        /// Returns if a script has been loaded into the game. Used to see if a script was loaded after requesting.
        ///
        /// > const char* scriptName
        ///
        /// </summary>
        HAS_SCRIPT_LOADED = 0xE6CC9F3BA0FB9EF1,
        /// <summary>
        /// formerly _REQUEST_STREAMED_SCRIPT
        ///
        /// > Hash scriptHash
        ///
        /// </summary>
        REQUEST_SCRIPT_WITH_NAME_HASH = 0xD62A67D26D9653E6,
        /// <summary>
        /// Starts a new iteration of the current threads.
        /// Call this first, then SCRIPT_THREAD_ITERATOR_GET_NEXT_THREAD_ID (0x30B4FA1C82DD4B9F)
        ///
        ///
        /// </summary>
        SCRIPT_THREAD_ITERATOR_RESET = 0xDADFADA5A20143A8,
        /// <summary>
        /// If the function returns 0, the end of the iteration has been reached.
        ///
        ///
        /// </summary>
        SCRIPT_THREAD_ITERATOR_GET_NEXT_THREAD_ID = 0x30B4FA1C82DD4B9F,
        /// <summary>
        /// Gets the number of instances of the specified script is currently running.
        /// 
        /// Actually returns numRefs - 1.
        /// if (program)
        /// 	v3 = rage::scrProgram::GetNumRefs(program) - 1;
        /// return v3;
        ///
        /// > Hash scriptHash
        ///
        /// </summary>
        _GET_NUMBER_OF_REFERENCES_OF_SCRIPT_WITH_NAME_HASH = 0x2C83A9DA6BFFC4F9,
        /// <summary>
        /// eventGroup: 0 = SCRIPT_EVENT_QUEUE_AI (CEventGroupScriptAI), 1 = SCRIPT_EVENT_QUEUE_NETWORK (CEventGroupScriptNetwork)
        ///
        /// > int eventGroup
        ///
        /// </summary>
        GET_NUMBER_OF_EVENTS = 0x5F92A689A06620AA,
        /// <summary>
        /// eventGroup: 0 = SCRIPT_EVENT_QUEUE_AI (CEventGroupScriptAI), 1 = SCRIPT_EVENT_QUEUE_NETWORK (CEventGroupScriptNetwork)
        ///
        /// > int eventGroup
        /// > int eventIndex
        ///
        /// </summary>
        GET_EVENT_EXISTS = 0x936E6168A9BCEDB5,
        /// <summary>
        /// eventGroup: 0 = SCRIPT_EVENT_QUEUE_AI (CEventGroupScriptAI), 1 = SCRIPT_EVENT_QUEUE_NETWORK (CEventGroupScriptNetwork)
        ///
        /// > int eventGroup
        /// > int eventIndex
        ///
        /// </summary>
        GET_EVENT_AT_INDEX = 0xD8F66A3A60C62153,
        /// <summary>
        /// eventGroup: 0 = SCRIPT_EVENT_QUEUE_AI (CEventGroupScriptAI), 1 = SCRIPT_EVENT_QUEUE_NETWORK (CEventGroupScriptNetwork)
        /// 
        /// Note: eventDataSize is NOT the size in bytes, it is the size determined by the SIZE_OF operator (RAGE Script operator, not C/C++ sizeof). That is, the size in bytes divided by 8 (script variables are always 8-byte aligned!).
        ///
        /// > int eventGroup
        /// > int eventIndex
        /// > Any* eventData
        /// > int eventDataSize
        ///
        /// </summary>
        GET_EVENT_DATA = 0x2902843FCD2B2D79,
        /// <summary>
        /// eventGroup: 0 = SCRIPT_EVENT_QUEUE_AI (CEventGroupScriptAI), 1 = SCRIPT_EVENT_QUEUE_NETWORK (CEventGroupScriptNetwork)
        /// 
        /// Note: eventDataSize is NOT the size in bytes, it is the size determined by the SIZE_OF operator (RAGE Script operator, not C/C++ sizeof). That is, the size in bytes divided by 8 (script variables are always 8-byte aligned!).
        /// 
        /// playerBits (also known as playersToBroadcastTo) is a bitset that indicates which players this event should be sent to. In order to send the event to specific players only, use (1 << playerIndex). Set all bits if it should be broadcast to all players.
        ///
        /// > int eventGroup
        /// > Any* eventData
        /// > int eventDataSize
        /// > int playerBits
        ///
        /// </summary>
        TRIGGER_SCRIPT_EVENT = 0x5AE99C571D5BBE5D,
        /// <summary>
        /// Hashed version of 0x9D5A25BADB742ACD.
        ///
        /// > Hash contextHash
        ///
        /// </summary>
        BG_START_CONTEXT_HASH = 0x75B18E49607874C7,
        /// <summary>
        /// Hashed version of 0xDC2BACD920D0A0DD.
        ///
        /// > Hash contextHash
        ///
        /// </summary>
        BG_END_CONTEXT_HASH = 0x107E5CC7CA942BC1,
        /// <summary>
        /// Inserts the given context into the background scripts context map.
        ///
        /// > const char* contextName
        ///
        /// </summary>
        BG_START_CONTEXT = 0x9D5A25BADB742ACD,
        /// <summary>
        /// Deletes the given context from the background scripts context map.
        ///
        /// > const char* contextName
        ///
        /// </summary>
        BG_END_CONTEXT = 0xDC2BACD920D0A0DD,
        /// <summary>
        /// See TRIGGER_SCRIPT_EVENT
        ///
        /// > int eventGroup
        /// > Any* eventData
        /// > int eventDataSize
        /// > int playerBits
        ///
        /// </summary>
        _TRIGGER_SCRIPT_EVENT_2 = 0xA40CC53DF8E50837,
        /// <summary>
        /// Returns true if bit 0 in GtaThread+0x154 is set.
        /// 
        /// BG_*
        ///
        ///
        /// </summary>
        _0x836B62713E0534CA = 0x836B62713E0534CA,
        /// <summary>
        /// Sets bit 1 in GtaThread+0x154
        /// 
        /// BG_*
        ///
        ///
        /// </summary>
        _0x760910B49D2B98EA = 0x760910B49D2B98EA,
        /// <summary>
        /// BG_*
        ///
        /// > int scriptIndex
        /// > const char* p1
        ///
        /// </summary>
        _0x0F6F1EBBC4E1D5E6 = 0x0F6F1EBBC4E1D5E6,
        /// <summary>
        /// BG_*
        ///
        /// > int scriptIndex
        /// > const char* p1
        ///
        /// </summary>
        _0x22E21FBCFC88C149 = 0x22E21FBCFC88C149,
        /// <summary>
        /// BG_*
        ///
        /// > Hash p0
        ///
        /// </summary>
        _0x829CD22E043A2577 = 0x829CD22E043A2577,
        REQUEST_SCRIPT = 0x6EB5F71AA68F2E8E,
        SET_SCRIPT_AS_NO_LONGER_NEEDED = 0xC90D2DCACD56184C,
        DOES_SCRIPT_EXIST = 0xFC04745FBE67C19A,
        SET_SCRIPT_WITH_NAME_HASH_AS_NO_LONGER_NEEDED = 0xC5BC038960E9DB27,
        HAS_SCRIPT_WITH_NAME_HASH_LOADED = 0x5F0F0C783EB16C04,
        DOES_SCRIPT_WITH_NAME_HASH_EXIST = 0xF86AA3C56BA31381,
        TERMINATE_THREAD = 0xC8B189ED9138BCD4,
        IS_THREAD_ACTIVE = 0x46E9AE36D8FA6417,
        _GET_NAME_OF_THREAD = 0x05A42BA9FC8DA96B,
        GET_ID_OF_THIS_THREAD = 0xC30338E8088E2E21,
        TERMINATE_THIS_THREAD = 0x1090044AD1DA76FA,
        GET_THIS_SCRIPT_NAME = 0x442E0A7EDE4A738A,
        GET_HASH_OF_THIS_SCRIPT_NAME = 0x8A1C8B1738FFE87E,
        SHUTDOWN_LOADING_SCREEN = 0x078EBE9809CCD637,
        SET_NO_LOADING_SCREEN = 0x5262CC1995D07E09,
        GET_NO_LOADING_SCREEN = 0x18C1270EA7F199BC,
        _0xB1577667C3708F9B = 0xB1577667C3708F9B,
    }
}