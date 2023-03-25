using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneManager : MonoBehaviour
{
    public GameObject dronePrefab;
    public int numDrones = 5;
    public string strategy = "circuit"; // options: circuit, circle, uam, objective

    private List<Drone> drones = new List<Drone>();

    void Start()
    {
        // Instantiate drones
        for (int i = 0; i < numDrones; i++)
        {
            GameObject droneGO = Instantiate(dronePrefab);
            Drone drone = droneGO.GetComponent<Drone>();
            drones.Add(drone);
        }

        // Set strategy for drones
        switch (strategy.ToLower())
        {
            case "circuit":
                foreach (Drone drone in drones)
                {
                    drone.SetMovementStrategy(new CircuitStrategy());
                }
                break;
            case "circle":
                foreach (Drone drone in drones)
                {
                    drone.SetMovementStrategy(new CircleStrategy());
                }
                break;
            case "uam":
                foreach (Drone drone in drones)
                {
                    drone.SetMovementStrategy(new UamStrategy());
                }
                break;
            case "objective":
                foreach (Drone drone in drones)
                {
                    drone.SetMovementStrategy(new ObjectiveStrategy());
                }
                break;
            default:
                Debug.LogError("Invalid strategy selected: " + strategy);
                break;
        }
    }
}

