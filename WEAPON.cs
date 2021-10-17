using System;
namespace Hotstar
{
    public enum WEAPON : ulong
    { 
        /// <summary>
        /// Enables laser sight on any weapon.
        /// 
        /// It doesn't work. Neither on tick nor OnKeyDown
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        ENABLE_LASER_SIGHT_RENDERING = 0xC8B46D7727D864AA,
        /// <summary>
        /// Returns the model of any weapon.
        /// 
        /// Can also take an ammo hash?
        /// sub_6663a(&l_115B, WEAPON::GET_WEAPONTYPE_MODEL(${ammo_rpg}));
        ///
        /// > Hash weaponHash
        ///
        /// </summary>
        GET_WEAPONTYPE_MODEL = 0xF46CDC33180FDA94,
        /// <summary>
        /// Returns the amount of extra components the specified component has.
        /// Returns -1 if the component isn't of type CWeaponComponentVariantModel.
        ///
        /// > Hash componentHash
        ///
        /// </summary>
        _GET_WEAPON_COMPONENT_VARIANT_EXTRA_COMPONENT_COUNT = 0x6558AC7C17BFEF58,
        /// <summary>
        /// Returns the model hash of the extra component at specified index.
        ///
        /// > Hash componentHash
        /// > int extraComponentIndex
        ///
        /// </summary>
        _GET_WEAPON_COMPONENT_VARIANT_EXTRA_COMPONENT_MODEL = 0x4D1CB8DC40208A17,
        /// <summary>
        /// The return value seems to indicate returns true if the hash of the weapon object weapon equals the weapon hash.
        /// p2 seems to be 1 most of the time.
        /// 
        /// 
        /// 
        /// 
        /// 
        /// p2 is not implemented
        /// 
        /// disassembly said that?
        /// 
        ///
        /// > Ped ped
        /// > Hash* weaponHash
        /// > BOOL p2
        ///
        /// </summary>
        GET_CURRENT_PED_WEAPON = 0x3A87E44BB9A01D54,
        /// <summary>
        /// p1 is always 0 in the scripts.
        ///
        /// > Ped ped
        /// > BOOL p1
        ///
        /// </summary>
        GET_BEST_PED_WEAPON = 0x8483E98E8B888AE2,
        /// <summary>
        /// Example in VB
        /// 
        ///     Public Shared Function GetVehicleCurrentWeapon(Ped As Ped) As Integer
        ///         Dim arg As New OutputArgument()
        ///         Native.Function.Call(Hash.GET_CURRENT_PED_VEHICLE_WEAPON, Ped, arg)
        ///         Return arg.GetResult(Of Integer)()
        ///     End Function
        /// 
        /// Usage:
        /// If GetVehicleCurrentWeapon(Game.Player.Character) = -821520672 Then ...Do something
        /// Note: -821520672 = VEHICLE_WEAPON_PLANE_ROCKET
        ///
        /// > Ped ped
        /// > Hash* weaponHash
        ///
        /// </summary>
        GET_CURRENT_PED_VEHICLE_WEAPON = 0x1017582BCD3832DC,
        /// <summary>
        /// Checks if the ped is currently equipped with a weapon matching a bit specified using a bitwise-or in typeFlags.
        /// 
        /// Type flag bit values:
        /// 1 = Melee weapons
        /// 2 = Explosive weapons
        /// 4 = Any other weapons
        /// 
        /// Not specifying any bit will lead to the native *always* returning 'false', and for example specifying '4 | 2' will check for any weapon except fists and melee weapons.
        /// 7 returns true if you are equipped with any weapon except your fists.
        /// 6 returns true if you are equipped with any weapon except melee weapons.
        /// 5 returns true if you are equipped with any weapon except the Explosives weapon group.
        /// 4 returns true if you are equipped with any weapon except Explosives weapon group AND melee weapons.
        /// 3 returns true if you are equipped with either Explosives or Melee weapons (the exact opposite of 4).
        /// 2 returns true only if you are equipped with any weapon from the Explosives weapon group.
        /// 1 returns true only if you are equipped with any Melee weapon.
        /// 0 never returns true.
        /// 
        /// Note: When I say "Explosives weapon group", it does not include the Jerry can and Fire Extinguisher.
        ///
        /// > Ped ped
        /// > int typeFlags
        ///
        /// </summary>
        IS_PED_ARMED = 0x475768A975D5AD17,
        /// <summary>
        /// p2 should be FALSE, otherwise it seems to always return FALSE
        /// 
        /// Bool does not check if the weapon is current equipped, unfortunately.
        ///
        /// > Ped ped
        /// > Hash weaponHash
        /// > BOOL p2
        ///
        /// </summary>
        HAS_PED_GOT_WEAPON = 0x8DECB02F88F428BC,
        /// <summary>
        /// WEAPON::GET_AMMO_IN_PED_WEAPON(PLAYER::PLAYER_PED_ID(), a_0)
        /// 
        /// From decompiled scripts
        /// Returns total ammo in weapon
        /// 
        /// GTALua Example :
        /// natives.WEAPON.GET_AMMO_IN_PED_WEAPON(plyPed, WeaponHash)
        ///
        /// > Ped ped
        /// > Hash weaponhash
        ///
        /// </summary>
        GET_AMMO_IN_PED_WEAPON = 0x015A522136D7F951,
        /// <summary>
        /// Gives a weapon to PED with a delay, example:
        /// 
        /// WEAPON::GIVE_DELAYED_WEAPON_TO_PED(PED::PLAYER_PED_ID(), MISC::GET_HASH_KEY("WEAPON_PISTOL"), 1000, false)
        ///
        /// > Ped ped
        /// > Hash weaponHash
        /// > int ammoCount
        /// > BOOL bForceInHand
        ///
        /// </summary>
        GIVE_DELAYED_WEAPON_TO_PED = 0xB282DC6EBD803C75,
        /// <summary>
        /// setting the last params to false it does that same so I would suggest its not a toggle
        ///
        /// > Ped ped
        /// > BOOL p1
        ///
        /// </summary>
        REMOVE_ALL_PED_WEAPONS = 0xF25DF915FA38C5F3,
        /// <summary>
        /// This native removes a specified weapon from your selected ped.
        /// Weapon Hashes: pastebin.com/0wwDZgkF
        /// 
        /// Example:
        /// C#:
        /// Function.Call(Hash.REMOVE_WEAPON_FROM_PED, Game.Player.Character, 0x99B507EA);
        /// 
        /// C++:
        /// WEAPON::REMOVE_WEAPON_FROM_PED(PLAYER::PLAYER_PED_ID(), 0x99B507EA);
        /// 
        /// The code above removes the knife from the player.
        ///
        /// > Ped ped
        /// > Hash weaponHash
        ///
        /// </summary>
        REMOVE_WEAPON_FROM_PED = 0x4899CB088EDF59B8,
        /// <summary>
        /// Hides the players weapon during a cutscene.
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        HIDE_PED_WEAPON_FOR_SCRIPTED_CUTSCENE = 0x6F6981D2253C208F,
        /// <summary>
        /// Has 5 parameters since latest patches.
        ///
        /// > Ped ped
        /// > BOOL visible
        /// > BOOL deselectWeapon
        /// > BOOL p3
        /// > BOOL p4
        ///
        /// </summary>
        SET_PED_CURRENT_WEAPON_VISIBLE = 0x0725A4CCFDED9A70,
        /// <summary>
        /// It determines what weapons caused damage:
        /// 
        /// If you want to define only a specific weapon, second parameter=weapon hash code, third parameter=0
        /// If you want to define any melee weapon, second parameter=0, third parameter=1.
        /// If you want to identify any weapon (firearms, melee, rockets, etc.), second parameter=0, third parameter=2.
        ///
        /// > Ped ped
        /// > Hash weaponHash
        /// > int weaponType
        ///
        /// </summary>
        HAS_PED_BEEN_DAMAGED_BY_WEAPON = 0x2D343D2219CD027A,
        /// <summary>
        /// Does NOT seem to work with HAS_PED_BEEN_DAMAGED_BY_WEAPON. Use CLEAR_ENTITY_LAST_WEAPON_DAMAGE and HAS_ENTITY_BEEN_DAMAGED_BY_WEAPON instead.
        ///
        /// > Ped ped
        ///
        /// </summary>
        CLEAR_PED_LAST_WEAPON_DAMAGE = 0x0E98F88A24C5F4B8,
        /// <summary>
        /// It determines what weapons caused damage:
        /// 
        /// If you want to define only a specific weapon, second parameter=weapon hash code, third parameter=0
        /// If you want to define any melee weapon, second parameter=0, third parameter=1.
        /// If you want to identify any weapon (firearms, melee, rockets, etc.), second parameter=0, third parameter=2.
        ///
        /// > Entity entity
        /// > Hash weaponHash
        /// > int weaponType
        ///
        /// </summary>
        HAS_ENTITY_BEEN_DAMAGED_BY_WEAPON = 0x131D401334815E94,
        /// <summary>
        /// p2 is mostly 1 in the scripts.
        ///
        /// > Ped ped
        /// > Hash weaponHash
        /// > BOOL p2
        ///
        /// </summary>
        GET_MAX_AMMO_IN_CLIP = 0xA38DCFFCEA8962FA,
        /// <summary>
        /// Returns the max ammo for an ammo type. Ammo types: https://gist.github.com/root-cause/faf41f59f7a6d818b7db0b839bd147c1
        ///
        /// > Ped ped
        /// > Hash ammoTypeHash
        /// > int* ammo
        ///
        /// </summary>
        _GET_MAX_AMMO_BY_TYPE = 0x585847C5E4E11709,
        /// <summary>
        /// Ammo types: https://gist.github.com/root-cause/faf41f59f7a6d818b7db0b839bd147c1
        ///
        /// > Ped ped
        /// > Hash ammoTypeHash
        /// > int ammo
        ///
        /// </summary>
        _ADD_AMMO_TO_PED_BY_TYPE = 0x2472622CE1F2D45F,
        /// <summary>
        /// Ammo types: https://gist.github.com/root-cause/faf41f59f7a6d818b7db0b839bd147c1
        ///
        /// > Ped ped
        /// > Hash ammoTypeHash
        /// > int ammo
        ///
        /// </summary>
        SET_PED_AMMO_BY_TYPE = 0x5FD1E1F011E76D7E,
        /// <summary>
        /// Returns the current ammo type of the specified ped's specified weapon.
        /// MkII magazines will change the return value, like Pistol MkII returning AMMO_PISTOL without any components and returning AMMO_PISTOL_TRACER after Tracer Rounds component is attached.
        /// Use 0xF489B44DD5AF4BD9 if you always want AMMO_PISTOL.
        ///
        /// > Ped ped
        /// > Hash weaponHash
        ///
        /// </summary>
        GET_PED_AMMO_TYPE_FROM_WEAPON = 0x7FEAD38B326B9F74,
        /// <summary>
        /// Returns the base/default ammo type of the specified ped's specified weapon.
        /// Use GET_PED_AMMO_TYPE_FROM_WEAPON if you want current ammo type (like AMMO_MG_INCENDIARY/AMMO_MG_TRACER while using MkII magazines) and use this if you want base ammo type. (AMMO_MG)
        ///
        /// > Ped ped
        /// > Hash weaponHash
        ///
        /// </summary>
        _GET_PED_AMMO_TYPE_FROM_WEAPON_2 = 0xF489B44DD5AF4BD9,
        /// <summary>
        /// Pass ped. Pass address of Vector3.
        /// The coord will be put into the Vector3.
        /// The return will determine whether there was a coord found or not.
        ///
        /// > Ped ped
        /// > Vector3* coords
        ///
        /// </summary>
        GET_PED_LAST_WEAPON_IMPACT_COORD = 0x6C4D0409BA1A2BC2,
        /// <summary>
        /// p1/gadgetHash was always 0xFBAB5776 ("GADGET_PARACHUTE").
        /// p2 is always true.
        ///
        /// > Ped ped
        /// > Hash gadgetHash
        /// > BOOL p2
        ///
        /// </summary>
        SET_PED_GADGET = 0xD0D7B1E680ED4A1A,
        /// <summary>
        /// gadgetHash - was always 0xFBAB5776 ("GADGET_PARACHUTE").
        ///
        /// > Ped ped
        /// > Hash gadgetHash
        ///
        /// </summary>
        GET_IS_PED_GADGET_EQUIPPED = 0xF731332072F5156C,
        /// <summary>
        /// Returns the hash of the weapon. 
        /// 
        ///             var num7 = WEAPON::GET_SELECTED_PED_WEAPON(num4);
        ///             sub_27D3(num7);
        ///             switch (num7)
        ///             {
        ///                 case 0x24B17070:
        /// 
        /// Also see WEAPON::GET_CURRENT_PED_WEAPON. Difference?
        /// 
        /// -------------------------------------------------------------------------
        /// 
        /// The difference is that GET_SELECTED_PED_WEAPON simply returns the ped's current weapon hash but GET_CURRENT_PED_WEAPON also checks the weapon object and returns true if the hash of the weapon object equals the weapon hash
        ///
        /// > Ped ped
        ///
        /// </summary>
        GET_SELECTED_PED_WEAPON = 0x0A6DB4965674D243,
        /// <summary>
        ///              WEAPON::EXPLODE_PROJECTILES(PLAYER::PLAYER_PED_ID(), func_221(0x00000003), 0x00000001);
        ///
        /// > Ped ped
        /// > Hash weaponHash
        /// > BOOL p2
        ///
        /// </summary>
        EXPLODE_PROJECTILES = 0xFC4BD125DE7611E4,
        /// <summary>
        /// If `explode` true, then removal is done through exploding the projectile. Basically the same as EXPLODE_PROJECTILES but without defining the owner ped.
        ///
        /// > Hash weaponHash
        /// > BOOL explode
        ///
        /// </summary>
        REMOVE_ALL_PROJECTILES_OF_TYPE = 0xFC52E0F37E446528,
        /// <summary>
        /// Third Parameter = unsure, but pretty sure it is weapon hash
        /// --> get_hash_key("weapon_stickybomb")
        /// 
        /// Fourth Parameter = unsure, almost always -1
        ///
        /// > Ped driver
        /// > Vehicle vehicle
        /// > Hash weaponHash
        /// > Any p3
        ///
        /// </summary>
        HAS_VEHICLE_GOT_PROJECTILE_ATTACHED = 0x717C8481234E3B88,
        /// <summary>
        /// Forces a ped to reload only if they are able to; if they have a full magazine, they will not reload.
        ///
        /// > Ped ped
        ///
        /// </summary>
        MAKE_PED_RELOAD = 0x20AE33F3AC9C0033,
        /// <summary>
        /// Nearly every instance of p1 I found was 31. Nearly every instance of p2 I found was 0.
        /// 
        /// REQUEST_WEAPON_ASSET(iLocal_1888, 31, 26);
        ///
        /// > Hash weaponHash
        /// > int p1
        /// > int p2
        ///
        /// </summary>
        REQUEST_WEAPON_ASSET = 0x5443438F033E29C3,
        /// <summary>
        /// Now has 8 params.
        ///
        /// > Hash weaponHash
        /// > int ammoCount
        /// > float x
        /// > float y
        /// > float z
        /// > BOOL showWorldModel
        /// > float scale
        /// > Any p7
        /// > Any p8
        /// > Any p9
        ///
        /// </summary>
        CREATE_WEAPON_OBJECT = 0x9541D3CF0D398F36,
        /// <summary>
        /// addonHash:
        /// (use WEAPON::GET_WEAPON_COMPONENT_TYPE_MODEL() to get hash value)
        /// ${component_at_ar_flsh}, ${component_at_ar_supp}, ${component_at_pi_flsh}, ${component_at_scope_large}, ${component_at_ar_supp_02}
        ///
        /// > Object weaponObject
        /// > Hash addonHash
        ///
        /// </summary>
        GIVE_WEAPON_COMPONENT_TO_WEAPON_OBJECT = 0x33E179436C0B31DB,
        /// <summary>
        /// Drops the current weapon and returns the object
        /// 
        /// Unknown behavior when unarmed.
        ///
        /// > Ped ped
        /// > BOOL p1
        ///
        /// </summary>
        GET_WEAPON_OBJECT_FROM_PED = 0xCAE1DC9A0E22A16D,
        /// <summary>
        /// GIVE_*
        ///
        /// > Ped ped
        /// > Hash loadoutHash
        ///
        /// </summary>
        _GIVE_LOADOUT_TO_PED = 0x68F8BE6AF5CDF8A6,
        /// <summary>
        /// tintIndex can be the following:
        /// 
        /// 0 - Normal
        /// 1 - Green
        /// 2 - Gold
        /// 3 - Pink
        /// 4 - Army
        /// 5 - LSPD
        /// 6 - Orange
        /// 7 - Platinum
        ///
        /// > Ped ped
        /// > Hash weaponHash
        /// > int tintIndex
        ///
        /// </summary>
        SET_PED_WEAPON_TINT_INDEX = 0x50969B9B89ED5738,
        /// <summary>
        /// Colors:
        /// 0 = Gray
        /// 1 = Dark Gray
        /// 2 = Black
        /// 3 = White
        /// 4 = Blue
        /// 5 = Cyan
        /// 6 = Aqua
        /// 7 = Cool Blue
        /// 8 = Dark Blue
        /// 9 = Royal Blue
        /// 10 = Plum
        /// 11 = Dark Purple
        /// 12 = Purple
        /// 13 = Red
        /// 14 = Wine Red
        /// 15 = Magenta
        /// 16 = Pink
        /// 17 = Salmon
        /// 18 = Hot Pink
        /// 19 = Rust Orange
        /// 20 = Brown
        /// 21 = Earth
        /// 22 = Orange
        /// 23 = Light Orange
        /// 24 = Dark Yellow
        /// 25 = Yellow
        /// 26 = Light Brown
        /// 27 = Lime Green
        /// 28 = Olive
        /// 29 = Moss
        /// 30 = Turquoise
        /// 31 = Dark Green
        ///
        /// > Ped ped
        /// > Hash weaponHash
        /// > Hash camoComponentHash
        /// > int colorIndex
        ///
        /// </summary>
        _SET_PED_WEAPON_LIVERY_COLOR = 0x9FE5633880ECD8ED,
        /// <summary>
        /// Returns -1 if camoComponentHash is invalid/not attached to the weapon.
        ///
        /// > Ped ped
        /// > Hash weaponHash
        /// > Hash camoComponentHash
        ///
        /// </summary>
        _GET_PED_WEAPON_LIVERY_COLOR = 0xF0A60040BE558F2D,
        /// <summary>
        /// Colors:
        /// 0 = Gray
        /// 1 = Dark Gray
        /// 2 = Black
        /// 3 = White
        /// 4 = Blue
        /// 5 = Cyan
        /// 6 = Aqua
        /// 7 = Cool Blue
        /// 8 = Dark Blue
        /// 9 = Royal Blue
        /// 10 = Plum
        /// 11 = Dark Purple
        /// 12 = Purple
        /// 13 = Red
        /// 14 = Wine Red
        /// 15 = Magenta
        /// 16 = Pink
        /// 17 = Salmon
        /// 18 = Hot Pink
        /// 19 = Rust Orange
        /// 20 = Brown
        /// 21 = Earth
        /// 22 = Orange
        /// 23 = Light Orange
        /// 24 = Dark Yellow
        /// 25 = Yellow
        /// 26 = Light Brown
        /// 27 = Lime Green
        /// 28 = Olive
        /// 29 = Moss
        /// 30 = Turquoise
        /// 31 = Dark Green
        ///
        /// > Object weaponObject
        /// > Hash camoComponentHash
        /// > int colorIndex
        ///
        /// </summary>
        _SET_WEAPON_OBJECT_LIVERY_COLOR = 0x5DA825A85D0EA6E6,
        /// <summary>
        /// Returns -1 if camoComponentHash is invalid/not attached to the weapon object.
        ///
        /// > Object weaponObject
        /// > Hash camoComponentHash
        ///
        /// </summary>
        _GET_WEAPON_OBJECT_LIVERY_COLOR = 0xB3EA4FEABF41464B,
        /// <summary>
        /// struct WeaponHudStatsData
        /// {
        ///     BYTE hudDamage; // 0x0000
        ///     char _0x0001[0x7]; // 0x0001
        ///     BYTE hudSpeed; // 0x0008
        ///     char _0x0009[0x7]; // 0x0009
        ///     BYTE hudCapacity; // 0x0010
        ///     char _0x0011[0x7]; // 0x0011
        ///     BYTE hudAccuracy; // 0x0018
        ///     char _0x0019[0x7]; // 0x0019
        ///     BYTE hudRange; // 0x0020
        /// };
        /// 
        /// Usage:
        /// 
        /// WeaponHudStatsData data;
        /// if (GET_WEAPON_HUD_STATS(weaponHash, (int *)&data))
        /// {
        ///     // BYTE damagePercentage = data.hudDamage and so on
        /// }
        ///
        /// > Hash weaponHash
        /// > Any* outData
        ///
        /// </summary>
        GET_WEAPON_HUD_STATS = 0xD92C739EE34C9EBA,
        /// <summary>
        /// This native does not return damages of weapons from the melee and explosive group.
        ///
        /// > Hash weaponHash
        /// > Hash componentHash
        ///
        /// </summary>
        GET_WEAPON_DAMAGE = 0x3133B907D8B32053,
        /// <summary>
        /// // Returns the size of the default weapon component clip.
        /// 
        /// Use it like this:
        /// 
        /// char cClipSize[32];
        /// Hash cur;
        /// if (WEAPON::GET_CURRENT_PED_WEAPON(playerPed, &cur, 1))
        /// {
        ///     if (WEAPON::IS_WEAPON_VALID(cur))
        ///     {
        ///         int iClipSize = WEAPON::GET_WEAPON_CLIP_SIZE(cur);
        ///         sprintf_s(cClipSize, "ClipSize: %.d", iClipSize);
        ///         vDrawString(cClipSize, 0.5f, 0.5f);
        ///     }
        /// }
        /// 
        ///
        /// > Hash weaponHash
        ///
        /// </summary>
        GET_WEAPON_CLIP_SIZE = 0x583BE370B1EC6EB4,
        /// <summary>
        /// Returns handle of the projectile.
        ///
        /// > Ped ped
        /// > float p1
        ///
        /// </summary>
        SET_PED_SHOOT_ORDNANCE_WEAPON = 0xB4C8D77C80C0421E,
        /// <summary>
        /// Changes the weapon damage output by the given multiplier value. Must be run every frame.
        ///
        /// > Hash weaponHash
        /// > float damageMultiplier
        ///
        /// </summary>
        _SET_WEAPON_DAMAGE_MODIFIER_THIS_FRAME = 0x4757F00BC6323CFE,
        /// <summary>
        /// This native returns a true or false value.
        /// 
        /// Ped ped = The ped whose weapon you want to check.
        ///
        /// > Ped ped
        ///
        /// </summary>
        IS_PED_CURRENT_WEAPON_SILENCED = 0x65F0C5AE05943EC7,
        /// <summary>
        /// Enables/disables flashlight on ped's weapon.
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_FLASH_LIGHT_ENABLED = 0x988DB6FE9B3AC000,
        /// <summary>
        /// Changes the selected ped aiming animation style. 
        /// Note : You must use GET_HASH_KEY!
        /// 
        /// Strings to use with GET_HASH_KEY :
        /// 
        ///     "Ballistic",
        ///     "Default",
        ///   "Fat",
        ///   "Female",
        ///    "FirstPerson",
        ///   "FirstPersonAiming",
        ///     "FirstPersonFranklin",
        ///   "FirstPersonFranklinAiming",
        ///     "FirstPersonFranklinRNG",
        ///    "FirstPersonFranklinScope",
        ///  "FirstPersonMPFemale",
        ///   "FirstPersonMichael",
        ///    "FirstPersonMichaelAiming",
        ///  "FirstPersonMichaelRNG",
        ///     "FirstPersonMichaelScope",
        ///   "FirstPersonRNG",
        ///    "FirstPersonScope",
        ///  "FirstPersonTrevor",
        ///     "FirstPersonTrevorAiming",
        ///   "FirstPersonTrevorRNG",
        ///  "FirstPersonTrevorScope",
        ///    "Franklin",
        ///  "Gang",
        ///  "Gang1H",
        ///    "GangFemale",
        ///    "Hillbilly",
        ///     "MP_F_Freemode",
        ///     "Michael",
        ///   "SuperFat",
        ///  "Trevor"
        ///
        /// > Ped ped
        /// > Hash animStyle
        ///
        /// </summary>
        SET_WEAPON_ANIMATION_OVERRIDE = 0x1055AC3A667F09D9,
        /// <summary>
        /// 0=unknown (or incorrect weaponHash)
        /// 1= no damage (flare,snowball, petrolcan)
        /// 2=melee
        /// 3=bullet
        /// 4=force ragdoll fall
        /// 5=explosive (RPG, Railgun, grenade)
        /// 6=fire(molotov)
        /// 8=fall(WEAPON_HELI_CRASH)
        /// 10=electric
        /// 11=barbed wire
        /// 12=extinguisher
        /// 13=gas
        /// 14=water cannon(WEAPON_HIT_BY_WATER_CANNON)
        ///
        /// > Hash weaponHash
        ///
        /// </summary>
        GET_WEAPON_DAMAGE_TYPE = 0x3BE0BB12D25FB305,
        /// <summary>
        /// this returns if you can use the weapon while using a parachute
        ///
        /// > Hash weaponHash
        ///
        /// </summary>
        CAN_USE_WEAPON_ON_PARACHUTE = 0xBC7BE5ABC0879F74,
        /// <summary>
        /// Both coordinates are from objects in the decompiled scripts. Native related to 0xECDC202B25E5CF48 p1 value. The only weapon hash used in the decompiled scripts is weapon_air_defence_gun. These two natives are used by the yacht script, decompiled scripts suggest it and the weapon hash used (valkyrie's rockets) are also used by yachts.
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        /// > float p4
        /// > float p5
        /// > float p6
        /// > Hash weaponHash
        ///
        /// </summary>
        _CREATE_AIR_DEFENSE_SPHERE = 0x91EF34584710BE99,
        /// <summary>
        /// Disables selecting the given weapon. Ped isn't forced to put the gun away. However you can't reselect the weapon if you holster then unholster. Weapon is also grayed out on the weapon wheel.
        ///
        /// > Ped ped
        /// > Hash weaponHash
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_CAN_PED_EQUIP_WEAPON = 0xB4771B9AAF4E68E4,
        /// <summary>
        /// Disable all weapons. Does the same as 0xB4771B9AAF4E68E4 except for all weapons.
        ///
        /// > Ped ped
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_CAN_PED_EQUIP_ALL_WEAPONS = 0xEFF296097FF1E509,
        /// <summary>
        /// SET_PED_*
        ///
        /// > Ped ped
        ///
        /// </summary>
        _0x50276EF8172F5F12 = 0x50276EF8172F5F12,
        /// <summary>
        /// GET_PED_WEAPON_*
        ///
        /// > Ped ped
        /// > Hash weaponHash
        ///
        /// </summary>
        _0xA2C9AC24B4061285 = 0xA2C9AC24B4061285,
        /// <summary>
        /// SET_WEAPON_OBJECT_*
        ///
        /// > Object weaponObject
        /// > int p1
        ///
        /// </summary>
        _0x977CA98939E82E4B = 0x977CA98939E82E4B,
        GET_WEAPON_COMPONENT_TYPE_MODEL = 0x0DB57B41EC1DB083,
        GET_WEAPONTYPE_SLOT = 0x4215460B9B8B7FA0,
        GET_WEAPONTYPE_GROUP = 0xC3287EE3050FB74C,
        SET_CURRENT_PED_WEAPON = 0xADF692B254977C0C,
        GET_CURRENT_PED_WEAPON_ENTITY_INDEX = 0x3B390A939AF0B5FC,
        SET_CURRENT_PED_VEHICLE_WEAPON = 0x75C55983C2C39DAA,
        IS_WEAPON_VALID = 0x937C71165CF334B3,
        IS_PED_WEAPON_READY_TO_SHOOT = 0xB80CA294F2F26749,
        GET_PED_WEAPONTYPE_IN_SLOT = 0xEFFED78E9011134D,
        ADD_AMMO_TO_PED = 0x78F0424C34306220,
        SET_PED_AMMO = 0x14E56BC5B5DB6A19,
        SET_PED_INFINITE_AMMO = 0x3EDCB0505123623B,
        SET_PED_INFINITE_AMMO_CLIP = 0x183DADC6AA953186,
        GIVE_WEAPON_TO_PED = 0xBF0FD6E56C964FCB,
        SET_PED_DROPS_WEAPONS_WHEN_DEAD = 0x476AE72C1D19D1A8,
        CLEAR_ENTITY_LAST_WEAPON_DAMAGE = 0xAC678E40BE7C74D2,
        SET_PED_DROPS_WEAPON = 0x6B7513D9966FBEC0,
        SET_PED_DROPS_INVENTORY_WEAPON = 0x208A1888007FC0E6,
        GET_AMMO_IN_CLIP = 0x2E1202248937775C,
        SET_AMMO_IN_CLIP = 0xDCD2A934D65CB497,
        GET_MAX_AMMO = 0xDC16122C7A20C933,
        GET_PED_AMMO_BY_TYPE = 0x39D22031557946C1,
        SET_PED_AMMO_TO_DROP = 0xA4EFEF9440A5B0EF,
        SET_PICKUP_AMMO_AMOUNT_SCALER = 0xE620FD3512A04F18,
        GET_LOCKON_DISTANCE_OF_CURRENT_PED_WEAPON = 0x840F03E9041E2C9C,
        GET_MAX_RANGE_OF_CURRENT_PED_WEAPON = 0x814C9D19DFD69679,
        GIVE_WEAPON_COMPONENT_TO_PED = 0xD966D51AA5B28BB9,
        REMOVE_WEAPON_COMPONENT_FROM_PED = 0x1E8BE90C74FB4C09,
        HAS_PED_GOT_WEAPON_COMPONENT = 0xC593212475FAE340,
        IS_PED_WEAPON_COMPONENT_ACTIVE = 0x0D78DE0572D3969E,
        REFILL_AMMO_INSTANTLY = 0x8C0D57EA686FAD87,
        HAS_WEAPON_ASSET_LOADED = 0x36E353271F0E90EE,
        REMOVE_WEAPON_ASSET = 0xAA08EF13F341C8FC,
        REMOVE_WEAPON_COMPONENT_FROM_WEAPON_OBJECT = 0xF7D82B0D66777611,
        HAS_WEAPON_GOT_WEAPON_COMPONENT = 0x76A18844E743BF91,
        GIVE_WEAPON_OBJECT_TO_PED = 0xB1FA61371AF7C4B7,
        DOES_WEAPON_TAKE_WEAPON_COMPONENT = 0x5CEE3DF569CECAB0,
        GET_PED_WEAPON_TINT_INDEX = 0x2B9EEDC07BD06B9F,
        SET_WEAPON_OBJECT_TINT_INDEX = 0xF827589017D4E4A9,
        GET_WEAPON_OBJECT_TINT_INDEX = 0xCD183314F7CD2E57,
        GET_WEAPON_TINT_COUNT = 0x5DCF6C5CAB2E9BF7,
        GET_WEAPON_COMPONENT_HUD_STATS = 0xB3CAF387AE12E9F8,
        _GET_WEAPON_TIME_BETWEEN_SHOTS = 0x065D2AACAD8CF7A4,
        SET_PED_CHANCE_OF_FIRING_BLANKS = 0x8378627201D5497D,
        REQUEST_WEAPON_HIGH_DETAIL_MODEL = 0x48164DBB970AC3F0,
        _SET_WEAPON_EXPLOSION_RADIUS_MULTIPLIER = 0x4AE5AC8B852D642C,
        IS_FLASH_LIGHT_ON = 0x4B7620C47217126C,
        SET_FLASH_LIGHT_FADE_DISTANCE = 0xCEA66DAD478CD39B,
        _CREATE_AIR_DEFENSE_AREA = 0x9DA58CDBF6BDBC08,
        _REMOVE_AIR_DEFENSE_ZONE = 0x0ABF535877897560,
        _REMOVE_ALL_AIR_DEFENSE_ZONES = 0x1E45B34ADEBEE48E,
        _SET_PLAYER_AIR_DEFENSE_ZONE_FLAG = 0xECDC202B25E5CF48,
        _IS_ANY_AIR_DEFENSE_ZONE_INSIDE_SPHERE = 0xDAB963831DBFD3F4,
        _FIRE_AIR_DEFENSE_WEAPON = 0x44F1012B69313374,
        _DOES_AIR_DEFENSE_ZONE_EXIST = 0xCD79A550999D7D4F,
        _0x24C024BA8379A70A = 0x24C024BA8379A70A,
        _0xE6D2CEDD370FF98E = 0xE6D2CEDD370FF98E,
        _0xE4DCEC7FD5B739A5 = 0xE4DCEC7FD5B739A5,
    }
}