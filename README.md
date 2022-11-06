**WinXI**
-
![](Resources/img/app.png)

WinXI, formerly known as *Xiret*, is a simple and powerful tool designed to replace the Windows Experience Index User Interface that was removed in Windows 8.1. It features a beautiful, easy to use UI, no adverts or spam, and is completely free forever. It's compatible with all versions of Windows that can run the Experience Index, however some versions do not include the WinSAT executable or Dynamic Link Library API. Many applications that imitate the experience index either do not work properly, or have many adverts, so I created something better, and free.

_Key features:-_
- Clean, friendly and easy to use UI built for novice and expert users alike
- The 'Show Hardware' toggle instantly shows you which hardware was rated
- View and generate Windows Experience Index scores with minimal effort
- Imgur API for super simple and immediate upload for sharing
- Built using the WInSAT API for high compatibility
- In-Depth assessment mode
- High DPI support
- Self monitoring for missing resources like fonts and patches
- Uncaught exception handling with log generation
- Options to save scores as text or an image
- Option to reset WinSAT with one click
- Portable with easily managed settings
- Automatic power adapter detection

**System Requirements**
```
Processor: 1.00 GHz Pentium 4, or AMD Athlon
Memory:    1.00 GB
Graphics:  64 MB DirectX 9 Compatible, pixel shader 2.0
Disk:      100 MB recommended
Software:  Windows Vista, 7, 8, 8.1, 10, 11 - 32-bit, or 64-bit

WinSAT is required.
Internet connectivity is only necessary for automatic update checking.
```

---

**Where did you go? Why WinXI?**
-
I took a long hiatus from software development to focus on other things. Let's get this out of the way now, I'm no longer actively focused on developing software, and solely focus on my repair business. There are no current plans for any more major versions of this application, only bug fixing. As for a release deadline, there isn't one, just keep checking in or watch this repo. Currently, I'm reverting code and systems that were partially ready from when it was in active development, and catching up with Windows 11 fixes, etc.

And as for the new name, let's face it, Xiret was a shit name from the start.

---

**How to build**
-
**You will need:**
- Visual Studio 2019 or newer
- .NET Framework 4.0

Open `WinXI.sln` in Visual Studio, then first you'll need to either disable signing, sign the app yourself by creating a new PFX, or disable the signing class constructor, otherwise the executable will refuse to run.

**Sign or unsign youself:**
- From the main menu, click "Project > WinXI Properties > Signing".
- Either uncheck `Sign the ClickOne manifests` and `Sign the assembly`, then comment out the code below, or...
- Create a new PFX and sign the assembly and ClickOne manifests, or...
- Ignore everything above and just comment out the code below to skip validation.

**WinXI/Program.vb:**
```
'Signature validation
RuntimeHelpers.RunClassConstructor(GetType(Signing).TypeHandle)
```

**Build the executable:**
- From the menu, select the "Release" build type.
- From the main menu click "Build` > Build Solution", then "Build WinXI".
- In the solution explorer, navigate to "/bin/Release", the newly compiled executable will now be available.

A debug version can also be compiled, however please note debug menus and text will be visible within the application. Anything in the dev branch should be considered as unstable and incomplete.

---

**License**
-

WinXI is released under the [GNU General Public License v3.0](https://choosealicense.com/licenses/gpl-3.0/).
