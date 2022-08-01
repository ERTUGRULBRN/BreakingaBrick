using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsControl : MonoBehaviour
{
    public GameObject collision;
    public AudioClip audio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision2D)
    {
        AudioSource.PlayClipAtPoint(audio, transform.position);
        Vector3 pos = collision2D.contacts[0].point;
        GameObject go = Instantiate(collision, pos, Quaternion.identity) as GameObject;
        Destroy(go, 1f);
    }
}
