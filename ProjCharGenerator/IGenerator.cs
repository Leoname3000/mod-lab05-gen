namespace generator
{
    public interface IGenerator
    {
        string GenerateText(int length, int? randSeed = null);
    }
}