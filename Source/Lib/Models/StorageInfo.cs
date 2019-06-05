﻿// <copyright file="StorageInfo.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Lib.Models
{
    /// <summary>
    /// References to storage tables.
    /// </summary>
    public class StorageInfo
    {
        /// <summary>
        /// Config Table
        /// </summary>
        public const string ConfigTableName = "Config";

        /// <summary>
        /// KB Info Table
        /// </summary>
        public const string KBInfoTableName = "KBInfo";

        /// <summary>
        /// Token Table
        /// </summary>
        public const string TokenTableName = "Token";

        /// <summary>
        /// Blob Container
        /// </summary>
        public const string BlobContainerName = "list-search-blob";
    }
}
