//zackery welk

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Decisions/TooClose")]
public class TooCloseDecision : Decision {
    public float range = 1.5f;
    public override bool Decide(StateController controller)
    {
        bool isTooClose = TooClose(controller);
        return isTooClose;
    }

    private bool TooClose(StateController controller)
    {
        LayerMask layerMask = 8;
        layerMask = ~layerMask;
        Debug.DrawRay(controller.bulletSpawn.transform.position, controller.bulletSpawn.transform.forward, Color.red);
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
