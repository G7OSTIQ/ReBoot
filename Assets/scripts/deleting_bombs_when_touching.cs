using UnityEngine;

public class deleting_bombs_when_touching : MonoBehaviour
{

    public bool boms_touching_ground = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            boms_touching_ground = true;
            Destroy(gameObject);
        }
    }
}
