using DevExpress.XtraEditors;
using Dapper;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;


 
namespace Tinthanh.App.Tiepnhan
{
    public partial class frmNhatkyPhieutiepnhan : XtraForm
    {

        public frmNhatkyPhieutiepnhan()
        {

            InitializeComponent();
            Initialize();
            Load += delegate { LoadData(); };
            btnXem.ItemClick += delegate { LoadData(); };

        }

        public Dictionary<int, string> Trangthai()
        {
            Dictionary<int, string> dc = new Dictionary<int, string>();
            dc.Add(1, "Nhận yêu cầu");
            dc.Add(2, "Chờ xử lý");
            dc.Add(3, "Có kết quả xử lý");
            dc.Add(4, "Đã lập báo giá");
            dc.Add(5, "Hủy");
            return dc;

        }
        void Initialize()
        {
            lkTrangthai.DataSource = new BindingSource(Trangthai(), null);
            lkTrangthai.DisplayMember = "Value";
            lkTrangthai.ValueMember = "Key";
            lkTrangthai.BestFit();

            var fluent = mvvmContext1.OfType<ViewModel.Xulyngaythang1>();
            fluent.WithEvent(rdChon, "EditValueChanged")
                .EventToCommand(x => x.Change);


            fluent.WithEvent(spThang, "EditValueChanged")
                .EventToCommand(x => x.Change);

            fluent.WithEvent(spQuy, "EditValueChanged")
                .EventToCommand(x => x.Change);

            fluent.WithEvent(spNam, "EditValueChanged")
                .EventToCommand(x => x.Change);
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

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            GridView view = gridView1;
            int bookmark = view.FocusedRowHandle;
            var m = view.GetRowCellValue(view.FocusedRowHandle, "Id");

            if (m == null) return;
            using (frmPhieuyeucau frm = new frmPhieuyeucau(Convert.ToInt32(m)))
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
            using (frmPhieuyeucau frm = new frmPhieuyeucau(0))
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

        public DataTable Nhatkychungtu(DateTime Tungay, DateTime Denngay)
        {
            string Ten = "pr_Nhatkyphieuyeucau";

            DynamicParameters para = new DynamicParameters();
            para.Add("@Tungay", Tungay, DbType.DateTime, ParameterDirection.Input);
            para.Add("@Denngay", Denngay, DbType.DateTime, ParameterDirection.Input);
            return Tinthanh.ViewModel.SQLHelper.ExecProcedureDataAsDataTable(Ten, para);
        }
    }
}