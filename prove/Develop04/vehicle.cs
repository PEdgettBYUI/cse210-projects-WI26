public class Vehicle
{
    private int _wheelNum;
    private string _engineType;

    public Vehicle(int wheelNum)
    {
        _wheelNum = wheelNum;
        _engineType = "UNKNOWN";

    }

        public Vehicle(int wheelNum, string engineType)
    {
        _wheelNum = wheelNum;
        _engineType = engineType;
    }

    public string GetEngineType()
    {
        return _engineType;
    }
}