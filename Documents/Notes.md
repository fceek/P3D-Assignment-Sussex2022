# General Planning

- Protagonist: Musician
- Pick-ups: Vinyl
	Throw through a specific window: to *partical effect*
	Other: *physics*
- Interactions: Instruments
- 2-Floor Building: Home, house in the woods
- Triggers: automatic doors, etc.
- Animations: (?)

## Failures Building the House

 - Floor sizing
 - The orientation, position of balconies and views, front door vs garden door

## Solving lighting problems

- Promote version to 2022.1.23 even 2023.1.0a20 alpha
- light probe
- adjust lightmap parameters, contact shadow
- reflection probe

## Possible Improvements

- Furthur improve samples when baking lightmap before submission
- Promote handtooltip to a HUD manager

## Animation

- Animating root objects made single axis rotation not available, use the ReversedWindows root for temp solution

## Code Struct

- Don't start game-standard framework at the beginning
- Find hard to arrange the scripts
- Create a simple manager script for management
- Have managers hard coded in script because just few modules