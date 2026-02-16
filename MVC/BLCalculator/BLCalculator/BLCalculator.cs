using DALcalc;
namespace BLCalculator
{
    public class BLCalc
    {
        public int BLAdd(int a, int b)
        {
            DalCalculator d = new DalCalculator();
            int sum = d.Add(a,b);
            return sum - 1;

        }
    }
}
