using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerControl : MonoBehaviour
{
    public Text TextScore;
    private int currentscore;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
    }
    public void Updatescore(int points)
    {
        currentscore = currentscore + points;
        TextScore.text = "Score: " + currentscore;
    }
}