# AI Drones

## Sight

Drone sight has a radius and angle, implemented by sphere overlap & ray cast.

## States

Using a state machine to switch between behaviors of AI drones:

- Idle (initial state)
- Patrol - Pick random patrol locations and auto-path to them, using a navmesh
- Look Around - Wait for a few seconds before heading to the next patrol location
- Chase - Chase the player, if the player is in sight
- Deactivated - Shut down & Falls to the ground

# References

- Unity User Manual

  https://docs.unity3d.com/2022.1/Documentation/Manual/UnityManual.html

- State Machine

  https://www.youtube.com/watch?v=nnrOhb5UdRc

- AI Sight

  https://www.youtube.com/watch?v=j1-OyLo77ss

- Chase

  https://www.youtube.com/watch?v=wp8m6xyIPtE

