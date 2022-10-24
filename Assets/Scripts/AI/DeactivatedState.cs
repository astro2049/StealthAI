using Unity.VisualScripting;
using UnityEngine;

public class DeactivatedState : IDroneState
{
    public IDroneState DoState(DroneController drone)
    {
        return drone.deactivatedState;
    }

    public void onEnter(DroneController drone)
    {
        drone.navMeshAgent.enabled = false;
        drone.AddComponent<Rigidbody>();
        drone.GetComponent<Rigidbody>().useGravity = true;
    }

    public void onExit(DroneController drone)
    {
    }
}