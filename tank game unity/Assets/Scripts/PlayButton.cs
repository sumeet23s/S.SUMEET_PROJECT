using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
	// Start is called before the first frame update

	//public Button yourButton;
 /*public	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}
*/
public	void TaskOnClick()
	{
		SceneManager.LoadScene("MainMenu");
		
	}

public void credits()
    {
		SceneManager.LoadScene("Credits");
    }

public void creditsback()
    {
		SceneManager.LoadScene("Win");
    }
	

}
