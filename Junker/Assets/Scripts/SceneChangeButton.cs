using UnityEngine;
using System.Collections;

public class SceneChangeButton : MonoBehaviour
{
	public void onClick() {
		UnityEngine.SceneManagement.SceneManager.LoadScene("scene1");
	}

}

