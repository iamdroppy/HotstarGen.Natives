using System;
namespace Hotstar
{
    public enum DECORATOR : ulong
    { 
        /// <summary>
        /// This function sets metadata of type bool to specified entity.
        /// 
        ///
        /// > Entity entity
        /// > const char* propertyName
        /// > BOOL value
        ///
        /// </summary>
        DECOR_SET_BOOL = 0x6B1E8E2ED1335B71,
        /// <summary>
        /// Sets property to int.
        ///
        /// > Entity entity
        /// > const char* propertyName
        /// > int value
        ///
        /// </summary>
        DECOR_SET_INT = 0x0CE3AA5E1CA19E10,
        /// <summary>
        /// Returns whether or not the specified property is set for the entity.
        ///
        /// > Entity entity
        /// > const char* propertyName
        ///
        /// </summary>
        DECOR_EXIST_ON = 0x05661B80A8C9165F,
        /// <summary>
        /// https://alloc8or.re/gta5/doc/enums/eDecorType.txt
        ///
        /// > const char* propertyName
        /// > int type
        ///
        /// </summary>
        DECOR_REGISTER = 0x9FD90732F56403CE,
        /// <summary>
        /// type: see DECOR_REGISTER
        ///
        /// > const char* propertyName
        /// > int type
        ///
        /// </summary>
        DECOR_IS_REGISTERED_AS_TYPE = 0x4F14F9F870D6FBC8,
        /// <summary>
        /// Called after all decorator type initializations.
        ///
        ///
        /// </summary>
        DECOR_REGISTER_LOCK = 0xA9D14EEA259F9248,
        DECOR_SET_TIME = 0x95AED7B8E39ECAA4,
        DECOR_SET_FLOAT = 0x211AB1DD8D0F363A,
        DECOR_GET_BOOL = 0xDACE671663F2F5DB,
        DECOR_GET_FLOAT = 0x6524A2F114706F43,
        DECOR_GET_INT = 0xA06C969B02A97298,
        DECOR_REMOVE = 0x00EE9F297C738720,
    }
}