# mksheet_vtex_gui
A simple GUI interface for creating animated vtf files, primarily intended for use in TF2 particle effects.

## Installation
Download and run mksheet_vtex_gui.exe from the latest release. 

If you encounter issues related to Visual C++, use mksheet_vtex_gui_selfcontained.exe instead.

## Usage
1. Ensure that "Team Fortress 2 folder" points to the location of your TF2 installation. 
    * This is most commonly "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2".
    
2. Place desired animation frames in an accessible folder, naming them with a common prefix and numbering them in order.
    * For example: _foo\bar**00**.png, foo\bar**01**.png, foo\bar**02**.png_, etc..
    
3. Click the [ ... ] button next to "Folder containing TGA frames" and select the folder you put the images in. In our example, this would be _foo_.

4. Enter the common prefix you used in step 2 into "Frame filename prefix". In our example, this would be _bar_.

5. If your frames are saved as .png files, click "Batch convert PNG to TGA. If your frames are saved as .tga files, continue to 6.

6. Enter a desired sprite name. 
    * Check "Multiple sequences" if you would like every frame to be contained in its own sequence (commonly used in tandem with the Sequence Random initializer to randomize particle appearance)
    * Check "Loop Animation" if you would like your animated sprite to loop.

7. Click "Generate MKS File". If you would like to [edit the mks](https://developer.valvesoftware.com/wiki/Animated_Particles#Creating_an_MKS_File), do so now.

8. If you would like to set any [Vtex compile parameters](https://developer.valvesoftware.com/wiki/Vtex_compile_parameters), click "VTEX Config" and type them into the popup.

9. **Click "Generate VTF" to compile the animated texture.

10. Optional: Use the "Blend Frames", "Depthblend", and "Additive" checkboxes to configure common VMT parameters and click "Generate VMT" to create a VMT file.

## Common Issues
- All frames should fit on a **2048x2048** canvas. If this is not the case, Vtex will silently fail and the program will crash.
- Sometimes, frames will be ordered incorrectly in the MKS. If you cannot get the program to correctly order the frames automatically, manually edit the MKS file after it is generated.
