using UnityEngine;
using System.Collections;

public class IslandController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
    public float speed = 5f;
    public GameController gameController;

	//PRIVATE INSTANCE VARIABLES
	private Transform _transform;
	private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
		// Make a reference with the Transform Component
		this._transform = gameObject.GetComponent<Transform> ();

		// Reset the Island Sprite to the Top
		this.Reset ();
	}

	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position;
		this._currentPosition -= new Vector2(0, this.speed);
		this._transform.position = this._currentPosition;

        if (this._currentPosition.y <= -270)
        {
            this.gameController.ScoreValue += 10;
			this.Reset ();
		}
	}

	public void Reset() {
		float xPosition = Random.Range (-288f, 288f);
		this._transform.position = new Vector2 (xPosition, 270f);
	}
}
