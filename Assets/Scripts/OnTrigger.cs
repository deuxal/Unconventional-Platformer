using UnityEngine;
using UnityEngine.Events;

public class OnTrigger : MonoBehaviour
{
    public UnityEvent onTrigger;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        onTrigger?.Invoke();
    }
}