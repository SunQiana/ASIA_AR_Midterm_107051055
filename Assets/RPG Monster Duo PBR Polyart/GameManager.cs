
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

     public void Attack()
     {
       TurtleAnim.SetTrigger("attack");
       SlimeAnim.SetTrigger("attack");
     }
     public void GetHurt()
     {
       TurtleAnim.SetTrigger("hit");
       SlimeAnim.SetTrigger("hit");
     }
     public void Happy()
     {
       TurtleAnim.SetTrigger("happy");
       SlimeAnim.SetTrigger("happy");
     }
     public void Stun()
     {
        TurtleAnim.SetTrigger("dizzy");
        SlimeAnim.SetTrigger("dizzy");
        
       
     }

}
