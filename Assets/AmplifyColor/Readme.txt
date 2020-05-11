# Amplify Unity Products

  While this package is provided, as is, for free, we develop and maintain professionally 
  created solutions used by thousands of developers. We invite you to check our current 
  projects, and to join our growing [Discord Community](https://discord.gg/SbNs7zK).
  
  [Amplify Shader Editor](https://assetstore.unity.com/packages/tools/visual-scripting/amplify-shader-editor-68570?aid=1011lPwI&pubref=GitHub) - Award-winning node-based shader creation tool
 
  [Amplify Impostors](https://assetstore.unity.com/packages/tools/utilities/amplify-impostors-beta-119877?aid=1011lPwI&pubref=GitHub) - 1-Click Impostor Creator
 
  [Amplify LUT Pack](https://assetstore.unity.com/packages/vfx/shaders/fullscreen-camera-effects/amplify-lut-pack-50070?aid=1011lPwI&pubref=GitHub) - 200+ LUTs for Amplify Color and Unity PPS
 
# Amplify Color

  Amplify Color was the first modern, high-performance LUT-based post-effect color 
  grading solution for Unity. It was originally named Color3 and was the first plugin
  we released on the Unity Asset Store, back in February of 2012.  
  
  <p align="center"><img src="https://i.imgur.com/KHcQ4ua.jpg"></p>

  This color grading post-effect enabled the ability to do complex grading operations 
  at a minimal and stable performance cost. The performance cost was so low, that it 
  quickly became viable for use even on smartphones.

  Amplify Color would automatically export a frame of the current camera directly to 
  Photoshop, allow you to use common color and tone operations on the image, then import
  the LUT back to Unity for storage in the project.  

  It was also the first to include the ability to mask and blend different LUTs, create 
  context Volumes to enable LUT and generic property blending based on camera location 
  and many other innovative features.
  
  This package was for sale on the Unity Asset Store between 2012 and 2019 with an
  average rating of 5 stars. It is now deprecated and we no longer support it, so we 
  are releasing it to open-source world under the MIT License.
	
# Description

  Amplify Color, previously known as Color3 Advanced Grading, brings industry-level 
  color grading to your game by mimicking the color transforms made inside a tool 
  like Photoshop; e.g. change contrast, color curves, exposure, saturation, hue and 
  more, or a combination of all transforms at once. So fast, it runs on mobile.

# Features

  * Industry level color grading
  * High-performance and Mobile-ready
  * Semi-automated Photoshop Workflow
  * File-based mode for other Image Editors
  * Dynamic blending between profiles
  * Texture-based per-pixel masking
  * All Color Alterations Supported
  * Oculus/VR friendly
  * Color Volumes
  * Third-party Effects Volume Blending
  * Base and Volume LUT mixing
  * 2D Color Volumes
  * Depth-based Masking
  * HDR Tone Mapping
  * HDR Dithering
  
# Supported Platforms

  All platforms
	
# Software Requirements

  Minimum

    Unity 4.6.8f1

# Quick Guide

  1) Export a reference screenshot from Unity, using "Window/Amplify Color/LUT Editor"
    
  2) Open reference screenshot in your favorite image editing software
    
  3) Apply any color changes you desire. E.g. hue, exposure
    
  4) Save and load it into Unity using "Window/Amplify Color/LUT Editor"
    
  5) Amplify Color automatically generates a texture containing a color grading 
     look-up-table (LUT).
       
  6) Apply a "Amplify Color" component to your main camera.
    
  7) Assign the previously generated LUT texture to the effect
    
  8) Enjoy changes you made to the reference screenshot applied to every frame of your game.

# Documentation

  Please refer to the following website for an up-to-date online manual:

    http://amplify.pt/unity/amplify-color/manual

# Acknowledgements

  This project was originally built in partnership with Tiago Carvalho
  
    http://pt.linkedin.com/pub/tiago-carvalho/18/aa1/306
