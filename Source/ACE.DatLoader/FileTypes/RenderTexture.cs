using ACE.Common;
using ACE.DatLoader.Entity;
using ACE.Entity.Enum;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ACE.DatLoader.FileTypes
{
    /// <summary>
    /// These are client_portal.dat files starting with 0x15.
    /// These are references to the textures for the DebugConsole
    ///
    /// This is identical to SurfaceTexture.
    ///
    /// As defined in DidMapper.UNIQUEDB (0x25000002)
    /// 0x15000000 = ConsoleOutputBackgroundTexture
    /// 0x15000001 = ConsoleInputBackgroundTexture
    /// </summary>
    [DatFileType(DatFileType.RenderTexture)]
    public class RenderTexture : FileType
    {
        public uint DataCategory { get; private set; }
        public TextureType TextureType { get; private set; }
        public List<uint> Textures { get; private set; } = new List<uint>(); // These values correspond to a Surface (0x06) entry

        public override void Unpack(BinaryReader reader)
        {
            Id = reader.ReadUInt32();
            DataCategory = reader.ReadUInt32();
            TextureType = (TextureType)reader.ReadByte();
            Textures.Unpack(reader);
        }
    }
}
