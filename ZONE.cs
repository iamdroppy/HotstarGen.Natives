using System;
namespace Hotstar
{
    public enum ZONE : ulong
    { 
        /// <summary>
        /// 'zoneName' corresponds to an entry in 'popzone.ipl'.
        /// 
        /// AIRP = Los Santos International Airport
        /// ALAMO = Alamo Sea
        /// ALTA = Alta
        /// ARMYB = Fort Zancudo
        /// BANHAMC = Banham Canyon Dr
        /// BANNING = Banning
        /// BEACH = Vespucci Beach
        /// BHAMCA = Banham Canyon
        /// BRADP = Braddock Pass
        /// BRADT = Braddock Tunnel
        /// BURTON = Burton
        /// CALAFB = Calafia Bridge
        /// CANNY = Raton Canyon
        /// CCREAK = Cassidy Creek
        /// CHAMH = Chamberlain Hills
        /// CHIL = Vinewood Hills
        /// CHU = Chumash
        /// CMSW = Chiliad Mountain State Wilderness
        /// CYPRE = Cypress Flats
        /// DAVIS = Davis
        /// DELBE = Del Perro Beach
        /// DELPE = Del Perro
        /// DELSOL = La Puerta
        /// DESRT = Grand Senora Desert
        /// DOWNT = Downtown
        /// DTVINE = Downtown Vinewood
        /// EAST_V = East Vinewood
        /// EBURO = El Burro Heights
        /// ELGORL = El Gordo Lighthouse
        /// ELYSIAN = Elysian Island
        /// GALFISH = Galilee
        /// GOLF = GWC and Golfing Society
        /// GRAPES = Grapeseed
        /// GREATC = Great Chaparral
        /// HARMO = Harmony
        /// HAWICK = Hawick
        /// HORS = Vinewood Racetrack
        /// HUMLAB = Humane Labs and Research
        /// JAIL = Bolingbroke Penitentiary
        /// KOREAT = Little Seoul
        /// LACT = Land Act Reservoir
        /// LAGO = Lago Zancudo
        /// LDAM = Land Act Dam
        /// LEGSQU = Legion Square
        /// LMESA = La Mesa
        /// LOSPUER = La Puerta
        /// MIRR = Mirror Park
        /// MORN = Morningwood
        /// MOVIE = Richards Majestic
        /// MTCHIL = Mount Chiliad
        /// MTGORDO = Mount Gordo
        /// MTJOSE = Mount Josiah
        /// MURRI = Murrieta Heights
        /// NCHU = North Chumash
        /// NOOSE = N.O.O.S.E
        /// OCEANA = Pacific Ocean
        /// PALCOV = Paleto Cove
        /// PALETO = Paleto Bay
        /// PALFOR = Paleto Forest
        /// PALHIGH = Palomino Highlands
        /// PALMPOW = Palmer-Taylor Power Station
        /// PBLUFF = Pacific Bluffs
        /// PBOX = Pillbox Hill
        /// PROCOB = Procopio Beach
        /// RANCHO = Rancho
        /// RGLEN = Richman Glen
        /// RICHM = Richman
        /// ROCKF = Rockford Hills
        /// RTRAK = Redwood Lights Track
        /// SANAND = San Andreas
        /// SANCHIA = San Chianski Mountain Range
        /// SANDY = Sandy Shores
        /// SKID = Mission Row
        /// SLAB = Stab City
        /// STAD = Maze Bank Arena
        /// STRAW = Strawberry
        /// TATAMO = Tataviam Mountains
        /// TERMINA = Terminal
        /// TEXTI = Textile City
        /// TONGVAH = Tongva Hills
        /// TONGVAV = Tongva Valley
        /// VCANA = Vespucci Canals
        /// VESP = Vespucci
        /// VINE = Vinewood
        /// WINDF = Ron Alternates Wind Farm
        /// WVINE = West Vinewood
        /// ZANCUDO = Zancudo River
        /// ZP_ORT = Port of South Los Santos
        /// ZQ_UAR = Davis Quartz
        /// 
        /// Full list of zones by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/zones.json
        ///
        /// > const char* zoneName
        ///
        /// </summary>
        GET_ZONE_FROM_NAME_ID = 0x98CD1D2934B76CC1,
        /// <summary>
        /// AIRP = Los Santos International Airport
        /// ALAMO = Alamo Sea
        /// ALTA = Alta
        /// ARMYB = Fort Zancudo
        /// BANHAMC = Banham Canyon Dr
        /// BANNING = Banning
        /// BEACH = Vespucci Beach
        /// BHAMCA = Banham Canyon
        /// BRADP = Braddock Pass
        /// BRADT = Braddock Tunnel
        /// BURTON = Burton
        /// CALAFB = Calafia Bridge
        /// CANNY = Raton Canyon
        /// CCREAK = Cassidy Creek
        /// CHAMH = Chamberlain Hills
        /// CHIL = Vinewood Hills
        /// CHU = Chumash
        /// CMSW = Chiliad Mountain State Wilderness
        /// CYPRE = Cypress Flats
        /// DAVIS = Davis
        /// DELBE = Del Perro Beach
        /// DELPE = Del Perro
        /// DELSOL = La Puerta
        /// DESRT = Grand Senora Desert
        /// DOWNT = Downtown
        /// DTVINE = Downtown Vinewood
        /// EAST_V = East Vinewood
        /// EBURO = El Burro Heights
        /// ELGORL = El Gordo Lighthouse
        /// ELYSIAN = Elysian Island
        /// GALFISH = Galilee
        /// GOLF = GWC and Golfing Society
        /// GRAPES = Grapeseed
        /// GREATC = Great Chaparral
        /// HARMO = Harmony
        /// HAWICK = Hawick
        /// HORS = Vinewood Racetrack
        /// HUMLAB = Humane Labs and Research
        /// JAIL = Bolingbroke Penitentiary
        /// KOREAT = Little Seoul
        /// LACT = Land Act Reservoir
        /// LAGO = Lago Zancudo
        /// LDAM = Land Act Dam
        /// LEGSQU = Legion Square
        /// LMESA = La Mesa
        /// LOSPUER = La Puerta
        /// MIRR = Mirror Park
        /// MORN = Morningwood
        /// MOVIE = Richards Majestic
        /// MTCHIL = Mount Chiliad
        /// MTGORDO = Mount Gordo
        /// MTJOSE = Mount Josiah
        /// MURRI = Murrieta Heights
        /// NCHU = North Chumash
        /// NOOSE = N.O.O.S.E
        /// OCEANA = Pacific Ocean
        /// PALCOV = Paleto Cove
        /// PALETO = Paleto Bay
        /// PALFOR = Paleto Forest
        /// PALHIGH = Palomino Highlands
        /// PALMPOW = Palmer-Taylor Power Station
        /// PBLUFF = Pacific Bluffs
        /// PBOX = Pillbox Hill
        /// PROCOB = Procopio Beach
        /// RANCHO = Rancho
        /// RGLEN = Richman Glen
        /// RICHM = Richman
        /// ROCKF = Rockford Hills
        /// RTRAK = Redwood Lights Track
        /// SANAND = San Andreas
        /// SANCHIA = San Chianski Mountain Range
        /// SANDY = Sandy Shores
        /// SKID = Mission Row
        /// SLAB = Stab City
        /// STAD = Maze Bank Arena
        /// STRAW = Strawberry
        /// TATAMO = Tataviam Mountains
        /// TERMINA = Terminal
        /// TEXTI = Textile City
        /// TONGVAH = Tongva Hills
        /// TONGVAV = Tongva Valley
        /// VCANA = Vespucci Canals
        /// VESP = Vespucci
        /// VINE = Vinewood
        /// WINDF = Ron Alternates Wind Farm
        /// WVINE = West Vinewood
        /// ZANCUDO = Zancudo River
        /// ZP_ORT = Port of South Los Santos
        /// ZQ_UAR = Davis Quartz
        /// 
        /// Full list of zones by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/zones.json
        ///
        /// > float x
        /// > float y
        /// > float z
        ///
        /// </summary>
        GET_NAME_OF_ZONE = 0xCD90657D4C30E1CA,
        /// <summary>
        /// cellphone range 1- 5 used for signal bar in iFruit phone
        ///
        /// > int zoneId
        ///
        /// </summary>
        GET_ZONE_SCUMMINESS = 0x5F7B268D15BA0739,
        /// <summary>
        /// Only used once in the decompiled scripts. Seems to be related to scripted vehicle generators.
        /// 
        /// Modified example from "am_imp_exp.c4", line 6406:
        /// /* popSchedules[0] = ZONE::GET_ZONE_POPSCHEDULE(ZONE::GET_ZONE_AT_COORDS(891.3, 807.9, 188.1));
        /// etc.
        /// */
        /// ZONE::OVERRIDE_POPSCHEDULE_VEHICLE_MODEL(popSchedules[index], vehicleHash);
        /// STREAMING::REQUEST_MODEL(vehicleHash);
        ///
        /// > int scheduleId
        /// > Hash vehicleHash
        ///
        /// </summary>
        OVERRIDE_POPSCHEDULE_VEHICLE_MODEL = 0x5F7D596BAC2E7777,
        /// <summary>
        /// Only used once in the decompiled scripts. Seems to be related to scripted vehicle generators.
        /// 
        /// Modified example from "am_imp_exp.c4", line 6418:
        /// /* popSchedules[0] = ZONE::GET_ZONE_POPSCHEDULE(ZONE::GET_ZONE_AT_COORDS(891.3, 807.9, 188.1));
        /// etc.
        /// */
        /// STREAMING::SET_MODEL_AS_NO_LONGER_NEEDED(vehicleHash);
        /// ZONE::CLEAR_POPSCHEDULE_OVERRIDE_VEHICLE_MODEL(popSchedules[index]);
        ///
        /// > int scheduleId
        ///
        /// </summary>
        CLEAR_POPSCHEDULE_OVERRIDE_VEHICLE_MODEL = 0x5C0DE367AA0D911C,
        /// <summary>
        /// Returns a hash representing which part of the map the given coords are located.
        /// 
        /// Possible return values:
        /// (Hash of) city -> -289320599
        /// (Hash of) countryside -> 2072609373
        /// 
        /// C# Example :
        /// 
        /// Ped player = Game.Player.Character;
        /// Hash h = Function.Call<Hash>(Hash.GET_HASH_OF_MAP_AREA_AT_COORDS, player.Position.X, player.Position.Y, player.Position.Z);
        ///
        /// > float x
        /// > float y
        /// > float z
        ///
        /// </summary>
        GET_HASH_OF_MAP_AREA_AT_COORDS = 0x7EE64D51E8498728,
        GET_ZONE_AT_COORDS = 0x27040C25DE6CB2F4,
        GET_ZONE_POPSCHEDULE = 0x4334BC40AA0CB4BB,
        SET_ZONE_ENABLED = 0xBA5ECEEA120E5611,
    }
}