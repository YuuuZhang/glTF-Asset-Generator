﻿using System.Collections.Generic;
using System.Numerics;

namespace AssetGenerator
{
    internal abstract partial class ModelGroup
    {
        protected static partial class Nodes
        {
            public static List<Runtime.Node> CreateMultiNode()
            {
                var vertexPositions = Runtime.Data.Create(new[]
                {
                    new Vector3( 2.5f,  2.5f,  2.5f),
                    new Vector3(-2.5f,  2.5f,  2.5f),
                    new Vector3(-2.5f, -2.5f,  2.5f),
                    new Vector3( 2.5f, -2.5f,  2.5f),
                    new Vector3( 0.0f,  2.5f,  0.0f),
                    new Vector3(-2.5f,  2.5f,  2.5f),
                    new Vector3( 2.5f,  2.5f,  2.5f),
                    new Vector3(-2.5f,  2.5f,  0.0f),
                    new Vector3( 0.0f,  7.5f,  0.0f),
                    new Vector3( 0.0f,  7.5f, -2.5f),
                    new Vector3(-2.5f,  7.5f,  0.0f),
                    new Vector3(-2.5f,  7.5f, -2.5f),
                    new Vector3( 2.5f,  2.5f, -2.5f),
                    new Vector3( 0.0f,  2.5f, -2.5f),
                    new Vector3( 0.0f,  0.0f, -7.5f),
                    new Vector3(-2.5f,  0.0f, -7.5f),
                    new Vector3(-2.5f,  2.5f, -7.5f),
                    new Vector3( 0.0f,  2.5f, -7.5f),
                    new Vector3( 0.0f,  2.5f, -2.5f),
                    new Vector3( 2.5f,  2.5f, -2.5f),
                    new Vector3( 0.0f,  0.0f, -2.5f),
                    new Vector3(-2.5f, -2.5f, -2.5f),
                    new Vector3( 2.5f, -2.5f, -2.5f),
                    new Vector3(-2.5f,  0.0f, -2.5f),
                    new Vector3( 2.5f, -2.5f,  2.5f),
                    new Vector3(-2.5f, -2.5f,  2.5f),
                    new Vector3(-2.5f, -2.5f, -2.5f),
                    new Vector3( 2.5f, -2.5f, -2.5f),
                    new Vector3( 2.5f,  2.5f,  2.5f),
                    new Vector3( 2.5f, -2.5f,  2.5f),
                    new Vector3( 2.5f,  2.5f, -2.5f),
                    new Vector3( 2.5f, -2.5f, -2.5f),
                    new Vector3(-2.5f, -2.5f, -2.5f),
                    new Vector3(-2.5f, -2.5f,  2.5f),
                    new Vector3(-2.5f,  0.0f,  0.0f),
                    new Vector3(-2.5f,  0.0f, -2.5f),
                    new Vector3(-2.5f,  2.5f,  2.5f),
                    new Vector3(-7.5f,  2.5f,  0.0f),
                    new Vector3(-7.5f,  0.0f, -2.5f),
                    new Vector3(-7.5f,  0.0f,  0.0f),
                    new Vector3(-7.5f,  2.5f, -2.5f),
                    new Vector3(-2.5f,  2.5f,  0.0f),
                    new Vector3(-7.5f,  0.0f,  0.0f),
                    new Vector3(-2.5f,  0.0f, -2.5f),
                    new Vector3(-2.5f,  0.0f,  0.0f),
                    new Vector3(-7.5f,  0.0f, -2.5f),
                    new Vector3(-7.5f,  2.5f,  0.0f),
                    new Vector3(-2.5f,  0.0f,  0.0f),
                    new Vector3(-2.5f,  2.5f,  0.0f),
                    new Vector3(-7.5f,  0.0f,  0.0f),
                    new Vector3(-2.5f,  2.5f, -2.5f),
                    new Vector3(-7.5f,  2.5f, -2.5f),
                    new Vector3(-2.5f,  2.5f,  0.0f),
                    new Vector3(-7.5f,  2.5f,  0.0f),
                    new Vector3(-7.5f,  0.0f, -2.5f),
                    new Vector3(-2.5f,  2.5f, -2.5f),
                    new Vector3(-2.5f,  0.0f, -2.5f),
                    new Vector3(-7.5f,  2.5f, -2.5f),
                    new Vector3(-2.5f,  7.5f,  0.0f),
                    new Vector3(-2.5f,  2.5f,  0.0f),
                    new Vector3( 0.0f,  7.5f,  0.0f),
                    new Vector3( 0.0f,  2.5f,  0.0f),
                    new Vector3( 0.0f,  2.5f, -2.5f),
                    new Vector3( 0.0f,  7.5f, -2.5f),
                    new Vector3( 0.0f,  2.5f,  0.0f),
                    new Vector3( 0.0f,  7.5f,  0.0f),
                    new Vector3(-2.5f,  2.5f, -2.5f),
                    new Vector3(-2.5f,  7.5f, -2.5f),
                    new Vector3( 0.0f,  2.5f, -2.5f),
                    new Vector3( 0.0f,  7.5f, -2.5f),
                    new Vector3(-2.5f,  7.5f,  0.0f),
                    new Vector3(-2.5f,  2.5f, -2.5f),
                    new Vector3(-2.5f,  2.5f,  0.0f),
                    new Vector3(-2.5f,  7.5f, -2.5f),
                    new Vector3( 0.0f,  2.5f, -2.5f),
                    new Vector3( 0.0f,  2.5f, -7.5f),
                    new Vector3(-2.5f,  2.5f, -2.5f),
                    new Vector3(-2.5f,  2.5f, -7.5f),
                    new Vector3( 0.0f,  0.0f, -2.5f),
                    new Vector3( 0.0f,  0.0f, -7.5f),
                    new Vector3( 0.0f,  2.5f, -2.5f),
                    new Vector3( 0.0f,  2.5f, -7.5f),
                    new Vector3(-2.5f,  0.0f, -2.5f),
                    new Vector3(-2.5f,  0.0f, -7.5f),
                    new Vector3( 0.0f,  0.0f, -2.5f),
                    new Vector3( 0.0f,  0.0f, -7.5f),
                    new Vector3(-2.5f,  2.5f, -2.5f),
                    new Vector3(-2.5f,  2.5f, -7.5f),
                    new Vector3(-2.5f,  0.0f, -2.5f),
                    new Vector3(-2.5f,  0.0f, -7.5f),
                    new Vector3( 3.0f, -1.0f,  3.0f),
                    new Vector3(-7.5f, -1.0f,  7.5f),
                    new Vector3( 3.0f, -1.0f,  7.5f),
                    new Vector3(-7.5f, -1.0f,  3.0f),
                    new Vector3( 7.5f, -1.0f,  7.5f),
                    new Vector3( 7.5f, -1.0f,  3.0f),
                    new Vector3( 7.5f, -1.0f, -7.5f),
                    new Vector3( 3.0f, -1.0f, -7.5f),
                });

                var texCoords = Runtime.Data.Create(new[]
                {
                    new Vector2(0.788554f, 0.205935f),
                    new Vector2(0.584720f, 0.205900f),
                    new Vector2(0.584685f, 0.409734f),
                    new Vector2(0.788519f, 0.409769f),
                    new Vector2(0.471918f, 0.880496f),
                    new Vector2(0.369983f, 0.982396f),
                    new Vector2(0.573817f, 0.982430f),
                    new Vector2(0.370001f, 0.880479f),
                    new Vector2(0.232172f, 0.857846f),
                    new Vector2(0.232064f, 0.959100f),
                    new Vector2(0.333426f, 0.857955f),
                    new Vector2(0.333317f, 0.959208f),
                    new Vector2(0.573852f, 0.778596f),
                    new Vector2(0.471935f, 0.778579f),
                    new Vector2(0.249236f, 0.325688f),
                    new Vector2(0.249140f, 0.426797f),
                    new Vector2(0.350249f, 0.426892f),
                    new Vector2(0.350345f, 0.325783f),
                    new Vector2(0.573870f, 0.676679f),
                    new Vector2(0.573852f, 0.778596f),
                    new Vector2(0.675786f, 0.676697f),
                    new Vector2(0.777721f, 0.574797f),
                    new Vector2(0.777686f, 0.778631f),
                    new Vector2(0.675804f, 0.574780f),
                    new Vector2(0.777652f, 0.982465f),
                    new Vector2(0.981486f, 0.982500f),
                    new Vector2(0.981520f, 0.778666f),
                    new Vector2(0.777686f, 0.778631f),
                    new Vector2(0.573817f, 0.982430f),
                    new Vector2(0.777652f, 0.982465f),
                    new Vector2(0.573852f, 0.778596f),
                    new Vector2(0.777686f, 0.778631f),
                    new Vector2(0.380851f, 0.409699f),
                    new Vector2(0.584685f, 0.409734f),
                    new Vector2(0.482785f, 0.307799f),
                    new Vector2(0.380868f, 0.307782f),
                    new Vector2(0.584720f, 0.205900f),
                    new Vector2(0.225056f, 0.327032f),
                    new Vector2(0.124248f, 0.226196f),
                    new Vector2(0.124234f, 0.327018f),
                    new Vector2(0.225070f, 0.226211f),
                    new Vector2(0.482803f, 0.205882f),
                    new Vector2(0.023427f, 0.226182f),
                    new Vector2(0.124277f, 0.024553f),
                    new Vector2(0.023455f, 0.024539f),
                    new Vector2(0.124248f, 0.226196f),
                    new Vector2(0.325892f, 0.226224f),
                    new Vector2(0.426742f, 0.024595f),
                    new Vector2(0.325920f, 0.024581f),
                    new Vector2(0.426714f, 0.226239f),
                    new Vector2(0.225098f, 0.024567f),
                    new Vector2(0.225070f, 0.226211f),
                    new Vector2(0.325920f, 0.024581f),
                    new Vector2(0.325892f, 0.226224f),
                    new Vector2(0.124248f, 0.226196f),
                    new Vector2(0.225098f, 0.024567f),
                    new Vector2(0.124277f, 0.024553f),
                    new Vector2(0.225070f, 0.226211f),
                    new Vector2(0.333426f, 0.857955f),
                    new Vector2(0.333643f, 0.655447f),
                    new Vector2(0.232172f, 0.857846f),
                    new Vector2(0.232389f, 0.655338f),
                    new Vector2(0.131136f, 0.655230f),
                    new Vector2(0.130919f, 0.857737f),
                    new Vector2(0.232389f, 0.655338f),
                    new Vector2(0.232172f, 0.857846f),
                    new Vector2(0.029882f, 0.655121f),
                    new Vector2(0.029664f, 0.857629f),
                    new Vector2(0.131136f, 0.655230f),
                    new Vector2(0.130919f, 0.857737f),
                    new Vector2(0.333426f, 0.857955f),
                    new Vector2(0.434897f, 0.655555f),
                    new Vector2(0.333643f, 0.655447f),
                    new Vector2(0.434680f, 0.858063f),
                    new Vector2(0.451167f, 0.629205f),
                    new Vector2(0.451358f, 0.426988f),
                    new Vector2(0.350058f, 0.629110f),
                    new Vector2(0.350249f, 0.426892f),
                    new Vector2(0.552276f, 0.629301f),
                    new Vector2(0.552467f, 0.427083f),
                    new Vector2(0.451167f, 0.629205f),
                    new Vector2(0.451358f, 0.426988f),
                    new Vector2(0.248950f, 0.629014f),
                    new Vector2(0.249140f, 0.426797f),
                    new Vector2(0.147841f, 0.628919f),
                    new Vector2(0.148031f, 0.426701f),
                    new Vector2(0.350058f, 0.629110f),
                    new Vector2(0.350249f, 0.426892f),
                    new Vector2(0.248950f, 0.629014f),
                    new Vector2(0.249140f, 0.426797f),
                    new Vector2(0.820246f, 0.187538f),
                    new Vector2(0.979596f, 0.559354f),
                    new Vector2(0.979596f, 0.187538f),
                    new Vector2(0.820247f, 0.559354f),
                    new Vector2(0.979596f, 0.028188f),
                    new Vector2(0.820247f, 0.028188f),
                    new Vector2(0.448431f, 0.028188f),
                    new Vector2(0.448431f, 0.187538f),
                });

                var indices0 = Runtime.Data.Create(new[]
                {
                    90, 91, 92,
                    91, 90, 93,
                    94, 95, 92,
                    92, 95, 90,
                    96, 90, 95,
                    90, 96, 97,
                });
                var indices1 = Runtime.Data.Create(new[]
                {
                    0, 1, 2,
                    0, 2, 3,
                    4, 5, 6,
                    5, 4, 7,
                    8, 9, 10,
                    10, 9, 11,
                    6, 12, 4,
                    4, 12, 13,
                    14, 15, 16,
                    14, 16, 17,
                    18, 19, 20,
                    21, 20, 22,
                    20, 21, 23,
                    20, 19, 22,
                    24, 25, 26,
                    24, 26, 27,
                    28, 29, 30,
                    29, 31, 30,
                    32, 33, 34,
                    32, 34, 35,
                    33, 36, 34,
                    37, 38, 39,
                    38, 37, 40,
                    34, 36, 41,
                    42, 43, 44,
                    43, 42, 45,
                    46, 47, 48,
                    47, 46, 49,
                    50, 51, 52,
                    53, 52, 51,
                    54, 55, 56,
                    55, 54, 57,
                    58, 59, 60,
                    60, 59, 61,
                    62, 63, 64,
                    65, 64, 63,
                    66, 67, 68,
                    68, 67, 69,
                    70, 71, 72,
                    71, 70, 73,
                    74, 75, 76,
                    76, 75, 77,
                    78, 79, 80,
                    80, 79, 81,
                    82, 83, 84,
                    84, 83, 85,
                    86, 87, 88,
                    88, 87, 89,
                });

                var node1 = new Runtime.Node
                {
                    Mesh = new Runtime.Mesh
                    {
                        MeshPrimitives = new[]
                        {
                            new Runtime.MeshPrimitive
                            {
                                Positions = vertexPositions,
                                TexCoords0 = texCoords,
                                Indices = indices1,
                            }
                        }
                    },
                    Name = "Node1"
                };

                var node0 = new Runtime.Node
                {
                    Mesh = new Runtime.Mesh
                    {
                        MeshPrimitives = new[]
                        {
                            new Runtime.MeshPrimitive
                            {
                                Positions = vertexPositions,
                                TexCoords0 = texCoords,
                                Indices = indices0,
                            }
                        }
                    },
                    Name = "Node0",
                    Children = new[]
                    {
                        node1
                    }
                };

                return new List<Runtime.Node>
                {
                    node0,
                    node1,
                };
            }

