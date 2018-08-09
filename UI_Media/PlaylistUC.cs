using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace UI_Media
{ 
    public partial class PlaylistUC : UserControl
    {
        List<string> playlist;
        List<Button> btn_list;
        List<Button> delete_list;

        public PlaylistUC()
        {
            InitializeComponent();
        }

        public void GetList(List<string> list)
        {
            playlist = list;
            createButtonList();
        }

        void createButtonList()
        {
            btn_list = new List<Button>();
            delete_list = new List<Button>();
            for (int i = 0; i < playlist.Count; i++)
            {
                Button tmp = button1.Clone();
                tmp.FlatAppearance.BorderSize = 0;
                tmp.Text = System.IO.Path.GetFileName(playlist[i]);
                tmp.Location = new Point(0, 40 * i);
                btn_list.Add(tmp);
                btn_list[i].Visible = true;
                this.Controls.Add(btn_list[i]);
                btn_list[i].Tag = i;

                tmp = button2.Clone();
                tmp.FlatAppearance.BorderSize = 0;
                tmp.Location = new Point(601, 40 * i);
                delete_list.Add(tmp);
                delete_list[i].Visible = true;
                this.Controls.Add(delete_list[i]);
                delete_list[i].Tag = i;           
            }

            for(int i = 0; i < playlist.Count; i++)
            {
                btn_list[i].Click += Song_Click;
                delete_list[i].Click += Delete_List_Click;
            }
        }

        private void Song_Click(object s, EventArgs e)
        {
            Button btn = (Button)s;
            int i = (int)btn.Tag;
            PlayMainForm.Play(i);

            PlayMainForm parent = (PlayMainForm)this.Parent;
            if(parent != null)
                parent.changeTitle(i);
        }

        private void Delete_List_Click(object s, EventArgs e)
        {
            Button btn = (Button)s;
            int i = (int)btn.Tag;
            PlayMainForm.Delete(i);
            clearButtonList();
            createButtonList();
        }
        
        private void clearButtonList()
        {
            for(int i = 0; i < btn_list.Count; i++)
            {
                btn_list[i].Visible = false;
                delete_list[i].Visible = false;
            }
        }
    }

    public static class ControlExtensions
    {
        public static T Clone<T>(this T controlToClone)
            where T : Control
        {
            PropertyInfo[] controlProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            T instance = Activator.CreateInstance<T>();

            foreach (PropertyInfo propInfo in controlProperties)
            {
                if (propInfo.CanWrite)
                {
                    if (propInfo.Name != "WindowTarget")
                        propInfo.SetValue(instance, propInfo.GetValue(controlToClone, null), null);
                }
            }

            return instance;
        }
    }
}
