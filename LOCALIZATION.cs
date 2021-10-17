using System;
namespace Hotstar
{
    public enum LOCALIZATION : ulong
    { 
        /// <summary>
        /// Same return values as GET_CURRENT_LANGUAGE
        ///
        ///
        /// </summary>
        _LOCALIZATION_GET_SYSTEM_LANGUAGE = 0x497420E022796B3F,
        /// <summary>
        /// 0 = american (en-US)
        /// 1 = french (fr-FR)
        /// 2 = german (de-DE)
        /// 3 = italian (it-IT)
        /// 4 = spanish (es-ES)
        /// 5 = brazilian (pt-BR)
        /// 6 = polish (pl-PL)
        /// 7 = russian (ru-RU)
        /// 8 = korean (ko-KR)
        /// 9 = chinesetrad (zh-TW)
        /// 10 = japanese (ja-JP)
        /// 11 = mexican (es-MX)
        /// 12 = chinesesimp (zh-CN)
        ///
        ///
        /// </summary>
        GET_CURRENT_LANGUAGE = 0x2BDD44CC428A7EAE,
        /// <summary>
        /// Possible return values: 0, 1, 2
        ///
        ///
        /// </summary>
        _LOCALIZATION_GET_SYSTEM_DATE_FORMAT = 0xA8AE43AEC1A61314,
    }
}