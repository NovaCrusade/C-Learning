using System;

namespace Properties
{
    public class Person
    {
        public string Name { get; set; }

        public DateTime Birthday { get; private set; }

        public Person(DateTime Birthday)
        {
            Birthday = Birthday;
        }


        public int Age
        {
            get
            {
                var timespan = DateTime.Now - Birthday;
                var years = timespan.Days / 365;

                return years;
            }
        }
    }
}
