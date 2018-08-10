using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;


public class PrefabTile : TileBase
{

    [SerializeField] GameObject prefab;
    [SerializeField] Vector2 offSet = new Vector2(0.5f,0.5f);



    public override void GetTileData(Vector3Int location, ITilemap tileMap, ref TileData tileData)
    {

          

        tileData.gameObject = prefab;
             
    }
       
    public override bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go)
    {            
        go.transform.position += Vector3.up * offSet.x + Vector3.right * offSet.y;

        return base.StartUp(position, tilemap, go);
    }        


#if UNITY_EDITOR
    [MenuItem("Assets/Create/Tiles/PrefabTile")]
    public static void CreateBlockFallTile()
    {
        string path = EditorUtility.SaveFilePanelInProject("Save PrefabTile", "New PrefabTile", "asset", "Save prefabTile", "Assets");
        if (path == "")
        {
            return;
        }
        AssetDatabase.CreateAsset(ScriptableObject.CreateInstance<PrefabTile>(), path);
    }
#endif
}

