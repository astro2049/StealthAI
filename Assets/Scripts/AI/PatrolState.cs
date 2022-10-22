public class PatrolState : IDroneState
{
    public IDroneState DoState(DroneController drone)
    {
        drone.navMeshAgent.destination = drone.movePositionTransform.position;
        return drone.patrolState;
    }
}