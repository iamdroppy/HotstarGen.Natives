using System;
namespace Hotstar
{
    public enum GRAPHICS : ulong
    { 
        /// <summary>
        /// NOTE: Debugging functions are not present in the retail version of the game.
        ///
        /// > BOOL enabled
        ///
        /// </summary>
        SET_DEBUG_LINES_AND_SPHERES_DRAWING_ACTIVE = 0x175B6BFC15CDD0C5,
        /// <summary>
        /// NOTE: Debugging functions are not present in the retail version of the game.
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > int r1
        /// > int g1
        /// > int b1
        /// > int r2
        /// > int g2
        /// > int b2
        /// > int alpha1
        /// > int alpha2
        ///
        /// </summary>
        DRAW_DEBUG_LINE_WITH_TWO_COLOURS = 0xD8B9A8AC5608FF94,
        /// <summary>
        /// NOTE: Debugging functions are not present in the retail version of the game.
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        /// > int red
        /// > int green
        /// > int blue
        /// > int alpha
        ///
        /// </summary>
        DRAW_DEBUG_SPHERE = 0xAAD68E1AB39DA632,
        /// <summary>
        /// NOTE: Debugging functions are not present in the retail version of the game.
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float size
        /// > int red
        /// > int green
        /// > int blue
        /// > int alpha
        ///
        /// </summary>
        DRAW_DEBUG_CROSS = 0x73B1189623049839,
        /// <summary>
        /// NOTE: Debugging functions are not present in the retail version of the game.
        ///
        /// > const char* text
        /// > float x
        /// > float y
        /// > float z
        /// > int red
        /// > int green
        /// > int blue
        /// > int alpha
        ///
        /// </summary>
        DRAW_DEBUG_TEXT = 0x3903E216620488E8,
        /// <summary>
        /// NOTE: Debugging functions are not present in the retail version of the game.
        ///
        /// > const char* text
        /// > float x
        /// > float y
        /// > float z
        /// > int red
        /// > int green
        /// > int blue
        /// > int alpha
        ///
        /// </summary>
        DRAW_DEBUG_TEXT_2D = 0xA3BB2E9555C05A8F,
        /// <summary>
        /// Draws a depth-tested line from one point to another.
        /// ----------------
        /// x1, y1, z1 : Coordinates for the first point
        /// x2, y2, z2 : Coordinates for the second point
        /// r, g, b, alpha : Color with RGBA-Values
        /// I recommend using a predefined function to call this.
        /// [VB.NET]
        /// Public Sub DrawLine(from As Vector3, [to] As Vector3, col As Color)
        ///     [Function].Call(Hash.DRAW_LINE, from.X, from.Y, from.Z, [to].X, [to].Y, [to].Z, col.R, col.G, col.B, col.A)
        /// End Sub
        /// 
        /// [C#]
        /// public void DrawLine(Vector3 from, Vector3 to, Color col)
        /// {
        ///     Function.Call(Hash.DRAW_LINE, from.X, from.Y, from.Z, to.X, to.Y, to.Z, col.R, col.G, col.B, col.A);
        /// }
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > int red
        /// > int green
        /// > int blue
        /// > int alpha
        ///
        /// </summary>
        DRAW_LINE = 0x6B7256074AE34680,
        /// <summary>
        /// x/y/z - Location of a vertex (in world coords), presumably.
        /// ----------------
        /// x1, y1, z1     : Coordinates for the first point
        /// x2, y2, z2     : Coordinates for the second point
        /// x3, y3, z3     : Coordinates for the third point
        /// r, g, b, alpha : Color with RGBA-Values
        /// 
        /// Keep in mind that only one side of the drawn triangle is visible: It's the side, in which the vector-product of the vectors heads to: (b-a)x(c-a) Or (b-a)x(c-b).
        /// But be aware: The function seems to work somehow differently. I have trouble having them drawn in rotated orientation. Try it yourself and if you somehow succeed, please edit this and post your solution.
        /// I recommend using a predefined function to call this.
        /// [VB.NET]
        /// Public Sub DrawPoly(a As Vector3, b As Vector3, c As Vector3, col As Color)
        ///     [Function].Call(Hash.DRAW_POLY, a.X, a.Y, a.Z, b.X, b.Y, b.Z, c.X, c.Y, c.Z, col.R, col.G, col.B, col.A)
        /// End Sub
        /// 
        /// [C#]
        /// public void DrawPoly(Vector3 a, Vector3 b, Vector3 c, Color col)
        /// {
        ///     Function.Call(Hash.DRAW_POLY, a.X, a.Y, a.Z, b.X, b.Y, b.Z, c.X, c.Y, c.Z, col.R, col.G, col.B, col.A);
        /// }
        /// BTW: Intersecting triangles are not supported: They overlap in the order they were called.
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > float x3
        /// > float y3
        /// > float z3
        /// > int red
        /// > int green
        /// > int blue
        /// > int alpha
        ///
        /// </summary>
        DRAW_POLY = 0xAC26716048436851,
        /// <summary>
        /// Used for drawling Deadline trailing lights, see deadline.ytd
        /// 
        /// p15 through p23 are values that appear to be related to illiumation, scaling, and rotation; more testing required.
        /// For UVW mapping (u,v,w parameters), reference your favourite internet resource for more details.
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > float x3
        /// > float y3
        /// > float z3
        /// > int red
        /// > int green
        /// > int blue
        /// > int alpha
        /// > const char* textureDict
        /// > const char* textureName
        /// > float u1
        /// > float v1
        /// > float w1
        /// > float u2
        /// > float v2
        /// > float w2
        /// > float u3
        /// > float v3
        /// > float w3
        ///
        /// </summary>
        _DRAW_SPRITE_POLY = 0x29280002282F1928,
        /// <summary>
        /// Used for drawling Deadline trailing lights, see deadline.ytd
        /// 
        /// Each vertex has its own colour that is blended/illuminated on the texture. Additionally, the R, G, and B components are floats that are int-casted internally.
        /// For UVW mapping (u,v,w parameters), reference your favourite internet resource for more details.
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > float x3
        /// > float y3
        /// > float z3
        /// > float red1
        /// > float green1
        /// > float blue1
        /// > int alpha1
        /// > float red2
        /// > float green2
        /// > float blue2
        /// > int alpha2
        /// > float red3
        /// > float green3
        /// > float blue3
        /// > int alpha3
        /// > const char* textureDict
        /// > const char* textureName
        /// > float u1
        /// > float v1
        /// > float w1
        /// > float u2
        /// > float v2
        /// > float w2
        /// > float u3
        /// > float v3
        /// > float w3
        ///
        /// </summary>
        _DRAW_SPRITE_POLY_2 = 0x736D7AA1B750856B,
        /// <summary>
        /// x,y,z = start pos
        /// x2,y2,z2 = end pos
        /// 
        /// Draw's a 3D Box between the two x,y,z coords.
        /// --------------
        /// Keep in mind that the edges of the box do only align to the worlds base-vectors. Therefore something like rotation cannot be applied. That means this function is pretty much useless, unless you want a static unicolor box somewhere.
        /// I recommend using a predefined function to call this.
        /// [VB.NET]
        /// Public Sub DrawBox(a As Vector3, b As Vector3, col As Color)
        ///     [Function].Call(Hash.DRAW_BOX,a.X, a.Y, a.Z,b.X, b.Y, b.Z,col.R, col.G, col.B, col.A)
        /// End Sub
        /// 
        /// [C#]
        /// public void DrawBox(Vector3 a, Vector3 b, Color col)
        /// {
        ///     Function.Call(Hash.DRAW_BOX,a.X, a.Y, a.Z,b.X, b.Y, b.Z,col.R, col.G, col.B, col.A);
        /// }
        ///
        /// > float x1
        /// > float y1
        /// > float z1
        /// > float x2
        /// > float y2
        /// > float z2
        /// > int red
        /// > int green
        /// > int blue
        /// > int alpha
        ///
        /// </summary>
        DRAW_BOX = 0xD3A9971CADAC7252,
        /// <summary>
        /// 1 match in 1 script. cellphone_controller.
        /// p0 is -1 in scripts.
        ///
        /// > int unused
        ///
        /// </summary>
        SAVE_HIGH_QUALITY_PHOTO = 0x3DEC726C25A11BAC,
        /// <summary>
        /// This function is hard-coded to always return 0.
        ///
        ///
        /// </summary>
        GET_MAXIMUM_NUMBER_OF_PHOTOS = 0x34D23450F028B0BF,
        /// <summary>
        /// This function is hard-coded to always return 96.
        ///
        ///
        /// </summary>
        GET_MAXIMUM_NUMBER_OF_CLOUD_PHOTOS = 0xDC54A7AF8B3A14EF,
        /// <summary>
        /// 3 matches across 3 scripts. First 2 were 0, 3rd was 1. Possibly a bool.
        /// appcamera, appmedia, and cellphone_controller.
        ///
        /// > Any p0
        ///
        /// </summary>
        GET_STATUS_OF_SORTED_LIST_OPERATION = 0xF5BED327CEA362B1,
        /// <summary>
        /// GET_L*
        /// 
        /// Hardcoded to always return 2.
        ///
        /// > int p0
        ///
        /// </summary>
        _RETURN_TWO = 0x40AFB081F8ADD4EE,
        /// <summary>
        /// Parameters:
        /// * pos - coordinate where the spotlight is located
        /// * dir - the direction vector the spotlight should aim at from its current position
        /// * r,g,b - color of the spotlight
        /// * distance - the maximum distance the light can reach
        /// * brightness - the brightness of the light
        /// * roundness - "smoothness" of the circle edge
        /// * radius - the radius size of the spotlight
        /// * falloff - the falloff size of the light's edge (example: www.i.imgur.com/DemAWeO.jpg)
        /// 
        /// Example in C# (spotlight aims at the closest vehicle):
        /// Vector3 myPos = Game.Player.Character.Position;
        /// Vehicle nearest = World.GetClosestVehicle(myPos , 1000f);
        /// Vector3 destinationCoords = nearest.Position;
        /// Vector3 dirVector = destinationCoords - myPos;
        /// dirVector.Normalize();
        /// Function.Call(Hash.DRAW_SPOT_LIGHT, pos.X, pos.Y, pos.Z, dirVector.X, dirVector.Y, dirVector.Z, 255, 255, 255, 100.0f, 1f, 0.0f, 13.0f, 1f);
        ///
        /// > float posX
        /// > float posY
        /// > float posZ
        /// > float dirX
        /// > float dirY
        /// > float dirZ
        /// > int colorR
        /// > int colorG
        /// > int colorB
        /// > float distance
        /// > float brightness
        /// > float hardness
        /// > float radius
        /// > float falloff
        ///
        /// </summary>
        DRAW_SPOT_LIGHT = 0xD0F64B265C8C8B33,
        /// <summary>
        /// enum MarkerTypes
        /// {
        ///     MarkerTypeUpsideDownCone = 0,
        ///  MarkerTypeVerticalCylinder = 1,
        ///    MarkerTypeThickChevronUp = 2,
        ///  MarkerTypeThinChevronUp = 3,
        ///   MarkerTypeCheckeredFlagRect = 4,
        ///   MarkerTypeCheckeredFlagCircle = 5,
        ///     MarkerTypeVerticleCircle = 6,
        ///  MarkerTypePlaneModel = 7,
        ///  MarkerTypeLostMCDark = 8,
        ///  MarkerTypeLostMCLight = 9,
        ///     MarkerTypeNumber0 = 10,
        ///    MarkerTypeNumber1 = 11,
        ///    MarkerTypeNumber2 = 12,
        ///    MarkerTypeNumber3 = 13,
        ///    MarkerTypeNumber4 = 14,
        ///    MarkerTypeNumber5 = 15,
        ///    MarkerTypeNumber6 = 16,
        ///    MarkerTypeNumber7 = 17,
        ///    MarkerTypeNumber8 = 18,
        ///    MarkerTypeNumber9 = 19,
        ///    MarkerTypeChevronUpx1 = 20,
        ///    MarkerTypeChevronUpx2 = 21,
        ///    MarkerTypeChevronUpx3 = 22,
        ///    MarkerTypeHorizontalCircleFat = 23,
        ///    MarkerTypeReplayIcon = 24,
        ///     MarkerTypeHorizontalCircleSkinny = 25,
        ///     MarkerTypeHorizontalCircleSkinny_Arrow = 26,
        ///   MarkerTypeHorizontalSplitArrowCircle = 27,
        ///     MarkerTypeDebugSphere = 28,
        ///    MarkerTypeDallorSign = 29,
        ///     MarkerTypeHorizontalBars = 30,
        ///     MarkerTypeWolfHead = 31
        /// };
        /// 
        /// dirX/Y/Z represent a heading on each axis in which the marker should face, alternatively you can rotate each axis independently with rotX/Y/Z (and set dirX/Y/Z all to 0).
        /// 
        /// faceCamera - Rotates only the y-axis (the heading) towards the camera
        /// 
        /// p19 - no effect, default value in script is 2
        /// 
        /// rotate - Rotates only on the y-axis (the heading)
        /// 
        /// textureDict - Name of texture dictionary to load texture from (e.g. "GolfPutting")
        /// 
        /// textureName - Name of texture inside dictionary to load (e.g. "PuttingMarker")
        /// 
        /// drawOnEnts - Draws the marker onto any entities that intersect it
        /// 
        /// basically what he said, except textureDict and textureName are totally not const char*, or if so, then they are always set to 0/NULL/nullptr in every script I checked, eg:
        /// 
        /// bj.c: graphics::draw_marker(6, vParam0, 0f, 0f, 1f, 0f, 0f, 0f, 4f, 4f, 4f, 240, 200, 80, iVar1, 0, 0, 2, 0, 0, 0, false);
        /// 
        /// his is what I used to draw an amber downward pointing chevron "V", has to be redrawn every frame.  The 180 is for 180 degrees rotation around the Y axis, the 50 is alpha, assuming max is 100, but it will accept 255.
        /// 
        /// GRAPHICS::DRAW_MARKER(2, v.x, v.y, v.z + 2, 0, 0, 0, 0, 180, 0, 2, 2, 2, 255, 128, 0, 50, 0, 1, 1, 0, 0, 0, 0);
        /// 
        /// 
        ///
        /// > int type
        /// > float posX
        /// > float posY
        /// > float posZ
        /// > float dirX
        /// > float dirY
        /// > float dirZ
        /// > float rotX
        /// > float rotY
        /// > float rotZ
        /// > float scaleX
        /// > float scaleY
        /// > float scaleZ
        /// > int red
        /// > int green
        /// > int blue
        /// > int alpha
        /// > BOOL bobUpAndDown
        /// > BOOL faceCamera
        /// > int p19
        /// > BOOL rotate
        /// > const char* textureDict
        /// > const char* textureName
        /// > BOOL drawOnEnts
        ///
        /// </summary>
        DRAW_MARKER = 0x28477EC23D892089,
        /// <summary>
        /// Draws a 3D sphere, typically seen in the GTA:O freemode event "Penned In".
        /// Example https://imgur.com/nCbtS4H
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        /// > int red
        /// > int green
        /// > int blue
        /// > float alpha
        ///
        /// </summary>
        _DRAW_SPHERE = 0x799017F9E3B10112,
        /// <summary>
        /// Creates a checkpoint. Returns the handle of the checkpoint.
        /// 
        /// 20/03/17 : Attention, checkpoints are already handled by the game itself, so you must not loop it like markers.
        /// 
        /// Parameters:
        /// * type - The type of checkpoint to create. See below for a list of checkpoint types.
        /// * pos1 - The position of the checkpoint.
        /// * pos2 - The position of the next checkpoint to point to.
        /// * radius - The radius of the checkpoint.
        /// * color - The color of the checkpoint.
        /// * reserved - Special parameter, see below for details. Usually set to 0 in the scripts.
        /// 
        /// Checkpoint types:
        /// 0-4---------Cylinder: 1 arrow, 2 arrow, 3 arrows, CycleArrow, Checker
        /// 5-9---------Cylinder: 1 arrow, 2 arrow, 3 arrows, CycleArrow, Checker
        /// 10-14-------Ring: 1 arrow, 2 arrow, 3 arrows, CycleArrow, Checker
        /// 15-19-------1 arrow, 2 arrow, 3 arrows, CycleArrow, Checker      
        /// 20-24-------Cylinder: 1 arrow, 2 arrow, 3 arrows, CycleArrow, Checker 
        /// 25-29-------Cylinder: 1 arrow, 2 arrow, 3 arrows, CycleArrow, Checker    
        /// 30-34-------Cylinder: 1 arrow, 2 arrow, 3 arrows, CycleArrow, Checker 
        /// 35-38-------Ring: Airplane Up, Left, Right, UpsideDown
        /// 39----------?
        /// 40----------Ring: just a ring
        /// 41----------?
        /// 42-44-------Cylinder w/ number (uses 'reserved' parameter)
        /// 45-47-------Cylinder no arrow or number
        /// 
        /// If using type 42-44, reserved sets number / number and shape to display
        /// 
        /// 0-99------------Just numbers (0-99)
        /// 100-109-----------------Arrow (0-9)
        /// 110-119------------Two arrows (0-9)
        /// 120-129----------Three arrows (0-9)
        /// 130-139----------------Circle (0-9)
        /// 140-149------------CycleArrow (0-9)
        /// 150-159----------------Circle (0-9)
        /// 160-169----Circle  w/ pointer (0-9)
        /// 170-179-------Perforated ring (0-9)
        /// 180-189----------------Sphere (0-9)
        ///
        /// > int type
        /// > float posX1
        /// > float posY1
        /// > float posZ1
        /// > float posX2
        /// > float posY2
        /// > float posZ2
        /// > float diameter
        /// > int red
        /// > int green
        /// > int blue
        /// > int alpha
        /// > int reserved
        ///
        /// </summary>
        CREATE_CHECKPOINT = 0x0134F0835AB6BFCB,
        /// <summary>
        /// p0 - Scale? Looks to be a normalized value (0.0 - 1.0)
        /// 
        /// offroad_races.c4, line ~67407:
        /// a_3._f7 = GRAPHICS::CREATE_CHECKPOINT(v_D, v_A, a_4, a_7, v_E, v_F, v_10, sub_62b2(v_A, 220, 255), 0);
        /// HUD::GET_HUD_COLOUR(134, &v_E, &v_F, &v_10, &v_11);
        /// GRAPHICS::_SET_CHECKPOINT_ICON_RGBA(a_3._f7, v_E, v_F, v_10, sub_62b2(v_A, 70, 210));
        /// GRAPHICS::_4B5B4DA5D79F1943(a_3._f7, 0.95);
        /// GRAPHICS::SET_CHECKPOINT_CYLINDER_HEIGHT(a_3._f7, 4.0, 4.0, 100.0);
        /// 
        ///
        /// > int checkpoint
        /// > float p0
        ///
        /// </summary>
        _SET_CHECKPOINT_SCALE = 0x4B5B4DA5D79F1943,
        /// <summary>
        /// Sets the cylinder height of the checkpoint.
        /// 
        /// Parameters:
        /// * nearHeight - The height of the checkpoint when inside of the radius.
        /// * farHeight - The height of the checkpoint when outside of the radius.
        /// * radius - The radius of the checkpoint.
        ///
        /// > int checkpoint
        /// > float nearHeight
        /// > float farHeight
        /// > float radius
        ///
        /// </summary>
        SET_CHECKPOINT_CYLINDER_HEIGHT = 0x2707AAE9D9297D89,
        /// <summary>
        /// Sets the checkpoint color.
        ///
        /// > int checkpoint
        /// > int red
        /// > int green
        /// > int blue
        /// > int alpha
        ///
        /// </summary>
        SET_CHECKPOINT_RGBA = 0x7167371E8AD747F7,
        /// <summary>
        /// Sets the checkpoint icon color.
        ///
        /// > int checkpoint
        /// > int red
        /// > int green
        /// > int blue
        /// > int alpha
        ///
        /// </summary>
        SET_CHECKPOINT_RGBA2 = 0xB9EA40907C680580,
        /// <summary>
        /// This function can requests texture dictonaries from following RPFs:
        /// scaleform_generic.rpf
        /// scaleform_minigames.rpf
        /// scaleform_minimap.rpf
        /// scaleform_web.rpf
        /// 
        /// last param isnt a toggle
        ///
        /// > const char* textureDict
        /// > BOOL p1
        ///
        /// </summary>
        REQUEST_STREAMED_TEXTURE_DICT = 0xDFA2EF8E04127DD5,
        /// <summary>
        /// Draws a rectangle on the screen.
        /// 
        /// -x: The relative X point of the center of the rectangle. (0.0-1.0, 0.0 is the left edge of the screen, 1.0 is the right edge of the screen)
        /// 
        /// -y: The relative Y point of the center of the rectangle. (0.0-1.0, 0.0 is the top edge of the screen, 1.0 is the bottom edge of the screen)
        /// 
        /// -width: The relative width of the rectangle. (0.0-1.0, 1.0 means the whole screen width)
        /// 
        /// -height: The relative height of the rectangle. (0.0-1.0, 1.0 means the whole screen height)
        /// 
        /// -R: Red part of the color. (0-255)
        /// 
        /// -G: Green part of the color. (0-255)
        /// 
        /// -B: Blue part of the color. (0-255)
        /// 
        /// -A: Alpha part of the color. (0-255, 0 means totally transparent, 255 means totally opaque)
        /// 
        /// The total number of rectangles to be drawn in one frame is apparently limited to 399.
        /// 
        ///
        /// > float x
        /// > float y
        /// > float width
        /// > float height
        /// > int r
        /// > int g
        /// > int b
        /// > int a
        /// > BOOL p8
        ///
        /// </summary>
        DRAW_RECT = 0x3A618A217E5154F0,
        /// <summary>
        /// Sets a flag defining whether or not script draw commands should continue being drawn behind the pause menu. This is usually used for TV channels and other draw commands that are used with a world render target.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_SCRIPT_GFX_DRAW_BEHIND_PAUSEMENU = 0xC6372ECD45D73BCD,
        /// <summary>
        /// Sets the draw order for script draw commands.
        /// 
        /// Examples from decompiled scripts:
        /// GRAPHICS::SET_SCRIPT_GFX_DRAW_ORDER(7);
        /// GRAPHICS::DRAW_RECT(0.5, 0.5, 3.0, 3.0, v_4, v_5, v_6, a_0._f172, 0);
        /// 
        /// GRAPHICS::SET_SCRIPT_GFX_DRAW_ORDER(1);
        /// GRAPHICS::DRAW_RECT(0.5, 0.5, 1.5, 1.5, 0, 0, 0, 255, 0);
        ///
        /// > int drawOrder
        ///
        /// </summary>
        SET_SCRIPT_GFX_DRAW_ORDER = 0x61BB1D9B3A95D802,
        /// <summary>
        /// horizontalAlign: The horizontal alignment. This can be 67 ('C'), 76 ('L'), or 82 ('R').
        /// verticalAlign: The vertical alignment. This can be 67 ('C'), 66 ('B'), or 84 ('T').
        /// 
        /// This function anchors script draws to a side of the safe zone. This needs to be called to make the interface independent of the player's safe zone configuration.
        /// 
        /// These values are equivalent to alignX and alignY in common:/data/ui/frontend.xml, which can be used as a baseline for default alignment.
        /// 
        /// Using any other value (including 0) will result in the safe zone not being taken into account for this draw. The canonical value for this is 'I' (73).
        /// 
        /// For example, you can use SET_SCRIPT_GFX_ALIGN(0, 84) to only scale on the Y axis (to the top), but not change the X axis.
        /// 
        /// To reset the value, use RESET_SCRIPT_GFX_ALIGN.
        ///
        /// > int horizontalAlign
        /// > int verticalAlign
        ///
        /// </summary>
        SET_SCRIPT_GFX_ALIGN = 0xB8A850F20A067EB6,
        /// <summary>
        /// This function resets the alignment set using SET_SCRIPT_GFX_ALIGN and SET_SCRIPT_GFX_ALIGN_PARAMS to the default values ('I', 'I'; 0, 0, 0, 0).
        /// This should be used after having used the aforementioned functions in order to not affect any other scripts attempting to draw.
        ///
        ///
        /// </summary>
        RESET_SCRIPT_GFX_ALIGN = 0xE3A3DB414A373DAB,
        /// <summary>
        /// Sets the draw offset/calculated size for SET_SCRIPT_GFX_ALIGN. If using any alignment other than left/top, the game expects the width/height to be configured using this native in order to get a proper starting position for the draw command.
        ///
        /// > float x
        /// > float y
        /// > float w
        /// > float h
        ///
        /// </summary>
        SET_SCRIPT_GFX_ALIGN_PARAMS = 0xF5A2C681787E579D,
        /// <summary>
        /// Calculates the effective X/Y fractions when applying the values set by SET_SCRIPT_GFX_ALIGN and SET_SCRIPT_GFX_ALIGN_PARAMS
        ///
        /// > float x
        /// > float y
        /// > float* calculatedX
        /// > float* calculatedY
        ///
        /// </summary>
        _GET_SCRIPT_GFX_POSITION = 0x6DD8F5AA635EB4B2,
        /// <summary>
        /// Gets the scale of safe zone. if the safe zone size scale is max, it will return 1.0.
        ///
        ///
        /// </summary>
        GET_SAFE_ZONE_SIZE = 0xBAF107B6BB2C97F0,
        /// <summary>
        /// Draws a 2D sprite on the screen.
        /// 
        /// Parameters:
        /// textureDict - Name of texture dictionary to load texture from (e.g. "CommonMenu", "MPWeaponsCommon", etc.)
        /// 
        /// textureName - Name of texture to load from texture dictionary (e.g. "last_team_standing_icon", "tennis_icon", etc.)
        /// 
        /// screenX/Y - Screen offset (0.5 = center)
        /// scaleX/Y - Texture scaling. Negative values can be used to flip the texture on that axis. (0.5 = half)
        /// 
        /// heading - Texture rotation in degrees (default = 0.0) positive is clockwise, measured in degrees
        /// 
        /// red,green,blue - Sprite color (default = 255/255/255)
        /// 
        /// alpha - opacity level
        ///
        /// > const char* textureDict
        /// > const char* textureName
        /// > float screenX
        /// > float screenY
        /// > float width
        /// > float height
        /// > float heading
        /// > int red
        /// > int green
        /// > int blue
        /// > int alpha
        /// > BOOL p11
        ///
        /// </summary>
        DRAW_SPRITE = 0xE7FFAE5EBF23D890,
        /// <summary>
        /// Similar to _DRAW_SPRITE, but seems to be some kind of "interactive" sprite, at least used by render targets.
        /// These seem to be the only dicts ever requested by this native:
        /// 
        /// prop_screen_biker_laptop
        /// Prop_Screen_GR_Disruption
        /// Prop_Screen_TaleOfUs
        /// prop_screen_nightclub
        /// Prop_Screen_IE_Adhawk
        /// prop_screen_sm_free_trade_shipping
        /// prop_screen_hacker_truck
        /// MPDesktop
        /// Prop_Screen_Nightclub
        /// And a few others
        /// 
        ///
        /// > const char* textureDict
        /// > const char* textureName
        /// > float screenX
        /// > float screenY
        /// > float width
        /// > float height
        /// > float heading
        /// > int red
        /// > int green
        /// > int blue
        /// > int alpha
        ///
        /// </summary>
        _DRAW_INTERACTIVE_SPRITE = 0x2BC54A8188768488,
        /// <summary>
        /// Similar to DRAW_SPRITE, but allows to specify the texture coordinates used to draw the sprite.
        /// 
        /// u1, v1 - texture coordinates for the top-left corner
        /// u2, v2 - texture coordinates for the bottom-right corner
        ///
        /// > const char* textureDict
        /// > const char* textureName
        /// > float x
        /// > float y
        /// > float width
        /// > float height
        /// > float u1
        /// > float v1
        /// > float u2
        /// > float v2
        /// > float heading
        /// > int red
        /// > int green
        /// > int blue
        /// > int alpha
        ///
        /// </summary>
        _DRAW_SPRITE_UV = 0x95812F9B26074726,
        /// <summary>
        /// Example:
        /// GRAPHICS::ADD_ENTITY_ICON(a_0, "MP_Arrow");
        /// 
        /// I tried this and nothing happened...
        ///
        /// > Entity entity
        /// > const char* icon
        ///
        /// </summary>
        ADD_ENTITY_ICON = 0x9CD43EEE12BF4DD0,
        /// <summary>
        /// Sets the on-screen drawing origin for draw-functions (which is normally x=0,y=0 in the upper left corner of the screen) to a world coordinate.
        /// From now on, the screen coordinate which displays the given world coordinate on the screen is seen as x=0,y=0.
        /// 
        /// Example in C#:
        /// Vector3 boneCoord = somePed.GetBoneCoord(Bone.SKEL_Head);
        /// Function.Call(Hash.SET_DRAW_ORIGIN, boneCoord.X, boneCoord.Y, boneCoord.Z, 0);
        /// Function.Call(Hash.DRAW_SPRITE, "helicopterhud", "hud_corner", -0.01, -0.015, 0.013, 0.013, 0.0, 255, 0, 0, 200);
        /// Function.Call(Hash.DRAW_SPRITE, "helicopterhud", "hud_corner", 0.01, -0.015, 0.013, 0.013, 90.0, 255, 0, 0, 200);
        /// Function.Call(Hash.DRAW_SPRITE, "helicopterhud", "hud_corner", -0.01, 0.015, 0.013, 0.013, 270.0, 255, 0, 0, 200);
        /// Function.Call(Hash.DRAW_SPRITE, "helicopterhud", "hud_corner", 0.01, 0.015, 0.013, 0.013, 180.0, 255, 0, 0, 200);
        /// Function.Call(Hash.CLEAR_DRAW_ORIGIN);
        /// 
        /// Result: www11.pic-upload.de/19.06.15/bkqohvil2uao.jpg
        /// If the pedestrian starts walking around now, the sprites are always around her head, no matter where the head is displayed on the screen.
        /// 
        /// This function also effects the drawing of texts and other UI-elements.
        /// The effect can be reset by calling GRAPHICS::CLEAR_DRAW_ORIGIN().
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > Any p3
        ///
        /// </summary>
        SET_DRAW_ORIGIN = 0xAA0008F3BBB8F416,
        /// <summary>
        /// Resets the screen's draw-origin which was changed by the function GRAPHICS::SET_DRAW_ORIGIN(...) back to x=0,y=0.
        /// 
        /// See GRAPHICS::SET_DRAW_ORIGIN(...) for further information.
        ///
        ///
        /// </summary>
        CLEAR_DRAW_ORIGIN = 0xFF0B610F6BE0D7AF,
        /// <summary>
        /// In percentage: 0.0 - 100.0
        ///
        /// > int binkMovie
        /// > float progress
        ///
        /// </summary>
        _SET_BINK_MOVIE_TIME = 0x0CB6B3446855B57A,
        /// <summary>
        /// In percentage: 0.0 - 100.0
        ///
        /// > int binkMovie
        ///
        /// </summary>
        _GET_BINK_MOVIE_TIME = 0x8E17DDD6B9D5BF29,
        /// <summary>
        /// binkMovie: Is return value from _SET_BINK_MOVIE. Has something to do with bink volume? (audRequestedSettings::SetVolumeCurveScale)
        ///
        /// > int binkMovie
        /// > float value
        ///
        /// </summary>
        _SET_BINK_MOVIE_VOLUME = 0xAFF33B1178172223,
        /// <summary>
        /// Might be more appropriate in AUDIO?
        ///
        /// > Entity entity
        ///
        /// </summary>
        ATTACH_TV_AUDIO_TO_ENTITY = 0x845BAD77CC770633,
        /// <summary>
        /// Probably changes tvs from being a 3d audio to being "global" audio
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_TV_AUDIO_FRONTEND = 0x113D2C5DC57E1774,
        /// <summary>
        /// int screenresx,screenresy;
        /// GET_SCREEN_RESOLUTION(&screenresx,&screenresy);
        ///
        /// > int* x
        /// > int* y
        ///
        /// </summary>
        GET_SCREEN_RESOLUTION = 0x888D57E407E63624,
        /// <summary>
        /// Returns current screen resolution.
        ///
        /// > int* x
        /// > int* y
        ///
        /// </summary>
        _GET_ACTIVE_SCREEN_RESOLUTION = 0x873C9F3104101DD3,
        /// <summary>
        /// Setting Aspect Ratio Manually in game will return:
        /// 
        /// false - for Narrow format Aspect Ratios (3:2, 4:3, 5:4, etc. )
        /// true - for Wide format Aspect Ratios (5:3, 16:9, 16:10, etc. )
        /// 
        /// Setting Aspect Ratio to "Auto" in game will return "false" or "true" based on the actual set Resolution Ratio.
        ///
        ///
        /// </summary>
        GET_IS_WIDESCREEN = 0x30CF4BDA4FCB1905,
        /// <summary>
        /// false = Any resolution < 1280x720
        /// true = Any resolution >= 1280x720
        ///
        ///
        /// </summary>
        GET_IS_HIDEF = 0x84ED31191CC5D2C9,
        /// <summary>
        /// Enables Night Vision.
        /// 
        /// Example:
        /// C#: Function.Call(Hash.SET_NIGHTVISION, true);
        /// C++: GRAPHICS::SET_NIGHTVISION(true);
        /// 
        /// BOOL toggle:
        /// true = turns night vision on for your player.
        /// false = turns night vision off for your player.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_NIGHTVISION = 0x18F621F7A5B1F85D,
        /// <summary>
        /// Convert a world coordinate into its relative screen coordinate.  (WorldToScreen)
        /// 
        /// Returns a boolean; whether or not the operation was successful. It will return false if the coordinates given are not visible to the rendering camera.
        /// 
        /// 
        /// For .NET users...
        /// 
        /// VB:
        /// Public Shared Function World3DToScreen2d(pos as vector3) As Vector2
        /// 
        ///         Dim x2dp, y2dp As New Native.OutputArgument
        /// 
        ///         Native.Function.Call(Of Boolean)(Native.Hash.GET_SCREEN_COORD_FROM_WORLD_COORD , pos.x, pos.y, pos.z, x2dp, y2dp)
        ///         Return New Vector2(x2dp.GetResult(Of Single), y2dp.GetResult(Of Single))
        ///       
        ///     End Function
        /// 
        /// C#:
        /// Vector2 World3DToScreen2d(Vector3 pos)
        ///     {
        ///         var x2dp = new OutputArgument();
        ///         var y2dp = new OutputArgument();
        /// 
        ///         Function.Call<bool>(Hash.GET_SCREEN_COORD_FROM_WORLD_COORD , pos.X, pos.Y, pos.Z, x2dp, y2dp);
        ///         return new Vector2(x2dp.GetResult<float>(), y2dp.GetResult<float>());
        ///     }
        /// //USE VERY SMALL VALUES FOR THE SCALE OF RECTS/TEXT because it is dramatically larger on screen than in 3D, e.g '0.05' small.
        /// 
        /// Used to be called _WORLD3D_TO_SCREEN2D
        /// 
        /// I thought we lost you from the scene forever. It does seem however that calling SET_DRAW_ORIGIN then your natives, then ending it. Seems to work better for certain things such as keeping boxes around people for a predator missile e.g.
        ///
        /// > float worldX
        /// > float worldY
        /// > float worldZ
        /// > float* screenX
        /// > float* screenY
        ///
        /// </summary>
        GET_SCREEN_COORD_FROM_WORLD_COORD = 0x34E82F05DF2974F5,
        /// <summary>
        /// Returns the texture resolution of the passed texture dict+name.
        /// 
        /// Note: Most texture resolutions are doubled compared to the console version of the game.
        ///
        /// > const char* textureDict
        /// > const char* textureName
        ///
        /// </summary>
        GET_TEXTURE_RESOLUTION = 0x35736EE65BD00C11,
        /// <summary>
        /// Overriding ped badge texture to a passed texture. It's synced between players (even custom textures!), don't forget to request used dict on *all* clients to make it sync properly. Can be removed by passing empty strings.
        ///
        /// > Ped ped
        /// > const char* txd
        /// > const char* txn
        ///
        /// </summary>
        _OVERRIDE_PED_BADGE_TEXTURE = 0x95EB5E34F821BABE,
        /// <summary>
        /// Purpose of p0 and p1 unknown.
        ///
        /// > float p0
        /// > float p1
        /// > float fadeIn
        /// > float duration
        /// > float fadeOut
        ///
        /// </summary>
        SET_FLASH = 0x0AB84296FED9CFC6,
        /// <summary>
        /// Does not affect weapons, particles, fire/explosions, flashlights or the sun.
        /// When set to true, all emissive textures (including ped components that have light effects), street lights, building lights, vehicle lights, etc will all be turned off.
        /// 
        /// Used in Humane Labs Heist for EMP.
        /// 
        /// state: True turns off all artificial light sources in the map: buildings, street lights, car lights, etc. False turns them back on.
        ///
        /// > BOOL state
        ///
        /// </summary>
        SET_ARTIFICIAL_LIGHTS_STATE = 0x1268615ACE24D504,
        /// <summary>
        /// If "blackout" is enabled, this native allows you to ignore "blackout" for vehicles.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_ARTIFICIAL_LIGHTS_STATE_AFFECTS_VEHICLES = 0xE2B187C0939B3D32,
        /// <summary>
        /// Creates a tracked point, useful for checking the visibility of a 3D point on screen.
        ///
        ///
        /// </summary>
        CREATE_TRACKED_POINT = 0xE2C9439ED45DEA60,
        /// <summary>
        /// Wraps 0xAAE9BE70EC7C69AB with FLT_MAX as p7, Jenkins: 0x73E96210?
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float radius
        /// > float p4
        /// > float p5
        /// > float p6
        ///
        /// </summary>
        _GRASS_LOD_SHRINK_SCRIPT_AREAS = 0x6D955F6A9E0295B1,
        /// <summary>
        /// When this is set to ON, shadows only draw as you get nearer.
        /// 
        /// When OFF, they draw from a further distance.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        CASCADE_SHADOWS_ENABLE_ENTITY_TRACKER = 0x80ECBC0C856D3B0B,
        /// <summary>
        /// Possible values:
        /// "CSM_ST_POINT"
        /// "CSM_ST_LINEAR"
        /// "CSM_ST_TWOTAP"
        /// "CSM_ST_BOX3x3"
        /// "CSM_ST_BOX4x4"
        /// "CSM_ST_DITHER2_LINEAR"
        /// "CSM_ST_CUBIC"
        /// "CSM_ST_DITHER4"
        /// "CSM_ST_DITHER16"
        /// "CSM_ST_SOFT16"
        /// "CSM_ST_DITHER16_RPDB"
        /// "CSM_ST_POISSON16_RPDB_GNORM"
        /// "CSM_ST_HIGHRES_BOX4x4"
        /// "CSM_ST_CLOUDS_SIMPLE"
        /// "CSM_ST_CLOUDS_LINEAR"
        /// "CSM_ST_CLOUDS_TWOTAP"
        /// "CSM_ST_CLOUDS_BOX3x3"
        /// "CSM_ST_CLOUDS_BOX4x4"
        /// "CSM_ST_CLOUDS_DITHER2_LINEAR"
        /// "CSM_ST_CLOUDS_SOFT16"
        /// "CSM_ST_CLOUDS_DITHER16_RPDB"
        /// "CSM_ST_CLOUDS_POISSON16_RPDB_GNORM"
        ///
        /// > const char* type
        ///
        /// </summary>
        CASCADE_SHADOWS_SET_SHADOW_SAMPLE_TYPE = 0xB11D94BC55F41932,
        /// <summary>
        /// p8 seems to always be false.
        ///
        /// > float p0
        /// > float p1
        /// > float p2
        /// > float p3
        /// > float p4
        /// > float p5
        /// > float p6
        /// > float p7
        /// > BOOL p8
        ///
        /// </summary>
        GOLF_TRAIL_SET_PATH = 0x312342E1A4874F3F,
        /// <summary>
        /// 12 matches across 4 scripts. All 4 scripts were job creators.
        /// 
        /// type ranged from 0 - 2.
        /// p4 was always 0.2f. Likely scale.
        /// assuming p5 - p8 is RGBA, the graphic is always yellow (255, 255, 0, 255).
        /// 
        /// Tested but noticed nothing.
        ///
        /// > int type
        /// > float xPos
        /// > float yPos
        /// > float zPos
        /// > float p4
        /// > int red
        /// > int green
        /// > int blue
        /// > int alpha
        ///
        /// </summary>
        GOLF_TRAIL_SET_FIXED_CONTROL_POINT = 0xB1BB03742917A5D6,
        /// <summary>
        /// Only appeared in Golf & Golf_mp. Parameters were all ptrs
        ///
        /// > float p0
        /// > float p1
        /// > float p2
        /// > float p3
        /// > float p4
        ///
        /// </summary>
        GOLF_TRAIL_SET_SHADER_PARAMS = 0x9CFDD90B2B844BF7,
        /// <summary>
        /// Toggles Heatvision on/off.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        SET_SEETHROUGH = 0x7E08924259E08CE0,
        /// <summary>
        /// 0.0 = you will not be able to see people behind the walls. 50.0 and more = you will see everyone through the walls. More value is "better" view. See https://gfycat.com/FirmFlippantGourami
        /// min: 1.0
        /// max: 10000.0
        ///
        /// > float thickness
        ///
        /// </summary>
        _SEETHROUGH_SET_MAX_THICKNESS = 0x0C8FAC83902A62DF,
        /// <summary>
        /// min: 0.0
        /// max: 0.75
        ///
        /// > int index
        /// > float heatScale
        ///
        /// </summary>
        SEETHROUGH_SET_HEATSCALE = 0xD7D0B00177485411,
        /// <summary>
        /// time in ms to transition to fully blurred screen
        ///
        /// > float transitionTime
        ///
        /// </summary>
        TRIGGER_SCREENBLUR_FADE_IN = 0xA328A24AAA6B7FDC,
        /// <summary>
        /// time in ms to transition from fully blurred to normal
        ///
        /// > float transitionTime
        ///
        /// </summary>
        TRIGGER_SCREENBLUR_FADE_OUT = 0xEFACC8AEF94430D5,
        /// <summary>
        /// Returns whether screen transition to blur/from blur is running.
        ///
        ///
        /// </summary>
        IS_SCREENBLUR_FADE_RUNNING = 0x7B226C785A52A0A9,
        /// <summary>
        /// Every p2 - p5 occurrence was 0f.
        ///
        /// > BOOL p0
        /// > BOOL p1
        /// > float nearplaneOut
        /// > float nearplaneIn
        /// > float farplaneOut
        /// > float farplaneIn
        ///
        /// </summary>
        _SET_HIDOF_ENV_BLUR_PARAMS = 0xBA3D65906822BED5,
        /// <summary>
        /// GRAPHICS::START_PARTICLE_FX_NON_LOOPED_AT_COORD("scr_paleto_roof_impact", -140.8576f, 6420.789f, 41.1391f, 0f, 0f, 267.3957f, 0x3F800000, 0, 0, 0);
        /// 
        /// Axis - Invert Axis Flags
        /// 
        /// Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
        /// 
        /// 
        /// -------------------------------------------------------------------
        /// C#
        /// 
        /// Function.Call<int>(Hash.START_PARTICLE_FX_NON_LOOPED_AT_COORD, = you are calling this function.
        /// 
        /// char *effectname = This is an in-game effect name, for e.g. "scr_fbi4_trucks_crash" is used to give the effects when truck crashes etc
        /// 
        /// float x, y, z pos = this one is Simple, you just have to declare, where do you want this effect to take place at, so declare the ordinates
        /// 
        /// float xrot, yrot, zrot = Again simple? just mention the value in case if you want the effect to rotate.
        /// 
        /// float scale = is declare the scale of the effect, this may vary as per the effects for e.g 1.0f
        /// 
        /// bool xaxis, yaxis, zaxis = To bool the axis values.
        /// 
        /// example:
        /// Function.Call<int>(Hash.START_PARTICLE_FX_NON_LOOPED_AT_COORD, "scr_fbi4_trucks_crash", GTA.Game.Player.Character.Position.X, GTA.Game.Player.Character.Position.Y, GTA.Game.Player.Character.Position.Z + 4f, 0, 0, 0, 5.5f, 0, 0, 0);
        ///
        /// > const char* effectName
        /// > float xPos
        /// > float yPos
        /// > float zPos
        /// > float xRot
        /// > float yRot
        /// > float zRot
        /// > float scale
        /// > BOOL xAxis
        /// > BOOL yAxis
        /// > BOOL zAxis
        ///
        /// </summary>
        START_PARTICLE_FX_NON_LOOPED_AT_COORD = 0x25129531F77B9ED3,
        /// <summary>
        /// Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
        ///
        /// > const char* effectName
        /// > float xPos
        /// > float yPos
        /// > float zPos
        /// > float xRot
        /// > float yRot
        /// > float zRot
        /// > float scale
        /// > BOOL xAxis
        /// > BOOL yAxis
        /// > BOOL zAxis
        /// > BOOL p11
        ///
        /// </summary>
        START_NETWORKED_PARTICLE_FX_NON_LOOPED_AT_COORD = 0xF56B8137DF10135D,
        /// <summary>
        /// GRAPHICS::START_PARTICLE_FX_NON_LOOPED_ON_PED_BONE("scr_sh_bong_smoke", PLAYER::PLAYER_PED_ID(), -0.025f, 0.13f, 0f, 0f, 0f, 0f, 31086, 0x3F800000, 0, 0, 0);
        /// 
        /// Axis - Invert Axis Flags
        /// 
        /// Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
        ///
        /// > const char* effectName
        /// > Ped ped
        /// > float offsetX
        /// > float offsetY
        /// > float offsetZ
        /// > float rotX
        /// > float rotY
        /// > float rotZ
        /// > int boneIndex
        /// > float scale
        /// > BOOL axisX
        /// > BOOL axisY
        /// > BOOL axisZ
        ///
        /// </summary>
        START_PARTICLE_FX_NON_LOOPED_ON_PED_BONE = 0x0E7E72961BA18619,
        /// <summary>
        /// Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
        ///
        /// > const char* effectName
        /// > Ped ped
        /// > float offsetX
        /// > float offsetY
        /// > float offsetZ
        /// > float rotX
        /// > float rotY
        /// > float rotZ
        /// > int boneIndex
        /// > float scale
        /// > BOOL axisX
        /// > BOOL axisY
        /// > BOOL axisZ
        ///
        /// </summary>
        START_NETWORKED_PARTICLE_FX_NON_LOOPED_ON_PED_BONE = 0xA41B6A43642AC2CF,
        /// <summary>
        /// Starts a particle effect on an entity for example your player.
        /// 
        /// Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
        /// 
        /// Example:
        /// C#:
        /// Function.Call(Hash.REQUEST_NAMED_PTFX_ASSET, "scr_rcbarry2");                     Function.Call(Hash._SET_PTFX_ASSET_NEXT_CALL, "scr_rcbarry2");                             Function.Call(Hash.START_PARTICLE_FX_NON_LOOPED_ON_ENTITY, "scr_clown_appears", Game.Player.Character, 0.0, 0.0, -0.5, 0.0, 0.0, 0.0, 1.0, false, false, false);
        /// 
        /// Internally this calls the same function as GRAPHICS::START_PARTICLE_FX_NON_LOOPED_ON_PED_BONE
        /// however it uses -1 for the specified bone index, so it should be possible to start a non looped fx on an entity bone using that native
        /// 
        /// -can confirm START_PARTICLE_FX_NON_LOOPED_ON_PED_BONE does NOT work on vehicle bones.
        ///
        /// > const char* effectName
        /// > Entity entity
        /// > float offsetX
        /// > float offsetY
        /// > float offsetZ
        /// > float rotX
        /// > float rotY
        /// > float rotZ
        /// > float scale
        /// > BOOL axisX
        /// > BOOL axisY
        /// > BOOL axisZ
        ///
        /// </summary>
        START_PARTICLE_FX_NON_LOOPED_ON_ENTITY = 0x0D53A3B8DA0809D2,
        /// <summary>
        /// Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
        ///
        /// > const char* effectName
        /// > Entity entity
        /// > float offsetX
        /// > float offsetY
        /// > float offsetZ
        /// > float rotX
        /// > float rotY
        /// > float rotZ
        /// > float scale
        /// > BOOL axisX
        /// > BOOL axisY
        /// > BOOL axisZ
        ///
        /// </summary>
        START_NETWORKED_PARTICLE_FX_NON_LOOPED_ON_ENTITY = 0xC95EB1DB6E92113D,
        /// <summary>
        /// only works on some fx's, not networked
        ///
        /// > float r
        /// > float g
        /// > float b
        ///
        /// </summary>
        SET_PARTICLE_FX_NON_LOOPED_COLOUR = 0x26143A59EF48B262,
        /// <summary>
        /// Usage example for C#:
        /// 
        /// Function.Call(Hash.SET_PARTICLE_FX_NON_LOOPED_ALPHA, new InputArgument[] { 0.1f });
        /// 
        /// Note: the argument alpha ranges from 0.0f-1.0f !
        ///
        /// > float alpha
        ///
        /// </summary>
        SET_PARTICLE_FX_NON_LOOPED_ALPHA = 0x77168D722C58B2FC,
        /// <summary>
        /// GRAPHICS::START_PARTICLE_FX_LOOPED_AT_COORD("scr_fbi_falling_debris", 93.7743f, -749.4572f, 70.86904f, 0f, 0f, 0f, 0x3F800000, 0, 0, 0, 0)
        /// 
        /// 
        /// p11 seems to be always 0
        /// 
        /// Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
        ///
        /// > const char* effectName
        /// > float x
        /// > float y
        /// > float z
        /// > float xRot
        /// > float yRot
        /// > float zRot
        /// > float scale
        /// > BOOL xAxis
        /// > BOOL yAxis
        /// > BOOL zAxis
        /// > BOOL p11
        ///
        /// </summary>
        START_PARTICLE_FX_LOOPED_AT_COORD = 0xE184F4F0DC5910E7,
        /// <summary>
        /// Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
        ///
        /// > const char* effectName
        /// > Ped ped
        /// > float xOffset
        /// > float yOffset
        /// > float zOffset
        /// > float xRot
        /// > float yRot
        /// > float zRot
        /// > int boneIndex
        /// > float scale
        /// > BOOL xAxis
        /// > BOOL yAxis
        /// > BOOL zAxis
        ///
        /// </summary>
        START_PARTICLE_FX_LOOPED_ON_PED_BONE = 0xF28DA9F38CD1787C,
        /// <summary>
        /// Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
        ///
        /// > const char* effectName
        /// > Entity entity
        /// > float xOffset
        /// > float yOffset
        /// > float zOffset
        /// > float xRot
        /// > float yRot
        /// > float zRot
        /// > float scale
        /// > BOOL xAxis
        /// > BOOL yAxis
        /// > BOOL zAxis
        ///
        /// </summary>
        START_PARTICLE_FX_LOOPED_ON_ENTITY = 0x1AE42C1660FD6517,
        /// <summary>
        /// Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
        ///
        /// > const char* effectName
        /// > Entity entity
        /// > float xOffset
        /// > float yOffset
        /// > float zOffset
        /// > float xRot
        /// > float yRot
        /// > float zRot
        /// > int boneIndex
        /// > float scale
        /// > BOOL xAxis
        /// > BOOL yAxis
        /// > BOOL zAxis
        ///
        /// </summary>
        START_PARTICLE_FX_LOOPED_ON_ENTITY_BONE = 0xC6EB449E33977F0B,
        /// <summary>
        /// Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
        ///
        /// > const char* effectName
        /// > Entity entity
        /// > float xOffset
        /// > float yOffset
        /// > float zOffset
        /// > float xRot
        /// > float yRot
        /// > float zRot
        /// > float scale
        /// > BOOL xAxis
        /// > BOOL yAxis
        /// > BOOL zAxis
        /// > Any p12
        /// > Any p13
        /// > Any p14
        /// > Any p15
        ///
        /// </summary>
        START_NETWORKED_PARTICLE_FX_LOOPED_ON_ENTITY = 0x6F60E89A7B64EE1D,
        /// <summary>
        /// Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
        ///
        /// > const char* effectName
        /// > Entity entity
        /// > float xOffset
        /// > float yOffset
        /// > float zOffset
        /// > float xRot
        /// > float yRot
        /// > float zRot
        /// > int boneIndex
        /// > float scale
        /// > BOOL xAxis
        /// > BOOL yAxis
        /// > BOOL zAxis
        /// > Any p13
        /// > Any p14
        /// > Any p15
        /// > Any p16
        ///
        /// </summary>
        START_NETWORKED_PARTICLE_FX_LOOPED_ON_ENTITY_BONE = 0xDDE23F30CC5A0F03,
        /// <summary>
        /// p1 is always 0 in the native scripts
        ///
        /// > int ptfxHandle
        /// > BOOL p1
        ///
        /// </summary>
        STOP_PARTICLE_FX_LOOPED = 0x8F75998877616996,
        /// <summary>
        /// only works on some fx's
        /// 
        /// p4 = 0
        ///
        /// > int ptfxHandle
        /// > float r
        /// > float g
        /// > float b
        /// > BOOL p4
        ///
        /// </summary>
        SET_PARTICLE_FX_LOOPED_COLOUR = 0x7F8F65877F88783B,
        /// <summary>
        /// Creates cartoon effect when Michel smokes the weed
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        ENABLE_CLOWN_BLOOD_VFX = 0xD821490579791273,
        /// <summary>
        /// Creates a motion-blur sort of effect, this native does not seem to work, however by using the `START_SCREEN_EFFECT` native with `DrugsMichaelAliensFight` as the effect parameter, you should be able to get the effect.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        ENABLE_ALIEN_BLOOD_VFX = 0x9DCE1F0F78260875,
        /// <summary>
        /// From the b678d decompiled scripts:
        /// 
        ///  GRAPHICS::_SET_PTFX_ASSET_NEXT_CALL("FM_Mission_Controler");
        ///  GRAPHICS::_SET_PTFX_ASSET_NEXT_CALL("scr_apartment_mp");
        ///  GRAPHICS::_SET_PTFX_ASSET_NEXT_CALL("scr_indep_fireworks");
        ///  GRAPHICS::_SET_PTFX_ASSET_NEXT_CALL("scr_mp_cig_plane");
        ///  GRAPHICS::_SET_PTFX_ASSET_NEXT_CALL("scr_mp_creator");
        ///  GRAPHICS::_SET_PTFX_ASSET_NEXT_CALL("scr_ornate_heist");
        ///  GRAPHICS::_SET_PTFX_ASSET_NEXT_CALL("scr_prison_break_heist_station");
        /// 
        /// Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
        ///
        /// > const char* name
        ///
        /// </summary>
        USE_PARTICLE_FX_ASSET = 0x6C38AF3693A69A91,
        /// <summary>
        /// Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
        ///
        /// > const char* oldAsset
        /// > const char* newAsset
        ///
        /// </summary>
        SET_PARTICLE_FX_OVERRIDE = 0xEA1E2D93F6F75ED9,
        /// <summary>
        /// Resets the effect of SET_PARTICLE_FX_OVERRIDE
        /// 
        /// Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
        ///
        /// > const char* name
        ///
        /// </summary>
        RESET_PARTICLE_FX_OVERRIDE = 0x89C8553DD3274AAE,
        /// <summary>
        /// Fades nearby decals within the range specified
        ///
        /// > Any p0
        /// > Any p1
        /// > Any p2
        /// > Any p3
        /// > Any p4
        ///
        /// </summary>
        FADE_DECALS_IN_RANGE = 0xD77EDADB0420E6E0,
        /// <summary>
        /// Removes all decals in range from a position, it includes the bullet holes, blood pools, petrol...
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float range
        ///
        /// </summary>
        REMOVE_DECALS_IN_RANGE = 0x5D6B2D4830A67C62,
        /// <summary>
        /// decal types:
        /// 
        /// public enum DecalTypes
        /// {
        ///     splatters_blood = 1010,
        ///     splatters_blood_dir = 1015,
        ///     splatters_blood_mist = 1017,
        ///     splatters_mud = 1020,
        ///     splatters_paint = 1030,
        ///     splatters_water = 1040,
        ///     splatters_water_hydrant = 1050,
        ///     splatters_blood2 = 1110,
        ///     weapImpact_metal = 4010,
        ///     weapImpact_concrete = 4020,
        ///     weapImpact_mattress = 4030,
        ///     weapImpact_mud = 4032,
        ///     weapImpact_wood = 4050,
        ///     weapImpact_sand = 4053,
        ///     weapImpact_cardboard = 4040,
        ///     weapImpact_melee_glass = 4100,
        ///     weapImpact_glass_blood = 4102,
        ///     weapImpact_glass_blood2 = 4104,
        ///     weapImpact_shotgun_paper = 4200,
        ///     weapImpact_shotgun_mattress,
        ///     weapImpact_shotgun_metal,
        ///     weapImpact_shotgun_wood,
        ///     weapImpact_shotgun_dirt,
        ///     weapImpact_shotgun_tvscreen,
        ///     weapImpact_shotgun_tvscreen2,
        ///     weapImpact_shotgun_tvscreen3,
        ///     weapImpact_melee_concrete = 4310,
        ///     weapImpact_melee_wood = 4312,
        ///     weapImpact_melee_metal = 4314,
        ///     burn1 = 4421,
        ///     burn2,
        ///     burn3,
        ///     burn4,
        ///     burn5,
        ///     bang_concrete_bang = 5000,
        ///     bang_concrete_bang2,
        ///     bang_bullet_bang,
        ///     bang_bullet_bang2 = 5004,
        ///     bang_glass = 5031,
        ///     bang_glass2,
        ///     solidPool_water = 9000,
        ///     solidPool_blood,
        ///     solidPool_oil,
        ///     solidPool_petrol,
        ///     solidPool_mud,
        ///     porousPool_water,
        ///     porousPool_blood,
        ///     porousPool_oil,
        ///     porousPool_petrol,
        ///     porousPool_mud,
        ///     porousPool_water_ped_drip,
        ///     liquidTrail_water = 9050
        /// }
        ///
        /// > int decalType
        /// > float posX
        /// > float posY
        /// > float posZ
        /// > float p4
        /// > float p5
        /// > float p6
        /// > float p7
        /// > float p8
        /// > float p9
        /// > float width
        /// > float height
        /// > float rCoef
        /// > float gCoef
        /// > float bCoef
        /// > float opacity
        /// > float timeout
        /// > BOOL p17
        /// > BOOL p18
        /// > BOOL p19
        ///
        /// </summary>
        ADD_DECAL = 0xB302244A1839BDAD,
        /// <summary>
        /// boneIndex is always chassis_dummy in the scripts. The x/y/z params are location relative to the chassis bone.
        ///
        /// > Vehicle vehicle
        /// > Ped ped
        /// > int boneIndex
        /// > float x1
        /// > float x2
        /// > float x3
        /// > float y1
        /// > float y2
        /// > float y3
        /// > float z1
        /// > float z2
        /// > float z3
        /// > float scale
        /// > Any p13
        /// > int alpha
        ///
        /// </summary>
        ADD_VEHICLE_CREW_EMBLEM = 0x428BDCB9DA58DA53,
        /// <summary>
        /// Used with 'NG_filmnoir_BW{01,02}' timecycles and the "NOIR_FILTER_SOUNDS" audioref.
        ///
        ///
        /// </summary>
        _REGISTER_NOIR_SCREEN_EFFECT_THIS_FRAME = 0xA44FF770DFBC5DAE,
        /// <summary>
        /// Forces footstep tracks on all surfaces.
        /// 
        /// USE_/USING_*
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_FORCE_PED_FOOTSTEPS_TRACKS = 0xAEEDAD1420C65CC0,
        /// <summary>
        /// Forces vehicle trails on all surfaces.
        /// 
        /// USE_/USING_*
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_FORCE_VEHICLE_TRAILS = 0x4CC7F0FEA5283FE0,
        /// <summary>
        /// Only one match in the scripts:
        /// 
        /// GRAPHICS::PRESET_INTERIOR_AMBIENT_CACHE("int_carrier_hanger");
        ///
        /// > const char* timecycleModifierName
        ///
        /// </summary>
        PRESET_INTERIOR_AMBIENT_CACHE = 0xD7021272EB0A451E,
        /// <summary>
        /// Loads the specified timecycle modifier. Modifiers are defined separately in another file (e.g. "timecycle_mods_1.xml")
        /// 
        /// Parameters:
        /// modifierName - The modifier to load (e.g. "V_FIB_IT3", "scanline_cam", etc.)
        /// 
        /// Full list of timecycle modifiers by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/timecycleModifiers.json
        ///
        /// > const char* modifierName
        ///
        /// </summary>
        SET_TIMECYCLE_MODIFIER = 0x2C933ABF17A1DF41,
        /// <summary>
        /// Full list of timecycle modifiers by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/timecycleModifiers.json
        ///
        /// > const char* modifierName
        /// > float transition
        ///
        /// </summary>
        SET_TRANSITION_TIMECYCLE_MODIFIER = 0x3BCF567485E1971C,
        /// <summary>
        /// Only use for this in the PC scripts is:
        /// 
        /// if (GRAPHICS::GET_TIMECYCLE_MODIFIER_INDEX() != -1)
        /// 
        /// For a full list, see here: pastebin.com/cnk7FTF2
        ///
        ///
        /// </summary>
        GET_TIMECYCLE_MODIFIER_INDEX = 0xFDF3D97C674AFB66,
        /// <summary>
        /// Full list of timecycle modifiers by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/timecycleModifiers.json
        ///
        /// > const char* modifierName
        ///
        /// </summary>
        _SET_EXTRA_TIMECYCLE_MODIFIER = 0x5096FD9CCB49056D,
        /// <summary>
        /// Clears the secondary timecycle modifier usually set with _SET_EXTRA_TIMECYCLE_MODIFIER
        ///
        ///
        /// </summary>
        _CLEAR_EXTRA_TIMECYCLE_MODIFIER = 0x92CCC17A7A2285DA,
        /// <summary>
        /// See _0xFDF3D97C674AFB66 for use, works the same just for the secondary timecycle modifier.
        /// Returns an integer representing the Timecycle modifier
        ///
        ///
        /// </summary>
        _GET_EXTRA_TIMECYCLE_MODIFIER_INDEX = 0xBB0527EC6341496D,
        /// <summary>
        /// ENABLE_*
        /// The same as SET_TIMECYCLE_MODIFIER_STRENGTH but for the secondary timecycle modifier.
        ///
        /// > float strength
        ///
        /// </summary>
        _SET_EXTRA_TIMECYCLE_MODIFIER_STRENGTH = 0x2C328AF17210F009,
        /// <summary>
        /// Resets the extra timecycle modifier strength normally set with 0x2C328AF17210F009
        ///
        ///
        /// </summary>
        _RESET_EXTRA_TIMECYCLE_MODIFIER_STRENGTH = 0x2BF72AD5B41AA739,
        /// <summary>
        /// Another REQUEST_SCALEFORM_MOVIE equivalent.
        ///
        /// > const char* scaleformName
        ///
        /// </summary>
        _REQUEST_SCALEFORM_MOVIE_2 = 0x65E7E78842E74CDB,
        /// <summary>
        /// Similar to REQUEST_SCALEFORM_MOVIE, but seems to be some kind of "interactive" scaleform movie?
        /// 
        /// These seem to be the only scaleforms ever requested by this native:
        /// "breaking_news"
        /// "desktop_pc"
        /// "ECG_MONITOR"
        /// "Hacking_PC"
        /// "TEETH_PULLING"
        /// 
        /// Note: Unless this hash is out-of-order, this native is next-gen only.
        /// 
        ///
        /// > const char* scaleformName
        ///
        /// </summary>
        _REQUEST_SCALEFORM_MOVIE_INTERACTIVE = 0xBD06C611BB9048C2,
        /// <summary>
        /// Only values used in the scripts are:
        /// 
        /// "heist_mp"
        /// "heistmap_mp"
        /// "instructional_buttons"
        /// "heist_pre"
        ///
        /// > const char* scaleformName
        ///
        /// </summary>
        HAS_SCALEFORM_MOVIE_FILENAME_LOADED = 0x0C1C5D756FB5F337,
        /// <summary>
        /// This native is used in some casino scripts to fit the scaleform in the rendertarget.
        ///
        /// > int scaleformHandle
        /// > BOOL toggle
        ///
        /// </summary>
        _SET_SCALEFORM_FIT_RENDERTARGET = 0xE6A9F00D4240B519,
        /// <summary>
        /// unk is not used so no need
        ///
        /// > int scaleform
        /// > int red
        /// > int green
        /// > int blue
        /// > int alpha
        /// > int unk
        ///
        /// </summary>
        DRAW_SCALEFORM_MOVIE_FULLSCREEN = 0x0DF606929C105BE1,
        /// <summary>
        /// Calls the Scaleform function.
        ///
        /// > int scaleform
        /// > const char* method
        ///
        /// </summary>
        CALL_SCALEFORM_MOVIE_METHOD = 0xFBD96D87AC96D533,
        /// <summary>
        /// Calls the Scaleform function and passes the parameters as floats.
        /// 
        /// The number of parameters passed to the function varies, so the end of the parameter list is represented by -1.0.
        ///
        /// > int scaleform
        /// > const char* methodName
        /// > float param1
        /// > float param2
        /// > float param3
        /// > float param4
        /// > float param5
        ///
        /// </summary>
        CALL_SCALEFORM_MOVIE_METHOD_WITH_NUMBER = 0xD0837058AE2E4BEE,
        /// <summary>
        /// Calls the Scaleform function and passes the parameters as strings.
        /// 
        /// The number of parameters passed to the function varies, so the end of the parameter list is represented by 0 (NULL).
        ///
        /// > int scaleform
        /// > const char* methodName
        /// > const char* param1
        /// > const char* param2
        /// > const char* param3
        /// > const char* param4
        /// > const char* param5
        ///
        /// </summary>
        CALL_SCALEFORM_MOVIE_METHOD_WITH_STRING = 0x51BC1ED3CC44E8F7,
        /// <summary>
        /// Calls the Scaleform function and passes both float and string parameters (in their respective order).
        /// 
        /// The number of parameters passed to the function varies, so the end of the float parameters is represented by -1.0, and the end of the string parameters is represented by 0 (NULL).
        /// 
        /// NOTE: The order of parameters in the function prototype is important! All float parameters must come first, followed by the string parameters.
        /// 
        /// Examples:
        /// // function MY_FUNCTION(floatParam1, floatParam2, stringParam)
        /// GRAPHICS::_CALL_SCALEFORM_MOVIE_FUNCTION_MIXED_PARAMS(scaleform, "MY_FUNCTION", 10.0, 20.0, -1.0, -1.0, -1.0, "String param", 0, 0, 0, 0);
        /// 
        /// // function MY_FUNCTION_2(floatParam, stringParam1, stringParam2)
        /// GRAPHICS::_CALL_SCALEFORM_MOVIE_FUNCTION_MIXED_PARAMS(scaleform, "MY_FUNCTION_2", 10.0, -1.0, -1.0, -1.0, -1.0, "String param #1", "String param #2", 0, 0, 0);
        ///
        /// > int scaleform
        /// > const char* methodName
        /// > float floatParam1
        /// > float floatParam2
        /// > float floatParam3
        /// > float floatParam4
        /// > float floatParam5
        /// > const char* stringParam1
        /// > const char* stringParam2
        /// > const char* stringParam3
        /// > const char* stringParam4
        /// > const char* stringParam5
        ///
        /// </summary>
        CALL_SCALEFORM_MOVIE_METHOD_WITH_NUMBER_AND_STRING = 0xEF662D8D57E290B1,
        /// <summary>
        /// Pushes a function from the Hud component Scaleform onto the stack. Same behavior as GRAPHICS::BEGIN_SCALEFORM_MOVIE_METHOD, just a hud component id instead of a Scaleform.
        /// 
        /// Known components:
        /// 19 - MP_RANK_BAR
        /// 20 - HUD_DIRECTOR_MODE
        /// 
        /// This native requires more research - all information can be found inside of 'hud.gfx'. Using a decompiler, the different components are located under "scripts\__Packages\com\rockstargames\gtav\hud\hudComponents" and "scripts\__Packages\com\rockstargames\gtav\Multiplayer".
        ///
        /// > int hudComponent
        /// > const char* methodName
        ///
        /// </summary>
        BEGIN_SCALEFORM_SCRIPT_HUD_MOVIE_METHOD = 0x98C494FD5BDFBFD5,
        /// <summary>
        /// Push a function from the Scaleform onto the stack
        /// 
        ///
        /// > int scaleform
        /// > const char* methodName
        ///
        /// </summary>
        BEGIN_SCALEFORM_MOVIE_METHOD = 0xF6E48914C7A8694E,
        /// <summary>
        /// Starts frontend (pause menu) scaleform movie methods.
        /// This can be used when you want to make custom frontend menus, and customize things like images or text in the menus etc.
        /// Use `BEGIN_SCALEFORM_MOVIE_METHOD_ON_FRONTEND_HEADER` for header scaleform functions.
        ///
        /// > const char* methodName
        ///
        /// </summary>
        BEGIN_SCALEFORM_MOVIE_METHOD_ON_FRONTEND = 0xAB58C27C2E6123C6,
        /// <summary>
        /// Starts frontend (pause menu) scaleform movie methods for header options.
        /// Use `BEGIN_SCALEFORM_MOVIE_METHOD_ON_FRONTEND` to customize the content inside the frontend menus.
        ///
        /// > const char* methodName
        ///
        /// </summary>
        BEGIN_SCALEFORM_MOVIE_METHOD_ON_FRONTEND_HEADER = 0xB9449845F73F5E9C,
        /// <summary>
        /// Pops and calls the Scaleform function on the stack
        ///
        ///
        /// </summary>
        END_SCALEFORM_MOVIE_METHOD = 0xC6796A8FFA375E53,
        /// <summary>
        /// methodReturn: The return value of this native: END_SCALEFORM_MOVIE_METHOD_RETURN_VALUE
        /// Returns true if the return value of a scaleform function is ready to be collected (using GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_STRING or GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_INT).
        ///
        /// > int methodReturn
        ///
        /// </summary>
        IS_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_READY = 0x768FF8961BA904D6,
        /// <summary>
        /// methodReturn: The return value of this native: END_SCALEFORM_MOVIE_METHOD_RETURN_VALUE
        /// Used to get a return value from a scaleform function. Returns an int in the same way GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_STRING returns a string.
        ///
        /// > int methodReturn
        ///
        /// </summary>
        GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_INT = 0x2DE7EFA66B906036,
        /// <summary>
        /// methodReturn: The return value of this native: END_SCALEFORM_MOVIE_METHOD_RETURN_VALUE
        ///
        /// > int methodReturn
        ///
        /// </summary>
        _GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_BOOL = 0xD80A80346A45D761,
        /// <summary>
        /// methodReturn: The return value of this native: END_SCALEFORM_MOVIE_METHOD_RETURN_VALUE
        /// Used to get a return value from a scaleform function. Returns a string in the same way GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_INT returns an int.
        ///
        /// > int methodReturn
        ///
        /// </summary>
        GET_SCALEFORM_MOVIE_METHOD_RETURN_VALUE_STRING = 0xE1E258829A885245,
        /// <summary>
        /// Pushes an integer for the Scaleform function onto the stack.
        ///
        /// > int value
        ///
        /// </summary>
        SCALEFORM_MOVIE_METHOD_ADD_PARAM_INT = 0xC3D0841A0CC546A6,
        /// <summary>
        /// Pushes a float for the Scaleform function onto the stack.
        ///
        /// > float value
        ///
        /// </summary>
        SCALEFORM_MOVIE_METHOD_ADD_PARAM_FLOAT = 0xD69736AAE04DB51A,
        /// <summary>
        /// Pushes a boolean for the Scaleform function onto the stack.
        ///
        /// > BOOL value
        ///
        /// </summary>
        SCALEFORM_MOVIE_METHOD_ADD_PARAM_BOOL = 0xC58424BA936EB458,
        /// <summary>
        /// Called prior to adding a text component to the UI. After doing so, GRAPHICS::END_TEXT_COMMAND_SCALEFORM_STRING is called.
        /// 
        /// Examples:
        /// GRAPHICS::BEGIN_TEXT_COMMAND_SCALEFORM_STRING("NUMBER");
        /// HUD::ADD_TEXT_COMPONENT_INTEGER(MISC::ABSI(a_1));
        /// GRAPHICS::END_TEXT_COMMAND_SCALEFORM_STRING();
        /// 
        /// GRAPHICS::BEGIN_TEXT_COMMAND_SCALEFORM_STRING("STRING");
        /// HUD::_ADD_TEXT_COMPONENT_STRING(a_2);
        /// GRAPHICS::END_TEXT_COMMAND_SCALEFORM_STRING();
        /// 
        /// GRAPHICS::BEGIN_TEXT_COMMAND_SCALEFORM_STRING("STRTNM2");
        /// HUD::_0x17299B63C7683A2B(v_3);
        /// HUD::_0x17299B63C7683A2B(v_4);
        /// GRAPHICS::END_TEXT_COMMAND_SCALEFORM_STRING();
        /// 
        /// GRAPHICS::BEGIN_TEXT_COMMAND_SCALEFORM_STRING("STRTNM1");
        /// HUD::_0x17299B63C7683A2B(v_3);
        /// GRAPHICS::END_TEXT_COMMAND_SCALEFORM_STRING();
        ///
        /// > const char* componentType
        ///
        /// </summary>
        BEGIN_TEXT_COMMAND_SCALEFORM_STRING = 0x80338406F3475E55,
        /// <summary>
        /// Same as END_TEXT_COMMAND_SCALEFORM_STRING but does not perform HTML conversion for text tokens.
        ///
        ///
        /// </summary>
        _END_TEXT_COMMAND_SCALEFORM_STRING_2 = 0xAE4E8157D9ECF087,
        /// <summary>
        /// Same as SCALEFORM_MOVIE_METHOD_ADD_PARAM_TEXTURE_NAME_STRING
        /// Both SCALEFORM_MOVIE_METHOD_ADD_PARAM_TEXTURE_NAME_STRING / _SCALEFORM_MOVIE_METHOD_ADD_PARAM_TEXTURE_NAME_STRING_2 works, but _SCALEFORM_MOVIE_METHOD_ADD_PARAM_TEXTURE_NAME_STRING_2 is usually used for "name" (organisation, players..).
        ///
        /// > const char* string
        ///
        /// </summary>
        _SCALEFORM_MOVIE_METHOD_ADD_PARAM_TEXTURE_NAME_STRING_2 = 0x77FE3402004CD1B0,
        /// <summary>
        /// All calls to this native are preceded by calls to GRAPHICS::_0x61BB1D9B3A95D802 and GRAPHICS::_0xC6372ECD45D73BCD, respectively.
        /// 
        /// "act_cinema.ysc", line 1483:
        /// HUD::SET_HUD_COMPONENT_POSITION(15, 0.0, -0.0375);
        /// HUD::SET_TEXT_RENDER_ID(l_AE);
        /// GRAPHICS::_0x61BB1D9B3A95D802(4);
        /// GRAPHICS::_0xC6372ECD45D73BCD(1);
        /// if (GRAPHICS::_0x0AD973CA1E077B60(${movie_arthouse})) {
        ///     GRAPHICS::DRAW_TV_CHANNEL(0.5, 0.5, 0.7375, 1.0, 0.0, 255, 255, 255, 255);
        /// } else { 
        ///     GRAPHICS::DRAW_TV_CHANNEL(0.5, 0.5, 1.0, 1.0, 0.0, 255, 255, 255, 255);
        /// }
        /// 
        /// "am_mp_property_int.ysc", line 102545:
        /// if (ENTITY::DOES_ENTITY_EXIST(a_2._f3)) {
        ///     if (HUD::IS_NAMED_RENDERTARGET_LINKED(ENTITY::GET_ENTITY_MODEL(a_2._f3))) {
        ///         HUD::SET_TEXT_RENDER_ID(a_2._f1);
        ///         GRAPHICS::_0x61BB1D9B3A95D802(4);
        ///         GRAPHICS::_0xC6372ECD45D73BCD(1);
        ///         GRAPHICS::DRAW_TV_CHANNEL(0.5, 0.5, 1.0, 1.0, 0.0, 255, 255, 255, 255);
        ///         if (GRAPHICS::GET_TV_CHANNEL() == -1) {
        ///             sub_a8fa5(a_2, 1);
        ///         } else { 
        ///             sub_a8fa5(a_2, 1);
        ///             GRAPHICS::ATTACH_TV_AUDIO_TO_ENTITY(a_2._f3);
        ///         }
        ///         HUD::SET_TEXT_RENDER_ID(HUD::GET_DEFAULT_SCRIPT_RENDERTARGET_RENDER_ID());
        ///     }
        /// }
        /// 
        ///
        /// > float xPos
        /// > float yPos
        /// > float xScale
        /// > float yScale
        /// > float rotation
        /// > int red
        /// > int green
        /// > int blue
        /// > int alpha
        ///
        /// </summary>
        DRAW_TV_CHANNEL = 0xFDDC2B4ED3C69DF0,
        /// <summary>
        /// Loads specified video sequence into the TV Channel
        /// TV_Channel ranges from 0-2
        /// VideoSequence can be any of the following:
        /// "PL_STD_CNT" CNT Standard Channel
        /// "PL_STD_WZL" Weazel Standard Channel
        /// "PL_LO_CNT"
        /// "PL_LO_WZL"
        /// "PL_SP_WORKOUT"
        /// "PL_SP_INV" - Jay Norris Assassination Mission Fail
        /// "PL_SP_INV_EXP" - Jay Norris Assassination Mission Success
        /// "PL_LO_RS" - Righteous Slaughter Ad
        /// "PL_LO_RS_CUTSCENE" - Righteous Slaughter Cut-scene
        /// "PL_SP_PLSH1_INTRO"
        /// "PL_LES1_FAME_OR_SHAME"
        /// "PL_STD_WZL_FOS_EP2"
        /// "PL_MP_WEAZEL" - Weazel Logo on loop
        /// "PL_MP_CCTV" - Generic CCTV loop
        /// 
        /// Restart:
        /// 0=video sequence continues as normal
        /// 1=sequence restarts from beginning every time that channel is selected
        /// 
        /// 
        /// The above playlists work as intended, and are commonly used, but there are many more playlists, as seen in `tvplaylists.xml`. A pastebin below outlines all playlists, they will be surronded by the name tag I.E. (<Name>PL_STD_CNT</Name> = PL_STD_CNT).
        /// https://pastebin.com/zUzGB6h7
        ///
        /// > int tvChannel
        /// > const char* playlistName
        /// > BOOL restart
        ///
        /// </summary>
        SET_TV_CHANNEL_PLAYLIST = 0xF7B38B8305F1FE8B,
        /// <summary>
        /// IS_*
        ///
        /// > Hash videoCliphash
        ///
        /// </summary>
        _IS_TV_PLAYLIST_ITEM_PLAYING = 0x0AD973CA1E077B60,
        /// <summary>
        /// All presets can be found in common\data\ui\uiscenes.meta
        ///
        /// > const char* presetName
        ///
        /// </summary>
        UI3DSCENE_PUSH_PRESET = 0xF1CEA8A4198D8E9A,
        /// <summary>
        /// This native enables/disables the gold putting grid display (https://i.imgur.com/TC6cku6.png).
        /// This requires these two natives to be called as well to configure the grid: `0x1c4fc5752bcd8e48` and `0x5ce62918f8d703c7`.
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        TERRAINGRID_ACTIVATE = 0xA356990E161C9E65,
        /// <summary>
        /// This native is used along with these two natives: `0xa356990e161c9e65` and `0x5ce62918f8d703c7`.
        /// This native configures the location, size, rotation, normal height, and the difference ratio between min, normal and max.
        /// 
        /// All those natives combined they will output something like this: https://i.imgur.com/TC6cku6.png
        ///
        /// > float x
        /// > float y
        /// > float z
        /// > float p3
        /// > float rotation
        /// > float p5
        /// > float width
        /// > float height
        /// > float p8
        /// > float scale
        /// > float glowIntensity
        /// > float normalHeight
        /// > float heightDiff
        ///
        /// </summary>
        TERRAINGRID_SET_PARAMS = 0x1C4FC5752BCD8E48,
        /// <summary>
        /// This native is used along with these two natives: `0xa356990e161c9e65` and `0x1c4fc5752bcd8e48`.
        /// This native sets the colors for the golf putting grid. the 'min...' values are for the lower areas that the grid covers, the 'max...' values are for the higher areas that the grid covers, all remaining values are for the 'normal' ground height.
        /// All those natives combined they will output something like this: https://i.imgur.com/TC6cku6.png
        ///
        /// > int lowR
        /// > int lowG
        /// > int lowB
        /// > int lowAlpha
        /// > int r
        /// > int g
        /// > int b
        /// > int alpha
        /// > int highR
        /// > int highG
        /// > int highB
        /// > int highAlpha
        ///
        /// </summary>
        TERRAINGRID_SET_COLOURS = 0x5CE62918F8D703C7,
        /// <summary>
        /// duration - is how long to play the effect for in milliseconds. If 0, it plays the default length
        /// if loop is true, the effect won't stop until you call ANIMPOSTFX_STOP on it. (only loopable effects)
        /// 
        /// Full list of animpostFX / screen effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animPostFxNamesCompact.json
        ///
        /// > const char* effectName
        /// > int duration
        /// > BOOL looped
        ///
        /// </summary>
        ANIMPOSTFX_PLAY = 0x2206BF9A37B7F724,
        /// <summary>
        /// See ANIMPOSTFX_PLAY
        /// 
        /// Full list of animpostFX / screen effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animPostFxNamesCompact.json
        ///
        /// > const char* effectName
        ///
        /// </summary>
        ANIMPOSTFX_STOP = 0x068E835A1D0DC0E3,
        /// <summary>
        /// See ANIMPOSTFX_PLAY
        /// 
        /// Full list of animpostFX / screen effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animPostFxNamesCompact.json
        ///
        /// > const char* effectName
        ///
        /// </summary>
        _ANIMPOSTFX_GET_UNK = 0xE35B38A27E8E7179,
        /// <summary>
        /// Returns whether the specified effect is active.
        /// See ANIMPOSTFX_PLAY
        /// 
        /// Full list of animpostFX / screen effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animPostFxNamesCompact.json
        ///
        /// > const char* effectName
        ///
        /// </summary>
        ANIMPOSTFX_IS_RUNNING = 0x36AD3E690DA5ACEB,
        /// <summary>
        /// Stops ALL currently playing effects.
        ///
        ///
        /// </summary>
        ANIMPOSTFX_STOP_ALL = 0xB4EDDC19532BFB85,
        /// <summary>
        /// Stops the effect and sets a value (bool) in its data (+0x199) to false.
        /// See ANIMPOSTFX_PLAY
        /// 
        /// Full list of animpostFX / screen effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/animPostFxNamesCompact.json
        ///
        /// > const char* effectName
        ///
        /// </summary>
        _ANIMPOSTFX_STOP_AND_DO_UNK = 0xD2209BE128B5418C,
        /// <summary>
        /// 2 matches across 2 scripts. Only showed in appcamera & appmedia. Both were 0.
        ///
        /// > Any p0
        ///
        /// </summary>
        _0x2A893980E96B659A = 0x2A893980E96B659A,
        /// <summary>
        /// This function is hard-coded to always return 0.
        ///
        /// > Any p0
        ///
        /// </summary>
        _0xE791DF1F73ED2C8B = 0xE791DF1F73ED2C8B,
        /// <summary>
        /// This function is hard-coded to always return 0.
        ///
        /// > Any p0
        ///
        /// </summary>
        _0xEC72C258667BE5EA = 0xEC72C258667BE5EA,
        /// <summary>
        /// This does not move an existing checkpoint... so wtf.
        ///
        /// > int checkpoint
        /// > float posX
        /// > float posY
        /// > float posZ
        /// > float unkX
        /// > float unkY
        /// > float unkZ
        ///
        /// </summary>
        _0xF51D36185993515D = 0xF51D36185993515D,
        /// <summary>
        /// SET_CHECKPOINT_*
        ///
        /// > int checkpoint
        ///
        /// </summary>
        _0xFCF6788FC4860CD4 = 0xFCF6788FC4860CD4,
        /// <summary>
        /// Unknown. Called after creating a checkpoint (type: 51) in the creators.
        ///
        /// > int checkpoint
        ///
        /// </summary>
        _0x615D3925E87A3B26 = 0x615D3925E87A3B26,
        /// <summary>
        /// Used in arcade games and Beam hack minigame in Doomsday Heist. I will most certainly dive into this to try replicate arcade games.
        /// x position must be between 0.0 and 1.0 (1.0 being the most right side of the screen)
        /// y position must be between 0.0 and 1.0 (1.0 being the most bottom side of the screen)
        /// width 0.0 - 1.0 is the reasonable amount generally
        /// height 0.0 - 1.0 is the reasonable amount generally
        /// p6 almost always 0.0
        /// p11 seems to be unknown but almost always 0 int
        ///
        /// > const char* textureDict
        /// > const char* textureName
        /// > float x
        /// > float y
        /// > float width
        /// > float height
        /// > float p6
        /// > int red
        /// > int green
        /// > int blue
        /// > int alpha
        /// > Any p11
        ///
        /// </summary>
        _0x2D3B147AFAD49DE0 = 0x2D3B147AFAD49DE0,
        /// <summary>
        /// AD*
        ///
        ///
        /// </summary>
        _0xEFABC7722293DA7C = 0xEFABC7722293DA7C,
        /// <summary>
        /// This function is hard-coded to always return 0.
        ///
        /// > Any p0
        /// > Any p1
        /// > Any p2
        /// > Any p3
        ///
        /// </summary>
        _0xBE197EAA669238F4 = 0xBE197EAA669238F4,
        /// <summary>
        /// This native does absolutely nothing, just a nullsub
        ///
        /// > Any p0
        ///
        /// </summary>
        _0x61F95E5BB3E0A8C6 = 0x61F95E5BB3E0A8C6,
        /// <summary>
        /// GOLF_TRAIL_SET_*
        ///
        /// > BOOL p0
        ///
        /// </summary>
        _0xC0416B061F2B7E5E = 0xC0416B061F2B7E5E,
        /// <summary>
        /// Setter for 0xE59343E9E96529E7
        /// 
        /// SET_M*
        ///
        /// > float p0
        ///
        /// </summary>
        _0xB3C641F3630BF6DA = 0xB3C641F3630BF6DA,
        /// <summary>
        /// Getter for 0xB3C641F3630BF6DA
        /// 
        /// GET_M*
        ///
        ///
        /// </summary>
        _0xE59343E9E96529E7 = 0xE59343E9E96529E7,
        /// <summary>
        /// SET_F*
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _0x6A51F78772175A51 = 0x6A51F78772175A51,
        /// <summary>
        /// Sets an unknown value related to timecycles.
        ///
        /// > int unk
        ///
        /// </summary>
        _0xE3E2C1B4C59DBC77 = 0xE3E2C1B4C59DBC77,
        /// <summary>
        /// Used only once in the scripts (taxi_clowncar)
        /// 
        /// SET_PARTICLE_FX_*
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _0x8CDE909A0370BB3A = 0x8CDE909A0370BB3A,
        /// <summary>
        /// DISABLE_*
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _0x5F6DF3D92271E8A1 = 0x5F6DF3D92271E8A1,
        /// <summary>
        /// SET_PARTICLE_FX_*
        /// 
        /// Full list of particle effect dictionaries and effects by DurtyFree: https://github.com/DurtyFree/gta-v-data-dumps/blob/master/particleEffectsCompact.json
        ///
        /// > const char* p0
        ///
        /// </summary>
        _0xBA3D194057C79A7B = 0xBA3D194057C79A7B,
        /// <summary>
        /// FORCE_*
        ///
        /// > BOOL p0
        ///
        /// </summary>
        _0x9B079E5221D984D3 = 0x9B079E5221D984D3,
        /// <summary>
        /// DISABLE_S*
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _0x02369D5C8A51FDCF = 0x02369D5C8A51FDCF,
        /// <summary>
        /// REQUEST_*
        ///
        ///
        /// </summary>
        _0x98EDF76A7271E4F2 = 0x98EDF76A7271E4F2,
        /// <summary>
        /// SET_TRA*
        ///
        /// > float p0
        ///
        /// </summary>
        _0x1CBA05AE7BD7EE05 = 0x1CBA05AE7BD7EE05,
        /// <summary>
        /// val is 1-20 (0 will return false)
        /// SET_???
        ///
        /// > int val
        ///
        /// </summary>
        _0x2FCB133CA50A49EB = 0x2FCB133CA50A49EB,
        /// <summary>
        /// val is 1-20. Return is related to INSTRUCTIONAL_BUTTONS, COLOUR_SWITCHER_02, etc?
        ///
        /// > int val
        ///
        /// </summary>
        _0x86255B1FC929E33E = 0x86255B1FC929E33E,
        /// <summary>
        /// SET_TV_???
        ///
        /// > Any p0
        ///
        /// </summary>
        _0xD1C55B110E4DF534 = 0xD1C55B110E4DF534,
        /// <summary>
        /// GET_CURRENT_*
        ///
        ///
        /// </summary>
        _0x30432A0118736E00 = 0x30432A0118736E00,
        /// <summary>
        /// It's called after 0xD3A10FC7FD8D98CD and 0xF1CEA8A4198D8E9A
        /// 
        /// presetName was always "CELEBRATION_WINNER"
        /// All presets can be found in common\data\ui\uiscenes.meta
        /// 
        /// UI3DSCENE_*
        ///
        /// > const char* presetName
        /// > Ped ped
        /// > int p2
        /// > float posX
        /// > float posY
        /// > float posZ
        ///
        /// </summary>
        _0x98C4FE6EC34154CA = 0x98C4FE6EC34154CA,
        /// <summary>
        /// UI3DSCENE_*
        ///
        ///
        /// </summary>
        _0x7A42B2E236E71415 = 0x7A42B2E236E71415,
        /// <summary>
        /// UI3DSCENE_*
        ///
        /// > BOOL toggle
        ///
        /// </summary>
        _0x108BE26959A9D9BB = 0x108BE26959A9D9BB,
        DRAW_DEBUG_LINE = 0x7FDFADE676AA3CB0,
        DRAW_DEBUG_BOX = 0x083A2CA4F2E573BD,
        SET_BACKFACECULLING = 0x23BA6B0C2AD7B0D3,
        BEGIN_TAKE_MISSION_CREATOR_PHOTO = 0x1DD2139A9A20DCE8,
        GET_STATUS_OF_TAKE_MISSION_CREATOR_PHOTO = 0x90A78ECAA4E78453,
        FREE_MEMORY_FOR_MISSION_CREATOR_PHOTO = 0x0A46AF8A78DC5E0A,
        LOAD_MISSION_CREATOR_PHOTO = 0x4862437A486F91B0,
        GET_STATUS_OF_LOAD_MISSION_CREATOR_PHOTO = 0x1670F8D05056F257,
        BEGIN_TAKE_HIGH_QUALITY_PHOTO = 0xA67C35C56EB1BD9D,
        GET_STATUS_OF_TAKE_HIGH_QUALITY_PHOTO = 0x0D6CA79EEEBD8CA3,
        FREE_MEMORY_FOR_HIGH_QUALITY_PHOTO = 0xD801CC02177FA3F1,
        GET_STATUS_OF_SAVE_HIGH_QUALITY_PHOTO = 0x0C0C4E81E1AC60A0,
        FREE_MEMORY_FOR_LOW_QUALITY_PHOTO = 0x6A12D88881435DCA,
        DRAW_LOW_QUALITY_PHOTO_TO_PHONE = 0x1072F115DAB0717E,
        GET_CURRENT_NUMBER_OF_CLOUD_PHOTOS = 0x473151EBC762C6DA,
        _DRAW_LIGHT_WITH_RANGE_AND_SHADOW = 0xF49E9A9716A04595,
        DRAW_LIGHT_WITH_RANGE = 0xF2A1B2771A01DBD4,
        _DRAW_SPOT_LIGHT_WITH_SHADOW = 0x5BCA583A583194DB,
        FADE_UP_PED_LIGHT = 0xC9B18B4619F48F7B,
        UPDATE_LIGHTS_ON_ENTITY = 0xDEADC0DEDEADC0DE,
        _DRAW_MARKER_2 = 0xE82728F0DE75D13A,
        _SET_CHECKPOINT_ICON_SCALE = 0x44621483FF966526,
        DELETE_CHECKPOINT = 0xF5ED37F54CD4D52E,
        DONT_RENDER_IN_GAME_UI = 0x22A249A53034450A,
        FORCE_RENDER_IN_GAME_UI = 0xDC459CFA0CCE245B,
        HAS_STREAMED_TEXTURE_DICT_LOADED = 0x0145F696AAAAD2E4,
        SET_STREAMED_TEXTURE_DICT_AS_NO_LONGER_NEEDED = 0xBE2CACCF5A8AA805,
        SET_ENTITY_ICON_VISIBILITY = 0xE0E8BEECCA96BA31,
        SET_ENTITY_ICON_COLOR = 0x1D5F595CCAE2E238,
        _SET_BINK_MOVIE = 0x338D9F609FD632DB,
        _PLAY_BINK_MOVIE = 0x70D2CC8A542A973C,
        _STOP_BINK_MOVIE = 0x63606A61DE68898A,
        _RELEASE_BINK_MOVIE = 0x04D950EEFA4EED8C,
        _DRAW_BINK_MOVIE = 0x7118E83EEB9F7238,
        _SET_BINK_MOVIE_UNK_2 = 0xF816F2933752322D,
        _SET_BINK_SHOULD_SKIP = 0x6805D58CAA427B72,
        LOAD_MOVIE_MESH_SET = 0xB66064452270E8F1,
        RELEASE_MOVIE_MESH_SET = 0xEB119AA014E89183,
        QUERY_MOVIE_MESH_SET_STATE = 0x9B6E70C5CEEF4EEB,
        _GET_ASPECT_RATIO = 0xF1307EF624A80D87,
        GET_REQUESTINGNIGHTVISION = 0x35FB78DC42B7BD21,
        GET_USINGNIGHTVISION = 0x2202A3F42C8E5F79,
        SET_NOISEOVERIDE = 0xE787BF1C5CF823C9,
        SET_NOISINESSOVERIDE = 0xCB6A7C3BB17A0C67,
        DISABLE_OCCLUSION_THIS_FRAME = 0x3669F1B198DCAA4F,
        SET_TRACKED_POINT_INFO = 0x164ECBB3CF750CB0,
        IS_TRACKED_POINT_VISIBLE = 0xC45CCDAAC9221CA8,
        DESTROY_TRACKED_POINT = 0xB25DC90BAD56CA42,
        _GRASS_LOD_RESET_SCRIPT_AREAS = 0x302C91AB2D477F7E,
        CASCADE_SHADOWS_INIT_SESSION = 0x03FC694AE06C5A20,
        CASCADE_SHADOWS_SET_CASCADE_BOUNDS = 0xD2936CAB8B58FCBD,
        CASCADE_SHADOWS_SET_CASCADE_BOUNDS_SCALE = 0x5F0F3F56635809EF,
        CASCADE_SHADOWS_SET_ENTITY_TRACKER_SCALE = 0x5E9DAF5A20F15908,
        CASCADE_SHADOWS_CLEAR_SHADOW_SAMPLE_TYPE = 0x27CB772218215325,
        CASCADE_SHADOWS_SET_AIRCRAFT_MODE = 0x6DDBF9DFFC4AC080,
        CASCADE_SHADOWS_SET_DYNAMIC_DEPTH_MODE = 0xD39D13C9FEBF0511,
        CASCADE_SHADOWS_SET_DYNAMIC_DEPTH_VALUE = 0x02AC28F3A01FA04A,
        GOLF_TRAIL_SET_ENABLED = 0xA51C4B86B71652AE,
        GOLF_TRAIL_SET_RADIUS = 0x2485D34E50A22E84,
        GOLF_TRAIL_SET_COLOUR = 0x12995F2E53FFA601,
        GOLF_TRAIL_SET_TESSELLATION = 0xDBAA5EC848BA2D46,
        GOLF_TRAIL_SET_FACING = 0x06F761EA47C1D3ED,
        GOLF_TRAIL_GET_MAX_HEIGHT = 0xA4819F5E23E2FFAD,
        GOLF_TRAIL_GET_VISUAL_CONTROL_POINT = 0xA4664972A9B8F8BA,
        GET_USINGSEETHROUGH = 0x44B80ABAB9D80BD3,
        SEETHROUGH_RESET = 0x70A64C0234EF522C,
        _SEETHROUGH_SET_FADE_START_DISTANCE = 0xA78DE25577300BA1,
        _SEETHROUGH_SET_FADE_END_DISTANCE = 0x9D75795B9DC6EBBF,
        _SEETHROUGH_GET_MAX_THICKNESS = 0x43DBAE39626CE83F,
        _SEETHROUGH_SET_NOISE_AMOUNT_MIN = 0xFF5992E1C9E65D05,
        _SEETHROUGH_SET_NOISE_AMOUNT_MAX = 0xFEBFBFDFB66039DE,
        _SEETHROUGH_SET_HI_LIGHT_INTENSITY = 0x19E50EB6E33E1D28,
        _SEETHROUGH_SET_HI_LIGHT_NOISE = 0x1636D7FC127B10D2,
        _SEETHROUGH_SET_COLOR_NEAR = 0x1086127B3A63505E,
        TOGGLE_PLAYER_DAMAGE_OVERLAY = 0xE63D7C6EECECB66B,
        DISABLE_SCREENBLUR_FADE = 0xDE81239437E8C5A8,
        GET_SCREENBLUR_FADE_CURRENT_TIME = 0x5CCABFFCA31DDE33,
        TOGGLE_PAUSED_RENDERPHASES = 0xDFC252D8A3E15AB7,
        GET_TOGGLE_PAUSED_RENDERPHASES_STATUS = 0xEB3DAC2C86001E5E,
        RESET_PAUSED_RENDERPHASES = 0xE1C8709406F2C41C,
        _START_NETWORKED_PARTICLE_FX_NON_LOOPED_ON_ENTITY_BONE = 0x02B1F2A72E0F5325,
        REMOVE_PARTICLE_FX = 0xC401503DFE8D53CF,
        REMOVE_PARTICLE_FX_FROM_ENTITY = 0xB8FEAEEBCC127425,
        REMOVE_PARTICLE_FX_IN_RANGE = 0xDD19FA1C6D657305,
        DOES_PARTICLE_FX_LOOPED_EXIST = 0x74AFEF0D2E1E409B,
        SET_PARTICLE_FX_LOOPED_OFFSETS = 0xF7DDEBEC43483C43,
        SET_PARTICLE_FX_LOOPED_EVOLUTION = 0x5F0C4B5B1C393BE2,
        SET_PARTICLE_FX_LOOPED_ALPHA = 0x726845132380142E,
        SET_PARTICLE_FX_LOOPED_SCALE = 0xB44250AAA456492D,
        SET_PARTICLE_FX_LOOPED_FAR_CLIP_DIST = 0xDCB194B85EF7B541,
        SET_PARTICLE_FX_CAM_INSIDE_VEHICLE = 0xEEC4047028426510,
        SET_PARTICLE_FX_CAM_INSIDE_NONPLAYER_VEHICLE = 0xACEE6F360FC1F6B6,
        SET_PARTICLE_FX_SHOOTOUT_BOAT = 0x96EF97DAEB89BEF5,
        SET_PARTICLE_FX_BULLET_IMPACT_SCALE = 0x27E32866E9A5C416,
        WASH_DECALS_IN_RANGE = 0x9C30613D50A6ADEF,
        WASH_DECALS_FROM_VEHICLE = 0x5B712761429DBC14,
        REMOVE_DECALS_FROM_OBJECT = 0xCCF71CBDDF5B6CB9,
        REMOVE_DECALS_FROM_OBJECT_FACING = 0xA6F6F70FDC6D144C,
        REMOVE_DECALS_FROM_VEHICLE = 0xE91F1B65F2B48D57,
        ADD_PETROL_DECAL = 0x4F5212C7AD880DF8,
        START_PETROL_TRAIL_DECALS = 0x99AC7F0D8B9C893D,
        ADD_PETROL_TRAIL_DECAL_INFO = 0x967278682CB6967A,
        END_PETROL_TRAIL_DECALS = 0x0A123435A26C36CD,
        REMOVE_DECAL = 0xED3F346429CCD659,
        IS_DECAL_ALIVE = 0xC694D74949CAFD0C,
        GET_DECAL_WASH_LEVEL = 0x323F647679A09103,
        SET_DISABLE_DECAL_RENDERING_THIS_FRAME = 0x4B5CFC83122DF602,
        GET_IS_PETROL_DECAL_IN_RANGE = 0x2F09F7976C512404,
        PATCH_DECAL_DIFFUSE_MAP = 0x8A35C742130C6080,
        UNPATCH_DECAL_DIFFUSE_MAP = 0xB7ED70C49521A61D,
        MOVE_VEHICLE_DECALS = 0x84C8D7C2D30D3280,
        REMOVE_VEHICLE_CREW_EMBLEM = 0xD2300034310557E4,
        GET_VEHICLE_CREW_EMBLEM_REQUEST_STATE = 0xFE26117A5841B2FF,
        DOES_VEHICLE_HAVE_CREW_EMBLEM = 0x060D935D3981A275,
        OVERRIDE_INTERIOR_SMOKE_NAME = 0x2A2A52824DB96700,
        OVERRIDE_INTERIOR_SMOKE_LEVEL = 0x1600FD8CF72EBC12,
        OVERRIDE_INTERIOR_SMOKE_END = 0xEFB55E7C25D3B3BE,
        DISABLE_VEHICLE_DISTANTLIGHTS = 0xC9F98AC1884E73A2,
        _DISABLE_SCRIPT_AMBIENT_EFFECTS = 0xEFD97FF47B745B8D,
        SET_TIMECYCLE_MODIFIER_STRENGTH = 0x82E7FFCD5B2326B3,
        CLEAR_TIMECYCLE_MODIFIER = 0x0F07E7745A236711,
        GET_TIMECYCLE_TRANSITION_MODIFIER_INDEX = 0x459FD2C8D0AB78BC,
        PUSH_TIMECYCLE_MODIFIER = 0x58F735290861E6B4,
        POP_TIMECYCLE_MODIFIER = 0x3C8938D7D872211E,
        SET_CURRENT_PLAYER_TCMODIFIER = 0xBBF327DED94E4DEB,
        SET_PLAYER_TCMODIFIER_TRANSITION = 0xBDEB86F4D5809204,
        SET_NEXT_PLAYER_TCMODIFIER = 0xBF59707B3E5ED531,
        ADD_TCMODIFIER_OVERRIDE = 0x1A8E2C8B9CF4549C,
        REMOVE_TCMODIFIER_OVERRIDE = 0x15E33297C3E8DC60,
        REQUEST_SCALEFORM_MOVIE = 0x11FE353CF9733E6F,
        REQUEST_SCALEFORM_MOVIE_INSTANCE = 0xC514489CFB8AF806,
        HAS_SCALEFORM_MOVIE_LOADED = 0x85F01B8D5B90570E,
        HAS_SCALEFORM_CONTAINER_MOVIE_LOADED_INTO_PARENT = 0x8217150E1217EBFD,
        SET_SCALEFORM_MOVIE_AS_NO_LONGER_NEEDED = 0x1D132D614DD86811,
        SET_SCALEFORM_MOVIE_TO_USE_SYSTEM_TIME = 0x6D8EB211944DCE08,
        DRAW_SCALEFORM_MOVIE = 0x54972ADAF0294A93,
        DRAW_SCALEFORM_MOVIE_FULLSCREEN_MASKED = 0xCF537FDE4FBD4CE5,
        DRAW_SCALEFORM_MOVIE_3D = 0x87D51D72255D4E78,
        DRAW_SCALEFORM_MOVIE_3D_SOLID = 0x1CE592FDC749D6F5,
        END_SCALEFORM_MOVIE_METHOD_RETURN_VALUE = 0xC50AA39A577AF886,
        END_TEXT_COMMAND_SCALEFORM_STRING = 0x362E2D3FE93A9959,
        SCALEFORM_MOVIE_METHOD_ADD_PARAM_TEXTURE_NAME_STRING = 0xBA7148484BD90365,
        SCALEFORM_MOVIE_METHOD_ADD_PARAM_PLAYER_NAME_STRING = 0xE83A3E3557A56640,
        DOES_LATEST_BRIEF_STRING_EXIST = 0x5E657EF1099EDD65,
        SCALEFORM_MOVIE_METHOD_ADD_PARAM_LATEST_BRIEF_STRING = 0xEC52C631A1831C03,
        REQUEST_SCALEFORM_SCRIPT_HUD_MOVIE = 0x9304881D6F6537EA,
        HAS_SCALEFORM_SCRIPT_HUD_MOVIE_LOADED = 0xDF6E5987D2B4D140,
        REMOVE_SCALEFORM_SCRIPT_HUD_MOVIE = 0xF44A5456AC3F4F97,
        SET_TV_CHANNEL = 0xBAABBB23EB6E484E,
        GET_TV_CHANNEL = 0xFC1E275A90D39995,
        SET_TV_VOLUME = 0x2982BF73F66E9DDC,
        GET_TV_VOLUME = 0x2170813D3DD8661B,
        SET_TV_CHANNEL_PLAYLIST_AT_HOUR = 0x2201C576FACAEBE8,
        CLEAR_TV_CHANNEL_PLAYLIST = 0xBEB3D46BB7F043C0,
        _IS_PLAYLIST_UNK = 0x1F710BFF7DAE6261,
        ENABLE_MOVIE_KEYFRAME_WAIT = 0x74C180030FDE4B69,
        ENABLE_MOVIE_SUBTITLES = 0x873FA65C778AD970,
        UI3DSCENE_IS_AVAILABLE = 0xD3A10FC7FD8D98CD,
        _0xC5C8F970D4EDFF71 = 0xC5C8F970D4EDFF71,
        _0x7FA5D82B8F58EC06 = 0x7FA5D82B8F58EC06,
        _0x5B0316762AFD4A64 = 0x5B0316762AFD4A64,
        _0x346EF3ECAAAB149E = 0x346EF3ECAAAB149E,
        _0x1BBC135A4D25EDDE = 0x1BBC135A4D25EDDE,
        _0xF3F776ADA161E47D = 0xF3F776ADA161E47D,
        _0xADD6627C4D325458 = 0xADD6627C4D325458,
        _0x759650634F07B6B4 = 0x759650634F07B6B4,
        _0xCB82A0BF0E3E3265 = 0xCB82A0BF0E3E3265,
        _0x4AF92ACD3141D96C = 0x4AF92ACD3141D96C,
        _0x9641588DAB93B4B5 = 0x9641588DAB93B4B5,
        _0x393BD2275CEB7793 = 0x393BD2275CEB7793,
        _0xDB1EA9411C8911EC = 0xDB1EA9411C8911EC,
        _0x3C788E7F6438754D = 0x3C788E7F6438754D,
        _0xB2EBE8CBC58B90E9 = 0xB2EBE8CBC58B90E9,
        _0xEF398BEEE4EF45F9 = 0xEF398BEEE4EF45F9,
        _0x814AF7DCAACC597B = 0x814AF7DCAACC597B,
        _0x43FA7CBE20DAB219 = 0x43FA7CBE20DAB219,
        _0xE2892E7E55D7073A = 0xE2892E7E55D7073A,
        _0xC35A6D07C93802B2 = 0xC35A6D07C93802B2,
        _0xAE51BC858F32BA66 = 0xAE51BC858F32BA66,
        _0x649C97D52332341A = 0x649C97D52332341A,
        _0x2C42340F916C5930 = 0x2C42340F916C5930,
        _0x14FC5833464340A8 = 0x14FC5833464340A8,
        _0x0218BA067D249DEA = 0x0218BA067D249DEA,
        _0x1612C45F9E3E0D44 = 0x1612C45F9E3E0D44,
        _0x5DEBD9C4DC995692 = 0x5DEBD9C4DC995692,
        _0xAAE9BE70EC7C69AB = 0xAAE9BE70EC7C69AB,
        _0x36F6626459D91457 = 0x36F6626459D91457,
        _0x259BA6D4E6F808F1 = 0x259BA6D4E6F808F1,
        _0x25FC3E33A31AD0C9 = 0x25FC3E33A31AD0C9,
        _0x0AE73D8DF3A762B2 = 0x0AE73D8DF3A762B2,
        _0xCA465D9CC0D231BA = 0xCA465D9CC0D231BA,
        _0x851CD923176EBA7C = 0x851CD923176EBA7C,
        _0xB569F41F3E7E83A4 = 0xB569F41F3E7E83A4,
        _0x7AC24EAB6D74118D = 0x7AC24EAB6D74118D,
        _0xBCEDB009461DA156 = 0xBCEDB009461DA156,
        _0x27FEB5254759CDE3 = 0x27FEB5254759CDE3,
        _0xBA0127DA25FD54C9 = 0xBA0127DA25FD54C9,
        _0x2A251AA48B2B46DB = 0x2A251AA48B2B46DB,
        _0x908311265D42A820 = 0x908311265D42A820,
        _0xCFD16F0DB5A3535C = 0xCFD16F0DB5A3535C,
        _0x2B40A97646381508 = 0x2B40A97646381508,
        _0xBB90E12CAC1DAB25 = 0xBB90E12CAC1DAB25,
        _0xCA4AE345A153D573 = 0xCA4AE345A153D573,
        _0x54E22EA2C1956A8D = 0x54E22EA2C1956A8D,
        _0x949F397A288B28B3 = 0x949F397A288B28B3,
        _0x5DBF05DB5926D089 = 0x5DBF05DB5926D089,
        _0xA46B73FAA3460AE1 = 0xA46B73FAA3460AE1,
        _0xF78B803082D4386F = 0xF78B803082D4386F,
        _0xD9454B5752C857DC = 0xD9454B5752C857DC,
        _0x27CFB1B1E078CB2D = 0x27CFB1B1E078CB2D,
        _0x82ACC484FFA3B05F = 0x82ACC484FFA3B05F,
        _0x0E4299C549F0D1F1 = 0x0E4299C549F0D1F1,
        _0x46D1A61A21F566FC = 0x46D1A61A21F566FC,
        _0x03300B57FCAC6DDB = 0x03300B57FCAC6DDB,
        _0x98D18905BF723B99 = 0x98D18905BF723B99,
        _0x32F34FF7F617643B = 0x32F34FF7F617643B,
        _0xD1C7CB175E012964 = 0xD1C7CB175E012964,
    }
}