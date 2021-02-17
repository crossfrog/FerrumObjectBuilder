using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FerrumObjectBuilder
{
    public partial class MainWindow : Form
    {
        public List<Element> Elements = new List<Element>();
        public MainWindow()
        {
            InitializeComponent();
        }

        public Element AddElement(Element element)
        {
            Elements.Add(element);
            nameList.Items.Add(element.Name);
            typeList.Items.Add(element.GetType().Name);
            return element;
        }

        private void newSpriteButton_Click(object sender, EventArgs e)
        {
            var elementCreationForm = new SpriteCreationForm();
            elementCreationForm.ShowDialog(this);
        }

        private void nameList_DoubleClick(object sender, EventArgs e)
        {
            if (Elements.Count > 0)
            {
                var selectedIndex = Math.Max(0, nameList.SelectedIndex);
                var selectedElement = Elements[selectedIndex];
                ElementCreationForm elementCreationForm;
                var formsByType = new Dictionary<Type, ElementCreationForm>
                {
                    { typeof(SpriteElement), new SpriteCreationForm() }
                };
                elementCreationForm = formsByType[selectedElement.GetType()];
                elementCreationForm.WorkingElement = Elements[selectedIndex];
                elementCreationForm.LoadFromElement(selectedElement);
                elementCreationForm.ShowDialog(this);
            }
        }
    }
}
