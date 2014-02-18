using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace DiHaoOA.Controls
{
    public partial class NavBar : UserControl
    {
        public delegate void SelectChildItem(string eventCode);//declare a delegate of childItem

        public event SelectChildItem OnChildItemSeleteion;

        public event EventHandler OnMenuSelection;
        private  ArrayList NavItems = new ArrayList();
        private  string selecteditem = string.Empty;
        //private System.Resources.ResourceManager rm = new System.Resources.ResourceManager("Resources", System.Reflection.Assembly.GetExecutingAssembly());

        public NavBar()
        {
            InitializeComponent();
        }

        public ArrayList MenuItems
        {
            set
            {
                NavItems = value;
            }
            get
            {
                return (NavItems);
            }
        }

        public void RenderMenu()
        {
            if (NavItems.Count == 0) return;
            LoadMenuItems(NavItems);
        }

        private void LoadMenuItems(ArrayList NavItems)
        {
            int btnHeight = 30;
            Panel mainpanel = new Panel();
            mainpanel.Dock = DockStyle.Top;
            mainpanel.AutoSize = true;
            mainpanel.Name = "mainpanel";


            Panel pnl = new Panel();
            pnl.Height = 1;
            pnl.Dock = DockStyle.Bottom;
            mainpanel.Controls.Add(pnl);
            string selectedbutton = string.Empty;
            foreach (NavItem navitems in NavItems)
            {
                Button btn = new Button();
                btn.Height = btnHeight;
                btn.Dock = DockStyle.Bottom;
                btn.Name = navitems.eventCode;
                btn.BackColor = Color.FromArgb(238,239,241);
                btn.Click += new EventHandler(btn_Click);
                btn.Text = navitems.MnuItem;
                btn.ForeColor = Color.FromArgb(84, 102, 124);
                btn.Font = new Font(btn.Font.Name, btn.Font.Size, FontStyle.Bold);
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.Cursor = Cursors.Hand;

                if (navitems.Selected == true) selectedbutton = btn.Name;

                mainpanel.Controls.Add(btn);


                pnl = new Panel();
                pnl.Dock = DockStyle.Bottom;
                pnl.Name = "panel_" + navitems.eventCode;
                pnl.BackColor = Color.FromArgb(219, 232, 241);
                pnl.Visible = false;

                pnl.Height = navitems.childNavItems.Count * btnHeight;
                foreach (childNavItems childnavitems in navitems.childNavItems)
                {
                    Label childbtn = new Label();

                    childbtn.FlatStyle = FlatStyle.Flat;
                    //childbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 212, 253);
                    childbtn.Height = btnHeight;
                    childbtn.Dock = DockStyle.Bottom;
                    childbtn.Text = "  " + childnavitems.MnuItem;
                    childbtn.Click += new EventHandler(childbtnbtn_Click);
                    childbtn.Name = childnavitems.eventCode;
                    //childbtn.Parent = btn;
                    if (childnavitems.eventCode == "InforAllList")
                    {
                        childbtn.BackColor = Color.FromArgb(218,230,242);
                    }
                    childbtn.ForeColor = Color.FromArgb(84, 102, 124);
                    childbtn.TextAlign = ContentAlignment.MiddleLeft; ;
                    childbtn.Cursor = Cursors.Hand;

                    pnl.Controls.Add(childbtn);
                }

                mainpanel.Controls.Add(pnl);


            }
            panel1.Controls.Add(mainpanel);


            if (selectedbutton != string.Empty)
            {
                Button btn = (Button)panel1.Controls["mainpanel"].Controls[selectedbutton];
                selecteditem = btn.Name;
                ShowChilds(btn);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button navItem = sender as Button;
            if (selecteditem != ((Button)sender).Name)
            {
                ShowChilds((Button)sender);
            }

            //OnMenuSelection(sender, e);
            selecteditem = ((Button)sender).Name;

        }

        private void ShowChilds(Button btn)
        {
            ResetAllPanels();

            ResetChildMenuHook();

            Panel pnl = (Panel)panel1.Controls["mainpanel"].Controls["panel_" + btn.Name];
            pnl.Visible = true;
            btn.Text = btn.Text.Replace("》", "︾");
            
        }

        private void ResetChildMenuHook()
        {
            foreach (Control ctrl in panel1.Controls["mainpanel"].Controls)
            {
                if (ctrl is Button)
                {
                    Button b = ctrl as Button;
                    if (b.Text.Contains("︾"))
                    {
                        b.Text = b.Text.Replace("︾", "》");
                    }
                }
            }
        }

        public void ChangeNavItem(string menu,string childMenu)
        {
            ResetAllPanels();
           
            selecteditem = menu;
            Panel pnl = (Panel)panel1.Controls["mainpanel"].Controls["panel_" + menu];
            pnl.Visible = true;
            foreach (Control button in pnl.Controls)
            {
                if (button.Name != childMenu)
                {
                    button.BackColor = Color.FromArgb(219, 232, 241);
                }
            }
            Label label = (Label)pnl.Controls[childMenu];
            label.BackColor = Color.FromArgb(191, 212, 253);
        }

        private void childbtnbtn_Click(object sender, EventArgs e)
        {
            OnMenuSelection(sender, e);
            Label btnSender = sender as Label;
            //btnSender.BackColor = Color.FromArgb(218, 230, 242);
            btnSender.BackColor = Color.FromArgb(188, 215, 236);
            foreach(Control button in btnSender.Parent.Controls)
            {
                if (button.Name != btnSender.Name)
                {
                    button.BackColor = Color.FromArgb(219, 232, 241);
                }
            }
            
        }



        private void ResetAllPanels()
        {
            foreach (Control ctrl in panel1.Controls["mainpanel"].Controls)
            {
                if (ctrl is Panel)
                {
                    if (ctrl.Name.Length >= 6)
                    {
                        if (ctrl.Name.Substring(0, 6) == "panel_")
                        {
                            if (ctrl.Visible == true) ctrl.Visible = false;
                        }
                    }
                }
            }
           
        }

        public class NavItem
        {
            public string MnuItem;
            public string eventCode;
            public ArrayList childNavItems;
            public bool Selected = false;

            public NavItem(string _MnuItem, string _eventCode, ArrayList _childNavItems, bool _selected)
            {
                MnuItem = _MnuItem;
                eventCode = _eventCode;
                childNavItems = _childNavItems;
                Selected = _selected;
            }
            public NavItem(string _MnuItem, string _eventCode, ArrayList _childNavItems)
            {
                MnuItem = _MnuItem;
                eventCode = _eventCode;
                childNavItems = _childNavItems;
            }
            public NavItem(string _MnuItem, string _eventCode)
            {
                MnuItem = _MnuItem;
                eventCode = _eventCode;
            }

        }

        public class childNavItems
        {
            public string MnuItem;
            public string eventCode;
            public childNavItems(string _MnuItem, string _eventCode)
            {
                MnuItem = _MnuItem;
                eventCode = _eventCode;
            }
            public childNavItems()
            {
              
            }
        }
    }
}
