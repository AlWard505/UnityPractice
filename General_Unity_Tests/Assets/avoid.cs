using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avoid : MonoBehaviour
{
    public GameObject bullet;
    public GameObject wall;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Physics2D.IgnoreCollision(bullet.GetComponent<Collider2D>(), wall.GetComponent<Collider2D>(), true);
    }
}
