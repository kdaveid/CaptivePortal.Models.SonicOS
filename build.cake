var target          = Argument("target", "Default");

var configuration   = Argument<string>("configuration", "Release");



///////////////////////////////////////////////////////////////////////////////

// GLOBAL VARIABLES

///////////////////////////////////////////////////////////////////////////////

var isLocalBuild        = !AppVeyor.IsRunningOnAppVeyor;

var packPath            = Directory("./src/Dkbe.CaptivePortal.Models.SonicOS");

var sourcePath          = Directory("./src");

var solutionPath		= string.Concat(Directory("."), "/Dkbe.CaptivePortal.Models.SonicOS.sln");

var testsPath           = Directory("test");

var buildArtifacts      = Directory("./artifacts/packages");



Task("Build")

    .IsDependentOn("Clean")

    .IsDependentOn("Restore")

    .Does(() =>

{

	var projects = GetFiles("./**/*.csproj");



	foreach(var project in projects)

	{

        var settings = new DotNetCoreBuildSettings 

        {

            Configuration = configuration

        };



        DotNetCoreBuild(project.GetDirectory().FullPath, settings); 

    }

});



Task("RunTests")

    .IsDependentOn("Restore")

    .IsDependentOn("Clean")

    .Does(() =>

{

    var projects = GetFiles("./test/**/*.csproj");



    foreach(var project in projects)
	{

		Information(string.Concat("Running tests for ", project.FullPath));

        var settings = new DotNetCoreTestSettings

        {

            Configuration = configuration

        };



        if (!IsRunningOnWindows())

        {

            Information("Not running on Windows - skipping tests for full .NET Framework");

            settings.Framework = "netcoreapp1.1";

        }


        DotNetCoreTest(project.FullPath, settings);

    }

});



Task("Pack")

    .IsDependentOn("Restore")

    .IsDependentOn("Clean")

    .Does(() =>

{

    var settings = new DotNetCorePackSettings

    {

        Configuration = configuration,

        OutputDirectory = buildArtifacts,

    };



    // add build suffix for CI builds

    if(!isLocalBuild)

    {

        settings.VersionSuffix = "build" + AppVeyor.Environment.Build.Number.ToString().PadLeft(5,'0');

    }



    DotNetCorePack(packPath, settings);

});



Task("Clean")

    .Does(() =>

{

    CleanDirectories(new DirectoryPath[] { buildArtifacts });

});



Task("Restore")

    .Does(() =>

{
	var settings = new NuGetRestoreSettings
	{
		Source = new [] {"https://api.nuget.org/v3/index.json"}
	};

	NuGetRestore(solutionPath, settings);
});



Task("Default")

  .IsDependentOn("Build")

  .IsDependentOn("RunTests")

  .IsDependentOn("Pack");



RunTarget(target);