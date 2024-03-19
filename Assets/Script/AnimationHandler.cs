using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator m_Animator;
    void Start()
    {
        //print("Ini Start");
        m_Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //print("Ini Update");
        if (Input.GetKey(KeyCode.Space))
        {
            //print("Ini Spasi di Klik !");
            m_Animator.SetTrigger("goAttack");
        }
    }
}
