using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //there can only be one GameManager in each scene

    public int score = 0; //initializing score

    public int targetScore = 1; //initializing variable and amount needed to go to the next scene
    
    public int targetScene = 0; //initializing variable that will keep track of the index of what scene we're in

    public TextMeshProUGUI scoreText; //gives us access to the UI
    void Awake()
    {
        //if there aren't any other singletons of this type in the scene:
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); //keep it
        }

        else //if there are any others:
        {
            Destroy(gameObject); //destroy the extra one
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //setting the UI:
        scoreText.text = "Emeralds: " + score;
        
        //when we reach the targetScore, change scenes:
        if (score >= targetScore)
        {
            targetScene++; //increase the index so it goes to the next scene
            SceneManager.LoadScene(targetScene); //go to the next index scene
            //changes the targetScore by adding and then rounding up so it gets harder every time:
            targetScore = Mathf.CeilToInt(targetScore + targetScore * 1.5f); 
        }
    }
}
