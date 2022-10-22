public class PatrolState : IDroneState
{
    public IDroneState DoState(DroneController drone)
    {
        return drone.patrolState;
    }

    public void onEnter(DroneController drone)
    {
        drone.navMeshAgent.destination = drone.movePositionTransform.position;
    }

    public void onExit(DroneController drone)
    {
    }
}