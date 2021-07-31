using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; //Type
using UnityEngine.Scripting; //preserve ( 당장 쓰이지 않는 클래스도 빌드를 할 때 반드시 포함 시키는 어트리뷰트 )
using SQLite.Attribute;

public class Table
{
    public static Type[] readOnlyTableTypeArray =
    {

        typeof(TextTable),
    };

    public static Type[] writableTableTypeArray =
    {
        typeof(LobbyTable),typeof(SaveTable),
    };

    #region ReadOnly Table


    [Preserve, Serializable] //serializable : 매칭이 되는 테이블과 연결을 하기 위한 어트리뷰트
    public class TextTable : IKeyTableData
    {
        public int GetTableId() { return id; }
        [NotNull, PrimaryKey, Unique]
        public int id { get; set; }
        public string kor { get; set; }
        public string eng { get; set; }


    }

    #endregion

    #region Writable Table
    [Preserve, Serializable] //serializable : 概莫捞 登绰 抛捞喉苞 楷搬阑 窍扁 困茄 绢飘府轰飘
    public class SaveTable : IKeyTableData
    {
        public int GetTableId() { return id; }
        [NotNull, PrimaryKey, Unique]
        public int id { get; set; }
        public int chapter_no { get; set; }

        public int stage_no { get; set; }

        public string last_time { get; set; }

        public int heart_count { get; set; }

        public int cumulative_cycle_time { get; set; }

        public string in_game_start_time { get; set; }
    }


    [Preserve, Serializable] //serializable : 매칭이 되는 테이블과 연결을 하기 위한 어트리뷰트
    public class LobbyTable : IKeyTableData
    {
        public int GetTableId() { return id; }
        [NotNull, PrimaryKey, Unique]
        public int id { get; set; }
        public int chapter_no { get; set; }

        public int stage_no { get; set; }

        public int clear { get; set; }
        public int star_count { get; set; }
        public int mode_type { get; set; } // 老馆 窍靛 绰 咆胶飘抛捞喉肺 阂矾坷扁

        public string box_image_name { get; set; }
    }

    #endregion
}