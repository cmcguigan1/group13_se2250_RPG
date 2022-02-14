using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScripts : MonoBehaviour
{
   public void OnTriggerEnter2D(Collider2D colide){
        if(colide.gameObject.tag=="coin"){
            Destroy(colide.gameObject);
        }
    }
}
