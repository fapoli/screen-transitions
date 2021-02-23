# ScreenTransitions
An Unity Component which allows playing transition animations between scenes. 

## Package Contents
The project is divided into 3 folders:

**Prefabs** contains the actual prefab (called ScreenTransitions) that should be added to all your scenes.

**Animations** contains the animation files.

**Scripts** contains the code for the component, which should be used as a singleton.

## Usage
Just add the ScreenTransitions prefab into your scene, and call the singleton from your code. There are *two* main functions that you can invoke:

**void PlayStart(string animationName)** plays the first part of the transition animation.

    ScreenTransitions.instance.PlayStart("CrossFade");

**void PlayEnd(string animationName)** plays the last part of the transition animation.

    ScreenTransitions.instance.PlayEnd("CrossFade");

## Available Transitions

* CrossFade
