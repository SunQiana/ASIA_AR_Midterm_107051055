using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public Transform Turtle;
   public Transform Slime;

     Animator TurtleAnim;
     Animator SlimeAnim;

     void Start()
     {
         TurtleAnim=Turtle.GetComponent<Animator>();
         SlimeAnim=Slime.GetComponent<Animator>();
     }

     public void AttackAnim()
     {
       TurtleAnim.SetTrigger("攻擊");
       SlimeAnim.SetTrigger("攻擊");
     }
     public void GetHurt()
     {
       TurtleAnim.SetTrigger("受攻擊");
       SlimeAnim.SetTrigger("受攻擊");
     }
     public void Happy()
     {
       TurtleAnim.SetTrigger("高興");
       SlimeAnim.SetTrigger("高興");
     }
     public void Stun()
     {
       TurtleAnim.SetBool("暈眩");
       SlimeAnim.SetBool("暈眩");
     }

}
