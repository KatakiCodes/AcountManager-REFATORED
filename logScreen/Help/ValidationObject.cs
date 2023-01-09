using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace logScreen.Help
{
    public class ValidationObject
    {
        private ValidationContext context;
        private List<ValidationResult> results;
        private bool Valid;
        private string message;

        public ValidationObject(Object instance)
        {
            context = new ValidationContext(instance);
            results = new List<ValidationResult>();
            Valid = Validator.TryValidateObject(instance, context, results, true);
        }

        public bool Validate()
        {
            if (Valid == false)
            {
                foreach (ValidationResult item in results)
                {
                    message = item.ErrorMessage;
                }
                System.Windows.Forms.MessageBox.Show(message);
            }
            return Valid;
        }
    }
}
