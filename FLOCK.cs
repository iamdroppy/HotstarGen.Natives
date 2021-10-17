using System;
namespace Hotstar
{
    public enum NATIVE_FLOCK : ulong
    { 
        /// <summary>
        /// enum eAnimalRarityLevel
        /// {
        /// 	ARL_COMMON,
        /// 	ARL_RARE,
        /// 	ARL_LEGENDARY,
        /// 	ARL_NUMRARITYLEVELS
        /// };
        ///
        /// > Ped ped
        ///
        /// </summary>
        _GET_ANIMAL_RARITY = 0xF8B48A361DC388AE,
        /// <summary>
        /// rarityLevel: see _GET_ANIMAL_RARITY
        ///
        /// > Ped ped
        /// > int rarityLevel
        ///
        /// </summary>
        _SET_ANIMAL_RARITY = 0x8B6F0F59B1B99801,
        GET_SPECIES_TUNING_FLOAT_PARAM = 0xE108489621422F91,
        SET_SPECIES_TUNING_FLOAT_PARAM = 0x963240B6C252BA49,
        SET_SPECIES_TUNING_BOOL_PARAM = 0x6D1D94C2459B42EE,
        GET_ANIMAL_TUNING_FLOAT_PARAM = 0x4BC3ECFDA0297E27,
        SET_ANIMAL_TUNING_FLOAT_PARAM = 0xCBDA22C87977244F,
        RESET_ANIMAL_TUNING_FLOAT_PARAM = 0xE776A195488FC520,
        GET_ANIMAL_TUNING_BOOL_PARAM = 0x1C1993824A396603,
        SET_ANIMAL_TUNING_BOOL_PARAM = 0x9FF1E042FA597187,
        RESET_ANIMAL_TUNING_BOOL_PARAM = 0x96AA1304D30E6BC3,
        _CREATE_HERD = 0xCB4EF7EDAE2E16F1,
        _ADD_PED_TO_FLOCK = 0x933E5D31A7D13069,
        _0x8049B17BEC937662 = 0x8049B17BEC937662,
        _0xE93415B3307208E5 = 0xE93415B3307208E5,
        _0x19870C40C7EE15BE = 0x19870C40C7EE15BE,
        _0x0816C31480764AB0 = 0x0816C31480764AB0,
        _0xC3D581A34BC0A1F0 = 0xC3D581A34BC0A1F0,
        _0xF2CCA7B68CFAB2B9 = 0xF2CCA7B68CFAB2B9,
        _0xFB16F08F47B83B4C = 0xFB16F08F47B83B4C,
        _0x3B005FF0538ED2A9 = 0x3B005FF0538ED2A9,
        _0xAEB97D84CDF3C00B = 0xAEB97D84CDF3C00B,
        _0xFF1E339CE40EAAAF = 0xFF1E339CE40EAAAF,
        _0x8D913E493BAFE0A3 = 0x8D913E493BAFE0A3,
        _0xE0961AED72642B80 = 0xE0961AED72642B80,
        _0x408D1149C5E39C1E = 0x408D1149C5E39C1E,
        _0x9E13ACC38BA8F9C3 = 0x9E13ACC38BA8F9C3,
        _0x34B9C4D86DF2C2F3 = 0x34B9C4D86DF2C2F3,
        _0x1DA6CB02071055D5 = 0x1DA6CB02071055D5,
        _0xC95611869E14F8AF = 0xC95611869E14F8AF,
        _0x09EE00B8F858E0BE = 0x09EE00B8F858E0BE,
        _0xE36D2CB540597EF7 = 0xE36D2CB540597EF7,
        _0xD95F04A4E73BE85E = 0xD95F04A4E73BE85E,
        _0x17E3E5C46ECCD308 = 0x17E3E5C46ECCD308,
        _0xC72CE37081DAE625 = 0xC72CE37081DAE625,
        _0x67A43EA3F6FE0076 = 0x67A43EA3F6FE0076,
        _0x36486AF7DA93A464 = 0x36486AF7DA93A464,
        _0x6C57BEA886A20C6B = 0x6C57BEA886A20C6B,
        _0x1520626FFAFFFA8F = 0x1520626FFAFFFA8F,
        _0xFA821997794F48E7 = 0xFA821997794F48E7,
        _0xCC6B5AAFC87BFC7B = 0xCC6B5AAFC87BFC7B,
        _0xFDB008B3BCF5992F = 0xFDB008B3BCF5992F,
        _0x2DF3D457D86F8E57 = 0x2DF3D457D86F8E57,
        _0x706B434FEFAD6A24 = 0x706B434FEFAD6A24,
        _0xA881F5C77A560906 = 0xA881F5C77A560906,
        _0x53187E563F938E76 = 0x53187E563F938E76,
    }
    public static class NATIVE_FLOCK_EXTENSIONS
    {
        public static void Call(this NATIVE_FLOCK hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_FLOCK hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}