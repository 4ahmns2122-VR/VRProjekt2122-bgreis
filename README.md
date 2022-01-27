# XRInteractionToolkitTemplate

### Project description: 
This project serves as sample project for spatial audio. Explore sound in its basics in virtual reality (VR).

You visit an Advent market, but you can't leave it until you complete the 2 tasks. The City, which is build like a labyrinth, is based in a Winter-Night Setting.
By audibly advertising the stalls, the player is lured through the maze. At the end the door of the advent market is open and the player can leave it again. 

### MVP:
  - Movement in the Maze with Quest/XR Device Simulator (teleport)
  - 2 Games
      - can aiming
         -You have to throw a ball into 10 cans until every can collided with the Collider
         -example image at "VISUALS"
          - cans are making a sound after getting hit by the ball
          - can counter goes up by every can that falls off (max. 10)
          - ball repawns after colliding with a collider after hitting the cans.
      - getting a mug and putting it back
         -You have to get a mug which stands on a table and then you have to put the mug back
         -example image at "VISUALS"
          - you can grap the mug with your hand in VR/XR Device Simulator
          - then you walk around a few corners 
          - then you place the mug on the second table
          - can makes sounds at colliding with the tables
  - Audio
      - Atmosphere
        -music typically for a Advent Market
        -people talking typically for a Advent Market
      - Shop owner
        -first owner applies for a can aiming game
        -second owner applies for a mug carring game 
      - Game Sounds
        -falling cans sound
        -mug colliding with a table sound
        
### Milestones:
1. 25.November.2021
  - round structure & movement Unity, playable on Quest
2. 23.December.2021
  - basic game functions of 2 minigames / first small sounds
3. 20.January.2022
  - 3 Working mini-games that work on the quest + sounds

### Development platform: 
OS: Windows 10, Game Engine: Unity 2020.3.18f1, Visual Studio 2019, XR Interaction Toolkit

## Software/Hardware Requirements: 
Oculus hardware requirements https://support.oculus.com/248749509016567/ You need a VR headset in this case an Oculus Rift/Quest/Quest2

When downlaoded, you have compile time errors in the project. To solve them install the XR interaction toolkit package via the Package Manager. (!Enable in Advanced Settings Preview Packages).

### Target platform: 
Oculus Rift/S; Quest/2

### Visuals: 
<img width="1292" alt="Screenshot 2022-01-27 at 13 02 24" src="https://user-images.githubusercontent.com/72389948/151355491-543640a4-e966-4e42-8d6e-70864fb99732.png">
<img width="1302" alt="Screenshot 2022-01-27 at 13 03 20" src="https://user-images.githubusercontent.com/72389948/151355498-b39e6581-c5b7-4cb9-b2ff-86071f9976c7.png">
<img width="1295" alt="Screenshot 2022-01-27 at 13 04 19" src="https://user-images.githubusercontent.com/72389948/151355508-f4743443-03b9-4ad4-add7-22d9880e0752.png">

Video coming soon!

### Third party material: 
For testing without a headset, use the XR Device Simulator (included in the xr interaction toolkit package):
https://www.youtube.com/watch?v=d4bTpkvBwrs

### Limitations/Problems: 
XR Device Simulator teleport into the ground with depug view (works on Quest)

Copyright by bgreis
