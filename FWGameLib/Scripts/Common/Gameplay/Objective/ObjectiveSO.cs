using UnityEngine;

namespace FWGameLib.Common.Gameplay.Objective
{
    [CreateAssetMenu(fileName = "New Objective", menuName = "FWGameLib/Objectives/Objective")]
    public class ObjectiveSO : ScriptableObject
    {
        public string title;
        public string description;
    }
}