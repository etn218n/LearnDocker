#if UNITY_EDITOR

using System.Linq;
using UnityEditor;

public static class Builder
{
    public static void Build() {
        var options = new BuildPlayerOptions {
            scenes = EditorBuildSettings.scenes.Select(scene => scene.path).ToArray(),
            target = BuildTarget.StandaloneWindows64,
            locationPathName = @"C:\Users\Projects\TempBuild\LearnDocker.exe"
        };

        BuildPipeline.BuildPlayer(options);
    }
}

#endif