            public static Vector3[] GetMultiNodeNormals()
            {
                return new[]
                {
                    new Vector3( 0.0f,  0.0f,  1.0f),
                    new Vector3( 0.0f,  0.0f,  1.0f),
                    new Vector3( 0.0f,  0.0f,  1.0f),
                    new Vector3( 0.0f,  0.0f,  1.0f),
                    new Vector3( 0.0f,  1.0f,  0.0f),
                    new Vector3( 0.0f,  1.0f,  0.0f),
                    new Vector3( 0.0f,  1.0f,  0.0f),
                    new Vector3( 0.0f,  1.0f,  0.0f),
                    new Vector3( 0.0f,  1.0f,  0.0f),
                    new Vector3( 0.0f,  1.0f,  0.0f),
                    new Vector3( 0.0f,  1.0f,  0.0f),
                    new Vector3( 0.0f,  1.0f,  0.0f),
                    new Vector3( 0.0f,  1.0f,  0.0f),
                    new Vector3( 0.0f,  1.0f,  0.0f),
                    new Vector3( 0.0f,  0.0f, -1.0f),
                    new Vector3( 0.0f,  0.0f, -1.0f),
                    new Vector3( 0.0f,  0.0f, -1.0f),
                    new Vector3( 0.0f,  0.0f, -1.0f),
                    new Vector3( 0.0f,  0.0f, -1.0f),
                    new Vector3( 0.0f,  0.0f, -1.0f),
                    new Vector3( 0.0f,  0.0f, -1.0f),
                    new Vector3( 0.0f,  0.0f, -1.0f),
                    new Vector3( 0.0f,  0.0f, -1.0f),
                    new Vector3( 0.0f,  0.0f, -1.0f),
                    new Vector3( 0.0f, -1.0f,  0.0f),
                    new Vector3( 0.0f, -1.0f,  0.0f),
                    new Vector3( 0.0f, -1.0f,  0.0f),
                    new Vector3( 0.0f, -1.0f,  0.0f),
                    new Vector3( 1.0f,  0.0f,  0.0f),
                    new Vector3( 1.0f,  0.0f,  0.0f),
                    new Vector3( 1.0f,  0.0f,  0.0f),
                    new Vector3( 1.0f,  0.0f,  0.0f),
                    new Vector3(-1.0f,  0.0f,  0.0f),
                    new Vector3(-1.0f,  0.0f,  0.0f),
                    new Vector3(-1.0f,  0.0f,  0.0f),
                    new Vector3(-1.0f,  0.0f,  0.0f),
                    new Vector3(-1.0f,  0.0f,  0.0f),
                    new Vector3(-1.0f,  0.0f,  0.0f),
                    new Vector3(-1.0f,  0.0f,  0.0f),
                    new Vector3(-1.0f,  0.0f,  0.0f),
                    new Vector3(-1.0f,  0.0f,  0.0f),
                    new Vector3(-1.0f,  0.0f,  0.0f),
                    new Vector3( 0.0f, -1.0f,  0.0f),
                    new Vector3( 0.0f, -1.0f,  0.0f),
                    new Vector3( 0.0f, -1.0f,  0.0f),
                    new Vector3( 0.0f, -1.0f,  0.0f),
                    new Vector3( 0.0f,  0.0f,  1.0f),
                    new Vector3( 0.0f,  0.0f,  1.0f),
                    new Vector3( 0.0f,  0.0f,  1.0f),
                    new Vector3( 0.0f,  0.0f,  1.0f),
                    new Vector3( 0.0f,  1.0f,  0.0f),
                    new Vector3( 0.0f,  1.0f,  0.0f),
                    new Vector3( 0.0f,  1.0f,  0.0f),
                    new Vector3( 0.0f,  1.0f,  0.0f),
                    new Vector3( 0.0f,  0.0f, -1.0f),
                    new Vector3( 0.0f,  0.0f, -1.0f),
                    new Vector3( 0.0f,  0.0f, -1.0f),
                    new Vector3( 0.0f,  0.0f, -1.0f),
                    new Vector3( 0.0f,  0.0f,  1.0f),
                    new Vector3( 0.0f,  0.0f,  1.0f),
                    new Vector3( 0.0f,  0.0f,  1.0f),
                    new Vector3( 0.0f,  0.0f,  1.0f),
                    new Vector3( 1.0f,  0.0f,  0.0f),
                    new Vector3( 1.0f,  0.0f,  0.0f),
                    new Vector3( 1.0f,  0.0f,  0.0f),
                    new Vector3( 1.0f,  0.0f,  0.0f),
                    new Vector3( 0.0f,  0.0f, -1.0f),
                    new Vector3( 0.0f,  0.0f, -1.0f),
                    new Vector3( 0.0f,  0.0f, -1.0f),
                    new Vector3( 0.0f,  0.0f, -1.0f),
                    new Vector3(-1.0f,  0.0f,  0.0f),
                    new Vector3(-1.0f,  0.0f,  0.0f),
                    new Vector3(-1.0f,  0.0f,  0.0f),
                    new Vector3(-1.0f,  0.0f,  0.0f),
                    new Vector3( 0.0f,  1.0f,  0.0f),
                    new Vector3( 0.0f,  1.0f,  0.0f),
                    new Vector3( 0.0f,  1.0f,  0.0f),
                    new Vector3( 0.0f,  1.0f,  0.0f),
                    new Vector3( 1.0f,  0.0f,  0.0f),
                    new Vector3( 1.0f,  0.0f,  0.0f),
                    new Vector3( 1.0f,  0.0f,  0.0f),
                    new Vector3( 1.0f,  0.0f,  0.0f),
                    new Vector3( 0.0f, -1.0f,  0.0f),
                    new Vector3( 0.0f, -1.0f,  0.0f),
                    new Vector3( 0.0f, -1.0f,  0.0f),
                    new Vector3( 0.0f, -1.0f,  0.0f),
                    new Vector3(-1.0f,  0.0f,  0.0f),
                    new Vector3(-1.0f,  0.0f,  0.0f),
                    new Vector3(-1.0f,  0.0f,  0.0f),
                    new Vector3(-1.0f,  0.0f,  0.0f),
                    new Vector3( 0.0f,  1.0f,  0.0f),
                    new Vector3( 0.0f,  1.0f,  0.0f),
                    new Vector3( 0.0f,  1.0f,  0.0f),
                    new Vector3( 0.0f,  1.0f,  0.0f),
                    new Vector3( 0.0f,  1.0f,  0.0f),
                    new Vector3( 0.0f,  1.0f,  0.0f),
                    new Vector3( 0.0f,  1.0f,  0.0f),
                    new Vector3( 0.0f,  1.0f,  0.0f),
                };
            }

