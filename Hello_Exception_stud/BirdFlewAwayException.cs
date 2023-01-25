using System;

namespace Hello_Exception_stud
{
    //Create the BirdFlewAwayException class, derived from ApplicationException  with two properties  

        //When
        //Why

        //Create constructors

    class BirdFlewAwayException : ApplicationException
    {
        public DateTime When { get; set; }
        public string Why { get; set; }

        public BirdFlewAwayException(string massage, string cause,DateTime time) : base(message: massage)
        {
            When = time;
            Why = cause;
        }
    }
}
