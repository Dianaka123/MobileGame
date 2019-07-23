using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explotion : MonoBehaviour
{
    Animator animator;
    AudioSource music;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    private void Awake()
    {
        music = gameObject.GetComponent<AudioSource>();
        
    }
    private void Update()
    {
        animator.SetBool("die", PlayerBehaviour.lose);
        if (PlayerBehaviour.lose)
        {
            music.enabled = true;
        }
        
    }
}
