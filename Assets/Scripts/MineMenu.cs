using UnityEngine;
using UnityEngine.SceneManagement;
public class MineMenu : MonoBehaviour
{
	public void Login()
	{
		SceneManager.LoadScene("Login");
	}
	public void Lobby()
	{
		SceneManager.LoadScene("Lobby");
	}
	public void Gacha()
	{
		SceneManager.LoadScene("Gacha");
	}
	public void Cards()
	{
		SceneManager.LoadScene("Cards");
	}
	public void Store()
	{
		SceneManager.LoadScene("Store");
	}
	public void MiniGame()
	{
		SceneManager.LoadScene("MiniGame");
	}
	public void MiniGStage()
	{
		SceneManager.LoadScene("Lobby");
	}
	public void Stage_Easy()
	{
		SceneManager.LoadScene("Easy");
	}
	public void Stage_Normal()
	{
		SceneManager.LoadScene("Normal");
	}
	public void Stage_Hard()
	{
		SceneManager.LoadScene("Hard");
	}
	public void MiniGCharacter()
	{
		SceneManager.LoadScene("MiniGStage");
	}
	public void Quit()
	{
		Application.Quit();
	}
}
