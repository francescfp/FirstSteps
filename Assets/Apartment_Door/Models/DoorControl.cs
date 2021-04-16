using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl : MonoBehaviour
{
    private Animator _anim;

    private BoxCollider _box;


    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        OnTriggerEnter(_box);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Sphere")
        {
            _anim.SetTrigger("touched");
;
        }
    }
}
