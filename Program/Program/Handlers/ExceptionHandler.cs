using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program.Handlers
{
    public class ExceptionHandler : Exception
    {
        public ExceptionHandler()
        {
            
        }

        public ExceptionHandler(string message) : base(message)
        {
            MessageBox.Show(message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public ExceptionHandler(string message, Exception inner) : base(message, inner)
        {
            
        }
    }
}
