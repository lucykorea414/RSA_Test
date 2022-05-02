using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Security.Cryptography;
using System.Xml.Serialization;
using System.IO;
using System.Threading;
using System.Collections;

namespace RSA_Test
{
    public partial class Form1 : Form
    {

        public static RSACryptoServiceProvider csp = new RSACryptoServiceProvider(2400);
        public RSAParameters prK;
        public RSAParameters puK;

        public Form1()
        {
            InitializeComponent();

            prK = csp.ExportParameters(true);
            puK = csp.ExportParameters(false);
        }

        public string Encrypt(string plainText)
        {
            csp = new RSACryptoServiceProvider();

            var puKey = new StringReader(pubKeyTxt.Text);
            var xs = new XmlSerializer(typeof(RSAParameters));
            csp.ImportParameters((RSAParameters)xs.Deserialize(puKey));

            var data = Encoding.Unicode.GetBytes(plainText);
            var cypher = csp.Encrypt(data, false);

            return Convert.ToBase64String(cypher);
        }

        public string Decrypt(string cypherText)
        {
            var dataBytes = Convert.FromBase64String(cypherText);
            csp.ImportParameters(prK);
            var plainText = csp.Decrypt(dataBytes, false);
            return Encoding.Unicode.GetString(plainText);
        }

        private void keyGenerateBtn_Click(object sender, EventArgs e)
        {
            csp.PersistKeyInCsp = true;

            var sw = new StringWriter();
            var xs = new XmlSerializer(typeof(RSAParameters));

            xs.Serialize(sw, puK);
            pubKeyTxt.Text = sw.ToString();

            xs.Serialize(sw, prK);
            priKeyTxt.Text = sw.ToString();
        }

        private void EncBtn_Click(object sender, EventArgs e)
        {
            EncTxt.Text = Encrypt(PlnTxt.Text);
        }

        private void DecBtn_Click(object sender, EventArgs e)
        {
            DecTxt.Text = Decrypt(EncTxt.Text);
        }
    }
}
