using System;
using System.IO;
using System.Collections.Generic;

namespace AssetGenerator.Conversion
{
    internal enum BinaryDataType
    {
        Animation,
        Mesh,
        Skin,
    }

    internal class BinaryData : IDisposable
    {
        public string Name { get; private set; }
        public string AnimationName { get; private set; }
        public BinaryWriter Writer { get; private set; }

        public BinaryData(string name)
        {
            Name = name;
            Writer = new BinaryWriter(new MemoryStream());
        }
        public BinaryData(string name, string animationName)
        {
            Name = name;
            AnimationName = animationName;
            Writer = new BinaryWriter(new MemoryStream());
        }
        public void Dispose()
        {
            Writer.BaseStream.Dispose();
            Writer.Dispose();
        }

        public byte[] Bytes
        {
            get
            {
                Writer.Flush();
                return ((MemoryStream)Writer.BaseStream).ToArray();
            }
        }
    }
}
