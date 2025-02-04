 
 
using DevExpress.XtraGrid.Views.Grid;
using Dapper;
using System.Data;
 

namespace Tinthanh.App.General
{
    public partial class frmTim : DevExpress.XtraEditors.XtraForm
    {


        public string Ma = "";
        public string Ten = "";
        public int Id = 0;
        private string _Tenbang = "";
        private int _loai = 1;
        public frmTim(string Tenbang, int Loai)
        {
            InitializeComponent();
            txtTen.KeyDown += TxtTen_KeyDown;
            gridView1.KeyDown += GridView1_KeyDown;
            SetDataSource(Tenbang, Loai);
            _Tenbang = Tenbang;
            _loai = Loai;
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
            if (e.KeyCode == Keys.Enter)
            {

                SetDataSource(_Tenbang, 2,txtTen.Text);

                gridControl1.Focus();
                if (gridView1.RowCount > 0)
                {
                    gridView1.FocusedRowHandle = 0;
                    gridView1_FocusedRowChanged(null, null);
                }
                e.SuppressKeyPress = true;
                
            }
        }

        public void SetDataSource(string Tenbang, int Somautin,string filter="")
        {

            Cursor.Current = Cursors.WaitCursor;
            string Ten = "pr_Timdanhsach";
            DynamicParameters para = new DynamicParameters();
            para.Add("@Tenbang", Tenbang, DbType.String, ParameterDirection.Input);
            para.Add("@Somautin", Somautin, DbType.Int32, ParameterDirection.Input);
            para.Add("@Ten", filter, DbType.String, ParameterDirection.Input);
            gridControl1.DataSource = SQLHelper.ExecProcedureDataAsDataTable(Ten, para);

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
                Ma = view.GetRowCellValue(view.FocusedRowHandle, colMa).ToString();
                Ten = view.GetRowCellValue(view.FocusedRowHandle, colTen).ToString();
                Id = (Int32)view.GetRowCellValue(view.FocusedRowHandle, "Id");
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
    }
}