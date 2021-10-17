using System;
namespace Hotstar
{
    public enum VEHICLE : ulong
    { 
        /// <summary>
        /// p7 when set to true allows you to spawn vehicles under -100 z.
        /// Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
        ///
        /// > Hash modelHash
        /// > float x
        /// > float y
        /// > float z
        /// > float heading
        /// > BOOL isNetwork
        /// > BOOL bScriptHostVeh
        /// > BOOL p7
        ///
        /// </summary>
        CREATE_VEHICLE = 0xAF35D0D2583051B0,
        /// <summary>
        /// Deletes a vehicle.
        /// The vehicle must be a mission entity to delete, so call this before deleting: SET_ENTITY_AS_MISSION_ENTITY(vehicle, true, true);
        /// 
        /// eg how to use:
        /// SET_ENTITY_AS_MISSION_ENTITY(vehicle, true, true);
        /// DELETE_VEHICLE(&vehicle);
        /// 
        /// Deletes the specified vehicle, then sets the handle pointed to by the pointer to NULL.
        ///
        /// > Vehicle* vehicle
        ///
        /// </summary>
        DELETE_VEHICLE = 0xEA386986E786A54F,
        /// <summary>
        /// SET_VEHICLE_AL*
        ///
        /// > Vehicle vehicle
        /// > BOOL canBeLockedOn
        /// > BOOL unk
        ///
        /// </summary>
        _SET_VEHICLE_CAN_BE_LOCKED_ON = 0x1DDA078D12879EEE,
        /// <summary>
        /// Makes the vehicle accept no passengers.
        ///
        /// > Vehicle veh
        /// > BOOL toggle
        ///
        /// </summary>
        SET_VEHICLE_ALLOW_NO_PASSENGERS_LOCKON = 0x5D14D4154BFE7B2C,
        /// <summary>
        /// Returns a value depending on the lock-on state of vehicle weapons.
        /// 0: not locked on
        /// 1: locking on
        /// 2: locked on
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_VEHICLE_HOMING_LOCKON_STATE = 0xE6B0E8CFC3633BF0,
        /// <summary>
        /// Creates a script vehicle generator at the given coordinates. Most parameters after the model hash are unknown.
        /// 
        /// Parameters:
        /// x/y/z - Generator position
        /// heading - Generator heading
        /// p4 - Unknown (always 5.0)
        /// p5 - Unknown (always 3.0)
        /// modelHash - Vehicle model hash
        /// p7/8/9/10 - Unknown (always -1)
        /// p11 - Unknown (usually TRUE, only one instance of FALSE)
        /// p12/13 - Unknown (always FALSE)
        /// p14 - Unknown (usally FALSE, only two instances of TRUE)
        /// p15 - Unknown (always TRUE)
        /// p16 - Unknown (always -1)
        /// 
        /// Vector3 coords = GET_ENTITY_COORDS(PLAYER_PED_ID(), 0);    CREATE_SCRIPT_VEHICLE_GENERATOR(coords.x, coords.y, coords.z, 1.0f, 5.0f, 3.0f, GET_HASH_KEY("adder"), -1. -1, -1, -1, -1, true, false, false, false, true, -1);
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float heading
        /// > float p4
        /// > float p5
        /// > Hash modelHash
        /// > int p7
        /// > int p8
        /// > int p9
        /// > int p10
        /// > BOOL p11
        /// > BOOL p12
        /// > BOOL p13
        /// > BOOL p14
        /// > BOOL p15
        /// > int p16
        ///
        /// </summary>
        CREATE_SCRIPT_VEHICLE_GENERATOR = 0x9DEF883114668116,
        /// <summary>
        /// Only called once in the decompiled scripts. Presumably activates the specified generator.
        ///
        /// > int vehicleGenerator
        /// > BOOL enabled
        ///
        /// </summary>
        SET_SCRIPT_VEHICLE_GENERATOR = 0xD9D620E0AC6DC4B0,
        /// <summary>
        /// Sets a vehicle on the ground on all wheels.  Returns whether or not the operation was successful.
        /// 
        /// sfink: This has an additional param(Vehicle vehicle, float p1) which is always set to 5.0f in the b944 scripts.
        ///
        /// > Vehicle vehicle
        /// > float p1
        ///
        /// </summary>
        SET_VEHICLE_ON_GROUND_PROPERLY = 0x49733E92263139D1,
        /// <summary>
        /// Returns true if the vehicle's current speed is less than, or equal to 0.0025f.
        /// 
        /// For some vehicles it returns true if the current speed is <= 0.00039999999.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        IS_VEHICLE_STOPPED = 0x5721B434AD84D57A,
        /// <summary>
        /// Gets the number of passengers, NOT including the driver. Use IS_VEHICLE_SEAT_FREE(Vehicle, -1) to also check for the driver
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_VEHICLE_NUMBER_OF_PASSENGERS = 0x24CB2137731FFE89,
        /// <summary>
        /// Returns max number of passengers (including the driver) for the specified vehicle model.
        /// 
        /// Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
        ///
        /// > Hash modelHash
        ///
        /// </summary>
        GET_VEHICLE_MODEL_NUMBER_OF_SEATS = 0x2AD93716F184EDA4,
        /// <summary>
        /// Returns true if the vehicle has the FLAG_ALLOWS_RAPPEL flag set.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _DOES_VEHICLE_ALLOW_RAPPEL = 0x4E417C547182C84D,
        /// <summary>
        /// Use this native inside a looped function.
        /// Values:
        /// - `0.0` = no vehicles on streets
        /// - `1.0` = normal vehicles on streets
        ///
        /// > float multiplier
        ///
        /// </summary>
        SET_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME = 0x245A6883D966D537,
        /// <summary>
        /// 0 - CARLOCK_NONE
        /// 1 - CARLOCK_UNLOCKED
        /// 2 - CARLOCK_LOCKED (locked)
        /// 3 - CARLOCK_LOCKOUT_PLAYER_ONLY
        /// 4 - CARLOCK_LOCKED_PLAYER_INSIDE (can get in, can't leave)
        /// 
        /// (maybe, these are leftovers from GTA:VC)
        /// 5 - CARLOCK_LOCKED_INITIALLY
        /// 6 - CARLOCK_FORCE_SHUT_DOORS
        /// 7 - CARLOCK_LOCKED_BUT_CAN_BE_DAMAGED
        /// 
        /// (source: GTA VC miss2 leak, matching constants for 0/2/4, testing)
        /// 
        /// They use 10 in am_mp_property_int, don't know what it does atm.
        ///
        /// > Vehicle vehicle
        /// > int doorLockStatus
        ///
        /// </summary>
        SET_VEHICLE_DOORS_LOCKED = 0xB664292EAECF7FA6,
        /// <summary>
        /// doorId: see SET_VEHICLE_DOOR_SHUT
        ///
        /// > Vehicle vehicle
        /// > int doorId
        /// > int doorLockStatus
        ///
        /// </summary>
        SET_VEHICLE_INDIVIDUAL_DOORS_LOCKED = 0xBE70724027F85BCD,
        /// <summary>
        /// if set to true, prevents vehicle sirens from having sound, leaving only the lights.
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        SET_VEHICLE_HAS_MUTED_SIRENS = 0xD8050E0EB60CF274,
        /// <summary>
        /// After some analysis, I've decided that these are what the parameters are.
        /// 
        /// We can see this being used in R* scripts such as "am_mp_property_int.ysc.c4":
        /// l_11A1 = PED::GET_VEHICLE_PED_IS_IN(PLAYER::PLAYER_PED_ID(), 1);
        /// ...
        /// VEHICLE::SET_VEHICLE_DOORS_LOCKED_FOR_ALL_PLAYERS(l_11A1, 1);
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        SET_VEHICLE_DOORS_LOCKED_FOR_ALL_PLAYERS = 0xA2F80B8D040727CC,
        /// <summary>
        /// Explodes a selected vehicle.
        /// 
        /// Vehicle vehicle = Vehicle you want to explode.
        /// BOOL isAudible = If explosion makes a sound.
        /// BOOL isInvisible = If the explosion is invisible or not.
        /// 
        /// First BOOL does not give any visual explosion, the vehicle just falls apart completely but slowly and starts to burn.
        ///
        /// > Vehicle vehicle
        /// > BOOL isAudible
        /// > BOOL isInvisible
        ///
        /// </summary>
        EXPLODE_VEHICLE = 0xBA71116ADF5B514C,
        /// <summary>
        /// Tested on the player's current vehicle. Unless you kill the driver, the vehicle doesn't loose control, however, if enabled, explodeOnImpact is still active. The moment you crash, boom.
        ///
        /// > Vehicle vehicle
        /// > BOOL killDriver
        /// > BOOL explodeOnImpact
        ///
        /// </summary>
        SET_VEHICLE_OUT_OF_CONTROL = 0xF19D095E42D430CC,
        /// <summary>
        /// This is not tested - it's just an assumption.
        /// - Nac
        /// 
        /// Doesn't seem to work.  I'll try with an int instead. --JT
        /// 
        /// Read the scripts, im dumpass. 
        /// 
        ///                             if (!VEHICLE::IS_TAXI_LIGHT_ON(l_115)) {
        ///                                 VEHICLE::SET_TAXI_LIGHTS(l_115, 1);
        ///                             }
        ///
        /// > Vehicle vehicle
        /// > BOOL state
        ///
        /// </summary>
        SET_TAXI_LIGHTS = 0x598803E85E8448D9,
        /// <summary>
        /// garageName example "Michael - Beverly Hills"
        /// 
        /// Full list of garages by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/garages.json
        ///
        /// > const char* garageName
        /// > Vehicle vehicle
        ///
        /// </summary>
        IS_VEHICLE_IN_GARAGE_AREA = 0xCEE4490CD57BB3C2,
        /// <summary>
        /// colorPrimary & colorSecondary are the paint index for the vehicle.
        /// For a list of valid paint indexes, view: pastebin.com/pwHci0xK
        /// -------------------------------------------------------------------------
        /// Use this to get the number of color indices: pastebin.com/RQEeqTSM
        /// Note: minimum color index is 0, maximum color index is (numColorIndices - 1)
        /// 
        /// Full list of vehicle colors by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicleColors.json
        ///
        /// > Vehicle vehicle
        /// > int colorPrimary
        /// > int colorSecondary
        ///
        /// </summary>
        SET_VEHICLE_COLOURS = 0x4F1D4BE3A7F24601,
        /// <summary>
        /// It switch to highbeam when p1 is set to true.
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        SET_VEHICLE_FULLBEAM = 0x8B7FD87F0DDB421E,
        /// <summary>
        /// p1 (toggle) was always 1 (true) except in one case in the b678 scripts.
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        SET_VEHICLE_IS_RACING = 0x07116E24E9D1929D,
        /// <summary>
        /// p1, p2, p3 are RGB values for color (255,0,0 for Red, ect)
        ///
        /// > Vehicle vehicle
        /// > int r
        /// > int g
        /// > int b
        ///
        /// </summary>
        SET_VEHICLE_CUSTOM_PRIMARY_COLOUR = 0x7141766F91D15BEA,
        /// <summary>
        /// p1, p2, p3 are RGB values for color (255,0,0 for Red, ect)
        ///
        /// > Vehicle vehicle
        /// > int r
        /// > int g
        /// > int b
        ///
        /// </summary>
        SET_VEHICLE_CUSTOM_SECONDARY_COLOUR = 0x36CED73BFED89754,
        /// <summary>
        /// Check if Vehicle Secondary is avaliable for customize
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_IS_VEHICLE_SECONDARY_COLOUR_CUSTOM = 0x910A32E7AAD2656C,
        /// <summary>
        /// formerly known as _SET_VEHICLE_PAINT_FADE
        /// 
        /// The parameter fade is a value from 0-1, where 0 is fresh paint.
        ///
        /// > Vehicle vehicle
        /// > float fade
        ///
        /// </summary>
        SET_VEHICLE_ENVEFF_SCALE = 0x3AFDC536C3D01674,
        /// <summary>
        /// formerly known as _GET_VEHICLE_PAINT_FADE
        /// 
        /// The result is a value from 0-1, where 0 is fresh paint.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_VEHICLE_ENVEFF_SCALE = 0xA82819CAC9C4C403,
        /// <summary>
        /// Hardcoded to not work in multiplayer.
        ///
        /// > Vehicle vehicle
        /// > BOOL state
        ///
        /// </summary>
        SET_CAN_RESPRAY_VEHICLE = 0x52BBA29D5EC69356,
        /// <summary>
        /// IS_*
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _IS_BOAT_ANCHORED_AND_FROZEN = 0xB0AD1238A709B1A2,
        /// <summary>
        /// Activate siren on vehicle (Only works if the vehicle has a siren).
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        SET_VEHICLE_SIREN = 0xF4924635A19EB37D,
        /// <summary>
        /// If set to true, vehicle will not take crash damage, but is still susceptible to damage from bullets and explosives
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        SET_VEHICLE_STRONG = 0x3E8C8727991A8A0B,
        /// <summary>
        /// Check if a vehicle seat is free.
        /// 
        /// seatIndex  = -1 being the driver seat.
        /// Use GET_VEHICLE_MAX_NUMBER_OF_PASSENGERS(vehicle) - 1 for last seat index.
        /// isTaskRunning = on true the function returns already false while a task on the target seat is running (TASK_ENTER_VEHICLE/TASK_SHUFFLE_TO_NEXT_VEHICLE_SEAT) - on false only when a ped is finally sitting in the seat.
        ///
        /// > Vehicle vehicle
        /// > int seatIndex
        /// > BOOL isTaskRunning
        ///
        /// </summary>
        IS_VEHICLE_SEAT_FREE = 0x22AC59A870E6A669,
        /// <summary>
        /// If there is no ped in the seat, and the game considers the vehicle as ambient population, this will create a random occupant ped in the seat, which may be cleaned up by the game fairly soon if not marked as script-owned mission entity.
        /// 
        /// Seat indexes:
        /// -1 = Driver
        /// 0 = Front Right Passenger
        /// 1 = Back Left Passenger
        /// 2 = Back Right Passenger
        /// 3 = Further Back Left Passenger (vehicles > 4 seats)
        /// 4 = Further Back Right Passenger (vehicles > 4 seats)
        /// etc.
        /// 
        /// If p2 is true it uses a different GetOccupant function.
        ///
        /// > Vehicle vehicle
        /// > int seatIndex
        /// > BOOL p2
        ///
        /// </summary>
        GET_PED_IN_VEHICLE_SEAT = 0xBB40DD2270B65366,
        /// <summary>
        /// wheelID used for 4 wheelers seem to be (0, 1, 4, 5)
        /// completely - is to check if tire completely gone from rim.
        /// 
        /// '0 = wheel_lf / bike, plane or jet front
        /// '1 = wheel_rf
        /// '2 = wheel_lm / in 6 wheels trailer, plane or jet is first one on left
        /// '3 = wheel_rm / in 6 wheels trailer, plane or jet is first one on right
        /// '4 = wheel_lr / bike rear / in 6 wheels trailer, plane or jet is last one on left
        /// '5 = wheel_rr / in 6 wheels trailer, plane or jet is last one on right
        /// '45 = 6 wheels trailer mid wheel left
        /// '47 = 6 wheels trailer mid wheel right
        ///
        /// > Vehicle vehicle
        /// > int wheelID
        /// > BOOL completely
        ///
        /// </summary>
        IS_VEHICLE_TYRE_BURST = 0xBA291848A0815CA9,
        /// <summary>
        /// SCALE: Setting the speed to 30 would result in a speed of roughly 60mph, according to speedometer.
        /// 
        /// Speed is in meters per second
        /// You can convert meters/s to mph here:
        /// http://www.calculateme.com/Speed/MetersperSecond/ToMilesperHour.htm
        ///
        /// > Vehicle vehicle
        /// > float speed
        ///
        /// </summary>
        SET_VEHICLE_FORWARD_SPEED = 0xAB54A438726D25D5,
        /// <summary>
        /// This native makes the vehicle stop immediately, as happens when we enter a MP garage.
        /// 
        /// . distance defines how far it will travel until stopping. Garage doors use 3.0.
        /// 
        /// . If killEngine is set to 1, you cannot resume driving the vehicle once it stops. This looks like is a bitmapped integer.
        ///
        /// > Vehicle vehicle
        /// > float distance
        /// > int duration
        /// > BOOL unknown
        ///
        /// </summary>
        BRING_VEHICLE_TO_HALT = 0x260BE8F09E326A20,
        /// <summary>
        /// Stops CTaskBringVehicleToHalt
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _STOP_BRING_VEHICLE_TO_HALT = 0x7C06330BFDDA182E,
        /// <summary>
        /// Returns true if vehicle is halted by BRING_VEHICLE_TO_HALT
        /// _IS_VEHICLE_*
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _IS_VEHICLE_BEING_HALTED = 0xC69BB1D832A710EF,
        /// <summary>
        /// 0.0 = Lowest 1.0 = Highest. This is best to be used if you wanna pick-up a car since un-realistically on GTA V forklifts can't pick up much of anything due to vehicle mass. If you put this under a car then set it above 0.0 to a 'lifted-value' it will raise the car with no issue lol
        ///
        /// > Vehicle vehicle
        /// > float height
        ///
        /// </summary>
        SET_FORKLIFT_FORK_HEIGHT = 0x37EBBF3117BD6A25,
        /// <summary>
        /// Finds the vehicle that is carrying this entity with a handler frame.
        /// The model of the entity must be prop_contr_03b_ld or the function will return 0.
        ///
        /// > Entity entity
        ///
        /// </summary>
        _FIND_VEHICLE_CARRYING_THIS_ENTITY = 0x375E7FC44F21C8AB,
        /// <summary>
        /// Initially used in Max Payne 3, that's why we know the name.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        SET_CAR_BOOT_OPEN = 0xFC40CBF7B90CA77C,
        /// <summary>
        /// "To burst tyres VEHICLE::SET_VEHICLE_TYRE_BURST(vehicle, 0, true, 1000.0)
        /// to burst all tyres type it 8 times where p1 = 0 to 7.
        /// 
        /// p3 seems to be how much damage it has taken. 0 doesn't deflate them, 1000 completely deflates them.
        /// 
        /// '0 = wheel_lf / bike, plane or jet front
        /// '1 = wheel_rf
        /// '2 = wheel_lm / in 6 wheels trailer, plane or jet is first one on left
        /// '3 = wheel_rm / in 6 wheels trailer, plane or jet is first one on right
        /// '4 = wheel_lr / bike rear / in 6 wheels trailer, plane or jet is last one on left
        /// '5 = wheel_rr / in 6 wheels trailer, plane or jet is last one on right
        /// '45 = 6 wheels trailer mid wheel left
        /// '47 = 6 wheels trailer mid wheel right
        ///
        /// > Vehicle vehicle
        /// > int index
        /// > BOOL onRim
        /// > float p3
        ///
        /// </summary>
        SET_VEHICLE_TYRE_BURST = 0xEC6A202EE4960385,
        /// <summary>
        /// Closes all doors of a vehicle:
        ///
        /// > Vehicle vehicle
        /// > BOOL closeInstantly
        ///
        /// </summary>
        SET_VEHICLE_DOORS_SHUT = 0x781B3D62BB013EF5,
        /// <summary>
        /// Allows you to toggle bulletproof tires.
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        SET_VEHICLE_TYRES_CAN_BURST = 0xEB9DC3C7D8596C46,
        /// <summary>
        /// doorId: see SET_VEHICLE_DOOR_SHUT
        ///
        /// > Vehicle vehicle
        /// > int doorId
        /// > BOOL loose
        /// > BOOL openInstantly
        ///
        /// </summary>
        SET_VEHICLE_DOOR_OPEN = 0x7C65DAC73C35C862,
        /// <summary>
        /// windowIndex:
        /// 0 = Front Right Window
        /// 1 = Front Left Window
        /// 2 = Back Right Window
        /// 3 = Back Left Window
        /// 4 = Unknown
        /// 5 = Unknown
        /// 6 = Windscreen
        /// 7 = Rear Windscreen
        ///
        /// > Vehicle vehicle
        /// > int windowIndex
        ///
        /// </summary>
        REMOVE_VEHICLE_WINDOW = 0xA711568EEDB43069,
        /// <summary>
        /// Roll down all the windows of the vehicle passed through the first parameter.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        ROLL_DOWN_WINDOWS = 0x85796B0549DDE156,
        /// <summary>
        /// windowIndex:
        /// 0 = Front Right Window
        /// 1 = Front Left Window
        /// 2 = Back Right Window
        /// 3 = Back Left Window
        ///
        /// > Vehicle vehicle
        /// > int windowIndex
        ///
        /// </summary>
        ROLL_DOWN_WINDOW = 0x7AD9E6CE657D69E3,
        /// <summary>
        /// Window indexes:
        /// 0 = Front Left Window
        /// 1 = Front Right Window
        /// 2 = Back Left Window
        /// 3 = Back Right Window
        ///
        /// > Vehicle vehicle
        /// > int windowIndex
        ///
        /// </summary>
        ROLL_UP_WINDOW = 0x602E548F46E24D59,
        /// <summary>
        /// `index` = 0 to 13
        /// 0 = front right window
        /// 1 = front left window
        /// 2 = rear right window
        /// 3 = rear left window
        /// 4 = unsure
        /// 5 = unsure
        /// 6 = windowscreen
        /// 7 = rear windowscreen
        /// 8 = unsure
        /// 9 = unsure
        /// 10 = unsure
        /// 11 = unsure
        /// 12 = unsure
        /// 13 = unsure
        ///
        /// > Vehicle vehicle
        /// > int index
        ///
        /// </summary>
        SMASH_VEHICLE_WINDOW = 0x9E5B5E4D2CCD2259,
        /// <summary>
        /// `index` = 0 to 13
        /// 0 = front right window
        /// 1 = front left window
        /// 2 = rear right window
        /// 3 = rear left window
        /// 4 = unsure
        /// 5 = unsure
        /// 6 = windowscreen
        /// 7 = rear windowscreen
        /// 8 = unsure
        /// 9 = unsure
        /// 10 = unsure
        /// 11 = unsure
        /// 12 = unsure
        /// 13 = unsure
        /// 
        /// Additional information: FIX_VEHICLE_WINDOW (0x140D0BB88) references an array of bone vehicle indices (0x141D4B3E0) { 2Ah, 2Bh, 2Ch, 2Dh, 2Eh, 2Fh, 28h, 29h } that correspond to: window_lf, window_rf, window_lr, window_rr, window_lm, window_rm, windscreen, windscreen_r. This array is used by most vehwindow natives.
        /// 
        /// Also, this function is coded to not work on vehicles of type: CBike, Bmx, CBoat, CTrain, and CSubmarine.
        ///
        /// > Vehicle vehicle
        /// > int index
        ///
        /// </summary>
        FIX_VEHICLE_WINDOW = 0x772282EBEB95E682,
        /// <summary>
        /// Detaches the vehicle's windscreen.
        /// For further information, see : gtaforums.com/topic/859570-glass/#entry1068894566
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        POP_OUT_VEHICLE_WINDSCREEN = 0x6D645D59FB5F5AD3,
        /// <summary>
        /// set's if the vehicle has lights or not.
        /// not an on off toggle.
        /// p1 = 0 ;vehicle normal lights, off then lowbeams, then highbeams
        /// p1 = 1 ;vehicle doesn't have lights, always off
        /// p1 = 2 ;vehicle has always on lights
        /// p1 = 3 ;or even larger like 4,5,... normal lights like =1
        /// note1: when using =2 on day it's lowbeam,highbeam
        /// but at night it's lowbeam,lowbeam,highbeam
        /// note2: when using =0 it's affected by day or night for highbeams don't exist in daytime.
        ///
        /// > Vehicle vehicle
        /// > int state
        ///
        /// </summary>
        SET_VEHICLE_LIGHTS = 0x34E710FF01247C5A,
        /// <summary>
        /// p1 can be either 0, 1 or 2.
        /// 
        /// Determines how vehicle lights behave when toggled.
        /// 
        /// 0 = Default (Lights can be toggled between off, normal and high beams)
        /// 1 = Lights Disabled (Lights are fully disabled, cannot be toggled)
        /// 2 = Always On (Lights can be toggled between normal and high beams)
        ///
        /// > Vehicle vehicle
        /// > int p1
        ///
        /// </summary>
        _SET_VEHICLE_LIGHTS_MODE = 0x1FD09E7390A74D54,
        /// <summary>
        /// multiplier = brightness of head lights.
        /// this value isn't capped afaik.
        /// 
        /// multiplier = 0.0 no lights
        /// multiplier = 1.0 default game value
        /// 
        ///
        /// > Vehicle vehicle
        /// > float multiplier
        ///
        /// </summary>
        SET_VEHICLE_LIGHT_MULTIPLIER = 0xB385454F8791F57C,
        /// <summary>
        /// This is the proper way of attaching vehicles to the car carrier, it's what Rockstar uses. Video Demo: https://www.youtube.com/watch?v=2lVEIzf7bgo
        ///
        /// > Vehicle vehicle
        /// > Vehicle trailer
        /// > float offsetX
        /// > float offsetY
        /// > float offsetZ
        /// > float coordsX
        /// > float coordsY
        /// > float coordsZ
        /// > float rotationX
        /// > float rotationY
        /// > float rotationZ
        /// > float disableCollisions
        ///
        /// </summary>
        ATTACH_VEHICLE_ON_TO_TRAILER = 0x16B5E274BDE402F8,
        /// <summary>
        /// in the decompiled scripts, seems to be always called on the vehicle right after being attached to a trailer.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        SET_TRAILER_LEGS_RAISED = 0x95CF53B3D687F9FA,
        /// <summary>
        /// tyreIndex = 0 to 4 on normal vehicles
        /// 
        /// '0 = wheel_lf / bike, plane or jet front
        /// '1 = wheel_rf
        /// '2 = wheel_lm / in 6 wheels trailer, plane or jet is first one on left
        /// '3 = wheel_rm / in 6 wheels trailer, plane or jet is first one on right
        /// '4 = wheel_lr / bike rear / in 6 wheels trailer, plane or jet is last one on left
        /// '5 = wheel_rr / in 6 wheels trailer, plane or jet is last one on right
        /// '45 = 6 wheels trailer mid wheel left
        /// '47 = 6 wheels trailer mid wheel right
        ///
        /// > Vehicle vehicle
        /// > int tyreIndex
        ///
        /// </summary>
        SET_VEHICLE_TYRE_FIXED = 0x6E13FC662B882D1D,
        /// <summary>
        /// Sets a vehicle's license plate text.  8 chars maximum.
        /// 
        /// Example:
        /// Ped playerPed = PLAYER::PLAYER_PED_ID();
        /// Vehicle veh = PED::GET_VEHICLE_PED_IS_USING(playerPed);
        /// char *plateText = "KING";
        /// VEHICLE::SET_VEHICLE_NUMBER_PLATE_TEXT(veh, plateText);
        ///
        /// > Vehicle vehicle
        /// > const char* plateText
        ///
        /// </summary>
        SET_VEHICLE_NUMBER_PLATE_TEXT = 0x95A88F0B409CDA47,
        /// <summary>
        /// Returns the license plate text from a vehicle.  8 chars maximum.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_VEHICLE_NUMBER_PLATE_TEXT = 0x7CE1CCB9B293020E,
        /// <summary>
        /// Returns the number of *types* of licence plates, enumerated below in SET_VEHICLE_NUMBER_PLATE_TEXT_INDEX.
        ///
        ///
        /// </summary>
        GET_NUMBER_OF_VEHICLE_NUMBER_PLATES = 0x4C4D6B2644F458CB,
        /// <summary>
        /// Plates:
        /// Blue/White - 0
        /// Yellow/black - 1
        /// Yellow/Blue - 2
        /// Blue/White2 - 3
        /// Blue/White3 - 4
        /// Yankton - 5
        ///
        /// > Vehicle vehicle
        /// > int plateIndex
        ///
        /// </summary>
        SET_VEHICLE_NUMBER_PLATE_TEXT_INDEX = 0x9088EB5A43FFB0A1,
        /// <summary>
        /// Returns the PlateType of a vehicle
        ///       Blue_on_White_1 = 3,
        ///       Blue_on_White_2 = 0,
        ///       Blue_on_White_3 = 4,
        ///       Yellow_on_Blue = 2,
        ///        Yellow_on_Black = 1,
        ///       North_Yankton = 5,
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_VEHICLE_NUMBER_PLATE_TEXT_INDEX = 0xF11BC2DD9A3E7195,
        /// <summary>
        /// Train models HAVE TO be loaded (requested) before you use this.
        /// For variation 15 - request:
        /// 
        /// freight
        /// freightcar
        /// freightgrain
        /// freightcont1
        /// freightcont2
        /// freighttrailer
        /// 
        /// 
        ///
        /// > int variation
        /// > float x
        /// > float y
        /// > float z
        /// > BOOL direction
        /// > Any p5
        /// > Any p6
        ///
        /// </summary>
        CREATE_MISSION_TRAIN = 0x63C6CCA8E68AE8C8,
        /// <summary>
        /// Toggles whether ambient trains can spawn on the specified track or not
        /// 
        /// `trackId` is the internal id of the train track to switch.
        /// `state` is whether ambient trains can spawn or not
        /// 
        /// trackIds
        /// 0 (`trains1.dat`) Main track around SA
        /// 1 (`trains2.dat`) Davis Quartz Quarry branch
        /// 2 (`trains3.dat`) Second track alongside live track along Roy Lewenstein Blv.
        /// 3 (`trains4.dat`) Metro track circuit
        /// 4 (`trains5.dat`) Branch in Mirror Park Railyard
        /// 5 (`trains6.dat`) Branch in Mirror Park Railyard
        /// 6 (`trains7.dat`) LS branch to Mirror Park Railyard
        /// 7 (`trains8.dat`) Overground part of metro track along Forum Dr.
        /// 8 (`trains9.dat`) Branch to Mirror Park Railyard
        /// 9 (`trains10.dat`) Yankton train
        /// 10 (`trains11.dat`) Part of metro track near mission row
        /// 11 (`trains12.dat`) Yankton prologue mission train
        ///
        /// > int trackId
        /// > BOOL state
        ///
        /// </summary>
        SWITCH_TRAIN_TRACK = 0xFD813BB7DB977F20,
        /// <summary>
        /// Only called once inside main_persitant with the parameters p0 = 0, p1 = 120000
        /// 
        /// trackIndex: 0 - 26
        ///
        /// > int trackIndex
        /// > int frequency
        ///
        /// </summary>
        SET_TRAIN_TRACK_SPAWN_FREQUENCY = 0x21973BBF8D17EDFA,
        /// <summary>
        /// Maximum amount of vehicles with vehicle stuck check appears to be 16.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        DOES_VEHICLE_HAVE_STUCK_VEHICLE_CHECK = 0x57E4C39DE5EE8470,
        /// <summary>
        /// See REQUEST_VEHICLE_RECORDING
        ///
        /// > int recording
        /// > const char* script
        ///
        /// </summary>
        GET_VEHICLE_RECORDING_ID = 0x21543C612379DB3C,
        /// <summary>
        /// Request the vehicle recording defined by the lowercase format string "%s%03d.yvr". For example, REQUEST_VEHICLE_RECORDING(1, "FBIs1UBER") corresponds to fbis1uber001.yvr.
        /// For all vehicle recording/playback natives, "script" is a common prefix that usually corresponds to the script/mission the recording is used in, "recording" is its int suffix, and "id" (e.g., in native GET_TOTAL_DURATION_OF_VEHICLE_RECORDING_ID) corresponds to a unique identifier within the recording streaming module.
        /// Note that only 24 recordings (hardcoded in multiple places) can ever active at a given time before clobbering begins.
        ///
        /// > int recording
        /// > const char* script
        ///
        /// </summary>
        REQUEST_VEHICLE_RECORDING = 0xAF514CABE74CBF15,
        /// <summary>
        /// See REQUEST_VEHICLE_RECORDING
        ///
        /// > int recording
        /// > const char* script
        ///
        /// </summary>
        HAS_VEHICLE_RECORDING_BEEN_LOADED = 0x300D614A4C785FC4,
        /// <summary>
        /// See REQUEST_VEHICLE_RECORDING
        ///
        /// > int recording
        /// > const char* script
        ///
        /// </summary>
        REMOVE_VEHICLE_RECORDING = 0xF1160ACCF98A3FC8,
        /// <summary>
        /// This native does no interpolation between pathpoints. The same position will be returned for all times up to the next pathpoint in the recording.
        /// 
        /// See REQUEST_VEHICLE_RECORDING
        ///
        /// > int recording
        /// > float time
        /// > const char* script
        ///
        /// </summary>
        GET_POSITION_OF_VEHICLE_RECORDING_AT_TIME = 0xD242728AA6F0FBA2,
        /// <summary>
        /// This native does no interpolation between pathpoints. The same rotation will be returned for all times up to the next pathpoint in the recording.
        /// 
        /// See REQUEST_VEHICLE_RECORDING
        ///
        /// > int recording
        /// > float time
        /// > const char* script
        ///
        /// </summary>
        GET_ROTATION_OF_VEHICLE_RECORDING_AT_TIME = 0x2058206FBE79A8AD,
        /// <summary>
        /// See REQUEST_VEHICLE_RECORDING
        ///
        /// > int recording
        /// > const char* script
        ///
        /// </summary>
        GET_TOTAL_DURATION_OF_VEHICLE_RECORDING = 0x0E48D1C262390950,
        /// <summary>
        /// Distance traveled in the vehicles current recording.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_POSITION_IN_RECORDING = 0x2DACD605FC681475,
        /// <summary>
        /// Can be used with GET_TOTAL_DURATION_OF_VEHICLE_RECORDING{_ID} to compute a percentage.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_TIME_POSITION_IN_RECORDING = 0x5746F3A7AB7FE544,
        /// <summary>
        /// p3 is some flag related to 'trailers' (invokes CVehicle::GetTrailer).
        /// 
        /// See REQUEST_VEHICLE_RECORDING
        ///
        /// > Vehicle vehicle
        /// > int recording
        /// > const char* script
        /// > BOOL p3
        ///
        /// </summary>
        START_PLAYBACK_RECORDED_VEHICLE = 0x3F878F92B3A7A071,
        /// <summary>
        /// flags requires further research, e.g., 0x4/0x8 are related to the AI driving task and 0x20 is internally set and interacts with dynamic entity components.
        /// 
        /// time, often zero and capped at 500, is related to SET_PLAYBACK_TO_USE_AI_TRY_TO_REVERT_BACK_LATER
        ///
        /// > Vehicle vehicle
        /// > int recording
        /// > const char* script
        /// > int flags
        /// > int time
        /// > int drivingStyle
        ///
        /// </summary>
        START_PLAYBACK_RECORDED_VEHICLE_WITH_FLAGS = 0x7D80FD645D4DA346,
        /// <summary>
        /// Often called after START_PLAYBACK_RECORDED_VEHICLE and SKIP_TIME_IN_PLAYBACK_RECORDED_VEHICLE; similar in use to FORCE_ENTITY_AI_AND_ANIMATION_UPDATE.
        ///
        /// > Vehicle vehicle
        /// > BOOL p1
        ///
        /// </summary>
        FORCE_PLAYBACK_RECORDED_VEHICLE_UPDATE = 0x1F2E4E06DEA8992B,
        /// <summary>
        /// AI abides by the provided driving style (e.g., stopping at red lights or waiting behind traffic) while executing the specificed vehicle recording.
        /// 
        /// 0x1F2E4E06DEA8992B is a related native that deals with the AI physics for such recordings.
        ///
        /// > Vehicle vehicle
        /// > int recording
        /// > const char* script
        /// > float speed
        /// > int drivingStyle
        ///
        /// </summary>
        START_PLAYBACK_RECORDED_VEHICLE_USING_AI = 0x29DE5FA52D00428C,
        /// <summary>
        /// SET_TIME_POSITION_IN_RECORDING can be emulated by: desired_time - GET_TIME_POSITION_IN_RECORDING(vehicle)
        ///
        /// > Vehicle vehicle
        /// > float time
        ///
        /// </summary>
        SKIP_TIME_IN_PLAYBACK_RECORDED_VEHICLE = 0x9438F7AD68771A20,
        /// <summary>
        /// Identical to SET_PLAYBACK_TO_USE_AI_TRY_TO_REVERT_BACK_LATER with 0 as arguments for p1 and p3.
        ///
        /// > Vehicle vehicle
        /// > int drivingStyle
        ///
        /// </summary>
        SET_PLAYBACK_TO_USE_AI = 0xA549C3B37EA28131,
        /// <summary>
        /// Time is number of milliseconds before reverting, zero for indefinitely.
        ///
        /// > Vehicle vehicle
        /// > int time
        /// > int drivingStyle
        /// > BOOL p3
        ///
        /// </summary>
        SET_PLAYBACK_TO_USE_AI_TRY_TO_REVERT_BACK_LATER = 0x6E63860BBB190730,
        /// <summary>
        /// seems to make the vehicle stop spawning naturally in traffic. Here's an essential example:
        /// 
        /// VEHICLE::SET_VEHICLE_MODEL_IS_SUPPRESSED(MISC::GET_HASH_KEY("taco"), true);
        /// 
        /// god I hate taco vans
        /// 
        /// Confirmed to work? Needs to be looped? Can not get it to work.
        ///
        /// > Hash model
        /// > BOOL suppressed
        ///
        /// </summary>
        SET_VEHICLE_MODEL_IS_SUPPRESSED = 0x0FC2D89AC25A5814,
        /// <summary>
        /// Gets a random vehicle in a sphere at the specified position, of the specified radius.
        /// 
        /// x: The X-component of the position of the sphere.
        /// y: The Y-component of the position of the sphere.
        /// z: The Z-component of the position of the sphere.
        /// radius: The radius of the sphere. Max is 9999.9004.
        /// modelHash: The vehicle model to limit the selection to. Pass 0 for any model.
        /// flags: The bitwise flags that modifies the behaviour of this function.
        /// 
        /// Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        /// > Hash modelHash
        /// > int flags
        ///
        /// </summary>
        GET_RANDOM_VEHICLE_IN_SPHERE = 0x386F6CE5BAF6091C,
        /// <summary>
        /// Example usage
        /// VEHICLE::GET_CLOSEST_VEHICLE(x, y, z, radius, hash, unknown leave at 70) 
        /// 
        /// x, y, z: Position to get closest vehicle to.
        /// radius: Max radius to get a vehicle.
        /// modelHash: Limit to vehicles with this model. 0 for any.
        /// flags: The bitwise flags altering the function's behaviour.
        /// 
        /// Does not return police cars or helicopters.
        /// 
        /// It seems to return police cars for me, does not seem to return helicopters, planes or boats for some reason
        /// 
        /// Only returns non police cars and motorbikes with the flag set to 70 and modelHash to 0. ModelHash seems to always be 0 when not a modelHash in the scripts, as stated above. 
        /// 
        /// These flags were found in the b617d scripts: 0,2,4,6,7,23,127,260,2146,2175,12294,16384,16386,20503,32768,67590,67711,98309,100359.
        /// Converted to binary, each bit probably represents a flag as explained regarding another native here: gtaforums.com/topic/822314-guide-driving-styles
        /// 
        /// Conversion of found flags to binary: pastebin.com/kghNFkRi
        /// 
        /// At exactly 16384 which is 0100000000000000 in binary and 4000 in hexadecimal only planes are returned. 
        /// 
        /// It's probably more convenient to use worldGetAllVehicles(int *arr, int arrSize) and check the shortest distance yourself and sort if you want by checking the vehicle type with for example VEHICLE::IS_THIS_MODEL_A_BOAT
        /// 
        /// -------------------------------------------------------------------------
        /// 
        /// Conclusion: This native is not worth trying to use. Use something like this instead: pastebin.com/xiFdXa7h
        /// 
        /// Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        /// > Hash modelHash
        /// > int flags
        ///
        /// </summary>
        GET_CLOSEST_VEHICLE = 0xF73EB622C4F1689B,
        /// <summary>
        /// Corrected p1. it's basically the 'carriage/trailer number'. So if the train has 3 trailers you'd call the native once with a var or 3 times with 1, 2, 3.
        ///
        /// > Vehicle train
        /// > int trailerNumber
        ///
        /// </summary>
        GET_TRAIN_CARRIAGE = 0x08AAFD0814722BC3,
        /// <summary>
        /// p1 is always 0
        ///
        /// > Vehicle* train
        /// > BOOL p1
        ///
        /// </summary>
        SET_MISSION_TRAIN_AS_NO_LONGER_NEEDED = 0xBBE7648349B49BE8,
        /// <summary>
        /// Checks if model is a boat, then checks for FLAG_IS_JETSKI.
        ///
        /// > Hash model
        ///
        /// </summary>
        IS_THIS_MODEL_A_JETSKI = 0x9537097412CF75FE,
        /// <summary>
        /// To check if the model is an amphibious car, see gtaforums.com/topic/717612-v-scriptnative-documentation-and-research/page-33#entry1069317363 (for build 944 and above only!)
        ///
        /// > Hash model
        ///
        /// </summary>
        IS_THIS_MODEL_A_CAR = 0x7F6DB52EEFC96DF8,
        /// <summary>
        /// Equivalent of SET_HELI_BLADES_SPEED(vehicleHandle, 1.0f);
        /// 
        /// this native works on planes to?
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        SET_HELI_BLADES_FULL_SPEED = 0xA178472EBB8AE60D,
        /// <summary>
        /// Sets the speed of the helicopter blades in percentage of the full speed.
        /// 
        /// vehicleHandle: The helicopter.
        /// speed: The speed in percentage, 0.0f being 0% and 1.0f being 100%.
        ///
        /// > Vehicle vehicle
        /// > float speed
        ///
        /// </summary>
        SET_HELI_BLADES_SPEED = 0xFD280B4D7F3ABC4D,
        /// <summary>
        /// This has not yet been tested - it's just an assumption of what the types could be.
        ///
        /// > Vehicle vehicle
        /// > BOOL state
        ///
        /// </summary>
        SET_VEHICLE_CAN_BE_TARGETTED = 0x3750146A28097A82,
        /// <summary>
        /// Dirt level 0..15
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_VEHICLE_DIRT_LEVEL = 0x8F17BC8BA08DA62B,
        /// <summary>
        /// You can't use values greater than 15.0
        /// You can see why here: pastebin.com/Wbn34fGD
        /// 
        /// Also, R* does (float)(rand() % 15) to get a random dirt level when generating a vehicle.
        ///
        /// > Vehicle vehicle
        /// > float dirtLevel
        ///
        /// </summary>
        SET_VEHICLE_DIRT_LEVEL = 0x79D3B596FE44EE8B,
        /// <summary>
        /// Appears to return true if the vehicle has any damage, including cosmetically.
        /// 
        /// GET_*
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _IS_VEHICLE_DAMAGED = 0xBCDC5017D3CE1E9E,
        /// <summary>
        /// doorId: see SET_VEHICLE_DOOR_SHUT
        ///
        /// > Vehicle vehicle
        /// > int doorId
        ///
        /// </summary>
        IS_VEHICLE_DOOR_FULLY_OPEN = 0x3E933CFF7B111C22,
        /// <summary>
        /// Starts or stops the engine on the specified vehicle.
        /// 
        /// vehicle: The vehicle to start or stop the engine on.
        /// value: true to turn the vehicle on; false to turn it off.
        /// instantly: if true, the vehicle will be set to the state immediately; otherwise, the current driver will physically turn on or off the engine.
        /// disableAutoStart: If true, the system will prevent the engine from starting when the player got into it.
        /// 
        /// from what I've tested when I do this to a helicopter the propellers turn off after the engine has started. so is there any way to keep the heli propellers on?
        ///
        /// > Vehicle vehicle
        /// > BOOL value
        /// > BOOL instantly
        /// > BOOL disableAutoStart
        ///
        /// </summary>
        SET_VEHICLE_ENGINE_ON = 0x2497C4717C8B881E,
        /// <summary>
        /// doorId: see SET_VEHICLE_DOOR_SHUT
        ///
        /// > Vehicle vehicle
        /// > int doorId
        /// > int speed
        /// > float angle
        ///
        /// </summary>
        SET_VEHICLE_DOOR_CONTROL = 0xF2BFA0430F0A0FCB,
        /// <summary>
        /// doorId: see SET_VEHICLE_DOOR_SHUT
        ///
        /// > Vehicle vehicle
        /// > int doorId
        /// > BOOL p2
        /// > BOOL p3
        /// > BOOL p4
        ///
        /// </summary>
        SET_VEHICLE_DOOR_LATCHED = 0xA5A9653A8D2CAF48,
        /// <summary>
        /// doorId: see SET_VEHICLE_DOOR_SHUT
        ///
        /// > Vehicle vehicle
        /// > int doorId
        ///
        /// </summary>
        GET_VEHICLE_DOOR_ANGLE_RATIO = 0xFE3F9C29F7B32BD5,
        /// <summary>
        /// doorId: see SET_VEHICLE_DOOR_SHUT
        ///
        /// > Vehicle vehicle
        /// > int doord
        ///
        /// </summary>
        GET_PED_USING_VEHICLE_DOOR = 0x218297BF0CFD853B,
        /// <summary>
        /// enum eDoorId
        /// {
        /// 	VEH_EXT_DOOR_INVALID_ID = -1,
        /// 	VEH_EXT_DOOR_DSIDE_F,
        /// 	VEH_EXT_DOOR_DSIDE_R,
        /// 	VEH_EXT_DOOR_PSIDE_F,
        /// 	VEH_EXT_DOOR_PSIDE_R,
        /// 	VEH_EXT_BONNET,
        /// 	VEH_EXT_BOOT
        /// };
        ///
        /// > Vehicle vehicle
        /// > int doorId
        /// > BOOL closeInstantly
        ///
        /// </summary>
        SET_VEHICLE_DOOR_SHUT = 0x93D9BD300D7789E5,
        /// <summary>
        /// doorId: see SET_VEHICLE_DOOR_SHUT
        ///
        /// > Vehicle vehicle
        /// > int doorId
        /// > BOOL deleteDoor
        ///
        /// </summary>
        SET_VEHICLE_DOOR_BROKEN = 0xD4D4F6A4AB575A33,
        /// <summary>
        /// Actually number of color combinations
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_NUMBER_OF_VEHICLE_COLOURS = 0x3B963160CD65D41E,
        /// <summary>
        /// Sets the selected vehicle's colors to their default value (specific variant specified using the colorCombination parameter).
        /// Range of possible values for colorCombination is currently unknown, I couldn't find where these values are stored either (Disquse's guess was vehicles.meta but I haven't seen it in there.)
        ///
        /// > Vehicle vehicle
        /// > int colorCombination
        ///
        /// </summary>
        SET_VEHICLE_COLOUR_COMBINATION = 0x33E8CD3322E2FE31,
        /// <summary>
        /// `color`: is the paint index for the vehicle.
        /// Paint index goes from 0 to 12.
        /// Be aware that it only works on xenon lights. Example: https://i.imgur.com/yV3cpG9.png
        ///
        /// > Vehicle vehicle
        /// > int colorIndex
        ///
        /// </summary>
        _SET_VEHICLE_XENON_LIGHTS_COLOR = 0xE41033B25D003A07,
        /// <summary>
        /// Returns the headlight color index from the vehicle. Value between 0, 12.
        /// Use _SET_VEHICLE_HEADLIGHTS_COLOUR to set the headlights color for the vehicle.
        /// Must enable xenon headlights before it'll take affect.
        /// 
        /// Returns an int, value between 0-12 or 255 if no color is set.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _GET_VEHICLE_XENON_LIGHTS_COLOR = 0x3DFF319A831E0CDB,
        /// <summary>
        /// Setting this to false, makes the specified vehicle to where if you press Y your character doesn't even attempt the animation to enter the vehicle. Hence it's not considered aka ignored.
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        SET_VEHICLE_IS_CONSIDERED_BY_PLAYER = 0x31B927BBC44156CD,
        /// <summary>
        /// Not present in the retail version! It's just a nullsub.
        /// 
        /// p0 always true (except in one case)
        /// successIndicator: 0 if success, -1 if failed
        ///
        /// > BOOL p0
        /// > Hash* modelHash
        /// > int* successIndicator
        ///
        /// </summary>
        GET_RANDOM_VEHICLE_MODEL_IN_MEMORY = 0x055BF0AC0C34F4FD,
        /// <summary>
        /// enum VehicleLockStatus = {
        ///     None = 0,
        ///     Unlocked = 1,
        ///     Locked = 2,
        ///     LockedForPlayer = 3,
        ///     StickPlayerInside = 4, -- Doesn't allow players to exit the vehicle with the exit vehicle key.
        ///     CanBeBrokenInto = 7, -- Can be broken into the car. If the glass is broken, the value will be set to 1
        ///     CanBeBrokenIntoPersist = 8, -- Can be broken into persist
        ///     CannotBeTriedToEnter = 10, -- Cannot be tried to enter (Nothing happens when you press the vehicle enter key).
        /// }
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_VEHICLE_DOOR_LOCK_STATUS = 0x25BC98A59C2EA962,
        /// <summary>
        /// Returns vehicle door destroy type previously set with _SET_VEHICLE_DOOR_DESTROY_TYPE
        ///
        /// > Vehicle vehicle
        /// > int doorId
        ///
        /// </summary>
        _GET_VEHICLE_DOOR_DESTROY_TYPE = 0xCA4AC3EAAE46EC7B,
        /// <summary>
        /// doorID starts at 0, not seeming to skip any numbers. Four door vehicles intuitively range from 0 to 3.
        ///
        /// > Vehicle veh
        /// > int doorID
        ///
        /// </summary>
        IS_VEHICLE_DOOR_DAMAGED = 0xB8E181E559464527,
        /// <summary>
        /// doorId: see SET_VEHICLE_DOOR_SHUT
        ///
        /// > Vehicle vehicle
        /// > int doorId
        /// > BOOL isBreakable
        ///
        /// </summary>
        _SET_VEHICLE_DOOR_CAN_BREAK = 0x2FA133A4A9D37ED8,
        /// <summary>
        /// Usage:
        /// 
        /// public bool isCopInRange(Vector3 Location, float Range)
        ///         {
        ///             return Function.Call<bool>(Hash.IS_COP_PED_IN_AREA_3D, Location.X - Range, Location.Y - Range, Location.Z - Range, Location.X + Range, Location.Y + Range, Location.Z + Range);
        ///         }
        ///
        /// > float x1
        /// > float x2
        /// > float y1
        /// > float y2
        /// > float z1
        /// > float z2
        ///
        /// </summary>
        IS_COP_VEHICLE_IN_AREA_3D = 0x7EEF65D5F153E26A,
        /// <summary>
        ///  Public Function isVehicleOnAllWheels(vh As Vehicle) As Boolean
        ///         Return Native.Function.Call(Of Boolean)(Hash.IS_VEHICLE_ON_ALL_WHEELS, vh)
        ///     End Function
        /// 
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        IS_VEHICLE_ON_ALL_WHEELS = 0xB104CD1BABF302E2,
        /// <summary>
        /// Returns `nMonetaryValue` from handling.meta for specific model.
        ///
        /// > Hash vehicleModel
        ///
        /// </summary>
        _GET_VEHICLE_MODEL_MONETARY_VALUE = 0x5873C14A52D74236,
        /// <summary>
        /// makes the train all jumbled up and derailed as it moves on the tracks (though that wont stop it from its normal operations)
        ///
        /// > Vehicle train
        /// > BOOL toggle
        ///
        /// </summary>
        SET_RENDER_TRAIN_AS_DERAILED = 0x317B11A312DF5534,
        /// <summary>
        /// They use the same color indexs as SET_VEHICLE_COLOURS.
        ///
        /// > Vehicle vehicle
        /// > int pearlescentColor
        /// > int wheelColor
        ///
        /// </summary>
        SET_VEHICLE_EXTRA_COLOURS = 0x2036F561ADD12E33,
        /// <summary>
        /// This fixes a vehicle.
        /// If the vehicle's engine's broken then you cannot fix it with this native.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        SET_VEHICLE_FIXED = 0x115722B1B9C14C1C,
        /// <summary>
        /// This fixes the deformation of a vehicle but the vehicle health doesn't improve
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        SET_VEHICLE_DEFORMATION_FIXED = 0x953DA1E1B12C0491,
        /// <summary>
        /// Locks the vehicle's steering to the desired angle, explained below.
        /// 
        /// Requires to be called onTick. Steering is unlocked the moment the function stops being called on the vehicle.
        /// 
        /// Steer bias:
        /// -1.0 = full right
        /// 0.0 = centered steering
        /// 1.0 = full left
        ///
        /// > Vehicle vehicle
        /// > float value
        ///
        /// </summary>
        SET_VEHICLE_STEER_BIAS = 0x42A8EC77D5150CBE,
        /// <summary>
        /// Note: only some vehicle have extras
        /// extra ids are from 1 - 9 depending on the vehicle
        /// 
        /// -------------------------------------------------
        /// 
        /// ^ not sure if outdated or simply wrong. Max extra ID for b944 is 14
        /// 
        /// -------------------------------------------------
        /// p2 is not a on/off toggle. mostly 0 means on and 1 means off.
        /// not sure if it really should be a BOOL.
        ///
        /// > Vehicle vehicle
        /// > int extraId
        /// > BOOL disable
        ///
        /// </summary>
        SET_VEHICLE_EXTRA = 0x7EE3A3C5E4A40CC9,
        /// <summary>
        /// Checks via CVehicleModelInfo
        ///
        /// > Vehicle vehicle
        /// > int extraId
        ///
        /// </summary>
        DOES_EXTRA_EXIST = 0x1262D55792428154,
        /// <summary>
        /// Checks if vehicle tyre at index exists. Also returns false if tyre was removed.
        ///
        /// > Vehicle vehicle
        /// > int tyreIndex
        ///
        /// </summary>
        _DOES_VEHICLE_TYRE_EXIST = 0x534E36D4DB9ECC5D,
        /// <summary>
        /// 0 -> up
        /// 1 -> lowering down
        /// 2 -> down
        /// 3 -> raising up
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_CONVERTIBLE_ROOF_STATE = 0xF8C397922FC03F41,
        /// <summary>
        /// p1 is false almost always.
        /// 
        /// However, in launcher_carwash/carwash1/carwash2 scripts, p1 is true and is accompanied by DOES_VEHICLE_HAVE_ROOF 
        ///
        /// > Vehicle vehicle
        /// > BOOL p1
        ///
        /// </summary>
        IS_VEHICLE_A_CONVERTIBLE = 0x52F357A30698BCCE,
        /// <summary>
        /// Transforms the `stormberg` to its "water vehicle" variant. If the vehicle is already in that state then the vehicle transformation audio will still play, but the vehicle won't change at all.
        ///
        /// > Vehicle vehicle
        /// > BOOL noAnimation
        ///
        /// </summary>
        _TRANSFORM_VEHICLE_TO_SUBMARINE = 0xBE4C854FFDB6EEBE,
        /// <summary>
        /// Transforms the `stormberg` to its "road vehicle" variant. If the vehicle is already in that state then the vehicle transformation audio will still play, but the vehicle won't change at all.
        ///
        /// > Vehicle vehicle
        /// > BOOL noAnimation
        ///
        /// </summary>
        _TRANSFORM_SUBMARINE_TO_VEHICLE = 0x2A69FFD1B42BFF9E,
        /// <summary>
        /// Is this for red lights only?  more testing required.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        IS_VEHICLE_STOPPED_AT_TRAFFIC_LIGHTS = 0x2959F696AE390A99,
        /// <summary>
        /// Apply damage to vehicle at a location. Location is relative to vehicle model (not world).
        /// 
        /// Radius of effect damage applied in a sphere at impact location
        /// When `focusOnModel` set to `true`, the damage sphere will travel towards the vehicle from the given point, thus guaranteeing an impact
        ///
        /// > Vehicle vehicle
        /// > float xOffset
        /// > float yOffset
        /// > float zOffset
        /// > float damage
        /// > float radius
        /// > BOOL focusOnModel
        ///
        /// </summary>
        SET_VEHICLE_DAMAGE = 0xA1DD317EA8FD4F29,
        /// <summary>
        /// Returns 1000.0 if the function is unable to get the address of the specified vehicle or if it's not a vehicle.
        /// 
        /// Minimum: -4000
        /// Maximum: 1000
        /// 
        /// -4000: Engine is destroyed
        /// 0 and below: Engine catches fire and health rapidly declines
        /// 300: Engine is smoking and losing functionality
        /// 1000: Engine is perfect
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_VEHICLE_ENGINE_HEALTH = 0xC45D23BAF168AAB8,
        /// <summary>
        /// 1000 is max health
        /// Begins leaking gas at around 650 health
        /// -999.90002441406 appears to be minimum health, although nothing special occurs <- false statement
        /// 
        /// -------------------------
        /// Minimum: -4000
        /// Maximum: 1000
        /// 
        /// -4000: Engine is destroyed
        /// 0 and below: Engine catches fire and health rapidly declines
        /// 300: Engine is smoking and losing functionality
        /// 1000: Engine is perfect
        ///
        /// > Vehicle vehicle
        /// > float health
        ///
        /// </summary>
        SET_VEHICLE_ENGINE_HEALTH = 0x45F6D8EEF34ABEF1,
        /// <summary>
        /// Works just like SET_VEHICLE_ENGINE_HEALTH, didn't saw any difference. But this native works only for planes.
        ///
        /// > Vehicle vehicle
        /// > float health
        ///
        /// </summary>
        _SET_PLANE_ENGINE_HEALTH = 0x2A86A0475B6A1434,
        /// <summary>
        /// 1000 is max health
        /// Begins leaking gas at around 650 health
        /// -999.90002441406 appears to be minimum health, although nothing special occurs
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_VEHICLE_PETROL_TANK_HEALTH = 0x7D5DABE888D2D074,
        /// <summary>
        /// 1000 is max health
        /// Begins leaking gas at around 650 health
        /// -999.90002441406 appears to be minimum health, although nothing special occurs
        ///
        /// > Vehicle vehicle
        /// > float health
        ///
        /// </summary>
        SET_VEHICLE_PETROL_TANK_HEALTH = 0x70DB57649FA8D0D8,
        /// <summary>
        /// p1 can be anywhere from 0 to 3 in the scripts. p2 is generally somewhere in the 1000 to 10000 range.
        ///
        /// > Vehicle vehicle
        /// > int p1
        /// > int p2
        ///
        /// </summary>
        IS_VEHICLE_STUCK_TIMER_UP = 0x679BE1DAF71DA874,
        /// <summary>
        /// The inner function has a switch on the second parameter. It's the stuck timer index.
        /// 
        /// Here's some pseudo code I wrote for the inner function:
        /// void __fastcall NATIVE_RESET_VEHICLE_STUCK_TIMER_INNER(CUnknown* unknownClassInVehicle, int timerIndex)
        /// {
        ///  switch (timerIndex)
        ///    {
        ///  case 0:
        ///        unknownClassInVehicle->FirstStuckTimer = (WORD)0u;
        ///  case 1:
        ///        unknownClassInVehicle->SecondStuckTimer = (WORD)0u;
        ///     case 2:
        ///        unknownClassInVehicle->ThirdStuckTimer = (WORD)0u;
        ///  case 3:
        ///        unknownClassInVehicle->FourthStuckTimer = (WORD)0u;
        ///     case 4:
        ///        unknownClassInVehicle->FirstStuckTimer = (WORD)0u;
        ///      unknownClassInVehicle->SecondStuckTimer = (WORD)0u;
        ///         unknownClassInVehicle->ThirdStuckTimer = (WORD)0u;
        ///      unknownClassInVehicle->FourthStuckTimer = (WORD)0u;
        ///         break;
        ///     };
        /// }
        ///
        /// > Vehicle vehicle
        /// > int nullAttributes
        ///
        /// </summary>
        RESET_VEHICLE_STUCK_TIMER = 0xD7591B0065AFAA7A,
        /// <summary>
        /// p1 is always 0 in the scripts.
        /// 
        /// p1 = check if vehicle is on fire
        ///
        /// > Vehicle vehicle
        /// > BOOL isOnFireCheck
        ///
        /// </summary>
        IS_VEHICLE_DRIVEABLE = 0x4C241E39B23DF959,
        /// <summary>
        /// Sounds the horn for the specified vehicle.
        /// 
        /// vehicle: The vehicle to activate the horn for.
        /// mode: The hash of "NORMAL" or "HELDDOWN". Can be 0.
        /// duration: The duration to sound the horn, in milliseconds.
        /// 
        /// Note: If a player is in the vehicle, it will only sound briefly.
        ///
        /// > Vehicle vehicle
        /// > int duration
        /// > Hash mode
        /// > BOOL forever
        ///
        /// </summary>
        START_VEHICLE_HORN = 0x9C8C6504B5B63D2C,
        /// <summary>
        /// If set to TRUE, it seems to suppress door noises and doesn't allow the horn to be continuous.
        /// 
        /// -Doesn't seem to suppress door noises for me, at least with the vehicle add-on I tried
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_VEHICLE_SILENT = 0x9D44FCCE98450843,
        /// <summary>
        /// if true, axles won't bend.
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        SET_VEHICLE_HAS_STRONG_AXLES = 0x92F0CF722BC4202F,
        /// <summary>
        /// Returns model name of vehicle in all caps. Needs to be displayed through localizing text natives to get proper display name.
        /// -----------------------------------------------------------------------------------------------------------------------------------------
        /// While often the case, this does not simply return the model name of the vehicle (which could be hashed to return the model hash). Variations of the same vehicle may also use the same display name.
        /// -----------------------------------------------------------------------------------------------------------------------------------------
        /// 
        /// Returns "CARNOTFOUND" if the hash doesn't match a vehicle hash.
        /// 
        /// Using HUD::_GET_LABEL_TEXT, you can get the localized name.
        /// 
        /// Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
        ///
        /// > Hash modelHash
        ///
        /// </summary>
        GET_DISPLAY_NAME_FROM_VEHICLE_MODEL = 0xB215AAC32D25D019,
        /// <summary>
        /// Will return a vehicle's manufacturer display label.
        /// Returns "CARNOTFOUND" if the hash doesn't match a vehicle hash.
        /// 
        /// Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
        ///
        /// > Hash modelHash
        ///
        /// </summary>
        _GET_MAKE_NAME_FROM_VEHICLE_MODEL = 0xF7AF4F159FF99F97,
        /// <summary>
        /// The only example I can find of this function in the scripts, is this:
        /// 
        /// struct _s = VEHICLE::GET_VEHICLE_DEFORMATION_AT_POS(rPtr((A_0) + 4), 1.21f, 6.15f, 0.3f);
        /// 
        /// -----------------------------------------------------------------------------------------------------------------------------------------
        /// PC scripts:
        /// 
        /// v_5/*{3}*/ = VEHICLE::GET_VEHICLE_DEFORMATION_AT_POS(a_0._f1, 1.21, 6.15, 0.3);
        ///
        /// > Vehicle vehicle
        /// > float offsetX
        /// > float offsetY
        /// > float offsetZ
        ///
        /// </summary>
        GET_VEHICLE_DEFORMATION_AT_POS = 0x4EC6CFBC7B2E9536,
        /// <summary>
        /// -1 = no livery
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_VEHICLE_LIVERY = 0x2BB9230590DA5E8A,
        /// <summary>
        /// Returns -1 if the vehicle has no livery
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_VEHICLE_LIVERY_COUNT = 0x87B63E25A529D526,
        /// <summary>
        /// Used to set the tornado custom (convertible) rooftop livery.
        /// 
        /// Livery value that works for tornado custom is between 0 and 9 from what i can tell. Maybe 0-8 even.
        /// 
        /// Might work on other custom vehicles but im not sure what those might be, only confirmed it working with the tornado custom.
        ///
        /// > Vehicle vehicle
        /// > int livery
        ///
        /// </summary>
        _SET_VEHICLE_ROOF_LIVERY = 0xA6D3A8750DC73270,
        /// <summary>
        /// Returns index of the current vehicle's rooftop livery. A getter for _SET_VEHICLE_ROOF_LIVERY.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _GET_VEHICLE_ROOF_LIVERY = 0x60190048C0764A26,
        /// <summary>
        /// Returns a number of available rooftop liveries, or -1 if vehicle has no rooftop liveries available.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _GET_VEHICLE_ROOF_LIVERY_COUNT = 0x5ECB40269053C0D4,
        /// <summary>
        /// This will return false if the window is broken, or rolled down.
        /// Window indexes:
        /// 0 = Front Right Window
        /// 1 = Front Left Window
        /// 2 = Back Right Window
        /// 3 = Back Left Window
        /// 
        /// 
        /// Those numbers go on for vehicles that have more than 4 doors with windows.
        ///
        /// > Vehicle vehicle
        /// > int windowIndex
        ///
        /// </summary>
        IS_VEHICLE_WINDOW_INTACT = 0x46E571A0E20D01F1,
        /// <summary>
        /// Appears to return false if any window is broken.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        ARE_ALL_VEHICLE_WINDOWS_INTACT = 0x11D862A3E977A9EF,
        /// <summary>
        /// Returns false if every seat is occupied.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        ARE_ANY_VEHICLE_SEATS_FREE = 0x2D34FC3BC4ADB780,
        /// <summary>
        /// Max 1000.
        /// At 0 the main rotor will stall.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_HELI_MAIN_ROTOR_HEALTH = 0xE4CB7541F413D2C5,
        /// <summary>
        /// Max 1000.
        /// At 0 the tail rotor will stall.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_HELI_TAIL_ROTOR_HEALTH = 0xAE8CE82A4219AC8C,
        /// <summary>
        /// Max 1000.
        /// At -100 both helicopter rotors will stall.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_HELI_TAIL_BOOM_HEALTH = 0xAC51915D27E4A5F7,
        /// <summary>
        /// NOTE: Debugging functions are not present in the retail version of the game.
        ///
        /// > Vehicle vehicle
        /// > const char* name
        ///
        /// </summary>
        SET_VEHICLE_NAME_DEBUG = 0xBFDF984E2C22B94F,
        /// <summary>
        /// Sets a vehicle to be strongly resistant to explosions. p0 is the vehicle; set p1 to false to toggle the effect on/off.
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        SET_VEHICLE_EXPLODES_ON_HIGH_EXPLOSION_DAMAGE = 0x71B0892EC081D60A,
        /// <summary>
        /// Works for vehicles with a retractable landing gear
        /// 
        /// landing gear states:
        /// 
        /// 0: Deployed
        /// 1: Closing
        /// 2: Opening
        /// 3: Retracted
        /// 
        /// what can I use to make the hydra thing forward?
        ///
        /// > Vehicle vehicle
        /// > int state
        ///
        /// </summary>
        CONTROL_LANDING_GEAR = 0xCFC8BE9A5E1FE575,
        /// <summary>
        /// Landing gear states:
        /// 
        /// 0: Deployed
        /// 1: Closing (Retracting)
        /// 2:(Landing gear state 2 is never used.)
        /// 3: Opening (Deploying)
        /// 4: Retracted
        /// 
        /// Returns the current state of the vehicles landing gear.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_LANDING_GEAR_STATE = 0x9B0F3DCA3DB0F4CD,
        /// <summary>
        /// REQUEST_VEHICLE_ASSET(GET_HASH_KEY(cargobob3), 3);
        /// 
        /// vehicle found that have asset's:
        /// cargobob3
        /// submersible
        /// blazer
        ///
        /// > Hash vehicleHash
        /// > int vehicleAsset
        ///
        /// </summary>
        REQUEST_VEHICLE_ASSET = 0x81A15811460FAB3A,
        /// <summary>
        /// Sets how much the crane on the tow truck is raised, where 0.0 is fully lowered and 1.0 is fully raised.
        ///
        /// > Vehicle vehicle
        /// > float position
        ///
        /// </summary>
        SET_VEHICLE_TOW_TRUCK_ARM_POSITION = 0xFE54B92A344583CA,
        /// <summary>
        /// HookOffset defines where the hook is attached. leave at 0 for default attachment.
        ///
        /// > Vehicle towTruck
        /// > Vehicle vehicle
        /// > BOOL rear
        /// > float hookOffsetX
        /// > float hookOffsetY
        /// > float hookOffsetZ
        ///
        /// </summary>
        ATTACH_VEHICLE_TO_TOW_TRUCK = 0x29A16F8D621C4508,
        /// <summary>
        /// First two parameters swapped. Scripts verify that towTruck is the first parameter, not the second.
        ///
        /// > Vehicle towTruck
        /// > Vehicle vehicle
        ///
        /// </summary>
        DETACH_VEHICLE_FROM_TOW_TRUCK = 0xC2DB6B6708350ED8,
        /// <summary>
        /// Scripts verify that towTruck is the first parameter, not the second.
        ///
        /// > Vehicle towTruck
        /// > Vehicle vehicle
        ///
        /// </summary>
        IS_VEHICLE_ATTACHED_TO_TOW_TRUCK = 0x146DF9EC4C4B9FD4,
        /// <summary>
        /// Sets the arm position of a bulldozer. Position must be a value between 0.0 and 1.0. Ignored when `p2` is set to false, instead incrementing arm position by 0.1 (or 10%).
        ///
        /// > Vehicle vehicle
        /// > float position
        /// > BOOL p2
        ///
        /// </summary>
        SET_VEHICLE_BULLDOZER_ARM_POSITION = 0xF8EBCCC96ADB9FB7,
        /// <summary>
        /// True stops vtols from switching modes. Doesn't stop the sound though.
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_DISABLE_VEHICLE_FLIGHT_NOZZLE_POSITION = 0xCE2B43770B655F8F,
        /// <summary>
        /// On accelerating, spins the driven wheels with the others braked, so you don't go anywhere.
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        SET_VEHICLE_BURNOUT = 0xFB8794444A7D60FB,
        /// <summary>
        /// Returns whether the specified vehicle is currently in a burnout.
        /// 
        /// 
        /// vb.net
        /// Public Function isVehicleInBurnout(vh As Vehicle) As Boolean
        ///         Return Native.Function.Call(Of Boolean)(Hash.IS_VEHICLE_IN_BURNOUT, vh)
        ///     End Function
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        IS_VEHICLE_IN_BURNOUT = 0x1297A88E081430EB,
        /// <summary>
        /// Reduces grip significantly so it's hard to go anywhere.
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        SET_VEHICLE_REDUCE_GRIP = 0x222FF6A823D122E2,
        /// <summary>
        /// val is 0-3
        /// Often used in conjunction with: SET_VEHICLE_REDUCE_GRIP
        ///
        /// > Vehicle vehicle
        /// > int val
        ///
        /// </summary>
        _SET_VEHICLE_REDUCE_TRACTION = 0x6DEE944E1EE90CFB,
        /// <summary>
        /// Sets the turn signal enabled for a vehicle.
        /// Set turnSignal to 1 for left light, 0 for right light.
        ///
        /// > Vehicle vehicle
        /// > int turnSignal
        /// > BOOL toggle
        ///
        /// </summary>
        SET_VEHICLE_INDICATOR_LIGHTS = 0xB5D45264751B7DF0,
        /// <summary>
        /// HAS_*
        ///
        ///
        /// </summary>
        _HAS_FILLED_VEHICLE_POPULATION = 0x91D6DD290888CBAB,
        /// <summary>
        /// Gets the trailer of a vehicle and puts it into the trailer parameter.
        ///
        /// > Vehicle vehicle
        /// > Vehicle* trailer
        ///
        /// </summary>
        GET_VEHICLE_TRAILER_VEHICLE = 0x1CDD6BADC297830D,
        /// <summary>
        /// vehicle must be a plane
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        SET_VEHICLE_USES_LARGE_REAR_RAMP = 0xCAC66558B944DA67,
        /// <summary>
        /// static - max acceleration
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_VEHICLE_ACCELERATION = 0x5DD35C8D074E57AE,
        /// <summary>
        /// Returns max speed (without mods) of the specified vehicle model in m/s.
        /// 
        /// Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
        ///
        /// > Hash modelHash
        ///
        /// </summary>
        GET_VEHICLE_MODEL_ESTIMATED_MAX_SPEED = 0xF417C2502FFFED43,
        /// <summary>
        /// Returns max braking of the specified vehicle model.
        /// 
        /// Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
        ///
        /// > Hash modelHash
        ///
        /// </summary>
        GET_VEHICLE_MODEL_MAX_BRAKING = 0xDC53FD41B4ED944C,
        /// <summary>
        /// Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
        ///
        /// > Hash modelHash
        ///
        /// </summary>
        GET_VEHICLE_MODEL_MAX_BRAKING_MAX_MODS = 0xBFBA3BA79CFF7EBF,
        /// <summary>
        /// Returns max traction of the specified vehicle model.
        /// 
        /// Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
        ///
        /// > Hash modelHash
        ///
        /// </summary>
        GET_VEHICLE_MODEL_MAX_TRACTION = 0x539DE94D44FDFD0D,
        /// <summary>
        /// Returns the acceleration of the specified model.
        /// 
        /// Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
        ///
        /// > Hash modelHash
        ///
        /// </summary>
        GET_VEHICLE_MODEL_ACCELERATION = 0x8C044C5C84505B6A,
        /// <summary>
        /// GET_VEHICLE_MODEL_*
        /// 
        /// 9.8 * thrust if air vehicle, else 0.38 + drive force?
        /// 
        /// Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
        ///
        /// > Hash modelHash
        ///
        /// </summary>
        _GET_VEHICLE_MODEL_ESTIMATED_AGILITY = 0x53409B5163D5B846,
        /// <summary>
        /// GET_VEHICLE_MODEL_*
        /// 
        /// Function pertains only to aviation vehicles.
        /// 
        /// Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
        ///
        /// > Hash modelHash
        ///
        /// </summary>
        _GET_VEHICLE_MODEL_MAX_KNOTS = 0xC6AD107DDC9054CC,
        /// <summary>
        /// GET_VEHICLE_MODEL_*
        /// 
        /// called if the vehicle is a boat -- returns vecMoveResistanceX?
        /// 
        /// Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
        ///
        /// > Hash modelHash
        ///
        /// </summary>
        _GET_VEHICLE_MODEL_MOVE_RESISTANCE = 0x5AA3F878A178C4FC,
        /// <summary>
        /// Returns true when the bomb bay doors of this plane are open. False if they're closed.
        ///
        /// > Vehicle aircraft
        ///
        /// </summary>
        _ARE_BOMB_BAY_DOORS_OPEN = 0xD0917A423314BBA8,
        /// <summary>
        /// Possibly: Returns whether the searchlight (found on police vehicles) is toggled on.
        /// 
        /// @Author Nac
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        IS_VEHICLE_SEARCHLIGHT_ON = 0xC0F97FCE55094987,
        /// <summary>
        /// Only works during nighttime.
        ///
        /// > Vehicle heli
        /// > BOOL toggle
        /// > BOOL canBeUsedByAI
        ///
        /// </summary>
        SET_VEHICLE_SEARCHLIGHT = 0x14E85C5EE7A4D542,
        /// <summary>
        /// Check if a vehicle seat is accessible. If you park your vehicle near a wall and the ped cannot enter/exit this side, the return value toggles from true (not blocked) to false (blocked).
        /// 
        /// seatIndex  = -1 being the driver seat.
        /// Use GET_VEHICLE_MAX_NUMBER_OF_PASSENGERS(vehicle) - 1 for last seat index.
        /// side = only relevant for bikes/motorcycles to check if the left (false)/right (true) side is blocked.
        /// onEnter = check if you can enter (true) or exit (false) a vehicle.
        ///
        /// > Ped ped
        /// > Vehicle vehicle
        /// > int seatIndex
        /// > BOOL side
        /// > BOOL onEnter
        ///
        /// </summary>
        _IS_VEHICLE_SEAT_ACCESSIBLE = 0x639431E895B9AA57,
        /// <summary>
        /// doorId: see SET_VEHICLE_DOOR_SHUT
        ///
        /// > Vehicle vehicle
        /// > int doorId
        ///
        /// </summary>
        _GET_ENTRY_POSITION_OF_DOOR = 0xC0572928C0ABFDA3,
        /// <summary>
        /// Set modKit to 0 if you plan to call SET_VEHICLE_MOD. That's what the game does. Most body modifications through SET_VEHICLE_MOD will not take effect until this is set to 0.
        /// 
        /// Full list of vehicle mod kits and mods by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicleModKits.json
        ///
        /// > Vehicle vehicle
        /// > int modKit
        ///
        /// </summary>
        SET_VEHICLE_MOD_KIT = 0x1F2AA07F00B3217A,
        /// <summary>
        /// Returns an int
        /// 
        /// Wheel Types:
        /// 0: Sport
        /// 1: Muscle
        /// 2: Lowrider
        /// 3: SUV
        /// 4: Offroad
        /// 5: Tuner
        /// 6: Bike Wheels
        /// 7: High End
        /// 
        /// Tested in Los Santos Customs
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_VEHICLE_WHEEL_TYPE = 0xB3ED1BFB4BE636DC,
        /// <summary>
        /// 0: Sport
        /// 1: Muscle
        /// 2: Lowrider
        /// 3: SUV
        /// 4: Offroad
        /// 5: Tuner
        /// 6: Bike Wheels
        /// 7: High End
        ///
        /// > Vehicle vehicle
        /// > int WheelType
        ///
        /// </summary>
        SET_VEHICLE_WHEEL_TYPE = 0x487EB21CC7295BA1,
        /// <summary>
        /// paintType:
        /// 0: Normal
        /// 1: Metallic
        /// 2: Pearl
        /// 3: Matte
        /// 4: Metal
        /// 5: Chrome
        ///
        /// > int paintType
        /// > BOOL p1
        ///
        /// </summary>
        GET_NUM_MOD_COLORS = 0xA551BE18C11A476D,
        /// <summary>
        /// paintType:
        /// 0: Normal
        /// 1: Metallic
        /// 2: Pearl
        /// 3: Matte
        /// 4: Metal
        /// 5: Chrome
        /// 
        /// color: number of the color.
        /// 
        /// p3 seems to always be 0.
        /// 
        /// Full list of vehicle colors and vehicle plates by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicleColors.json
        ///
        /// > Vehicle vehicle
        /// > int paintType
        /// > int color
        /// > int pearlescentColor
        ///
        /// </summary>
        SET_VEHICLE_MOD_COLOR_1 = 0x43FEB945EE7F85B8,
        /// <summary>
        /// Changes the secondary paint type and color
        /// paintType:
        /// 0: Normal
        /// 1: Metallic
        /// 2: Pearl
        /// 3: Matte
        /// 4: Metal
        /// 5: Chrome
        /// 
        /// color: number of the color
        /// 
        /// Full list of vehicle colors and vehicle plates by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicleColors.json
        ///
        /// > Vehicle vehicle
        /// > int paintType
        /// > int color
        ///
        /// </summary>
        SET_VEHICLE_MOD_COLOR_2 = 0x816562BADFDEC83E,
        /// <summary>
        /// returns a string which is the codename of the vehicle's currently selected primary color
        /// 
        /// p1 is always 0
        ///
        /// > Vehicle vehicle
        /// > BOOL p1
        ///
        /// </summary>
        GET_VEHICLE_MOD_COLOR_1_NAME = 0xB45085B721EFD38C,
        /// <summary>
        /// returns a string which is the codename of the vehicle's currently selected secondary color
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_VEHICLE_MOD_COLOR_2_NAME = 0x4967A516ED23A5A1,
        /// <summary>
        /// In b944, there are 50 (0 - 49) mod types.
        /// 
        /// Sets the vehicle mod.
        /// The vehicle must have a mod kit first.
        /// 
        /// Any out of range ModIndex is stock.
        /// 
        /// #Mod Type
        /// Spoilers - 0
        /// Front Bumper - 1
        /// Rear Bumper - 2
        /// Side Skirt - 3
        /// Exhaust - 4
        /// Frame - 5
        /// Grille - 6
        /// Hood - 7
        /// Fender - 8
        /// Right Fender - 9
        /// Roof - 10
        /// Engine - 11
        /// Brakes - 12
        /// Transmission - 13
        /// Horns - 14 (modIndex from 0 to 51)
        /// Suspension - 15
        /// Armor - 16
        /// Front Wheels - 23
        /// Back Wheels - 24 //only for motocycles
        /// Plate holders - 25
        /// Trim Design - 27
        /// Ornaments - 28
        /// Dial Design - 30
        /// Steering Wheel - 33
        /// Shifter Leavers - 34
        /// Plaques - 35
        /// Hydraulics - 38
        /// Livery - 48
        /// 
        /// ENUMS: pastebin.com/QzEAn02v
        ///
        /// > Vehicle vehicle
        /// > int modType
        /// > int modIndex
        /// > BOOL customTires
        ///
        /// </summary>
        SET_VEHICLE_MOD = 0x6AF0636DDEDCB6DD,
        /// <summary>
        /// In b944, there are 50 (0 - 49) mod types.
        /// 
        /// Returns -1 if the vehicle mod is stock
        ///
        /// > Vehicle vehicle
        /// > int modType
        ///
        /// </summary>
        GET_VEHICLE_MOD = 0x772960298DA26FDB,
        /// <summary>
        /// Only used for wheels(ModType = 23/24) Returns true if the wheels are custom wheels
        ///
        /// > Vehicle vehicle
        /// > int modType
        ///
        /// </summary>
        GET_VEHICLE_MOD_VARIATION = 0xB3924ECD70E095DC,
        /// <summary>
        /// Returns how many possible mods a vehicle has for a given mod type
        ///
        /// > Vehicle vehicle
        /// > int modType
        ///
        /// </summary>
        GET_NUM_VEHICLE_MODS = 0xE38E9162A2500646,
        /// <summary>
        /// Toggles:
        /// UNK17 - 17
        /// Turbo - 18
        /// UNK19 - 19
        /// Tire Smoke - 20
        /// UNK21 - 21
        /// Xenon Headlights - 22
        ///
        /// > Vehicle vehicle
        /// > int modType
        /// > BOOL toggle
        ///
        /// </summary>
        TOGGLE_VEHICLE_MOD = 0x2A1F4F37F95BAD08,
        /// <summary>
        /// Returns the text label of a mod type for a given vehicle
        /// 
        /// Use _GET_LABEL_TEXT to get the part name in the game's language
        ///
        /// > Vehicle vehicle
        /// > int modType
        /// > int modValue
        ///
        /// </summary>
        GET_MOD_TEXT_LABEL = 0x8935624F8C5592CC,
        /// <summary>
        /// Returns the name for the type of vehicle mod(Armour, engine etc)
        /// 
        ///
        /// > Vehicle vehicle
        /// > int modType
        ///
        /// </summary>
        GET_MOD_SLOT_NAME = 0x51F0FEB9F6AE98C0,
        /// <summary>
        /// Second Param = LiveryIndex
        /// 
        /// example 
        /// 
        /// int count = VEHICLE::GET_VEHICLE_LIVERY_COUNT(veh);
        /// for (int i = 0; i < count; i++)  
        ///   {
        ///      const char* LiveryName = VEHICLE::GET_LIVERY_NAME(veh, i);
        ///   }
        /// 
        /// 
        /// this example will work fine to fetch all names 
        /// for example for Sanchez we get 
        /// 
        /// SANC_LV1
        /// SANC_LV2
        /// SANC_LV3
        /// SANC_LV4
        /// SANC_LV5
        /// 
        /// 
        /// Use _GET_LABEL_TEXT, to get the localized livery name.
        /// 
        /// Full list of vehicle mod kits and mods by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicleModKits.json
        ///
        /// > Vehicle vehicle
        /// > int liveryIndex
        ///
        /// </summary>
        GET_LIVERY_NAME = 0xB4C7A93837C91A1F,
        /// <summary>
        /// Can be used for IS_DLC_VEHICLE_MOD and _0xC098810437312FFF
        ///
        /// > Vehicle vehicle
        /// > int modType
        /// > int modIndex
        ///
        /// </summary>
        GET_VEHICLE_MOD_IDENTIFIER_HASH = 0x4593CF82AA179706,
        /// <summary>
        /// Sets the tire smoke's color of this vehicle.
        /// 
        /// vehicle: The vehicle that is the target of this method.
        /// r: The red level in the RGB color code.
        /// g: The green level in the RGB color code.
        /// b: The blue level in the RGB color code.
        /// 
        /// Note:
        /// setting r,g,b to 0 will give the car independance day tyre smoke
        ///
        /// > Vehicle vehicle
        /// > int r
        /// > int g
        /// > int b
        ///
        /// </summary>
        SET_VEHICLE_TYRE_SMOKE_COLOR = 0xB5BA80F839791C0F,
        /// <summary>
        /// enum WindowTints
        /// {
        ///  WINDOWTINT_NONE,
        ///   WINDOWTINT_PURE_BLACK,
        ///     WINDOWTINT_DARKSMOKE,
        ///  WINDOWTINT_LIGHTSMOKE,
        ///     WINDOWTINT_STOCK,
        ///  WINDOWTINT_LIMO,
        ///   WINDOWTINT_GREEN
        /// };
        ///
        /// > Vehicle vehicle
        /// > int tint
        ///
        /// </summary>
        SET_VEHICLE_WINDOW_TINT = 0x57C51E6BAD752696,
        /// <summary>
        /// What's this for? Primary and Secondary RGB have their own natives and this one doesn't seem specific.
        ///
        /// > Vehicle vehicle
        /// > int* r
        /// > int* g
        /// > int* b
        ///
        /// </summary>
        GET_VEHICLE_COLOR = 0xF3CC740D36221548,
        /// <summary>
        /// iVar3 = get_vehicle_cause_of_destruction(uLocal_248[iVar2]);
        /// if (iVar3 == joaat("weapon_stickybomb"))
        /// {
        /// 	func_171(726);
        /// 	iLocal_260 = 1;
        /// }
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_VEHICLE_CAUSE_OF_DESTRUCTION = 0xE495D1EF4C91FD20,
        /// <summary>
        /// From the driver's perspective, is the left headlight broken.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_IS_LEFT_VEHICLE_HEADLIGHT_DAMAGED = 0x5EF77C9ADD3B11A3,
        /// <summary>
        /// From the driver's perspective, is the right headlight broken.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_IS_RIGHT_VEHICLE_HEADLIGHT_DAMAGED = 0xA7ECB73355EB2F20,
        /// <summary>
        /// Only ever used once in decompiled scripts: **am_pi_menu**:
        /// Returns true if the engine is on fire, or if the vehicle engine health is < 0 and it **has been** on fire.
        /// 
        /// It sometimes doesn't return true when the vehicle engine has been on fire, and has since been fixed. I'm not really sure what the exact conditions are.
        /// 
        /// This usually returns true even if there are no visible flames yet (engine health > 0). However if you monitor engine health you'll see that it starts decreasing as soon as this returns true.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _IS_VEHICLE_ENGINE_ON_FIRE = 0xEC69ADF931AAE0C3,
        /// <summary>
        /// To reset the max speed, set the `speed` value to `0.0` or lower.
        ///
        /// > Vehicle vehicle
        /// > float speed
        ///
        /// </summary>
        _SET_VEHICLE_MAX_SPEED = 0xBAA045B4E42F3C06,
        /// <summary>
        /// <1.0 - Decreased torque
        /// =1.0 - Default torque
        /// >1.0 - Increased torque
        /// 
        /// Negative values will cause the vehicle to go backwards instead of forwards while accelerating.
        /// 
        /// value - is between 0.2 and 1.8 in the decompiled scripts. 
        /// 
        /// This needs to be called every frame to take effect.
        ///
        /// > Vehicle vehicle
        /// > float value
        ///
        /// </summary>
        SET_VEHICLE_CHEAT_POWER_INCREASE = 0xB59E4BD37AE292DB,
        /// <summary>
        /// Sets the wanted state of this vehicle.
        /// 
        ///
        /// > Vehicle vehicle
        /// > BOOL state
        ///
        /// </summary>
        SET_VEHICLE_IS_WANTED = 0xF7EC25A3EBEEC726,
        /// <summary>
        /// Sets the boat boom position for the `TR3` trailer.
        /// Ratio value is between `0.0` and `1.0`, where `0.0` is 90 degrees to the left of the boat, and `1.0` is just slightly to the right/back of the boat.
        /// To get the current boom position ratio, use GET_BOAT_BOOM_POSITION_RATIO
        ///
        /// > Vehicle vehicle
        /// > float ratio
        ///
        /// </summary>
        _SET_BOAT_BOOM_POSITION_RATIO = 0xF488C566413B4232,
        /// <summary>
        /// Same call as VEHICLE::_0x0F3B4D4E43177236
        ///
        /// > Vehicle vehicle
        /// > BOOL p1
        ///
        /// </summary>
        _GET_BOAT_BOOM_POSITION_RATIO_2 = 0xC1F981A6F74F0C23,
        /// <summary>
        /// Returns true when in a vehicle, false whilst entering/exiting.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_IS_VEHICLE_ENGINE_RUNNING = 0xAE31E7DF9B5B132E,
        /// <summary>
        /// Only works on bikes, both X and Y work in the -1 - 1 range.
        /// 
        /// X forces the bike to turn left or right (-1, 1)
        /// Y forces the bike to lean to the left or to the right (-1, 1)
        /// 
        /// Example with X -1/Y 1
        /// http://i.imgur.com/TgIuAPJ.jpg
        ///
        /// > Vehicle vehicle
        /// > float x
        /// > float y
        ///
        /// </summary>
        SET_BIKE_ON_STAND = 0x9CFA4896C3A53CBB,
        /// <summary>
        /// Also includes some "turnOffBones" when vehicle mods are installed.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _GET_VEHICLE_NUMBER_OF_BROKEN_OFF_BONES = 0x42A4BEB35D372407,
        /// <summary>
        /// Allows creation of CEventShockingPlaneFlyby, CEventShockingHelicopterOverhead, and other(?) Shocking events
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        SET_VEHICLE_GENERATES_ENGINE_SHOCKING_EVENTS = 0x279D50DE5652D935,
        /// <summary>
        /// Copies sourceVehicle's damage (broken bumpers, broken lights, etc.) to targetVehicle.
        ///
        /// > Vehicle sourceVehicle
        /// > Vehicle targetVehicle
        ///
        /// </summary>
        COPY_VEHICLE_DAMAGES = 0xE44A982368A4AF23,
        /// <summary>
        /// Commands the driver of an armed vehicle (p0) to shoot its weapon at a target (p1). p3, p4 and p5 are the coordinates of the target. Example:
        /// 
        /// WEAPON::SET_CURRENT_PED_VEHICLE_WEAPON(pilot,MISC::GET_HASH_KEY("VEHICLE_WEAPON_PLANE_ROCKET"));                        VEHICLE::SET_VEHICLE_SHOOT_AT_TARGET(pilot, target, targPos.x, targPos.y, targPos.z);
        ///
        /// > Ped driver
        /// > Entity entity
        /// > float xTarget
        /// > float yTarget
        /// > float zTarget
        ///
        /// </summary>
        SET_VEHICLE_SHOOT_AT_TARGET = 0x74CD9A9327A282EA,
        /// <summary>
        /// in script hook .net 
        /// 
        /// Vehicle v = ...;
        /// Function.Call(Hash.TRACK_VEHICLE_VISIBILITY, v.Handle);
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        TRACK_VEHICLE_VISIBILITY = 0x64473AEFDCF47DCA,
        /// <summary>
        /// must be called after TRACK_VEHICLE_VISIBILITY 
        /// 
        /// it's not instant so probabilly must pass an 'update' to see correct result.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        IS_VEHICLE_VISIBLE = 0xAA0A52D24FB98293,
        /// <summary>
        /// Enable/Disables global slipstream physics
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_ENABLE_VEHICLE_SLIPSTREAMING = 0xE6C0C80B8C867537,
        /// <summary>
        /// Returns a float value between 0.0 and 3.0 related to its slipstream draft (boost/speedup).
        /// 
        /// GET_VEHICLE_*
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _GET_VEHICLE_CURRENT_SLIPSTREAM_DRAFT = 0x36492C2F0D134C56,
        /// <summary>
        /// Returns true if the vehicle is being slipstreamed by another vehicle
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _IS_VEHICLE_SLIPSTREAM_LEADER = 0x48C633E94A8142A7,
        /// <summary>
        /// Returns false if the vehicle has the FLAG_NO_RESPRAY flag set.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        IS_VEHICLE_SPRAYABLE = 0x8D474C8FAEFF6CDE,
        /// <summary>
        /// Adds some kind of shadow to the vehicle.
        /// 
        /// -1 disables the effect.
        /// DISABLE_*
        ///
        /// > Vehicle vehicle
        /// > int p1
        /// > int p2
        ///
        /// </summary>
        _SET_VEHICLE_SHADOW_EFFECT = 0xF0E4BA16D1DB546C,
        /// <summary>
        /// Remove the weird shadow applied by _SET_VEHICLE_SHADOW_EFFECT.
        /// ENABLE_*
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _REMOVE_VEHICLE_SHADOW_EFFECT = 0xF87D9F2301F7D206,
        /// <summary>
        /// This native sets the turbulence multiplier. It only works for planes.
        /// 0.0 = no turbulence at all.
        /// 1.0 = heavy turbulence.
        /// Works by just calling it once, does not need to be called every tick.
        ///
        /// > Vehicle vehicle
        /// > float multiplier
        ///
        /// </summary>
        SET_PLANE_TURBULENCE_MULTIPLIER = 0xAD2D28A1AFDFF131,
        /// <summary>
        /// ADD_A_MARKER_OVER_VEHICLE was a hash collision!!!
        /// 
        /// Can be used for planes only!
        ///
        /// > Vehicle plane
        ///
        /// </summary>
        _ARE_PLANE_WINGS_INTACT = 0x5991A01434CE9677,
        /// <summary>
        /// Returns attached vehicle (Vehicle in parameter must be cargobob)
        ///
        /// > Vehicle cargobob
        ///
        /// </summary>
        GET_VEHICLE_ATTACHED_TO_CARGOBOB = 0x873B82D42AC2B9E5,
        /// <summary>
        /// Stops cargobob from beeing able to detach the attached vehicle.
        ///
        /// > Vehicle cargobob
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_CARGOBOB_HOOK_CAN_DETACH = 0x571FEB383F629926,
        /// <summary>
        /// Gets the position of the cargobob hook, in world coords.
        ///
        /// > Vehicle cargobob
        ///
        /// </summary>
        _GET_CARGOBOB_HOOK_POSITION = 0xCBDB9B923CACC92D,
        /// <summary>
        /// Returns true only when the hook is active, will return false if the magnet is active
        ///
        /// > Vehicle cargobob
        ///
        /// </summary>
        DOES_CARGOBOB_HAVE_PICK_UP_ROPE = 0x1821D91AD4B56108,
        /// <summary>
        /// Drops the Hook/Magnet on a cargobob
        /// 
        /// state
        /// enum eCargobobHook
        /// {
        ///   CARGOBOB_HOOK = 0,
        ///     CARGOBOB_MAGNET = 1,
        /// };
        ///
        /// > Vehicle cargobob
        /// > int state
        ///
        /// </summary>
        CREATE_PICK_UP_ROPE_FOR_CARGOBOB = 0x7BEB0C7A235F6F3B,
        /// <summary>
        /// Retracts the hook on the cargobob.
        /// 
        /// Note: after you retract it the natives for dropping the hook no longer work
        ///
        /// > Vehicle cargobob
        ///
        /// </summary>
        REMOVE_PICK_UP_ROPE_FOR_CARGOBOB = 0x9768CF648F54C804,
        /// <summary>
        /// min: 1.9f, max: 100.0f
        ///
        /// > Vehicle cargobob
        /// > float length1
        /// > float length2
        /// > BOOL p3
        ///
        /// </summary>
        SET_PICKUP_ROPE_LENGTH_FOR_CARGOBOB = 0x877C1EAEAC531023,
        /// <summary>
        /// Returns true only when the magnet is active, will return false if the hook is active
        ///
        /// > Vehicle cargobob
        ///
        /// </summary>
        DOES_CARGOBOB_HAVE_PICKUP_MAGNET = 0x6E08BF5B3722BAC9,
        /// <summary>
        /// Won't attract or magnetize to any helicopters or planes of course, but that's common sense.
        ///
        /// > Vehicle cargobob
        /// > BOOL isActive
        ///
        /// </summary>
        SET_CARGOBOB_PICKUP_MAGNET_ACTIVE = 0x9A665550F8DA349B,
        /// <summary>
        /// how does this work?
        ///
        /// > BOOL disabled
        /// > Hash weaponHash
        /// > Vehicle vehicle
        /// > Ped owner
        ///
        /// </summary>
        DISABLE_VEHICLE_WEAPON = 0xF4FC6A6F67D8D856,
        /// <summary>
        /// Returns an int
        /// 
        /// Vehicle Classes:
        /// 0: Compacts
        /// 1: Sedans
        /// 2: SUVs
        /// 3: Coupes
        /// 4: Muscle
        /// 5: Sports Classics
        /// 6: Sports
        /// 7: Super
        /// 8: Motorcycles
        /// 9: Off-road
        /// 10: Industrial
        /// 11: Utility
        /// 12: Vans
        /// 13: Cycles
        /// 14: Boats
        /// 15: Helicopters
        /// 16: Planes
        /// 17: Service
        /// 18: Emergency
        /// 19: Military
        /// 20: Commercial
        /// 21: Trains
        /// 
        /// char buffer[128];
        /// std::sprintf(buffer, "VEH_CLASS_%i", VEHICLE::GET_VEHICLE_CLASS(vehicle));
        /// 
        /// const char* className = HUD::_GET_LABEL_TEXT(buffer);
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_VEHICLE_CLASS = 0x29439776AAA00A62,
        /// <summary>
        /// For a full enum, see here : pastebin.com/i2GGAjY0
        /// 
        /// char buffer[128];
        /// std::sprintf(buffer, "VEH_CLASS_%i", VEHICLE::GET_VEHICLE_CLASS_FROM_NAME (hash));
        /// 
        /// const char* className = HUD::_GET_LABEL_TEXT(buffer);
        /// 
        /// Full list of vehicles by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/vehicles.json
        ///
        /// > Hash modelHash
        ///
        /// </summary>
        GET_VEHICLE_CLASS_FROM_NAME = 0xDEDF1C8BD47C2200,
        /// <summary>
        /// Money pickups are created around cars when they explode. Only works when the vehicle model is a car. A single pickup is between 1 and 18 dollars in size. All car models seem to give the same amount of money.
        /// 
        /// youtu.be/3arlUxzHl5Y 
        /// i.imgur.com/WrNpYFs.jpg
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        SET_VEHICLE_DROPS_MONEY_WHEN_BLOWN_UP = 0x068F64F2470F9656,
        /// <summary>
        /// VEHICLE::SET_VEHICLE_ENGINE_ON is not enough to start jet engines when not inside the vehicle. But with this native set to true it works: youtu.be/OK0ps2fDpxs 
        /// i.imgur.com/7XA14pX.png
        /// Certain planes got jet engines.
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_VEHICLE_JET_ENGINE_ON = 0xB8FBC8B1330CA9B4,
        /// <summary>
        /// Use the "AIHandling" string found in handling.meta
        ///
        /// > Vehicle vehicle
        /// > Hash hash
        ///
        /// </summary>
        _SET_VEHICLE_HANDLING_HASH_FOR_AI = 0x10655FAB9915623D,
        /// <summary>
        /// Max value is 32767
        ///
        /// > Vehicle vehicle
        /// > int range
        ///
        /// </summary>
        SET_VEHICLE_EXTENDED_REMOVAL_RANGE = 0x79DF7E806202CE01,
        /// <summary>
        /// value between 0.0 and 1.0
        ///
        /// > Vehicle helicopter
        /// > float multiplier
        ///
        /// </summary>
        _SET_HELICOPTER_ROLL_PITCH_YAW_MULT = 0x6E0859B530A365CC,
        /// <summary>
        /// Seems to be related to the metal parts, not tyres (like i was expecting lol)
        ///
        /// > Vehicle vehicle
        /// > float friction
        ///
        /// </summary>
        SET_VEHICLE_FRICTION_OVERRIDE = 0x1837AF7C627009BA,
        /// <summary>
        /// index: 0 - 1
        /// 
        /// Used to be incorrectly named _SET_VEHICLE_EXCLUSIVE_DRIVER_2
        ///
        /// > Vehicle vehicle
        /// > Ped ped
        /// > int index
        ///
        /// </summary>
        SET_VEHICLE_EXCLUSIVE_DRIVER = 0xB5C51B5502E85E83,
        /// <summary>
        /// R* used it to "remove" vehicle windows when "nightshark" had some mod, which adding some kind of armored windows. When enabled, you can't break vehicles glass. All your bullets wiil shoot through glass. You also will not able to break the glass with any other way (hitting and etc)
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_DISABLE_VEHICLE_WINDOW_COLLISIONS = 0x1087BC8EC540DAEB,
        /// <summary>
        /// Toggles to render distant vehicles. They may not be vehicles but images to look like vehicles.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_DISTANT_CARS_ENABLED = 0xF796359A959DF65D,
        /// <summary>
        /// Sets the color of the neon lights of the specified vehicle.
        /// 
        /// More info: pastebin.com/G49gqy8b
        ///
        /// > Vehicle vehicle
        /// > int r
        /// > int g
        /// > int b
        ///
        /// </summary>
        _SET_VEHICLE_NEON_LIGHTS_COLOUR = 0x8E0A582209A62695,
        /// <summary>
        /// Gets the color of the neon lights of the specified vehicle.
        /// 
        /// See _SET_VEHICLE_NEON_LIGHTS_COLOUR (0x8E0A582209A62695) for more information
        ///
        /// > Vehicle vehicle
        /// > int* r
        /// > int* g
        /// > int* b
        ///
        /// </summary>
        _GET_VEHICLE_NEON_LIGHTS_COLOUR = 0x7619EEE8C886757F,
        /// <summary>
        /// Sets the neon lights of the specified vehicle on/off.
        /// 
        /// Indices:
        /// 0 = Left
        /// 1 = Right
        /// 2 = Front
        /// 3 = Back
        ///
        /// > Vehicle vehicle
        /// > int index
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_VEHICLE_NEON_LIGHT_ENABLED = 0x2AA720E4287BF269,
        /// <summary>
        /// indices:
        /// 0 = Left
        /// 1 = Right
        /// 2 = Front
        /// 3 = Back
        ///
        /// > Vehicle vehicle
        /// > int index
        ///
        /// </summary>
        _IS_VEHICLE_NEON_LIGHT_ENABLED = 0x8C4B92553E4766A5,
        /// <summary>
        /// REQUEST_VEHICLE_*
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _REQUEST_VEHICLE_DASHBOARD_SCALEFORM_MOVIE = 0xDBA3C090E3D74690,
        /// <summary>
        /// Seems related to vehicle health, like the one in IV.
        /// Max 1000, min 0.
        /// Vehicle does not necessarily explode or become undrivable at 0.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_VEHICLE_BODY_HEALTH = 0xF271147EB7B40F12,
        /// <summary>
        /// p2 often set to 1000.0 in the decompiled scripts.
        ///
        /// > Vehicle vehicle
        /// > float value
        ///
        /// </summary>
        SET_VEHICLE_BODY_HEALTH = 0xB77D05AC8C78AADB,
        /// <summary>
        /// Outputs 2 Vector3's.
        /// Scripts check if out2.x - out1.x > someshit.x
        /// Could be suspension related, as in max suspension height and min suspension height, considering the natives location.
        ///
        /// > Vehicle vehicle
        /// > Vector3* out1
        /// > Vector3* out2
        ///
        /// </summary>
        _GET_VEHICLE_SUSPENSION_BOUNDS = 0xDF7E3EEB29642C38,
        /// <summary>
        /// Gets the height of the vehicle's suspension.
        /// The higher the value the lower the suspension. Each 0.002 corresponds with one more level lowered.
        /// 0.000 is the stock suspension.
        /// 0.008 is Ultra Suspension.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _GET_VEHICLE_SUSPENSION_HEIGHT = 0x53952FD2BAA19F17,
        /// <summary>
        /// Something to do with "high speed bump severity"?
        /// 
        /// if (!sub_87a46("SET_CAR_HIGH_SPEED_BUMP_SEVERITY_MULTIPLIER")) {
        ///     VEHICLE::_84FD40F56075E816(0.0);
        ///     sub_8795b("SET_CAR_HIGH_SPEED_BUMP_SEVERITY_MULTIPLIER", 1);
        /// }
        ///
        /// > float multiplier
        ///
        /// </summary>
        _SET_CAR_HIGH_SPEED_BUMP_SEVERITY_MULTIPLIER = 0x84FD40F56075E816,
        /// <summary>
        /// 0 min 100 max
        /// starts at 100
        /// Seams to have health zones
        /// Front of vehicle when damaged goes from 100-50 and stops at 50.
        /// Rear can be damaged from 100-0
        /// Only tested with two cars.
        /// 
        /// any idea how this differs from the first one?
        /// 
        /// --
        /// May return the vehicle health on a scale of 0.0 - 100.0 (needs to be confirmed)
        /// 
        /// example:
        /// 
        /// v_F = ENTITY::GET_ENTITY_MODEL(v_3);
        /// if (((v_F == ${tanker}) || (v_F == ${armytanker})) || (v_F == ${tanker2})) {
        ///     if (VEHICLE::_GET_VEHICLE_BODY_HEALTH_2(v_3) <= 1.0) {
        ///         NETWORK::NETWORK_EXPLODE_VEHICLE(v_3, 1, 1, -1);
        ///     }
        /// }
        ///
        /// > Vehicle vehicle
        /// > float maxEngineHealth
        /// > float maxPetrolTankHealth
        /// > float maxBodyHealth
        /// > float maxMainRotorHealth
        /// > float maxTailRotorHealth
        /// > float maxUnkHealth
        ///
        /// </summary>
        _GET_VEHICLE_BODY_HEALTH_2 = 0xB8EF61207C2393A9,
        /// <summary>
        /// Returns true if the vehicle has a kers boost (for instance the lectro or the vindicator)
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        GET_VEHICLE_HAS_KERS = 0x50634E348C8D44EF,
        /// <summary>
        /// Works only on vehicles that support hydraulic.
        ///
        /// > Vehicle vehicle
        /// > int wheelId
        /// > float value
        ///
        /// </summary>
        _SET_HYDRAULIC_WHEEL_VALUE = 0x84EA99C62CB3EF0C,
        /// <summary>
        /// Sets vehicle wheel hydraulic states transition. Known states:
        /// 0 - reset
        /// 1 - raise wheel (uses value arg, works just like _SET_VEHICLE_HYDRAULIC_WHEEL_VALUE)
        /// 2 - jump using wheel
        ///
        /// > Vehicle vehicle
        /// > int wheelId
        /// > int state
        /// > float value
        /// > Any p4
        ///
        /// </summary>
        _SET_HYDRAULIC_WHEEL_STATE_TRANSITION = 0xC24075310A8B9CD1,
        /// <summary>
        /// SET_VEHICLE_D*
        ///
        /// > Vehicle vehicle
        /// > float p1
        ///
        /// </summary>
        _SET_VEHICLE_DAMAGE_MODIFIER = 0x4E20D2A627011E8E,
        /// <summary>
        /// Inverts vehicle's controls. So INPUT_VEH_ACCELERATE will be INPUT_VEH_BRAKE and vise versa (same for A/D controls)
        /// Doesn't work for planes/helis.
        ///
        /// > Vehicle vehicle
        /// > BOOL state
        ///
        /// </summary>
        _SET_VEHICLE_CONTROLS_INVERTED = 0x5B91B229243351A8,
        /// <summary>
        /// doorId: see SET_VEHICLE_DOOR_SHUT
        ///
        /// > Vehicle vehicle
        /// > int doorId
        ///
        /// </summary>
        _GET_IS_DOOR_VALID = 0x645F4B6E8499F632,
        /// <summary>
        /// Returns true if the vehicle has the FLAG_JUMPING_CAR flag set.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _GET_CAN_VEHICLE_JUMP = 0x9078C0C5EF8C19E9,
        /// <summary>
        /// Allows vehicles with the FLAG_JUMPING_CAR flag to jump higher (i.e. Ruiner 2000).
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_USE_HIGHER_VEHICLE_JUMP_FORCE = 0xF06A16CA55D138D8,
        /// <summary>
        /// Set vehicle's primary mounted weapon 2 ammo. For example, use it on APC.
        /// For example, you can "remove" any vehicle weapon from any vehicle.
        /// ammoAmount -1 = infinite ammo (default value for any spawned vehicle tho)
        ///
        /// > Vehicle vehicle
        /// > int weaponIndex
        /// > int capacity
        ///
        /// </summary>
        _SET_VEHICLE_WEAPON_CAPACITY = 0x44CD1F493DB2A0A6,
        /// <summary>
        /// Parachute models:
        /// - sr_prop_specraces_para_s_01
        /// - imp_prop_impexp_para_s (SecuroServ; Default)
        /// Plus, many more props can be used as vehicle parachutes, like umbrellas (prop_beach_parasol_03), and unlike SET_PLAYER_PARACHUTE_MODEL_OVERRIDE, you won't get stuck mid-air when using an umbrella.
        ///
        /// > Vehicle vehicle
        /// > Hash modelHash
        ///
        /// </summary>
        _SET_VEHICLE_PARACHUTE_MODEL = 0x4D610C6B56031351,
        /// <summary>
        /// Variations available for the generic parachute (sr_prop_specraces_para_s_01):
        /// - 0: Rainbow
        /// - 1: Red
        /// - 2: White, blue, yellow
        /// - 3: Black, red, white
        /// - 4: Red, white, blue
        /// - 5: Blue
        /// - 6: Black
        /// - 7: Black, yellow
        ///
        /// > Vehicle vehicle
        /// > int textureVariation
        ///
        /// </summary>
        _SET_VEHICLE_PARACHUTE_TEXTURE_VARIATION = 0xA74AD2439468C883,
        /// <summary>
        /// Set state to true to extend the wings, false to retract them.
        ///
        /// > Vehicle vehicle
        /// > BOOL state
        ///
        /// </summary>
        _SET_OPPRESSOR_TRANSFORM_STATE = 0x544996C0081ABDEB,
        /// <summary>
        /// Disables collision for this vehicle (maybe it also supports other entities, not sure).
        /// Only world/building/fixed world objects will have their collisions disabled, props, peds, or any other entity still collides with the vehicle.
        /// Example: https://streamable.com/6n45d5
        /// Not sure if there is a native (and if so, which one) that resets the collisions.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _DISABLE_VEHICLE_WORLD_COLLISION = 0x75627043C6AA90AD,
        /// <summary>
        /// Stops the cargobob from being able to attach any vehicle
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_CARGOBOB_HOOK_CAN_ATTACH = 0x94A68DA412C4007D,
        /// <summary>
        /// Sets the amount of bombs that this vehicle has. As far as I know, this does _not_ impact vehicle weapons or the ammo of those weapons in any way, it is just a way to keep track of the amount of bombs in a specific plane. 
        ///
        /// > Vehicle vehicle
        /// > int bombCount
        ///
        /// </summary>
        _SET_VEHICLE_BOMB_COUNT = 0xF4B2ED59DEB5D774,
        /// <summary>
        /// Gets the amount of bombs that this vehicle has. As far as I know, this does _not_ impact vehicle weapons or the ammo of those weapons in any way, it is just a way to keep track of the amount of bombs in a specific plane. 
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _GET_VEHICLE_BOMB_COUNT = 0xEA12BD130D7569A1,
        /// <summary>
        /// Similar to 0xF4B2ED59DEB5D774, this sets the amount of countermeasures that are present on this vehicle.
        /// Use 0xF846AA63DF56B804 to get the current amount.
        ///
        /// > Vehicle vehicle
        /// > int counterMeasureCount
        ///
        /// </summary>
        _SET_VEHICLE_COUNTERMEASURE_COUNT = 0x9BDA23BF666F0855,
        /// <summary>
        /// Similar to `0xEA12BD130D7569A1`, this gets the amount of countermeasures that are present on this vehicle.
        /// Use 0x9BDA23BF666F0855 to set the current amount.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _GET_VEHICLE_COUNTERMEASURE_COUNT = 0xF846AA63DF56B804,
        /// <summary>
        /// According to decompiled scripts this should work with the `deluxo` and `oppressor2` vehicles.
        /// I've only seen this work for `deluxo` though, can't figure out what it's supposed to do on `oppressor2`.
        /// 
        /// For the deluxo:
        /// - Set `state` to `0.0`: Fully transform to a 'road' vehicle (non-hover mode).
        /// - Set `state` to `1.0`: Fully transform to a 'flying' vehicle (hover mode).
        /// 
        /// If you set it to something like 0.5, then something [weird happens](https://streamable.com/p6wmr), you end up in some 50% hover mode, 50% not hover mode.
        /// 
        /// This doesn't need to be called every tick, just once and the vehicle will transform to that state at the usual transform speed. It'll just stop transforming when it reaches the state you provided.
        /// 
        /// Once this native is used then players will just be able to hit the vehicle transform key to toggle the transformation cycle; it won't block users from using the key.
        ///
        /// > Vehicle vehicle
        /// > float percentage
        ///
        /// </summary>
        _SET_VEHICLE_HOVER_TRANSFORM_PERCENTAGE = 0x438B3D7CA026FE91,
        /// <summary>
        /// It will override the ability to transform deluxo. For oppressor it will work just like 0x2D55FE374D5FDB91
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_VEHICLE_HOVER_TRANSFORM_ENABLED = 0xF1211889DF15A763,
        /// <summary>
        /// Disables "wings" for some flying vehicles. Works only for oppressor _2_ and deluxo.
        /// For deluxo it just immediately removes vehicle's "wings" and you will be not able to fly up.
        /// For oppressor 2 it will remove wings right after you land. And you will not able to fly up anymore too.
        /// But for opressor 2 you still can fly if you somehow get back in the air.
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_VEHICLE_HOVER_TRANSFORM_ACTIVE = 0x2D55FE374D5FDB91,
        /// <summary>
        /// Native is significantly more complicated than simply generating a random vector & length.
        /// The 'point' is either 400.0 or 250.0 units away from the Ped's current coordinates; and paths into functions like rage::grcViewport___IsSphereVisible
        ///
        /// > Ped ped
        ///
        /// </summary>
        _FIND_RANDOM_POINT_IN_SPACE = 0x8DC9675797123522,
        /// <summary>
        /// Only used with the "akula" and "annihilator2" in the decompiled native scripts.
        ///
        /// > Vehicle vehicle
        /// > BOOL deploy
        /// > BOOL p2
        ///
        /// </summary>
        _SET_DEPLOY_HELI_STUB_WINGS = 0xB251E0B33E58B424,
        /// <summary>
        /// Only used with the "akula" and "annihilator2" in the decompiled native scripts.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _ARE_HELI_STUB_WINGS_DEPLOYED = 0xAEF12960FA943792,
        /// <summary>
        /// Toggles specific flag on turret
        ///
        /// > Vehicle vehicle
        /// > int index
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_VEHICLE_TURRET_UNK = 0xC60060EB0D8AC7B1,
        /// <summary>
        /// Disables turret movement when called in a loop. You can still fire and aim. You cannot shoot backwards though.
        ///
        /// > Vehicle vehicle
        /// > int turretId
        ///
        /// </summary>
        _SET_DISABLE_TURRET_MOVEMENT_THIS_FRAME = 0xE615BB7A7752C76A,
        /// <summary>
        /// Returns last vehicle that was rammed by the given vehicle using the shunt boost.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _GET_LAST_RAMMED_VEHICLE = 0x04F2FA6E234162F7,
        /// <summary>
        /// Sets some global vehicle related bool
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_DISABLE_VEHICLE_UNK_2 = 0x211E95CE9903940C,
        /// <summary>
        /// Disables detachable bumber from domnator4, dominator5, dominator6, see https://gfycat.com/SecondUnluckyGosling
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        _HIDE_VEHICLE_TOMBSTONE = 0xAE71FB656C600587,
        /// <summary>
        /// Returns whether this vehicle is currently disabled by an EMP mine.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _GET_IS_VEHICLE_EMP_DISABLED = 0x0506ED94363AD905,
        /// <summary>
        /// Usable wheels:
        /// 0: wheel_lf
        /// 1: wheel_rf
        /// 2: wheel_lm1
        /// 3: wheel_rm1
        /// 4: wheel_lr
        /// 5: wheel_rr
        ///
        /// > Vehicle vehicle
        /// > int wheelIndex
        ///
        /// </summary>
        _GET_TYRE_HEALTH = 0x55EAB010FAEE9380,
        /// <summary>
        /// _SET_TYRE_WEAR_MULTIPLIER must be active, otherwise values set to <1000.0f will default to 350.0f
        /// 
        /// Usable wheels:
        /// 0: wheel_lf
        /// 1: wheel_rf
        /// 2: wheel_lm1
        /// 3: wheel_rm1
        /// 4: wheel_lr
        /// 5: wheel_rr
        ///
        /// > Vehicle vehicle
        /// > int wheelIndex
        /// > float health
        ///
        /// </summary>
        _SET_TYRE_HEALTH = 0x74C68EF97645E79D,
        /// <summary>
        /// Returns the multiplier value from _SET_TYRE_WEAR_MULTIPLIER
        /// 
        /// Usable wheels:
        /// 0: wheel_lf
        /// 1: wheel_rf
        /// 2: wheel_lm1
        /// 3: wheel_rm1
        /// 4: wheel_lr
        /// 5: wheel_rr
        ///
        /// > Vehicle vehicle
        /// > int wheelIndex
        ///
        /// </summary>
        _GET_TYRE_WEAR_MULTIPLIER = 0x6E387895952F4F71,
        /// <summary>
        /// Needs to be run for tire wear to work. Multiplier affects the downforce and how fast the tires will wear out, higher values essentially make the vehicle slower on straights and its tires will wear down quicker when cornering. Value must be >0f.
        /// Default value in Rockstar's Open Wheel Race JSON's ("owrtws", "owrtwm", "owrtwh") is 1.0
        /// 
        /// Usable wheels:
        /// 0: wheel_lf
        /// 1: wheel_rf
        /// 2: wheel_lm1
        /// 3: wheel_rm1
        /// 4: wheel_lr
        /// 5: wheel_rr
        ///
        /// > Vehicle vehicle
        /// > int wheelIndex
        /// > float multiplier
        ///
        /// </summary>
        _SET_TYRE_WEAR_MULTIPLIER = 0x01894E2EDE923CA2,
        /// <summary>
        /// Controls how fast the tires wear out.
        /// 
        /// Default values from Rockstar's Open Wheel Race JSON's:
        /// "owrtss" (Soft): 2.2
        /// "owrtsm" (Medium): 1.7
        /// "owrtsh" (Hard): 1.2
        /// 
        /// Usable wheels:
        /// 0: wheel_lf
        /// 1: wheel_rf
        /// 2: wheel_lm1
        /// 3: wheel_rm1
        /// 4: wheel_lr
        /// 5: wheel_rr
        ///
        /// > Vehicle vehicle
        /// > int wheelIndex
        /// > float multiplier
        ///
        /// </summary>
        _SET_TYRE_SOFTNESS_MULTIPLIER = 0x392183BB9EA57697,
        /// <summary>
        /// Controls how much traction the wheel loses.
        /// 
        /// Default values from Rockstar's Open Wheel Race JSON's:
        /// "owrtds" (Soft): 0.05
        /// "owrtdm" (Medium): 0.45
        /// "owrtdh" (Hard): 0.8
        /// 
        /// Usable wheels:
        /// 0: wheel_lf
        /// 1: wheel_rf
        /// 2: wheel_lm1
        /// 3: wheel_rm1
        /// 4: wheel_lr
        /// 5: wheel_rr
        ///
        /// > Vehicle vehicle
        /// > int wheelIndex
        /// > float multiplier
        ///
        /// </summary>
        _SET_TYRE_TRACTION_LOSS_MULTIPLIER = 0xC970D0E0FC31D768,
        /// <summary>
        /// Lowers the vehicle's stance. Only works for vehicles that support this feature.
        ///
        /// > Vehicle vehicle
        /// > BOOL enable
        ///
        /// </summary>
        _SET_REDUCE_DRIFT_VEHICLE_SUSPENSION = 0x3A375167F5782A65,
        /// <summary>
        /// Implemented only for trains.
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        _NETWORK_USE_HIGH_PRECISION_VEHICLE_BLENDING = 0xEC0C1D4922AF9754,
        /// <summary>
        /// SET_VEHICLE_AL*
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        /// > BOOL p2
        ///
        /// </summary>
        _0x7D6F9A3EF26136A0 = 0x7D6F9A3EF26136A0,
        /// <summary>
        /// Related to car generators & CPlayerSwitchMgrLong
        /// 
        /// SET_VEHICLE_*
        /// 
        /// SET_VEHICLE_GENERATORS_EXPECTED_GAMEPLAY_PT ?
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        ///
        /// </summary>
        _0x9A75585FB2E54FAD = 0x9A75585FB2E54FAD,
        /// <summary>
        /// CLEAR_VEHICLE_*
        ///
        ///
        /// </summary>
        _0x0A436B8643716D14 = 0x0A436B8643716D14,
        /// <summary>
        /// SET_VEHICLE_*
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _0x76D26A22750E849E = 0x76D26A22750E849E,
        /// <summary>
        /// Sets a value that appears to affect door opening behavior when damaged.
        /// 
        /// SET_*
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        _0x1B212B26DD3C04DF = 0x1B212B26DD3C04DF,
        /// <summary>
        /// No observed effect.
        ///
        /// > Vehicle vehicle
        /// > BOOL p1
        ///
        /// </summary>
        _0xB28B1FE5BFADD7F5 = 0xB28B1FE5BFADD7F5,
        /// <summary>
        /// Sets some bit of vehicle.
        /// _SET_VEHICLE_*
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        _0x9849DE24FCF23CCC = 0x9849DE24FCF23CCC,
        /// <summary>
        /// Used on helicopters and blimps during the CTaskVehicleLand task. Sets a value on the task to 10f
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _0x107A473D7A6647A9 = 0x107A473D7A6647A9,
        /// <summary>
        /// doorId: see SET_VEHICLE_DOOR_SHUT
        /// 
        /// Usually used alongside other vehicle door natives.
        ///
        /// > Vehicle vehicle
        /// > int doorId
        /// > BOOL toggle
        ///
        /// </summary>
        _0x3B458DDB57038F08 = 0x3B458DDB57038F08,
        /// <summary>
        /// Sets some bit of vehicle
        /// _SET_VEHICLE_*
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        _0x8821196D91FA2DE5 = 0x8821196D91FA2DE5,
        /// <summary>
        /// A vehicle recording playback flag only used in jewelry_heist
        ///
        /// > Vehicle vehicle
        /// > BOOL p1
        ///
        /// </summary>
        _0x063AE2B2CC273588 = 0x063AE2B2CC273588,
        /// <summary>
        /// Related to locking the vehicle or something similar.
        /// 
        /// In the decompiled scripts, its always called after
        /// VEHICLE::_SET_EXCLUSIVE_DRIVER(a_0, 0, 0);
        /// VEHICLE::SET_VEHICLE_DOORS_LOCKED_FOR_ALL_PLAYERS(a_0, 1);
        /// VEHICLE::SET_VEHICLE_DOORS_LOCKED_FOR_PLAYER(a_0, PLAYER::PLAYER_ID(), 0);
        /// -->VEHICLE::_DBC631F109350B8C(a_0, 1);
        ///
        /// > Vehicle vehicle
        /// > BOOL p1
        ///
        /// </summary>
        _0xDBC631F109350B8C = 0xDBC631F109350B8C,
        /// <summary>
        /// SET_VEHICLE_LI*
        ///
        /// > Vehicle vehicle
        /// > BOOL p1
        ///
        /// </summary>
        _0xC50CE861B55EAB8B = 0xC50CE861B55EAB8B,
        /// <summary>
        /// sfink: sets bit in vehicle's structure, used by maintransition, fm_mission_controller, mission_race and a couple of other scripts. see dissassembly: 
        /// CVehicle *__fastcall sub_140CDAA10(signed int a1, char a2)
        /// {
        ///     CVehicle *result; // rax@1
        /// 
        ///     result = EntityAsCVehicle(a1);
        ///     if ( result )
        ///     {
        ///         result->field_886 &= 0xEFu;
        ///         result->field_886 |= 16 * (a2 & 1);
        ///     }
        ///     return result;
        /// }
        ///
        /// > Vehicle vehicle
        /// > BOOL p1
        ///
        /// </summary>
        _0x6EBFB22D646FFC18 = 0x6EBFB22D646FFC18,
        /// <summary>
        /// Default:1000||This sets a value which is used when _0x51db102f4a3ba5e0(true) is called each frame.
        ///
        /// > int p0
        ///
        /// </summary>
        _0xA4A9A4C40E615885 = 0xA4A9A4C40E615885,
        /// <summary>
        /// Some kind of flags.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _0xEEBFC7A7EFDC35B4 = 0xEEBFC7A7EFDC35B4,
        /// <summary>
        /// Sets some health value. Looks like it's used for helis.
        ///
        /// > Vehicle vehicle
        /// > float health
        ///
        /// </summary>
        _0x5EE5632F47AE9695 = 0x5EE5632F47AE9695,
        /// <summary>
        /// Has something to do with trains. Always precedes SET_MISSION_TRAIN_AS_NO_LONGER_NEEDED.
        /// May be true that it can be used with trains not sure, but not specifically for trains. Go find Xbox360 decompiled scripts and search for 'func_1333' in freemode.c it isn't used just for trains. Thanks for the info tho.
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        _0x1CF38D529D7441D9 = 0x1CF38D529D7441D9,
        /// <summary>
        /// Sets some bit and float of vehicle. float is >= 0
        /// SET_VEHICLE_*
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        /// > float p2
        ///
        /// </summary>
        _0x59C3757B3B7408E8 = 0x59C3757B3B7408E8,
        /// <summary>
        /// what does this do?
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _0xCFD778E7904C255E = 0xCFD778E7904C255E,
        /// <summary>
        /// This native doesn't seem to do anything, might be a debug-only native.
        /// 
        /// Confirmed, it is a debug native.
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _0xB264C4D2F2B0A78B = 0xB264C4D2F2B0A78B,
        /// <summary>
        /// SET_VEHICLE_W* (next character is either H or I)
        ///
        /// > Vehicle vehicle
        /// > BOOL p1
        ///
        /// </summary>
        _0x2C4A1590ABF43E8B = 0x2C4A1590ABF43E8B,
        /// <summary>
        /// Seems to copy some values in vehicle
        ///
        /// > Vehicle vehicle
        /// > Any p1
        ///
        /// </summary>
        _0x6A973569BA094650 = 0x6A973569BA094650,
        /// <summary>
        /// Used to be incorrectly named SET_VEHICLE_EXCLUSIVE_DRIVER
        /// 
        /// Likely SET_VEHICLE_ALLOW_*
        /// 
        /// Jenkins hash may be wrong, unsure at this time.
        /// Toggles a flag related to SET_VEHICLE_EXCLUSIVE_DRIVER, however, doesn't enable that feature (or trigger script events related to it).
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        _0x41062318F23ED854 = 0x41062318F23ED854,
        /// <summary>
        /// Sets value for vehicle. Vehicle is a helicopter?
        /// _SET_HELICOPTER_*
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        _0xB68CFAF83A02768D = 0xB68CFAF83A02768D,
        /// <summary>
        /// Sets some float for vehicle (def -1f)
        /// SET_VEHICLE_*
        ///
        /// > Vehicle vehicle
        /// > float p1
        ///
        /// </summary>
        _0x0205F5365292D2EB = 0x0205F5365292D2EB,
        /// <summary>
        /// Sets some value for vehicle from array based on index
        /// _SET_VEHICLE_*
        ///
        /// > Vehicle vehicle
        /// > int index
        ///
        /// </summary>
        _0xB93B2867F7B479D1 = 0xB93B2867F7B479D1,
        /// <summary>
        /// Only used like this:
        /// 
        /// if (VEHICLE::_D4C4642CB7F50B5D(ENTITY::GET_VEHICLE_INDEX_FROM_ENTITY_INDEX(v_3))) {
        /// 	sub_157e9c(g_40001._f1868, 0);
        /// }
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _0xD4C4642CB7F50B5D = 0xD4C4642CB7F50B5D,
        /// <summary>
        /// CLEAR_VEHICLE_*
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _0x4419966C9936071A = 0x4419966C9936071A,
        /// <summary>
        /// SET_*
        ///
        /// > Vehicle vehicle
        /// > float x
        /// > float y
        /// > float z
        /// > float p4
        ///
        /// </summary>
        _0x428AD3E26C8D9EB0 = 0x428AD3E26C8D9EB0,
        /// <summary>
        /// RESET_*
        /// 
        /// Resets the effect of 0x428AD3E26C8D9EB0
        ///
        ///
        /// </summary>
        _0xE2F53F172B45EDE1 = 0xE2F53F172B45EDE1,
        /// <summary>
        /// SET_C*
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        _0xB2E0C0D6922D31F2 = 0xB2E0C0D6922D31F2,
        /// <summary>
        /// Sets some value for vehicle
        /// SET_VEHICLE_*
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        _0x8235F1BEAD557629 = 0x8235F1BEAD557629,
        /// <summary>
        /// Used on helicopters
        /// SET_HELICOPTER_??
        ///
        /// > Vehicle vehicle
        /// > float x
        /// > float y
        /// > float z
        ///
        /// </summary>
        _0x0A3F820A9A9A9AC5 = 0x0A3F820A9A9A9AC5,
        /// <summary>
        /// Used in decompiled scripts in combination with _GET_VEHICLE_SUSPENSION_BOUNDS
        /// p7 is usually 2
        /// p8 is usually 1
        ///
        /// > Vehicle vehicle
        /// > float x
        /// > float y
        /// > float z
        /// > float rotX
        /// > float rotY
        /// > float rotZ
        /// > int p7
        /// > Any p8
        ///
        /// </summary>
        _0x51F30DB60626A20E = 0x51F30DB60626A20E,
        /// <summary>
        /// Sets a flag on heli and another vehicle type.
        /// _SET_VEHICLE_??
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        _0x97841634EF7DF1D6 = 0x97841634EF7DF1D6,
        /// <summary>
        /// Sets some vehicle value
        /// _SET_VEHICLE_?
        ///
        /// > Vehicle vehicle
        /// > BOOL toggle
        ///
        /// </summary>
        _0xAA653AE61924B0A0 = 0xAA653AE61924B0A0,
        /// <summary>
        /// Sets some vehicle value to 1
        /// SET_VEHICLE_??
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _0x887FA38787DE8C72 = 0x887FA38787DE8C72,
        /// <summary>
        /// Does nothing. It's a nullsub.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _0x36DE109527A2C0C4 = 0x36DE109527A2C0C4,
        /// <summary>
        /// Does nothing. It's a nullsub.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _0x82E0AC411E41A5B4 = 0x82E0AC411E41A5B4,
        /// <summary>
        /// Does nothing. It's a nullsub.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _0x99A05839C46CE316 = 0x99A05839C46CE316,
        /// <summary>
        /// GET_H*
        ///
        /// > Vehicle vehicle
        ///
        /// </summary>
        _0xE8718FAF591FD224 = 0xE8718FAF591FD224,
        IS_VEHICLE_MODEL = 0x423E8DE37D934D89,
        DOES_SCRIPT_VEHICLE_GENERATOR_EXIST = 0xF6086BC836400876,
        DELETE_SCRIPT_VEHICLE_GENERATOR = 0x22102C9ABFCF125D,
        SET_ALL_VEHICLE_GENERATORS_ACTIVE_IN_AREA = 0xC12321827687FE4D,
        SET_ALL_VEHICLE_GENERATORS_ACTIVE = 0x34AD89078831A4BC,
        SET_ALL_LOW_PRIORITY_VEHICLE_GENERATORS_ACTIVE = 0x608207E7A8FB787C,
        SET_VEHICLE_USE_CUTSCENE_WHEEL_COMPRESSION = 0xE023E8AC4EF7C117,
        IS_VEHICLE_STUCK_ON_ROOF = 0xB497F06B288DCFDF,
        ADD_VEHICLE_UPSIDEDOWN_CHECK = 0xB72E26D81006005B,
        REMOVE_VEHICLE_UPSIDEDOWN_CHECK = 0xC53EB42A499A7E90,
        GET_VEHICLE_MAX_NUMBER_OF_PASSENGERS = 0xA7C4F2C6E744A550,
        IS_SEAT_WARP_ONLY = 0xF7F203E31F96F6A1,
        IS_TURRET_SEAT = 0xE33FFA906CE74880,
        SET_RANDOM_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME = 0xB3B3359379FE77D3,
        SET_PARKED_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME = 0xEAE6DCC7EEE3DB1D,
        SET_DISABLE_RANDOM_TRAINS_THIS_FRAME = 0xD4B8E3D1917BC86B,
        SET_AMBIENT_VEHICLE_RANGE_MULTIPLIER_THIS_FRAME = 0x90B6DA738A9A25DA,
        SET_FAR_DRAW_VEHICLES = 0x26324F33423F3CC3,
        SET_NUMBER_OF_PARKED_VEHICLES = 0xCAA15F13EBD417FF,
        SET_VEHICLE_DOORS_LOCKED_FOR_PLAYER = 0x517AAF684BB50CD1,
        GET_VEHICLE_DOORS_LOCKED_FOR_PLAYER = 0xF6AF6CB341349015,
        SET_VEHICLE_DOORS_LOCKED_FOR_NON_SCRIPT_PLAYERS = 0x9737A37136F07E75,
        SET_VEHICLE_DOORS_LOCKED_FOR_TEAM = 0xB81F6D4A8F5EEBA8,
        _SET_VEHICLE_DOORS_LOCKED_FOR_UNK = 0x203B527D1B77904C,
        SET_VEHICLE_TIMED_EXPLOSION = 0x2E0A74E1002380B1,
        ADD_VEHICLE_PHONE_EXPLOSIVE_DEVICE = 0x99AD4CCCB128CBC9,
        _CLEAR_VEHICLE_PHONE_EXPLOSIVE_DEVICE = 0xAA3F739ABDDCF21F,
        HAS_VEHICLE_PHONE_EXPLOSIVE_DEVICE = 0x6ADAABD3068C5235,
        DETONATE_VEHICLE_PHONE_EXPLOSIVE_DEVICE = 0xEF49CF0270307CBE,
        IS_TAXI_LIGHT_ON = 0x7504C0F113AB50FC,
        GET_VEHICLE_CUSTOM_PRIMARY_COLOUR = 0xB64CF2CCA9D95F52,
        CLEAR_VEHICLE_CUSTOM_PRIMARY_COLOUR = 0x55E1D2758F34E437,
        GET_IS_VEHICLE_PRIMARY_COLOUR_CUSTOM = 0xF095C0405307B21B,
        GET_VEHICLE_CUSTOM_SECONDARY_COLOUR = 0x8389CD56CA8072DC,
        CLEAR_VEHICLE_CUSTOM_SECONDARY_COLOUR = 0x5FFBDEEC3E8E2009,
        FORCE_SUBMARINE_SURFACE_MODE = 0x33506883545AC0DF,
        SET_SUBMARINE_CRUSH_DEPTHS = 0xC59872A5134879C7,
        _GET_SUBMARINE_IS_BELOW_FIRST_CRUSH_DEPTH = 0x3E71D0B300B7AA79,
        _GET_SUBMARINE_CRUSH_DEPTH_WARNING_STATE = 0x093D6DDCA5B8FBAE,
        SET_BOAT_ANCHOR = 0x75DBEC174AEEAD10,
        CAN_ANCHOR_BOAT_HERE = 0x26C10ECBDA5D043B,
        _CAN_ANCHOR_BOAT_HERE_2 = 0x24F4121D07579880,
        _SET_BOAT_FROZEN_WHEN_ANCHORED = 0xE3EBAAE484798530,
        _SET_BOAT_MOVEMENT_RESISTANCE = 0xE842A9398079BD82,
        SET_BOAT_SINKS_WHEN_WRECKED = 0x8F719973E1445BA2,
        _SET_BOAT_IS_SINKING = 0xBD32E46AA95C1DD2,
        IS_VEHICLE_SIREN_ON = 0x4C9BF537BE2634B2,
        IS_VEHICLE_SIREN_AUDIO_ON = 0xB5CC40FBCB586380,
        REMOVE_VEHICLE_STUCK_CHECK = 0x8386BFB614D06749,
        GET_VEHICLE_COLOURS = 0xA19435F193E081AC,
        GET_LAST_PED_IN_VEHICLE_SEAT = 0x83F969AA1EE2A664,
        GET_VEHICLE_LIGHTS_STATE = 0xB91B4C20085BD12F,
        IS_ENTITY_ATTACHED_TO_HANDLER_FRAME = 0x57715966069157AD,
        IS_ANY_ENTITY_ATTACHED_TO_HANDLER_FRAME = 0x62CA17B74C435651,
        _IS_HANDLER_FRAME_ABOVE_CONTAINER = 0x89D630CF5EA96D23,
        DETACH_CONTAINER_FROM_HANDLER_FRAME = 0x7C0043FDFF6436BC,
        SET_BOAT_DISABLE_AVOIDANCE = 0x0A6A279F3AA4FD70,
        IS_HELI_LANDING_AREA_BLOCKED = 0x634148744F385576,
        SET_HELI_TURBULENCE_SCALAR = 0xE6F13851780394DA,
        GET_VEHICLE_TYRES_CAN_BURST = 0x678B9BB8C3F58FEB,
        SET_VEHICLE_WHEELS_CAN_BREAK = 0x29B18B4FD460CA8F,
        _EJECT_JB700_ROOF = 0xE38CB9D7D39FDBCC,
        SET_VEHICLE_USE_PLAYER_LIGHT_SETTINGS = 0xC45C27EF50F36ADC,
        SET_VEHICLE_ALARM = 0xCDE5E70C1DDB954C,
        START_VEHICLE_ALARM = 0xB8FF7AB45305C345,
        IS_VEHICLE_ALARM_ACTIVATED = 0x4319E335B71FFF34,
        SET_VEHICLE_INTERIORLIGHT = 0xBC2042F090AF6AD3,
        ATTACH_VEHICLE_TO_TRAILER = 0x3C7D42D58F770B54,
        STABILISE_ENTITY_ATTACHED_TO_HELI = 0x374706271354CB18,
        DETACH_VEHICLE_FROM_TRAILER = 0x90532EDF0D2BDD86,
        IS_VEHICLE_ATTACHED_TO_TRAILER = 0xE7CF3C4F9F489F0C,
        SET_TRAILER_INVERSE_MASS_SCALE = 0x2A8F319B392E7B3F,
        _SET_TRAILER_LEGS_LOWERED = 0x878C75C09FBDB942,
        SET_RANDOM_TRAINS = 0x80D9F74197EA47D9,
        DELETE_ALL_TRAINS = 0x736A718577F39C7D,
        SET_TRAIN_SPEED = 0xAA0BC91BE0B796E3,
        SET_TRAIN_CRUISE_SPEED = 0x16469284DB8C62B5,
        SET_RANDOM_BOATS = 0x84436EC293B1415F,
        _SET_RANDOM_BOATS_IN_MP = 0xDA5E12F728DB30CA,
        SET_GARBAGE_TRUCKS = 0x2AFD795EEAC8D30D,
        GET_POSITION_OF_VEHICLE_RECORDING_ID_AT_TIME = 0x92523B76657A517D,
        GET_ROTATION_OF_VEHICLE_RECORDING_ID_AT_TIME = 0xF0F2103EFAF8CBA7,
        GET_TOTAL_DURATION_OF_VEHICLE_RECORDING_ID = 0x102D125411A7B6E6,
        STOP_PLAYBACK_RECORDED_VEHICLE = 0x54833611C17ABDEA,
        PAUSE_PLAYBACK_RECORDED_VEHICLE = 0x632A689BF42301B1,
        UNPAUSE_PLAYBACK_RECORDED_VEHICLE = 0x8879EE09268305D5,
        IS_PLAYBACK_GOING_ON_FOR_VEHICLE = 0x1C8A4C2C19E68EEC,
        IS_PLAYBACK_USING_AI_GOING_ON_FOR_VEHICLE = 0xAEA8FD591FAD4106,
        GET_CURRENT_PLAYBACK_FOR_VEHICLE = 0x42BC05C27A946054,
        SKIP_TO_END_AND_STOP_PLAYBACK_RECORDED_VEHICLE = 0xAB8E2EDA0C0A5883,
        SET_PLAYBACK_SPEED = 0x6683AB880E427778,
        EXPLODE_VEHICLE_IN_CUTSCENE = 0x786A4EB67B01BF0B,
        ADD_VEHICLE_STUCK_CHECK_WITH_WARP = 0x2FA9923062DD396C,
        GET_RANDOM_VEHICLE_FRONT_BUMPER_IN_SPHERE = 0xC5574E0AEB86BA68,
        GET_RANDOM_VEHICLE_BACK_BUMPER_IN_SPHERE = 0xB50807EABE20A8DC,
        _IS_MISSION_TRAIN = 0xAD464F2E18836BFC,
        DELETE_MISSION_TRAIN = 0x5B76B14AE875C795,
        SET_MISSION_TRAIN_COORDS = 0x591CA673AA6AB736,
        IS_THIS_MODEL_A_BOAT = 0x45A9187928F4B9E3,
        IS_THIS_MODEL_A_PLANE = 0xA0948AB42D7BA0DE,
        IS_THIS_MODEL_A_HELI = 0xDCE4334788AF94EA,
        IS_THIS_MODEL_A_TRAIN = 0xAB935175B22E822B,
        IS_THIS_MODEL_A_BIKE = 0xB50C0B0CEDC6CE84,
        IS_THIS_MODEL_A_BICYCLE = 0xBF94DD42F63BDED2,
        IS_THIS_MODEL_A_QUADBIKE = 0x39DAC362EE65FA28,
        _IS_THIS_MODEL_AN_AMPHIBIOUS_CAR = 0x633F6F44A537EBB6,
        _IS_THIS_MODEL_AN_AMPHIBIOUS_QUADBIKE = 0xA1A9FC1C76A6730D,
        SET_VEHICLE_CAN_BE_VISIBLY_DAMAGED = 0x4C7028F78FFD3681,
        SET_VEHICLE_HAS_UNBREAKABLE_LIGHTS = 0x1AA8A837D2169D94,
        SET_VEHICLE_UNDRIVEABLE = 0x8ABA6AF54B942B95,
        SET_VEHICLE_PROVIDES_COVER = 0x5AFEEDD9BB2899D7,
        SET_VEHICLE_CAN_BREAK = 0x59BF8C3D52C92F66,
        DOES_VEHICLE_HAVE_ROOF = 0x8AC862B0B32C5B80,
        IS_BIG_VEHICLE = 0x9F243D3919F442FE,
        GET_VEHICLE_COLOUR_COMBINATION = 0x6A842D197F845D56,
        IS_VEHICLE_BUMPER_BOUNCING = 0x27B926779DEB502D,
        IS_VEHICLE_BUMPER_BROKEN_OFF = 0x468056A6BB6F3846,
        GET_VEHICLE_LAYOUT_HASH = 0x28D37D4F71AC5C58,
        GET_VEHICLE_EXTRA_COLOURS = 0x3BC4245933A166F7,
        _SET_VEHICLE_INTERIOR_COLOR = 0xF40DD601A65F7F19,
        _GET_VEHICLE_INTERIOR_COLOR = 0x7D1464D472D32136,
        _SET_VEHICLE_DASHBOARD_COLOR = 0x6089CDF6A57F326C,
        _GET_VEHICLE_DASHBOARD_COLOR = 0xB7635E80A5C31BFF,
        STOP_ALL_GARAGE_ACTIVITY = 0x0F87E938BDF29D66,
        _SET_VEHICLE_CAN_ENGINE_OPERATE_ON_FIRE = 0x206BC5DC9D1AC70A,
        SET_VEHICLE_CAN_LEAK_OIL = 0x51BB2D88D31A914B,
        SET_VEHICLE_CAN_LEAK_PETROL = 0x192547247864DFDD,
        SET_DISABLE_VEHICLE_PETROL_TANK_FIRES = 0x465BF26AB9684352,
        SET_DISABLE_VEHICLE_PETROL_TANK_DAMAGE = 0x37C8252A7C92D017,
        SET_DISABLE_VEHICLE_ENGINE_FIRES = 0x91A0BD635321F145,
        SET_DISABLE_PRETEND_OCCUPANTS = 0x25367DE49D64CF16,
        REMOVE_VEHICLES_FROM_GENERATORS_IN_AREA = 0x46A1E1A299EC4BBA,
        IS_VEHICLE_EXTRA_TURNED_ON = 0xD2E6822DBFD6C8BD,
        SET_CONVERTIBLE_ROOF = 0xF39C4F538B5124C2,
        LOWER_CONVERTIBLE_ROOF = 0xDED51F703D0FA83D,
        RAISE_CONVERTIBLE_ROOF = 0x8F5FB35D7E88FC70,
        _GET_IS_SUBMARINE_VEHICLE_TRANSFORMED = 0xA77DC70BD689A1E5,
        SET_VEHICLE_HAS_BEEN_OWNED_BY_PLAYER = 0x2B5F9D2AF1F1722D,
        SET_VEHICLE_NEEDS_TO_BE_HOTWIRED = 0xFBA550EA44404EE6,
        SET_VEHICLE_LIVERY = 0x60BF608F1B8CD1B6,
        RESET_VEHICLE_WHEELS = 0x21D2E5662C1F6FED,
        IS_HELI_PART_BROKEN = 0xBC74B4BE25EB6C8A,
        _SET_HELI_MAIN_ROTOR_HEALTH = 0x4056EA1105F5ABD7,
        _SET_HELI_TAIL_ROTOR_HEALTH = 0xFE205F38AAA58E5B,
        SET_HELI_TAIL_EXPLODE_THROW_DASHBOARD = 0x3EC8BF18AA453FE9,
        SET_VEHICLE_DISABLE_TOWING = 0x2B6747FAA9DB9D6B,
        _DOES_VEHICLE_HAVE_LANDING_GEAR = 0xE43701C36CAFF1A4,
        IS_ANY_VEHICLE_NEAR_POINT = 0x61E1DD6125A3EEE6,
        REQUEST_VEHICLE_HIGH_DETAIL_MODEL = 0xA6E9FDCB2C76785E,
        REMOVE_VEHICLE_HIGH_DETAIL_MODEL = 0x00689CDE5F7C6787,
        IS_VEHICLE_HIGH_DETAIL = 0x1F25887F3C104278,
        HAS_VEHICLE_ASSET_LOADED = 0x1BBE0523B8DB9A21,
        REMOVE_VEHICLE_ASSET = 0xACE699C71AB9DEB5,
        DETACH_VEHICLE_FROM_ANY_TOW_TRUCK = 0xD0E9CE05A1E68CD8,
        GET_ENTITY_ATTACHED_TO_TOW_TRUCK = 0xEFEA18DCF10F8F75,
        SET_VEHICLE_AUTOMATICALLY_ATTACHES = 0x8BA6F76BC53A1493,
        SET_VEHICLE_TANK_TURRET_POSITION = 0x56B94C6D7127DFBA,
        SET_VEHICLE_TURRET_SPEED_THIS_FRAME = 0x1093408B4B9D1146,
        _DISABLE_VEHICLE_TURRET_MOVEMENT_THIS_FRAME = 0x32CAEDF24A583345,
        SET_VEHICLE_FLIGHT_NOZZLE_POSITION = 0x30D779DE7C4F6DD3,
        SET_VEHICLE_FLIGHT_NOZZLE_POSITION_IMMEDIATE = 0x9AA47FFF660CB932,
        _GET_VEHICLE_FLIGHT_NOZZLE_POSITION = 0xDA62027C8BDB326E,
        SET_VEHICLE_BRAKE_LIGHTS = 0x92B35082E0B42F66,
        SET_VEHICLE_HANDBRAKE = 0x684785568EF26A22,
        SET_VEHICLE_BRAKE = 0xE4E2FD323574965C,
        INSTANTLY_FILL_VEHICLE_POPULATION = 0x48ADC8A773564670,
        SET_VEHICLE_RUDDER_BROKEN = 0x09606148B6C71DEF,
        SET_CONVERTIBLE_ROOF_LATCH_STATE = 0x1A78AD3D8240536F,
        GET_VEHICLE_ESTIMATED_MAX_SPEED = 0x53AF99BAA671CA47,
        GET_VEHICLE_MAX_BRAKING = 0xAD7E85FC227197C4,
        GET_VEHICLE_MAX_TRACTION = 0xA132FB5370554DB0,
        GET_VEHICLE_CLASS_ESTIMATED_MAX_SPEED = 0x00C09F246ABEDD82,
        GET_VEHICLE_CLASS_MAX_TRACTION = 0xDBC86D85C5059461,
        GET_VEHICLE_CLASS_MAX_AGILITY = 0x4F930AD022D6DE3B,
        GET_VEHICLE_CLASS_MAX_ACCELERATION = 0x2F83E7E45D9EA7AE,
        GET_VEHICLE_CLASS_MAX_BRAKING = 0x4BF54C16EC8FEC03,
        ADD_ROAD_NODE_SPEED_ZONE = 0x2CE544C68FB812A0,
        REMOVE_ROAD_NODE_SPEED_ZONE = 0x1033371FC8E842A7,
        OPEN_BOMB_BAY_DOORS = 0x87E7F24270732CB1,
        CLOSE_BOMB_BAY_DOORS = 0x3556041742A0DC74,
        _DOES_VEHICLE_HAVE_SEARCHLIGHT = 0x99015ED7DBEA5113,
        CAN_SHUFFLE_SEAT = 0x30785D90C956BF35,
        GET_NUM_MOD_KITS = 0x33F2E3FE70EAAE1D,
        GET_VEHICLE_MOD_KIT = 0x6325D1A044AE510D,
        GET_VEHICLE_MOD_KIT_TYPE = 0xFC058F5121E54C32,
        GET_VEHICLE_MOD_COLOR_1 = 0xE8D65CA700C9A693,
        GET_VEHICLE_MOD_COLOR_2 = 0x81592BE4E3878728,
        HAVE_VEHICLE_MODS_STREAMED_IN = 0x9A83F5F9963775EF,
        REMOVE_VEHICLE_MOD = 0x92D619E420858204,
        IS_TOGGLE_MOD_ON = 0x84B233A8C8FC8AE7,
        GET_VEHICLE_MOD_MODIFIER_VALUE = 0x90A38E9838E0A8C1,
        PRELOAD_VEHICLE_MOD = 0x758F49C24925568A,
        HAS_PRELOAD_MODS_FINISHED = 0x06F43E5175EB6D96,
        RELEASE_PRELOAD_MODS = 0x445D79F995508307,
        GET_VEHICLE_TYRE_SMOKE_COLOR = 0xB635392A4938B3C3,
        GET_VEHICLE_WINDOW_TINT = 0x0EE21293DAD47C95,
        GET_NUM_VEHICLE_WINDOW_TINTS = 0x9D1224004B3A6707,
        MODIFY_VEHICLE_TOP_SPEED = 0x93A3996368C94158,
        ADD_VEHICLE_COMBAT_ANGLED_AVOIDANCE_AREA = 0x54B0F614960F4A5F,
        REMOVE_VEHICLE_COMBAT_AVOIDANCE_AREA = 0xE30524E1871F481D,
        IS_ANY_PED_RAPPELLING_FROM_HELI = 0x291E373D483E7EE7,
        _GET_BOAT_BOOM_POSITION_RATIO_3 = 0x0F3B4D4E43177236,
        GET_BOAT_BOOM_POSITION_RATIO = 0x6636C535F6CC2725,
        DISABLE_PLANE_AILERON = 0x23428FC53C60919C,
        SET_VEHICLE_USE_ALTERNATE_HANDLING = 0x1D97D1E3A70A649F,
        SET_LAST_DRIVEN_VEHICLE = 0xACFB2463CC22BED2,
        GET_LAST_DRIVEN_VEHICLE = 0xB2D06FAEDE65B577,
        CLEAR_LAST_DRIVEN_VEHICLE = 0xE01903C47C7AC89E,
        SET_VEHICLE_HAS_BEEN_DRIVEN_FLAG = 0x02398B627547189C,
        SET_TASK_VEHICLE_GOTO_PLANE_MIN_HEIGHT_ABOVE_TERRAIN = 0xB893215D8D4C015B,
        SET_VEHICLE_LOD_MULTIPLIER = 0x93AE6A61BE015BF1,
        SET_VEHICLE_CAN_SAVE_IN_GARAGE = 0x428BACCDF5E26EAD,
        _GET_VEHICLE_NUMBER_OF_BROKEN_BONES = 0x2C8CBFE1EA5FC631,
        SET_LIGHTS_CUTOFF_DISTANCE_TWEAK = 0xBC3CCA5844452B06,
        GET_VEHICLE_LOCK_ON_TARGET = 0x8F5EBAB1F260CFCE,
        SET_FORCE_HD_VEHICLE = 0x97CE68CB032583F0,
        GET_VEHICLE_PLATE_TYPE = 0x9CCC9525BF2408E0,
        SET_VEHICLE_GRAVITY = 0x89F149B6131E57DA,
        SET_VEHICLE_INACTIVE_DURING_PLAYBACK = 0x06582AFF74894C75,
        SET_VEHICLE_ACTIVE_DURING_PLAYBACK = 0xDFFCEF48E511DB48,
        SET_VEHICLE_ENGINE_CAN_DEGRADE = 0x983765856F2564F9,
        IS_PLANE_LANDING_GEAR_INTACT = 0x4198AB0022B15F87,
        ARE_PLANE_PROPELLERS_INTACT = 0x755D6D5267CBBD7E,
        _SET_PLANE_PROPELLERS_HEALTH = 0x4C815EB175086F84,
        SET_VEHICLE_CAN_DEFORM_WHEELS = 0x0CDDA42F9E360CA6,
        IS_VEHICLE_STOLEN = 0x4AF9BD80EEBEB453,
        SET_VEHICLE_IS_STOLEN = 0x67B2C79AA7FF5738,
        DETACH_VEHICLE_FROM_CARGOBOB = 0x0E21D3DF1051399D,
        DETACH_VEHICLE_FROM_ANY_CARGOBOB = 0xADF7BE450512C12F,
        _DETACH_ENTITY_FROM_CARGOBOB = 0xAF03011701811146,
        IS_VEHICLE_ATTACHED_TO_CARGOBOB = 0xD40148F22E81A1D9,
        _GET_ENTITY_ATTACHED_TO_CARGOBOB = 0x99093F60746708CA,
        ATTACH_VEHICLE_TO_CARGOBOB = 0x4127F1D84E347769,
        _ATTACH_ENTITY_TO_CARGOBOB = 0xA1DD82F3CCF9A01E,
        SET_CARGOBOB_PICKUP_ROPE_DAMPING_MULTIPLIER = 0xCF1182F682F65307,
        SET_CARGOBOB_PICKUP_ROPE_TYPE = 0x0D5F65A8F4EBDAB5,
        SET_CARGOBOB_PICKUP_MAGNET_STRENGTH = 0xBCBFCD9D1DAC19E2,
        SET_CARGOBOB_PICKUP_MAGNET_EFFECT_RADIUS = 0xA17BAD153B51547E,
        SET_CARGOBOB_PICKUP_MAGNET_REDUCED_FALLOFF = 0x66979ACF5102FD2F,
        SET_CARGOBOB_PICKUP_MAGNET_PULL_ROPE_LENGTH = 0x6D8EAC07506291FB,
        SET_CARGOBOB_PICKUP_MAGNET_PULL_STRENGTH = 0xED8286F71A819BAA,
        SET_CARGOBOB_PICKUP_MAGNET_FALLOFF = 0x685D5561680D088B,
        SET_CARGOBOB_PICKUP_MAGNET_REDUCED_STRENGTH = 0xE301BD63E9E13CF0,
        DOES_VEHICLE_HAVE_WEAPONS = 0x25ECB9F8017D98E0,
        _IS_VEHICLE_WEAPON_DISABLED = 0x563B65A643ED072E,
        SET_VEHICLE_ACTIVE_FOR_PED_NAVIGATION = 0x21115BCD6E44656A,
        SET_PLAYERS_LAST_VEHICLE = 0xBCDF8BAF56C87B6A,
        SET_VEHICLE_CAN_BE_USED_BY_FLEEING_PEDS = 0x300504B23BD3B711,
        SET_VEHICLE_STEERING_BIAS_SCALAR = 0x9007A2F21DC108D4,
        SET_VEHICLE_WHEELS_CAN_BREAK_OFF_WHEN_BLOW_UP = 0xA37B9A517B133349,
        SET_VEHICLE_CEILING_HEIGHT = 0xA46413066687A328,
        CLEAR_VEHICLE_ROUTE_HISTORY = 0x6D6AF961B72728AE,
        DOES_VEHICLE_EXIST_WITH_DECORATOR = 0x956B409B984D9BF7,
        _IS_PED_EXCLUSIVE_DRIVER_OF_VEHICLE = 0xB09D25E77C33EB3F,
        DISABLE_INDIVIDUAL_PLANE_PROPELLER = 0x500873A45724C863,
        SET_VEHICLE_FORCE_AFTERBURNER = 0xB055A34527CB8FD7,
        _DISABLE_VEHICLE_NEON_LIGHTS = 0x83F813570FF519DE,
        _SET_DISABLE_SUPERDUMMY_MODE = 0xB088E9A47AE6EDD5,
        _GET_NUMBER_OF_VEHICLE_DOORS = 0x92922A607497B14D,
        _SET_HYDRAULIC_RAISED = 0x28B18377EB6E25F6,
        SET_VEHICLE_KERS_ALLOWED = 0x99C82F8A139F3E4E,
        _GET_HYDRAULIC_WHEEL_VALUE = 0x0BB5CBDDD0F25AE3,
        _SET_CAMBERED_WHEELS_DISABLED = 0x1201E8A3290A3B98,
        _SET_HYDRAULIC_WHEEL_STATE = 0x8EA86DF356801C7D,
        _SET_VEHICLE_UNK_DAMAGE_MULTIPLIER = 0x45A561A9421AB6AD,
        _SET_VEHICLE_RAMP_LAUNCH_MODIFIER = 0xEFC13B1CE30D755D,
        _SET_VEHICLE_ROCKET_BOOST_REFILL_TIME = 0xE00F2AB100B76E89,
        _GET_HAS_ROCKET_BOOST = 0x36D782F68B309BDA,
        _IS_VEHICLE_ROCKET_BOOST_ACTIVE = 0x3D34E80EED4AE3BE,
        _SET_VEHICLE_ROCKET_BOOST_ACTIVE = 0x81E1552E35DC3839,
        _GET_HAS_RETRACTABLE_WHEELS = 0xDCA174A42133F08C,
        _GET_IS_WHEELS_LOWERED_STATE_ACTIVE = 0x1DA0DA9CB3F0C8BF,
        _RAISE_RETRACTABLE_WHEELS = 0xF660602546D27BA8,
        _LOWER_RETRACTABLE_WHEELS = 0x5335BE58C083E74E,
        _GET_VEHICLE_WEAPON_CAPACITY = 0x8181CE2F25CB9BB7,
        _GET_VEHICLE_HAS_PARACHUTE = 0xBC9CFF381338CB4F,
        _GET_VEHICLE_CAN_ACTIVATE_PARACHUTE = 0xA916396DF4154EE3,
        _SET_VEHICLE_PARACHUTE_ACTIVE = 0x0BFFB028B3DD0A97,
        _SET_VEHICLE_RECEIVES_RAMP_DAMAGE = 0x28D034A93FE31BF5,
        _SET_VEHICLE_RAMP_SIDEWAYS_LAUNCH_MOTION = 0x1BBAC99C0BC53656,
        _SET_VEHICLE_RAMP_UPWARDS_LAUNCH_MOTION = 0x756AE6E962168A04,
        _SET_VEHICLE_WEAPONS_DISABLED = 0x86B4B6212CB8B627,
        _GET_ALL_VEHICLES = 0x9B8E1BF04B51F2E8,
        _SET_VEHICLE_ROCKET_BOOST_PERCENTAGE = 0xFEB2DDED3509562E,
        _SET_VEHICLE_HOVER_TRANSFORM_RATIO = 0xD138FA15C9776837,
        _SET_SPECIALFLIGHT_WING_RATIO = 0x70A252F60A3E036B,
        _SET_UNK_FLOAT_0x104_FOR_SUBMARINE_VEHICLE_TASK = 0x498218259FB7C72D,
        _SET_UNK_BOOL_0x102_FOR_SUBMARINE_VEHICLE_TASK = 0x41B9FB92EDED32A6,
        _GET_IS_VEHICLE_SHUNT_BOOST_ACTIVE = 0xA2459F72C14E2E8D,
        _SET_DISABLE_VEHICLE_UNK = 0x143921E45EC44D62,
        _SET_VEHICLE_NITRO_ENABLED = 0xC8E9B6B71B8E660D,
        _SET_VEHICLE_WHEELS_DEAL_DAMAGE = 0x2970EAA18FD5E42F,
        _GET_DOES_VEHICLE_HAVE_TOMBSTONE = 0x71AFB258CCED3A27,
        _SET_DRIFT_TYRES_ENABLED = 0x5AC79C98C5C17F05,
        _GET_DRIFT_TYRES_ENABLED = 0x2F5A72430E78C8D3,
        _0x6EAAEFC76ACC311F = 0x6EAAEFC76ACC311F,
        _0x407DC5E97DB1A4D3 = 0x407DC5E97DB1A4D3,
        _0xAB31EF4DE6800CE9 = 0xAB31EF4DE6800CE9,
        _0xC67DB108A9ADE3BE = 0xC67DB108A9ADE3BE,
        _0xED5EDE9E676643C9 = 0xED5EDE9E676643C9,
        _0x6501129C9E0FFA05 = 0x6501129C9E0FFA05,
        _0xDCE97BDF8A0EABC8 = 0xDCE97BDF8A0EABC8,
        _0x8664170EF165C4A6 = 0x8664170EF165C4A6,
        _0x6A98C2ECF57FA5D4 = 0x6A98C2ECF57FA5D4,
        _0x8AA9180DE2FEDD45 = 0x8AA9180DE2FEDD45,
        _0xA247F9EF01D8082E = 0xA247F9EF01D8082E,
        _0x2310A8F9421EBF43 = 0x2310A8F9421EBF43,
        _0x5845066D8A1EA7F7 = 0x5845066D8A1EA7F7,
        _0x796A877E459B99EA = 0x796A877E459B99EA,
        _0xFAF2A78061FD9EF4 = 0xFAF2A78061FD9EF4,
        _0x99CAD8E7AFDB60FA = 0x99CAD8E7AFDB60FA,
        _0x2311DD7159F00582 = 0x2311DD7159F00582,
        _0x065D03A9D6B2C6B5 = 0x065D03A9D6B2C6B5,
        _0xC4B3347BD68BD609 = 0xC4B3347BD68BD609,
        _0xD3301660A57C9272 = 0xD3301660A57C9272,
        _0xB9562064627FF9DB = 0xB9562064627FF9DB,
        _0xBE5C1255A1830FF5 = 0xBE5C1255A1830FF5,
        _0x9BECD4B9FEF3F8A6 = 0x9BECD4B9FEF3F8A6,
        _0x88BC673CA9E0AE99 = 0x88BC673CA9E0AE99,
        _0xE851E480B814D4BA = 0xE851E480B814D4BA,
        _0xA01BC64DD4BFBBAC = 0xA01BC64DD4BFBBAC,
        _0x35BB21DE06784373 = 0x35BB21DE06784373,
        _0x9F3F689B814F2599 = 0x9F3F689B814F2599,
        _0x4E74E62E0A97E901 = 0x4E74E62E0A97E901,
        _0xD565F438137F0E10 = 0xD565F438137F0E10,
        _0x3441CAD2F2231923 = 0x3441CAD2F2231923,
        _0x0581730AB9380412 = 0x0581730AB9380412,
        _0x737E398138550FFF = 0x737E398138550FFF,
        _0xA4822F1CF23F4810 = 0xA4822F1CF23F4810,
        _0x51DB102F4A3BA5E0 = 0x51DB102F4A3BA5E0,
        _0x1F9FB66F3A3842D2 = 0x1F9FB66F3A3842D2,
        _0x0AD9E8F87FF7C16F = 0x0AD9E8F87FF7C16F,
        _0xAB04325045427AAE = 0xAB04325045427AAE,
        _0x4D9D109F63FEE1D4 = 0x4D9D109F63FEE1D4,
        _0xF25E02CB9C5818F8 = 0xF25E02CB9C5818F8,
        _0x182F266C2D9E2BEB = 0x182F266C2D9E2BEB,
        _0xF051D9BFB6BA39C0 = 0xF051D9BFB6BA39C0,
        _0x1F34B0626C594380 = 0x1F34B0626C594380,
        _0x2C1D8B3B19E517CC = 0x2C1D8B3B19E517CC,
        _0xC0ED6438E6D39BA8 = 0xC0ED6438E6D39BA8,
        _0x9BDDC73CC6A115D4 = 0x9BDDC73CC6A115D4,
        _0x56EB5E94318D3FB6 = 0x56EB5E94318D3FB6,
        _0xE05DD0E9707003A3 = 0xE05DD0E9707003A3,
        _0xE5810AC70602F2F5 = 0xE5810AC70602F2F5,
        _0xF78F94D60248C737 = 0xF78F94D60248C737,
        _0x5E569EC46EC21CAE = 0x5E569EC46EC21CAE,
        _0x4AD280EB48B2D8E6 = 0x4AD280EB48B2D8E6,
        _0xCF9159024555488C = 0xCF9159024555488C,
        _0x35E0654F4BAD7971 = 0x35E0654F4BAD7971,
        _0xA7DCDF4DED40A8F4 = 0xA7DCDF4DED40A8F4,
        _0xC361AA040D6637A8 = 0xC361AA040D6637A8,
        _0xE16142B94664DEFD = 0xE16142B94664DEFD,
        _0x26D99D5A82FD18E8 = 0x26D99D5A82FD18E8,
        _0x5BA68A0840D546AC = 0x5BA68A0840D546AC,
        _0x870B8B7A766615C8 = 0x870B8B7A766615C8,
        _0x8533CAFDE1F0F336 = 0x8533CAFDE1F0F336,
        _0xD4196117AF7BB974 = 0xD4196117AF7BB974,
        _0xBB2333BB87DDD87F = 0xBB2333BB87DDD87F,
        _0x73561D4425A021A2 = 0x73561D4425A021A2,
        _0x7BBE7FF626A591FE = 0x7BBE7FF626A591FE,
        _0x65B080555EA48149 = 0x65B080555EA48149,
        _0xBA91D045575699AD = 0xBA91D045575699AD,
        _0x80E3357FDEF45C21 = 0x80E3357FDEF45C21,
        _0x3DE51E9C80B116CF = 0x3DE51E9C80B116CF,
        _0x9D30687C57BAA0BB = 0x9D30687C57BAA0BB,
        _0x41290B40FA63E6DA = 0x41290B40FA63E6DA,
        _0x0419B167EE128F33 = 0x0419B167EE128F33,
        _0xF3B0E0AED097A3F5 = 0xF3B0E0AED097A3F5,
        _0xD3E51C0AB8C26EEE = 0xD3E51C0AB8C26EEE,
        _0x72BECCF4B829522E = 0x72BECCF4B829522E,
        _0x66E3AAFACE2D1EB8 = 0x66E3AAFACE2D1EB8,
        _0x1312DDD8385AEE4E = 0x1312DDD8385AEE4E,
        _0xEDBC8405B3895CC9 = 0xEDBC8405B3895CC9,
        _0x26E13D440E7F6064 = 0x26E13D440E7F6064,
        _0x2FA2494B47FDD009 = 0x2FA2494B47FDD009,
        _0x78CEEE41F49F421F = 0x78CEEE41F49F421F,
        _0xAF60E6A2936F982A = 0xAF60E6A2936F982A,
        _0x430A7631A84C9BE7 = 0x430A7631A84C9BE7,
        _0x9640E30A7F395E4B = 0x9640E30A7F395E4B,
        _0x0BBB9A7A8FFE931B = 0x0BBB9A7A8FFE931B,
        _0x3A9128352EAC9E85 = 0x3A9128352EAC9E85,
        _0x5BBCF35BF6E456F7 = 0x5BBCF35BF6E456F7,
        _0x8F0D5BA1C2CC91D7 = 0x8F0D5BA1C2CC91D7,
        _0xF8B49F5BA7F850E7 = 0xF8B49F5BA7F850E7,
    }
}