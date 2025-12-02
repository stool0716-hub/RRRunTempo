using UnityEngine;
using UnityEngine.UI;

public class ssr_cardopen_ctl : MonoBehaviour
{
    Material UI_ssr_cardopen;
    public float Size;

    void Start()
    {
        Image img = GetComponent<Image>();
        UI_ssr_cardopen = Instantiate(img.material); // 取得獨立材質
        img.material = UI_ssr_cardopen;             // 再貼回去
    }

    void Update()
    {
        UI_ssr_cardopen.SetFloat("_Size", Size);
    }
}
