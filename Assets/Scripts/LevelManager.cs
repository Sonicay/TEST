using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
	private AudioSource _audioSource;

	private void Awake()
    {
		DontDestroyOnLoad(transform.gameObject);
		_audioSource = GetComponent<AudioSource>();
	}

	public void ChangeScene(string name)
	{
		SceneManager.LoadScene(name);
	}
}
