A demo project demonstrating how to use the new URP system in order to create a postprocessing outline shader in Unity.

Based on two tutorials:
https://www.youtube.com/watch?v=ehyMwVnnnTg (Game Dev Guide)
https://www.youtube.com/watch?v=VGEz8oKyMpY (Daniel Ilett)

Since the Game Dev Guide tutorial, URP has become the default, which is not compatible with the Postprocesssing Stack V2. The solution is to use the builtin shader solution to URP. 
To make postprocessing effects, you add passes to a renderer. The demo project uses two renderers: one for the outline camera, and one for the main camera.
The outline camera samples a depth texture, and using edge detection methods, creates a mask for the edges. It then renders this mask to a texture for the main camera to use.
The main camera samples the texture and draws outlines of a specified color wherever the mask tells it to.
There are two parts to a renderer: the renderer itself, and renderer data assets. The data asset tells the renderer how to actually render, and this is where you add passes.
To add a postprocessing effect, add a FullScreenRenderPass to the renderer, and create a material from a shader graph and assign it to the Material field of the FullScreenRenderPass.

Limitations: The outline render texture is set to a fixed 1920x1080. The application must be locked to a 16:9 ratio, otherwise the render texture will be scaled in a way that breaks the effect. Could potentially be fixed by changing how the main camera samples the mask.

All code and assets in this repository are licensed under the CC0 1.0 Universal deed and are public domain.
You are free to copy, modify and distribute this work, even for commercial purposes, without asking permission. No credit is required to be given to the author.
