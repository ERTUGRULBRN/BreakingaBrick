using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScripts : MonoBehaviour
{
    public UnityEngine.UI.Text point;
    // Start is called before the first frame update
    void Start()
    {
        point.text = "Point: " + GameObject.FindObjectOfType<Point>().GetComponent<Point>().PointGET();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GamesScene()
    {
        SceneManager.LoadScene("StartScene");
    }
    
}
