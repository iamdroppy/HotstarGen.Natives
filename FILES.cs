using System;
namespace Hotstar
{
    public enum FILES : ulong
    { 
        /// <summary>
        /// Character types:
        /// 0 = Michael, 
        /// 1 = Franklin, 
        /// 2 = Trevor, 
        /// 3 = MPMale, 
        /// 4 = MPFemale
        ///
        /// > int character
        ///
        /// </summary>
        GET_NUM_TATTOO_SHOP_DLC_ITEMS = 0x278F76C3B0A8F109,
        /// <summary>
        /// Character types:
        /// 0 = Michael, 
        /// 1 = Franklin, 
        /// 2 = Trevor, 
        /// 3 = MPMale, 
        /// 4 = MPFemale
        /// 
        /// 
        /// enum TattooZoneData
        /// {  
        ///     ZONE_TORSO = 0,  
        ///     ZONE_HEAD = 1,  
        ///     ZONE_LEFT_ARM = 2,  
        ///     ZONE_RIGHT_ARM = 3,  
        ///     ZONE_LEFT_LEG = 4,  
        ///     ZONE_RIGHT_LEG = 5,  
        ///     ZONE_UNKNOWN = 6,
        ///     ZONE_NONE = 7,  
        /// };
        /// struct outComponent
        /// {
        ///     // these vars are suffixed with 4 bytes of padding each.
        ///     uint unk;
        ///     int unk2;
        ///     uint tattooCollectionHash;
        ///     uint tattooNameHash;
        ///     int unk3;
        ///     TattooZoneData zoneId;
        ///     uint unk4;
        ///     uint unk5;
        ///     // maybe more, not sure exactly, decompiled scripts are very vague around this part.
        /// }
        ///
        /// > int characterType
        /// > int decorationIndex
        /// > Any* outComponent
        ///
        /// </summary>
        GET_TATTOO_SHOP_DLC_ITEM_DATA = 0xFF56381874F82086,
        /// <summary>
        /// character is 0 for Michael, 1 for Franklin, 2 for Trevor, 3 for freemode male, and 4 for freemode female.
        /// 
        /// componentId is between 0 and 11 and corresponds to the usual component slots.
        /// 
        /// p1 could be the outfit number; unsure.
        /// 
        /// p2 is usually -1; unknown function.
        /// 
        /// p3 appears to be for selecting between clothes and props; false is used with components/clothes, true is used with props.
        /// 
        /// p4 is usually -1; unknown function.
        /// 
        /// componentId is -1 when p3 is true in decompiled scripts.
        ///
        /// > int character
        /// > int p1
        /// > int p2
        /// > BOOL p3
        /// > int p4
        /// > int componentId
        ///
        /// </summary>
        SETUP_SHOP_PED_APPAREL_QUERY_TU = 0x9BDF59818B1E38C1,
        /// <summary>
        /// See https://git.io/JtcRf for example and structs.
        ///
        /// > int componentId
        /// > Any* outComponent
        ///
        /// </summary>
        GET_SHOP_PED_QUERY_COMPONENT = 0x249E310B2D920699,
        /// <summary>
        /// More info here: https://gist.github.com/root-cause/3b80234367b0c856d60bf5cb4b826f86
        ///
        /// > Hash componentHash
        /// > Any* outComponent
        ///
        /// </summary>
        GET_SHOP_PED_COMPONENT = 0x74C0E2A57EC66760,
        /// <summary>
        /// See https://git.io/JtcRf for example and structs.
        ///
        /// > int componentId
        /// > Any* outProp
        ///
        /// </summary>
        GET_SHOP_PED_QUERY_PROP = 0xDE44A00999B2837D,
        /// <summary>
        /// More info here: https://gist.github.com/root-cause/3b80234367b0c856d60bf5cb4b826f86
        ///
        /// > Hash componentHash
        /// > Any* outProp
        ///
        /// </summary>
        GET_SHOP_PED_PROP = 0x5D5CAFF661DDF6FC,
        /// <summary>
        /// `propHash`: Ped helmet prop hash?
        /// This native returns 1 when the player helmet has a visor (there is another prop index for the same helmet with closed/opened visor variant) that can be toggled. 0 if there's no alternative version with a visor for this helmet prop.
        ///
        /// > Hash propHash
        ///
        /// </summary>
        _GET_SHOP_PED_APPAREL_VARIANT_PROP_COUNT = 0xD40AAC51E8E4C663,
        /// <summary>
        /// Returns number of possible values of the forcedComponentIndex argument of GET_FORCED_COMPONENT.
        ///
        /// > Hash componentHash
        ///
        /// </summary>
        GET_SHOP_PED_APPAREL_FORCED_COMPONENT_COUNT = 0xC6B9DB42C04DD8C3,
        /// <summary>
        /// Returns number of possible values of the forcedPropIndex argument of GET_FORCED_PROP.
        ///
        /// > Hash componentHash
        ///
        /// </summary>
        GET_SHOP_PED_APPAREL_FORCED_PROP_COUNT = 0x017568A8182D98A6,
        /// <summary>
        /// Full list of restriction tags by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/pedApparelRestrictionTags.json
        /// 
        /// componentId/last parameter seems to be unused.
        ///
        /// > Hash componentHash
        /// > Hash restrictionTagHash
        /// > int componentId
        ///
        /// </summary>
        DOES_SHOP_PED_APPAREL_HAVE_RESTRICTION_TAG = 0x341DE7ED1D2A1BFD,
        /// <summary>
        /// characters
        /// 
        /// 0: Michael
        /// 1: Franklin
        /// 2: Trevor
        /// 3: MPMale
        /// 4: MPFemale
        ///
        /// > int character
        /// > BOOL p1
        ///
        /// </summary>
        SETUP_SHOP_PED_OUTFIT_QUERY = 0xF3FBE2D50A6A8C28,
        /// <summary>
        /// outfitIndex: from 0 to _GET_NUM_SHOP_PED_OUTFITS(characterIndex, false) - 1.
        /// See https://git.io/JtcB8 for example and outfit struct.
        ///
        /// > int outfitIndex
        /// > Any* outfit
        ///
        /// </summary>
        GET_SHOP_PED_QUERY_OUTFIT = 0x6D793F03A631FE56,
        /// <summary>
        /// See https://git.io/JtcBH for example and structs.
        ///
        /// > Hash outfitHash
        /// > int variantIndex
        /// > Any* outPropVariant
        ///
        /// </summary>
        GET_SHOP_PED_OUTFIT_PROP_VARIANT = 0xA9F9C2E0FDE11CBB,
        /// <summary>
        /// See https://git.io/JtcBH for example and structs.
        ///
        /// > Hash outfitHash
        /// > int variantIndex
        /// > Any* outComponentVariant
        ///
        /// </summary>
        GET_SHOP_PED_OUTFIT_COMPONENT_VARIANT = 0x19F2A026EDF0013F,
        /// <summary>
        /// dlcVehicleIndex is 0 to GET_NUM_DLC_VEHICLS() - 1
        ///
        /// > int dlcVehicleIndex
        ///
        /// </summary>
        GET_DLC_VEHICLE_MODEL = 0xECC01B7C5763333C,
        /// <summary>
        /// dlcVehicleIndex takes a number from 0 - GET_NUM_DLC_VEHICLES() - 1.
        /// outData is a struct of 3 8-byte items.
        /// The Second item in the struct *(Hash *)(outData + 1) is the vehicle hash.
        ///
        /// > int dlcVehicleIndex
        /// > int* outData
        ///
        /// </summary>
        GET_DLC_VEHICLE_DATA = 0x33468EDC08E371F6,
        /// <summary>
        /// Returns the total number of DLC weapons.
        ///
        ///
        /// </summary>
        GET_NUM_DLC_WEAPONS = 0xEE47635F352DA367,
        /// <summary>
        /// Returns the total number of DLC weapons that are available in SP (availableInSP field in shop_weapon.meta).
        ///
        ///
        /// </summary>
        _GET_NUM_DLC_WEAPONS_SP = 0x4160B65AE085B5A9,
        /// <summary>
        /// 
        /// dlcWeaponIndex takes a number from 0 - GET_NUM_DLC_WEAPONS() - 1.
        /// struct DlcWeaponData
        /// {
        /// int emptyCheck; //use DLC1::_IS_DLC_DATA_EMPTY on this
        /// int padding1;
        /// int weaponHash;
        /// int padding2;
        /// int unk;
        /// int padding3;
        /// int weaponCost;
        /// int padding4;
        /// int ammoCost;
        /// int padding5;
        /// int ammoType;
        /// int padding6;
        /// int defaultClipSize;
        /// int padding7;
        /// char nameLabel[64];
        /// char descLabel[64];
        /// char desc2Label[64]; // usually "the" + name
        /// char upperCaseNameLabel[64];
        /// };
        ///
        /// > int dlcWeaponIndex
        /// > int* outData
        ///
        /// </summary>
        GET_DLC_WEAPON_DATA = 0x79923CD21BECE14E,
        /// <summary>
        /// Same as GET_DLC_WEAPON_DATA but only works for DLC weapons that are available in SP.
        ///
        /// > int dlcWeaponIndex
        /// > int* outData
        ///
        /// </summary>
        _GET_DLC_WEAPON_DATA_SP = 0x310836EE7129BA33,
        /// <summary>
        /// Returns the total number of DLC weapon components.
        ///
        /// > int dlcWeaponIndex
        ///
        /// </summary>
        GET_NUM_DLC_WEAPON_COMPONENTS = 0x405425358A7D61FE,
        /// <summary>
        /// Returns the total number of DLC weapon components that are available in SP.
        ///
        /// > int dlcWeaponIndex
        ///
        /// </summary>
        _GET_NUM_DLC_WEAPON_COMPONENTS_SP = 0xAD2A7A6DFF55841B,
        /// <summary>
        /// p0 seems to be the weapon index
        /// p1 seems to be the weapon component index
        /// struct DlcComponentData{
        /// int attachBone;
        /// int padding1;
        /// int bActiveByDefault;
        /// int padding2;
        /// int unk;
        /// int padding3;
        /// int componentHash;
        /// int padding4;
        /// int unk2;
        /// int padding5;
        /// int componentCost;
        /// int padding6;
        /// char nameLabel[64];
        /// char descLabel[64];
        /// };
        /// 
        ///
        /// > int dlcWeaponIndex
        /// > int dlcWeapCompIndex
        /// > int* ComponentDataPtr
        ///
        /// </summary>
        GET_DLC_WEAPON_COMPONENT_DATA = 0x6CF598A2957C2BF8,
        /// <summary>
        /// Same as GET_DLC_WEAPON_COMPONENT_DATA but only works for DLC components that are available in SP.
        ///
        /// > int dlcWeaponIndex
        /// > int dlcWeapCompIndex
        /// > int* ComponentDataPtr
        ///
        /// </summary>
        _GET_DLC_WEAPON_COMPONENT_DATA_SP = 0x31D5E073B6F93CDC,
        /// <summary>
        /// From fm_deathmatch_creator and fm_race_creator:
        /// 
        /// FILES::_UNLOAD_CONTENT_CHANGE_SET_GROUP(joaat("GROUP_MAP_SP"));
        /// FILES::_LOAD_CONTENT_CHANGE_SET_GROUP(joaat("GROUP_MAP"));
        ///
        /// > Hash hash
        ///
        /// </summary>
        _LOAD_CONTENT_CHANGE_SET_GROUP = 0x6BEDF5769AC2DC07,
        /// <summary>
        /// From fm_deathmatch_creator and fm_race_creator:
        /// 
        /// FILES::_UNLOAD_CONTENT_CHANGE_SET_GROUP(joaat("GROUP_MAP_SP"));
        /// FILES::_LOAD_CONTENT_CHANGE_SET_GROUP(joaat("GROUP_MAP"));
        ///
        /// > Hash hash
        ///
        /// </summary>
        _UNLOAD_CONTENT_CHANGE_SET_GROUP = 0x3C1978285B036B25,
        /// <summary>
        /// Returns some sort of index/offset for overlays/decorations.
        /// 
        /// Character types:
        /// 0 = Michael, 
        /// 1 = Franklin, 
        /// 2 = Trevor, 
        /// 3 = MPMale, 
        /// 4 = MPFemale
        ///
        /// > Hash overlayHash
        /// > Any p1
        /// > int character
        ///
        /// </summary>
        _0x10144267DD22866C = 0x10144267DD22866C,
        /// <summary>
        /// Returns some sort of index/offset for components.
        /// Needs _GET_NUM_PROPS_FROM_OUTFIT to be called with p3 = false and componentId with the drawable's component slot first, returns -1 otherwise.
        ///
        /// > Hash componentHash
        ///
        /// </summary>
        _0x96E2929292A4DB77 = 0x96E2929292A4DB77,
        /// <summary>
        /// Returns some sort of index/offset for props.
        /// Needs _GET_NUM_PROPS_FROM_OUTFIT to be called with p3 = true and componentId = -1 first, returns -1 otherwise.
        ///
        /// > Hash componentHash
        ///
        /// </summary>
        _0x6CEBE002E58DEE97 = 0x6CEBE002E58DEE97,
        INIT_SHOP_PED_COMPONENT = 0x1E8C308FD312C036,
        INIT_SHOP_PED_PROP = 0xEB0A2B758F7B850F,
        SETUP_SHOP_PED_APPAREL_QUERY = 0x50F457823CE6EB5F,
        GET_HASH_NAME_FOR_COMPONENT = 0x0368B3A838070348,
        GET_HASH_NAME_FOR_PROP = 0x5D6160275CAEC8DD,
        GET_SHOP_PED_APPAREL_VARIANT_COMPONENT_COUNT = 0xC17AD0E5752BECDA,
        GET_VARIANT_COMPONENT = 0x6E11F282F11863B6,
        _GET_VARIANT_PROP = 0xD81B7F27BC773E66,
        GET_FORCED_COMPONENT = 0x6C93ED8C2F74859B,
        GET_FORCED_PROP = 0xE1CA84EBF72E691D,
        GET_SHOP_PED_OUTFIT = 0xB7952076E444979D,
        GET_SHOP_PED_OUTFIT_LOCATE = 0x073CA26B079F956E,
        GET_NUM_DLC_VEHICLES = 0xA7A866D21CD2329B,
        GET_DLC_VEHICLE_FLAGS = 0x5549EE11FA22FCF2,
        IS_CONTENT_ITEM_LOCKED = 0xD4D7B033C3AA243C,
        IS_DLC_VEHICLE_MOD = 0x0564B9FF9631B82C,
        GET_DLC_VEHICLE_MOD_LOCK_HASH = 0xC098810437312FFF,
    }
}