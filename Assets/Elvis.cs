using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elvis : MonoBehaviour {

    public BallLauncher launcher;
    public Animator anim;
    private bool shoot = false;

    private void Update()
    {
        if (launcher.isShooting && !shoot)
        {
            anim.SetBool("isShoot", true);
            shoot = true;
        }
        else if (!launcher.isShooting && shoot)
        {
            anim.SetBool("isShoot", false);
            shoot = false;
        }
    }

}
