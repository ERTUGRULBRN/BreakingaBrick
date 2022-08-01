using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSound : MonoBehaviour
{
    static bool soundOn;
    // Start is called before the first frame update
    void Start()
    {
        if (!soundOn)
        {
            GameObject.DontDestroyOnLoad(this.gameObject);
            soundOn = true;
        }else
        {
            Destroy(gameObject);
        }

          
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
