
using System;

namespace FirstProject.Models
{
    public class MyViewModel
    {
        private readonly DateTime Now;
        public string Message { get { return GetMessage(); } }
        public string CreationTime { get { return Now.ToString(); } }

        public MyViewModel()
        {
            this.Now = DateTime.Now;
        }

        private string GetMessage()
        {
            if (Now.Hour < 12)
            {
                return "Good Morning";
            }

            if (Now.Hour < 18)
            {
                return "Good Afternon";
            }

            return "Good Evening";
        }
    }
}
