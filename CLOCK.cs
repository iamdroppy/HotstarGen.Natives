using System;
namespace Hotstar
{
    public enum CLOCK : ulong
    { 
        /// <summary>
        /// SET_CLOCK_TIME(12, 34, 56);
        ///
        /// > int hour
        /// > int minute
        /// > int second
        ///
        /// </summary>
        SET_CLOCK_TIME = 0x47C3B5848C3E45D8,
        /// <summary>
        /// Gets the current ingame hour, expressed without zeros. (09:34 will be represented as 9)
        ///
        ///
        /// </summary>
        GET_CLOCK_HOURS = 0x25223CA6B4D20B7F,
        /// <summary>
        /// Gets the current ingame clock minute.
        ///
        ///
        /// </summary>
        GET_CLOCK_MINUTES = 0x13D2B8ADD79640F2,
        /// <summary>
        /// Gets the current ingame clock second. Note that ingame clock seconds change really fast since a day in GTA is only 48 minutes in real life.
        ///
        ///
        /// </summary>
        GET_CLOCK_SECONDS = 0x494E97C2EF27C470,
        /// <summary>
        /// Gets the current day of the week.
        /// 
        /// 0: Sunday
        /// 1: Monday
        /// 2: Tuesday
        /// 3: Wednesday
        /// 4: Thursday
        /// 5: Friday
        /// 6: Saturday
        ///
        ///
        /// </summary>
        GET_CLOCK_DAY_OF_WEEK = 0xD972E4BD7AEB235F,
        /// <summary>
        /// Gets system time as year, month, day, hour, minute and second.
        /// 
        /// Example usage:
        /// 
        ///     int year;
        ///  int month;
        ///     int day;
        ///   int hour;
        ///  int minute;
        ///    int second;
        /// 
        ///  TIME::GET_POSIX_TIME(&year, &month, &day, &hour, &minute, &second);
        /// 
        ///
        /// > int* year
        /// > int* month
        /// > int* day
        /// > int* hour
        /// > int* minute
        /// > int* second
        ///
        /// </summary>
        GET_POSIX_TIME = 0xDA488F299A5B164E,
        /// <summary>
        /// Gets current UTC time 
        ///
        /// > int* year
        /// > int* month
        /// > int* day
        /// > int* hour
        /// > int* minute
        /// > int* second
        ///
        /// </summary>
        GET_UTC_TIME = 0x8117E09A19EEF4D3,
        /// <summary>
        /// Gets local system time as year, month, day, hour, minute and second.
        /// 
        /// Example usage:
        /// 
        /// int year;
        /// int month;
        /// int day;
        /// int hour;
        /// int minute;
        /// int second;
        /// or use std::tm struct
        /// 
        /// TIME::GET_LOCAL_TIME(&year, &month, &day, &hour, &minute, &second);
        /// 
        ///
        /// > int* year
        /// > int* month
        /// > int* day
        /// > int* hour
        /// > int* minute
        /// > int* second
        ///
        /// </summary>
        GET_LOCAL_TIME = 0x50C7A99057A69748,
        PAUSE_CLOCK = 0x4055E40BD2DBEC1D,
        ADVANCE_CLOCK_TIME_TO = 0xC8CA9670B9D83B3B,
        ADD_TO_CLOCK_TIME = 0xD716F30D8C8980E2,
        SET_CLOCK_DATE = 0xB096419DF0D06CE7,
        GET_CLOCK_DAY_OF_MONTH = 0x3D10BC92A4DB1D35,
        GET_CLOCK_MONTH = 0xBBC72712E80257A1,
        GET_CLOCK_YEAR = 0x961777E64BDAF717,
        GET_MILLISECONDS_PER_GAME_MINUTE = 0x2F8B4D1C595B11DB,
    }
}