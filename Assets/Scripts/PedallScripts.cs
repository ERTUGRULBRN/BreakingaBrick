using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedallScripts : MonoBehaviour
{
    private GameObject ball;
    public AudioClip audio;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("ball");
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
       // transform.position = new Vector3(Mathf.Clamp(mousePos.x,-5.90f,5.90f), transform.position.y, transform.position.z);
        transform.position = new Vector3(ball.transform.position.x, transform.position.y, transform.position.z);

        
    }
    void OnCollisionEnter2D(Collision2D collision2D)
    {
        AudioSource.PlayClipAtPoint(audio, transform.position);
    }
}
