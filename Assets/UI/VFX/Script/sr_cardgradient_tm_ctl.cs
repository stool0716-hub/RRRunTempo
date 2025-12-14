using UnityEngine;
using UnityEngine.UI;

public class sr_cardgradient_tm_ctl : MonoBehaviour
{
    Material UI_sr_gacha_tm;
    public float Move;
    
    
    void Start()
    {
        Image img = GetComponent<Image>();
        UI_sr_gacha_tm = Instantiate(img.material); // 取得獨立材質
        img.material = UI_sr_gacha_tm;             // 再貼回去
    }

    void Update()
    {
        UI_sr_gacha_tm.SetFloat("_Move", Move);
       
    }
}
