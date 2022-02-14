using UnityEngine;
using System.Collections;
using System.Collections.Generic;

    public class PlayerController : MonoBehaviour
    {
    public bool jumping = false;
    public float movespeed = 5f;
        void Start(){

    }

    void Update(){
        while(jumping==true){ //if space pressed 
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0f,8f),ForceMode2D.Impulse);
                jumping =false; //jump then set jumping to false 
        }
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),0f,0f);
        Vector3 movement2 = new Vector3(Input.GetAxis("Vertical"),0f,0f);
        transform.position +=movement* Time.deltaTime * movespeed;

    }
    void Jump(){ //jumping method 
        if(Input.GetButtonDown("Jump")){
            jumping=true;
        }
    }  

    


    
}
