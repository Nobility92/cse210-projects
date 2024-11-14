 public class Job
        {
            public string _jobTitle;
            public int _startYear;
            public int _endYear;

            public void DisplayResume()
            {
                Console.WriteLine($"{_jobTitle} {_startYear}-{_endYear}");
            }
        }