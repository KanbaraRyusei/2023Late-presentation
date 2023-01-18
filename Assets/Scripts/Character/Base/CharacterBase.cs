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
    [Header("出現時の待機時間")]
    private int _delayTime;
}
