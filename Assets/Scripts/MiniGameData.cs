using UnityEngine;

public class MiniGameData : MonoBehaviour
{
	public static MiniGameData Instance;

	public CharacterType selectedCharacter;
	public string selectedStageScene;

	private void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
	}
}
