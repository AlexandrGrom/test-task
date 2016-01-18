
# Test task for Bully! developers

## Brief

Create a mobile app for Android and iOS in Unity using reference and
short description below.

## Description:

AR app that uses the marker image given to present a 3D model of an old watch, 
its hands show current time and day of week. Watch has skins that include:
color of seconds hand, language of days, GMT timezone. There are two buttons
to cycle though skins. Clicking sound is used as feedback to button clicks.
The watch slowly rotates and small metal balls are popping out of its top
when you click it. To create an old-school effect a camera effect is used a
vignette with some grain noise.

## Hints

Use:

* Git for version control, a gitignore and git flow model;
* Vuforia for AR experience and given marker;
* `ScriptableObject` for skins (material, day names, time offset);
*  Custom inspector for skins to validate constrain: week can only have 7 days;
* `OnRenderImage` and a CG shader to create vignette effect;
* `AnimationCurve` and SetFloat to animate vignette flickering;
* C# interface for clickable objects;
* Singletons for global managers


## What is important in this task:

* Code performance and architecture;
* Scene organization, asset names;
* Project structure, prefabs, hierarchy;
* Using correct asset serialization editor setting for git;
* Code style: variable names, regions, reasonable comments in English.

## What is not important

* No need to model watch - use standard 3D primitives provided by Unity;
* No need to match reference watch model 100% precise;
* No need to match materials and colors 100% precise;
* No need to use exact font;
* IDE used (better be Vim but anyway).


## Bonus (for ninjas)

* `+1` Use pool manager singleton and reuse small spheres
* `+3` Implement a screen space UI button to capture screenshot
* `+4` Implement screenshot sharing on Android and iOS
* `+10` Implement LUT color grading that work on mobile (i.e with no Texture3D)
* `+15` Create a wormhole effect under watch, that distorts real word camera feed

## References

TODO: add




