using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public bool isStartingCheckpoint;
    void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Instance.SetCheckpoint(transform);
    }

    void Start()
    {
        if (isStartingCheckpoint) GameManager.Instance.SetCheckpoint(transform);
    }
}