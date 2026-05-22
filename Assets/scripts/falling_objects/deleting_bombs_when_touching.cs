using UnityEngine;

public class deleting_bombs_when_touching : MonoBehaviour
{

    public bool obj_touching_ground = false;
    public ParticleSystem fallingParticles;
    
    private void OnCollisionEnter(Collision collision)
    {
        
        if (fallingParticles != null)
        {
            ParticleSystem particles = Instantiate(fallingParticles, transform.position, Quaternion.identity);
            particles.Play();
            Destroy(particles.gameObject, 2f); 
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Count_down_Timer timer = FindObjectOfType<Count_down_Timer>();
            timer.countdownAudioSource.Stop();
            timer.backgroundAudioSource.Stop();
            Game_Over.gameover = true;
            GameObject.Find("Timer").SetActive(false); // set the timer hidden 
            
        }
        
        if (collision.gameObject.CompareTag("ground"))
        {
            obj_touching_ground = true;
            Destroy(gameObject);
        }
        
        
        Destroy(gameObject); // need this so that it will delete it self if touching something else
    }
    
}
