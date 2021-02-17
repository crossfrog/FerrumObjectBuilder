using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerrumObjectBuilder
{
    public partial class ElementCreationForm : Form
    {
        public Element WorkingElement;
        public ElementCreationForm()
        {
            InitializeComponent();
        }

        public virtual void LoadFromElement(Element element)
        {
            nameBox.Text = element.Name;
            offsetTextBoxX.Text = element.OffsetX.ToString();
            offsetTextBoxY.Text = element.OffsetY.ToString();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            var mainWindow = Owner as MainWindow;
            var nameList = Owner.Controls["nameList"] as ListBox;
            var selectedIndex = Math.Max(0, nameList.SelectedIndex);

            if (nameBox.Text == "")
                { MessageBox.Show("Please specify a name."); }
            else if (nameList.Items.Contains(nameBox.Text) && nameBox.Text != mainWindow.Elements[selectedIndex].Name)
                { MessageBox.Show("Specified name already exists."); }  
            else
            {
                var newElement = NewElement();
                if (WorkingElement == null)
                {
                    AddElement(newElement);
                }  
                else
                {
                    mainWindow.Elements[selectedIndex] = NewElement();
                    nameList.Items[selectedIndex] = newElement.Name;
                }
                    
                Close();
            }
        }

        protected virtual Element NewElement() { return new Element(); }

        private void AddElement(Element element)
        {
            var mainWindow = Owner as MainWindow;
            mainWindow.AddElement(element);
        }

        private string TextBoxToFloat(string text)
        {
            if (float.TryParse(text, out float number))
            {
                if (text.Last() == '.')
                    return text;
                else
                    return number.ToString();
            }
            else
            {
                return "0";
            }
        }

        private void offsetTextBoxX_TextChanged(object sender, EventArgs e)
        {
            offsetTextBoxX.Text = TextBoxToFloat(offsetTextBoxX.Text);
        }

        private void offsetTextBoxY_TextChanged(object sender, EventArgs e)
        {
            offsetTextBoxY.Text = TextBoxToFloat(offsetTextBoxY.Text);
        }

        private void nameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                okButton_Click(this, new EventArgs());
            }
        }
    }

    public class Element
    {
        public string Name;
        public float OffsetX;
        public float OffsetY;
    }
}
