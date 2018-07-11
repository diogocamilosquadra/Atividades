using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NHibernateTutorialPart1;

namespace NHibernateTutorialPart1
{
    public partial class Form1 : Form
    {
        private Configuration myConfiguration;
        private ISessionFactory mySessionFactory;
        private ISession mySession;
   

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Declara as variaveis do Nhibernate
            myConfiguration = new Configuration();
            myConfiguration.Configure();
            mySessionFactory = myConfiguration.BuildSessionFactory();
            mySession = mySessionFactory.OpenSession();

            //  Salva os itens
            using (mySession.BeginTransaction())
            {
                Contact loContact = new Contact();
                loContact.ID = int.Parse(txtID.Text);
                loContact.FirstName = txtFirstName.Text;
                loContact.LastName = txtLastName.Text;
                mySession.Save(loContact);

                mySession.Transaction.Commit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declara as variaveis do Nhibernate
            myConfiguration = new Configuration();
            myConfiguration.Configure();
            mySessionFactory = myConfiguration.BuildSessionFactory();
            mySession = mySessionFactory.OpenSession();

            //Deleta de acordo com a sintaxe
            using (mySession.BeginTransaction())
            {
                Contact loContact = new Contact();
                loContact.FirstName = txtFirstName.Text;
                loContact.LastName = txtLastName.Text;
                mySession.Delete("from Contact where FirstName='"+loContact.FirstName+"'" +
                "and LastName='"+loContact.LastName+"';");

                mySession.Transaction.Commit();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //Declara as variaveis do Nhibernate
            myConfiguration = new Configuration();
            myConfiguration.Configure();
            mySessionFactory = myConfiguration.BuildSessionFactory();
            mySession = mySessionFactory.OpenSession();

            //Lista todos os itens da classe Contact
            using (mySession.BeginTransaction())
            {

                ICriteria criteria = mySession.CreateCriteria<Contact>();
                IList<Contact> list = criteria.List<Contact>();
                
                foreach (Contact pessoa in list)
                { 
                    MessageBox.Show(" ID da pessoa: " + pessoa.ID +
                                    " \nPrimeiro nome da pessoa: " + pessoa.FirstName +
                                    " \nSegundo  nome da pessoa: " + pessoa.LastName
                                    );
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Declara as variaveis do Nhibernate
            myConfiguration = new Configuration();
            myConfiguration.Configure();
            mySessionFactory = myConfiguration.BuildSessionFactory();
            mySession = mySessionFactory.OpenSession();

            //Atualiza um cadastro
            using (mySession.BeginTransaction())
            {

                Contact loContact = new Contact();

                loContact.ID = int.Parse(txtID.Text);
                loContact.FirstName = txtFirstName.Text;
                loContact.LastName = txtLastName.Text;

                mySession.SaveOrUpdate(loContact);
                mySession.Transaction.Commit();
            }

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

