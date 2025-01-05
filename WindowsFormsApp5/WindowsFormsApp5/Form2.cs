using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ClosedXML.Excel;
using Newtonsoft.Json;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();



        }


        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-F4415RA;Initial Catalog=hastane;Integrated Security=True;Encrypt=False");

        private void KayitListele()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * FROM hastalar", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read["id"].ToString();
                ekle.SubItems.Add(read["Tc"].ToString());
                ekle.SubItems.Add(read["Ad"].ToString());
                ekle.SubItems.Add(read["Soyad"].ToString());
                ekle.SubItems.Add(read["OdaNo"].ToString());
                ekle.SubItems.Add(read["YatisTarihi"].ToString());
                ekle.SubItems.Add(read["TaburcuTarihi"].ToString());
                ekle.SubItems.Add(read["TelefonNo"].ToString());
                ekle.SubItems.Add(read["Ucret"].ToString());
                listView1.Items.Add(ekle);

            }
            baglanti.Close();

            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                listView1.Columns[i].Width = -2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            KayitListele();
        }


        private void Form2_Load(object sender, EventArgs e)
        {



            CultureInfo tr = new CultureInfo("tr-TR");

            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            dateTimePicker1.CustomFormat = "dd MMMM yyyy dddd HH:mm:ss";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;

            dateTimePicker2.CustomFormat = "dd MMMM yyyy dddd HH:mm:ss";

            TimeZoneInfo trBolgesi = TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time");

            DateTime trTime = TimeZoneInfo.ConvertTime(DateTime.Now, trBolgesi);

            dateTimePicker1.Value = trTime;

            dateTimePicker2.Value = trTime;

            Application.CurrentCulture = tr;




            baglanti.Open();
            SqlCommand km = new SqlCommand("Select * From bosoda", baglanti);
            SqlDataReader oda = km.ExecuteReader();
            while (oda.Read())
            {
                comboBox1.Items.Add(oda[0].ToString());
            }
            baglanti.Close();


            listView1.View = View.Details;
            listView1.Columns.Add("id");
            listView1.Columns.Add("Tc");
            listView1.Columns.Add("Ad");
            listView1.Columns.Add("Soyad");
            listView1.Columns.Add("OdaNo");
            listView1.Columns.Add("YatisTarihi");
            listView1.Columns.Add("TaburcuTarihi");
            listView1.Columns.Add("TelefonNo");
            listView1.Columns.Add("Ucret");







        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kayitEkleButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into hastalar(id,Tc,Ad,Soyad,OdaNo,YatisTarihi,TaburcuTarihi,TelefonNo,Ucret) values('" +
            idtextbox.Text.ToString() + "','" +
            textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" +
            textBox3.Text.ToString() + "','" + comboBox1.Text.ToString() + "','" +
            dateTimePicker1.Text.ToString() + "','" + dateTimePicker2.Text.ToString() +
            "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "')", baglanti);

            komut.ExecuteNonQuery();

            komut.CommandText = "insert into doluoda(doluyerler) values('" + comboBox1.Text + "')";

            komut.CommandText = ("delete from bosoda where bosyerler = '" + comboBox1.Text + "'");
            komut.ExecuteNonQuery();
            baglanti.Close();
            KayitListele();
            idtextbox.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        int id = 0;

        private void listView1_MouseDoubleClick(object sender,
        MouseEventArgs e)
        {


            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            idtextbox.Text = listView1.SelectedItems[0].SubItems[0].Text;

            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;

            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;

            textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;

            comboBox1.Text = listView1.SelectedItems[0].SubItems[4].Text;

            dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[5].Text;

            dateTimePicker2.Text = listView1.SelectedItems[0].SubItems[6].Text;

            textBox4.Text = listView1.SelectedItems[0].SubItems[7].Text;

            textBox5.Text = listView1.SelectedItems[0].SubItems[8].Text;



        }
        private void kayitSilButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From hastalar where id = (" + id + ")", baglanti);

            komut.ExecuteNonQuery();

            komut.CommandText = "Insert Into bosoda(bosyerler) VALUES('" + comboBox1.Text + "')";

            komut.ExecuteNonQuery();

            komut.CommandText = ("Delete from doluoda where doluyerler = '" + comboBox1.Text + "'");

            komut.ExecuteNonQuery();

            baglanti.Close();

            KayitListele();


        }

        private void idtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void kayitGuncelleButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update hastalar set id = '" + idtextbox.Text.ToString() +


                "',Tc = '" + textBox1.Text.ToString() +

                "',Ad='" + textBox2.Text.ToString() +

                "',Soyad='" + textBox3.Text.ToString() +

                "',OdaNo='" + comboBox1.Text.ToString() +

                "',YatisTarihi='" + dateTimePicker1.Text.ToString() +

                "',TaburcuTarihi='" + dateTimePicker2.Text.ToString() +

                "',TelefonNo='" + textBox4.Text.ToString() +

                "',Ucret='" + textBox5.Text.ToString() +

                "'where id = " + id + "", baglanti);

            komut.ExecuteNonQuery();

            baglanti.Close();

            KayitListele();

        }
        private void move(object sender, EventArgs e)
        {
            textBox7.Text = textBox7.Text.Substring(1) + textBox7.Text.Substring(0, 1);

        }
        private void time(object sender, EventArgs e)
        {
            saatLabel.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();

        }





        private void kayitAraButton_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();

            baglanti.Open();

            SqlCommand kmt = new SqlCommand("Select *from hastalar  where Ad like '%" +
                textBox6.Text + "%'", baglanti);

            SqlDataReader re = kmt.ExecuteReader();

            while (re.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = re["id"].ToString();
                ekle.SubItems.Add(re["Tc"].ToString());
                ekle.SubItems.Add(re["Ad"].ToString());
                ekle.SubItems.Add(re["Soyad"].ToString());
                ekle.SubItems.Add(re["OdaNo"].ToString());
                ekle.SubItems.Add(re["YatisTarihi"].ToString());
                ekle.SubItems.Add(re["TaburcuTarihi"].ToString());
                ekle.SubItems.Add(re["TelefonNo"].ToString());
                ekle.SubItems.Add(re["Ucret"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();

        }

        private void disaAktarButon_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            
            saveFileDialog.Filter = "Excel Dosyaları (*.xlsx)|*.xlsx|JSON Dosyaları (*.json)|*.json|XML Dosyaları (*.xml)|*.xml|TXT Dosyaları (*.txt)|*.txt|CSV Dosyaları (*.csv)|*.csv|HTML Dosyaları (*.html)|*.html|Tüm Dosyalar (*.*)|*.*";

            
            DialogResult result = saveFileDialog.ShowDialog();

            
            if (result == DialogResult.OK)
            {
                
                string dosyaAdi = saveFileDialog.FileName;

                
                string format = Path.GetExtension(dosyaAdi).TrimStart('.');
                switch (format)
                {
                    case "xlsx":
                        ExcelAktarma(dosyaAdi);
                        break;
                    case "json":
                        JSONAktarma(dosyaAdi);
                        break;
                    case "xml":
                        XMLAktarma(dosyaAdi);
                        break;
                    case "txt":
                        TXTAktarma(dosyaAdi);
                        break;
                    case "csv":
                        CSVAktarma(dosyaAdi);
                        break;
                    case "html":
                        HTMLAktarma(dosyaAdi);
                        break;
                    default:
                        MessageBox.Show("Geçersiz format seçildi.");
                        break;
                }

                MessageBox.Show("Veriler başarıyla dışa aktarıldı.");
            }
        }



        private void ExcelAktarma(string dosyaAdi)
        {
            
            string tamYol = Path.Combine(dosyaAdi);

            
            var kitap = new XLWorkbook();
           
            var ws = kitap.Worksheets.Add("Veriler");

         
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int j = 0; j < listView1.Columns.Count; j++)
                {
                    ws.Cell(i + 1, j + 1).Value = listView1.Items[i].SubItems[j].Text;
                }
            }

            
            kitap.SaveAs(tamYol);
        }

        private void JSONAktarma(string dosyaAdi)
        {
        string yol = Path.Combine(dosyaAdi);

        try
        {
                
         using (StreamWriter yazici = new StreamWriter(yol))
         {
          var jsonSerializer = new JsonSerializer();
         
          jsonSerializer.Serialize(yazici, listView1.Items.Cast<ListViewItem>().Select(satir =>
          {
            var satirVerisi = new Dictionary<string, string>();
           foreach (ListViewItem.ListViewSubItem altSutun in satir.SubItems)
           {
             satirVerisi[listView1.Columns[satir.SubItems.IndexOf(altSutun)].Text] = altSutun.Text;
           }
           return satirVerisi;
           }));
           }

          MessageBox.Show("Veriler başarıyla JSON olarak dışa aktarıldı.");
           }
          catch (Exception ex)
          {
          MessageBox.Show("JSON dosyası oluşturulurken bir hata oluştu: " + ex.Message);
          }
        }

        private void XMLAktarma(string dosyaAdi)
        {
            
            string yol = Path.Combine(dosyaAdi);

            try
            {
                
                using (XmlWriter yazici = XmlWriter.Create(yol))
                {
                    
                    yazici.WriteStartDocument();
                    yazici.WriteStartElement("Veriler");

                    
                    foreach (ListViewItem satir in listView1.Items)
                    {
                        yazici.WriteStartElement("Satır");
                        foreach (ListViewItem.ListViewSubItem altSutun in satir.SubItems)
                        {
                            yazici.WriteElementString(listView1.Columns[satir.SubItems.IndexOf(altSutun)].Text, altSutun.Text);
                        }
                        yazici.WriteEndElement();
                    }

                    yazici.WriteEndElement();
                    yazici.WriteEndDocument();
                }

                MessageBox.Show("Veriler başarıyla XML olarak dışa aktarıldı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("XML dosyası oluşturulurken bir hata oluştu: " + ex.Message);
            }
        }


        private void TXTAktarma(string dosyaAdi)
        {
            
        string yol = Path.Combine(dosyaAdi);

        try
        {
        using (StreamWriter yazici = new StreamWriter(yol))
        {
                    
        yazici.WriteLine(string.Join(",", listView1.Columns.Cast<ColumnHeader>().Select(sutun => sutun.Text)));

        foreach (ListViewItem satir in listView1.Items)
        
        {
         yazici.WriteLine(string.Join(",", satir.SubItems.Cast<ListViewItem.ListViewSubItem>().Select(altSutun => altSutun.Text)));
         }
         }

         MessageBox.Show("Veriler başarıyla TXT olarak dışa aktarıldı.");
         }
         catch (Exception ex)
         {
         MessageBox.Show("TXT dosyası oluşturulurken bir hata oluştu: " + ex.Message);
         }
        }

        private void CSVAktarma(string dosyaAdi)
        {
          
            string yol = Path.Combine(dosyaAdi);

            try
            {
                
                using (StreamWriter yazici = new StreamWriter(yol))
                {
                    
                    yazici.WriteLine(string.Join(",", listView1.Columns.Cast<ColumnHeader>().Select(sutun => sutun.Text)));

                    
                    foreach (ListViewItem satir in listView1.Items)
                    {
                        yazici.WriteLine(string.Join(",", satir.SubItems.Cast<ListViewItem.ListViewSubItem>().Select(altSutun => altSutun.Text)));
                    }
                }

                MessageBox.Show("Veriler başarıyla CSV olarak dışa aktarıldı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("CSV dosyası oluşturulurken bir hata oluştu: " + ex.Message);
            }
        }


        private void HTMLAktarma(string dosyaAdi)
        {
        string yol = Path.Combine(dosyaAdi);

         try
         {
                
         using (StreamWriter yazici = new StreamWriter(yol))
         {
                   
                    yazici.WriteLine("<html>");
                    yazici.WriteLine("<head><title>ListView Verileri</title></head>");
                    yazici.WriteLine("<body>");
                    yazici.WriteLine("<table border=\"1\">");

                    
                    yazici.WriteLine("<tr>");
                    foreach (ColumnHeader sutun in listView1.Columns)
                    {
                        yazici.WriteLine($"<th>{sutun.Text}</th>");
                    }
                    yazici.WriteLine("</tr>");

                    foreach (ListViewItem satir in listView1.Items)
                    {
                    yazici.WriteLine("<tr>");
                     foreach (ListViewItem.ListViewSubItem altSutun in satir.SubItems)
                      {
                            yazici.WriteLine($"<td>{altSutun.Text}</td>");
                      }
                        yazici.WriteLine("</tr>");
                    }

                    
                yazici.WriteLine("</table>");
                 yazici.WriteLine("</body>");
                  yazici.WriteLine("</html>");
                }

                MessageBox.Show("Veriler başarıyla HTML olarak dışa aktarıldı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HTML dosyası oluşturulurken bir hata oluştu: " + ex.Message);
            }
        }
    }




    }

