using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float attackCooldown; //before fire next shot 
   private Animator anim; 
   private PlayerController playerMovement; 
   private float coolDownTimer = 1;

   private void Awake(){
       anim = GetComponent<Animator>();
       playerMovement = GetComponent<PlayerController>();

   }
   private void Update(){
       if(Input.GetKeyDown(KeyCode.W)&& coolDownTimer>attackCooldown ){
        Attack();
       }
       coolDownTimer+=Time.deltaTime;
   }
   private void Attack(){
       anim.SetTrigger("attack");
       coolDownTimer=1;
   }
}
