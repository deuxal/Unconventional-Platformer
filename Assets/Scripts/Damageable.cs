using UnityEngine;
using UnityEngine.Events;

public class Damageable : MonoBehaviour
{
    public int health;
    public int Health { get { return health; } set { health = value; } }
    public bool IsAlive { get { return Health > 0; } }
    public UnityEvent onDeath;

    Transform Checkpoint {get { return GameManager.Instance.CurrentCheckpoint; } }
    [SerializeField] Rigidbody2D Body;

    public void Hit(int damage)
    {
        Health -= damage;
    }

    void Update()
    {
        if (!IsAlive)
        {
            Respawn();
        }
    }

    public void Respawn()
    {
        if (IsAlive) return;
        Health = 1;

        onDeath?.Invoke();

        Body.position = Checkpoint.position;
    }
}