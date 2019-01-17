using System;
using System.Windows.Forms;
using WindowsFormsClient.TicketService;

namespace WindowsFormsClient
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            using(TicketServiceClient client = new TicketServiceClient())
            {
                var tickets = client.GetAll();

                listView1.View = View.Details;
                listView1.FullRowSelect = true;

                listView1.Columns.Add("Id");
                listView1.Columns.Add("EventName");
                listView1.Columns.Add("Price");

                foreach (var item in tickets)
                {
                    listView1.Items.Add(new ListViewItem(new string[] {
                        item.Id.ToString(),
                        item.EventName.ToString(),
                        item.Price.ToString()
                    }));
                }
            } 
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = listView1.SelectedItems;

            if (item.Count != 0)
            {
                textBox_event_update.Text = item[0].SubItems[1].Text;
                textBox_price_update.Text = item[0].SubItems[2].Text;
            }
        }

        private void button_create_Click_1(object sender, EventArgs e)
        {
            string eventName = textBox_event_create.Text;
            decimal price;
            if (Decimal.TryParse(textBox_price_create.Text, out price) && !String.IsNullOrEmpty(textBox_price_create.Text))
            {
                using (TicketServiceClient client = new TicketServiceClient())
                {
                    Ticket ticket = new Ticket {
                        EventName = eventName,
                        Price = price
                    };

                    int currentId = client.Create(ticket);
                    listView1.Items.Add(new ListViewItem(new string[] {
                        currentId.ToString(),
                        ticket.EventName.ToString(),
                        ticket.Price.ToString()
                    }));
                }

                textBox_event_create.Text = string.Empty;
                textBox_price_create.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Incorrect data");
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            var item = listView1.FocusedItem;
            int id = Convert.ToInt32(item.SubItems[0].Text);

            using (TicketServiceClient client = new TicketServiceClient())
            {
                client.Delete(id);
                listView1.Items.Remove(listView1.FocusedItem);
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            var item = listView1.SelectedItems;

            if (item.Count != 0)
            {
                string eventName = textBox_event_update.Text;
                decimal price;
                if (Decimal.TryParse(textBox_price_update.Text, out price) && !String.IsNullOrEmpty(textBox_price_update.Text))
                {
                    using (TicketServiceClient client = new TicketServiceClient())
                    {
                        Ticket ticket = new Ticket
                        {
                            Id = Convert.ToInt32(item[0].SubItems[0].Text),
                            EventName = eventName,
                            Price = price
                        };

                        client.Update(ticket);
                        item[0].SubItems[1].Text = eventName;
                        item[0].SubItems[2].Text = price.ToString();
                    }

                    textBox_event_update.Text = string.Empty;
                    textBox_price_update.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Incorrect data or item is not selected");
                }
            }          
        }
    }
}
