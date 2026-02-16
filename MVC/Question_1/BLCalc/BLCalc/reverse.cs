using DalCalc;
namespace BLCalc
{
    public class ReverseString
    {
        public List<string> ReverseNames()
        {
            DalList dal = new DalList();
            List<string> originalNames = dal.GetNames();

            List<string> reversedNames = new List<string>();

            foreach (string name in originalNames)
            {
                char[] chars = name.ToCharArray();
                Array.Reverse(chars);
                reversedNames.Add(new string(chars));
            }

            return reversedNames;
        }
    }
}
