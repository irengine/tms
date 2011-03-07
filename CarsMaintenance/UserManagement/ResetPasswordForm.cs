using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CarsMaintenance.Common;
using CarsMaintenance.Common.Validation;
using TMS.Model;

namespace CarsMaintenance.UserManagement
{
    public partial class ResetPasswordForm : BaseForm
    {
        public SystemUser CurrentSystemUser { get; set; }

        public ResetPasswordForm()
        {
            InitializeComponent();
            RegisterControlsForValidation();
        }

        private ValidationManager _validationManager;

        private void RegisterControlsForValidation()
        {
            _validationManager = new ValidationManager()
            {
                Provider = _errorProvider
            };
            _validationManager.Validators.Add(new RequiredValidator()
            {
                Control = txtPassword,
                ErrorMessage = string.Format(CarsMaintenance.Properties.Resources.RequiredErrorMessage, lblPassword.Text)
            });
            _validationManager.Validators.Add(new RequiredValidator()
            {
                Control = txtPassword2,
                ErrorMessage = string.Format(CarsMaintenance.Properties.Resources.RequiredErrorMessage, lblPassword2.Text)
            });
        }

        private void LoadData()
        {
            CurrentSystemUser = SystemHelper.CurrentUser;

            txtCode.Text = CurrentSystemUser.Code;
            txtName.Text = CurrentSystemUser.Name;
            txtPassword.Text = CurrentSystemUser.Password;
            txtPassword2.Text = CurrentSystemUser.Password;
        }

        private void ResetPasswordForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void _saveButton_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(delegate()
            {
                if (!_validationManager.Validate())
                {
                    return;
                }

                if (!txtPassword.Text.Equals(txtPassword2.Text))
                {
                    _errorProvider.SetError(txtPassword2, "密码不一致!");
                    return;
                }
                
                CurrentSystemUser.Password = txtPassword.Text;

                SystemHelper.TMSContext.SaveChanges();

                DialogResult = DialogResult.OK;
            });
        }
    }
}
