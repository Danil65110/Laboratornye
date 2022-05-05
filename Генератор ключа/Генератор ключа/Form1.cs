using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Генератор_ключа
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string sKey;

        private void button2_Click(object sender, EventArgs e)
        {
            sKey = textBox1.Text;
            openFileDialog1.Filter = "des files |* .des";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) ;
            {
                string source = openFileDialog1.FileName;
                saveFileDialog1.Filter = "txt files |* .txt ";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) ;
                {
                    string destination = saveFileDialog1.FileName;
                    DecryptFile(source, destination, sKey);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sKey = textBox1.Text;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) ;
            {
                string source = openFileDialog1.FileName;
                saveFileDialog1.Filter = "des files |* .des ";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) ;
                {
                    string destination = saveFileDialog1.FileName;
                    EncryptFile(source, destination, sKey);
                }
            }

        }
        private void EncryptFile(string source, string destination, string sKey)
        {
            FileStream fsinput = new FileStream(source, FileMode.Open, FileAccess.Read);
            FileStream fsencrypt = new FileStream(destination, FileMode.Create, FileAccess.Write);
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            try
            {
                des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
                des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
                ICryptoTransform desencrypt = des.CreateEncryptor();
                CryptoStream cryptosream = new CryptoStream(fsencrypt, desencrypt, CryptoStreamMode.Write);
                byte[] bytearrayinput = new byte[fsinput.Length - 0];
                fsinput.Read(bytearrayinput, 0, bytearrayinput.Length);
                cryptosream.Write(bytearrayinput, 0, bytearrayinput.Length);
                cryptosream.Close();
            }
            catch
            {
                MessageBox.Show("Внимание", "Неверный ключ");
                return;
            }
            fsinput.Close();
            fsencrypt.Close();

        }
        private void DecryptFile(string source, string destination, string sKey)
        {
            FileStream fsinput = new FileStream(source, FileMode.Open, FileAccess.Read);
            FileStream fsencrypt = new FileStream(destination, FileMode.Create, FileAccess.Write);
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            try
            {
                des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
                des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
                ICryptoTransform desencrypt = des.CreateDecryptor();
                CryptoStream cryptosream = new CryptoStream(fsencrypt, desencrypt, CryptoStreamMode.Write);
                byte[] bytearrayinput = new byte[fsinput.Length - 0];
                fsinput.Read(bytearrayinput, 0, bytearrayinput.Length);
                cryptosream.Write(bytearrayinput, 0, bytearrayinput.Length);
                cryptosream.Close();
            }
            catch
            {
                MessageBox.Show("Внимание", "Неверный ключ");
                return;
            }
            fsinput.Close();
            fsencrypt.Close();
        }
    }
}
