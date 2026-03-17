using UnityEngine;

public class bullet_collection_player2 : MonoBehaviour
{
    public int reload = 0;
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Hit: " + other.gameObject.tag); //checks if the player is touching with a object
        if (other.gameObject.CompareTag("Bullet"))
        {
            reload++;
            Destroy(other.gameObject);
            Debug.Log("Ammo: " + reload);
        }
    }
}
