
public partial class BehaviourCreator
{
    public class BehaviourMethod
    {
        string returnType;
        string name;
        string desc;

        public BehaviourMethod(string returnType, string name, string desc = null)
        {
            this.returnType = returnType;
            this.name = name;
            this.desc = desc;
        }

        public string GetMethodDeclaration()
        {
            string result = "";
            if(desc != null)
            {
                result = "\t//" + desc + "\n";
            }
            result += "\t" + returnType + " " + name + "()" + "\n\t{\n\t\t\n\t}\n";
            return result;
        }
    }
}
