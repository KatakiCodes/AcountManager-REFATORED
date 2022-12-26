using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logScreen._modal;

namespace logScreen._modal._modal_behavior
{
    class Modal
    {
        public void openModal(Form mainForm, Form modal)
        {
                Modal_verlay modal_overlay = new Modal_verlay();
                using (modal_overlay)
                {
                    modal_overlay.ShowInTaskbar = false;
                    modal_overlay.Location = mainForm.Location;
                    modal_overlay.Size = mainForm.Size;
                    modal_overlay.Show();

                    modal.Owner = modal_overlay;
                    modal.ShowDialog();
                }
        }
        public void registerAccount(Form mainForm)
        {
            //Esta função será responsável da abertura da modal
            //De cadastro de contas
            openModal(mainForm, new _modal.Modal());
        }
        public void AllAccount(Form mainForm)
        {
            //Esta função será responsável da abertura da modal
            //De cadastro de contas
            openModal(mainForm, new _modal.All_Accounts());
        }
    }
}
