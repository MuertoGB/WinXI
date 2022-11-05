 **Version 2.1.0 (1JA12)**
 -
 *7th March, 2021*
 
 **New:**
- Assessment code has been rewritten
- Added a new theme color
- Added new graphic to form title bars
- Bump WinSAT Reader to v5
>Decimal separator is now read from the system\
>Fetch WinSAT exit code\
>Enumerate string from WinSAT exit code
- Added menu item Help > Donate
>Removed donate link (About)

**Enhancements:**
- Major user interface and scaling improvements
- Moved version label is now clickable (Main form)
- Renamed Tools > 'Cleanup' to 'Reset'
- Renamed explorer menu item 'Reset Application' to 'Restart Application'
- Enabled deletion of WinSAT and WinXI data simultaneously (Tools > Reset)
- Concatenate 'What is Rated?' text when hardware mode is enabled
- Font Installer updated to utilize new font
>Added Segoe MDL2 assets font as a resource
- Removed deprecated files
>Launch diagnostics (prelaunch. *)\
>Updater settings (paths. *)
- Modified settings load order
- Changed how WinSAT executes
- Switched back to SHA256 for hash generation
- Stability and speed improvements
- Garbage collector has been deprecated

**Bugs:**
- Fixed an issue where the font installer could prevent application startup
- Fixed an issue where a progress bar would not redraw
- Fixed radio buttons not matching their corresponding theme color
- Fixed UI framework font bugs
- Fixed UI framework progress bar background transparency
- Fixed missing text when a section has no data (Metrics)
- Fixed a scenario where the UI could be crashed (Metrics)
- Fixed UI element text out of bounds
- Fixed graphical issues on win build 9200
- Fixed settings file not deleting when stored in the local path (Tools > Reset > Configuration)
- Fixed graphical glitches when a theme color is applied to form borders
- Fixed Win32 Exceptions when opening specific files
- Other various fixes that aren’t noteworthy

**Misc:**
- Troubleshooting file updated
- Update copyrights to 2021

 **Version 2.0.2 (1HL20)**
 -
 *22nd Oct, 2019*

**New:**
- Added acknowledgements (Help > Acknowledgements)
>Some information was removed from the 'About' form
- Added the option to save some resources to disk (Options > Save Resources to Disk)
- Concatenate version label text when an update is available (Main Form)

**Enhancements:**
- User Interface improvements
- Notification system has been redesigned
- Improvements made to the hotfix installer
>Install exit codes are now determined and a reboot is avoided in most cases\
>Exit codes are shown after install in case an error occurs\
>Added wait animation
- Did some sorcery with threading that should vastly improve stability
- Changelog keyboard shortcut has been switched from ALT+O to ALT+L

**Bugs:**
- Fixed hotfix installer failing to patch the system

**Misc:**
- Hotfixes have been added as resources and are no longer downloaded

**Version 2.0.1 (1HK20)**
-
*16th Oct, 2016*

**New:**
- Added thanks and a link to Majorgeeks (About)
- Added thanks to MyDigitalLife (About)

**Enhancements:**
- Transferred Core.dll and Gambol.dll code back into the executable
- Removed library checking as it's no longer necessary
- User Interface improvements
- Removed large resources from the executable
>Missing hotfixes are now downloaded instead\
>Reduced the application file size by approx. 1.2 megabytes
- Detection of missing fonts has been improved
> - Checking is no longer limited to Windows Vista
> - All fonts used by the application are now checked and installed if missing
- Removed duplicate application channel from the assessment log
- Reduced application memory consumption by 10-15%
- Various stability improvements

**Bugs:**
- Fixed double-click repositioning not working after the user invokes an aero snap shortcut
- Fixed explorer context menu being bound to an incorrect control
- Fixed a form that was scaling via font and not DPI (Score Metrics)
- Fixed a rare situation where the hotfix installer became unstable
>This was caused by a task being blocked that would eventually crash the installer thread

