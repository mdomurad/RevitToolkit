﻿using Nuke.Common.Tooling;

namespace RevitToolkit.Build.Tools;

public static class DotNetExtendedTasks
{
    public static IReadOnlyCollection<Output> DotNetNuGetDelete(Configure<DotNetNuGetDeleteSettings> configurator) =>
        DotNetNuGetDelete(configurator(new DotNetNuGetDeleteSettings()));

    public static IReadOnlyCollection<Output> DotNetNuGetDelete(DotNetNuGetDeleteSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new DotNetNuGetDeleteSettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
}