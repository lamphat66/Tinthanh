using Dapper;
using DevExpress.XtraEditors;
 

using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using Tinthanh.App.General;


namespace Tinthanh.App.Tiepnhan
{
    public partial class frmNhatkyPhieuxuly : XtraForm
    {

        
        public frmNhatkyPhieuxuly()
        {

            InitializeComponent();

            lkTrangthai.DataSource = new BindingSource(Trangthai(), null);
            lkTrangthai.DisplayMember = "Value";
            lkTrangthai.ValueMember = "Key";
            lkTrangthai.BestFit();
            Load += delegate { LoadData(); };
            btnXem.ItemClick += delegate { LoadData(); };
        }

        public Dictionary<int, string> Trangthai()
        {
            Dictionary<int, string> dc = new Dictionary<int, string>();
            dc.Add(1, "Hiệu chỉnh");
            dc.Add(2, "Tạo phiếu định giá");
            dc.Add(3, "Tạo thông tin KHSP");
            dc.Add(4, "Hoàn thành");
            dc.Add(5, "Hủy");

            return dc;

        }
        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void LoadData()
        {
            DateTime Tungay = Convert.ToDateTime(dtTungay.EditValue);
            DateTime Denngay = Convert.ToDateTime(dtDenngay.EditValue);

            gridControl1.DataSource = Nhatkychungtu(Tungay, Denngay);
          

        }
        public DataTable Nhatkychungtu(DateTime Tungay, DateTime Denngay)
        {
            string Ten = "pr_NhatkyphieuYCXL";

            DynamicParameters para = new DynamicParameters();
            para.Add("@Tungay", Tungay, DbType.DateTime, ParameterDirection.Input);
            para.Add("@Denngay", Denngay, DbType.DateTime, ParameterDirection.Input);
            return SQLHelper.ExecProcedureDataAsDataTable(Ten, para);
        }


        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            GridView view = gridView1;
            int bookmark = view.FocusedRowHandle;
            var m = view.GetRowCellValue(view.FocusedRowHandle, "Id");
            if (m == null) return;
            using (frmPhieuxuly frm = new frmPhieuxuly(Convert.ToInt32(m)))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    LoadData();
                view.FocusedRowHandle = bookmark;
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (frmPhieuxuly frm = new frmPhieuxuly(0))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                    gridView1.MoveLast();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {


            btnEdit_ItemClick(sender, null);
        }


    }
}