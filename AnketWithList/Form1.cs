using Newtonsoft.Json;
using System.Text.Json.Serialization;


namespace AnketWithList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool nm = false;
        bool snm = false;
        bool ml = false;
        bool phn = false;
        class MyJson
        {
            public List<User>? JsonDeserialize()
            {
                List<User>? txt = new List<User>();
                if (File.Exists("list.json"))
                {
                    var jsonStr = File.ReadAllText("list.json");
                    txt = JsonConvert.DeserializeObject<List<User>>(jsonStr);
                }
                return txt;
            }
            public void JsonSerialize(List<User> users)
            {
                var txt = JsonConvert.SerializeObject(users, Newtonsoft.Json.Formatting.Indented); ;
                File.WriteAllText("list.json", txt);
            }

        }
        private void namebox_TextChanged(object sender, EventArgs e)
        {
            if (namebox.Text == "")
            {
                nm = false;
            }
            else
                nm = true;
            if (nm == true && snm == true && phn == true && ml == true)
                savebutton.Enabled = true;
            else
                savebutton.Enabled = false;
        }

        private void surnamebox_TextChanged(object sender, EventArgs e)
        {
            if (surnamebox.Text == "")
            {
                snm = false;
            }
            else
                snm = true;
            if (nm == true && snm == true && phn == true && ml == true)
                savebutton.Enabled = true;
            else
                savebutton.Enabled = false;
        }

        private void emailbox_TextChanged(object sender, EventArgs e)
        {
            if (emailbox.Text == "")
            {
                ml = false;
            }
            else
                ml = true;
            if (nm == true && snm == true && phn == true && ml == true)
                savebutton.Enabled = true;
            else
                savebutton.Enabled = false;
        }

        private void numbox_TextChanged(object sender, EventArgs e)
        {
            if (emailbox.Text == "")
                phn = false;
            else
                phn = true;
            if (nm == true && snm == true && phn == true && ml == true)
                savebutton.Enabled = true;
            else
                savebutton.Enabled = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            MyJson myJson = new();
            User newUser = new(namebox.Text, surnamebox.Text, emailbox.Text, numbox.Text, datebox.Value);
            List<User>? list = myJson.JsonDeserialize();
            list.Add(newUser);
            myJson.JsonSerialize(list);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Listbox.Items.Clear();
            MyJson myJson = new();
            List<User> list = new List<User>();
            if (File.Exists(loadbox.Text))
            {
                list = myJson.JsonDeserialize();
                for (int i = 0; i < list.Count; i++)
                {
                    Listbox.Items.Add(list[i].Name);
                }
            }
        }

        private void Listbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MyJson myJson = new();
            List<User> userList = new List<User>();
            if (File.Exists(loadbox.Text))
            {
                userList = myJson.JsonDeserialize();
            }
            for (int i = 0; i < userList.Count; i++)
            {
                
            }
        }

        private void Listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyJson myJson = new();
            List<User> users = new();
            if (File.Exists(loadbox.Text))
            {
                users = myJson.JsonDeserialize();
            }
            namebox.Text = users[Listbox.SelectedIndex].Name;
            surnamebox.Text = users[Listbox.SelectedIndex].Surname;
            emailbox.Text = users[Listbox.SelectedIndex].Mail;
            numbox.Text = users[Listbox.SelectedIndex].Phone;
            datebox.Value = users[Listbox.SelectedIndex].datetime;
            savebutton.Enabled = false;
            editbutton.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyJson myJson = new();
            List<User> users = new();
            if (File.Exists(loadbox.Text))
            {
                users=myJson.JsonDeserialize();
            }
            users[Listbox.SelectedIndex].Name = namebox.Text;
            users[Listbox.SelectedIndex].Surname = surnamebox.Text;
            users[Listbox.SelectedIndex].Phone = numbox.Text;
            users[Listbox.SelectedIndex].Mail = emailbox.Text;
            users[Listbox.SelectedIndex].datetime = datebox.Value;
            myJson.JsonSerialize(users);
        }
    }
}