**Misc:**
- Troubleshooting file updated

**Version 2.0.0 (1HJ19)**
-
*8th Oct, 2019*

**New:**
 - User interface has been redesigned from the ground up
 - In-depth assessment mode added which can be set as default in settings
 - Added the ability to show system hardware
 - Users can now view key assessment information (Score Metrics)
 - WinSAT or Xiret can be reset automatically (Tools > Cleanup)
 - Some handy system information can now be viewed (Tools > View System Details)
 - Full changelog has been made accessible (Help > Changelog)
 - System scores can now be refreshed from the menu (Options > Refresh Scores)
 - Added new settings system (Options > Settings)
 - Added assessment logging (Options > View Xiret Log)
 - Pre-launch diagnostics are now stored each time the application is started
 - Recreated the explorer shortcut menu (Right click the main form icon)
 - The application now saves Imgur upload links (Options > View Imgur Links)

**Enhancements:**
- Any forms position can be reset by double clicking the top left icon
- Application screenshots now include operating system details
- Improved uncaught exception handling
- Application shortcuts have been added
- Improved application support system
- JPEG options added for screenshots
- Full Windows Vista compatibility
- Full DPI scaling has been added
- Added WSR4

This version is a full rewrite, therefore some details or incipient features may not be listed.

**Version 1.22.1020**
-

**New:**
- Applied WSRv3

**Enhancements:**
- UI ClassStyle and general UI improvements
- Improved UI thread handling
- Checksum generation changed to SHA256
- Better handling of threads
- Improved operating system version checking

**Bugs:**
- Fixed an application version checking issue fixed
- Fixed an XML serializing issue fixed

**Misc:**
- The application now requires Windows 7 or higher

**Version 1.21.1016**
-

**New:**
- UI improvements
- Updated XML parsing method added
- Auto removal of corrupted scores feature added

**Enhancements:**
- Memory management system removed
- WinSAT execution method changes
- Multiple instance messagebox removed
- Messagebox changes to follow the UI
- Core reconstruction applied
- The escape key can now be used to close most windows

**Bugs:**
- Path formatting issue fixed
- Missing file issue fixed
- Score files force read in descending order to eliminate loading incorrect formal assessments

**Misc:**
- CLR updated to .NET framework 3.5

**Version 1.3.3**
-

**Bugs:**
- Fixed a typo in the main window

**Version 1.3.1**
-

**New:**
- User interface improved
- Auto-update system added
- Troubleshooting information added
- Operating system name, architecture and version information added to the main UI

**Enhancements:**
- Print-screen manager removed
- The screenshot option now only captures scores and information
- WinSAT execution commands changed
- Core edits to further prevent WinSAT from exiting spontaneously

**Bugs:**
- Fixed the application reading incorrect WinSAT score files

**Version 1.2.6**
-

**New:**
- Notification system added
- Donate link added to the 'about' section 

**Enhancements:**
- Handed a new WinSAT error code
- UI tweaks
- Removed redundant code
- Removed unused resources

**Version 1.1.5**
-

**Bugs:**
1. Fixed a print-screen bounds issue with UI scaling over 100%
2. Fixed a typo and applied grammatical corrections

**Version 1.1.4**
-

**New:**
1. Advanced error reporter added

**Enhancements:**
1.  Changed how WinSAT executes
2. Users with 'KN/K' versions of Windows are now prompted to download necessary additions

** Version 1.0.3**
-

**New:**
- Added information regarding experience index scoring

**Enhancements:**
- UI enhancements
- Control changes

**Bugs:**
- Fixed a typo
- Removed ability to capture score images on unrated systems

**Version 1.0.2**
-

**New:**
- Useful links added to the 'about' section

**Enhancements:**
-  Screenshot manager UI tweaks
- Application scaling is now set via DPI

**Version 1.0.1**
-

**Enhancements:**
- Automatic capture of error codes generated by WinSAT added
- Screenshot manager added

**Version 1.0.0**
-

- Unreleased private build