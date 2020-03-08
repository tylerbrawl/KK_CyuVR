**DISCLAIMER**: This project is an effort to decompile and improve an existing plugin that was not written by me.  
The original plugin can be found here: https://vr-erogamer.com/archives/454

# KK_CyuVR
> Adds kissing functionality in Koikatsu official VR  


## Prerequisites  
- Afterschool DLC  
- [Koikatsu Official VR Patch 0531](http://www.illusion.jp/preview/koikatu/download/vr.php)  
- BepInEx 4 and above  
- (optional, strongly recommended): [CrossFader](https://vr-erogamer.com/wp-content/uploads/CrossFader.zip) plugin
- (optional, recommended): [KoikatuVRAssistPlugin](https://mega.nz/#!YQZyWRwQ!C2FX0Iwp-X7F5z55ytTlQGkjfqH6kQP-wcDPfNBvT0s) plugin



## Installation
Place **KK_CyuVR.dll** in BepInEx root folder.  
This is a BepInEx 4 plugin, to run it with BepInEx 5 you'd need [BepInEx 4 Patcher](https://github.com/BepInEx/BepInEx.BepInEx4Upgrader). (Included within HF Patch)

Installation of the [**CrossFader.dll**](https://vr-erogamer.com/wp-content/uploads/CrossFader.zip) plugin found on https://vr-erogamer.com/archives/527 is strongly recommended to ensure smooth animation in and out of kissing.   
(Install by placing in BepInEx root folder alongside KK_CyuVR.dll)

Also recommended is the [**KoikatuVRAssistPlugin**](https://mega.nz/#!YQZyWRwQ!C2FX0Iwp-X7F5z55ytTlQGkjfqH6kQP-wcDPfNBvT0s) plugin found on https://vr-erogamer.com/archives/322, for easier movement and better access to actions in VR. With it installed, one can rotate and move the camera by the controller while in Action (Caress) Mode by holding the trigger button. While the UI menu is visible, hold the grip button for 1 second to freeze it in place, and drag and move it by holding the grip button. Double click the grip button to return the menu to your controller.

## Configurations
Configurations are located in *config.ini* in the BepInEx root folder, under section **[bero.cyu.cyuvr]**.  

***It is recommended to adjust the configs via the in-game plugin settings page *(accessible outside of VR)* instead of directly editing the config file.***
- **Eyes Animation Openness (EyesMovement)** - Maximum openness of eyes and eyelids during kissing. Set to 0 to keep eyes closed during kiss **(0-100, Default: 30)**  

- **Girl Neck Elevation (KissNeckAngle)** - Head elevation of the female character during kissing. **(Default: 0.2)**   

- **Increase Kiss Intensity by Groping (GropeOverride)** - If enabled, kissing motion speed in caress mode will depend on the intensity of touching and dragging the girl, ignoring the maximum value set by *KissMotionSpeed*. **(Default: true)**  

- **Kiss Activation Distance (KissDistance)** - Distance within which to start kissing when not in caress mode. Unit in meters approximately **(Default: 0.18)**  

- **Kiss Activation Distance in Caress Mode (KissDistanceAibu)** - Distance within which to start kissing in caress mode. Unit in meters approximately **(Default: 0.35)**  

- **Kiss Intensity in Caress Mode (KissMotionSpeed)** - Default speed of kissing motion in caress mode. **(0.1-1.5, Default: 0.1)**  

- **Mouth Movement** - Mode of tongue and mouth movement (french kiss) - **Auto** will enable tongue and mouth movement when character is in "lewd" state OR when female character's excitement gauge is above 70 (climax threshold). **ForceOn** will enable tongue and mouth movement at all times, and **ForceOff** will disable it completely. **(Default: Auto)**  

- **Player Mouth Offset (MouthOffset)** - *Negative* vertical offset to player's mouth (increase this value to make your own mouth lower). Affects calculation of the kiss activation distances and attachment point of saliva string. **(Default: 0.12)**  


## Notes and Limitations
- Unknown compatibility with Koikatsu Party (Steam release)  
- Currently does not work in the unofficial VR mod for main game.
- In **caress mode**, the girl will lean forward to initialize kissing. Approach the girl slowly to avoid ~~bumping~~ clipping into her head.  
- This plugin will only enable kissing in situations where it's possible to kiss as in the non-VR version of the game. Therefore, it would not work in 3P, Darkness mode...etc.  

## Credits
All credit of the plugin up to version 0.0.4 goes to the unknown developer who made this plugin.  
