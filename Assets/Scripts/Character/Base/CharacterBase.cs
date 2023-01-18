using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterBase : MonoBehaviour
{
    public int CurrentHp => _currentHp;
    public float CurrentSpeed => _currentSpeed;
    public CharacterType Type => _characterType;

    [SerializeField]
    private CharacterType _characterType;

    [SerializeField]
    private int _initialHp;

    [SerializeField]
    private float _initialSpeed;

    [SerializeField]
    [Header("出現時の待機時間")]
    private int _delayTime;

    [SerializeField]
    [Header("出現時の演出")]
    private ParticleSystem _enableParticle;

    [SerializeField]
    [Header("死亡時の演出")]
    private ParticleSystem _deathParticle;
    
    protected int _currentHp;
    protected float _currentSpeed;

    protected Animator _anim;

    private void OnEnable()
    {
        _anim ??= GetComponent<Animator>();
        Init();
    }

    public abstract void Attack();
    public abstract void Move();

    protected void Init()
    {
        _currentHp = _initialHp;
        _currentSpeed = _initialSpeed;
        _deathParticle.gameObject.SetActive(false);
        _enableParticle.gameObject.SetActive(true);
    }

    public void RecieveDamage(int damage)
    {
        _currentHp -= damage;
        if(_currentHp <= 0)
        {
            Death();
        }
    }

    public virtual void Death()
    {
        _deathParticle.gameObject.SetActive(true);
    }
}
