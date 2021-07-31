using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ScrollViewController : MonoBehaviour
{

    private ScrollRect scrollRect;
    // 스크립트가 붙어있는 gameObject가 ScrollRect Component가지고 있어서 GetComponent로 받으면 됨 . 굳이 public으로 받을 필요없음

    [SerializeField]
    private float space = 100f;


    private void Awake()
    {
        scrollRect = GetComponent<ScrollRect>();
    }
    void Start()
    {


    }


    public void OnStageSignSpread(int chapter_no) // player의 chapter
    {
        // 챕터 하나에 스테이지 20개 받아오기
        int start_stage = (chapter_no - 1) * 20 + 1;

        // 데이터베이스 접근해서 리스트로 데이터 받아오기
        var lobbyList = DataService.Instance.GetDataList<Table.LobbyTable>().FindAll(x => x.chapter_no == chapter_no && x.stage_no >= start_stage && x.stage_no <= start_stage + 19);

        lobbyList.OrderBy(x => x.stage_no).ToList(); // 정렬한 후 리스트화 하기



        float x_float= 0f; //  뿌려지는 박스간의 간격

        for (int i = 0; i < 20; i++)
        {

            // 프리팹 복제중  , scrollRect.content의 자식으로 Instatiate 하기
            RectTransform cloneRect = Instantiate(Resources.Load<RectTransform>("Prefabs/Stage/StageGroup"), scrollRect.content);


            // StageGroup 프리팹이 컴포넌트로 가지고 있는 StageUIInfo 스크립트를 받아와서 Init() 으로 각 stage에 맞는 기본값 세팅
            StageUIInfo stageUIInfo = cloneRect.GetComponent<StageUIInfo>();


            stageUIInfo.Init(lobbyList[i]);
            // db로부터 받은 리스트에서 한줄의 정보를 stageUIInfo 스크립트에 넘겨 복제한 프리팹 값 세팅                        

            // 복제한 프리팹의 캔버스에서 위치 잡아주기
            cloneRect.anchoredPosition = new Vector2(scrollRect.content.sizeDelta.x + x_float, 0f);

            x_float += space; //  다음 박스의 위치 값 미리 세팅
        }

        //마지막으로 content 위치 조절 (이게 필요한지는 모르겠음)
      // scrollRect.content.sizeDelta = new Vector2(scrollRect.content.sizeDelta.x, scrollRect.content.sizeDelta.y);
    }

}



