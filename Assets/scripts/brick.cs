using Unity.VisualScripting;
using UnityEngine;

public class brick : MonoBehaviour
{
    private int hp;
    private SpriteRenderer spriteR;
    private int spriteVersion = 0;
    private Sprite[] sprites;
    //score scriptable object
    public scorestorage score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hp=3;
        sprites = Resources.LoadAll<Sprite>("brick sprites");
        spriteR = spriteR = gameObject.GetComponent<SpriteRenderer>();
        // Debug.Log(sprites[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "ball")
        {
            // Debug.Log(hp);
            --hp;
            if (hp == 0)
            {
                Destroy(this.gameObject);
            }
            else
            {
                spriteVersion++;
                spriteR.sprite = sprites[spriteVersion];
            }
        }
    }
    void OnDestroy()
    {   
        //so it doesn't add score on scene loading
        if(hp==0){
            ++score.score;
        }
    }
}


