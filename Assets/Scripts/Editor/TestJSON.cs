using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class TestJSON 
{

    [MenuItem("Test/Json")]
    public static void TestJson() {
        var result = JsonUtility.FromJson<Test>(File.ReadAllText(Application.dataPath + "/Resources/Generated/test.json"));
        Debug.Log(result.wew);
    }

}
