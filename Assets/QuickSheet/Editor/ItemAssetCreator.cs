using UnityEngine;
using UnityEditor;
using System.IO;
using UnityQuickSheet;

///
/// !!! Machine generated code !!!
/// 
public partial class GoogleDataAssetUtility
{
    [MenuItem("Assets/Create/Google/Item")]
    public static void CreateItemAssetFile()
    {
        Item asset = CustomAssetUtility.CreateAsset<Item>();
        asset.SheetName = "MySpreadSheet";
        asset.WorksheetName = "Item";
        EditorUtility.SetDirty(asset);        
    }
    
}