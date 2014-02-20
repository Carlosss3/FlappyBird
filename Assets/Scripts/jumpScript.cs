using UnityEngine;
using System.Collections;

public class jumpScript : MonoBehaviour {
	public float moveForce = 365f;			
	public float maxSpeed = 5f;			
	public float jumpForce = 1000f;
	public AudioClip jumpSound;
	public AudioClip deadSound;
	public bool jump = false;
	public bool inmortal = false;

	SpriteRenderer spr;
	Animator anim;
	// Use this for initialization


	void Start () {
		anim = GetComponent<Animator>();
		spr = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump") && !GameControl.dead){
			jump = true;
			anim.SetBool("jump",true);
		}

		if(GameControl.inmortal){
			gameObject.collider2D.isTrigger = true;
		
		}else{
			gameObject.collider2D.isTrigger = false;
		}

	}

	void FixedUpdate() {
		if(jump)
		{	
			AudioSource.PlayClipAtPoint(jumpSound, transform.position);
			var v = new Vector2(0,0);
			rigidbody2D.velocity = v;
			rigidbody2D.AddForce(new Vector2(0f, jumpForce));
			jump = false;
			anim.SetBool("jump",false);

		}

		if(GameControl.inmortal){


			spr.color=new Color(1f,1f,1f,0.5f);
			anim.enabled = false;
		}

		if(GameControl.inmortal && Time.time > GameControl.inmortalTime){
			GameControl.inmortal = false;
			anim.enabled = true;
			spr.color=new Color(1f,1f,1f,1f);
		}


	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(!GameControl.dead){
			GameControl.dead = true;
			AudioSource.PlayClipAtPoint(deadSound, transform.position);
			anim.SetBool("dead",true);
			rigidbody2D.gravityScale = 4;
			var v = new Vector2(0,0);
			rigidbody2D.velocity = v;
			DestroyObject(gameObject,2);
		}
	}

	void OnDestroy(){
		GameControl.dead = false;
		GameControl.score = 0;
		Application.LoadLevel (Application.loadedLevel);

	}
}
