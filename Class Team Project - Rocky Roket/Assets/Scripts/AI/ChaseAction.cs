//zackery welk

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu (menuName = "PluggableAI/Actions/Chase")]
public class ChaseAction : Action {

    public override void Act(StateController controller)
    {
        Chase(controller);
    }

    private void Chase(StateController controller)
    {
        // Debug.Log("chasing");
        //looking at the player to always face it
        controller.transform.LookAt(controller.Target);
        //setting the destination of the navmesh agent
        controller.navMeshAgent.destination = controller.Target.position;
        controller.navMeshAgent.isStopped = false;
    }
}
