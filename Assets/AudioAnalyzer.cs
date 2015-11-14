using UnityEngine;
using System.Collections;

public class AudioAnalyzer : MonoBehaviour {

	AudioSource MainAudioSource;

	// Use this for initialization
	void Start () {
		MainAudioSource = gameObject.GetComponent<AudioSource> ();
		MainAudioSource.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		float[] b = new float[32];
		MainAudioSource.GetSpectrumData(b, 0, FFTWindow.BlackmanHarris);
	}
}
