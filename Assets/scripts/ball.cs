using UnityEngine;
using UnityEngine.SceneManagement;
public class ball : MonoBehaviour
{
    public Rigidbody rb;
    public float thrust = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(0, 10, 0, ForceMode.Impulse);
        SceneManager.LoadScene("Assets/Scenes/UIScene.unity", LoadSceneMode.Additive);       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            thrust = -(collision.collider.transform.position.x - collision.contacts[0].point.x); 
            // right now it continously adds momentum if you don't hit with center of the paddle
            //can be edited later for polish
            //makes the general speed of ball vary a lot rn
            rb.AddForce(thrust*2, 0, 0, ForceMode.Impulse);        
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "death")
        {
            SceneManager.LoadScene("Assets/Scenes/Game Over.unity");
            SceneManager.LoadScene("Assets/Scenes/UIScene.unity", LoadSceneMode.Additive);
        }
    }
}
