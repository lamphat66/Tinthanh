

using DevExpress.XtraGrid.Views.Grid;
using Dapper;
using System.Data;

namespace Tinthanh.App.General
{
    public partial class frmTimSQL : DevExpress.XtraEditors.XtraForm
    {


        public string Ma = "";
        public string Ten = "";
        public string Donvi = "";

        public frmTimSQL(string SQL)
        {
            InitializeComponent();

            gridView1.KeyDown += GridView1_KeyDown;

            SetDataSource(SQL);

            this.KeyPreview = true;

        }

        private void GridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
                e.SuppressKeyPress = true;
            }
        }

        private void TxtTen_KeyDown(object sender, KeyEventArgs e)
        {

        }

        public void SetDataSource(string SQL)
        {

            Cursor.Current = Cursors.WaitCursor;

            gridControl1.DataSource = SQLHelper.ExecQueryDataAsDataTable(SQL);

            Cursor.Current = Cursors.Default;

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView view = gridView1;
            if (view.RowCount > 0)
            {
                Ma = view.GetRowCellValue(view.FocusedRowHandle, "Ma").ToString();
                Ten = view.GetRowCellValue(view.FocusedRowHandle, "Ten").ToString();
                Donvi = view.GetRowCellValue(view.FocusedRowHandle, "Donvi").ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void frmTimSQL_Load(object sender, EventArgs e)
        {
            gridView1.BestFitColumns();
        }
    }
}