using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Controller : MonoBehaviour
{
    public Animator animator;
    bool acting = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Action()
    {
        if(acting)
        {
            acting = false;
            animator.SetBool("Interation",false);
        }
        else
        {
            acting = true;
            animator.SetBool("Interation",true);
        }
        
    }
}
