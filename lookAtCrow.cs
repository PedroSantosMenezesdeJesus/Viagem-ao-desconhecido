using UnityEngine;

public class lookAtCrow : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveZ = Input.GetAxis("Horizontal");
        
        if(moveZ != 0f)
        {
            animator.SetBool("flying", true);
        }
    }
}
