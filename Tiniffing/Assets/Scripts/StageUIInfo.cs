using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StageUIInfo : MonoBehaviour
{
    [SerializeField]
    private Image boxImg;

    [SerializeField]
    private Text stageNumberText;

    [SerializeField]
    private Text stageModeText;



    public void Init(Table.LobbyTable lobbyData)
    {
        // 霸烙捞 场唱搁 舅酒辑 促 眉农秦林扁锭巩俊(clear  蜡公, 喊俺荐, 弊俊蝶弗 秦寸 府家胶 捞抚)  被捞 咯扁辑 眉欧且 鞘夸绝促)
        boxImg.sprite = Resources.Load<Sprite>("Images/Lobby/" + lobbyData.box_image_name);

        stageNumberText.text = lobbyData.stage_no.ToString();

        // 捞扒 咆胶飘扼辑 包府啊 蝶肺 鞘夸窍骨肺 LobbyTable俊 咆胶飘俊 措茄 沥焊甫 持阑荐 绝扁锭巩俊 眉欧 鞘夸
        if (lobbyData.mode_type == 0)
        {
            stageModeText.text = DataService.Instance.GetText(0);
        }
        else //modetype ==1
            stageModeText.text = DataService.Instance.GetText(1);




    }


}
