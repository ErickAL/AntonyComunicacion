using AntonyCelulares.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AntonyCelulares.Views.Account
{
    public partial class LoginPage : Form, ILogin
    {

        #region Properties
        public string Username
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = value; }
        }
        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }
        public bool RememberMe
        {
            get { return cbRememberMe.Checked; }
            set { cbRememberMe.Checked = value; }
        }
        #endregion

        #region Contuctors
        public LoginPage()
        {
            InitializeComponent();
        }
        #endregion
       

        #region Methods

        #endregion


    }
}
