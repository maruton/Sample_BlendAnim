using UnityEngine;
using System.Collections;

public class Blemd_via_CrossFade : MonoBehaviour
{
    Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    float deltaTime;
    bool morfDirection = false;
    void Update()
    {
        deltaTime += Time.deltaTime;
        if (deltaTime > 2.0f)
        {
            deltaTime = 0;
            morfDirection = !morfDirection;
            if (morfDirection)
            {
                anim.CrossFade("puyoSmallXY", 0.2f);// 0.2f is CrossFade time
            }
            else
            {
                anim.CrossFade("Default", 0.2f);// 0.2f is CrossFade time
            }
        }
    }
}
