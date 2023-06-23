using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MBS.Type;

namespace MBS.Object.Character
{
    [CreateAssetMenu(fileName = "Character Data", menuName = "Scriptable Object/Character Data", order = int.MaxValue)]
    public class BasicCharacter : ScriptableObject
    {
        [SerializeField] private string _name;
        [SerializeField] private CharacterType _type;
        [SerializeField] private Allies _allies;
        [SerializeField] private Gender _gender;
        [SerializeField] private Side _side;
        // Abliity list
        [SerializeField] private BasicPassive[] _ability;
        // Passive list
        [SerializeField] private BasicPassive[] _passiveBuffList;

        [SerializeField] private int _hitPoint;

        [SerializeField] private int _physicalDamage;
        [SerializeField] private int _energyDamage;

        [SerializeField] private float _dodge;
        [SerializeField] private float _ignoreDodge;
        [SerializeField] private float _endurance;
        [SerializeField] private float _cooldown;
    }
}
