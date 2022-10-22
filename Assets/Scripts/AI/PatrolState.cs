using System.Numerics;
using UnityEngine.AI;

public class PatrolState : IDroneState
{
    public IDroneState DoState(DroneController drone)
    {
        if (ReachedDestination(drone))
        {
            return drone.lookAroundState;
        }
        return drone.patrolState;
    }

    public void onEnter(DroneController drone)
    {
        drone.navMeshAgent.destination = drone.movePositionTransform.position;
    }

    public void onExit(DroneController drone)
    {
    }

    private bool ReachedDestination(DroneController drone)
    {
        return drone.navMeshAgent.pathStatus == NavMeshPathStatus.PathComplete;
    }
}