using UnityEngine;
using System.Collections;

public class OceanController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public float speed = 5f;

	//PRIVATE INSTANCE VARIABLES
	private Transform _transform;
    private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
		// Make a reference with the Transform Component
		this._transform = gameObject.GetComponent<Transform> ();

		// Reset the Ocean Sprite to the Top
		this._Reset ();
	}
	
	// Update is called once per frame
    void Update()
    {
        Vector2 currentPosition = gameObject.GetComponent<Transform>().position;
        currentPosition.y -= speed;
        gameObject.GetComponent<Transform>().position = currentPosition;

        // Check bottom boundary
        if (currentPosition.y <= -480)
        {
            this._Reset();
        }
        //this._currentPosition = this._transform.position;
        //this._currentPosition -= new Vector2(0, this.speed);
        //this._transform.position = this._currentPosition;

        //if (this._currentPosition.y <= -480) {
        //    this.Reset ();
        //}
	}

    public void _Reset()
    {
        Vector2 resetPosition = new Vector2(0.0f, 480f);
        gameObject.GetComponent<Transform>().position = resetPosition;
	}
}
