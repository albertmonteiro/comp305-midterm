using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    // PUBLIC INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++
    public float speed = 7f;
    public Boundary boundary;

    // PRIVATE INSTANCE VARIABLES
    private float _playerInput;
    private Transform _transform;
    private Vector2 _currentPosition;

	// get a reference to the camera to make mouse input work
	public Camera camera; 
	
	// PRIVATE INSTANCE VARIABLES
	private Vector2 _newPosition = new Vector2(0.0f, 0.0f);
	
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		this._CheckInput ();
	}

    private void _CheckInput()
    {
        this._currentPosition = this._transform.position;

        this._playerInput = Input.GetAxis("Horizontal");
        // if player input is positive move right 
        if (this._playerInput > 0)
        {
            this._currentPosition += new Vector2(this.speed, 0);
        }

        // if player input is negative move left 
        if (this._playerInput < 0)
        {
            this._currentPosition -= new Vector2(this.speed, 0);
        }

        //this._checkBounds();

        this._transform.position = this._currentPosition;
        //Debug.Log("Inside checkInput!");
        //this._newPosition = gameObject.GetComponent<Transform> ().position; // current position

        //// movement by keyboard
        //if (Input.GetAxis ("Horizontal") > 0) {
        //    this._newPosition.x += this.speed; // add move value to current position
        //}
	
		
        //if (Input.GetAxis ("Horizontal") < 0) {
        //    this._newPosition.x -= this.speed; // subtract move value to current position
        //}

        //// movement by mouse
        //Vector2 mousePosition = Input.mousePosition;
        //this._newPosition.x = this.camera.ScreenToWorldPoint (mousePosition).x;

        //this._BoundaryCheck ();

        //gameObject.GetComponent<Transform>().position = this._newPosition;
	}

	private void _BoundaryCheck() {
		if (this._newPosition.x < this.boundary.xMin) {
			this._newPosition.x = this.boundary.xMin;
		}

		if (this._newPosition.x > this.boundary.xMax) {
			this._newPosition.x = this.boundary.xMax;
		}
	}
}
