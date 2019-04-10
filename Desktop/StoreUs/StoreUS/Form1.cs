using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreUS.Classes;
using System.Xml;

namespace StoreUS
{
    public partial class Form1 : Form
    {
        List<Item> Items;

        XmlDocument XML = new XmlDocument();

        Item CurrentItem;

        public Form1()
        {
            InitializeComponent();
            InitializeItems();

        }

        /// <summary>
        /// Reads the txt file which cointains all of the item data and puts it into a list
        /// </summary>
        private void InitializeItems()
        {
            //Running an instance of bg1 so it doesnt crash the GUI
            backgroundWorker1.RunWorkerAsync();
        }

        private void Button_Add_Item_Click(object sender, EventArgs e)
        {
            Item temp = new Item(int.Parse(TextBox_AddItem_ID.Text), TextBox_AddItem_ItemName.Text, TextBox_AddItem_Origin.Text, int.Parse(TextBox_AddItem_Quantity.Text), float.Parse(TextBox_AddItem_Price.Text), ComboBox_AddItem_Status.SelectedItem.ToString());
            //Needs extra code to check if the item exists already so no duplicates can be formed
            //Needs extra code to also add the item to xml file which contains all items
            Items.Add(temp);
            ListView_ItemRange.Items.Add(temp.Name);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Items = new List<Item>();
            XML.Load("Items.xml");

            //reads the xml file which contains item data
            foreach(XmlNode node in XML.DocumentElement)
            {
                string name = node.Attributes[0].InnerText;
                int ID = int.Parse(node.ChildNodes[0].InnerText);
                string Origin = node.ChildNodes[1].InnerText;
                string Status = node.ChildNodes[2].InnerText;
                float Price = float.Parse(node.ChildNodes[3].InnerText);
                int Quantity = int.Parse(node.ChildNodes[4].InnerText);

                Item temp = new Item(ID, name, Origin, Quantity, Price, Status);
                Items.Add(temp);
            }
            AddItems();
            
        }
        private void AddItems()
        {
            foreach(Item c in Items)
            {
                ListView_ItemRange.Items.Add(c.Name);
            }
        }

        private void ListView_ItemRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            backgroundWorker2.RunWorkerAsync();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
          /*  foreach(Item node in Items)
            {
                if(node.Name.Equals(ListView_ItemRange.SelectedItems[0].Text))
                {
                    CurrentItem = node;
                }
            }*/
        }
    }
}
