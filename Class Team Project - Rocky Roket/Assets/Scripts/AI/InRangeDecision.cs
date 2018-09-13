//zackery welk

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Decisions/InRange")]
public class InRangeDecision : Decision {
    public float range = 3.5f;

    public override bool Decide(StateController controller)
    {
        bool targetInRange = InRange(controller);
        return targetInRange;
    }

    private bool InRange(StateController controller)
    {
        LayerMask layerMask = 8;
        layerMask = ~layerMask;
        Debug.DrawRay(controller.bulletSpawn.transform.position, controller.bulletSpawn.transform.forward, Color.blue);
        if (Physics.Raycast(controller.bulletSpawn.transform.position, controller.bulletSpawn.transform.forward, range, layerMask))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
