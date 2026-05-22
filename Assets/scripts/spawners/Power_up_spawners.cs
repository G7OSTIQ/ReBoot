using UnityEngine;

public class Power_up_spawners : MonoBehaviour
{
    //This is the powerup
    public GameObject thunder_power;
    public Transform[] thunder_spawner;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnPowerUP", 35f, 10f); //10 is there for the amout of time for a powerup to spawn
    }

    // Update is called once per frame
    private void SpawnPowerUP()
    {
        int inside_list= Random.Range(0, thunder_spawner.Length);
        Transform spawnPoint = thunder_spawner[inside_list];
        Instantiate(thunder_power, spawnPoint.position, spawnPoint.rotation);
    }
}
