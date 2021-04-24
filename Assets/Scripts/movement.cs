using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Vertical", 0);
        animator.SetFloat("Horizontal", 0);

        if (Input.GetKey(KeyCode.I)) { animator.SetFloat("Vertical", 1); }
        if (Input.GetKey(KeyCode.J)) { animator.SetFloat("Horizontal", -1); }
        if (Input.GetKey(KeyCode.K)) { animator.SetFloat("Vertical", -1); }
        if (Input.GetKey(KeyCode.L)) { animator.SetFloat("Horizontal", 1); }
    }
}
