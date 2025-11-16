using UnityEngine;

public class TP : MonoBehaviour
{
    public Transform objeto; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void transport_tp(Transform Pos)
    {
        objeto.transform.position = Pos.position;
    }
}
