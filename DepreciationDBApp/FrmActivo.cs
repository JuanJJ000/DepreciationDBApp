using DepreciationDBApp.Applications.Interfaces;
using DepreciationDBApp.Domain.Entities;
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
    public partial class FrmActivo : Form
    {



        private IAssetService assetService;
        private IEmployeeService employeeService;


        public FrmActivo(IAssetService assetService, IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
            this.assetService = assetService;
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Asset asset = new Asset()
            {
                Name = txtNombre.Text,
                Description = txtDescription.Text,
                Amount = nudMonto.Value,
                AmountResidual = nudResidual.Value,
                Terms = (int)nudVidaUtil.Value,
                Code = Guid.NewGuid().ToString(),
                Status = "Disponible",
                IsActive = true
            };

            assetService.Create(asset);
            LoadDataGridView();
        }

        private void FrmActivo_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            dgvAsset.DataSource = assetService.GetAll();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
        







        }
    }
}
