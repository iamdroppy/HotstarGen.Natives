using System;
namespace Hotstar
{
    public enum CAM : ulong
    { 
        /// <summary>
        /// ease - smooth transition between the camera's positions
        /// easeTime - Time in milliseconds for the transition to happen
        /// 
        /// If you have created a script (rendering) camera, and want to go back to the 
        /// character (gameplay) camera, call this native with render set to 0.
        /// Setting ease to 1 will smooth the transition.
        ///
        /// > BOOL render
        /// > BOOL ease
        /// > int easeTime
        /// > BOOL p3
        /// > BOOL p4
        /// > Any p5
        ///
        /// </summary>
        RENDER_SCRIPT_CAMS = 0x07E5B515DB0636FC,
        /// <summary>
        /// This native makes the gameplay camera zoom into first person/third person with a special effect.
        ///
        /// > BOOL render
        /// > float p1
        /// > int p2
        /// > Any p3
        ///
        /// </summary>
        STOP_RENDERING_SCRIPT_CAMS_USING_CATCH_UP = 0xC819F3CBB62BF692,
        /// <summary>
        /// "DEFAULT_SCRIPTED_CAMERA"
        /// "DEFAULT_ANIMATED_CAMERA"
        /// "DEFAULT_SPLINE_CAMERA"
        /// "DEFAULT_SCRIPTED_FLY_CAMERA"
        /// "TIMED_SPLINE_CAMERA"
        ///
        /// > const char* camName
        /// > BOOL p1
        ///
        /// </summary>
        CREATE_CAM = 0xC3981DCE61D9E13F,
        /// <summary>
        /// camName is always set to "DEFAULT_SCRIPTED_CAMERA" in Rockstar's scripts.
        /// ------------
        /// Camera names found in the b617d scripts:
        /// "DEFAULT_ANIMATED_CAMERA"
        /// "DEFAULT_SCRIPTED_CAMERA"
        /// "DEFAULT_SCRIPTED_FLY_CAMERA"
        /// "DEFAULT_SPLINE_CAMERA"
        /// ------------
        /// Side Note: It seems p8 is basically to represent what would be the bool p1 within CREATE_CAM native. As well as the p9 since it's always 2 in scripts seems to represent what would be the last param within SET_CAM_ROT native which normally would be 2.
        ///
        /// > const char* camName
        /// > float posX
        /// > float posY
        /// > float posZ
        /// > float rotX
        /// > float rotY
        /// > float rotZ
        /// > float fov
        /// > BOOL p8
        /// > int p9
        ///
        /// </summary>
        CREATE_CAM_WITH_PARAMS = 0xB51194800B257161,
        /// <summary>
        /// CAM::_GET_GAMEPLAY_CAM_COORDS can be used instead of posX,Y,Z
        /// CAM::_GET_GAMEPLAY_CAM_ROT can be used instead of rotX,Y,Z
        /// CAM::_80EC114669DAEFF4() can be used instead of p7 (Possible p7 is FOV parameter. )
        /// p8 ???
        /// p9 uses 2 by default
        /// 
        ///
        /// > Hash camHash
        /// > float posX
        /// > float posY
        /// > float posZ
        /// > float rotX
        /// > float rotY
        /// > float rotZ
        /// > float fov
        /// > BOOL p8
        /// > Any p9
        ///
        /// </summary>
        CREATE_CAMERA_WITH_PARAMS = 0x6ABFA3E16460F22D,
        /// <summary>
        /// BOOL param indicates whether the cam should be destroyed if it belongs to the calling script.
        ///
        /// > Cam cam
        /// > BOOL bScriptHostCam
        ///
        /// </summary>
        DESTROY_CAM = 0x865908C81A2C22E9,
        /// <summary>
        /// BOOL param indicates whether the cam should be destroyed if it belongs to the calling script.
        ///
        /// > BOOL bScriptHostCam
        ///
        /// </summary>
        DESTROY_ALL_CAMS = 0x8E5FB15663F79120,
        /// <summary>
        /// Returns whether or not the passed camera handle exists.
        ///
        /// > Cam cam
        ///
        /// </summary>
        DOES_CAM_EXIST = 0xA7A932170592B50E,
        /// <summary>
        /// Set camera as active/inactive.
        ///
        /// > Cam cam
        /// > BOOL active
        ///
        /// </summary>
        SET_CAM_ACTIVE = 0x026FB97D0A425F84,
        /// <summary>
        /// Returns whether or not the passed camera handle is active.
        ///
        /// > Cam cam
        ///
        /// </summary>
        IS_CAM_ACTIVE = 0xDFB2B516207D3534,
        /// <summary>
        /// The last parameter, as in other "ROT" methods, is usually 2.
        ///
        /// > Cam cam
        /// > int rotationOrder
        ///
        /// </summary>
        GET_CAM_ROT = 0x7D304C1C955E3E12,
        /// <summary>
        /// Sets the position of the cam.
        ///
        /// > Cam cam
        /// > float posX
        /// > float posY
        /// > float posZ
        ///
        /// </summary>
        SET_CAM_COORD = 0x4D41783FB745E42E,
        /// <summary>
        /// Sets the rotation of the cam.
        /// Last parameter unknown.
        /// 
        /// Last parameter seems to always be set to 2.
        ///
        /// > Cam cam
        /// > float rotX
        /// > float rotY
        /// > float rotZ
        /// > int rotationOrder
        ///
        /// </summary>
        SET_CAM_ROT = 0x85973643155D0B07,
        /// <summary>
        /// Sets the field of view of the cam.
        /// ---------------------------------------------
        /// Min: 1.0f
        /// Max: 130.0f
        ///
        /// > Cam cam
        /// > float fieldOfView
        ///
        /// </summary>
        SET_CAM_FOV = 0xB13C14F66A00D047,
        /// <summary>
        /// This native has its name defined inside its codE
        /// 
        ///
        /// > Cam camera
        /// > float p1
        ///
        /// </summary>
        _SET_CAM_DOF_FNUMBER_OF_LENS = 0x7DD234D6F3914C5B,
        /// <summary>
        /// Native name labeled within its code
        ///
        /// > Cam camera
        /// > float multiplier
        ///
        /// </summary>
        _SET_CAM_DOF_FOCAL_LENGTH_MULTIPLIER = 0x47B595D60664CFFA,
        /// <summary>
        /// This native has a name defined inside its code
        ///
        /// > Cam camera
        /// > float p1
        ///
        /// </summary>
        _SET_CAM_DOF_FOCUS_DISTANCE_BIAS = 0xC669EEA5D031B7DE,
        /// <summary>
        /// This native has a name defined inside its code
        ///
        /// > Cam camera
        /// > float p1
        ///
        /// </summary>
        _SET_CAM_DOF_MAX_NEAR_IN_FOCUS_DISTANCE = 0xC3654A441402562D,
        /// <summary>
        /// This native has a name defined inside its code
        ///
        /// > Cam camera
        /// > float p1
        ///
        /// </summary>
        _SET_CAM_DOF_MAX_NEAR_IN_FOCUS_DISTANCE_BLEND_LEVEL = 0x2C654B4943BDDF7C,
        /// <summary>
        /// Last param determines if its relative to the Entity
        ///
        /// > Cam cam
        /// > Entity entity
        /// > float xOffset
        /// > float yOffset
        /// > float zOffset
        /// > BOOL isRelative
        ///
        /// </summary>
        ATTACH_CAM_TO_ENTITY = 0xFEDB7D269E8C60E3,
        /// <summary>
        /// This native works with vehicles only. Bone indexes are usually given by this native GET_ENTITY_BONE_INDEX_BY_NAME.
        ///
        /// > Cam cam
        /// > Vehicle vehicle
        /// > int boneIndex
        /// > BOOL relativeRotation
        /// > float rotX
        /// > float rotY
        /// > float rotZ
        /// > float offsetX
        /// > float offsetY
        /// > float offsetZ
        /// > BOOL fixedDirection
        ///
        /// </summary>
        _ATTACH_CAM_TO_VEHICLE_BONE = 0x8DB3F12A02CAEF72,
        /// <summary>
        /// The native seems to only be called once.
        /// 
        /// The native is used as so,
        /// CAM::SET_CAM_INHERIT_ROLL_VEHICLE(l_544, getElem(2, &l_525, 4));
        /// In the exile1 script.
        ///
        /// > Cam cam
        /// > BOOL p1
        ///
        /// </summary>
        SET_CAM_INHERIT_ROLL_VEHICLE = 0x45F1DE9C34B93AE6,
        /// <summary>
        /// p5 always seems to be 1 i.e TRUE
        ///
        /// > Cam cam
        /// > Entity entity
        /// > float p2
        /// > float p3
        /// > float p4
        /// > BOOL p5
        ///
        /// </summary>
        POINT_CAM_AT_ENTITY = 0x5640BFF86B16E8DC,
        /// <summary>
        /// Parameters p0-p5 seems correct. The bool p6 is unknown, but through every X360 script it's always 1. Please correct p0-p5 if any prove to be wrong. 
        ///
        /// > Cam cam
        /// > Ped ped
        /// > int boneIndex
        /// > float x
        /// > float y
        /// > float z
        /// > BOOL p6
        ///
        /// </summary>
        POINT_CAM_AT_PED_BONE = 0x68B2B5F33BA63C41,
        /// <summary>
        /// Allows you to aim and shoot at the direction the camera is facing.
        ///
        /// > Cam cam
        /// > BOOL toggle
        ///
        /// </summary>
        SET_CAM_AFFECTS_AIMING = 0x8C1DC7770C51DC8D,
        /// <summary>
        /// NOTE: Debugging functions are not present in the retail version of the game.
        ///
        /// > Cam camera
        /// > const char* name
        ///
        /// </summary>
        SET_CAM_DEBUG_NAME = 0x1B93E0107865DD40,
        /// <summary>
        /// I filled p1-p6 (the floats) as they are as other natives with 6 floats in a row are similar and I see no other method. So if a test from anyone proves them wrong please correct.
        /// 
        /// p7 (length) determines the length of the spline, affects camera path and duration of transition between previous node and this one
        /// 
        /// p8 big values ~100 will slow down the camera movement before reaching this node
        /// 
        /// p9 != 0 seems to override the rotation/pitch (bool?)
        ///
        /// > Cam camera
        /// > float x
        /// > float y
        /// > float z
        /// > float xRot
        /// > float yRot
        /// > float zRot
        /// > int length
        /// > int p8
        /// > int p9
        ///
        /// </summary>
        ADD_CAM_SPLINE_NODE = 0x8609C75EC438FB3B,
        /// <summary>
        /// Can use this with SET_CAM_SPLINE_PHASE to set the float it this native returns.
        /// 
        /// (returns 1.0f when no nodes has been added, reached end of non existing spline)
        ///
        /// > Cam cam
        ///
        /// </summary>
        GET_CAM_SPLINE_PHASE = 0xB5349E36C546509A,
        /// <summary>
        /// I'm pretty sure the parameter is the camera as usual, but I am not certain so I'm going to leave it as is.
        ///
        /// > Cam cam
        ///
        /// </summary>
        GET_CAM_SPLINE_NODE_PHASE = 0xD9D0E694C8282C96,
        /// <summary>
        /// I named p1 as timeDuration as it is obvious. I'm assuming tho it is ran in ms(Milliseconds) as usual.
        ///
        /// > Cam cam
        /// > int timeDuration
        ///
        /// </summary>
        SET_CAM_SPLINE_DURATION = 0x1381539FEE034CDA,
        /// <summary>
        /// Max value for p1 is 15.
        ///
        /// > Cam cam
        /// > int p1
        /// > float p2
        /// > float p3
        ///
        /// </summary>
        OVERRIDE_CAM_SPLINE_MOTION_BLUR = 0x7DCF7C708D292D55,
        /// <summary>
        /// Previous declaration void SET_CAM_ACTIVE_WITH_INTERP(Cam camTo, Cam camFrom, int duration, BOOL easeLocation, BOOL easeRotation) is completely wrong. The last two params are integers not BOOLs...
        /// 
        ///
        /// > Cam camTo
        /// > Cam camFrom
        /// > int duration
        /// > int easeLocation
        /// > int easeRotation
        ///
        /// </summary>
        SET_CAM_ACTIVE_WITH_INTERP = 0x9FBDA379383A52A4,
        /// <summary>
        /// Possible shake types (updated b617d):
        /// 
        /// DEATH_FAIL_IN_EFFECT_SHAKE
        /// DRUNK_SHAKE
        /// FAMILY5_DRUG_TRIP_SHAKE
        /// HAND_SHAKE
        /// JOLT_SHAKE
        /// LARGE_EXPLOSION_SHAKE
        /// MEDIUM_EXPLOSION_SHAKE
        /// SMALL_EXPLOSION_SHAKE
        /// ROAD_VIBRATION_SHAKE
        /// SKY_DIVING_SHAKE
        /// VIBRATE_SHAKE
        /// 
        /// Full list of cam shake types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/camShakeTypesCompact.json
        ///
        /// > Cam cam
        /// > const char* type
        /// > float amplitude
        ///
        /// </summary>
        SHAKE_CAM = 0x6A25241C340D3822,
        /// <summary>
        /// Example from michael2 script.
        /// 
        /// CAM::ANIMATED_SHAKE_CAM(l_5069, "shake_cam_all@", "light", "", 1f);
        ///
        /// > Cam cam
        /// > const char* p1
        /// > const char* p2
        /// > const char* p3
        /// > float amplitude
        ///
        /// </summary>
        ANIMATED_SHAKE_CAM = 0xA2746EEAE3E577CD,
        /// <summary>
        /// CAM::SHAKE_SCRIPT_GLOBAL("HAND_SHAKE", 0.2);
        /// 
        /// Full list of cam shake types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/camShakeTypesCompact.json
        ///
        /// > const char* p0
        /// > float p1
        ///
        /// </summary>
        SHAKE_SCRIPT_GLOBAL = 0xF4C8CF9E353AFECA,
        /// <summary>
        /// CAM::ANIMATED_SHAKE_SCRIPT_GLOBAL("SHAKE_CAM_medium", "medium", "", 0.5f);
        /// 
        /// Full list of cam shake types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/camShakeTypesCompact.json
        ///
        /// > const char* p0
        /// > const char* p1
        /// > const char* p2
        /// > float p3
        ///
        /// </summary>
        ANIMATED_SHAKE_SCRIPT_GLOBAL = 0xC2EAE3FB8CDBED31,
        /// <summary>
        /// In drunk_controller.c4, sub_309
        /// if (CAM::IS_SCRIPT_GLOBAL_SHAKING()) {
        ///     CAM::STOP_SCRIPT_GLOBAL_SHAKING(0);
        /// }
        ///
        ///
        /// </summary>
        IS_SCRIPT_GLOBAL_SHAKING = 0xC912AF078AF19212,
        /// <summary>
        /// In drunk_controller.c4, sub_309
        /// if (CAM::IS_SCRIPT_GLOBAL_SHAKING()) {
        ///     CAM::STOP_SCRIPT_GLOBAL_SHAKING(0);
        /// }
        ///
        /// > BOOL p0
        ///
        /// </summary>
        STOP_SCRIPT_GLOBAL_SHAKING = 0x1C9D7949FA533490,
        /// <summary>
        /// Atleast one time in a script for the zRot Rockstar uses GET_ENTITY_HEADING to help fill the parameter.
        /// 
        /// p9 is unknown at this time.
        /// p10 throughout all the X360 Scripts is always 2.
        /// 
        /// Full list of animation dictionaries and anims by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animDictsCompact.json
        ///
        /// > Cam cam
        /// > const char* animName
        /// > const char* animDictionary
        /// > float x
        /// > float y
        /// > float z
        /// > float xRot
        /// > float yRot
        /// > float zRot
        /// > BOOL p9
        /// > int p10
        ///
        /// </summary>
        PLAY_CAM_ANIM = 0x9A2D0FB2E7852392,
        /// <summary>
        /// Examples:
        /// 
        /// CAM::PLAY_SYNCHRONIZED_CAM_ANIM(l_2734, NETWORK::_02C40BF885C567B6(l_2739), "PLAYER_EXIT_L_CAM", "mp_doorbell");
        /// 
        /// CAM::PLAY_SYNCHRONIZED_CAM_ANIM(l_F0D[7/*1*/], l_F4D[15/*1*/], "ah3b_attackheli_cam2", "missheistfbi3b_helicrash");
        ///
        /// > Any p0
        /// > Any p1
        /// > const char* animName
        /// > const char* animDictionary
        ///
        /// </summary>
        PLAY_SYNCHRONIZED_CAM_ANIM = 0xE32EFE9AB4A9AA0C,
        /// <summary>
        /// Fades the screen in.
        /// 
        /// duration: The time the fade should take, in milliseconds.
        ///
        /// > int duration
        ///
        /// </summary>
        DO_SCREEN_FADE_IN = 0xD4E8E24955024033,
        /// <summary>
        /// Fades the screen out.
        /// 
        /// duration: The time the fade should take, in milliseconds.
        ///
        /// > int duration
        ///
        /// </summary>
        DO_SCREEN_FADE_OUT = 0x891B5B39AC6302AF,
        /// <summary>
        /// p0 dosen't seem to change much, I tried it with 0, 1, 2:
        /// 0-Pitch(X): -70.000092
        /// 0-Roll(Y): -0.000001
        /// 0-Yaw(Z): -43.886459
        /// 1-Pitch(X): -70.000092
        /// 1-Roll(Y): -0.000001
        /// 1-Yaw(Z): -43.886463
        /// 2-Pitch(X): -70.000092
        /// 2-Roll(Y): -0.000002
        /// 2-Yaw(Z): -43.886467
        ///
        /// > int rotationOrder
        ///
        /// </summary>
        GET_GAMEPLAY_CAM_ROT = 0x837765A25378F0BB,
        /// <summary>
        /// Sets the camera position relative to heading in float from -360 to +360.
        /// 
        /// Heading is alwyas 0 in aiming camera.
        ///
        /// > float heading
        ///
        /// </summary>
        SET_GAMEPLAY_CAM_RELATIVE_HEADING = 0xB4EC2312F4E5B1F1,
        /// <summary>
        /// This native sets the camera's pitch (rotation on the x-axis).
        ///
        /// > float angle
        /// > float scalingFactor
        ///
        /// </summary>
        SET_GAMEPLAY_CAM_RELATIVE_PITCH = 0x6D0858B8EDFD2B7D,
        /// <summary>
        /// Does nothing
        ///
        /// > float yaw
        ///
        /// </summary>
        _SET_GAMEPLAY_CAM_RAW_YAW = 0x103991D4A307D472,
        /// <summary>
        /// Possible shake types (updated b617d):
        /// 
        /// DEATH_FAIL_IN_EFFECT_SHAKE
        /// DRUNK_SHAKE
        /// FAMILY5_DRUG_TRIP_SHAKE
        /// HAND_SHAKE
        /// JOLT_SHAKE
        /// LARGE_EXPLOSION_SHAKE
        /// MEDIUM_EXPLOSION_SHAKE
        /// SMALL_EXPLOSION_SHAKE
        /// ROAD_VIBRATION_SHAKE
        /// SKY_DIVING_SHAKE
        /// VIBRATE_SHAKE
        /// 
        /// Full list of cam shake types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/camShakeTypesCompact.json
        ///
        /// > const char* shakeName
        /// > float intensity
        ///
        /// </summary>
        SHAKE_GAMEPLAY_CAM = 0xFD55E49555E017CF,
        /// <summary>
        /// Sets the amplitude for the gameplay (i.e. 3rd or 1st) camera to shake. Used in script "drunk_controller.ysc.c4" to simulate making the player drunk.
        ///
        /// > float amplitude
        ///
        /// </summary>
        SET_GAMEPLAY_CAM_SHAKE_AMPLITUDE = 0xA87E00932DB4D85D,
        /// <summary>
        /// Examples when this function will return 0 are:
        /// - During busted screen.
        /// - When player is coming out from a hospital.
        /// - When player is coming out from a police station.
        /// - When player is buying gun from AmmuNation.
        ///
        ///
        /// </summary>
        IS_GAMEPLAY_CAM_RENDERING = 0x39B5D1B10383F0C8,
        /// <summary>
        /// Shows the crosshair even if it wouldn't show normally. Only works for one frame, so make sure to call it repeatedly.
        /// 
        /// DISABLE_*
        ///
        ///
        /// </summary>
        _ENABLE_CROSSHAIR_THIS_FRAME = 0xEA7F0AD7E9BA676F,
        /// <summary>
        /// From the scripts:
        /// 
        /// CAM::SET_FOLLOW_PED_CAM_THIS_UPDATE("FOLLOW_PED_ATTACHED_TO_ROPE_CAMERA", 0);
        /// CAM::SET_FOLLOW_PED_CAM_THIS_UPDATE("FOLLOW_PED_ON_EXILE1_LADDER_CAMERA", 1500);
        /// CAM::SET_FOLLOW_PED_CAM_THIS_UPDATE("FOLLOW_PED_SKY_DIVING_CAMERA", 0);
        /// CAM::SET_FOLLOW_PED_CAM_THIS_UPDATE("FOLLOW_PED_SKY_DIVING_CAMERA", 3000);
        /// CAM::SET_FOLLOW_PED_CAM_THIS_UPDATE("FOLLOW_PED_SKY_DIVING_FAMILY5_CAMERA", 0);
        /// CAM::SET_FOLLOW_PED_CAM_THIS_UPDATE("FOLLOW_PED_SKY_DIVING_CAMERA", 0);
        ///
        /// > const char* camName
        /// > int p1
        ///
        /// </summary>
        SET_FOLLOW_PED_CAM_THIS_UPDATE = 0x44A113DD6FFC48D1,
        /// <summary>
        /// minimum: Degrees between -180f and 180f.
        /// maximum: Degrees between -180f and 180f.
        /// 
        /// Clamps the gameplay camera's current yaw.
        /// 
        /// Eg. _CLAMP_GAMEPLAY_CAM_YAW(0.0f, 0.0f) will set the horizontal angle directly behind the player.
        ///
        /// > float minimum
        /// > float maximum
        ///
        /// </summary>
        _CLAMP_GAMEPLAY_CAM_YAW = 0x8F993D26E0CA5E8E,
        /// <summary>
        /// minimum: Degrees between -90f and 90f.
        /// maximum: Degrees between -90f and 90f.
        /// 
        /// Clamps the gameplay camera's current pitch.
        /// 
        /// Eg. _CLAMP_GAMEPLAY_CAM_PITCH(0.0f, 0.0f) will set the vertical angle directly behind the player.
        ///
        /// > float minimum
        /// > float maximum
        ///
        /// </summary>
        _CLAMP_GAMEPLAY_CAM_PITCH = 0xA516C198B7DCA1E1,
        /// <summary>
        /// Seems to animate the gameplay camera zoom.
        /// 
        /// Eg. _ANIMATE_GAMEPLAY_CAM_ZOOM(1f, 1000f);
        /// will animate the camera zooming in from 1000 meters away.
        /// 
        /// Game scripts use it like this:
        /// 
        /// // Setting this to 1 prevents V key from changing zoom
        /// PLAYER::SET_PLAYER_FORCED_ZOOM(PLAYER::PLAYER_ID(), 1);
        /// 
        /// // These restrict how far you can move cam up/down left/right
        /// CAM::_CLAMP_GAMEPLAY_CAM_YAW(-20f, 50f);
        /// CAM::_CLAMP_GAMEPLAY_CAM_PITCH(-60f, 0f);
        /// 
        /// CAM::_ANIMATE_GAMEPLAY_CAM_ZOOM(1f, 1f);
        ///
        /// > float p0
        /// > float distance
        ///
        /// </summary>
        _ANIMATE_GAMEPLAY_CAM_ZOOM = 0xDF2E1F7742402E81,
        /// <summary>
        /// Disables first person camera for the current frame.
        /// 
        /// Found in decompiled scripts:
        /// GRAPHICS::DRAW_DEBUG_TEXT_2D("Disabling First Person Cam", 0.5, 0.8, 0.0, 0, 0, 255, 255);
        /// CAM::_DE2EF5DA284CC8DF();
        ///
        ///
        /// </summary>
        _DISABLE_FIRST_PERSON_CAM_THIS_FRAME = 0xDE2EF5DA284CC8DF,
        /// <summary>
        /// Returns
        /// 0 - Third Person Close
        /// 1 - Third Person Mid
        /// 2 - Third Person Far
        /// 4 - First Person
        ///
        ///
        /// </summary>
        GET_FOLLOW_PED_CAM_VIEW_MODE = 0x8D4D46230B2C353A,
        /// <summary>
        /// Sets the type of Player camera:
        /// 
        /// 0 - Third Person Close
        /// 1 - Third Person Mid
        /// 2 - Third Person Far
        /// 4 - First Person
        ///
        /// > int viewMode
        ///
        /// </summary>
        SET_FOLLOW_PED_CAM_VIEW_MODE = 0x5A4F9EDF1673F704,
        /// <summary>
        /// Returns the type of camera:
        /// 
        /// 0 - Third Person Close
        /// 1 - Third Person Mid
        /// 2 - Third Person Far
        /// 4 - First Person
        ///
        ///
        /// </summary>
        GET_FOLLOW_VEHICLE_CAM_VIEW_MODE = 0xA4FF579AC0E3AAAE,
        /// <summary>
        /// Sets the type of Player camera in vehicles:
        /// 
        /// 0 - Third Person Close
        /// 1 - Third Person Mid
        /// 2 - Third Person Far
        /// 4 - First Person
        ///
        /// > int viewMode
        ///
        /// </summary>
        SET_FOLLOW_VEHICLE_CAM_VIEW_MODE = 0xAC253D7842768F48,
        /// <summary>
        /// context: see _GET_CAM_ACTIVE_VIEW_MODE_CONTEXT
        ///
        /// > int context
        ///
        /// </summary>
        GET_CAM_VIEW_MODE_FOR_CONTEXT = 0xEE778F8C7E1142E2,
        /// <summary>
        /// context: see _GET_CAM_ACTIVE_VIEW_MODE_CONTEXT
        ///
        /// > int context
        /// > int viewMode
        ///
        /// </summary>
        SET_CAM_VIEW_MODE_FOR_CONTEXT = 0x2A2173E46DAECD12,
        /// <summary>
        /// enum Context
        /// {
        /// 	ON_FOOT,
        /// 	IN_VEHICLE,
        /// 	ON_BIKE,
        /// 	IN_BOAT,
        /// 	IN_AIRCRAFT,
        /// 	IN_SUBMARINE,
        /// 	IN_HELI,
        /// 	IN_TURRET
        /// };
        ///
        ///
        /// </summary>
        _GET_CAM_ACTIVE_VIEW_MODE_CONTEXT = 0x19CAFA3C87F7C2FF,
        /// <summary>
        /// Sets gameplay camera to hash
        ///
        /// > const char* camName
        ///
        /// </summary>
        _SET_GAMEPLAY_CAM_HASH = 0x425A920FDB9A0DDA,
        /// <summary>
        /// IS_A*
        ///
        ///
        /// </summary>
        _IS_AIM_CAM_THIRD_PERSON_ACTIVE = 0x74BD83EA840F6BC9,
        /// <summary>
        /// p0 seems to consistently be 2 across scripts
        /// 
        /// Function is called faily often by CAM::CREATE_CAM_WITH_PARAMS
        ///
        /// > int rotationOrder
        ///
        /// </summary>
        GET_FINAL_RENDERED_CAM_ROT = 0x5B4E4C817FCC2DFB,
        /// <summary>
        /// Gets some camera fov
        ///
        ///
        /// </summary>
        GET_FINAL_RENDERED_CAM_FOV = 0x80EC114669DAEFF4,
        /// <summary>
        /// Focuses the camera on the specified vehicle.
        ///
        /// > Vehicle vehicle
        /// > float offsetX
        /// > float offsetY
        /// > float offsetZ
        /// > BOOL p4
        /// > int time
        /// > int easeInTime
        /// > int easeOutTime
        ///
        /// </summary>
        SET_GAMEPLAY_VEHICLE_HINT = 0xA2297E18F3E71C2E,
        /// <summary>
        /// p6 & p7 - possibly length or time
        ///
        /// > Entity entity
        /// > float xOffset
        /// > float yOffset
        /// > float zOffset
        /// > BOOL p4
        /// > int p5
        /// > int p6
        /// > int p7
        /// > Any p8
        ///
        /// </summary>
        SET_GAMEPLAY_ENTITY_HINT = 0x189E955A8313E298,
        /// <summary>
        /// p0 argument found in the b617d scripts: "DRUNK_SHAKE"
        /// 
        /// Full list of cam shake types by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/camShakeTypesCompact.json
        ///
        /// > const char* p0
        /// > float p1
        ///
        /// </summary>
        SHAKE_CINEMATIC_CAM = 0xDCE214D9ED58F3CF,
        /// <summary>
        /// Resets the vehicle idle camera timer. Calling this in a loop will disable the idle camera.
        ///
        ///
        /// </summary>
        _INVALIDATE_VEHICLE_IDLE_CAM = 0x9E4CFFF989258472,
        /// <summary>
        /// Resets the idle camera timer. Calling that in a loop once every few seconds is enough to disable the idle cinematic camera.
        ///
        ///
        /// </summary>
        INVALIDATE_IDLE_CAM = 0xF4F2C0D4EE209E20,
        /// <summary>
        /// Only used once in carsteal3 with p0 set to -1096069633 (CAMERA_MAN_SHOT)
        ///
        /// > Hash p0
        ///
        /// </summary>
        STOP_CINEMATIC_SHOT = 0x7660C6E75D3A078E,
        /// <summary>
        /// Toggles the vehicle cinematic cam; requires the player ped to be in a vehicle to work.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_CINEMATIC_MODE_ACTIVE = 0xDCF0754AC3D6FD4E,
        /// <summary>
        /// Tests some cinematic camera flags
        ///
        ///
        /// </summary>
        _IS_CINEMATIC_CAM_ACTIVE = 0xF5F1E89A970B7796,
        /// <summary>
        /// if p0 is 0, effect is cancelled
        /// 
        /// if p0 is 1, effect zooms in, gradually tilts cam clockwise apx 30 degrees, wobbles slowly. Motion blur is active until cancelled.
        /// 
        /// if p0 is 2, effect immediately tilts cam clockwise apx 30 degrees, begins to wobble slowly, then gradually tilts cam back to normal. The wobbling will continue until the effect is cancelled.
        ///
        /// > int p0
        ///
        /// </summary>
        _SET_CAM_EFFECT = 0x80C8B1846639BB19,
        /// <summary>
        /// From b617 scripts:
        /// 
        /// CAM::_21E253A7F8DA5DFB("DINGHY");
        /// CAM::_21E253A7F8DA5DFB("ISSI2");
        /// CAM::_21E253A7F8DA5DFB("SPEEDO");
        ///
        /// > const char* vehicleName
        ///
        /// </summary>
        _SET_GAMEPLAY_CAM_VEHICLE_CAMERA = 0x21E253A7F8DA5DFB,
        /// <summary>
        /// SET_CAM_*
        ///
        /// > Cam cam
        /// > BOOL p1
        ///
        /// </summary>
        _0x661B5C8654ADD825 = 0x661B5C8654ADD825,
        /// <summary>
        /// p1: 0..16
        ///
        /// > Vehicle vehicle
        /// > int p1
        /// > float p2
        ///
        /// </summary>
        _0x5D96CFB59DA076A0 = 0x5D96CFB59DA076A0,
        /// <summary>
        /// W*
        ///
        /// > Cam cam
        ///
        /// </summary>
        _0x5C48A1D6E3B33179 = 0x5C48A1D6E3B33179,
        /// <summary>
        /// A*
        ///
        ///
        /// </summary>
        _0x4879E4FE39074CDF = 0x4879E4FE39074CDF,
        /// <summary>
        /// some camera effect that is used in the drunk-cheat, and turned off (by setting it to 0.0) along with the shaking effects once the drunk cheat is disabled.
        ///
        /// > float p0
        ///
        /// </summary>
        _0x487A82C650EB7799 = 0x487A82C650EB7799,
        /// <summary>
        /// some camera effect that is (also) used in the drunk-cheat, and turned off (by setting it to 0.0) along with the shaking effects once the drunk cheat is disabled. Possibly a cinematic or script-cam version of _0x487A82C650EB7799
        ///
        /// > float p0
        ///
        /// </summary>
        _0x0225778816FDC28C = 0x0225778816FDC28C,
        /// <summary>
        /// F*
        ///
        /// > float p0
        /// > float p1
        ///
        /// </summary>
        _0x28B022A17B068A3A = 0x28B022A17B068A3A,
        /// <summary>
        /// Sets some flag on cinematic camera
        ///
        ///
        /// </summary>
        _0xB1381B97F70C7B30 = 0xB1381B97F70C7B30,
        /// <summary>
        /// B*
        ///
        ///
        /// </summary>
        _0x9F97DA93681F87EA = 0x9F97DA93681F87EA,
        /// <summary>
        /// SET_FOLLOW_*
        ///
        /// > BOOL p0
        /// > BOOL p1
        ///
        /// </summary>
        _0x9DFE13ECDC1EC196 = 0x9DFE13ECDC1EC196,
        /// <summary>
        /// This native does absolutely nothing, just a nullsub
        ///
        /// > BOOL p0
        ///
        /// </summary>
        _0xCCD078C2665D2973 = 0xCCD078C2665D2973,
        /// <summary>
        /// Hardcoded to only work in multiplayer.
        ///
        /// > float p0
        ///
        /// </summary>
        _0x12DED8CA53D47EA5 = 0x12DED8CA53D47EA5,
        CREATE_CAMERA = 0x5E3CF89C6BCCA67D,
        IS_CAM_RENDERING = 0x02EC0AF5C5A49B7A,
        GET_RENDERING_CAM = 0x5234F9F10919EABA,
        GET_CAM_COORD = 0xBAC038F7459AE5AE,
        GET_CAM_FOV = 0xC3330A45CCCDB26A,
        GET_CAM_NEAR_CLIP = 0xC520A34DAFBF24B1,
        GET_CAM_FAR_CLIP = 0xB60A9CFEB21CA6AA,
        GET_CAM_FAR_DOF = 0x255F8DAFD540D397,
        SET_CAM_PARAMS = 0xBFD8727AEA3CCEBA,
        SET_CAM_NEAR_CLIP = 0xC7848EFCCC545182,
        SET_CAM_FAR_CLIP = 0xAE306F2A904BF86E,
        SET_CAM_MOTION_BLUR_STRENGTH = 0x6F0F77FBA9A8F2E6,
        SET_CAM_NEAR_DOF = 0x3FA4BF0A7AB7DE2C,
        SET_CAM_FAR_DOF = 0xEDD91296CD01AEE0,
        SET_CAM_DOF_STRENGTH = 0x5EE29B4D7D5DF897,
        SET_CAM_DOF_PLANES = 0x3CF48F6F96E749DC,
        SET_CAM_USE_SHALLOW_DOF_MODE = 0x16A96863A17552BB,
        SET_USE_HI_DOF = 0xA13B0222F3D94A94,
        ATTACH_CAM_TO_PED_BONE = 0x61A3DBA14AB7F411,
        _ATTACH_CAM_TO_PED_BONE_2 = 0x149916F50C34A40D,
        DETACH_CAM = 0xA2FABBE87F4BAD82,
        POINT_CAM_AT_COORD = 0xF75497BB865F0803,
        STOP_CAM_POINTING = 0xF33AB75780BA57DE,
        _GET_DEBUG_CAMERA = 0x77C3CEC46BE286F6,
        ADD_CAM_SPLINE_NODE_USING_CAMERA_FRAME = 0x0A9F2A468B328E74,
        ADD_CAM_SPLINE_NODE_USING_CAMERA = 0x0FB82563989CF4FB,
        ADD_CAM_SPLINE_NODE_USING_GAMEPLAY_FRAME = 0x609278246A29CA34,
        SET_CAM_SPLINE_PHASE = 0x242B5874F0A4E052,
        SET_CAM_SPLINE_SMOOTHING_STYLE = 0xD1B0F412F109EA5D,
        GET_CAM_SPLINE_NODE_INDEX = 0xB22B17DF858716A6,
        SET_CAM_SPLINE_NODE_EASE = 0x83B8201ED82A9A2D,
        SET_CAM_SPLINE_NODE_VELOCITY_SCALE = 0xA6385DEB180F319F,
        OVERRIDE_CAM_SPLINE_VELOCITY = 0x40B62FA033EB0346,
        SET_CAM_SPLINE_NODE_EXTRA_FLAGS = 0x7BF1A54AE67AC070,
        IS_CAM_SPLINE_PAUSED = 0x0290F35C0AD97864,
        IS_CAM_INTERPOLATING = 0x036F97C908C2B52C,
        IS_CAM_SHAKING = 0x6B24BFE83A2BE47B,
        SET_CAM_SHAKE_AMPLITUDE = 0xD93DB43B82BC0D00,
        STOP_CAM_SHAKING = 0xBDECF64367884AC3,
        IS_CAM_PLAYING_ANIM = 0xC90621D8A0CEECF2,
        SET_CAM_ANIM_CURRENT_PHASE = 0x4145A4C44FF3B5A6,
        GET_CAM_ANIM_CURRENT_PHASE = 0xA10B2DB49E92A6B0,
        SET_FLY_CAM_HORIZONTAL_RESPONSE = 0x503F5920162365B2,
        _SET_FLY_CAM_VERTICAL_SPEED_MULTIPLIER = 0xE827B9382CFB41BA,
        SET_FLY_CAM_MAX_HEIGHT = 0xF9D02130ECDD1D77,
        SET_FLY_CAM_COORD_AND_CONSTRAIN = 0xC91C6C55199308CA,
        IS_SCREEN_FADED_OUT = 0xB16FCE9DDC7BA182,
        IS_SCREEN_FADED_IN = 0x5A859503B0C08678,
        IS_SCREEN_FADING_OUT = 0x797AC7CB535BA28F,
        IS_SCREEN_FADING_IN = 0x5C544BC6C57AC575,
        SET_WIDESCREEN_BORDERS = 0xDCD4EA924F42D01A,
        GET_GAMEPLAY_CAM_COORD = 0x14D6F5678D8F1B37,
        GET_GAMEPLAY_CAM_FOV = 0x65019750A0324133,
        GET_GAMEPLAY_CAM_RELATIVE_HEADING = 0x743607648ADD4587,
        GET_GAMEPLAY_CAM_RELATIVE_PITCH = 0x3A6867B4845BEDA2,
        _SET_GAMEPLAY_CAM_RELATIVE_ROTATION = 0x48608C3464F58AB4,
        _SET_GAMEPLAY_CAM_RAW_PITCH = 0x759E13EBC1C15C5A,
        IS_GAMEPLAY_CAM_SHAKING = 0x016C090630DF1F89,
        STOP_GAMEPLAY_CAM_SHAKING = 0x0EF93E9F3D08C178,
        SET_GAMEPLAY_CAM_FOLLOW_PED_THIS_UPDATE = 0x8BBACBF51DA047A8,
        IS_GAMEPLAY_CAM_LOOKING_BEHIND = 0x70FDA869F3317EA9,
        _DISABLE_CAM_COLLISION_FOR_ENTITY = 0x2AED6301F67007D5,
        DISABLE_CAM_COLLISION_FOR_OBJECT = 0x49482F9FCD825AAA,
        IS_SPHERE_VISIBLE = 0xE33D59DA70B58FDF,
        IS_FOLLOW_PED_CAM_ACTIVE = 0xC6D3D26810C8E0F9,
        SET_IN_VEHICLE_CAM_STATE_THIS_UPDATE = 0xE9EA16D6E54CDCA4,
        GET_FOLLOW_PED_CAM_ZOOM_LEVEL = 0x33E6C8EFD0CD93E9,
        IS_FOLLOW_VEHICLE_CAM_ACTIVE = 0xCBBDE6D335D6D496,
        GET_FOLLOW_VEHICLE_CAM_ZOOM_LEVEL = 0xEE82280AB767B690,
        SET_FOLLOW_VEHICLE_CAM_ZOOM_LEVEL = 0x19464CB6E4078C8A,
        _USE_STUNT_CAMERA_THIS_FRAME = 0x6493CF69859B116A,
        _SET_FOLLOW_TURRET_SEAT_CAM = 0x5C90CAB09951A12F,
        IS_AIM_CAM_ACTIVE = 0x68EDDA28A5976D07,
        IS_FIRST_PERSON_AIM_CAM_ACTIVE = 0x5E346D934122613F,
        DISABLE_AIM_CAM_THIS_UPDATE = 0x1A31FE0049E542F6,
        GET_FIRST_PERSON_AIM_CAM_ZOOM_FACTOR = 0x7EC52CC40597D170,
        SET_FIRST_PERSON_AIM_CAM_ZOOM_FACTOR = 0x70894BD0915C5BCA,
        _SET_FIRST_PERSON_CAM_PITCH_RANGE = 0xBCFC632DB7673BF0,
        SET_FIRST_PERSON_AIM_CAM_NEAR_CLIP_THIS_UPDATE = 0x0AF7B437918103B3,
        SET_THIRD_PERSON_AIM_CAM_NEAR_CLIP_THIS_UPDATE = 0x42156508606DE65E,
        GET_FINAL_RENDERED_CAM_COORD = 0xA200EB1EE790F448,
        GET_FINAL_RENDERED_IN_WHEN_FRIENDLY_ROT = 0x26903D9CD1175F2C,
        GET_FINAL_RENDERED_IN_WHEN_FRIENDLY_FOV = 0x5F35F6732C3FBBA0,
        GET_FINAL_RENDERED_CAM_NEAR_CLIP = 0xD0082607100D7193,
        GET_FINAL_RENDERED_CAM_FAR_CLIP = 0xDFC8CBC606FDB0FC,
        GET_FINAL_RENDERED_CAM_NEAR_DOF = 0xA03502FC581F7D9B,
        GET_FINAL_RENDERED_CAM_FAR_DOF = 0x9780F32BCAF72431,
        GET_FINAL_RENDERED_CAM_MOTION_BLUR_STRENGTH = 0x162F9D995753DC19,
        SET_GAMEPLAY_COORD_HINT = 0xD51ADCD2D8BC0FB3,
        SET_GAMEPLAY_PED_HINT = 0x2B486269ACD548D3,
        SET_GAMEPLAY_OBJECT_HINT = 0x83E87508A2CA2AC6,
        IS_GAMEPLAY_HINT_ACTIVE = 0xE520FF1AD2785B40,
        STOP_GAMEPLAY_HINT = 0xF46C581C61718916,
        SET_GAMEPLAY_HINT_FOV = 0x513403FB9C56211F,
        SET_GAMEPLAY_HINT_FOLLOW_DISTANCE_SCALAR = 0xF8BDBF3D573049A1,
        SET_GAMEPLAY_HINT_BASE_ORBIT_PITCH_OFFSET = 0xD1F8363DFAD03848,
        _SET_GAMEPLAY_HINT_ANIM_OFFSETX = 0x5D7B620DAE436138,
        _SET_GAMEPLAY_HINT_ANIM_OFFSETY = 0xC92717EF615B6704,
        _SET_GAMEPLAY_HINT_ANIM_CLOSEUP = 0xE3433EADAAF7EE40,
        SET_CINEMATIC_BUTTON_ACTIVE = 0x51669F7D1FB53D9F,
        IS_CINEMATIC_CAM_RENDERING = 0xB15162CB5826E9E8,
        IS_CINEMATIC_CAM_SHAKING = 0xBBC08F6B4CB8FF0A,
        SET_CINEMATIC_CAM_SHAKE_AMPLITUDE = 0xC724C701C30B2FE7,
        STOP_CINEMATIC_CAM_SHAKING = 0x2238E588E588A6D7,
        _DISABLE_VEHICLE_FIRST_PERSON_CAM_THIS_FRAME = 0xADFF1B2A555F5FBA,
        IS_CINEMATIC_IDLE_CAM_RENDERING = 0xCA9D2AA3E326D720,
        _IS_IN_VEHICLE_CAM_DISABLED = 0x4F32C0D5A90A9B40,
        CREATE_CINEMATIC_SHOT = 0x741B0129D4560F31,
        IS_CINEMATIC_SHOT_ACTIVE = 0xCC9F3371A7C28BC9,
        FORCE_CINEMATIC_RENDERING_THIS_UPDATE = 0xA41BCD7213805AAC,
        STOP_CUTSCENE_CAM_SHAKING = 0xDB629FFD9285FA06,
        GET_FOCUS_PED_ON_SCREEN = 0x89215EC747DF244A,
        _SET_GAMEPLAY_CAM_VEHICLE_CAMERA_NAME = 0x11FA5D3479C7DD47,
        _REPLAY_FREE_CAM_GET_MAX_RANGE = 0x8BFCEB5EA1B161B6,
        _0xAABD62873FFB1A33 = 0xAABD62873FFB1A33,
        _0xF55E4046F6F831DC = 0xF55E4046F6F831DC,
        _0xE111A7C0D200CBC5 = 0xE111A7C0D200CBC5,
        _0x202A5ED9CE01D6E7 = 0x202A5ED9CE01D6E7,
        _0xA2767257A320FC82 = 0xA2767257A320FC82,
        _0x271017B9BA825366 = 0x271017B9BA825366,
        _0xC8B5C4A79CC18B94 = 0xC8B5C4A79CC18B94,
        _0x469F2ECDEC046337 = 0x469F2ECDEC046337,
        _0x3044240D2E0FA842 = 0x3044240D2E0FA842,
        _0x705A276EBFF3133D = 0x705A276EBFF3133D,
        _0xDB90C6CCA48940F1 = 0xDB90C6CCA48940F1,
        _0xA7092AFE81944852 = 0xA7092AFE81944852,
        _0xFD3151CD37EA2245 = 0xFD3151CD37EA2245,
        _0xDD79DF9F4D26E1C9 = 0xDD79DF9F4D26E1C9,
        _0x271401846BD26E92 = 0x271401846BD26E92,
        _0xC8391C309684595A = 0xC8391C309684595A,
        _0x59424BD75174C9B1 = 0x59424BD75174C9B1,
        _0x91EF6EE6419E5B97 = 0x91EF6EE6419E5B97,
        _0x79C0E43EB9B944E2 = 0x79C0E43EB9B944E2,
        _0x0AA27680A0BD43FA = 0x0AA27680A0BD43FA,
        _0xCED08CBE8EBB97C7 = 0xCED08CBE8EBB97C7,
        _0x2F7F2B26DD3F18EE = 0x2F7F2B26DD3F18EE,
        _0x4008EDF7D6E48175 = 0x4008EDF7D6E48175,
        _0x380B4968D1E09E55 = 0x380B4968D1E09E55,
        _0x247ACBC4ABBC9D1C = 0x247ACBC4ABBC9D1C,
        _0xBF72910D0F26F025 = 0xBF72910D0F26F025,
        _0x62ECFCFDEE7885D6 = 0x62ECFCFDEE7885D6,
        _0xDC9DA9E8789F5246 = 0xDC9DA9E8789F5246,
        _0x1F2300CB7FA7B7F6 = 0x1F2300CB7FA7B7F6,
        _0x17FCA7199A530203 = 0x17FCA7199A530203,
        _0xD7360051C885628B = 0xD7360051C885628B,
        _0x7B8A361C1813FBEF = 0x7B8A361C1813FBEF,
        _0x324C5AA411DA7737 = 0x324C5AA411DA7737,
        _0x5A43C76F7FC7BA5F = 0x5A43C76F7FC7BA5F,
        _0x5C41E6BABC9E2112 = 0x5C41E6BABC9E2112,
        _0xEAF0FA793D05C592 = 0xEAF0FA793D05C592,
        _0x62374889A4D59F72 = 0x62374889A4D59F72,
    }
}