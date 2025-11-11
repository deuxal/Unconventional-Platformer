using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damage;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Damageable>(out var col))
        {
            col.Hit(damage);
        }
    }
}