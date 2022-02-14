using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    public float speedy = 3f;
    //public int damage=5;


    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            transform.position.x + (-1*speedy * Time.deltaTime),
            transform.position.y,
            transform.position.z);

    }
    //private void OnTriggerEnter2D(Collider2D colly){}


}
