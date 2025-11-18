using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    [SerializeField] Animator animator;
    public bool IsMoving { get { return IsMoving; } set { animator.SetBool("IsMoving", value); } }
    public bool CanMove { get { return animator.GetBool("CanMove"); } }
    public float XVelocity { get { return animator.GetFloat("xVelocity"); } set { animator.SetFloat("xVelocity", value); } }

    // Update is called once per frame
    void Update()
    {
        if (XVelocity < 0) transform.localScale = new(-1, 1, 1);
        else transform.localScale = Vector3.one;

        IsMoving = XVelocity != 0;
    }
    
    public void PlayAnimation(AnimationClip clip)
    {
        animator.Play(clip.name);
    }    
}
