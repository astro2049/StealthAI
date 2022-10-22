using UnityEngine;

public class LookAroundState : IDroneState
{
    public IDroneState DoState(DroneController drone)
    {
        if (drone.lookAroundCountDown <= 0)
        {
            return drone.patrolState;
        }
        drone.lookAroundCountDown -= Time.deltaTime;
        return drone.lookAroundState;
    }

    public void onEnter(DroneController drone)
    {
        drone.lookAroundCountDown = 3;
    }

    public void onExit(DroneController drone)
    {
        drone.lookAroundCountDown = 0;
    }
}