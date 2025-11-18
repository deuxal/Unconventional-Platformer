using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    [SerializeField] Animator animator;
    public bool IsMoving { get { return IsMoving; } set { animator.SetBool("IsMoving", value); } }
    public bool CanMove { get { return animator.GetBool("CanMove"); } }
    public float XVelocity { get { return XVelocity; } set { XVelocity = value; } }

    // Update is called once per frame
    void Update()
    {
        if (XVelocity < 0) transform.localScale = new(-1, 1, 1);
        else transform.localScale = Vector3.one;
    }
    
    public void PlayAnimation(AnimationClip clip)
    {
        animator.Play(clip.name);
    }    
}
