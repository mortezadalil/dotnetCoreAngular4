using System.Collections.Generic;

namespace SuperCoolApp.BL.Exception
{
    public class NameAlreadyExist : System.Exception
    {

        public NameAlreadyExist()
        {
            HResult = 100;
        }
    
        public override string Message => "Name already exist.";
    }
}
