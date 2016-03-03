using UnityEngine;
using System.Collections;

public class CloudController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public float minVerticalSpeed = 5f;
	public float maxVerticalSpeed = 10f;
	public float minHorizontalSpeed = -2f;
    public float maxHorizontalSpeed = 2f;
    public GameController gameController;

	//PRIVATE INSTANCE VARIABLES
	private Transform _transform;
	private Vector2 _currentPosition;
	private float _verticalSpeed;
    private float _horizontalDrift;

	// Use this for initialization
	void Start () {
		// Make a reference with the Transform Component
		this._transform = gameObject.GetComponent<Transform> ();

		// Reset the Cloud Sprite to the Top
		this.Reset ();
	}

	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position;
		this._currentPosition -= new Vector2(this._horizontalDrift, this._verticalSpeed);
		this._transform.position = this._currentPosition;

        if (this._currentPosition.y <= -330)
        {
            //Debug.Log("Test!");
            //this.gameController.ScoreValue += 10;
			this.Reset ();
		}
	}

	public void Reset() {
		this._verticalSpeed = Random.Range (this.minVerticalSpeed, this.maxVerticalSpeed);
		this._horizontalDrift = Random.Range (this.minHorizontalSpeed, this.maxHorizontalSpeed);
		float xPosition = Random.Range (-206f, 206f);
		this._transform.position = new Vector2 (xPosition, 330f);
	}
}
