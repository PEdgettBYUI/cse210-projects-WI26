public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public string GetDescription()
    {
        return $"Job: {_jobTitle} at {_company} starting {_startYear} and ending {_endYear}";
    }
}