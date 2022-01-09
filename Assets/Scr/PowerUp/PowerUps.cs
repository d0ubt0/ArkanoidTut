using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    Vector3 ReduceChange = new Vector3(-0.2f,0,0);
    Vector3 IncreaseChange = new Vector3(0.2f,0,0);
    ArkanoidController arkanoidController;

    void Start()
    {
        arkanoidController = GameObject.Find("Arkanoid").GetComponent<ArkanoidController>();
    }
    
   void OnTriggerEnter2D(Collider2D other)
   {
        if(other.gameObject.name == "SlowPowerUp(Clone)")
        {
            SlowPowerUp();  
        }
        else if(other.gameObject.name == "FastPowerUp(Clone)")
        {
            FastPowerUp();
        }
        else if(other.gameObject.name == "ReducePowerUp(Clone)")
        {
            ReducePowerUp();
        }
        else if(other.gameObject.name == "IncreasePowerUp(Clone)")
        {
            IncreasePowerUp();
        }
        else if(other.gameObject.name == "50PointsPowerUp(Clone)")
        {
            arkanoidController.Points50PowerUp();
        }
        else if(other.gameObject.name == "100PointsPowerUp(Clone)")
        {
            arkanoidController.Points100PowerUp();
        }
        else if(other.gameObject.name == "250PointsPowerUp(Clone)")
        {
            arkanoidController.Points250PowerUp();
        }
        else if(other.gameObject.name == "500PointsPowerUp(Clone)")
        {
            arkanoidController.Points500PowerUp();
        }
        Destroy(other.gameObject);
   }

   void SlowPowerUp()
   {
       Ball.currentMultiplier = Ball.currentMultiplier - 0.25f;
       if(Ball.currentMultiplier<0.5f)
       {
           Ball.currentMultiplier = 0.5f;
       }

   }

   void FastPowerUp()
   {
       Ball.currentMultiplier = Ball.currentMultiplier + 0.25f;
       if(Ball.currentMultiplier>1.75f)
       {
           Ball.currentMultiplier = 1.75f;
       }

   }

   void ReducePowerUp()
   {
       gameObject.transform.localScale += ReduceChange;
       if(gameObject.transform.localScale.x<0.4f)
       {
           gameObject.transform.localScale = new Vector3(0.4f,gameObject.transform.localScale.y,gameObject.transform.localScale.z);
       }
   }

   void IncreasePowerUp()
   {
       gameObject.transform.localScale += IncreaseChange;
       if(gameObject.transform.localScale.x>1.6f)
       {
           gameObject.transform.localScale = new Vector3(1.6f,gameObject.transform.localScale.y,gameObject.transform.localScale.z);
       }
   }

   
}
