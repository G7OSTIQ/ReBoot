using UnityEngine;

public class object_falling : MonoBehaviour
{
    public GameObject object_fall;
    public Transform[] object_spawner;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        if (gameObject.CompareTag("above_object1")) // will check which is above_object1 or 2
        {
            InvokeRepeating("Spawnobjects", 5f, 1f); //2 is there for the amout of time for a bullet to spawn
        }
        else if(gameObject.CompareTag("above_object2"))
        {
            InvokeRepeating("Spawnobjects",10f, 1f);
        }
       
    }

    // Update is called once per frame
    private void Spawnobjects()
    {
        int inside_list= Random.Range(0, object_spawner.Length);
        Transform spawnPoint = object_spawner[inside_list];
        Instantiate(object_fall, spawnPoint.position, spawnPoint.rotation);
    }
}
