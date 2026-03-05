using System.Dynamic;

public class Motorcycle : Vehicle
{
    private string _handlebarType;

    public Motorcycle (string handlebarType, int wheelNum) : base(wheelNum)
    {
        _handlebarType = handlebarType;
        // _wheelNum = wheelNum;
    }

        public Motorcycle (string handlebarType, int wheelNum, string engineType) : 
            base(wheelNum, engineType)
    {
        _handlebarType = handlebarType;
        // _wheelNum = wheelNum;    // Created in the parent class Vehicle
        // _engineType = engineType;    // Created in the parent class Vehicle
    }

    public string GetDescription() 
    {
        return GetEngineType();
    }
}