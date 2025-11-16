using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public Transform CurrentCheckpoint { get; private set; }

    void Awake()
    {
        if (Instance != this && Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(this);
    }

    public void SetCheckpoint(Transform t)
    {
        CurrentCheckpoint = t;
    }

    public void transport_player(Transform player_pos)
    {

    }
}