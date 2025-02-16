// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using CommandLine;
using Microsoft.DotNet.Darc.Operations;
using Microsoft.DotNet.DarcLib;
using System.Threading.Tasks;

namespace Microsoft.DotNet.Darc.Options;

[Verb("trigger-subscriptions", HelpText = "Trigger a subscription or set of subscriptions matching criteria.")]
internal class TriggerSubscriptionsCommandLineOptions : SubscriptionsCommandLineOptions
{
    [Option("id", HelpText = "Trigger a specific subscription by id.")]
    public string Id { get; set; }

    [Option("build", HelpText = "If specified, selects a specific BAR build id to use; otherwise will use the latest available from the supplied '--source-repo'")]
    public int Build { get; set; }

    [Option('q', "quiet", HelpText = "Do not confirm which subscriptions are about to be triggered.")]
    public bool NoConfirmation { get; set; }

    public override Operation GetOperation()
    {
        return new TriggerSubscriptionsOperation(this);
    }
}
