using UnityEngine;
using UnityEngine.UI;

public class ssr_cornerbg_line_ctl : MonoBehaviour
{
    Material UI_ssr_cornerline;
    public float LineMove;
    
    
    void Start()
    {
        Image img = GetComponent<Image>();
        UI_ssr_cornerline = Instantiate(img.material); // 取得獨立材質
        img.material = UI_ssr_cornerline;             // 再貼回去
    }

    void Update()
    {
        UI_ssr_cornerline.SetFloat("_LineMove", LineMove);
       
    }
}
