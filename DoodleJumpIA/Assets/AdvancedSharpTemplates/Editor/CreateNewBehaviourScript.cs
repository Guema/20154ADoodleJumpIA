using UnityEngine;
using UnityEditor;
using System.IO;

public class CreateNewBehaviourScript : EditorWindow
{
    [MenuItem("Assets/Create/C# Advanced Script", priority = 81)]
    static void Init()
    {
        CreateNewBehaviourScript window = (
            CreateNewBehaviourScript)GetWindow(typeof(CreateNewBehaviourScript),
            true,
            "Create new behaviour");
        window.minSize = new Vector2(300, 400);
        window.Show();
    }

    string scriptName = "NewBehaviourScript";
    bool implementStart = true;
    bool implementUpdate = true;
    bool implementFixedUpdate = false;

    void OnGUI()
    {
        EditorGUILayout.LabelField("Create New Behaviour Script");
        scriptName = EditorGUILayout.TextField("Script Name", scriptName);
        implementStart = EditorGUILayout.Toggle("Implement Start", implementStart);
        implementUpdate = EditorGUILayout.Toggle("Implement Update", implementUpdate);
        implementFixedUpdate = EditorGUILayout.Toggle("Implement FixedUpdate", implementFixedUpdate);
        
        if (GUILayout.Button("Create Script"))
        {
            
            BehaviourCreator bc = new BehaviourCreator(scriptName, BehaviourCreator.BehaviourType.Normal);
            if(implementStart)
            {
                bc.AddMethod(new BehaviourCreator.BehaviourMethod(
                "void",
                "Start",
                " Use this for initialization"));
            }
            if(implementUpdate)
            {
                bc.AddMethod(new BehaviourCreator.BehaviourMethod(
                "void",
                "Update",
                " Update is called once per frame"));
            }
            if(implementFixedUpdate)
            {
                bc.AddMethod(new BehaviourCreator.BehaviourMethod(
                "void",
                "FixedUpdate",
                " FixedUpdate is called on each game cycle"));
            }
            

            string projpath;
            projpath = Application.dataPath.Substring(0, Application.dataPath.Length - 6);
            
            Debug.Log(projpath);
            Debug.Log(UnityUtil.GetSelectedPathOrFallback());

            File.WriteAllText(
                projpath+UnityUtil.GetSelectedPathOrFallback()+"/"+scriptName+".cs",
                bc.GetGeneratedBehaviour());
            Close();
            AssetDatabase.Refresh();
        }
    }
}
