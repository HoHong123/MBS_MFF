using MBS.Object.Character;
using MBS.Type;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MBS.Controller.Game
{
    public class CharacterController : MonoBehaviour
    {
        [SerializeField] private BasicCharacter _character;
        [SerializeField] private CrowdControl _crowdContrlStatus;
        [SerializeField] private DefenceStatus _defenceStatus;

        [SerializeField] private Transform _currentTarget;


        [SerializeField] private CrowdControl _status;
        // Buff list
        [SerializeField] private List<object> _activeBuffList;
        // Debuff list
        [SerializeField] private List<object> _debuffList;




        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
