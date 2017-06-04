﻿using Syroot.NintenTools.Bfres.Core;

namespace Syroot.NintenTools.Bfres
{
    /// <summary>
    /// Represents a node in a <see cref="SubMesh"/> bounding tree to determine when to show which sub mesh of a
    /// <see cref="Mesh"/>.
    /// </summary>
    public class BoundingNode : ResContent
    {
        // ---- CONSTRUCTORS & DESTRUCTOR ------------------------------------------------------------------------------

        public BoundingNode(ResFileLoader loader)
            : base(loader)
        {
            LeftChildIndex = loader.ReadUInt16();
            RightChildIndex = loader.ReadUInt16();
            Unknown = loader.ReadUInt16();
            SubMeshIndex = loader.ReadUInt16();
            SubMeshCount = loader.ReadUInt16();
        }

        // ---- PROPERTIES ---------------------------------------------------------------------------------------------

        public ushort LeftChildIndex { get; set; }

        public ushort RightChildIndex { get; set; }

        public ushort Unknown { get; set; }

        public ushort SubMeshIndex { get; set; }

        public ushort SubMeshCount { get; set; }
    }
}