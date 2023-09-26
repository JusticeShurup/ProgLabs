namespace LR5
{
    public interface IHuman
    {
        void ReadFromFile(ref StreamReader streamReader);
        void WriteInFile(ref StreamWriter streamWriter);
        
    }
}