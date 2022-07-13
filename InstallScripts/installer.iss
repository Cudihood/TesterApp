#define MyAppName "TestApp"
#define MyAppVersion "1.0.0"
#define MyAppPublisher "Daniil Tsirkunov, Inc."
#define MyAppURL "https://github.com/Cudihood/TesterApp.git"

[Setup]
AppId={{52B4CA0A-E067-4F4D-BDE5-FDC34ABE7FCE}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
SetupIconFile = "..\icon\testApp.ico"
DisableProgramGroupPage=yes
OutputBaseFilename=TesterAppSetup
Compression=lzma
SolidCompression=yes
OutputDir = "Installers"

[Languages]
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "Release\TesterAppUI.exe"; DestDir: "{app}"
Source: "Release\NModbus4.dll"; DestDir: "{app}"

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\TesterAppUI.exe" ; 
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\TesterAppUI.exe"; Tasks: desktopicon ; 
