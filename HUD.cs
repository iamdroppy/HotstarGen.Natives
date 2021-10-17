using System;
namespace Hotstar
{
    public enum HUD : ulong
    { 
        /// <summary>
        /// Initializes the text entry for the the text next to a loading prompt. All natives for building UI texts can be used here
        /// 
        /// 
        /// e.g
        /// void StartLoadingMessage(char *text, int spinnerType = 3)
        ///   {
        ///      _SET_LOADING_PROMPT_TEXT_ENTRY("STRING");
        ///        ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME(text);
        ///        _SHOW_LOADING_PROMPT(spinnerType);
        ///     }
        /// /*OR*/
        ///  void ShowLoadingMessage(char *text, int spinnerType = 3, int timeMs = 10000)
        ///   {
        ///      _SET_LOADING_PROMPT_TEXT_ENTRY("STRING");
        ///        ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME(text);
        ///        _SHOW_LOADING_PROMPT(spinnerType);
        ///         WAIT(timeMs);
        ///      _REMOVE_LOADING_PROMPT();
        ///  }
        /// 
        /// 
        /// These are some localized strings used in the loading spinner.
        /// "PM_WAIT"                   = Please Wait
        /// "CELEB_WPLYRS"              = Waiting For Players.
        /// "CELL_SPINNER2"             = Scanning storage.
        /// "ERROR_CHECKYACHTNAME" = Registering your yacht's name. Please wait.
        /// "ERROR_CHECKPROFANITY"   = Checking your text for profanity. Please wait.
        /// "FM_COR_AUTOD"                        = Just spinner no text
        /// "FM_IHELP_WAT2"                        = Waiting for other players
        /// "FM_JIP_WAITO"                            = Game options are being set
        /// "FMMC_DOWNLOAD"                    = Downloading
        /// "FMMC_PLYLOAD"                         = Loading
        /// "FMMC_STARTTRAN"                    = Launching session
        /// "HUD_QUITTING"                           =  Quiting session
        /// "KILL_STRIP_IDM"                         = Waiting for to accept
        /// "MP_SPINLOADING"                      = Loading
        ///
        /// > const char* string
        ///
        /// </summary>
        BEGIN_TEXT_COMMAND_BUSYSPINNER_ON = 0xABA17D7CE615ADBF,
        /// <summary>
        /// enum eBusySpinnerType
        /// {
        /// 	BUSY_SPINNER_LEFT,
        /// 	BUSY_SPINNER_LEFT_2,
        /// 	BUSY_SPINNER_LEFT_3,
        /// 	BUSY_SPINNER_SAVE,
        /// 	BUSY_SPINNER_RIGHT,
        /// };
        ///
        /// > int busySpinnerType
        ///
        /// </summary>
        END_TEXT_COMMAND_BUSYSPINNER_ON = 0xBD12F8228410D9B4,
        /// <summary>
        /// Removes the loading prompt at the bottom right of the screen.
        ///
        ///
        /// </summary>
        BUSYSPINNER_OFF = 0x10D373323E5B9C0D,
        /// <summary>
        /// Shows the cursor on screen for one frame.
        ///
        ///
        /// </summary>
        _SET_MOUSE_CURSOR_ACTIVE_THIS_FRAME = 0xAAE7CE1D63167423,
        /// <summary>
        /// Changes the mouse cursor's sprite. 
        /// 1 = Normal
        /// 6 = Left Arrow
        /// 7 = Right Arrow
        ///
        /// > int spriteId
        ///
        /// </summary>
        _SET_MOUSE_CURSOR_SPRITE = 0x8DB8CFFD58B62552,
        /// <summary>
        /// Shows/hides the frontend cursor on the pause menu or similar menus.
        /// Clicking off and then on the game window will show it again.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_MOUSE_CURSOR_VISIBLE_IN_MENUS = 0x98215325A695E78A,
        /// <summary>
        /// Stops loading screen tips shown by invoking either `0x488043841BBE156F` or `0x15CFA549788D35EF`
        ///
        ///
        /// </summary>
        _THEFEED_DISABLE_LOADING_SCREEN_TIPS = 0x32888337579A5970,
        /// <summary>
        /// Once called each frame hides all above radar notifications.
        ///
        ///
        /// </summary>
        THEFEED_HIDE_THIS_FRAME = 0x25F87B30C382FCA7,
        /// <summary>
        /// Displays loading screen tips, requires `0x56C8B608CFD49854` to be called beforehand.
        ///
        ///
        /// </summary>
        _THEFEED_DISPLAY_LOADING_SCREEN_TIPS = 0x15CFA549788D35EF,
        /// <summary>
        /// Removes a notification instantly instead of waiting for it to disappear
        ///
        /// > int notificationId
        ///
        /// </summary>
        THEFEED_REMOVE_ITEM = 0xBE4390CB40B3E627,
        /// <summary>
        /// Enables loading screen tips to be be shown (`_0x15CFA549788D35EF` and `_0x488043841BBE156F`), blocks other kinds of notifications from being displayed (at least from current script). Call `0xADED7F5748ACAFE6` to display those again.
        ///
        ///
        /// </summary>
        THEFEED_FORCE_RENDER_OFF = 0x583049884A2EEE3C,
        /// <summary>
        /// Returns the handle for the notification currently displayed on the screen. Name may be a hash collision, but describes the function accurately.
        ///
        ///
        /// </summary>
        THEFEED_GET_FIRST_VISIBLE_DELETE_REMAINING = 0x82352748437638CA,
        /// <summary>
        /// Enables loading screen tips to be be shown (`_0x15CFA549788D35EF` and `_0x488043841BBE156F`), blocks other kinds of notifications from being displayed (at least from current script). Call `0xADED7F5748ACAFE6` to display those again.
        ///
        ///
        /// </summary>
        THEFEED_COMMENT_TELEPORT_POOL_ON = 0x56C8B608CFD49854,
        /// <summary>
        /// Displays "normal" notifications again after calling `_0x56C8B608CFD49854` (those that were drawn before calling this native too), though those will have a weird offset and stay on screen forever (tested with notifications created from same script).
        ///
        ///
        /// </summary>
        THEFEED_COMMENT_TELEPORT_POOL_OFF = 0xADED7F5748ACAFE6,
        /// <summary>
        /// From the decompiled scripts:
        /// HUD::_92F0DA1E27DB96DC(6);
        /// HUD::_92F0DA1E27DB96DC(184);
        /// HUD::_92F0DA1E27DB96DC(190);
        /// 
        /// sets background color for the next notification
        /// 6 = red
        /// 184 = green
        /// 190 = yellow
        /// 
        /// Here is a list of some colors that can be used: gyazo.com/68bd384455fceb0a85a8729e48216e15
        ///
        /// > int hudColorIndex
        ///
        /// </summary>
        _THEFEED_SET_NEXT_POST_BACKGROUND_COLOR = 0x92F0DA1E27DB96DC,
        /// <summary>
        /// Related to notification color flashing, setting p0 to 0 invalidates a `_SET_NOTIFICATION_FLASH_COLOR` call for the target notification.
        ///
        /// > int count
        ///
        /// </summary>
        _THEFEED_SET_ANIMPOSTFX_COUNT = 0x17AD8C9706BDD88A,
        /// <summary>
        /// Requires manual management of game stream handles (i.e., 0xBE4390CB40B3E627).
        ///
        ///
        /// </summary>
        THEFEED_FREEZE_NEXT_POST = 0xFDEC055AB549E328,
        /// <summary>
        /// From the decompiled scripts, called 61 times:
        /// HUD::_317EBA71D7543F52(&v_13, &v_13, &v_3, &v_3);
        ///
        /// > Any* p0
        /// > Any* p1
        /// > Any* p2
        /// > Any* p3
        ///
        /// </summary>
        _THEFEED_ADD_TXD_REF = 0x317EBA71D7543F52,
        /// <summary>
        /// Declares the entry type of a notification, for example "STRING".
        /// 
        /// int ShowNotification(char *text)
        /// {
        /// 	BEGIN_TEXT_COMMAND_THEFEED_POST("STRING");
        /// 	ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME(text);
        /// 	return _DRAW_NOTIFICATION(1, 1);
        /// }
        ///
        /// > const char* text
        ///
        /// </summary>
        BEGIN_TEXT_COMMAND_THEFEED_POST = 0x202709F4C58A0424,
        /// <summary>
        /// List of picture names: https://pastebin.com/XdpJVbHz
        /// Example result: https://i.imgur.com/SdEZ22m.png
        ///
        /// > const char* statTitle
        /// > int iconEnum
        /// > BOOL stepVal
        /// > int barValue
        /// > BOOL isImportant
        /// > const char* pictureTextureDict
        /// > const char* pictureTextureName
        ///
        /// </summary>
        END_TEXT_COMMAND_THEFEED_POST_STATS = 0x2B7E9A4EAAA93C89,
        /// <summary>
        /// This function can show pictures of every texture that can be requested by REQUEST_STREAMED_TEXTURE_DICT.
        /// 
        /// List of picNames: pastebin.com/XdpJVbHz
        /// 
        /// 
        /// flash is a bool for fading in.
        /// iconTypes:
        /// 1 : Chat Box
        /// 2 : Email
        /// 3 : Add Friend Request
        /// 4 : Nothing
        /// 5 : Nothing
        /// 6 : Nothing
        /// 7 : Right Jumping Arrow
        /// 8 : RP Icon
        /// 9 : $ Icon
        /// 
        /// "sender" is the very top header. This can be any old string.
        /// "subject" is the header under the sender.
        ///
        /// > const char* txdName
        /// > const char* textureName
        /// > BOOL flash
        /// > int iconType
        /// > const char* sender
        /// > const char* subject
        ///
        /// </summary>
        END_TEXT_COMMAND_THEFEED_POST_MESSAGETEXT = 0x1CCD9A37359072CF,
        /// <summary>
        /// This function can show pictures of every texture that can be requested by REQUEST_STREAMED_TEXTURE_DICT.
        /// 
        /// Needs more research.
        /// 
        /// Only one type of usage in the scripts:
        /// 
        /// HUD::_C6F580E4C94926AC("CHAR_ACTING_UP", "CHAR_ACTING_UP", 0, 0, "DI_FEED_CHAR", a_0);
        ///
        /// > const char* txdName
        /// > const char* textureName
        /// > BOOL flash
        /// > int iconType
        /// > const char* sender
        /// > const char* subject
        ///
        /// </summary>
        _END_TEXT_COMMAND_THEFEED_POST_MESSAGETEXT_GXT_ENTRY = 0xC6F580E4C94926AC,
        /// <summary>
        /// This function can show pictures of every texture that can be requested by REQUEST_STREAMED_TEXTURE_DICT.
        /// 
        /// NOTE: 'duration' is a multiplier, so 1.0 is normal, 2.0 is twice as long (very slow), and 0.5 is half as long.
        /// 
        /// Example, only occurrence in the scripts:
        /// v_8 = HUD::_1E6611149DB3DB6B("CHAR_SOCIAL_CLUB", "CHAR_SOCIAL_CLUB", 0, 0, &v_9, "", a_5);
        ///
        /// > const char* txdName
        /// > const char* textureName
        /// > BOOL flash
        /// > int iconType
        /// > const char* sender
        /// > const char* subject
        /// > float duration
        ///
        /// </summary>
        END_TEXT_COMMAND_THEFEED_POST_MESSAGETEXT_TU = 0x1E6611149DB3DB6B,
        /// <summary>
        /// This function can show pictures of every texture that can be requested by REQUEST_STREAMED_TEXTURE_DICT.
        /// 
        /// List of picNames pastebin.com/XdpJVbHz
        /// 
        /// flash is a bool for fading in.
        /// iconTypes:
        /// 1 : Chat Box
        /// 2 : Email
        /// 3 : Add Friend Request
        /// 4 : Nothing
        /// 5 : Nothing
        /// 6 : Nothing
        /// 7 : Right Jumping Arrow
        /// 8 : RP Icon
        /// 9 : $ Icon
        /// 
        /// "sender" is the very top header. This can be any old string.
        /// "subject" is the header under the sender.
        /// "duration" is a multiplier, so 1.0 is normal, 2.0 is twice as long (very slow), and 0.5 is half as long.
        /// "clanTag" shows a crew tag in the "sender" header, after the text. You need to use 3 underscores as padding. Maximum length of this field seems to be 7. (e.g. "MK" becomes "___MK", "ACE" becomes "___ACE", etc.)
        ///
        /// > const char* txdName
        /// > const char* textureName
        /// > BOOL flash
        /// > int iconType
        /// > const char* sender
        /// > const char* subject
        /// > float duration
        /// > const char* clanTag
        ///
        /// </summary>
        END_TEXT_COMMAND_THEFEED_POST_MESSAGETEXT_WITH_CREW_TAG = 0x5CBF7BADE20DB93E,
        /// <summary>
        /// This function can show pictures of every texture that can be requested by REQUEST_STREAMED_TEXTURE_DICT.
        /// 
        /// List of picNames: pastebin.com/XdpJVbHz
        /// 
        /// flash is a bool for fading in.
        /// iconTypes:
        /// 1 : Chat Box
        /// 2 : Email
        /// 3 : Add Friend Request
        /// 4 : Nothing
        /// 5 : Nothing
        /// 6 : Nothing
        /// 7 : Right Jumping Arrow
        /// 8 : RP Icon
        /// 9 : $ Icon
        /// 
        /// "sender" is the very top header. This can be any old string.
        /// "subject" is the header under the sender.
        /// "duration" is a multiplier, so 1.0 is normal, 2.0 is twice as long (very slow), and 0.5 is half as long.
        /// "clanTag" shows a crew tag in the "sender" header, after the text. You need to use 3 underscores as padding. Maximum length of this field seems to be 7. (e.g. "MK" becomes "___MK", "ACE" becomes "___ACE", etc.)
        /// iconType2 is a mirror of iconType. It shows in the "subject" line, right under the original iconType.
        /// 
        /// 
        /// int IconNotification(char *text, char *text2, char *Subject)
        /// {
        ///     _SET_NOTIFICATION_TEXT_ENTRY("STRING");
        ///  ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME(text);
        ///    _SET_NOTIFICATION_MESSAGE_CLAN_TAG_2("CHAR_SOCIAL_CLUB", "CHAR_SOCIAL_CLUB", 1, 7, text2, Subject, 1.0f, "__EXAMPLE", 7);
        ///    return _DRAW_NOTIFICATION(1, 1);
        /// }
        ///
        /// > const char* txdName
        /// > const char* textureName
        /// > BOOL flash
        /// > int iconType1
        /// > const char* sender
        /// > const char* subject
        /// > float duration
        /// > const char* clanTag
        /// > int iconType2
        /// > int p9
        ///
        /// </summary>
        END_TEXT_COMMAND_THEFEED_POST_MESSAGETEXT_WITH_CREW_TAG_AND_ADDITIONAL_ICON = 0x531B84E7DA981FB6,
        /// <summary>
        /// Shows an "award" notification above the minimap, example: https://i.imgur.com/e2DNaKX.png
        /// Example:
        /// 
        /// HUD::_SET_NOTIFICATION_TEXT_ENTRY("HUNT");
        /// HUD::_0xAA295B6F28BD587D("Hunting", "Hunting_Gold_128", 0, 109, "HUD_MED_UNLKED");
        ///
        /// > const char* textureDict
        /// > const char* textureName
        /// > int rpBonus
        /// > int colorOverlay
        /// > const char* titleLabel
        ///
        /// </summary>
        END_TEXT_COMMAND_THEFEED_POST_AWARD = 0xAA295B6F28BD587D,
        /// <summary>
        /// returns a notification handle, prints out a notification like below:
        /// type range: 0 - 2
        /// if you set type to 1, image goes from 0 - 39 - Xbox you can add text to
        /// 
        /// example: 
        /// HUD::_0xD202B92CBF1D816F(1, 20, "Who you trynna get crazy with, ese? Don't you know I'm LOCO?!");
        /// - imgur.com/lGBPCz3
        ///
        /// > int type
        /// > int image
        /// > const char* text
        ///
        /// </summary>
        _END_TEXT_COMMAND_THEFEED_POST_REPLAY_ICON = 0xD202B92CBF1D816F,
        /// <summary>
        /// returns a notification handle, prints out a notification like below:
        /// type range: 0 - 2
        /// if you set type to 1, button accepts "~INPUT_SOMETHING~"
        /// 
        /// example:
        /// HUD::_0xDD6CB2CCE7C2735C(1, "~INPUT_TALK~", "Who you trynna get crazy with, ese? Don't you know I'm LOCO?!");
        /// - imgur.com/UPy0Ial
        /// 
        /// 
        /// Examples from the scripts:
        /// l_D1[1/*1*/]=HUD::_DD6CB2CCE7C2735C(1,"~INPUT_REPLAY_START_STOP_RECORDING~","");
        /// l_D1[2/*1*/]=HUD::_DD6CB2CCE7C2735C(1,"~INPUT_SAVE_REPLAY_CLIP~","");
        /// l_D1[1/*1*/]=HUD::_DD6CB2CCE7C2735C(1,"~INPUT_REPLAY_START_STOP_RECORDING~","");
        /// l_D1[2/*1*/]=HUD::_DD6CB2CCE7C2735C(1,"~INPUT_REPLAY_START_STOP_RECORDING_SECONDARY~","");
        /// 
        ///
        /// > int type
        /// > const char* button
        /// > const char* text
        ///
        /// </summary>
        _END_TEXT_COMMAND_THEFEED_POST_REPLAY_INPUT = 0xDD6CB2CCE7C2735C,
        /// <summary>
        /// Used to be known as _SET_TEXT_ENTRY_2
        /// 
        /// void ShowSubtitle(char *text)
        /// {
        ///   BEGIN_TEXT_COMMAND_PRINT("STRING");
        ///  ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME(text);
        ///    END_TEXT_COMMAND_PRINT(2000, 1);
        /// }
        ///
        /// > const char* GxtEntry
        ///
        /// </summary>
        BEGIN_TEXT_COMMAND_PRINT = 0xB87A37EEB7FAA67D,
        /// <summary>
        /// Draws the subtitle at middle center of the screen.
        /// 
        /// int duration = time in milliseconds to show text on screen before disappearing
        /// 
        /// drawImmediately = If true, the text will be drawn immediately, if false, the text will be drawn after the previous subtitle has finished
        /// 
        /// Used to be known as _DRAW_SUBTITLE_TIMED
        ///
        /// > int duration
        /// > BOOL drawImmediately
        ///
        /// </summary>
        END_TEXT_COMMAND_PRINT = 0x9D77056A530643F6,
        /// <summary>
        /// nothin doin. 
        /// 
        /// BOOL Message(const char* text)
        ///    {
        ///      BEGIN_TEXT_COMMAND_IS_MESSAGE_DISPLAYED("STRING");
        ///       ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME(text);
        ///        return END_TEXT_COMMAND_IS_MESSAGE_DISPLAYED();
        ///    }
        ///
        /// > const char* text
        ///
        /// </summary>
        BEGIN_TEXT_COMMAND_IS_MESSAGE_DISPLAYED = 0x853648FD1063A213,
        /// <summary>
        /// The following were found in the decompiled script files:
        /// STRING, TWOSTRINGS, NUMBER, PERCENTAGE, FO_TWO_NUM, ESMINDOLLA, ESDOLLA, MTPHPER_XPNO, AHD_DIST, CMOD_STAT_0, CMOD_STAT_1, CMOD_STAT_2, CMOD_STAT_3, DFLT_MNU_OPT, F3A_TRAFDEST, ES_HELP_SOC3
        /// 
        /// ESDOLLA - cash
        /// ESMINDOLLA - cash (negative)
        /// 
        /// Used to be known as _SET_TEXT_ENTRY
        ///
        /// > const char* text
        ///
        /// </summary>
        BEGIN_TEXT_COMMAND_DISPLAY_TEXT = 0x25FBB336DF1804CB,
        /// <summary>
        /// After applying the properties to the text (See HUD::SET_TEXT_), this will draw the text in the applied position. Also 0.0f < x, y < 1.0f, percentage of the axis.
        /// 
        /// Used to be known as _DRAW_TEXT
        ///
        /// > float x
        /// > float y
        /// > int p2
        ///
        /// </summary>
        END_TEXT_COMMAND_DISPLAY_TEXT = 0xCD015E5BB0D96A57,
        /// <summary>
        /// BEGIN_TEXT_COMMAND_*
        /// 
        /// Example:
        /// _BEGIN_TEXT_COMMAND_GET_WIDTH("NUMBER");
        /// ADD_TEXT_COMPONENT_FLOAT(69.420f, 2);
        /// float width = _END_TEXT_COMMAND_GET_WIDTH(1);
        ///
        /// > const char* text
        ///
        /// </summary>
        _BEGIN_TEXT_COMMAND_GET_WIDTH = 0x54CE8AC98E120CAB,
        /// <summary>
        /// END_TEXT_COMMAND_*
        /// 
        /// In scripts font most of the time is passed as 1.
        /// Use _BEGIN_TEXT_GET_COMMAND_GET_WIDTH
        /// 
        /// param is not font from what i've tested
        ///
        /// > BOOL p0
        ///
        /// </summary>
        _END_TEXT_COMMAND_GET_WIDTH = 0x85F061DA64ED2F67,
        /// <summary>
        /// BEGIN_TEXT_COMMAND_*
        /// 
        /// get's line count
        /// 
        /// 
        /// int GetLineCount(char *text, float x, float y)
        ///     {
        ///      _BEGIN_TEXT_COMMAND_LINE_COUNT("STRING");
        ///                 ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME(text);
        ///       return _END_TEXT_COMMAND_GET_LINE_COUNT(x, y);
        ///     }
        ///
        /// > const char* entry
        ///
        /// </summary>
        _BEGIN_TEXT_COMMAND_LINE_COUNT = 0x521FB041D93DD0E4,
        /// <summary>
        /// END_TEXT_COMMAND_*
        /// 
        /// Determines how many lines the text string will use when drawn on screen. 
        /// Must use 0x521FB041D93DD0E4 for setting up
        ///
        /// > float x
        /// > float y
        ///
        /// </summary>
        _END_TEXT_COMMAND_LINE_COUNT = 0x9040DFB09BE75706,
        /// <summary>
        /// Used to be known as _SET_TEXT_COMPONENT_FORMAT
        ///
        /// > const char* inputType
        ///
        /// </summary>
        BEGIN_TEXT_COMMAND_DISPLAY_HELP = 0x8509B634FBE7DA11,
        /// <summary>
        /// shape goes from -1 to 50 (may be more).
        /// p0 is always 0.
        /// 
        /// Example:
        /// void FloatingHelpText(const char* text)
        /// {
        ///     BEGIN_TEXT_COMMAND_DISPLAY_HELP("STRING");
        ///   ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME(text);
        ///    END_TEXT_COMMAND_DISPLAY_HELP (0, 0, 1, -1);
        /// }
        /// 
        /// Image:
        /// - imgbin.org/images/26209.jpg
        /// 
        /// more inputs/icons:
        /// - pastebin.com/nqNYWMSB
        /// 
        /// Used to be known as _DISPLAY_HELP_TEXT_FROM_STRING_LABEL
        ///
        /// > int p0
        /// > BOOL loop
        /// > BOOL beep
        /// > int shape
        ///
        /// </summary>
        END_TEXT_COMMAND_DISPLAY_HELP = 0x238FFE5C7B0498A6,
        /// <summary>
        /// BOOL IsContextActive(char *ctx)
        ///     {
        ///      BEGIN_TEXT_COMMAND_IS_THIS_HELP_MESSAGE_BEING_DISPLAYED(ctx);
        ///      return END_TEXT_COMMAND_IS_THIS_HELP_MESSAGE_BEING_DISPLAYED(0);
        ///   }
        ///
        /// > const char* labelName
        ///
        /// </summary>
        BEGIN_TEXT_COMMAND_IS_THIS_HELP_MESSAGE_BEING_DISPLAYED = 0x0A24DA3A41B718F5,
        /// <summary>
        /// Starts a text command to change the name of a blip displayed in the pause menu.
        /// This should be paired with `END_TEXT_COMMAND_SET_BLIP_NAME`, once adding all required text components.
        /// Example:
        /// 
        /// HUD::BEGIN_TEXT_COMMAND_SET_BLIP_NAME("STRING");
        /// HUD::_ADD_TEXT_COMPONENT_STRING("Name");
        /// HUD::END_TEXT_COMMAND_SET_BLIP_NAME(blip);
        ///
        /// > const char* textLabel
        ///
        /// </summary>
        BEGIN_TEXT_COMMAND_SET_BLIP_NAME = 0xF9113A30DE5C6670,
        /// <summary>
        /// Finalizes a text command started with BEGIN_TEXT_COMMAND_SET_BLIP_NAME, setting the name of the specified blip.
        ///
        /// > Blip blip
        ///
        /// </summary>
        END_TEXT_COMMAND_SET_BLIP_NAME = 0xBC38B49BCB83BC9B,
        /// <summary>
        /// clears a print text command with this text
        ///
        /// > const char* text
        ///
        /// </summary>
        BEGIN_TEXT_COMMAND_CLEAR_PRINT = 0xE124FA80A759019C,
        /// <summary>
        /// It adds the localized text of the specified GXT entry name. Eg. if the argument is GET_HASH_KEY("ES_HELP"), adds "Continue". Just uses a text labels hash key
        ///
        /// > Hash gxtEntryHash
        ///
        /// </summary>
        ADD_TEXT_COMPONENT_SUBSTRING_TEXT_LABEL_HASH_KEY = 0x17299B63C7683A2B,
        /// <summary>
        /// Adds a timer (e.g. "00:00:00:000"). The appearance of the timer depends on the flags, which needs more research.
        ///
        /// > int timestamp
        /// > int flags
        ///
        /// </summary>
        ADD_TEXT_COMPONENT_SUBSTRING_TIME = 0x1115F16B8AB9E8BF,
        /// <summary>
        /// p1 was always -1
        ///
        /// > const char* p0
        /// > int p1
        ///
        /// </summary>
        ADD_TEXT_COMPONENT_SUBSTRING_PHONE_NUMBER = 0x761B77454205A61D,
        /// <summary>
        /// This native (along with 0x5F68520888E69014 and 0x6C188BE134E074AA) do not actually filter anything. They simply add the provided text (as of 944)
        ///
        /// > const char* website
        ///
        /// </summary>
        ADD_TEXT_COMPONENT_SUBSTRING_WEBSITE = 0x94CF4AC034C9C986,
        /// <summary>
        /// Returns a substring of a specified length starting at a specified position.
        /// 
        /// Example:
        /// // Get "STRING" text from "MY_STRING"
        /// subStr = HUD::_GET_TEXT_SUBSTRING("MY_STRING", 3, 6);
        ///
        /// > const char* text
        /// > int position
        /// > int length
        ///
        /// </summary>
        _GET_TEXT_SUBSTRING = 0x169BD9382084C8C0,
        /// <summary>
        /// Returns a substring of a specified length starting at a specified position. The result is guaranteed not to exceed the specified max length.
        /// 
        /// NOTE: The 'maxLength' parameter might actually be the size of the buffer that is returned. More research is needed. -CL69
        /// 
        /// Example:
        /// // Condensed example of how Rockstar uses this function
        /// strLen = HUD::GET_LENGTH_OF_LITERAL_STRING(MISC::GET_ONSCREEN_KEYBOARD_RESULT());
        /// subStr = HUD::_GET_TEXT_SUBSTRING_SAFE(MISC::GET_ONSCREEN_KEYBOARD_RESULT(), 0, strLen, 63);
        /// 
        /// --
        /// 
        /// "fm_race_creator.ysc", line 85115:
        /// // parameters modified for clarity
        /// BOOL sub_8e5aa(char *text, int length) {
        ///     for (i = 0; i <= (length - 2); i += 1) {
        ///         if (!MISC::ARE_STRINGS_EQUAL(HUD::_GET_TEXT_SUBSTRING_SAFE(text, i, i + 1, 1), " ")) {
        ///             return FALSE;
        ///         }
        ///     }
        ///     return TRUE;
        /// }
        ///
        /// > const char* text
        /// > int position
        /// > int length
        /// > int maxLength
        ///
        /// </summary>
        _GET_TEXT_SUBSTRING_SAFE = 0xB2798643312205C5,
        /// <summary>
        /// Returns a substring that is between two specified positions. The length of the string will be calculated using (endPosition - startPosition).
        /// 
        /// Example:
        /// // Get "STRING" text from "MY_STRING"
        /// subStr = HUD::_GET_TEXT_SUBSTRING_SLICE("MY_STRING", 3, 9);
        /// // Overflows are possibly replaced with underscores (needs verification)
        /// subStr = HUD::_GET_TEXT_SUBSTRING_SLICE("MY_STRING", 3, 10); // "STRING_"?
        ///
        /// > const char* text
        /// > int startPosition
        /// > int endPosition
        ///
        /// </summary>
        _GET_TEXT_SUBSTRING_SLICE = 0xCE94AEBA5D82908A,
        /// <summary>
        /// Gets a string literal from a label name.
        /// 
        /// GET_F*
        ///
        /// > const char* labelName
        ///
        /// </summary>
        _GET_LABEL_TEXT = 0x7B5280EBA9840C72,
        /// <summary>
        /// p0: found arguments in the b617d scripts: pastebin.com/X5akCN7z
        ///
        /// > const char* p0
        ///
        /// </summary>
        CLEAR_THIS_PRINT = 0xCF708001E1E536DD,
        /// <summary>
        /// Request a gxt into the passed slot.
        ///
        /// > const char* gxt
        /// > int slot
        ///
        /// </summary>
        REQUEST_ADDITIONAL_TEXT = 0x71A78003C8E71424,
        /// <summary>
        /// Checks if the specified gxt has loaded into the passed slot.
        ///
        /// > const char* gxt
        /// > int slot
        ///
        /// </summary>
        HAS_THIS_ADDITIONAL_TEXT_LOADED = 0xADBF060E2B30C5BC,
        /// <summary>
        /// Checks if the passed gxt name exists in the game files.
        ///
        /// > const char* gxt
        ///
        /// </summary>
        DOES_TEXT_LABEL_EXIST = 0xAC09CA973C564252,
        /// <summary>
        /// Returns the string length of the string from the gxt string .
        ///
        /// > const char* gxt
        ///
        /// </summary>
        GET_LENGTH_OF_STRING_WITH_THIS_TEXT_LABEL = 0x801BD273D3A23F74,
        /// <summary>
        /// Returns the length of the string passed (much like strlen).
        ///
        /// > const char* string
        ///
        /// </summary>
        GET_LENGTH_OF_LITERAL_STRING = 0xF030907CCBB8A9FD,
        /// <summary>
        /// This functions converts the hash of a street name into a readable string.
        /// 
        /// For how to get the hashes, see PATHFIND::GET_STREET_NAME_AT_COORD.
        ///
        /// > Hash hash
        ///
        /// </summary>
        GET_STREET_NAME_FROM_HASH_KEY = 0xD0EF8A959B8A4CB9,
        /// <summary>
        /// If Hud should be displayed
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        DISPLAY_HUD = 0xA6294919E56FF02A,
        /// <summary>
        /// Enables drawing some hud components, such as help labels, this frame, when the player is dead.
        ///
        ///
        /// </summary>
        _DISPLAY_HUD_WHEN_DEAD_THIS_FRAME = 0x7669F9E39DC17063,
        /// <summary>
        /// If Minimap / Radar should be displayed.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        DISPLAY_RADAR = 0xA0EBB943C300E693,
        /// <summary>
        /// Enable / disable showing route for the Blip-object.
        ///
        /// > Blip blip
        /// > BOOL enabled
        ///
        /// </summary>
        SET_BLIP_ROUTE = 0x4F7D8A9BFB0B43E9,
        /// <summary>
        /// zoomLevel ranges from 0 to 200 
        ///
        /// > int zoomLevel
        ///
        /// </summary>
        SET_RADAR_ZOOM = 0x096EF57A0C999BBA,
        /// <summary>
        /// HUD colors and their values: pastebin.com/d9aHPbXN
        ///
        /// > int hudColorIndex
        /// > int* r
        /// > int* g
        /// > int* b
        /// > int* a
        ///
        /// </summary>
        GET_HUD_COLOUR = 0x7C9C91AB74A0360F,
        /// <summary>
        /// Sets the color of HUD_COLOUR_SCRIPT_VARIABLE
        ///
        /// > int r
        /// > int g
        /// > int b
        /// > int a
        ///
        /// </summary>
        SET_SCRIPT_VARIABLE_HUD_COLOUR = 0xD68A5FF8A3A89874,
        /// <summary>
        /// Sets the color of HUD_COLOUR_SCRIPT_VARIABLE_2
        ///
        /// > int r
        /// > int g
        /// > int b
        /// > int a
        ///
        /// </summary>
        _SET_SCRIPT_VARIABLE_2_HUD_COLOUR = 0x16A304E6CB2BFAB9,
        /// <summary>
        /// HUD colors and their values: pastebin.com/d9aHPbXN
        /// --------------------------------------------------
        /// makes hudColorIndex2 color into hudColorIndex color
        ///
        /// > int hudColorIndex
        /// > int hudColorIndex2
        ///
        /// </summary>
        REPLACE_HUD_COLOUR = 0x1CCC708F0F850613,
        /// <summary>
        /// HUD colors and their values: pastebin.com/d9aHPbXN
        ///
        /// > int hudColorIndex
        /// > int r
        /// > int g
        /// > int b
        /// > int a
        ///
        /// </summary>
        REPLACE_HUD_COLOUR_WITH_RGBA = 0xF314CF4F0211894E,
        /// <summary>
        /// This gets the height of the FONT and not the total text. You need to get the number of lines your text uses, and get the height of a newline (I'm using a smaller value) to get the total text height.
        ///
        /// > float size
        /// > int font
        ///
        /// </summary>
        GET_RENDERED_CHARACTER_HEIGHT = 0xDB88A37483346780,
        /// <summary>
        /// Size range : 0F to 1.0F
        /// p0 is unknown and doesn't seem to have an effect, yet in the game scripts it changes to 1.0F sometimes.
        ///
        /// > float scale
        /// > float size
        ///
        /// </summary>
        SET_TEXT_SCALE = 0x07C837F9A01C34C9,
        /// <summary>
        /// colors you input not same as you think?
        /// A: for some reason its R B G A
        ///
        /// > int red
        /// > int green
        /// > int blue
        /// > int alpha
        ///
        /// </summary>
        SET_TEXT_COLOUR = 0xBE6B23FFA53FB442,
        /// <summary>
        /// Types -
        /// 0: Center-Justify
        /// 1: Left-Justify
        /// 2: Right-Justify
        /// 
        /// Right-Justify requires SET_TEXT_WRAP, otherwise it will draw to the far right of the screen
        ///
        /// > int justifyType
        ///
        /// </summary>
        SET_TEXT_JUSTIFICATION = 0x4E096588B13FFECA,
        /// <summary>
        /// It sets the text in a specified box and wraps the text if it exceeds the boundries. Both values are for X axis. Useful when positioning text set to center or aligned to the right.
        /// 
        /// start - left boundry on screen position (0.0 - 1.0)
        /// end - right boundry on screen position (0.0 - 1.0)
        ///
        /// > float start
        /// > float end
        ///
        /// </summary>
        SET_TEXT_WRAP = 0x63145D9C883A1A70,
        /// <summary>
        /// This native does absolutely nothing, just a nullsub
        ///
        /// > BOOL p0
        ///
        /// </summary>
        SET_TEXT_PROPORTIONAL = 0x038C1F517D7FDCF8,
        /// <summary>
        /// fonts that mess up your text where made for number values/misc stuff
        ///
        /// > int fontType
        ///
        /// </summary>
        SET_TEXT_FONT = 0x66E0276CC5F6B9DA,
        /// <summary>
        /// distance - shadow distance in pixels, both horizontal and vertical
        /// r, g, b, a - color
        ///
        /// > int distance
        /// > int r
        /// > int g
        /// > int b
        /// > int a
        ///
        /// </summary>
        SET_TEXT_DROPSHADOW = 0x465C84BC39F1C351,
        /// <summary>
        /// This native does absolutely nothing, just a nullsub
        ///
        /// > int p0
        /// > int r
        /// > int g
        /// > int b
        /// > int a
        ///
        /// </summary>
        SET_TEXT_EDGE = 0x441603240D202FA6,
        /// <summary>
        /// This function is hard-coded to always return 1.
        ///
        ///
        /// </summary>
        GET_DEFAULT_SCRIPT_RENDERTARGET_RENDER_ID = 0x52F0982D7FD156B6,
        /// <summary>
        /// This function is hard-coded to always return 1.
        ///
        ///
        /// </summary>
        GET_STANDARD_BLIP_ENUM_ID = 0x4A9923385BDB9DAD,
        /// <summary>
        /// Returns a value based on what the blip is attached to
        /// 1 - Vehicle
        /// 2 - Ped
        /// 3 - Object
        /// 4 - Coord
        /// 5 - unk
        /// 6 - Pickup
        /// 7 - Radius
        ///
        /// > Blip blip
        ///
        /// </summary>
        GET_BLIP_INFO_ID_TYPE = 0xBE9B0959FFD0779B,
        /// <summary>
        /// This function is hard-coded to always return 0.
        ///
        /// > Blip blip
        ///
        /// </summary>
        GET_BLIP_INFO_ID_PICKUP_INDEX = 0x9B6786E4C03DD382,
        /// <summary>
        /// Returns the Blip handle of given Entity.
        ///
        /// > Entity entity
        ///
        /// </summary>
        GET_BLIP_FROM_ENTITY = 0xBC8DBDCA2436F7E8,
        /// <summary>
        /// Adds a rectangular blip for the specified coordinates/area.
        /// 
        /// It is recommended to use SET_BLIP_ROTATION and SET_BLIP_COLOUR to make the blip not rotate along with the camera.
        /// 
        /// By default, the blip will show as a _regular_ blip with the specified color/sprite if it is outside of the minimap view.
        /// 
        /// Example image:
        /// minimap https://w.wew.wtf/pdcjig.png
        /// big map https://w.wew.wtf/zgcjcm.png
        /// 
        /// (Native name is _likely_ to actually be ADD_BLIP_FOR_AREA, but due to the usual reasons this can't be confirmed)
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float width
        /// > float height
        ///
        /// </summary>
        _ADD_BLIP_FOR_AREA = 0xCE5D0E5E315DB238,
        /// <summary>
        /// Returns red ( default ) blip attached to entity.
        /// 
        /// Example:
        /// Blip blip; //Put this outside your case or option
        /// blip = HUD::ADD_BLIP_FOR_ENTITY(YourPedOrBodyguardName);
        /// HUD::SET_BLIP_AS_FRIENDLY(blip, true);
        ///
        /// > Entity entity
        ///
        /// </summary>
        ADD_BLIP_FOR_ENTITY = 0x5CDE92C702A8FCE7,
        /// <summary>
        /// Creates an orange ( default ) Blip-object. Returns a Blip-object which can then be modified.
        ///
        /// > float x
        /// > float y
        /// > float z
        ///
        /// </summary>
        ADD_BLIP_FOR_COORD = 0x5A039BB0BCA604B6,
        /// <summary>
        /// Sets the displayed sprite for a specific blip..
        /// 
        /// You may have your own list, but since dev-c didn't show it I was bored and started looking through scripts and functions to get a presumable almost positive list of a majority of blip IDs
        /// h t t p://pastebin.com/Bpj9Sfft
        /// 
        /// Blips Images + IDs:
        /// gtaxscripting.blogspot.com/2016/05/gta-v-blips-id-and-image.html
        ///
        /// > Blip blip
        /// > int spriteId
        ///
        /// </summary>
        SET_BLIP_SPRITE = 0xDF735600A4696DAF,
        /// <summary>
        /// Blips Images + IDs:
        /// gtaxscripting.blogspot.com/2016/05/gta-v-blips-id-and-image.html
        ///
        /// > Blip blip
        ///
        /// </summary>
        GET_BLIP_SPRITE = 0x1FC877464A04FC4F,
        /// <summary>
        /// Doesn't work if the label text of gxtEntry is >= 80.
        ///
        /// > Blip blip
        /// > const char* gxtEntry
        ///
        /// </summary>
        SET_BLIP_NAME_FROM_TEXT_FILE = 0xEAA0FFE120D92784,
        /// <summary>
        /// Sets alpha-channel for blip color.
        /// 
        /// Example:
        /// 
        /// Blip blip = HUD::ADD_BLIP_FOR_ENTITY(entity);
        /// HUD::SET_BLIP_COLOUR(blip , 3);
        /// HUD::SET_BLIP_ALPHA(blip , 64);
        /// 
        ///
        /// > Blip blip
        /// > int alpha
        ///
        /// </summary>
        SET_BLIP_ALPHA = 0x45FF974EEE1C8734,
        /// <summary>
        /// After some testing, looks like you need to use CEIL() on the rotation (vehicle/ped heading) before using it there.
        ///
        /// > Blip blip
        /// > int rotation
        ///
        /// </summary>
        SET_BLIP_ROTATION = 0xF87683CDF73C3F6E,
        /// <summary>
        /// Does not require whole number/integer rotations.
        ///
        /// > Blip blip
        /// > float heading
        ///
        /// </summary>
        _SET_BLIP_SQUARED_ROTATION = 0xA8B6AFDAC320AC87,
        /// <summary>
        /// Adds up after viewing multiple R* scripts. I believe that the duration is in miliseconds.
        ///
        /// > Blip blip
        /// > int duration
        ///
        /// </summary>
        SET_BLIP_FLASH_TIMER = 0xD3CD6FD297AE87CC,
        /// <summary>
        /// https://gtaforums.com/topic/864881-all-blip-color-ids-pictured/
        ///
        /// > Blip blip
        /// > int color
        ///
        /// </summary>
        SET_BLIP_COLOUR = 0x03D7FB09E75D6B7E,
        /// <summary>
        /// Sets whether or not the specified blip should only be displayed when nearby, or on the minimap.
        ///
        /// > Blip blip
        /// > BOOL toggle
        ///
        /// </summary>
        SET_BLIP_AS_SHORT_RANGE = 0xBE8BE4FE60E27B72,
        /// <summary>
        /// See https://imgur.com/a/lLkEsMN
        ///
        /// > Blip blip
        /// > float xScale
        /// > float yScale
        ///
        /// </summary>
        _SET_BLIP_SCALE_TRANSFORMATION = 0xCD6524439909C979,
        /// <summary>
        /// See this topic for more details : gtaforums.com/topic/717612-v-scriptnative-documentation-and-research/page-35?p=1069477935
        ///
        /// > Blip blip
        /// > int priority
        ///
        /// </summary>
        SET_BLIP_PRIORITY = 0xAE9FC9EF6A9FAC79,
        /// <summary>
        /// Display Id behaviours:
        /// 0 = Doesn't show up, ever, anywhere.
        /// 1 = Doesn't show up, ever, anywhere.
        /// 2 = Shows on both main map and minimap. (Selectable on map)
        /// 3 = Shows on main map only. (Selectable on map)
        /// 4 = Shows on main map only. (Selectable on map)
        /// 5 = Shows on minimap only.
        /// 6 = Shows on both main map and minimap. (Selectable on map)
        /// 7 = Doesn't show up, ever, anywhere.
        /// 8 = Shows on both main map and minimap. (Not selectable on map)
        /// 9 = Shows on minimap only.
        /// 10 = Shows on both main map and minimap. (Not selectable on map)
        /// 
        /// Anything higher than 10 seems to be exactly the same as 10.
        ///
        /// > Blip blip
        /// > int displayId
        ///
        /// </summary>
        SET_BLIP_DISPLAY = 0x9029B2F3DA924928,
        /// <summary>
        /// Example: https://i.imgur.com/skY6vAJ.png
        /// 
        /// Index:
        /// 1 = No distance shown in legend
        /// 2 = Distance shown in legend
        /// 7 = "Other Players" category, also shows distance in legend
        /// 10 = "Property" category
        /// 11 = "Owned Property" category
        /// 
        /// Any other value behaves like index = 1, index wraps around after 255
        /// Blips with categories 7, 10 or 11 will all show under the specific categories listing in the map legend, regardless of sprite or name.
        /// Legend entries:
        /// 7 = Other Players (BLIP_OTHPLYR)
        /// 10 = Property (BLIP_PROPCAT)
        /// 11 = Owned Property (BLIP_APARTCAT)
        /// 
        /// Category needs to be `7` in order for blip names to show on the expanded minimap when using DISPLAY_PLAYER_NAME_TAGS_ON_BLIPS.
        ///
        /// > Blip blip
        /// > int index
        ///
        /// </summary>
        SET_BLIP_CATEGORY = 0x234CDD44D996FD9A,
        /// <summary>
        /// In the C++ SDK, this seems not to work-- the blip isn't removed immediately. I use it for saving cars.
        /// 
        /// E.g.:
        /// 
        /// Ped pped = PLAYER::PLAYER_PED_ID();
        /// Vehicle v = PED::GET_VEHICLE_PED_IS_USING(pped);
        /// Blip b = HUD::ADD_BLIP_FOR_ENTITY(v);
        /// 
        /// works fine.
        /// But later attempting to delete it with:
        /// 
        /// Blip b = HUD::GET_BLIP_FROM_ENTITY(v);
        /// if (HUD::DOES_BLIP_EXIST(b)) HUD::REMOVE_BLIP(&b);
        /// 
        /// doesn't work. And yes, doesn't work without the DOES_BLIP_EXIST check either. Also, if you attach multiple blips to the same thing (say, a vehicle), and that thing disappears, the blips randomly attach to other things (in my case, a vehicle).
        /// 
        /// Thus for me, HUD::REMOVE_BLIP(&b) only works if there's one blip, (in my case) the vehicle is marked as no longer needed, you drive away from it and it eventually despawns, AND there is only one blip attached to it. I never intentionally attach multiple blips but if the user saves the car, this adds a blip. Then if they delete it, it is supposed to remove the blip, but it doesn't. Then they can immediately save it again, causing another blip to re-appear.
        /// -------------
        /// 
        /// Passing the address of the variable instead of the value works for me.
        /// e.g.
        /// int blip = HUD::ADD_BLIP_FOR_ENTITY(ped);
        /// HUD::REMOVE_BLIP(&blip);
        /// 
        /// 
        /// Remove blip will currently crash your game, just artificially remove the blip by setting the sprite to a id that is 'invisible'.
        /// 
        /// --
        /// It crashes my game.
        ///
        /// > Blip* blip
        ///
        /// </summary>
        REMOVE_BLIP = 0x86A652570E5F25DD,
        /// <summary>
        /// false for enemy
        /// true for friendly
        ///
        /// > Blip blip
        /// > BOOL toggle
        ///
        /// </summary>
        SET_BLIP_AS_FRIENDLY = 0x6F6F290102C02AB4,
        /// <summary>
        /// Adds a green checkmark on top of a blip.
        ///
        /// > Blip blip
        /// > BOOL toggle
        ///
        /// </summary>
        SHOW_TICK_ON_BLIP = 0x74513EA3E505181E,
        /// <summary>
        /// Adds the GTA: Online player heading indicator to a blip.
        ///
        /// > Blip blip
        /// > BOOL toggle
        ///
        /// </summary>
        SHOW_HEADING_INDICATOR_ON_BLIP = 0x5FBCA48327B914DF,
        /// <summary>
        /// Highlights a blip by a cyan color circle.
        /// 
        /// Color can be changed with SET_BLIP_SECONDARY_COLOUR
        ///
        /// > Blip blip
        /// > BOOL toggle
        ///
        /// </summary>
        SHOW_OUTLINE_INDICATOR_ON_BLIP = 0xB81656BC81FE24D1,
        /// <summary>
        /// Highlights a blip by a half cyan circle on the right side of the blip. https://i.imgur.com/FrV9M4e.png
        /// .Indicating that that player is a friend (in GTA:O). This color can not be changed.
        /// To toggle the left side (crew member indicator) of the half circle around the blip, use: `SHOW_CREW_INDICATOR_ON_BLIP`
        ///
        /// > Blip blip
        /// > BOOL toggle
        ///
        /// </summary>
        SHOW_FRIEND_INDICATOR_ON_BLIP = 0x23C3EB807312F01A,
        /// <summary>
        /// Enables or disables the blue half circle https://i.imgur.com/iZes9Ec.png around the specified blip on the left side of the blip. This is used to indicate that the player is in your crew in GTA:O. Color is changeable by using `SET_BLIP_SECONDARY_COLOUR`.
        ///
        /// > Blip blip
        /// > BOOL toggle
        ///
        /// </summary>
        SHOW_CREW_INDICATOR_ON_BLIP = 0xDCFB5D4DB8BF367E,
        /// <summary>
        /// Must be toggled before being queued for animation
        ///
        /// > Blip blip
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_BLIP_DISPLAY_INDICATOR_ON_BLIP = 0xC4278F70131BAA6D,
        /// <summary>
        /// Makes a blip go small when off the minimap.
        ///
        /// > Blip blip
        /// > BOOL toggle
        ///
        /// </summary>
        SET_BLIP_AS_MINIMAL_ON_EDGE = 0x2B6D467DAB714E8D,
        /// <summary>
        /// Enabling this on a radius blip will make it outline only. See https://cdn.discordapp.com/attachments/553235301632573459/575132227935928330/unknown.png
        ///
        /// > Blip blip
        /// > BOOL toggle
        ///
        /// </summary>
        SET_RADIUS_BLIP_EDGE = 0x25615540D894B814,
        /// <summary>
        /// This native removes the current waypoint from the map.
        /// 
        /// Example:
        /// C#:
        /// Function.Call(Hash.SET_WAYPOINT_OFF);
        /// 
        /// C++:
        /// HUD::SET_WAYPOINT_OFF();
        ///
        ///
        /// </summary>
        SET_WAYPOINT_OFF = 0xA7E4E2D361C2627F,
        /// <summary>
        /// This native is used to colorize certain map components like the army base at the top of the map.
        /// p2 appears to be always -1. If p2 is -1 then native wouldn't change the color. See https://gfycat.com/SkinnyPinkChupacabra
        ///
        /// > int componentId
        /// > BOOL toggle
        /// > int overrideColor
        ///
        /// </summary>
        SET_MINIMAP_COMPONENT = 0x75A9A10948D1DEA6,
        /// <summary>
        /// List of interior hashes: pastebin.com/1FUyXNqY
        /// Not for every interior zoom > 0 available.
        ///
        /// > Hash interior
        /// > float x
        /// > float y
        /// > int z
        /// > int zoom
        ///
        /// </summary>
        SET_RADAR_AS_INTERIOR_THIS_FRAME = 0x59E727A1C9D3E31A,
        /// <summary>
        /// Sets the position of the arrow icon representing the player on both the minimap and world map.
        /// 
        /// Too bad this wouldn't work over the network (obviously not). Could spoof where we would be.
        ///
        /// > float x
        /// > float y
        ///
        /// </summary>
        _SET_PLAYER_BLIP_POSITION_THIS_FRAME = 0x77E2DD177910E1CF,
        /// <summary>
        /// Toggles the Cayo Perico map.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_TOGGLE_MINIMAP_HEIST_ISLAND = 0x5E1460624D194A38,
        /// <summary>
        /// When calling this, the current frame will have the players "arrow icon" be focused on the dead center of the radar.
        ///
        ///
        /// </summary>
        DONT_TILT_MINIMAP_THIS_FRAME = 0x6D14BFDC33B34F55,
        /// <summary>
        /// "DISPLAY_CASH(false);" makes the cash amount render on the screen when appropriate
        /// "DISPLAY_CASH(true);" disables cash amount rendering
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        DISPLAY_CASH = 0x96DEC8D5430208B7,
        /// <summary>
        /// Displays cash change notifications on HUD.
        ///
        /// > int cash
        /// > int bank
        ///
        /// </summary>
        _SET_PLAYER_CASH_CHANGE = 0x0772DF77852C2E30,
        /// <summary>
        /// Displays the crosshair for this frame.
        ///
        ///
        /// </summary>
        DISPLAY_SNIPER_SCOPE_THIS_FRAME = 0x73115226F4814E62,
        /// <summary>
        /// I think this works, but seems to prohibit switching to other weapons (or accessing the weapon wheel)
        ///
        ///
        /// </summary>
        HIDE_HUD_AND_RADAR_THIS_FRAME = 0x719FF505F097FD20,
        /// <summary>
        /// This native does absolutely nothing, just a nullsub
        ///
        /// > int p0
        /// > int p1
        ///
        /// </summary>
        SET_MULTIPLAYER_HUD_CASH = 0xFD1D220394BCB824,
        /// <summary>
        /// Removes multiplayer cash hud each frame
        ///
        ///
        /// </summary>
        REMOVE_MULTIPLAYER_HUD_CASH = 0x968F270E39141ECA,
        /// <summary>
        /// The messages are localized strings.
        /// Examples:
        /// "No_bus_money"
        /// "Enter_bus"
        /// "Tour_help"
        /// "LETTERS_HELP2"
        /// "Dummy"
        /// 
        /// **The bool appears to always be false (if it even is a bool, as it's represented by a zero)**
        /// --------
        /// p1 doesn't seem to make a difference, regardless of the state it's in. 
        /// 
        /// 
        /// picture of where on the screen this is displayed? 
        ///
        /// > const char* message
        /// > BOOL p1
        ///
        /// </summary>
        DISPLAY_HELP_TEXT_THIS_FRAME = 0x960C9FF8F616E41C,
        /// <summary>
        /// Forces the weapon wheel to show/hide.
        ///
        /// > BOOL show
        ///
        /// </summary>
        HUD_FORCE_WEAPON_WHEEL = 0xEB354E5376BC81A7,
        /// <summary>
        /// Displays loading screen tips, requires `_0x56C8B608CFD49854` to be called beforehand.
        ///
        ///
        /// </summary>
        _HUD_DISPLAY_LOADING_SCREEN_TIPS = 0x488043841BBE156F,
        /// <summary>
        /// Calling this each frame, stops the player from receiving a weapon via the weapon wheel.
        ///
        ///
        /// </summary>
        _HUD_WEAPON_WHEEL_IGNORE_SELECTION = 0x0AFC4AF510774B47,
        /// <summary>
        /// Returns the weapon hash to the selected/highlighted weapon in the wheel
        ///
        ///
        /// </summary>
        _HUD_WEAPON_WHEEL_GET_SELECTED_HASH = 0xA48931185F0536FE,
        /// <summary>
        /// Set the active slotIndex in the wheel weapon to the slot associated with the provided Weapon hash
        ///
        /// > Hash weaponHash
        ///
        /// </summary>
        HUD_SET_WEAPON_WHEEL_TOP_SLOT = 0x72C1056D678BB7D8,
        /// <summary>
        /// Returns the weapon hash active in a specific weapon wheel slotList
        ///
        /// > int weaponTypeIndex
        ///
        /// </summary>
        _HUD_WEAPON_WHEEL_GET_SLOT_HASH = 0xA13E93403F26C812,
        /// <summary>
        /// Sets a global that disables many weapon input tasks (shooting, aiming, etc.). Does not work with vehicle weapons, only used in selector.ysc
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _HUD_WEAPON_WHEEL_IGNORE_CONTROL_INPUT = 0x14C9FDCC41F81F63,
        /// <summary>
        /// Only the script that originally called SET_GPS_FLAGS can set them again. Another script cannot set the flags, until the first script that called it has called CLEAR_GPS_FLAGS.
        /// 
        /// Doesn't seem like the flags are actually read by the game at all.
        ///
        /// > int p0
        /// > float p1
        ///
        /// </summary>
        SET_GPS_FLAGS = 0x5B440763A4C8D15B,
        /// <summary>
        /// Clears the GPS flags. Only the script that originally called SET_GPS_FLAGS can clear them.
        /// 
        /// Doesn't seem like the flags are actually read by the game at all.
        ///
        ///
        /// </summary>
        CLEAR_GPS_FLAGS = 0x21986729D6A3A830,
        /// <summary>
        /// Does the same as SET_RACE_TRACK_RENDER(false);
        ///
        ///
        /// </summary>
        CLEAR_GPS_RACE_TRACK = 0x7AA5B4CE533C858B,
        /// <summary>
        /// Starts a new GPS custom-route, allowing you to plot lines on the map.
        /// Lines are drawn directly between points.
        /// The GPS custom route works like the GPS multi route, except it does not follow roads.
        /// Example result: https://i.imgur.com/BDm5pzt.png
        /// hudColor: The HUD color of the GPS path.
        /// displayOnFoot: Draws the path regardless if the player is in a vehicle or not.
        /// followPlayer: Draw the path partially between the previous and next point based on the players position between them. When false, the GPS appears to not disappear after the last leg is completed.
        ///
        /// > int hudColor
        /// > BOOL displayOnFoot
        /// > BOOL followPlayer
        ///
        /// </summary>
        START_GPS_CUSTOM_ROUTE = 0xDB34E8D56FC13B08,
        /// <summary>
        /// radarThickness: The width of the GPS route on the radar
        /// mapThickness: The width of the GPS route on the map
        ///
        /// > BOOL toggle
        /// > int radarThickness
        /// > int mapThickness
        ///
        /// </summary>
        SET_GPS_CUSTOM_ROUTE_RENDER = 0x900086F371220B6F,
        /// <summary>
        /// Starts a new GPS multi-route, allowing you to create custom GPS paths.
        /// GPS functions like the waypoint, except it can contain multiple points it's forced to go through.
        /// Once the player has passed a point, the GPS will no longer force its path through it.
        /// 
        /// Works independently from the player-placed waypoint and blip routes.
        /// Example result: https://i.imgur.com/ZZHQatX.png
        /// hudColor: The HUD color of the GPS path.
        /// routeFromPlayer: Makes the GPS draw a path from the player to the next point, rather than the original path from the previous point.
        /// displayOnFoot: Draws the GPS path regardless if the player is in a vehicle or not.
        ///
        /// > int hudColor
        /// > BOOL routeFromPlayer
        /// > BOOL displayOnFoot
        ///
        /// </summary>
        START_GPS_MULTI_ROUTE = 0x3D3D15AF7BCAAF83,
        /// <summary>
        /// Does the same as SET_GPS_MULTI_ROUTE_RENDER(false);
        ///
        ///
        /// </summary>
        CLEAR_GPS_MULTI_ROUTE = 0x67EEDEA1B9BAFD94,
        /// <summary>
        /// adds a short flash to the Radar/Minimap
        /// Usage: UI.FLASH_MINIMAP_DISPLAY
        ///
        ///
        /// </summary>
        FLASH_MINIMAP_DISPLAY = 0xF2DD778C22B15BDA,
        /// <summary>
        /// Toggles the North Yankton map
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_MINIMAP_IN_PROLOGUE = 0x9133955F1A2DA957,
        /// <summary>
        /// If true, the entire map will be revealed.
        /// 
        /// FOW = Fog of War
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_MINIMAP_HIDE_FOW = 0xF8DEE0A5600CBB93,
        /// <summary>
        /// Not much is known so far on what it does _exactly_.
        /// All I know for sure is that it draws the specified hole ID on the pause menu map as well as on the mini-map/radar. This native also seems to change some other things related to the pause menu map's behaviour, for example: you can no longer set waypoints, the pause menu map starts up in a 'zoomed in' state. This native does not need to be executed every tick.
        /// You need to center the minimap manually as well as change/lock it's zoom and angle in order for it to appear correctly on the minimap.
        /// You'll also need to use the `GOLF` scaleform in order to get the correct minmap border to show up.
        /// Use `0x35edd5b2e3ff01c0` to reset the map when you no longer want to display any golf holes (you still need to unlock zoom, position and angle of the radar manually after calling this).
        ///
        /// > int hole
        ///
        /// </summary>
        SET_MINIMAP_GOLF_COURSE = 0x71BDB63DBAF8DA59,
        /// <summary>
        /// Locks the minimap to the specified angle in integer degrees.
        /// 
        /// angle: The angle in whole degrees. If less than 0 or greater than 360, unlocks the angle.
        ///
        /// > int angle
        ///
        /// </summary>
        LOCK_MINIMAP_ANGLE = 0x299FAEBB108AE05B,
        /// <summary>
        /// Locks the minimap to the specified world position.
        ///
        /// > float x
        /// > float y
        ///
        /// </summary>
        LOCK_MINIMAP_POSITION = 0x1279E861A329E73F,
        /// <summary>
        /// Argument must be 0.0f or above 38.0f, or it will be ignored.
        ///
        /// > float altitude
        /// > BOOL p1
        /// > Any p2
        ///
        /// </summary>
        _SET_MINIMAP_ALTITUDE_INDICATOR_LEVEL = 0xD201F3FF917A506D,
        /// <summary>
        /// Toggles the big minimap state like in GTA:Online.
        ///
        /// > BOOL toggleBigMap
        /// > BOOL showFullMap
        ///
        /// </summary>
        SET_BIGMAP_ACTIVE = 0x231C8F89D0539D8F,
        /// <summary>
        /// Full list of components below
        /// 
        /// HUD = 0;
        /// HUD_WANTED_STARS = 1;
        /// HUD_WEAPON_ICON = 2;
        /// HUD_CASH = 3;
        /// HUD_MP_CASH = 4;
        /// HUD_MP_MESSAGE = 5;
        /// HUD_VEHICLE_NAME = 6;
        /// HUD_AREA_NAME = 7;
        /// HUD_VEHICLE_CLASS = 8;
        /// HUD_STREET_NAME = 9;
        /// HUD_HELP_TEXT = 10;
        /// HUD_FLOATING_HELP_TEXT_1 = 11;
        /// HUD_FLOATING_HELP_TEXT_2 = 12;
        /// HUD_CASH_CHANGE = 13;
        /// HUD_RETICLE = 14;
        /// HUD_SUBTITLE_TEXT = 15;
        /// HUD_RADIO_STATIONS = 16;
        /// HUD_SAVING_GAME = 17;
        /// HUD_GAME_STREAM = 18;
        /// HUD_WEAPON_WHEEL = 19;
        /// HUD_WEAPON_WHEEL_STATS = 20;
        /// MAX_HUD_COMPONENTS = 21;
        /// MAX_HUD_WEAPONS = 22;
        /// MAX_SCRIPTED_HUD_COMPONENTS = 141;
        ///
        /// > int id
        ///
        /// </summary>
        IS_HUD_COMPONENT_ACTIVE = 0xBC4C9EA5391ECC0D,
        /// <summary>
        /// SHOW_*
        ///
        /// > int id
        ///
        /// </summary>
        _SHOW_SCRIPTED_HUD_COMPONENT_THIS_FRAME = 0x4F38DCA127DAAEA2,
        /// <summary>
        /// This function hides various HUD (Heads-up Display) components.
        /// Listed below are the integers and the corresponding HUD component.
        /// - 1 : WANTED_STARS
        /// - 2 : WEAPON_ICON
        /// - 3 : CASH
        /// - 4 : MP_CASH
        /// - 5 : MP_MESSAGE
        /// - 6 : VEHICLE_NAME
        /// - 7 : AREA_NAME
        /// - 8 : VEHICLE_CLASS
        /// - 9 : STREET_NAME
        /// - 10 : HELP_TEXT
        /// - 11 : FLOATING_HELP_TEXT_1
        /// - 12 : FLOATING_HELP_TEXT_2
        /// - 13 : CASH_CHANGE
        /// - 14 : RETICLE
        /// - 15 : SUBTITLE_TEXT
        /// - 16 : RADIO_STATIONS
        /// - 17 : SAVING_GAME
        /// - 18 : GAME_STREAM
        /// - 19 : WEAPON_WHEEL
        /// - 20 : WEAPON_WHEEL_STATS
        /// - 21 : HUD_COMPONENTS
        /// - 22 : HUD_WEAPONS
        /// 
        /// These integers also work for the `SHOW_HUD_COMPONENT_THIS_FRAME` native, but instead shows the HUD Component.
        ///
        /// > int id
        ///
        /// </summary>
        HIDE_HUD_COMPONENT_THIS_FRAME = 0x6806C51AD12B83B8,
        /// <summary>
        /// This function hides various HUD (Heads-up Display) components.
        /// Listed below are the integers and the corresponding HUD component.
        /// - 1 : WANTED_STARS
        /// - 2 : WEAPON_ICON
        /// - 3 : CASH
        /// - 4 : MP_CASH
        /// - 5 : MP_MESSAGE
        /// - 6 : VEHICLE_NAME
        /// - 7 : AREA_NAME
        /// - 8 : VEHICLE_CLASS
        /// - 9 : STREET_NAME
        /// - 10 : HELP_TEXT
        /// - 11 : FLOATING_HELP_TEXT_1
        /// - 12 : FLOATING_HELP_TEXT_2
        /// - 13 : CASH_CHANGE
        /// - 14 : RETICLE
        /// - 15 : SUBTITLE_TEXT
        /// - 16 : RADIO_STATIONS
        /// - 17 : SAVING_GAME
        /// - 18 : GAME_STREAM
        /// - 19 : WEAPON_WHEEL
        /// - 20 : WEAPON_WHEEL_STATS
        /// - 21 : HUD_COMPONENTS
        /// - 22 : HUD_WEAPONS
        /// 
        /// These integers also work for the `HIDE_HUD_COMPONENT_THIS_FRAME` native, but instead hides the HUD Component.
        ///
        /// > int id
        ///
        /// </summary>
        SHOW_HUD_COMPONENT_THIS_FRAME = 0x0B4DF1FA60C0E664,
        /// <summary>
        /// HIDE_*_THIS_FRAME
        /// 
        /// Hides area and vehicle name HUD components for one frame.
        ///
        ///
        /// </summary>
        _HIDE_AREA_AND_VEHICLE_NAME_THIS_FRAME = 0xA4DEDE28B1814289,
        /// <summary>
        /// This native does absolutely nothing, just a nullsub
        ///
        ///
        /// </summary>
        CLEAR_REMINDER_MESSAGE = 0xB57D8DD645CFA2CF,
        /// <summary>
        /// World to relative screen coords, this world to screen will keep the text on screen. Was named _GET_SCREEN_COORD_FROM_WORLD_COORD, but this conflicts with 0x34E82F05DF2974F5. As that hash actually matches GET_SCREEN_COORD_FROM_WORLD_COORD that one supercedes and this one was renamed to _GET_2D_COORD_FROM_3D_COORD
        ///
        /// > float worldX
        /// > float worldY
        /// > float worldZ
        /// > float* screenX
        /// > float* screenY
        ///
        /// </summary>
        GET_HUD_SCREEN_POSITION_FROM_WORLD_POSITION = 0xF9904D11F1ACBEC3,
        /// <summary>
        /// Shows a menu for reporting UGC content.
        ///
        ///
        /// </summary>
        OPEN_REPORTUGC_MENU = 0x523A590C1A3CC0D3,
        /// <summary>
        /// clanFlag: takes a number 0-5
        ///
        /// > Player player
        /// > const char* username
        /// > BOOL pointedClanTag
        /// > BOOL isRockstarClan
        /// > const char* clanTag
        /// > int clanFlag
        /// > int r
        /// > int g
        /// > int b
        ///
        /// </summary>
        CREATE_MP_GAMER_TAG_WITH_CREW_COLOR = 0x6DD05E9D83EFA4C9,
        /// <summary>
        /// clanFlag: takes a number 0-5
        ///
        /// > Ped ped
        /// > const char* username
        /// > BOOL pointedClanTag
        /// > BOOL isRockstarClan
        /// > const char* clanTag
        /// > int clanFlag
        ///
        /// </summary>
        CREATE_FAKE_MP_GAMER_TAG = 0xBFEFE3321A3F5015,
        /// <summary>
        /// enum eMpGamerTagComponent
        /// {
        /// 	MP_TAG_GAMER_NAME,
        /// 	MP_TAG_CREW_TAG,
        /// 	MP_TAG_HEALTH_ARMOUR,
        /// 	MP_TAG_BIG_TEXT,
        /// 	MP_TAG_AUDIO_ICON,
        /// 	MP_TAG_USING_MENU,
        /// 	MP_TAG_PASSIVE_MODE,
        /// 	MP_TAG_WANTED_STARS,
        /// 	MP_TAG_DRIVER,
        /// 	MP_TAG_CO_DRIVER,
        /// 	MP_TAG_TAGGED,
        /// 	MP_TAG_GAMER_NAME_NEARBY,
        /// 	MP_TAG_ARROW,
        /// 	MP_TAG_PACKAGES,
        /// 	MP_TAG_INV_IF_PED_FOLLOWING,
        /// 	MP_TAG_RANK_TEXT,
        /// 	MP_TAG_TYPING,
        /// 	MP_TAG_BAG_LARGE,
        /// 	MP_TAG_ARROW,
        /// 	MP_TAG_GANG_CEO,
        /// 	MP_TAG_GANG_BIKER,
        /// 	MP_TAG_BIKER_ARROW,
        /// 	MP_TAG_MC_ROLE_PRESIDENT,
        /// 	MP_TAG_MC_ROLE_VICE_PRESIDENT,
        /// 	MP_TAG_MC_ROLE_ROAD_CAPTAIN,
        /// 	MP_TAG_MC_ROLE_SARGEANT,
        /// 	MP_TAG_MC_ROLE_ENFORCER,
        /// 	MP_TAG_MC_ROLE_PROSPECT,
        /// 	MP_TAG_TRANSMITTER,
        /// 	MP_TAG_BOMB
        /// };
        ///
        /// > int gamerTagId
        /// > int component
        /// > BOOL toggle
        /// > Any p3
        ///
        /// </summary>
        SET_MP_GAMER_TAG_VISIBILITY = 0x63BB75ABEDC1F6A0,
        /// <summary>
        /// Displays a bunch of icons above the players name, and level, and their name twice
        ///
        /// > int gamerTagId
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_MP_GAMER_TAG_ICONS = 0xA67F9C46D612B6F1,
        /// <summary>
        /// Sets a gamer tag's component colour
        /// 
        /// gamerTagId is obtained using for example CREATE_FAKE_MP_GAMER_TAG
        /// Ranges from 0 to 255. 0 is grey health bar, ~50 yellow, 200 purple.
        ///
        /// > int gamerTagId
        /// > int component
        /// > int hudColorIndex
        ///
        /// </summary>
        SET_MP_GAMER_TAG_COLOUR = 0x613ED644950626AE,
        /// <summary>
        /// Ranges from 0 to 255. 0 is grey health bar, ~50 yellow, 200 purple.
        /// Should be enabled as flag (2). Has 0 opacity by default.
        /// 
        /// - This was _SET_MP_GAMER_TAG_HEALTH_BAR_COLOR,
        /// -> Rockstar use the EU spelling of 'color' so I hashed the same name with COLOUR and it came back as the correct hash, so it has been corrected above.
        ///
        /// > int gamerTagId
        /// > int hudColorIndex
        ///
        /// </summary>
        SET_MP_GAMER_TAG_HEALTH_BAR_COLOUR = 0x3158C77A7E888AB4,
        /// <summary>
        /// Sets flag's sprite transparency. 0-255.
        ///
        /// > int gamerTagId
        /// > int component
        /// > int alpha
        ///
        /// </summary>
        SET_MP_GAMER_TAG_ALPHA = 0xD48FE545CD46F857,
        /// <summary>
        /// displays wanted star above head
        ///
        /// > int gamerTagId
        /// > int wantedlvl
        ///
        /// </summary>
        SET_MP_GAMER_TAG_WANTED_LEVEL = 0xCF228E2AA03099C3,
        /// <summary>
        /// IS_*
        ///
        /// > int gamerTagId
        ///
        /// </summary>
        _IS_VALID_MP_GAMER_TAG_MOVIE = 0xEB709A36958ABE0D,
        /// <summary>
        /// Returns the ActionScript flagValue.
        /// ActionScript flags are global flags that scaleforms use
        /// Flags found during testing
        /// 0: Returns 1 if the web_browser keyboard is open, otherwise 0
        /// 1: Returns 1 if the player has clicked back twice on the opening page, otherwise 0 (web_browser)
        /// 2: Returns how many links the player has clicked in the web_browser scaleform, returns 0 when the browser gets closed
        /// 9: Returns the current selection on the mobile phone scaleform
        /// 
        /// There are 20 flags in total.
        ///
        /// > int flagIndex
        ///
        /// </summary>
        GET_GLOBAL_ACTIONSCRIPT_FLAG = 0xE3B05614DCE1D014,
        /// <summary>
        /// IS_WARNING_MESSAGE_*
        ///
        ///
        /// </summary>
        _IS_WARNING_MESSAGE_ACTIVE_2 = 0xAF42195A42C63BBA,
        /// <summary>
        /// You can only use text entries. No custom text.
        /// 
        /// Example: SET_WARNING_MESSAGE("t20", 3, "adder", false, -1, 0, 0, true);
        ///
        /// > const char* titleMsg
        /// > int flags
        /// > const char* promptMsg
        /// > BOOL p3
        /// > int p4
        /// > const char* p5
        /// > const char* p6
        /// > BOOL showBackground
        /// > Any p8
        ///
        /// </summary>
        SET_WARNING_MESSAGE = 0x7B1776B3B53F8D74,
        /// <summary>
        /// Shows a warning message on screen with a header.
        /// Note: You can only use text entries. No custom text. You can recreate this easily with scaleforms.
        /// Example: https://i.imgur.com/ITJt8bJ.png
        ///
        /// > const char* entryHeader
        /// > const char* entryLine1
        /// > int instructionalKey
        /// > const char* entryLine2
        /// > BOOL p4
        /// > Any p5
        /// > Any* showBackground
        /// > Any* p7
        /// > BOOL p8
        /// > Any p9
        ///
        /// </summary>
        SET_WARNING_MESSAGE_WITH_HEADER = 0xDC38CC1E35B6A5D7,
        /// <summary>
        /// You can use this native for custom input, without having to use any scaleform-related natives.
        /// The native must be called on tick.
        /// The entryHeader must be a valid label.
        /// For Single lines use JL_INVITE_N as entryLine1, JL_INVITE_ND for multiple.
        /// Notes:
        /// - additionalIntInfo: replaces first occurrence of ~1~ in provided label with an integer
        /// - additionalTextInfoLine1: replaces first occurrence of ~a~ in provided label, with your custom text
        /// - additionalTextInfoLine2: replaces second occurrence of ~a~ in provided label, with your custom text
        /// - showBackground: shows black background of the warning screen
        /// - errorCode: shows an error code at the bottom left if nonzero
        /// Example of usage:
        /// SET_WARNING_MESSAGE_WITH_HEADER_AND_SUBSTRING_FLAGS("ALERT", "JL_INVITE_ND", 66, "", true, -1, -1, "Testing line 1", "Testing line 2", true, 0);
        /// Screenshot:
        /// https://imgur.com/a/IYA7vJ8
        ///
        /// > const char* entryHeader
        /// > const char* entryLine1
        /// > int instructionalKey
        /// > const char* entryLine2
        /// > BOOL p4
        /// > Any p5
        /// > Any additionalIntInfo
        /// > const char* additionalTextInfoLine1
        /// > const char* additionalTextInfoLine2
        /// > BOOL showBackground
        /// > int errorCode
        ///
        /// </summary>
        SET_WARNING_MESSAGE_WITH_HEADER_AND_SUBSTRING_FLAGS = 0x701919482C74B5AB,
        /// <summary>
        /// labelTitle: Label of the alert's title.
        /// labelMsg: Label of the alert's message.
        /// p2: This is an enum, check the description for a list.
        /// p3: This is an enum, check the description for a list.
        /// labelMsg2: Label of another message line
        /// p5: usually 0
        /// p6: usually -1
        /// p7: usually 0
        /// p8: unknown label
        /// p9: unknown label
        /// background: Set to anything other than 0 or false (even any string) and it will draw a background. Setting it to 0 or false will draw no background.
        /// errorCode: Error code, shown at the bottom left if set to value other than 0.
        /// 
        /// instructionalKey enum list:
        /// Buttons = {
        ///       Empty = 0,
        ///       Select = 1, -- (RETURN)
        ///       Ok = 2, -- (RETURN)
        ///       Yes = 4, -- (RETURN)
        ///       Back = 8, -- (ESC)
        ///       Cancel = 16, -- (ESC)
        ///       No = 32, -- (ESC)
        ///       RetrySpace = 64, -- (SPACE)
        ///       Restart = 128, -- (SPACE)
        ///       Skip = 256, -- (SPACE)
        ///       Quit = 512, -- (ESC)
        ///       Adjust = 1024, -- (ARROWS)
        ///       SpaceKey = 2048, -- (SPACE)
        ///       Share = 4096, -- (SPACE)
        ///       SignIn = 8192, -- (SPACE)
        ///       Continue = 16384, -- (RETURN)
        ///       AdjustLeftRight = 32768, -- (SCROLL L/R)
        ///       AdjustUpDown = 65536, -- (SCROLL U/D)
        ///       Overwrite = 131072, -- (SPACE)
        ///       SocialClubSignup = 262144, -- (RETURN)
        ///       Confirm = 524288, -- (RETURN)
        ///       Queue = 1048576, -- (RETURN)
        ///       RetryReturn = 2097152, -- (RETURN)
        ///       BackEsc = 4194304, -- (ESC)
        ///       SocialClub = 8388608, -- (RETURN)
        ///       Spectate = 16777216, -- (SPACE)
        ///       OkEsc = 33554432, -- (ESC)
        ///       CancelTransfer = 67108864, -- (ESC)
        ///       LoadingSpinner = 134217728,
        ///       NoReturnToGTA = 268435456, -- (ESC)
        ///       CancelEsc = 536870912, -- (ESC)
        /// }
        /// 
        /// Alt = {
        ///       Empty = 0,
        ///       No = 1, -- (SPACE)
        ///       Host = 2, -- (ESC)
        ///       SearchForJob = 4, -- (RETURN)
        ///       ReturnKey = 8, -- (TURN)
        ///       Freemode = 16, -- (ESC)
        /// }
        /// 
        /// Example: https://i.imgur.com/TvmNF4k.png
        ///
        /// > const char* labelTitle
        /// > const char* labelMessage
        /// > int p2
        /// > int p3
        /// > const char* labelMessage2
        /// > BOOL p5
        /// > int p6
        /// > int p7
        /// > const char* p8
        /// > const char* p9
        /// > BOOL background
        /// > int errorCode
        ///
        /// </summary>
        _SET_WARNING_MESSAGE_WITH_ALERT = 0x15803FEC3B9A872B,
        /// <summary>
        /// Has to do with the confirmation overlay (E.g. confirm exit)
        ///
        ///
        /// </summary>
        _GET_WARNING_MESSAGE_TITLE_HASH = 0x81DF9ABA6C83DFF9,
        /// <summary>
        /// Some sort of list displayed in a warning message. Yet unknown how to prevent repeating.
        /// Param names copied from the corresponding scaleform function "SET_LIST_ROW".
        /// Example: https://i.imgur.com/arKvOYx.png
        ///
        /// > int index
        /// > const char* name
        /// > int cash
        /// > int rp
        /// > int lvl
        /// > int colour
        ///
        /// </summary>
        _SET_WARNING_MESSAGE_LIST_ROW = 0x0C5A80A9E096D529,
        /// <summary>
        /// If toggle is true, the map is shown in full screen
        /// If toggle is false, the map is shown in normal mode
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _RACE_GALLERY_FULLSCREEN = 0x5354C5BA2EA868A4,
        /// <summary>
        /// Sets the sprite of the next BLIP_GALLERY blip, values used in the native scripts: 143 (ObjectiveBlue), 144 (ObjectiveGreen), 145 (ObjectiveRed), 146 (ObjectiveYellow).
        ///
        /// > int spriteId
        ///
        /// </summary>
        _RACE_GALLERY_NEXT_BLIP_SPRITE = 0x1EAE6DD17B7A5EFA,
        /// <summary>
        /// Add a BLIP_GALLERY at the specific coordinate. Used in fm_maintain_transition_players to display race track points.
        ///
        /// > float x
        /// > float y
        /// > float z
        ///
        /// </summary>
        _RACE_GALLERY_ADD_BLIP = 0x551DF99658DB6EE8,
        /// <summary>
        /// Doesn't actually return anything.
        ///
        ///
        /// </summary>
        FORCE_SONAR_BLIPS_THIS_FRAME = 0x1121BFA1A1A522A8,
        /// <summary>
        /// Toggles whether or not name labels are shown on the expanded minimap next to player blips, like in GTA:O.
        /// Doesn't need to be called every frame.
        /// Preview: https://i.imgur.com/DfqKWfJ.png
        /// 
        /// Make sure to call SET_BLIP_CATEGORY with index 7 for this to work on the desired blip.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        DISPLAY_PLAYER_NAME_TAGS_ON_BLIPS = 0x82CEDC33687E1F50,
        /// <summary>
        /// Does stuff like this:
        /// gyazo.com/7fcb78ea3520e3dbc5b2c0c0f3712617
        /// 
        /// Example:
        /// int GetHash = GET_HASH_KEY("fe_menu_version_corona_lobby");
        /// ACTIVATE_FRONTEND_MENU(GetHash, 0, -1);
        /// 
        /// BOOL p1 is a toggle to define the game in pause.
        /// int p2 is unknown but -1 always works, not sure why though.
        /// 
        /// [30/03/2017] ins1de :
        /// 
        /// the int p2 is actually a component variable. When the pause menu is visible, it opens the tab related to it.
        /// 
        /// Example : Function.Call(Hash.ACTIVATE_FRONTEND_MENU,-1171018317, 0, 42);
        /// Result : Opens the "Online" tab without pausing the menu, with -1 it opens the map.Below is a list of all known Frontend Menu Hashes.
        /// - FE_MENU_VERSION_SP_PAUSE
        /// - FE_MENU_VERSION_MP_PAUSE
        /// - FE_MENU_VERSION_CREATOR_PAUSE
        /// - FE_MENU_VERSION_CUTSCENE_PAUSE
        /// - FE_MENU_VERSION_SAVEGAME
        /// - FE_MENU_VERSION_PRE_LOBBY
        /// - FE_MENU_VERSION_LOBBY
        /// - FE_MENU_VERSION_MP_CHARACTER_SELECT
        /// - FE_MENU_VERSION_MP_CHARACTER_CREATION
        /// - FE_MENU_VERSION_EMPTY
        /// - FE_MENU_VERSION_EMPTY_NO_BACKGROUND
        /// - FE_MENU_VERSION_TEXT_SELECTION
        /// - FE_MENU_VERSION_CORONA
        /// - FE_MENU_VERSION_CORONA_LOBBY
        /// - FE_MENU_VERSION_CORONA_JOINED_PLAYERS
        /// - FE_MENU_VERSION_CORONA_INVITE_PLAYERS
        /// - FE_MENU_VERSION_CORONA_INVITE_FRIENDS
        /// - FE_MENU_VERSION_CORONA_INVITE_CREWS
        /// - FE_MENU_VERSION_CORONA_INVITE_MATCHED_PLAYERS
        /// - FE_MENU_VERSION_CORONA_INVITE_LAST_JOB_PLAYERS
        /// - FE_MENU_VERSION_CORONA_RACE
        /// - FE_MENU_VERSION_CORONA_BETTING
        /// - FE_MENU_VERSION_JOINING_SCREEN
        /// - FE_MENU_VERSION_LANDING_MENU
        /// - FE_MENU_VERSION_LANDING_KEYMAPPING_MENU
        ///
        /// > Hash menuhash
        /// > BOOL togglePause
        /// > int component
        ///
        /// </summary>
        ACTIVATE_FRONTEND_MENU = 0xEF01D36B9C9D0C7B,
        /// <summary>
        /// Before using this native click the native above and look at the decription.
        /// 
        /// Example:
        /// int GetHash = Function.Call<int>(Hash.GET_HASH_KEY, "fe_menu_version_corona_lobby");
        /// Function.Call(Hash.ACTIVATE_FRONTEND_MENU, GetHash, 0, -1);
        /// Function.Call(Hash.RESTART_FRONTEND_MENU(GetHash, -1);
        /// 
        /// This native refreshes the frontend menu.
        /// 
        /// p1 = Hash of Menu
        /// p2 = Unknown but always works with -1.
        ///
        /// > Hash menuHash
        /// > int p1
        ///
        /// </summary>
        RESTART_FRONTEND_MENU = 0x10706DC6AD2D49C0,
        /// <summary>
        /// if (HUD::GET_CURRENT_FRONTEND_MENU_VERSION() == joaat("fe_menu_version_empty_no_background"))
        ///
        ///
        /// </summary>
        GET_CURRENT_FRONTEND_MENU_VERSION = 0x2309595AD6145265,
        /// <summary>
        /// Allows opening the pause menu this frame, when the player is dead.
        ///
        ///
        /// </summary>
        _ALLOW_PAUSE_MENU_WHEN_DEAD_THIS_FRAME = 0xCC3FDDED67BCFC63,
        /// <summary>
        /// Returns:
        /// 
        /// 0
        /// 5
        /// 10
        /// 15
        /// 20
        /// 25
        /// 30
        /// 35
        /// 
        ///
        ///
        /// </summary>
        GET_PAUSE_MENU_STATE = 0x272ACD84970869C5,
        /// <summary>
        /// Not present in retail version of the game, actual definiton seems to be
        /// _LOG_DEBUG_INFO(const char* category, const char* debugText);
        ///
        /// > const char* p0
        ///
        /// </summary>
        _LOG_DEBUG_INFO = 0x2162C446DFDF38FD,
        /// <summary>
        /// Activates the specified frontend menu context.
        /// pausemenu.xml defines some specific menu options using 'context'. Context is basically a 'condition'. 
        /// The `*ALL*` part of the context means that whatever is being defined, will be active when any or all of those conditions after `*ALL*` are met.
        /// The `*NONE*` part of the context section means that whatever is being defined, will NOT be active if any or all of the conditions after `*NONE*` are met.
        /// This basically allows you to hide certain menu sections, or things like instructional buttons.
        ///
        /// > Hash contextHash
        ///
        /// </summary>
        PAUSE_MENU_ACTIVATE_CONTEXT = 0xDD564BDD0472C936,
        /// <summary>
        /// Disables frontend (works in custom frontends, not sure about regular pause menu) navigation keys on keyboard. Not sure about controller. Does not disable mouse controls. No need to call this every tick.
        /// 
        /// To enable the keys again, use `0x14621BB1DF14E2B2`.
        ///
        ///
        /// </summary>
        TAKE_CONTROL_OF_FRONTEND = 0xEC9264727EEC0F28,
        /// <summary>
        /// Enables frontend (works in custom frontends, not sure about regular pause menu) navigation keys on keyboard if they were disabled using the native below.
        /// To disable the keys, use `0xEC9264727EEC0F28`
        ///
        ///
        /// </summary>
        RELEASE_CONTROL_OF_FRONTEND = 0x14621BB1DF14E2B2,
        /// <summary>
        /// lastItemMenuId: this is the menuID of the last selected item minus 1000 (lastItem.menuID - 1000)
        /// selectedItemMenuId: same as lastItemMenuId except for the currently selected menu item
        /// selectedItemUniqueId: this is uniqueID of the currently selected menu item
        /// 
        /// when the pausemenu is closed:
        /// lastItemMenuId = -1
        /// selectedItemMenuId = -1
        /// selectedItemUniqueId = 0
        /// 
        /// when the header gains focus:
        /// lastItemMenuId updates as normal or 0 if the pausemenu was just opened
        /// selectedItemMenuId becomes a unique id for the pausemenu page that focus was taken from (?) or 0 if the pausemenu was just opened
        /// selectedItemUniqueId = -1
        /// 
        /// when focus is moved from the header to a pausemenu page:
        /// lastItemMenuId becomes a unique id for the pausemenu page that focus was moved to (?)
        /// selectedItemMenuId = -1
        /// selectedItemUniqueId updates as normal
        ///
        /// > int* lastItemMenuId
        /// > int* selectedItemMenuId
        /// > int* selectedItemUniqueId
        ///
        /// </summary>
        _GET_PAUSE_MENU_SELECTION_DATA = 0x7E17BE53E1AAABAF,
        /// <summary>
        /// p0 was always 0xAE2602A3.
        ///
        /// > Hash p0
        /// > Any* p1
        ///
        /// </summary>
        GET_MENU_PED_BOOL_STAT = 0x052991E59076E4E4,
        /// <summary>
        /// p1 is either 1 or 2 in the PC scripts.
        ///
        /// > Ped ped
        /// > int p1
        ///
        /// </summary>
        GIVE_PED_TO_PAUSE_MENU = 0xAC0BFBDC3BE00E14,
        /// <summary>
        /// Toggles the light state for the pause menu ped in frontend menus.
        /// 
        /// This is used by R* in combination with `SET_PAUSE_MENU_PED_SLEEP_STATE` to toggle the "offline" or "online" state in the "friends" tab of the pause menu in GTA Online.
        /// 
        /// 
        /// Example:
        /// Lights On: https://vespura.com/hi/i/2019-04-01_16-09_540ee_1015.png
        /// Lights Off: https://vespura.com/hi/i/2019-04-01_16-10_8b5e7_1016.png
        ///
        /// > BOOL state
        ///
        /// </summary>
        SET_PAUSE_MENU_PED_LIGHTING = 0x3CA6050692BC61B0,
        /// <summary>
        /// Toggles the pause menu ped sleep state for frontend menus.
        /// 
        /// Example: https://vespura.com/hi/i/2019-04-01_15-51_8ed38_1014.gif
        /// 
        /// `state` 0 will make the ped slowly fall asleep, 1 will slowly wake the ped up.
        ///
        /// > BOOL state
        ///
        /// </summary>
        SET_PAUSE_MENU_PED_SLEEP_STATE = 0xECF128344E9FF9F1,
        /// <summary>
        /// Returns the same as IS_SOCIAL_CLUB_ACTIVE
        ///
        ///
        /// </summary>
        IS_ONLINE_POLICIES_MENU_ACTIVE = 0x6F72CD94F7B5B68C,
        /// <summary>
        /// Uses the `SOCIAL_CLUB2` scaleform.
        ///
        ///
        /// </summary>
        OPEN_SOCIAL_CLUB_MENU = 0x75D3691713C3B05A,
        /// <summary>
        /// HUD::SET_SOCIAL_CLUB_TOUR("Gallery");
        /// HUD::SET_SOCIAL_CLUB_TOUR("Missions");
        /// HUD::SET_SOCIAL_CLUB_TOUR("General");
        /// HUD::SET_SOCIAL_CLUB_TOUR("Playlists");
        ///
        /// > const char* name
        ///
        /// </summary>
        SET_SOCIAL_CLUB_TOUR = 0x9E778248D6685FE0,
        /// <summary>
        /// Returns whether or not the text chat (MULTIPLAYER_CHAT Scaleform component) is active.
        ///
        ///
        /// </summary>
        _IS_MULTIPLAYER_CHAT_ACTIVE = 0xB118AF58B5F332A1,
        /// <summary>
        /// Sets an unknown boolean value in the text chat.
        ///
        /// > BOOL p0
        ///
        /// </summary>
        _SET_TEXT_CHAT_UNK = 0x1DB21A44B09E8BA3,
        /// <summary>
        /// This native turns on the AI blip on the specified ped. It also disappears automatically when the ped is too far or if the ped is dead. You don't need to control it with other natives.
        /// 
        /// See gtaforums.com/topic/884370-native-research-ai-blips for further information.
        ///
        /// > Ped ped
        /// > BOOL hasCone
        ///
        /// </summary>
        SET_PED_HAS_AI_BLIP = 0xD30C50DF888D58B5,
        /// <summary>
        /// color: see SET_BLIP_COLOUR
        ///
        /// > Ped ped
        /// > BOOL hasCone
        /// > int color
        ///
        /// </summary>
        _SET_PED_HAS_AI_BLIP_WITH_COLOR = 0xB13DCB4C6FAAD238,
        /// <summary>
        /// Returns the current AI BLIP for the specified ped
        ///
        /// > Ped ped
        ///
        /// </summary>
        _GET_AI_BLIP = 0x56176892826A4FE8,
        /// <summary>
        /// HAS_*
        ///
        ///
        /// </summary>
        _HAS_DIRECTOR_MODE_BEEN_TRIGGERED = 0xA277800A9EAE340E,
        /// <summary>
        /// SET_*
        ///
        ///
        /// </summary>
        _SET_DIRECTOR_MODE_CLEAR_TRIGGERED_FLAG = 0x2632482FD6B9AB87,
        /// <summary>
        /// If toggle is true, hides special ability bar / character name in the pause menu
        /// If toggle is false, shows special ability bar / character name in the pause menu
        /// 
        /// SET_PLAYER_*
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_PLAYER_IS_IN_DIRECTOR_MODE = 0x808519373FD336A3,
        /// <summary>
        /// DISABLE_*
        ///
        /// > BOOL p0
        ///
        /// </summary>
        _0x9245E81072704B8A = 0x9245E81072704B8A,
        /// <summary>
        /// GET_F*
        ///
        /// > const char* string
        /// > int length
        ///
        /// </summary>
        _0x98C3CF913D895111 = 0x98C3CF913D895111,
        /// <summary>
        /// Setter for 0xC2D2AD9EAAE265B8
        /// 
        /// SET_*
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _0xCD74233600C4EA6B = 0xCD74233600C4EA6B,
        /// <summary>
        /// Getter for 0xCD74233600C4EA6B
        /// 
        /// GET_*
        ///
        ///
        /// </summary>
        _0xC2D2AD9EAAE265B8 = 0xC2D2AD9EAAE265B8,
        /// <summary>
        /// SET_F*
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _0x2790F4B17D098E26 = 0x2790F4B17D098E26,
        /// <summary>
        /// FORCE_*
        ///
        /// > int p0
        ///
        /// </summary>
        _0x57D760D55F54E071 = 0x57D760D55F54E071,
        /// <summary>
        /// Does nothing (it's a nullsub).
        ///
        ///
        /// </summary>
        _0xD2049635DEB9C375 = 0xD2049635DEB9C375,
        /// <summary>
        /// FORCE_*
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _0xBA8D65C1C65702E5 = 0xBA8D65C1C65702E5,
        /// <summary>
        /// HAS_S*
        ///
        ///
        /// </summary>
        _0x214CD562A939246A = 0x214CD562A939246A,
        /// <summary>
        /// SET_C*
        ///
        /// > int p0
        /// > float p1
        ///
        /// </summary>
        _0x9FCB3CBFB3EAD69A = 0x9FCB3CBFB3EAD69A,
        /// <summary>
        /// SET_C*
        ///
        ///
        /// </summary>
        _0xB7B873520C84C118 = 0xB7B873520C84C118,
        /// <summary>
        /// GET_BLIP_*
        /// 
        /// Seems to always return 0 from what I can tell. I've tried a lot of different blip related natives and it always seems to return 0. Decompiled scripts always pass a blip handle as p0.
        ///
        /// > Blip blip
        ///
        /// </summary>
        _0x2C173AE2BDB9385E = 0x2C173AE2BDB9385E,
        /// <summary>
        /// Interesting fact: A hash collision for this is RESET_JETPACK_MODEL_SETTINGS
        ///
        /// > Ped ped
        ///
        /// </summary>
        _0xC594B315EDF2D4AF = 0xC594B315EDF2D4AF,
        /// <summary>
        /// Related to displaying cash on the HUD
        /// Always called before HUD::_SET_SINGLEPLAYER_HUD_CASH in decompiled scripts
        ///
        /// > BOOL p0
        ///
        /// </summary>
        _0x170F541E1CADD1DE = 0x170F541E1CADD1DE,
        /// <summary>
        /// IS_*
        ///
        ///
        /// </summary>
        _0x801879A9B4F4B2FB = 0x801879A9B4F4B2FB,
        /// <summary>
        /// HUD::_817B86108EB94E51(1, &g_189F36._f10CD1[0/*16*/], &g_189F36._f10CD1[1/*16*/], &g_189F36._f10CD1[2/*16*/], &g_189F36._f10CD1[3/*16*/], &g_189F36._f10CD1[4/*16*/], &g_189F36._f10CD1[5/*16*/], &g_189F36._f10CD1[6/*16*/], &g_189F36._f10CD1[7/*16*/]);
        ///
        /// > BOOL p0
        /// > Any* p1
        /// > Any* p2
        /// > Any* p3
        /// > Any* p4
        /// > Any* p5
        /// > Any* p6
        /// > Any* p7
        /// > Any* p8
        ///
        /// </summary>
        _0x817B86108EB94E51 = 0x817B86108EB94E51,
        /// <summary>
        /// This native does absolutely nothing, just a nullsub
        ///
        ///
        /// </summary>
        _0x211C4EF450086857 = 0x211C4EF450086857,
        /// <summary>
        /// Returns something related to the store.
        /// 
        /// IS_S*
        /// 
        /// IS_STORE_EXIT_PURCHASE_CAPABILITY_ACTIVATED ?
        ///
        ///
        /// </summary>
        _0x2F057596F2BD0061 = 0x2F057596F2BD0061,
        /// <summary>
        /// GET_PAUSE_MENU_*
        ///
        ///
        /// </summary>
        _0x5BFF36D6ED83E0AE = 0x5BFF36D6ED83E0AE,
        /// <summary>
        /// Returns true when the menu state(?) changed this frame.
        /// HAS_*? _GET_MENU_STATE_CHANGED_THIS_FRAME?
        ///
        ///
        /// </summary>
        _0x2E22FEFA0100275E = 0x2E22FEFA0100275E,
        /// <summary>
        /// SET_TEXT_??? - Used in golf and golf_mp
        ///
        /// > BOOL p0
        ///
        /// </summary>
        _0x1185A8087587322C = 0x1185A8087587322C,
        /// <summary>
        /// SET_*
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _0x04655F9D075D0AE5 = 0x04655F9D075D0AE5,
        PRELOAD_BUSYSPINNER = 0xC65AB383CD91DF98,
        BUSYSPINNER_IS_ON = 0xD422FCC5F239A915,
        BUSYSPINNER_IS_DISPLAYING = 0xB2A592B04648A9CB,
        THEFEED_ONLY_SHOW_TOOLTIPS = 0x6F1554B0CC2089FA,
        THEFEED_SET_SCRIPTED_MENU_HEIGHT = 0x55598D21339CB998,
        THEFEED_FLUSH_QUEUE = 0xA8FDB297A8D25FBA,
        THEFEED_FORCE_RENDER_ON = 0xA13C11E1B5C06BFC,
        THEFEED_PAUSE = 0xFDB423997FA30340,
        THEFEED_RESUME = 0xE1CD1E48E025E661,
        THEFEED_IS_PAUSED = 0xA9CBFD40B3FA3010,
        THEFEED_SPS_EXTEND_WIDESCREEN_ON = 0xD4438C0564490E63,
        THEFEED_SPS_EXTEND_WIDESCREEN_OFF = 0xB695E2CD0A2DA9EE,
        _THEFEED_SET_ANIMPOSTFX_COLOR = 0x17430B918701C342,
        _THEFEED_SET_ANIMPOSTFX_SOUND = 0x4A0C7C9BB10ABB36,
        THEFEED_RESET_ALL_PARAMETERS = 0xFDD85225B2DEA55E,
        THEFEED_CLEAR_FROZEN_POST = 0x80FE4F3AB4E1B62A,
        _THEFEED_SET_FLUSH_ANIMPOSTFX = 0xBAE4F9B97CD43B30,
        END_TEXT_COMMAND_THEFEED_POST_TICKER = 0x2ED7843F8F801023,
        END_TEXT_COMMAND_THEFEED_POST_TICKER_FORCED = 0x44FA03975424A0EE,
        END_TEXT_COMMAND_THEFEED_POST_TICKER_WITH_TOKENS = 0x378E809BF61EC840,
        END_TEXT_COMMAND_THEFEED_POST_CREWTAG = 0x97C9E4E7024A8F2C,
        END_TEXT_COMMAND_THEFEED_POST_CREWTAG_WITH_GAME_NAME = 0x137BC35589E34E1E,
        END_TEXT_COMMAND_THEFEED_POST_UNLOCK = 0x33EE12743CCD6343,
        END_TEXT_COMMAND_THEFEED_POST_UNLOCK_TU = 0xC8F3AAF93D0600BF,
        END_TEXT_COMMAND_THEFEED_POST_UNLOCK_TU_WITH_COLOR = 0x7AE0589093A2E088,
        END_TEXT_COMMAND_THEFEED_POST_MPTICKER = 0xF020C96915705B3A,
        END_TEXT_COMMAND_THEFEED_POST_CREW_RANKUP = 0x8EFCCF6EC66D85E4,
        END_TEXT_COMMAND_THEFEED_POST_VERSUS_TU = 0xB6871B0555B02996,
        END_TEXT_COMMAND_IS_MESSAGE_DISPLAYED = 0x8A9BA1AB3E237613,
        END_TEXT_COMMAND_IS_THIS_HELP_MESSAGE_BEING_DISPLAYED = 0x10BDDBFC529428DD,
        _BEGIN_TEXT_COMMAND_OBJECTIVE = 0x23D69E0465570028,
        _END_TEXT_COMMAND_OBJECTIVE = 0xCFDBDF5AE59BA0F4,
        END_TEXT_COMMAND_CLEAR_PRINT = 0xFCC75460ABA29378,
        BEGIN_TEXT_COMMAND_OVERRIDE_BUTTON_TEXT = 0x8F9EE5687F8EECCD,
        END_TEXT_COMMAND_OVERRIDE_BUTTON_TEXT = 0xA86911979638106F,
        ADD_TEXT_COMPONENT_INTEGER = 0x03B504CF259931BC,
        ADD_TEXT_COMPONENT_FLOAT = 0xE7DCB5B874BCD96E,
        ADD_TEXT_COMPONENT_SUBSTRING_TEXT_LABEL = 0xC63CD5D2920ACBE7,
        ADD_TEXT_COMPONENT_SUBSTRING_BLIP_NAME = 0x80EAD8E2E1D5D52E,
        ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME = 0x6C188BE134E074AA,
        ADD_TEXT_COMPONENT_FORMATTED_INTEGER = 0x0E4C749FF9DE9CC4,
        ADD_TEXT_COMPONENT_SUBSTRING_KEYBOARD_DISPLAY = 0x5F68520888E69014,
        SET_COLOUR_OF_NEXT_TEXT_COMPONENT = 0x39BBF623FC803EAC,
        CLEAR_PRINTS = 0xCC33FA791322B9D9,
        CLEAR_BRIEF = 0x9D292F73ADBD9313,
        CLEAR_ALL_HELP_MESSAGES = 0x6178F68A87A4D3A0,
        CLEAR_SMALL_PRINTS = 0x2CEA2839313C09AC,
        DOES_TEXT_BLOCK_EXIST = 0x1C7302E725259789,
        REQUEST_ADDITIONAL_TEXT_FOR_DLC = 0x6009F9F1AE90D8A6,
        HAS_ADDITIONAL_TEXT_LOADED = 0x02245FE4BED318B8,
        CLEAR_ADDITIONAL_TEXT = 0x2A179DF17CCF04CD,
        IS_STREAMING_ADDITIONAL_TEXT = 0x8B6817B71B85EBF0,
        IS_MESSAGE_BEING_DISPLAYED = 0x7984C03AA5CC2F41,
        GET_LENGTH_OF_LITERAL_STRING_IN_BYTES = 0x43E4111189E54F0E,
        IS_HUD_PREFERENCE_SWITCHED_ON = 0x1930DFA731813EC4,
        IS_RADAR_PREFERENCE_SWITCHED_ON = 0x9EB6522EA68F22FE,
        IS_SUBTITLE_PREFERENCE_SWITCHED_ON = 0xAD6DACA4BA53E0A4,
        DISPLAY_HUD_WHEN_PAUSED_THIS_FRAME = 0x402F9ED62087E898,
        IS_HUD_HIDDEN = 0xA86478C6958735C5,
        IS_RADAR_HIDDEN = 0x157F93B036700462,
        IS_MINIMAP_RENDERING = 0xAF754F20EB5CD51A,
        _CLEAR_ALL_BLIP_ROUTES = 0xD12882D3FF82BF11,
        SET_BLIP_ROUTE_COLOUR = 0x837155CD2F63DA09,
        ADD_NEXT_MESSAGE_TO_PREVIOUS_BRIEFS = 0x60296AF4BA14ABC5,
        SET_RADAR_ZOOM_PRECISE = 0xBD12C5EEE184C337,
        SET_RADAR_ZOOM_TO_BLIP = 0xF98E4B3E56AFC7B1,
        SET_RADAR_ZOOM_TO_DISTANCE = 0xCB7CC0D58405AD41,
        _SET_ABILITY_BAR_VISIBILITY_IN_MULTIPLAYER = 0x1DFEDD15019315A9,
        _SET_ALLOW_ABILITY_BAR_IN_MULTIPLAYER = 0x889329C80FE5963C,
        FLASH_ABILITY_BAR = 0x02CFBA0C9E9275CE,
        SET_ABILITY_BAR_VALUE = 0x9969599CCFF5D85E,
        FLASH_WANTED_DISPLAY = 0xA18AFB39081B6A1F,
        SET_TEXT_CENTRE = 0xC02F4DBFB51D988B,
        SET_TEXT_RIGHT_JUSTIFY = 0x6B3C4650BC8BEE47,
        SET_TEXT_LEADING = 0xA50ABC31E3CDFAFF,
        SET_TEXT_DROP_SHADOW = 0x1CA3E9EAC9D93E5E,
        SET_TEXT_OUTLINE = 0x2513DFB0FB8400FE,
        SET_TEXT_RENDER_ID = 0x5F15302936E07111,
        REGISTER_NAMED_RENDERTARGET = 0x57D9C12635E25CE3,
        IS_NAMED_RENDERTARGET_REGISTERED = 0x78DCDC15C9F116B4,
        RELEASE_NAMED_RENDERTARGET = 0xE9F6FFE837354DD4,
        LINK_NAMED_RENDERTARGET = 0xF6C09E276AEB3F2D,
        GET_NAMED_RENDERTARGET_RENDER_ID = 0x1A6478B61C6BDC3B,
        IS_NAMED_RENDERTARGET_LINKED = 0x113750538FA31298,
        CLEAR_HELP = 0x8DFCED7A656F8802,
        IS_HELP_MESSAGE_ON_SCREEN = 0xDAD37F45428801AE,
        IS_HELP_MESSAGE_BEING_DISPLAYED = 0x4D79439A6B55AC67,
        IS_HELP_MESSAGE_FADING_OUT = 0x327EDEEEAC55C369,
        _SET_HELP_MESSAGE_TEXT_STYLE = 0xB9C362BABECDDC7A,
        GET_WAYPOINT_BLIP_ENUM_ID = 0x186E5D252FA50E7D,
        GET_NUMBER_OF_ACTIVE_BLIPS = 0x9A3FF3DE163034E8,
        GET_NEXT_BLIP_INFO_ID = 0x14F96AA50D6FBEA7,
        GET_FIRST_BLIP_INFO_ID = 0x1BEDE233E6CD2A1F,
        _GET_CLOSEST_BLIP_OF_TYPE = 0xD484BF71050CA1EE,
        GET_BLIP_INFO_ID_COORD = 0xFA7C7F0AADF25D09,
        GET_BLIP_INFO_ID_DISPLAY = 0x1E314167F701DC3B,
        GET_BLIP_INFO_ID_ENTITY_INDEX = 0x4BA4E2553AFEDC2C,
        ADD_BLIP_FOR_RADIUS = 0x46818D79B1F7499A,
        ADD_BLIP_FOR_PICKUP = 0xBE339365C863BD36,
        TRIGGER_SONAR_BLIP = 0x72DD432F3CDFC0EE,
        ALLOW_SONAR_BLIPS = 0x60734CC207C9833C,
        SET_BLIP_COORDS = 0xAE2AF67E9D9AF65D,
        GET_BLIP_COORDS = 0x586AFE3FF72D996E,
        SET_BLIP_NAME_TO_PLAYER_NAME = 0x127DE7B20C60A6A3,
        GET_BLIP_ALPHA = 0x970F608F0EE6C885,
        SET_BLIP_FADE = 0x2AEE8F8390D2298C,
        _GET_BLIP_ROTATION = 0x003E92BA477F9D7F,
        SET_BLIP_FLASH_INTERVAL = 0xAA51DB313C010A7E,
        SET_BLIP_SECONDARY_COLOUR = 0x14892474891E09EB,
        GET_BLIP_COLOUR = 0xDF729E8D20CF7327,
        GET_BLIP_HUD_COLOUR = 0x729B5F1EFBC0AAEE,
        IS_BLIP_SHORT_RANGE = 0xDA5F8727EB75B926,
        IS_BLIP_ON_MINIMAP = 0xE41CA53051197A27,
        DOES_BLIP_HAVE_GPS_ROUTE = 0xDD2238F57B977751,
        SET_BLIP_HIDDEN_ON_LEGEND = 0x54318C915D27E4CE,
        SET_BLIP_HIGH_DETAIL = 0xE2590BC29220CEBB,
        SET_BLIP_AS_MISSION_CREATOR_BLIP = 0x24AC0137444F9FD5,
        IS_MISSION_CREATOR_BLIP = 0x26F49BF3381D933D,
        GET_NEW_SELECTED_MISSION_CREATOR_BLIP = 0x5C90988E7C8E1AF4,
        IS_HOVERING_OVER_MISSION_CREATOR_BLIP = 0x4167EFE0527D706E,
        SHOW_START_MISSION_INSTRUCTIONAL_BUTTON = 0xF1A6C18B35BCADE6,
        SET_BLIP_FLASHES = 0xB14552383D39CE3E,
        SET_BLIP_FLASHES_ALTERNATE = 0x2E8D9498C56DD0D1,
        IS_BLIP_FLASHING = 0xA5E41FD83AD6CEF0,
        SET_BLIP_SCALE = 0xD38744167B2FA257,
        PULSE_BLIP = 0x742D6FD43115AF73,
        SHOW_NUMBER_ON_BLIP = 0xA3C0B359DCB848B6,
        HIDE_NUMBER_ON_BLIP = 0x532CFF637EF80148,
        SHOW_HEIGHT_ON_BLIP = 0x75A16C3DA34F1245,
        DOES_BLIP_EXIST = 0xA6DB27D19ECBB7DA,
        _DELETE_WAYPOINT = 0xD8E694757BCEA8E9,
        REFRESH_WAYPOINT = 0x81FA173F170560D1,
        IS_WAYPOINT_ACTIVE = 0x1DD1F58F493F1DA5,
        SET_NEW_WAYPOINT = 0xFE43368D2AA4F2FC,
        SET_BLIP_BRIGHT = 0xB203913733F27884,
        SET_BLIP_SHOW_CONE = 0x13127EC3665E8EE1,
        _SET_MINIMAP_SONAR_ENABLED = 0x6B50FC8749632EC1,
        _SHOW_SIGNIN_UI = 0x60E892BA4F5BDCA4,
        GET_MAIN_PLAYER_BLIP_ID = 0xDCD4EC3F419D02FA,
        HIDE_LOADING_ON_FADE_THIS_FRAME = 0x4B0311D3CDC4648F,
        _SET_INTERIOR_ZOOM_LEVEL_INCREASED = 0x504DFE62A1692296,
        _SET_INTERIOR_ZOOM_LEVEL_DECREASED = 0x7EC8ABA5E74B3D7A,
        SET_RADAR_AS_EXTERIOR_THIS_FRAME = 0xE81B7D2A3DAB2D81,
        _IS_MINIMAP_IN_INTERIOR = 0x9049FE339D5F6F6F,
        HIDE_MINIMAP_EXTERIOR_MAP_THIS_FRAME = 0x5FBAE526203990C9,
        HIDE_MINIMAP_INTERIOR_MAP_THIS_FRAME = 0x20FE7FDFEEAD38C0,
        SET_WIDESCREEN_FORMAT = 0xC3B07BA00A83B0F1,
        DISPLAY_AREA_NAME = 0x276B6CE369C33678,
        DISPLAY_AMMO_THIS_FRAME = 0xA5E78BA2B1331C55,
        SET_MULTIPLAYER_WALLET_CASH = 0xC2D15BEF167E27BC,
        REMOVE_MULTIPLAYER_WALLET_CASH = 0x95CF81BD06EE1887,
        SET_MULTIPLAYER_BANK_CASH = 0xDD21B55DF695CD0A,
        REMOVE_MULTIPLAYER_BANK_CASH = 0xC7C6789AA1CFEDD0,
        HIDE_HELP_TEXT_THIS_FRAME = 0xD46923FC481CA285,
        SET_RACE_TRACK_RENDER = 0x1EAC5F91BCBC5073,
        ADD_POINT_TO_GPS_CUSTOM_ROUTE = 0x311438A071DD9B1A,
        CLEAR_GPS_CUSTOM_ROUTE = 0xE6DE0561D9232A64,
        ADD_POINT_TO_GPS_MULTI_ROUTE = 0xA905192A6781C41B,
        SET_GPS_MULTI_ROUTE_RENDER = 0x3DDA37128DD1ACA8,
        CLEAR_GPS_PLAYER_WAYPOINT = 0xFF4FB7C8CDFA3DA7,
        SET_GPS_FLASHES = 0x320D0E0D936A0E9B,
        _SET_MAIN_PLAYER_BLIP_COLOUR = 0x7B21E0BB01E8224A,
        FLASH_MINIMAP_DISPLAY_WITH_COLOR = 0x6B1DE27EE78E6A19,
        TOGGLE_STEALTH_RADAR = 0x6AFDFB93754950C7,
        SET_MINIMAP_IN_SPECTATOR_MODE = 0x1A5CD7752DD28CD3,
        SET_MISSION_NAME = 0x5F28ECF5FC84772F,
        _SET_MISSION_NAME_2 = 0xE45087D85F468BC2,
        SET_MINIMAP_BLOCK_WAYPOINT = 0x58FADDED207897DC,
        GET_MINIMAP_FOW_DISCOVERY_RATIO = 0xE0130B41D3CF4574,
        GET_MINIMAP_FOW_COORDINATE_IS_REVEALED = 0x6E31B91145873922,
        SET_MINIMAP_FOW_REVEAL_COORDINATE = 0x0923DBF87DFF735E,
        SET_MINIMAP_GOLF_COURSE_OFF = 0x35EDD5B2E3FF01C0,
        UNLOCK_MINIMAP_ANGLE = 0x8183455E16C42E3A,
        UNLOCK_MINIMAP_POSITION = 0x3E93E06DB8EF1F30,
        SET_HEALTH_HUD_DISPLAY_VALUES = 0x3F5CC444DCAAA8F2,
        SET_MAX_HEALTH_HUD_DISPLAY = 0x975D66A0BC17064C,
        SET_MAX_ARMOUR_HUD_DISPLAY = 0x06A320535F5F0248,
        IS_SCRIPTED_HUD_COMPONENT_ACTIVE = 0xDD100EB17A94FF65,
        HIDE_SCRIPTED_HUD_COMPONENT_THIS_FRAME = 0xE374C498D8BADC14,
        IS_SCRIPTED_HUD_COMPONENT_HIDDEN_THIS_FRAME = 0x09C0403ED9A751C2,
        RESET_RETICULE_VALUES = 0x12782CE0A636E9F0,
        RESET_HUD_COMPONENT_VALUES = 0x450930E616475D0D,
        SET_HUD_COMPONENT_POSITION = 0xAABB1F56E2A17CED,
        GET_HUD_COMPONENT_POSITION = 0x223CA69A8C4417FD,
        FORCE_CLOSE_REPORTUGC_MENU = 0xEE4C0E6DBC6F2C6F,
        IS_REPORTUGC_MENU_OPEN = 0x9135584D09A3437E,
        IS_FLOATING_HELP_TEXT_ON_SCREEN = 0x2432784ACA090DA4,
        SET_FLOATING_HELP_TEXT_SCREEN_POSITION = 0x7679CC1BCEBE3D4C,
        SET_FLOATING_HELP_TEXT_WORLD_POSITION = 0x784BA7E0ECEB4178,
        SET_FLOATING_HELP_TEXT_TO_ENTITY = 0xB094BC1DB4018240,
        SET_FLOATING_HELP_TEXT_STYLE = 0x788E7FD431BD67F1,
        CLEAR_FLOATING_HELP = 0x50085246ABD3FEFA,
        IS_MP_GAMER_TAG_MOVIE_ACTIVE = 0x6E0EB3EB47C8D7AA,
        REMOVE_MP_GAMER_TAG = 0x31698AA80E0223F8,
        IS_MP_GAMER_TAG_ACTIVE = 0x4E929E7A5796FD26,
        IS_MP_GAMER_TAG_FREE = 0x595B5178E412E199,
        _SET_MP_GAMER_TAG_ENABLED = 0xEE76FF7E6A0166B0,
        _SET_MP_GAMER_HEALTH_BAR_DISPLAY = 0xD29EC58C2F6B5014,
        _SET_MP_GAMER_HEALTH_BAR_MAX = 0x1563FE35E9928E67,
        _SET_MP_GAMER_TAG_UNK = 0x9C16459B2324B2CF,
        SET_MP_GAMER_TAG_NAME = 0xDEA2B8283BAA3944,
        SET_MP_GAMER_TAG_BIG_TEXT = 0x7B7723747CCB55B6,
        GET_CURRENT_WEBPAGE_ID = 0x01A358D9128B7A86,
        GET_CURRENT_WEBSITE_ID = 0x97D47996FC48CBAD,
        RESET_GLOBAL_ACTIONSCRIPT_FLAG = 0xB99C4E4D9499DF29,
        _SET_WARNING_MESSAGE_WITH_HEADER_UNK = 0x38B55259C2E078ED,
        _REMOVE_WARNING_MESSAGE_LIST_ITEMS = 0x6EF54AB721DC6242,
        IS_WARNING_MESSAGE_ACTIVE = 0xE18B138FABC53103,
        CLEAR_DYNAMIC_PAUSE_MENU_ERROR_MESSAGE = 0x7792424AA0EAC32E,
        _CLEAR_RACE_GALLERY_BLIPS = 0x2708FC083123F9FF,
        _GET_NORTH_RADAR_BLIP = 0x3F0CF9CB7E589B88,
        SET_PAUSE_MENU_ACTIVE = 0xDF47FC56C71569CF,
        DISABLE_FRONTEND_THIS_FRAME = 0x6D3465A73092F0E6,
        SUPPRESS_FRONTEND_RENDERING_THIS_FRAME = 0xBA751764F0821256,
        SET_FRONTEND_ACTIVE = 0x745711A75AB09277,
        IS_PAUSE_MENU_ACTIVE = 0xB0034A223497FFCB,
        IS_PAUSE_MENU_RESTARTING = 0x1C491717107431C7,
        PAUSE_MENU_DEACTIVATE_CONTEXT = 0x444D8CF241EC25C5,
        PAUSE_MENU_IS_CONTEXT_ACTIVE = 0x84698AB38D0C6636,
        PAUSE_MENU_IS_CONTEXT_MENU_ACTIVE = 0x2A25ADC48F87841F,
        PAUSE_MENU_SET_BUSY_SPINNER = 0xC78E239AC5B2DDB9,
        IS_FRONTEND_READY_FOR_CONTROL = 0x3BAB9A4E4F2FF5C7,
        IS_NAVIGATING_MENU_CONTENT = 0x4E3CD0EF8A489541,
        _GET_PAUSE_MENU_SELECTION = 0x36C1451A88A09630,
        GET_MENU_PED_INT_STAT = 0xEF4CED81CEBEDC6D,
        GET_MENU_PED_MASKED_INT_STAT = 0x90A6526CF0381030,
        GET_MENU_PED_FLOAT_STAT = 0x5FBD7095FE7AE57F,
        CLEAR_PED_IN_PAUSE_MENU = 0x5E62BE5DC58E9E06,
        OPEN_ONLINE_POLICIES_MENU = 0x805D7CBB36FD6C4C,
        CLOSE_SOCIAL_CLUB_MENU = 0xD2B32BE3FC1626C6,
        IS_SOCIAL_CLUB_ACTIVE = 0xC406BE343FC4B9AF,
        _FORCE_CLOSE_TEXT_INPUT_BOX = 0x8817605C2BA76200,
        _OVERRIDE_MULTIPLAYER_CHAT_PREFIX = 0x6A1738B4323FE2D9,
        _CLOSE_MULTIPLAYER_CHAT = 0x1AC8F4AD40E22127,
        _OVERRIDE_MULTIPLAYER_CHAT_COLOUR = 0xF47E567B3630DD12,
        FLAG_PLAYER_CONTEXT_IN_TOURNAMENT = 0xCEF214315D276FD1,
        DOES_PED_HAVE_AI_BLIP = 0x15B8ECF844EE67ED,
        SET_PED_AI_BLIP_GANG_ID = 0xE52B8E7F85D39A08,
        SET_PED_AI_BLIP_HAS_CONE = 0x3EED80DFF7325CAA,
        SET_PED_AI_BLIP_FORCED_ON = 0x0C4BBF625CA98C4E,
        SET_PED_AI_BLIP_NOTICE_RANGE = 0x97C65887D4B37FA9,
        _SET_PED_AI_BLIP_SPRITE = 0xFCFACD0DB9D7A57D,
        _GET_AI_BLIP_2 = 0x7CD934010E115C2C,
        _0x3D9ACB1EB139E702 = 0x3D9ACB1EB139E702,
        _0x632B2940C67F4EA9 = 0x632B2940C67F4EA9,
        _0x0C698D8F099174C7 = 0x0C698D8F099174C7,
        _0xE4C3B169876D33D7 = 0xE4C3B169876D33D7,
        _0xEB81A3DADD503187 = 0xEB81A3DADD503187,
        _0x6CDD58146A436083 = 0x6CDD58146A436083,
        _0xD1942374085C8469 = 0xD1942374085C8469,
        _0x2916A928514C9827 = 0x2916A928514C9827,
        _0xB552929B85FC27EC = 0xB552929B85FC27EC,
        _0x4B5B620C9B59ED34 = 0x4B5B620C9B59ED34,
        _0x2C9F302398E13141 = 0x2C9F302398E13141,
        _0xF83D0FEBE75E62C9 = 0xF83D0FEBE75E62C9,
        _0x35A3CD97B2C0A6D2 = 0x35A3CD97B2C0A6D2,
        _0x8410C5E0CD847B9D = 0x8410C5E0CD847B9D,
        _0x41350B4FC28E3941 = 0x41350B4FC28E3941,
        _0xA17784FCA9548D15 = 0xA17784FCA9548D15,
        _0x55F5A5F07134DE60 = 0x55F5A5F07134DE60,
        _0xE67C6DFD386EA5E7 = 0xE67C6DFD386EA5E7,
        _0x62E849B7EB28E770 = 0x62E849B7EB28E770,
        _0xDAF87174BE7454FF = 0xDAF87174BE7454FF,
        _0xBF4F34A85CA2970C = 0xBF4F34A85CA2970C,
        _0x77F16B447824DA6C = 0x77F16B447824DA6C,
        _0xCDCA26E80FAECB8F = 0xCDCA26E80FAECB8F,
        _0x2DE6C5E2E996F178 = 0x2DE6C5E2E996F178,
        _0xDE03620F8703A9DF = 0xDE03620F8703A9DF,
        _0x359AF31A4B52F5ED = 0x359AF31A4B52F5ED,
        _0x13C4B962653A5280 = 0x13C4B962653A5280,
        _0xC8E1071177A23BE5 = 0xC8E1071177A23BE5,
        _0x4895BDEA16E7C080 = 0x4895BDEA16E7C080,
        _0xF06EBB91A81E09E3 = 0xF06EBB91A81E09E3,
        _0x66E7CB63C97B7D20 = 0x66E7CB63C97B7D20,
        _0x593FEAE1F73392D4 = 0x593FEAE1F73392D4,
        _0xF284AC67940C6812 = 0xF284AC67940C6812,
        _0x0CF54F20DE43879C = 0x0CF54F20DE43879C,
        _0xA238192F33110615 = 0xA238192F33110615,
        _0xCA6B2F7CE32AB653 = 0xCA6B2F7CE32AB653,
        _0x24A49BEAF468DC90 = 0x24A49BEAF468DC90,
        _0x8F08017F9D7C47BD = 0x8F08017F9D7C47BD,
        _0xF13FE2A80C05C561 = 0xF13FE2A80C05C561,
        _0x577599CCED639CA2 = 0x577599CCED639CA2,
        _0x7C226D5346D4D10A = 0x7C226D5346D4D10A,
        _0x243296A510B562B6 = 0x243296A510B562B6,
    }
}