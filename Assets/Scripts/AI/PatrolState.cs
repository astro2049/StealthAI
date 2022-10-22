using UnityEngine.AI;
using Random = UnityEngine.Random;
using Vector3 = UnityEngine.Vector3;

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
        drone.navMeshAgent.destination = GetRandomLocation(drone);
    }

    public void onExit(DroneController drone)
    {
    }

    private Vector3 GetRandomLocation(DroneController drone)
    {
        Vector3 randomLocation = Random.insideUnitSphere * drone.walkRadius;
        randomLocation += drone.transform.position;
        NavMeshHit hit;
        NavMesh.SamplePosition(randomLocation, out hit, drone.walkRadius, 1);
        return hit.position;
    }

    private bool ReachedDestination(DroneController drone)
    {
        return drone.navMeshAgent.pathStatus == NavMeshPathStatus.PathComplete;
    }
}