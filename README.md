**WinXI**
-
![](Resources/img/app.png)

WinXI, formerly known as *Xiret*, is a simple and powerful tool designed to replace the Windows Experience Index User Interface that was removed in Windows 8.1. It features a beautiful, easy to use UI, no adverts or spam, and is completely free forever. It's compatible with all versions of Windows that can run the Experience Index, however some versions do not include the WinSAT executable or Dynamic Link Library API. Many applications that imitate the experience index either do not work properly, or have many adverts, so I created something better, and free.

_Key features:-_
- Clean, friendly and easy to use UI built for novice and expert users alike
- View and generate Windows Experience Index scores with minimal effort
- Built using the WInSAT API for high compatibility
- Options to save scores as text or an image
- Imgur API for super simple and immediate upload for sharing
- Automatic power adapter detection
- High DPI support
- In-Depth assessment mode
- Option to reset Winsat with one click
- Portable with easily managed settings
- Uncaught exception handling with log generation
- Self monitoring for missing resources like fonts and patches
- The 'Show Hardware' toggle instantly shows you which hardware was rated

---
**Where did you go? Why WinXI?**
-
I took a long hiatus from software development. I will get this out of the way now, I'm no longer actively writing software, and solely focus on my repair business. I won't be releasing any more major versions of this application, only bug fixing. The only reason this is here is for those who keep asking after it, I'm happy you appreciate this software.

For clarification, WSA, NVReform, and other tools have been scrapped. If someone would like the source code, I'll be happy to send it, however they will not be on Git.

This will be the home of WinXI, and all versioning files, etc, that were on my server will be here.

As for a release deadline, there isn't one, just keep checking in, or watch this repo. Currently, I'm reverting partially applied code and systems I was getting ready for the next version, and catching up with Windows 11 fixes, etc.

And as for the new name, let's face it, Xiret was a shit name from the start.

---

**How to build**
-
**You will need:**
- Visual Studio 2019 or newer
- .NET Framework 4.0

Open WinXI.sln in Visual Studio, first you'll need to either disable signing, sign the app yourself by creating a new PFX, or disable the signing class constructor.

**Sign or unsign youself:**
- From the main menu and click "Project > WinXI Properties > Signing"
- Either uncheck `Sign the ClickOne manifests` and `Sign the assembly`, then comment out the code below, or...
- Create a new PFX and sign the assembly and ClickOne manifests, or...
- Ignore everything above and comment out the code below to skip validation

**WinXI/Program.vb:**
```
'Signature validation
RuntimeHelpers.RunClassConstructor(GetType(Signing).TypeHandle)
```

**Build the executable:**
- From the menu, select "Debug" or "Release", your choice
- From the main menu click "Build` > Build Solution", then "Build WinXI"
- In the solution explorer, navigate to "/bin", the newly compiled executable will now be accessible in the folder you chose (Debug, or release)

---

**License**
-

WinXI is released under the [GNU General Public License v3.0](https://choosealicense.com/licenses/gpl-3.0/).
