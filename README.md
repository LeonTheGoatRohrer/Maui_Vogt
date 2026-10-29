# MAUI Basics / Maui_Vogt

A .NET MAUI coursework application exploring cross-platform pages, controls and view-model binding.

## Implemented features

- Main and component example pages.
- About page and an About-us view model.
- MAUI application resources and platform projects.

## Technology

.NET 9, C#, XAML, .NET MAUI, CommunityToolkit.Maui and CommunityToolkit.Mvvm.

## Installation and local use

Open the solution in Visual Studio with MAUI workloads installed. On Windows, build the Windows target explicitly:

```powershell
dotnet build Maui_Basics/Maui_Basics.csproj -f net9.0-windows10.0.19041.0
```

Android requires the Android SDK/emulator or a device; iOS/Mac Catalyst builds require the corresponding Apple development environment.

## Configuration and requirements

.NET 9 SDK plus compatible MAUI workloads and the Windows SDK for the Windows target. Restore package references through NuGet. No application secret is required by the reviewed coursework source.

## Development status and limitations

Learning project, not a production mobile application or a messenger. `Maui_Vogt` and the MAUI_Basics folders are related coursework copies; the existing repository is reused. No automated application test suite was found.

## Contribution and attribution

Leon Rohrer: coursework in his existing repository. The standard MAUI template and toolkit components are not claimed as original work. Individual collaborator contributions beyond the recorded Git history are not inferred.



## Publication notes

This portfolio copy includes project source and relevant documentation. Local credentials, private datasets, dependencies and generated build files are excluded. No deployment or paid service is configured by this publication. Existing copyright and license notices remain applicable; this publication does not introduce a new license.
