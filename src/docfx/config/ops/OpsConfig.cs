// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

#nullable enable

namespace Microsoft.Docs.Build
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    internal class OpsConfig
    {
        public OpsDocsetConfig[] DocsetsToPublish { get; private set; } = Array.Empty<OpsDocsetConfig>();

        public OpsDependencyConfig[] DependentRepositories { get; private set; } = Array.Empty<OpsDependencyConfig>();

        public string? GitRepositoryBranchOpenToPublicContributors { get; private set; }

        public string? GitRepositoryUrlOpenToPublicContributors { get; private set; }

        public bool NeedGeneratePdfUrlTemplate { get; private set; }

        public string? XrefEndpoint { get; private set; }
    }
}