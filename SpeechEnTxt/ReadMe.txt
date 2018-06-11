reference to: http://www.bubuko.com/infodetail-1169054.html

How to install more voices to Windows Speech?



    !!!WARNING!!!

    This involves manual edits to your registry. If you mess it up, don‘t blame me. Do at your own risk.

    Step 1 --------------------------------------------------------------------------

    Install the Speech Platform v11 / Win10 should have been installed a default one.

    a) go here: http://www.microsoft.com/en-us/download/details.aspx?id=27225
    b) click "Download"
    c) select the "x64_SpeechPlatformRuntime\SpeechPlatformRuntime.msi"
	
	PS:to install x64 or x32, the APP should be compiled with the right version of the platformruntime. Almost I prefer to x32. Perhaps, the default version in system should be x32 for x32 and x64 system. Because I installed without testing, I do not know which is the default one.

    d) run the installer (duh :P)

    Step 2: --------------------------------------------------------------------------

    Get the alternate voices

a) go here: http://www.microsoft.com/en-us/download/details.aspx?id=27224
b) click "Download"
c) select the voice files you want. They are the ones that have "TTS" in the file name. 

    There are 6 English (all female). I have not listened to the other languages, so I dont know how they sound. GB_Hazel and US_ZiraPro are IMO the better sounding voices.

MSSpeech_TTS_en-CA_Heather
MSSpeech_TTS_en-GB_Hazel
MSSpeech_TTS_en-IN_Heera
MSSpeech_TTS_en-US_Helen
MSSpeech_TTS_en-US_ZiraPro
MSSpeech_TTS_en-AU_Hayley

d) run the installers for each (duh :P)

    Step 3: --------------------------------------------------------------------------

    Extract the registry tokens

a) Open Regedit
b) Under - HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Speech Server\v11.0\Voices - right click the "Tokens" folder and export. Save this file to your desktop as voices1.reg so it will be easy to find later.
b) Under - HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Speech Server\v11.0\Voices - right click "Tokens" and again export it, again to the desktop. Call it voices2.reg.

    Step 4: --------------------------------------------------------------------------

    Edit the voices1/2 files

a) open Voices1.reg in Notepad.
b) press "cntrl + H"
c) enter \Speech Server\v11.0\ into the "Find What" field
d) enter \Speech\ into the "Replace With" field
e) click "Replace All"
f) Save File
g) Repeat a-f with the Voices2.reg file

    Step 5: --------------------------------------------------------------------------

    Merge the new Registry files into your registry

a) double click to "run" both Voices1.reg and Voices2.reg
b) Click "Yes" when it prompts

    You should now have access to the new voices in Voice Attack, and in the Windows TTS options menu.

    This process may also work with other voice packs.

voice resources:
https://www.microsoft.com/en-us/download/details.aspx?id=27224



