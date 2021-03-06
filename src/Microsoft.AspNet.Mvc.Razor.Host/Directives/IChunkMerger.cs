// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNet.Razor.Chunks;

namespace Microsoft.AspNet.Mvc.Razor.Directives
{
    /// <summary>
    /// Defines the contract for merging <see cref="Chunk"/> instances from _ViewStart files.
    /// </summary>
    public interface IChunkMerger
    {
        /// <summary>
        /// Visits a <see cref="Chunk"/> from the <see cref="ChunkTree"/> to merge into.
        /// </summary>
        /// <param name="chunk">A <see cref="Chunk"/> from the tree.</param>
        void VisitChunk(Chunk chunk);

        /// <summary>
        /// Merges an inherited <see cref="Chunk"/> into the <see cref="ChunkTree"/>.
        /// </summary>
        /// <param name="ChunkTree">The <see cref="ChunkTree"/> to merge into.</param>
        /// <param name="chunk">The <see cref="Chunk"/> to merge.</param>
        void Merge(ChunkTree chunkTree, Chunk chunk);
    }
}