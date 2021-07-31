using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LobbyManager : MonoBehaviour
{
    public static LobbyManager instance;

    [SerializeField]
    private ScrollViewController lobbyScrollViewController;
    [SerializeField]
    //private LobbyUIInfo lobbyUIInfo;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

    }
    private void Start()
    {
        Init();
    }
    public void Init()
    {
        //硅版技泼
      //  lobbyUIInfo.Init();

        // scroll view  Setting
        int chapter_no = DataService.Instance.GetData<Table.SaveTable>(0).chapter_no;
        lobbyScrollViewController.OnStageSignSpread(chapter_no);
    }


   /* public void oneHeartGetNeedTime(int remainingTime)
    {
        lobbyUIInfo.RemainingHeartTime(remainingTime);
    }
    */
    private void OnDestroy()
    {
        instance = null;
    }
}
