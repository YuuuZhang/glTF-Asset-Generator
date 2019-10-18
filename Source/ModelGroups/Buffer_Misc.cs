using System;
using System.Numerics;
using AssetGenerator.Runtime;
using System.Collections.Generic;

namespace AssetGenerator.ModelGroups
{
    internal class Buffer_Misc : ModelGroup
    {
        public override ModelGroupId Id => ModelGroupId.Buffer_Misc;

        public Buffer_Misc(List<string> imageList)
        {
            var baseColorTexture = new Texture { Source = UseTexture(imageList, "BaseColor_Grey")};

            // Track the common properties for use in the readme
            CommonProperties.Add(new Property(PropertyName.BaseColorTexture, baseColorTexture.Source.ToReadmeString()));

            Model CreateModel(Action<List<Property>, Runtime.MeshPrimitive> setProperties) 
            {
                var properties = new List<Property>();
                Runtime.MeshPrimitive meshPrimitive = MeshPrimitive.CreateSinglePlane();

                // Apply the common properties to the glTF
                meshPrimitive.Colors = Data.Create
                (
                    new[]
                    {
                        new Vector3(0.0f, 1.0f, 0.0f),
                        new Vector3(1.0f, 0.0f, 0.0f),
                        new Vector3(1.0f, 1.0f, 0.0f),
                        new Vector3(0.0f, 0.0f, 1.0f),
                    }
                );
                meshPrimitive.Material = new Runtime.Material
                {
                    PbrMetallicRoughness = new PbrMetallicRoughness
                    {
                        BaseColorTexture = new TextureInfo { Texture = baseColorTexture },
                    },
                };

                var node = new Node
                {
                    Mesh = new Runtime.Mesh
                    {
                        MeshPrimitives = new[]
                        {
                            meshPrimitive
                        }
                    }
                };
                var channel = new AnimationChannel
                {
                    Target = new AnimationChannelTarget
                    {
                        Node = node,
                        Path = AnimationChannelTargetPath.Translation,
                    },
                    Sampler = new AnimationSampler
                    {
                        Interpolation = AnimationSamplerInterpolation.Linear,
                        Input = Data.Create(new[]
                        {
                            0.0f,
                            2.0f,
                            4.0f,
                        }),
                        Output = Data.Create(new[]
                        {
                            new Vector3(-0.1f, 0.0f, 0.0f),
                            new Vector3(0.1f, 0.0f, 0.0f),
                            new Vector3(-0.1f, 0.0f, 0.0f),
                        }),
                    },
                };

                // Apply the proerties that are specific to this glTF
                setProperties(properties, meshPrimitive);

                // Create the glTF object
                GLTF gltf = CreateGLTF(() => new Scene
                {
                    Nodes = new[]
                    {
                        node
                    },
                });
                gltf.Animations = new[]
                {
                    new Animation
                    {
                        Channels = new List<AnimationChannel>
                        {
                            channel
                        }
                    }
                };
                return new Model
                {
                    Properties = properties,
                    GLTF = gltf,
                    Animated = true,
                };
            }
            void SetUvTypeFloat(List<Property> properties, Runtime.MeshPrimitive meshPrimitive)
            {
                meshPrimitive.TexCoords0.OutputType = DataType.Float;
                properties.Add(new Property(PropertyName.VertexUV0, meshPrimitive.TexCoords0.OutputType.ToReadmeString()));
            }
            void SetColorTypeFloat(List<Property> properties, Runtime.MeshPrimitive meshPrimitive)
            {
                meshPrimitive.Colors.OutputType = DataType.Float;
                properties.Add(new Property(PropertyName.VertexColor, $"Vector3 {meshPrimitive.Colors.OutputType.ToReadmeString()}"));
            }

            Models = new List<Model>
            {
                CreateModel((properties, meshPrimitive) =>
                {
                    SetUvTypeFloat(properties, meshPrimitive);
                    SetColorTypeFloat(properties, meshPrimitive);
                })
            };

            GenerateUsedPropertiesList();
        }
    }
}