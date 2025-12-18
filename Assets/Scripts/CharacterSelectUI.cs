using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelectUI : MonoBehaviour
{
	public void SelectCharacter(int characterIndex)
	{
		Debug.Log("選到角色 index = " + characterIndex);
		Debug.Log("【OnClick 有被呼叫】 index = " + characterIndex);

		MiniGameData.Instance.selectedCharacter = (CharacterType)characterIndex;
		SceneManager.LoadScene("MiniGameStage");
	}
}
