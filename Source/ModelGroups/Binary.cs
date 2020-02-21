using System;
using System.Numerics;
using AssetGenerator.Runtime;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace AssetGenerator.ModelGroups
{
    internal class Binary : ModelGroup
    {
        public override ModelGroupId Id => ModelGroupId.Binary;

        public Binary(List<string> imageList)
        {
            var baseColorTexture = new Texture { Source = UseTexture(imageList, "BaseColor_A") };

            // Track the common properties for use in the readme.
            CommonProperties.Add(new Property(PropertyName.BaseColorTexture, baseColorTexture.Source.ToReadmeString()));

            Model CreateModel(Action<List<Property>, Node> setProperties, Action<glTFLoader.Schema.Gltf> glbModelGroupSignal)
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

                var model = new Model
                {
                    Properties = properties,
                    GLTF = gltf,
                };

                model.ModelGroupsSignal = glbModelGroupSignal;

                return model;
            }

            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            string executingAssemblyFolder = Path.GetDirectoryName(executingAssembly.Location);
            char pathSeparator = Path.DirectorySeparatorChar;
            string outputFolder = Path.GetFullPath(Path.Combine(executingAssemblyFolder, $"{string.Format(@"..{0}..{0}..{0}..{0}Output{0}Positive", pathSeparator)}"));
            string outputFileFolder = Path.Combine(outputFolder, ModelGroupId.Binary.ToString());

            void packAllBinaryData(glTFLoader.Schema.Gltf gltf)
            {
                string bufferUri = gltf.Buffers[0].Uri;
                string outputPath = Path.Combine(outputFileFolder, Path.ChangeExtension(bufferUri, ".glb"));

                glTFLoader.Interface.SaveBinaryModelPacked(gltf, outputPath, $"{outputFileFolder}{pathSeparator}");

                // Binary file has been packed into .glb, delete it.
                File.Delete(Path.Combine(outputFileFolder, bufferUri));
            }

            void packSomeBinaryData(glTFLoader.Schema.Gltf gltf)
            {
                string bufferUri = gltf.Buffers[0].Uri;
                byte[] binaryBuffer = File.ReadAllBytes(Path.Combine(outputFileFolder, bufferUri));
                string outputGLBPath = Path.Combine(outputFileFolder, Path.ChangeExtension(bufferUri, ".glb"));

                gltf.Buffers[0].Uri = null;
                glTFLoader.Interface.SaveBinaryModel(gltf, binaryBuffer, outputGLBPath);

                // Binary file has been packed into .glb, delete it.
                File.Delete(Path.Combine(outputFileFolder, bufferUri));
            }

            void packNoneBinaryData(glTFLoader.Schema.Gltf gltf)
            {
                string outputGLBPath = Path.Combine(outputFileFolder, Path.ChangeExtension(gltf.Buffers[0].Uri, ".glb"));
                glTFLoader.Interface.SaveBinaryModel(gltf, null, outputGLBPath);
            }

            Models = new List<Model>
            {
                CreateModel((properties, node) =>
                {
                    properties.Add(new Property(PropertyName.Description, "This GLB file is packed all resource data: BaseColor_A.png and .bin."));
                }, packAllBinaryData),
                CreateModel((properties, node) =>
                {
                    properties.Add(new Property(PropertyName.Description, "This GLB file is packed one resource data: .bin, and points to one external resource: BaseColor_A.png."));
                }, packSomeBinaryData),
                CreateModel((properties, node) =>
                {
                    properties.Add(new Property(PropertyName.Description, "This GLB file is not packed any resource data, still points to external resource: BaseColor_A.png and .bin."));
                }, packNoneBinaryData)
            };

            GenerateUsedPropertiesList();
        }
    }
}
