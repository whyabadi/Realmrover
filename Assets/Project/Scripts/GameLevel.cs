using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Realmrover
{
    [CreateAssetMenu(fileName ="new level", menuName ="Level Design/Game Level")]
    public class GameLevel : ScriptableObject
    {
        public string Name;
        public Sprite Background;

        List<EnemyEntry> Enemies = new List<EnemyEntry>();
    }

    [System.Serializable]
    public class EnemyEntry
    {
        public int Level;
        public CharacterTemplate Template;
    }
}