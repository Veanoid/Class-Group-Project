//zackery welk

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Actions/Attack")]

public class AttackAction : Action {
    public GameObject enemyBullet;
   
    public int bulletSpeed;
    private Transform enemyBulletSpawn;
    float shootTimer;
    public override void Act(StateController controller)
    {
        enemyBulletSpawn = GameObject.FindGameObjectWithTag("BulletSpawn").transform;

        Attack(controller);
    }

    private void Attack(StateController controller)
    {
        //making the enemy always look at the player
        controller.transform.LookAt(controller.Target);
        //creating a timer that limits the fire rate of the enemy
        shootTimer += Time.deltaTime;
        if (shootTimer > 0.5f)
        {
            //creatin gthe bullets
            GameObject enBull = Instantiate(enemyBullet, enemyBulletSpawn.position, enemyBulletSpawn.rotation);
            //giving them rigidbody and moving them
            enBull.GetComponent<Rigidbody>().AddForce(enBull.transform.forward * bulletSpeed);
            shootTimer = 0;
           
        }

    }
   
}
