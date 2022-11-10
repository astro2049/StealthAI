# AI Drones

## Sight

Drone sight has a radius and angle, implemented by ray cast.

## States

Using a state machine to switch between behaviors of AI drones:

1. *Idle* (initial state)
2. *Patrol* - Pick random patrol locations and auto-path to them
3. *Look Around* - Wait for around 2s
4. *Alert* - Go to *Chase* in 1s, if the player is in sight
5. *Chase* - Chase the player
6. *Deactivated* - Shut down & Falls to the ground

## Map Set Up

- Player
   - Tag - Player
   - Layer - Target
- Map plane
   - Navigation Static
- Walls
   - Navigation Static
   - Tag - Wall
   - Layer - Obstuction
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

