using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MBS.Type;

namespace MBS.Object.Character
{
    [CreateAssetMenu(fileName = "Character Data", menuName = "Scriptable Object/Character Data", order = int.MaxValue)]
    public class BasicCharacter : ScriptableObject
    {
        [SerializeField] protected string _name;
        [SerializeField] protected CharacterType _type;
        [SerializeField] protected Allies _allies;
        [SerializeField] protected Gender _gender;
        [SerializeField] protected Side _side;
        // Abliity list
        [SerializeField] protected BasicPassive[] _ability;
        // Passive list
        [SerializeField] protected BasicPassive[] _passiveBuffList;

        [SerializeField] protected int _hitPoint;

        [SerializeField] protected int _physicalDamage;
        [SerializeField] protected int _energyDamage;

        [SerializeField] protected float _dodge;
        [SerializeField] protected float _ignoreDodge;
        [SerializeField] protected float _endurance;
        [SerializeField] protected float _cooldown;
    }
}
