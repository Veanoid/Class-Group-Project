//zackery welk

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "PluggableAI/Actions/Flee")]

public class FleeAction : Action {
    public override void Act(StateController controller)
    {
        Flee(controller);
    }

    private void Flee(StateController controller)
    {
        Debug.Log("Fleeing");
        //controller.transform.LookAt(controller.Target);

        //controller.navMeshAgent.destination = Vector3.zero;

        //controller.navMeshAgent.isStopped = false;
        float timer = Time.deltaTime;

        if (timer < 2)
        {

         //   float distance = Vector3.Distance(controller.transform.position, controller.Target.position);

            Vector3 dirToPlayer = controller.transform.position - controller.Target.position;

            dirToPlayer = dirToPlayer.normalized * 10.0f;

            Vector3 newPos = controller.transform.position + dirToPlayer;

            controller.navMeshAgent.SetDestination(newPos);
            timer = 0;
        }

    }
}
