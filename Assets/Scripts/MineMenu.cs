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
	public void Collection()
	{
		SceneManager.LoadScene("Collection");
	}
	public void Shop()
	{
		SceneManager.LoadScene("Shop");
	}
	public void MiniGameStage()
	{
		SceneManager.LoadScene("MiniGameStage");
	}
	public void MiniGameCharacter()
	{
		SceneManager.LoadScene("MiniGameCharacter");
	}
	public void Stage_Easy()
	{
		SceneManager.LoadScene("Stage_Easy");
	}
	public void Stage_Normal()
	{
		SceneManager.LoadScene("Stage_Normal");
	}
	public void Stage_Hard()
	{
		SceneManager.LoadScene("Stage_Hard");
	}
	public void Quit()
	{
		Application.Quit();
	}
}
