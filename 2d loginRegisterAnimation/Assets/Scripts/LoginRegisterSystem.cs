using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginRegisterSystem : MonoBehaviour
{

	private string url = "http://localhost/Unity3d";
	public Text loginNick, loginPass, loginInfo, registerPass, registerPass2, registerNick, registerInfo;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		
	}

	public void Login()
	{
		if (!string.IsNullOrEmpty(loginNick.text) && !string.IsNullOrEmpty(loginPass.text))
		{
			StartCoroutine(LoginSystem());
		}
		else
		{
			loginInfo.text = "Prosze podać wszystkie dane";
		}
	}

	IEnumerator LoginSystem()
	{
		yield return new WaitForEndOfFrame();
		WWWForm wwwForm = new WWWForm();
		wwwForm.AddField("nick", loginNick.text);
		wwwForm.AddField("pass", loginPass.text);
		WWW www = new WWW(url + "/login.php", wwwForm);
		yield return www;

		loginInfo.text = www.text;
		if (loginInfo.text == "Zalogowano pomyślnie")
		{
			SceneManager.LoadScene("Game");
		}

	}

	public void Register()
	{
		if (!string.IsNullOrEmpty(registerNick.text) && !string.IsNullOrEmpty(registerPass.text) && !string.IsNullOrEmpty(registerPass2.text))
		{
			if (registerPass.text == registerPass2.text)
			{
				StartCoroutine(RegisterSystem());
			}
			else
				registerInfo.text = "Podane hasła są różne";

		}
		else
		{
			registerInfo.text = "Prosze podać wszystkie dane";
		}
	}
	IEnumerator RegisterSystem()
	{
		yield return new WaitForEndOfFrame();
		WWWForm wwwForm = new WWWForm();
		wwwForm.AddField("nick", registerNick.text);
		wwwForm.AddField("pass", registerPass.text);
		WWW www = new WWW(url + "/register.php", wwwForm);
		yield return www;

		registerInfo.text = www.text;
		

	}
}