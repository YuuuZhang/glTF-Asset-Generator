using System;
using System.Numerics;
using AssetGenerator.Runtime;
using System.Collections.Generic;

namespace AssetGenerator.ModelGroups
{
    internal class Binary_glTF : ModelGroup
    {
        public override ModelGroupId Id => ModelGroupId.Binary_glTF;

        public Binary_glTF(List<string> imageList)
        {
            var baseColorTexture = new Texture { Source = UseTexture(imageList, "BaseColor_A") };

            // Track the common properties for use in the readme.
            CommonProperties.Add(new Property(PropertyName.BaseColorTexture, baseColorTexture.Source.ToReadmeString()));

            Model CreateModel(Action<List<Property>, Node> setProperties)
            {
                var properties = new List<Property>();
                Runtime.MeshPrimitive meshPrimitive = MeshPrimitive.CreateSinglePlane();

                // Apply the common properties to the glTF.
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

                // Apply the proerties that are specific to this glTF.
                setProperties(properties, node);

                // Create the glTF object
                GLTF gltf = CreateGLTF(() => new Scene
                {
                    Nodes = new[]
                    {
                        node
                    },
                });

                return new Model
                {
                    Properties = properties,
                    GLTF = gltf,
                    PackedAllGLBData = true,
                };
            }

            Models = new List<Model>
            {
                CreateModel((properties, node) =>
                {
                    properties.Add(new Property(PropertyName.Description, "This GLB file is packed all resource data: image and .bin resources."));
                })
            };

            GenerateUsedPropertiesList();
        }
    }
}
