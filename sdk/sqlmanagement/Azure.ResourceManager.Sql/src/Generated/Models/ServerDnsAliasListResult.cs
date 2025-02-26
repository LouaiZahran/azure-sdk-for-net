// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of server DNS aliases. </summary>
    internal partial class ServerDnsAliasListResult
    {
        /// <summary> Initializes a new instance of ServerDnsAliasListResult. </summary>
        internal ServerDnsAliasListResult()
        {
            Value = new ChangeTrackingList<SqlServerDnsAliasData>();
        }

        /// <summary> Initializes a new instance of ServerDnsAliasListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal ServerDnsAliasListResult(IReadOnlyList<SqlServerDnsAliasData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SqlServerDnsAliasData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
