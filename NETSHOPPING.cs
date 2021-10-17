using System;
namespace Hotstar
{
    public enum NATIVE_NETSHOPPING : ulong
    { 
        CASHINVENTORY_INIT_SESSION_STATUS = 0xC019112F8995DC1C,
        _CASHINVENTORY_IS_SESSION_READY = 0xFCC24220FDDAC929,
        CASHINVENTORY_IS_CONNECTION_FAULTED = 0x6CE9FB6332B5E46E,
        _CASHINVENTORY_INIT_SESSION_IS_FAULTED = 0xD1CE92D1D9BE170A,
        _CASHINVENTORY_TRANSACTION_FIRE_AND_FORGET_ITEM = 0xFFEA09CCEC4AF32F,
        _CASHINVENTORY_TRANSACTION_START = 0xF039EC27F4490E96,
        _CASHINVENTORY_TRANSACTION_GET_BASKET_IS_VALID = 0x52A226ADF4A270D2,
        _CASHINVENTORY_TRANSACTION_DELETE = 0x59EF5D516E2D96B9,
        _CASHINVENTORY_TRANSACTION_VALIDATE_ITEM = 0x6C9F12700BCE69F4,
        _CASHINVENTORY_TRANSACTION_ADD_AWARD = 0x52BDE32F21BA3B6D,
        _CASHINVENTORY_TRANSACTION_GET_ITEM_INFO = 0x7616B5F0895C2D99,
        _CASHINVENTORY_TRANSACTION_GET_NUM_OF_ITEMS = 0xCF2D04D076847478,
        _CASHINVENTORY_TRANSACTION_GET_ACTION = 0xBD2D520C51CCFF52,
        _CASHINVENTORY_TRANSACTION_CHECKOUT = 0x592BC00BF6629BE7,
        _CASHINVENTORY_TRANSACTION_CHECKOUT_STATUS = 0x26C008791D066F37,
        _CASHINVENTORY_TRANSACTION_RESPONSE_GET_ITEM_INFO = 0x98412398BBE73F61,
        _0x38640A8C2DEF011B = 0x38640A8C2DEF011B,
        _0xA3B8D31C13CB4239 = 0xA3B8D31C13CB4239,
        _0xB6F4557060EF0FB4 = 0xB6F4557060EF0FB4,
        _0xCE54C9ABE6FBC6DB = 0xCE54C9ABE6FBC6DB,
        _0xA0B7094629724974 = 0xA0B7094629724974,
        _0x92A32BA29622763F = 0x92A32BA29622763F,
        _0x3FA09DD57B93C0DE = 0x3FA09DD57B93C0DE,
        _0xD1555FBC96C88444 = 0xD1555FBC96C88444,
    }
    public static class NATIVE_NETSHOPPING_EXTENSIONS
    {
        public static void Call(this NATIVE_NETSHOPPING hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_NETSHOPPING hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}