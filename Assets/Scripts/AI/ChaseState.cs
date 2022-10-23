public class ChaseState : IDroneState
{
    public IDroneState DoState(DroneController drone)
    {
        return drone.chaseState;
    }

    public void onEnter(DroneController drone)
    {
    }

    public void onExit(DroneController drone)
    {
    }
}