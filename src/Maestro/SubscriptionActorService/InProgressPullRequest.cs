// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Maestro.Contracts;
using Microsoft.DotNet.DarcLib;

namespace SubscriptionActorService;

[DataContract]
public class InProgressPullRequest : IPullRequest
{
    [DataMember]
    public string Url { get; set; }

    [DataMember]
    public MergePolicyCheckResult MergePolicyResult { get; set; }

    [DataMember]
    public List<SubscriptionPullRequestUpdate> ContainedSubscriptions { get; set; }

    [DataMember]
    public List<SubscriptionPullRequestUpdate> Contained { get; set; }

    [DataMember]
    public List<DependencyUpdateSummary> RequiredUpdates { get; set; }

    [DataMember]
    public bool? SourceRepoNotified { get; set; }
}

[DataContract]
public class SubscriptionPullRequestUpdate
{
    [DataMember]
    public Guid SubscriptionId { get; set; }

    [DataMember]
    public int BuildId { get; set; }
}
