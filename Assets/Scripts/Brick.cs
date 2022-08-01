using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public GameObject collision;
    public Sprite[] brickSprites;
    private int maxNumberHits;
    private int numberHits;
    public static int totalBrick;
    private Point point;
    public AudioClip audioCollision; 
    public AudioClip audioDestroy;
    // Start is called before the first frame update
    void Start()
    {
        maxNumberHits = brickSprites.Length + 1;
        totalBrick++;
        point = GameObject.FindObjectOfType<Point>().GetComponent<Point>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.name.Equals("ball"))
        {
            point.PointUP();
            numberHits++;
            
            if (numberHits >= maxNumberHits)
            {
                totalBrick--;
                if (totalBrick <= 0)
                {
                    GameObject.FindObjectOfType<GameControl>().GetComponent<GameControl>().NextScene();
                }
                Vector3 pos = collider.contacts[0].point;
                GameObject go = Instantiate(collision, pos, Quaternion.identity) as GameObject;
                Color brickColor = GetComponent<SpriteRenderer>().color;
                go.GetComponent<ParticleSystemRenderer>().material.color = brickColor;
                Destroy(go, 1f);
                Destroy(gameObject);
                AudioSource.PlayClipAtPoint(audioDestroy, transform.position);

            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = brickSprites[numberHits - 1];
                AudioSource.PlayClipAtPoint(audioCollision, transform.position);
            }


        }
    }
}
