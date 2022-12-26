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
        private bool valid;
        private string message;

        public ValidationObject(object instance)
        {
            context = new ValidationContext(instance);
            valid = Validator.TryValidateObject(instance, context, results, true);
            results = new List<ValidationResult>();
        }



        //Validate
        public bool Validate()
        {
            if (valid == false)
            {
                foreach (ValidationResult item in results)
                {
                    message = item.ErrorMessage;
                }
                
                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
