using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    [SerializeField]
    private CharacterType _characterType;

    [SerializeField]
    private int _hp;

    [SerializeField]
    private float _speed;

    [SerializeField]
    [Header("�o�����̑ҋ@����")]
    private int _delayTime;
}
