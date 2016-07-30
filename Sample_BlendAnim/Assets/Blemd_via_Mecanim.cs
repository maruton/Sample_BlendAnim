using UnityEngine;
using System.Collections;

public class Blemd_via_Mecanim : MonoBehaviour {
    public Animator anim;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    float deltaTime;
    bool morfDirection = false;
	void Update () {
        deltaTime += Time.deltaTime;
        if (deltaTime > 3.0f)
        {
            deltaTime = 0;
            morfDirection = !morfDirection;
            if (morfDirection)
            {
                anim.SetBool("puyoLargeXY", true);//Animator window -> Parameter -> "puyoLargeXY"
                Debug.Log("Piece_M: puyoLargeX = true");
            }
            else
                anim.SetBool("puyoLargeXY", false);
                Debug.Log("Piece_M: puyoLargeX = false");
            {

            }
        }
    }
}
