using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScripts : MonoBehaviour
{
    private GameObject pedal;
    private bool gameActive = false;
    // Start is called before the first frame update
    void Start()
    {
        pedal = GameObject.FindObjectOfType<PedallScripts>().gameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameActive)
        {
            transform.position = new Vector3(pedal.transform.position.x, transform.position.y, transform.position.z);
        }
        if (Input.GetMouseButtonDown(0) && !gameActive)
        {
            gameActive = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);

        }
        
    }
}
