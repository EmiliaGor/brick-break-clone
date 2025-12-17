using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class startGame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Button button;
    //score scriptable object for reseting it after starting new game
    public scorestorage score;

    void Start()
    {
        Button btn = button.GetComponent<Button>();
		    btn.onClick.AddListener(TaskOnClick);
        score.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TaskOnClick()
    {
		  SceneManager.LoadScene("Assets/Scenes/main scene.unity");  
	  }
}
