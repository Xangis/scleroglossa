; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Scleroglossa"
#define MyAppVersion "1.0"
#define MyAppPublisher "Lambda Centauri"
#define MyAppURL "https://lambdacentauri.com/software_scleroglossa.htm"
#define MyAppExeName "Scleroglossa.exe"
#define CodeDir "E:\code\Scleroglossa"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{1C41DAA6-729C-463C-9A63-DA9E40979E5C}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppPublisher}\{#MyAppName}
DisableDirPage=yes
DefaultGroupName={#MyAppPublisher}
DisableProgramGroupPage=yes
LicenseFile={#CodeDir}\license.txt
OutputDir={#CodeDir}\installer
OutputBaseFilename={#MyAppName}{#MyAppVersion}Setup
SetupIconFile={#CodeDir}\images\Scleroglossa.ico
UninstallDisplayIcon={app}\{#MyAppExeName},0
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "{#CodeDir}\bin\Release\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#CodeDir}\bin\Release\Geckofx-Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#CodeDir}\bin\Release\Geckofx-Winforms.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#CodeDir}\bin\Release\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#CodeDir}\Firefox\*"; DestDir: "{app}\Firefox"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon; OnlyBelowVersion: 0,6.1

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, "&", "&&")}}"; Flags: nowait postinstall skipifsilent

[Registry]
; File association to open .htm files.
Root: HKCR; Subkey: ".htm"; ValueType: string; ValueName: ""; ValueData: "HTMFile"; Flags: uninsdeletevalue
Root: HKCR; Subkey: "HTMFile"; ValueType: string; ValueName: ""; ValueData: "HTML File"; Flags: uninsdeletekey
Root: HKCR; Subkey: "HTMFile\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\{#MyAppExeName},0"
Root: HKCR; Subkey: "HTMFile\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1""" 
; File association to open .html files.
Root: HKCR; Subkey: ".html"; ValueType: string; ValueName: ""; ValueData: "HTMLFile"; Flags: uninsdeletevalue
Root: HKCR; Subkey: "HTMLFile"; ValueType: string; ValueName: ""; ValueData: "HTML File"; Flags: uninsdeletekey
Root: HKCR; Subkey: "HTMLFile\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\{#MyAppExeName},0"
Root: HKCR; Subkey: "HTMLFile\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1""" 


