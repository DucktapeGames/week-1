using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscillateRandomRange : MonoBehaviour {

	public Vector3 fromAmplitude;
	public Vector3 toAmplitude;
	public Vector3 fromSpeed;
	public Vector3 toSpeed;

	public bool randomOffset = true;

	Vector3 offset;
	Vector3 speed;
	Vector3 amplitude;
	Vector3 center;


	Vector3 randomVec(Vector3 from, Vector3 to) {
		return new Vector3 (Random.Range (from.x, to.x), 
			Random.Range (from.y, to.y), 
			Random.Range (from.z, to.z));
	}

	void Start() {
		if (randomOffset) {
			offset = randomVec(Vector3.zero, Vector3.one*Mathf.PI*2);
		}

		speed = randomVec(fromAmplitude, toAmplitude);
		amplitude = randomVec(fromSpeed, toSpeed);
		center = transform.localPosition;
	}

	// Update is called once per frame
	void Update () {
		Vector3 parameter = offset + Time.time * speed;
		transform.localPosition = center + new Vector3 (amplitude.x * Mathf.Sin (parameter.x),
			amplitude.y * Mathf.Sin (parameter.y),
			amplitude.z * Mathf.Sin (parameter.z));
	}
}
