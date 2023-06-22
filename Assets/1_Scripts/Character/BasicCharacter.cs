using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MBS.Type;

namespace MBS.Object.Character
{
    public class BasicCharacter
    {
        private string _name;
        private CharacterType _type;
        private Allies _allies;
        private Side _side;
        // Abliity list
        [SerializeField]
        private BasicPassive[] _ability;
        // Passive list
        private BasicPassive[] _passive;

        private int _hitPoint;
        private CrowdControl _status;
        // Buff list
        private List<object> _buffList;
        // Debuff list
        private List<object> _debuffList;

        private int _physicalDamage;
        private int _energyDamage;

        private float _dodge;
        private float _ignoreDodge;
        private float _endurance;
        private float _cooldown;

    }
}
