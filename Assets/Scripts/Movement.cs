using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour {

    public float speed;
    public float jumpforce = 500f;
    bool jump;
    bool isGrounded;
    [SerializeField]
    float groundRadius;
    public Transform[] GroundPoints;
    public LayerMask whatisGround;
    Rigidbody2D myRigidbody;
   


    // Use this for initialization
    void Start () {

        myRigidbody = GetComponent<Rigidbody2D>();
        
    }

    bool Grounded()
    {

        if (myRigidbody.velocity.y <= 0)
        {

            foreach (Transform point in GroundPoints)
            {
                Collider2D[] colliders = Physics2D.OverlapCircleAll(point.position, groundRadius, whatisGround);

                for (int i = 0; i < colliders.Length; i++)
                {
                    if (colliders[i].gameObject != gameObject)
                    {
                        return true;
                    }
                }
            }

        }
        return false;

}
	
	// Update is called once per frame
	void Update () {
        isGrounded = Grounded();
        if (Input.GetKeyDown(KeyCode.Space))
            jump = true;

        if(isGrounded&&jump)
        {
            isGrounded = false;
            myRigidbody.AddForce(new Vector2(0, jumpforce));

        }
        ResetValues();

        transform.Translate(new Vector2(speed, 0f) * Time.deltaTime);
       
   

    }

    void ResetValues()
    {
        jump = false;
    }

}
