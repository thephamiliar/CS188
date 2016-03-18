using UnityEngine;

public class FireLightScript : MonoBehaviour
{
	public float minIntensity = 0.25f;
	public float maxIntensity = 0.5f;
	public bool turnOff;

	public Light fireLight;

	float random;

	void Update()
	{
		random = Random.Range(0.0f, 150.0f);
		float noise = Mathf.PerlinNoise(random, Time.timeSinceLevelLoad );
		if (turnOff) {
			if (Time.timeSinceLevelLoad  >= 23) {
				fireLight.GetComponent<Light> ().intensity = 0;
			} else {
				fireLight.GetComponent<Light> ().intensity = Mathf.Lerp (minIntensity, maxIntensity, noise);
			}
		} else {
			if (Time.timeSinceLevelLoad  <= 85) {
				fireLight.GetComponent<Light> ().intensity = 0;
			} else {
				fireLight.GetComponent<Light> ().intensity = Mathf.Lerp (minIntensity, maxIntensity, noise);
			}
		}
	}
}