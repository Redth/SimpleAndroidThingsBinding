﻿using System.Reflection;
using System.Runtime.CompilerServices;
using Android.App;

// Information about this assembly is defined by the following attributes. 
// Change them to the values specific to your project.

[assembly: AssemblyTitle("Xamarin.Android.Things")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("")]
[assembly: AssemblyCopyright("Microsoft Corporation")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The form "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.

[assembly: AssemblyVersion("1.0.0")]

// The following attributes are used to specify the signing key for the assembly, 
// if desired. See the Mono documentation for more information about signing.

//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]

[assembly: UsesLibrary("com.google.android.things")]

[assembly: Java.Interop.DoNotPackage(__AndroidThingsConsts.LibraryName)]
[assembly: Java.Interop.JavaLibraryReference(null,
                                             Version = __AndroidThingsConsts.Version,
                                             SourceUrl = __AndroidThingsConsts.Url)]

internal class __AndroidThingsConsts
{
    internal const string Version = "0.1-devpreview";
    internal const string LibraryName = "androidthings-" + Version;
    internal const string Url = "https://bintray.com/google/androidthings/download_file?file_path=com%2Fgoogle%2Fandroid%2Fthings%2Fandroidthings%2F" + Version + "%2Fandroidthings-" + Version + ".jar";
}