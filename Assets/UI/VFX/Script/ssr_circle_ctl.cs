using UnityEngine;
using UnityEngine.UI;

public class ssr_circle_ctl : MonoBehaviour
{
    Material UI_ssr_circle;
    public float Move;
    public float LineThick;

    void Start()
    {
        Image img = GetComponent<Image>();
        UI_ssr_circle = Instantiate(img.material); // 取得獨立材質
        img.material = UI_ssr_circle;             // 再貼回去
    }

    void Update()
    {
        UI_ssr_circle.SetFloat("_Move", Move);
        UI_ssr_circle.SetFloat("_LineThick", LineThick);
    }
}
