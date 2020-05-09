using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

	public float velocity;
	private Rigidbody2D rb;
    public SceneController sceneController;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    	// detect fire button
        if (Input.GetMouseButtonDown(0)){
        	rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
    	sceneController.YouLost();
    }

}
