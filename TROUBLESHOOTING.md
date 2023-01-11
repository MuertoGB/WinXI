**WinXI Troubeshooting**
-
**Error: "Failed to properly assess the disk. The parameter is incorrect.":-**

Where rare, this issue is encountered whilst running an assessment, and will cause the test to fail. This problem affects the following Windows versions:

```
Windows 7, 32-Bit, 64-Bit
6.1.7600.16976
6.1.7600.21167
6.1.7601.17793
6.1.7601.21940
```

See the knowledgebase article [here.](https://support.microsoft.com/en-us/topic/-the-parameter-is-incorrect-error-message-when-you-run-winsat-in-windows-7-b8c320cc-ce3f-70a7-593e-8aa3ed3b5b5f)

This issue can be resolved by [downloading](https://github.com/MuertoGB/WinXI/tree/dev/Resources/hotfix), and installing the hotfix specific to your architecture.

---
**Message: This system is missing one or more required fonts:-**

WinXI cannot run without required fonts present. This issue can be resolved by ensuring the following fonts are installed:
```
Segoe UI Regular   (segoeui.ttf)
Segoe UI Bold      (segoeuib.ttf)
Segoe UI Semibold  (seguisb.ttf)
Segoe MDL2 Assets  (segmdl2.ttf)
```

Required fonts can be acquired [here.](https://github.com/MuertoGB/WinXI/tree/dev/Resources/fonts)

---
**Message: This Operating is missing vital WinSAT files:-**

Some versions of Windows do not ship with the Windows Experience Index, and without a WinSAT enabled Operating System the application simply cannot run.

If this message is encountered on a WinSAT enabled Operating System, you may have corrupt system files that need repair.

---
**Message: This program requires Windows Vista or later:-**

Operating Systems prior to Vista do not support the Windows Experience Index, WinXI will not run on these systems.

---
**Assessment fails on K/KN versions of Windows:-**

These versions of Windows generally do not ship with Windows Media Player, which is required for the assessment to run. You can attempt to resolved this issue by installing the [Media Feature Pack](https://support.microsoft.com/windows/get-windows-media-player-81718e0d-cfce-25b1-aee3-94596b658287), then restarting your system.

---

**Gaming graphics stuck at 9.9 on Windows 10:-**

Windows 10 no longer uses the D3D assessments, therefore gaming graphics are no longer calculated. Returned scores are a hardcoded sentinel value.

---
**Assessment Error 21:-**

This issue can be causes by the following:
```
Low disk space on the primary system drive
Third party codecs
```

To resolve the issue, check the space on your primary system drive. You may also need to uninstall any third party codecs.

More information on [codecs.](https://en.wikipedia.org/wiki/Codec)

