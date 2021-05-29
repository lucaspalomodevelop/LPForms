using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPForms
{

    public partial class LPFormPanel : Panel
    {

      //  ObservableCollection<ContainerControl> containerControls = new ObservableCollection<ContainerControl>();

        public LPFormPanel()
        {
            InitializeComponent();
        }

        public LPFormPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void clear()
        {
            this.Controls.Clear();
        }

        public void ShowForm(Form from)
        {
            //  clear();
            from.TopLevel = false;
            from.AutoScroll = true;
            this.Controls.Add(from);
            from.Show();
        }

        public void ShowForm(Form form, FormBorderStyle borderstyle)
        {
            form.FormBorderStyle = borderstyle;
            ShowForm(form);
        }

    }
}



