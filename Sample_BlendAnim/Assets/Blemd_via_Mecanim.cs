using UnityEngine;
using System.Collections;

public class Blemd_via_Mecanim : MonoBehaviour {
    public Animation anim;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    float deltaTime;
    bool morfDirection = false;
	void Update () {
        deltaTime += Time.deltaTime;
        if (deltaTime > 1.0f)
        {
            deltaTime = 0;
            morfDirection = !morfDirection;
            if (morfDirection)
            {
                //anim.CrossFade("Piece_Blend");
            }
            else
                //anim.CrossFade("Run");
            {

            }
        }
    }
}
