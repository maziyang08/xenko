﻿#if SILICONSTUDIO_XENKO_GRAPHICS_API_OPENGLES
//------------------------------------------------------------------------------
// <auto-generated>
//     Xenko Effect Compiler File Generated:
//     Effect [ParticleBatch]
//
//     Command Line: C:\Dev\paradox\sources\engine\SiliconStudio.Xenko.Particles\Shaders.Bytecodes\..\..\..\..\Bin\Windows-Direct3D11\SiliconStudio.Assets.CompilerApp.exe --profile=Windows-OpenGLES --output-path=C:\Dev\paradox\sources\engine\SiliconStudio.Xenko.Particles\Shaders.Bytecodes\obj\app_data --build-path=C:\Dev\paradox\sources\engine\SiliconStudio.Xenko.Particles\Shaders.Bytecodes\obj\build_app_data --package-file=Graphics.xkpkg
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiliconStudio.Xenko.Particles 
{
    public partial class ParticleBatch
    {
        private static readonly byte[] binaryBytecodeSRgbTex0 = new byte[] {
1, 192, 254, 239, 0, 6, 0, 0, 0, 19, 80, 97, 114, 116, 105, 99, 108, 101, 66, 97, 116, 99, 104, 83, 104, 97, 100, 101, 114, 1, 93, 97, 150, 197, 18, 126, 173, 228, 251, 120, 178, 3, 144, 175, 205, 28, 12, 80, 97, 114, 116, 105, 99, 108, 101, 66, 97, 115, 101, 1, 185, 253, 244, 151, 133, 
81, 163, 241, 55, 136, 113, 143, 36, 98, 220, 163, 10, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 1, 5, 53, 66, 125, 168, 40, 169, 95, 115, 110, 141, 195, 22, 140, 101, 223, 16, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 83, 116, 114, 101, 97, 109, 1, 252, 149, 143, 37, 199, 91, 237, 
34, 31, 232, 194, 67, 83, 107, 157, 134, 9, 84, 101, 120, 116, 117, 114, 105, 110, 103, 1, 90, 7, 144, 56, 150, 36, 71, 168, 103, 101, 181, 74, 154, 179, 90, 203, 12, 67, 111, 108, 111, 114, 85, 116, 105, 108, 105, 116, 121, 1, 77, 232, 0, 156, 217, 55, 64, 161, 231, 217, 185, 133, 139, 109, 
6, 40, 0, 0, 2, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 32, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 46, 88, 101, 110, 107, 111, 70, 108, 105, 112, 82, 101, 110, 100, 101, 114, 116, 97, 114, 103, 101, 116, 0, 0, 0, 0, 0, 21, 88, 101, 110, 107, 111, 70, 108, 105, 112, 82, 
101, 110, 100, 101, 114, 116, 97, 114, 103, 101, 116, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 11, 79, 112, 101, 110, 103, 108, 70, 108, 97, 103, 115, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 28, 80, 97, 114, 116, 105, 99, 108, 101, 66, 97, 115, 101, 46, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 0, 0, 0, 0, 0, 20, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 95, 105, 
100, 55, 50, 3, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 4, 0, 0, 0, 1, 0, 23, 80, 97, 114, 116, 105, 99, 108, 101, 66, 97, 115, 101, 46, 67, 111, 108, 111, 114, 83, 99, 97, 108, 101, 0, 0, 0, 
0, 0, 15, 67, 111, 108, 111, 114, 83, 99, 97, 108, 101, 95, 105, 100, 55, 51, 1, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 4, 0, 0, 0, 1, 0, 26, 80, 97, 114, 116, 105, 99, 108, 101, 66, 97, 115, 
101, 46, 65, 108, 112, 104, 97, 65, 100, 100, 105, 116, 105, 118, 101, 0, 0, 0, 0, 0, 18, 65, 108, 112, 104, 97, 65, 100, 100, 105, 116, 105, 118, 101, 95, 105, 100, 55, 52, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 
0, 0, 0, 1, 0, 0, 0, 1, 0, 27, 80, 97, 114, 116, 105, 99, 108, 101, 66, 97, 115, 101, 46, 67, 111, 108, 111, 114, 73, 110, 116, 101, 110, 115, 105, 116, 121, 0, 0, 0, 0, 0, 19, 67, 111, 108, 111, 114, 73, 110, 116, 101, 110, 115, 105, 116, 121, 95, 105, 100, 55, 53, 0, 0, 
0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 30, 80, 97, 114, 116, 105, 99, 108, 101, 66, 97, 115, 101, 46, 82, 101, 110, 100, 101, 114, 70, 108, 97, 103, 83, 119, 105, 122, 122, 108, 101, 0, 
0, 0, 0, 0, 22, 82, 101, 110, 100, 101, 114, 70, 108, 97, 103, 83, 119, 105, 122, 122, 108, 101, 95, 105, 100, 55, 54, 0, 0, 0, 0, 19, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 7, 71, 108, 
111, 98, 97, 108, 115, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 18, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 48, 0, 0, 0, 0, 0, 13, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 9, 0, 0, 
0, 7, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 17, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 83, 97, 109, 112, 108, 101, 114, 0, 0, 0, 0, 0, 12, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 8, 0, 0, 0, 10, 0, 0, 0, 0, 0, 
0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 11, 79, 112, 101, 110, 103, 108, 70, 108, 97, 103, 115, 0, 0, 0, 0, 0, 11, 79, 112, 101, 110, 103, 108, 70, 108, 97, 103, 115, 10, 0, 0, 0, 25, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 7, 71, 108, 
111, 98, 97, 108, 115, 0, 0, 0, 0, 0, 7, 71, 108, 111, 98, 97, 108, 115, 10, 0, 0, 0, 25, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 21, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 
16, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 127, 255, 255, 255, 127, 127, 0, 17, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 83, 97, 109, 112, 108, 101, 114, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 2, 0, 
0, 0, 0, 1, 0, 0, 0, 0, 0, 4, 0, 0, 160, 3, 117, 110, 105, 102, 111, 114, 109, 32, 102, 108, 111, 97, 116, 32, 88, 101, 110, 107, 111, 70, 108, 105, 112, 82, 101, 110, 100, 101, 114, 116, 97, 114, 103, 101, 116, 59, 10, 117, 110, 105, 102, 111, 114, 109, 32, 109, 97, 116, 52, 32, 
77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 95, 105, 100, 55, 50, 59, 10, 118, 97, 114, 121, 105, 110, 103, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 97, 116, 116, 114, 105, 98, 117, 116, 101, 32, 118, 101, 99, 52, 32, 97, 
95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 59, 10, 97, 116, 116, 114, 105, 98, 117, 116, 101, 32, 118, 101, 99, 50, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 32, 40, 41, 10, 123, 10, 32, 32, 104, 105, 103, 104, 112, 32, 118, 
101, 99, 52, 32, 116, 109, 112, 118, 97, 114, 95, 49, 59, 10, 32, 32, 116, 109, 112, 118, 97, 114, 95, 49, 32, 61, 32, 40, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 32, 42, 32, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 95, 105, 100, 55, 50, 41, 59, 
10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 120, 119, 32, 61, 32, 116, 109, 112, 118, 97, 114, 95, 49, 46, 120, 119, 59, 10, 32, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 32, 61, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 32, 32, 
103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 122, 32, 61, 32, 40, 40, 116, 109, 112, 118, 97, 114, 95, 49, 46, 122, 32, 42, 32, 50, 46, 48, 41, 32, 45, 32, 116, 109, 112, 118, 97, 114, 95, 49, 46, 119, 41, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 
46, 121, 32, 61, 32, 40, 88, 101, 110, 107, 111, 70, 108, 105, 112, 82, 101, 110, 100, 101, 114, 116, 97, 114, 103, 101, 116, 32, 42, 32, 116, 109, 112, 118, 97, 114, 95, 49, 46, 121, 41, 59, 10, 125, 10, 10, 206, 4, 35, 118, 101, 114, 115, 105, 111, 110, 32, 51, 48, 48, 32, 101, 115, 10, 
108, 97, 121, 111, 117, 116, 40, 115, 116, 100, 49, 52, 48, 41, 32, 117, 110, 105, 102, 111, 114, 109, 32, 71, 108, 111, 98, 97, 108, 115, 32, 123, 10, 32, 32, 109, 97, 116, 52, 32, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 95, 105, 100, 55, 50, 59, 10, 32, 32, 
118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 83, 99, 97, 108, 101, 95, 105, 100, 55, 51, 59, 10, 32, 32, 102, 108, 111, 97, 116, 32, 65, 108, 112, 104, 97, 65, 100, 100, 105, 116, 105, 118, 101, 95, 105, 100, 55, 52, 59, 10, 32, 32, 102, 108, 111, 97, 116, 32, 67, 111, 108, 111, 114, 73, 
110, 116, 101, 110, 115, 105, 116, 121, 95, 105, 100, 55, 53, 59, 10, 32, 32, 117, 105, 110, 116, 32, 82, 101, 110, 100, 101, 114, 70, 108, 97, 103, 83, 119, 105, 122, 122, 108, 101, 95, 105, 100, 55, 54, 59, 10, 125, 59, 10, 108, 97, 121, 111, 117, 116, 40, 115, 116, 100, 49, 52, 48, 41, 32, 
117, 110, 105, 102, 111, 114, 109, 32, 79, 112, 101, 110, 103, 108, 70, 108, 97, 103, 115, 32, 123, 10, 32, 32, 102, 108, 111, 97, 116, 32, 88, 101, 110, 107, 111, 70, 108, 105, 112, 82, 101, 110, 100, 101, 114, 116, 97, 114, 103, 101, 116, 59, 10, 125, 59, 10, 111, 117, 116, 32, 118, 101, 99, 50, 
32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 105, 110, 32, 118, 101, 99, 52, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 59, 10, 105, 110, 32, 118, 101, 99, 50, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 118, 111, 105, 100, 32, 109, 97, 105, 
110, 32, 40, 41, 10, 123, 10, 32, 32, 104, 105, 103, 104, 112, 32, 118, 101, 99, 52, 32, 116, 109, 112, 118, 97, 114, 95, 49, 59, 10, 32, 32, 116, 109, 112, 118, 97, 114, 95, 49, 32, 61, 32, 40, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 32, 42, 32, 77, 97, 116, 114, 105, 120, 
84, 114, 97, 110, 115, 102, 111, 114, 109, 95, 105, 100, 55, 50, 41, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 120, 119, 32, 61, 32, 116, 109, 112, 118, 97, 114, 95, 49, 46, 120, 119, 59, 10, 32, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 32, 61, 
32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 122, 32, 61, 32, 40, 40, 116, 109, 112, 118, 97, 114, 95, 49, 46, 122, 32, 42, 32, 50, 46, 48, 41, 32, 45, 32, 116, 109, 112, 118, 97, 114, 95, 49, 46, 119, 
41, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 121, 32, 61, 32, 40, 88, 101, 110, 107, 111, 70, 108, 105, 112, 82, 101, 110, 100, 101, 114, 116, 97, 114, 103, 101, 116, 32, 42, 32, 116, 109, 112, 118, 97, 114, 95, 49, 46, 121, 41, 59, 10, 125, 10, 10, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 217, 80, 227, 7, 144, 164, 164, 26, 120, 213, 157, 86, 95, 210, 20, 206, 0, 5, 0, 0, 0, 0, 0, 16, 0, 0, 193, 11, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 104, 105, 103, 104, 112, 32, 102, 108, 111, 97, 116, 59, 13, 
10, 13, 10, 115, 116, 114, 117, 99, 116, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 
114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 80, 83, 95, 79, 85, 84, 80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 
59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 86, 83, 95, 79, 85, 84, 80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 
118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 59, 13, 10, 125, 59, 13, 10, 47, 47, 32, 66, 101, 103, 105, 110, 32, 99, 98, 117, 102, 102, 101, 114, 32, 79, 112, 101, 110, 103, 108, 70, 108, 97, 103, 115, 13, 10, 117, 110, 105, 102, 111, 114, 109, 32, 102, 
108, 111, 97, 116, 32, 88, 101, 110, 107, 111, 70, 108, 105, 112, 82, 101, 110, 100, 101, 114, 116, 97, 114, 103, 101, 116, 59, 13, 10, 47, 47, 32, 69, 110, 100, 32, 98, 117, 102, 102, 101, 114, 32, 79, 112, 101, 110, 103, 108, 70, 108, 97, 103, 115, 13, 10, 47, 47, 32, 66, 101, 103, 105, 110, 
32, 99, 98, 117, 102, 102, 101, 114, 32, 71, 108, 111, 98, 97, 108, 115, 13, 10, 117, 110, 105, 102, 111, 114, 109, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 83, 99, 97, 108, 101, 95, 105, 100, 55, 51, 59, 13, 10, 117, 110, 105, 102, 111, 114, 109, 32, 102, 108, 111, 97, 116, 32, 65, 
108, 112, 104, 97, 65, 100, 100, 105, 116, 105, 118, 101, 95, 105, 100, 55, 52, 59, 13, 10, 117, 110, 105, 102, 111, 114, 109, 32, 102, 108, 111, 97, 116, 32, 67, 111, 108, 111, 114, 73, 110, 116, 101, 110, 115, 105, 116, 121, 95, 105, 100, 55, 53, 59, 13, 10, 117, 110, 105, 102, 111, 114, 109, 32, 
117, 105, 110, 116, 32, 82, 101, 110, 100, 101, 114, 70, 108, 97, 103, 83, 119, 105, 122, 122, 108, 101, 95, 105, 100, 55, 54, 59, 13, 10, 47, 47, 32, 69, 110, 100, 32, 98, 117, 102, 102, 101, 114, 32, 71, 108, 111, 98, 97, 108, 115, 13, 10, 117, 110, 105, 102, 111, 114, 109, 32, 115, 97, 109, 
112, 108, 101, 114, 50, 68, 32, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 59, 13, 10, 118, 97, 114, 121, 105, 110, 103, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 118, 
101, 99, 52, 32, 83, 97, 109, 112, 108, 101, 84, 101, 120, 48, 95, 105, 100, 52, 40, 105, 110, 111, 117, 116, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 97, 109, 115, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 114, 101, 116, 117, 114, 110, 32, 116, 101, 120, 116, 
117, 114, 101, 50, 68, 40, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 44, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 41, 59, 13, 10, 125, 13, 10, 118, 101, 
99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 53, 40, 105, 110, 111, 117, 116, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 97, 109, 115, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 102, 105, 110, 97, 108, 67, 111, 108, 111, 114, 
32, 61, 32, 67, 111, 108, 111, 114, 83, 99, 97, 108, 101, 95, 105, 100, 55, 51, 59, 13, 10, 13, 10, 32, 32, 32, 32, 123, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 102, 105, 110, 97, 108, 67, 111, 108, 111, 114, 32, 42, 61, 32, 40, 40, 82, 101, 110, 100, 101, 114, 70, 108, 97, 103, 
83, 119, 105, 122, 122, 108, 101, 95, 105, 100, 55, 54, 32, 61, 61, 32, 117, 105, 110, 116, 40, 48, 41, 41, 32, 63, 32, 83, 97, 109, 112, 108, 101, 84, 101, 120, 48, 95, 105, 100, 52, 40, 115, 116, 114, 101, 97, 109, 115, 41, 32, 58, 32, 83, 97, 109, 112, 108, 101, 84, 101, 120, 48, 95, 
105, 100, 52, 40, 115, 116, 114, 101, 97, 109, 115, 41, 46, 114, 114, 114, 114, 41, 59, 13, 10, 32, 32, 32, 32, 125, 13, 10, 32, 32, 32, 32, 102, 105, 110, 97, 108, 67, 111, 108, 111, 114, 46, 114, 103, 98, 32, 42, 61, 32, 118, 101, 99, 51, 40, 67, 111, 108, 111, 114, 73, 110, 116, 101, 
110, 115, 105, 116, 121, 95, 105, 100, 55, 53, 41, 59, 13, 10, 32, 32, 32, 32, 102, 105, 110, 97, 108, 67, 111, 108, 111, 114, 46, 97, 32, 42, 61, 32, 65, 108, 112, 104, 97, 65, 100, 100, 105, 116, 105, 118, 101, 95, 105, 100, 55, 52, 59, 13, 10, 32, 32, 32, 32, 114, 101, 116, 117, 114, 
110, 32, 102, 105, 110, 97, 108, 67, 111, 108, 111, 114, 59, 13, 10, 125, 13, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 40, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 86, 83, 95, 79, 85, 84, 80, 85, 84, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 59, 13, 10, 32, 32, 32, 32, 
95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 32, 61, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 
105, 116, 105, 111, 110, 95, 105, 100, 48, 32, 61, 32, 103, 108, 95, 70, 114, 97, 103, 67, 111, 111, 114, 100, 59, 13, 10, 32, 32, 32, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 97, 109, 115, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 
84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 32, 61, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 
116, 95, 105, 100, 49, 32, 61, 32, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 53, 40, 115, 116, 114, 101, 97, 109, 115, 41, 59, 13, 10, 32, 32, 32, 32, 80, 83, 95, 79, 85, 84, 80, 85, 84, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 
111, 117, 116, 112, 117, 116, 95, 48, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 32, 61, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 59, 13, 10, 32, 32, 32, 32, 103, 108, 95, 70, 114, 97, 103, 
68, 97, 116, 97, 91, 48, 93, 32, 61, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 59, 13, 10, 125, 13, 10, 188, 7, 35, 118, 101, 114, 115, 105, 111, 110, 32, 51, 48, 48, 32, 101, 115, 10, 112, 114, 101, 99, 
105, 115, 105, 111, 110, 32, 104, 105, 103, 104, 112, 32, 102, 108, 111, 97, 116, 59, 10, 108, 97, 121, 111, 117, 116, 40, 115, 116, 100, 49, 52, 48, 41, 32, 117, 110, 105, 102, 111, 114, 109, 32, 71, 108, 111, 98, 97, 108, 115, 32, 123, 10, 32, 32, 109, 97, 116, 52, 32, 77, 97, 116, 114, 105, 
120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 95, 105, 100, 55, 50, 59, 10, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 83, 99, 97, 108, 101, 95, 105, 100, 55, 51, 59, 10, 32, 32, 102, 108, 111, 97, 116, 32, 65, 108, 112, 104, 97, 65, 100, 100, 105, 116, 105, 118, 101, 95, 105, 
100, 55, 52, 59, 10, 32, 32, 102, 108, 111, 97, 116, 32, 67, 111, 108, 111, 114, 73, 110, 116, 101, 110, 115, 105, 116, 121, 95, 105, 100, 55, 53, 59, 10, 32, 32, 117, 105, 110, 116, 32, 82, 101, 110, 100, 101, 114, 70, 108, 97, 103, 83, 119, 105, 122, 122, 108, 101, 95, 105, 100, 55, 54, 59, 
10, 125, 59, 10, 108, 97, 121, 111, 117, 116, 40, 115, 116, 100, 49, 52, 48, 41, 32, 117, 110, 105, 102, 111, 114, 109, 32, 79, 112, 101, 110, 103, 108, 70, 108, 97, 103, 115, 32, 123, 10, 32, 32, 102, 108, 111, 97, 116, 32, 88, 101, 110, 107, 111, 70, 108, 105, 112, 82, 101, 110, 100, 101, 114, 
116, 97, 114, 103, 101, 116, 59, 10, 125, 59, 10, 111, 117, 116, 32, 108, 111, 119, 112, 32, 118, 101, 99, 52, 32, 95, 103, 108, 101, 115, 70, 114, 97, 103, 68, 97, 116, 97, 91, 49, 93, 59, 10, 117, 110, 105, 102, 111, 114, 109, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 32, 84, 101, 120, 
116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 59, 10, 105, 110, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 32, 40, 41, 10, 123, 10, 32, 32, 118, 
101, 99, 50, 32, 116, 109, 112, 118, 97, 114, 95, 49, 59, 10, 32, 32, 116, 109, 112, 118, 97, 114, 95, 49, 32, 61, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 32, 32, 108, 111, 119, 112, 32, 118, 101, 99, 52, 32, 102, 105, 110, 97, 108, 67, 111, 108, 111, 114, 95, 50, 
59, 10, 32, 32, 102, 105, 110, 97, 108, 67, 111, 108, 111, 114, 95, 50, 32, 61, 32, 67, 111, 108, 111, 114, 83, 99, 97, 108, 101, 95, 105, 100, 55, 51, 59, 10, 32, 32, 108, 111, 119, 112, 32, 118, 101, 99, 52, 32, 116, 109, 112, 118, 97, 114, 95, 51, 59, 10, 32, 32, 105, 102, 32, 40, 
40, 82, 101, 110, 100, 101, 114, 70, 108, 97, 103, 83, 119, 105, 122, 122, 108, 101, 95, 105, 100, 55, 54, 32, 61, 61, 32, 48, 117, 41, 41, 32, 123, 10, 32, 32, 32, 32, 116, 109, 112, 118, 97, 114, 95, 49, 32, 61, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 32, 32, 
32, 32, 116, 109, 112, 118, 97, 114, 95, 51, 32, 61, 32, 116, 101, 120, 116, 117, 114, 101, 32, 40, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 44, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 41, 59, 10, 
32, 32, 125, 32, 101, 108, 115, 101, 32, 123, 10, 32, 32, 32, 32, 116, 109, 112, 118, 97, 114, 95, 51, 32, 61, 32, 116, 101, 120, 116, 117, 114, 101, 32, 40, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 44, 32, 116, 
109, 112, 118, 97, 114, 95, 49, 41, 46, 120, 120, 120, 120, 59, 10, 32, 32, 125, 59, 10, 32, 32, 102, 105, 110, 97, 108, 67, 111, 108, 111, 114, 95, 50, 32, 61, 32, 40, 67, 111, 108, 111, 114, 83, 99, 97, 108, 101, 95, 105, 100, 55, 51, 32, 42, 32, 116, 109, 112, 118, 97, 114, 95, 51, 
41, 59, 10, 32, 32, 102, 105, 110, 97, 108, 67, 111, 108, 111, 114, 95, 50, 46, 120, 121, 122, 32, 61, 32, 40, 102, 105, 110, 97, 108, 67, 111, 108, 111, 114, 95, 50, 46, 120, 121, 122, 32, 42, 32, 118, 101, 99, 51, 40, 67, 111, 108, 111, 114, 73, 110, 116, 101, 110, 115, 105, 116, 121, 95, 
105, 100, 55, 53, 41, 41, 59, 10, 32, 32, 102, 105, 110, 97, 108, 67, 111, 108, 111, 114, 95, 50, 46, 119, 32, 61, 32, 40, 102, 105, 110, 97, 108, 67, 111, 108, 111, 114, 95, 50, 46, 119, 32, 42, 32, 65, 108, 112, 104, 97, 65, 100, 100, 105, 116, 105, 118, 101, 95, 105, 100, 55, 52, 41, 
59, 10, 32, 32, 95, 103, 108, 101, 115, 70, 114, 97, 103, 68, 97, 116, 97, 91, 48, 93, 32, 61, 32, 102, 105, 110, 97, 108, 67, 111, 108, 111, 114, 95, 50, 59, 10, 125, 10, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 18, 6, 52, 21, 110, 27, 135, 62, 87, 77, 229, 144, 72, 161, 178, 166, 
        };
    }
}
#endif
