namespace WebApplication1.Services
{
    public interface ICompareService
    {
        public bool Compare(int a, int b);
    }
    public class CompareService : ICompareService
    {
        public bool Compare(int a, int b)
        {
            return a > b;
        }
    }
}
