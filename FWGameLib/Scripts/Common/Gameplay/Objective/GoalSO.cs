using UnityEngine;

namespace FWGameLib.Common.Gameplay.Objective
{
    [CreateAssetMenu(fileName = "New Goal", menuName = "FWGameLib/Objectives/Goal")]
    public class GoalSO : ScriptableObject
    {
        public string title;
        public string description;
    }
}