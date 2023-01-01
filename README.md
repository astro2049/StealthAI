# AI Drones

Drones have **vision** and **hearing**.

## Vision

Drone sight has a distance and an angle, implemented by ray cast.

## States

Using a state machine to switch between behaviors of AI drones:

![Stealth AI - State Machine](https://user-images.githubusercontent.com/45759373/210186398-53502fcd-e5b5-4037-9398-21bcfcde234b.png)

1. *Idle* (initial state)
2. *Patrol* - Pick a random patrol location and auto-path to it
3. *Look Around* - Stay put and look around
4. *Alert* - Transition state to *Chase*, when the player can be seen. Duration - 1s
5. *Investigate* - Go to where the player is last seen at
6. *Chase* - Chase the player
7. *Deactivated* - Shut down & Fall to the ground
8. *Stunned* - Power down for a few seconds and resume to *Look Around*. Duration - 5s

## Map Set Up

- Player
   - Tag - Player
- Map plane
   - Navigation Static
- Walls
   - Navigation Static
- Drone
   - Tag - Drone

**And, bake the Nav Mesh*.

# References

- Unity User Manual

  https://docs.unity3d.com/2022.1/Documentation/Manual/UnityManual.html

- State Machine

  https://www.youtube.com/watch?v=nnrOhb5UdRc

- AI Sight

  https://www.youtube.com/watch?v=j1-OyLo77ss

- Field of View Effect

  https://www.youtube.com/watch?v=CSeUMTaNFYk

- Chase

  https://www.youtube.com/watch?v=wp8m6xyIPtE

