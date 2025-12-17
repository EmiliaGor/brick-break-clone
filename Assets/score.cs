using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    //score scriptable object

    public scorestorage scoreValue;
    private TMP_Text mText; 
    void Start()
    {
        mText = this.GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        mText.text = "score: " + scoreValue.score.ToString();
    }
}
