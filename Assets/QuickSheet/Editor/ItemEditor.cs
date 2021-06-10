using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using GDataDB;
using GDataDB.Linq;

using UnityQuickSheet;

///
/// !!! Machine generated code !!!
///
[CustomEditor(typeof(Item))]
public class ItemEditor : BaseGoogleEditor<Item>
{	    
    public override bool Load()
    {        
        Item targetData = target as Item;
        
        var client = new DatabaseClient("", "");
        string error = string.Empty;
        var db = client.GetDatabase(targetData.SheetName, ref error);	
        var table = db.GetTable<ItemData>(targetData.WorksheetName) ?? db.CreateTable<ItemData>(targetData.WorksheetName);
        
        List<ItemData> myDataList = new List<ItemData>();
        
        var all = table.FindAll();
        foreach(var elem in all)
        {
            ItemData data = new ItemData();
            
            data = Cloner.DeepCopy<ItemData>(elem.Element);
            myDataList.Add(data);
        }
                
        targetData.dataArray = myDataList.ToArray();
        
        EditorUtility.SetDirty(targetData);
        AssetDatabase.SaveAssets();
        
        return true;
    }
}
