using DepreciationDBApp.Applications.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepreciationDBApp.Forms
{
    public partial class FrmEmpleado : Form
    {
        private IAssetService assetService;
        private IEmployeeService employeeService;


        public FrmEmpleado(IAssetService assetService, IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
            this.assetService = assetService;
            InitializeComponent();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }


        private void LoadDataGridView()
        {
            dgvEmployee.DataSource = assetService.GetAll();
        }


    }
}
