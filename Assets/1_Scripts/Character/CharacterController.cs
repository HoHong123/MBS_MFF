using MBS.Object.Character;
using MBS.Type;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MBS.Controller.Game
{
    [CreateAssetMenu(fileName = "Character Controller", menuName = "Scriptable Object/Character Controller", order = int.MaxValue)]
    public class CharacterController : BasicCharacter
    {
        protected HitPoint _hitPoints;

        // Current target of the character
        private Transform _currentTarget;

        // Current state of the character
        private CrowdControl _crowdContrlStatus;
        // Current defence state of the character
        private DefenceStatus _defenceStatus;

        // Buff list
        private List<object> _activeBuffList;
        // Debuff list
        private List<object> _debuffList;




        // Start is called before the first frame update
        void Start()
        {
            _hitPoints = new HitPoint(_hitPoint);
        }
         
        // Update is called once per frame
        void Update()
        {

        }

        private void SeekingTarget()
        {

        }

        private void Attack()
        {

        }
    }
}
