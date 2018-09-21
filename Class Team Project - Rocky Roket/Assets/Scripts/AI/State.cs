//zackery welk

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/State")]
public class State : ScriptableObject {

    public Action[] actions;
    public Transition[] transitions;


    public void UpdateState(StateController controller)
    {
        DoActions(controller);
        CheckTransitions(controller);
    }

    private void DoActions(StateController controller)
    {
        //actually performing the actions
        for (int i = 0; i < actions.Length; i++)
        {
        actions[i].Act(controller);
        }
    }

    private void CheckTransitions(StateController controller)
    {
        //checking if a decision succeeded so it will then transition into the next state
        for (int i = 0; i < transitions.Length; i++)
        {
            bool decisionSucceeded = transitions[i].decision.Decide(controller);

            if(decisionSucceeded)
            {
                controller.TransitionToState(transitions[i].trueState);
            }
            else
            {
                controller.TransitionToState(transitions[i].falseState);
            }
        }
    }
}