            public static Vector4[] GetMultiNodeTangents()
            {
                return new[]
                {
                    new Vector4( 1.000000f,  0.000170f,  0.000000f,  1.000000f),
                    new Vector4( 1.000000f,  0.000171f,  0.000000f,  1.000000f),
                    new Vector4( 1.000000f,  0.000172f,  0.000000f,  1.000000f),
                    new Vector4( 1.000000f,  0.000171f,  0.000000f,  1.000000f),
                    new Vector4( 1.000000f,  0.000000f, -0.000170f,  1.000000f),
                    new Vector4( 1.000000f,  0.000000f, -0.000170f,  1.000000f),
                    new Vector4( 1.000000f,  0.000000f, -0.000170f,  1.000000f),
                    new Vector4( 1.000000f,  0.000000f, -0.000171f,  1.000000f),
                    new Vector4(-0.999999f,  0.000000f,  0.001072f,  1.000000f),
                    new Vector4(-0.999999f,  0.000000f,  0.001072f,  1.000000f),
                    new Vector4(-0.999999f,  0.000000f,  0.001071f,  1.000000f),
                    new Vector4(-0.999999f,  0.000000f,  0.001072f,  1.000000f),
                    new Vector4( 1.000000f,  0.000000f, -0.000171f,  1.000000f),
                    new Vector4( 1.000000f,  0.000000f, -0.000171f,  1.000000f),
                    new Vector4( 0.000947f,  1.000000f,  0.000000f,  1.000000f),
                    new Vector4( 0.000947f,  1.000000f,  0.000000f,  1.000000f),
                    new Vector4( 0.000947f,  1.000000f,  0.000000f,  1.000000f),
                    new Vector4( 0.000947f,  1.000000f,  0.000000f,  1.000000f),
                    new Vector4(-0.000172f, -1.000000f,  0.000000f,  1.000000f),
                    new Vector4(-0.000171f, -1.000000f,  0.000000f,  1.000000f),
                    new Vector4(-0.000171f, -1.000000f,  0.000000f,  1.000000f),
                    new Vector4(-0.000170f, -1.000000f,  0.000000f,  1.000000f),
                    new Vector4(-0.000169f, -1.000000f,  0.000000f,  1.000000f),
                    new Vector4(-0.000172f, -1.000000f,  0.000000f,  1.000000f),
                    new Vector4(-1.000000f,  0.000000f, -0.000169f,  1.000000f),
                    new Vector4(-1.000000f,  0.000000f, -0.000170f,  1.000000f),
                    new Vector4(-1.000000f,  0.000000f, -0.000171f,  1.000000f),
                    new Vector4(-1.000000f,  0.000000f, -0.000170f,  1.000000f),
                    new Vector4( 0.000000f, -1.000000f, -0.000170f,  1.000000f),
                    new Vector4( 0.000000f, -1.000000f, -0.000171f,  1.000000f),
                    new Vector4( 0.000000f, -1.000000f, -0.000169f,  1.000000f),
                    new Vector4( 0.000000f, -1.000000f, -0.000170f,  1.000000f),
                    new Vector4( 0.000000f,  0.000169f,  1.000000f,  1.000000f),
                    new Vector4( 0.000000f,  0.000172f,  1.000000f,  1.000000f),
                    new Vector4( 0.000000f,  0.000170f,  1.000000f,  1.000000f),
                    new Vector4( 0.000000f,  0.000168f,  1.000000f,  1.000000f),
                    new Vector4( 0.000000f,  0.000172f,  1.000000f,  1.000000f),
                    new Vector4( 0.000000f,  1.000000f, -0.000140f,  1.000000f),
                    new Vector4( 0.000000f,  1.000000f, -0.000141f,  1.000000f),
                    new Vector4( 0.000000f,  1.000000f, -0.000140f,  1.000000f),
                    new Vector4( 0.000000f,  1.000000f, -0.000140f,  1.000000f),
                    new Vector4( 0.000000f,  0.000170f,  1.000000f,  1.000000f),
                    new Vector4( 0.000140f,  0.000000f, -1.000000f,  1.000000f),
                    new Vector4( 0.000142f,  0.000000f, -1.000000f,  1.000000f),
                    new Vector4( 0.000141f,  0.000000f, -1.000000f,  1.000000f),
                    new Vector4( 0.000141f,  0.000000f, -1.000000f,  1.000000f),
                    new Vector4( 0.000140f, -1.000000f,  0.000000f,  1.000000f),
                    new Vector4( 0.000140f, -1.000000f,  0.000000f,  1.000000f),
                    new Vector4( 0.000140f, -1.000000f,  0.000000f,  1.000000f),
                    new Vector4( 0.000140f, -1.000000f,  0.000000f,  1.000000f),
                    new Vector4( 0.000139f,  0.000000f,  1.000000f,  1.000000f),
                    new Vector4( 0.000138f,  0.000000f,  1.000000f,  1.000000f),
                    new Vector4( 0.000140f,  0.000000f,  1.000000f,  1.000000f),
                    new Vector4( 0.000139f,  0.000000f,  1.000000f,  1.000000f),
                    new Vector4( 0.000141f,  1.000000f,  0.000000f,  1.000000f),
                    new Vector4( 0.000138f,  1.000000f,  0.000000f,  1.000000f),
                    new Vector4( 0.000140f,  1.000000f,  0.000000f,  1.000000f),
                    new Vector4( 0.000140f,  1.000000f,  0.000000f,  1.000000f),
                    new Vector4(-0.999999f, -0.001071f,  0.000000f,  1.000000f),
                    new Vector4(-0.999999f, -0.001071f,  0.000000f,  1.000000f),
                    new Vector4(-0.999999f, -0.001071f,  0.000000f,  1.000000f),
                    new Vector4(-0.999999f, -0.001071f,  0.000000f,  1.000000f),
                    new Vector4( 0.000000f, -0.001073f,  0.999999f,  1.000000f),
                    new Vector4( 0.000000f, -0.001075f,  0.999999f,  1.000000f),
                    new Vector4( 0.000000f, -0.001071f,  0.999999f,  1.000000f),
                    new Vector4( 0.000000f, -0.001073f,  0.999999f,  1.000000f),
                    new Vector4( 0.999999f, -0.001073f,  0.000000f,  1.000000f),
                    new Vector4( 0.999999f, -0.001072f,  0.000000f,  1.000000f),
                    new Vector4( 0.999999f, -0.001074f,  0.000000f,  1.000000f),
                    new Vector4( 0.999999f, -0.001073f,  0.000000f,  1.000000f),
                    new Vector4( 0.000000f, -0.001071f, -0.999999f,  1.000000f),
                    new Vector4( 0.000000f, -0.001074f, -0.999999f,  1.000000f),
                    new Vector4( 0.000000f, -0.001073f, -0.999999f,  1.000000f),
                    new Vector4( 0.000000f, -0.001073f, -0.999999f,  1.000000f),
                    new Vector4( 1.000000f,  0.000000f, -0.000942f,  1.000000f),
                    new Vector4( 1.000000f,  0.000000f, -0.000943f,  1.000000f),
                    new Vector4( 1.000000f,  0.000000f, -0.000941f,  1.000000f),
                    new Vector4( 1.000000f,  0.000000f, -0.000942f,  1.000000f),
                    new Vector4( 0.000000f, -1.000000f, -0.000944f,  1.000000f),
                    new Vector4( 0.000000f, -1.000000f, -0.000943f,  1.000000f),
                    new Vector4( 0.000000f, -1.000000f, -0.000946f,  1.000000f),
                    new Vector4( 0.000000f, -1.000000f, -0.000944f,  1.000000f),
                    new Vector4(-1.000000f,  0.000000f, -0.000941f,  1.000000f),
                    new Vector4(-1.000000f,  0.000000f, -0.000941f,  1.000000f),
                    new Vector4(-1.000000f,  0.000000f, -0.000942f,  1.000000f),
                    new Vector4(-1.000000f,  0.000000f, -0.000941f,  1.000000f),
                    new Vector4( 0.000000f,  1.000000f, -0.000946f,  1.000000f),
                    new Vector4( 0.000000f,  1.000000f, -0.000947f,  1.000000f),
                    new Vector4( 0.000000f,  1.000000f, -0.000945f,  1.000000f),
                    new Vector4( 0.000000f,  1.000000f, -0.000946f,  1.000000f),
                    new Vector4( 0.000000f,  0.000000f,  1.000000f,  1.000000f),
                    new Vector4(-0.000001f,  0.000000f,  1.000000f,  1.000000f),
                    new Vector4(-0.000000f,  0.000000f,  1.000000f,  1.000000f),
                    new Vector4(-0.000000f,  0.000000f,  1.000000f,  1.000000f),
                    new Vector4( 0.000000f,  0.000000f,  1.000000f,  1.000000f),
                    new Vector4( 0.000000f,  0.000000f,  1.000000f,  1.000000f),
                    new Vector4( 0.000000f,  0.000000f,  1.000000f,  1.000000f),
                    new Vector4( 0.000000f,  0.000000f,  1.000000f,  1.000000f),
                };
            }
        }
    }
}
