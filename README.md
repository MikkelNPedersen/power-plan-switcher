# PowerPlanSwitcher

A shitty ai made lightweight portable Windows utility that automatically switches
Windows power plans based on running applications.

## Features
- Detects running programs by executable name
- Switches to High Performance when detected
- Switches back to Normal when none are running
- System tray support
- Portable (no installer)
- Configuration stored in %APPDATA%

## Requirements
- Windows 11
- .NET 6 SDK or newer

## Build
```powershell
dotnet restore
dotnet build -c Release
