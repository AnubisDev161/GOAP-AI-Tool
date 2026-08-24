using GOAP.Tree;
using System.Collections.Generic;
using UnityEngine;

namespace GOAP.Core.Agent
{
    /// <summary>
    /// The GOAPPlanner is responsible for generating plans using its GOAPTree which searches through 
    /// the given actions to create a valid plan that satisfies the given goal.
    /// </summary>
    public class GOAPPlanner
    {
        private GOAPTree tree;
  
        public GOAPPlanner()
        {
            tree = new GOAPTree();
        }

        public Queue<GOAPAction> GeneratePlan(WorldState currentWorldState, GOAPGoal goal, List<GOAPAction> availableActions, GOAPGraph.GOAPGraphAsset graphInstance)
        {
            return tree.GeneratePlan(currentWorldState, goal, availableActions, graphInstance);
        }
    }
}
    