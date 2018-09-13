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
        Debug.Log("chasing");
        controller.transform.LookAt(controller.Target);
        controller.navMeshAgent.destination = controller.Target.position;
       // controller.navMeshAgent.Resume();
        controller.navMeshAgent.isStopped = false;
    }
}
