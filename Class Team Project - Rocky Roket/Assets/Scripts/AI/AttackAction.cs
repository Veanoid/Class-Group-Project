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
        controller.transform.LookAt(controller.Target);
        shootTimer += Time.deltaTime;
        if (shootTimer > 1)
        {
            GameObject enBull = Instantiate(enemyBullet, enemyBulletSpawn.position, enemyBulletSpawn.rotation);
            enBull.GetComponent<Rigidbody>().AddForce(enBull.transform.forward * bulletSpeed);
            shootTimer = 0;
            Destroy(enBull, 3.0f);
        }

    }
}
