# Week-08

## Syphon

[What is Syphon?](http://syphon.v002.info/)
+ Caution! Mac only!
	+ Windows alternatives for those interested (won't work in our mapper)
		+ [Spout](http://spout.zeal.co/)
		+ [Wyphon](https://wyphon.wordpress.com/)

### Syphon in Unity

First get a few things ready:

1. Edit -> Project Settings
2. Enable "Run in Background"
	+ This allows your Unity project to run live in the background, so that you can have a projection mapping program open simultaneously.
3. Open "funnel.unitypackage" with your Unity project open
4. Attach "funnel.cs" to your Main Camera

### Changes to projection mapper

I added Syphon support, you'll need to add the "Syphon" library in Processing. With Processing open:

1. Sketch -> Add Library -> Import Library
2. Search "Syphon", select, and install

New Controls:
+ Pressing '1' adds an image
+ Pressing '2' adds a movie
+ Pressing '3' adds the latest Syphon source

### How to use Audio scripts for this week
1. Add AudioProcessor.cs to Main Camera. This will add an AudioSource component automatically.
2. AudioSource is just something that plays audio files. Add the "Broke_For_Free_-_05_-_Something_Elated.mp3" track to the "AudioClip" area
3. Add a cube to your scene and attach the "BeatExample.cs" script to it

### Thursday Challenge
1. Assemble a team of 3-4 people
2. Stage a "scene" with 3+ real world objects
3. Use Unity to activate the objects on command using mouse and/or keyboard input

## Homework - Project 2: 
+ Propose a projection mapping project. This can include projecting onto exterior buildings and architecture, but will have to be reproducible in class (via a model). This will be done in groups of 4~ people. Only one proposal must be written but EVERYONE must include it in their github repo, along with the names of each student involved.
+ Proposals should:
	+ Be 10+ sentences
	+ Include a conceptual explanation of what you are doing
	+ Include a technical explanation of what you are doing (including any props you need, like boxes)
	+ Identify technical challenges you expect to encounter, and your plan to succeed

+ Bring in props on Tuesday!