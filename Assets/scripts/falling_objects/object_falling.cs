using UnityEngine;

public class object_falling : MonoBehaviour
{
    
    //This will be set when it reach 30/60 sec pass the obejcts will start falling  
    
    public GameObject object_fall;
    public Transform[] object_spawner;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        if (gameObject.CompareTag("above_object1")) // will check which is above_object1 or 2
        {
            InvokeRepeating("Spawnobjects", 40f, 1f); //5 will be change to 40
        }
        else if(gameObject.CompareTag("above_object2"))
        {
            InvokeRepeating("Spawnobjects",60f, 1f); //10 will be change to 60
        }
        else if(gameObject.CompareTag("above_objects3"))
        {
            InvokeRepeating("Spawnobjects",70f, 1f); 
        }
        else if(gameObject.CompareTag("above_objects_4"))
        {
            InvokeRepeating("Spawnobjects",80f, 1f); 
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
