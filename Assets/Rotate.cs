using UnityEngine;

public class Rotate : MonoBehaviour {

    private GameObject centerOfRotation;
    private float rotationSpeed = 1.0f;

	// Use this for initialization
	void Start () {
        centerOfRotation = new GameObject();
        centerOfRotation.transform.position = transform.position;
        rotationSpeed = Random.value;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(
            rotationSpeed * Mathf.Sin(Time.time),
            rotationSpeed * Mathf.Cos(Time.time), 0) +
            centerOfRotation.transform.position;
	}
}
