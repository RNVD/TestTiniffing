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


    };

    public static Type[] writableTableTypeArray =
    {

       typeof(PlayerIngameShopSkillLevelTable)
    };

    #region ReadOnly Table

   
    #endregion

    #region Writable Table
   

    [Preserve, Serializable] //serializable : 매칭이 되는 테이블과 연결을 하기 위한 어트리뷰트
    public class PlayerIngameShopSkillLevelTable : IKeyTableData //extra table
    {
        public int GetTableId() { return id; }
        [NotNull, PrimaryKey, Unique]
        public int id { get; set; }
        public int level { get; set; }

    }
    #endregion
}