using System.Collections.Generic;

public partial class BehaviourCreator
{
    public enum BehaviourType
    {
        Normal,
        Networked,
        Inherited,
        Editor
    }

    string name;
    BehaviourType type;
    List<BehaviourMethod> Methods = new List<BehaviourMethod>();

    public BehaviourCreator(string name, BehaviourType type = BehaviourType.Normal)
    {
        this.name = name;
        this.type = type;
    }

    private string GetDependancies()
    {
        return "using UnityEngine;\n" +
               "using System.Collections;\n" +
               (type == BehaviourType.Networked ? "using UnityEngine.Networking;\n" : "");
    }

    public void AddMethod(BehaviourMethod method)
    {
        Methods.Add(method);
    }

    private string ParseMethods()
    {
        string result = "";
        foreach (var Method in Methods)
        {
            result += Method.GetMethodDeclaration();
        }
        return result;
    }

    public string GetGeneratedBehaviour()
    {
        return GetDependancies()+
               "\n"+
               "public class "+name+" : "+
               (type == BehaviourType.Networked ? "NetworkBehaviour\n" : "MonoBehaviour\n")+
               "{\n"+
               ParseMethods()+
               "}"; 
    }
}
