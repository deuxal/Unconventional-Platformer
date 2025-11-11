using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public LayerMask layerMask;
    [SerializeField] Collider2D collision;
    public bool Grounded { get { return grounded; } private set { grounded = value; } }
    public bool grounded;
    public bool OnWall { get; private set; }
    RaycastHit2D[] hits = new RaycastHit2D[5];
    [SerializeField] Vector2 groundDetectionOffset;
    [SerializeField] float groundDetectionDistance;
    [SerializeField] Vector2 wallDetectionOffset;
    Vector2 groundLeft { get { return transform.position + (Vector3)new(groundDetectionOffset.x, groundDetectionOffset.y); } }
    Vector2 groundRight { get { return transform.position + (Vector3)new(-groundDetectionOffset.x, groundDetectionOffset.y); } }
    void Update()
    {
        if (Physics2D.Raycast(groundLeft, Vector2.down, groundDetectionDistance, layerMask) ||
            Physics2D.Raycast(groundRight, Vector2.down, groundDetectionDistance, layerMask))
            Grounded = true;
        else Grounded = false;
    }

    void OnDrawGizmos()
    {    
        Debug.DrawRay(groundLeft, Vector2.down * groundDetectionDistance, Grounded? Color.green : Color.red);
        Debug.DrawRay(groundRight, Vector2.down * groundDetectionDistance, Grounded? Color.green : Color.red);
    }
}