// An example class for a Car, containing year, make, and model info

public class Car
{
    public string _make;
    public string _model;
    public int _year;


    public string GetDescription()
    {
        return ($"Car: {_year} {_make} {_model}");
    }
}