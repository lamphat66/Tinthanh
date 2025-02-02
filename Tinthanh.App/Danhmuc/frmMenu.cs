using DevExpress.XtraTreeList;

using Tinthanh.App.General;
using Tinthanh.Data.Entities;

namespace Tinthanh.App.Danhmuc
{
    public partial class frmMenu : DevExpress.XtraEditors.XtraForm
    {

        int SelectedId = 0;
        
        public frmMenu()
        {
            InitializeComponent();
            Load += delegate { Loaddata(); };
            barEdit.ItemClick += BarEdit_ItemClick;
            barAdd.ItemClick += BarAdd_ItemClick;
            barAddChild.ItemClick += BarAddChild_ItemClick;
        }

         

        private void Loaddata()
        {
            bdSource.ResetBindings(false);
            bdSource.DataSource = SQLHelper.ExecQueryData<Chucnang>("Select * from Chucnang");
        }

   
        private void tlHethong_CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e)
        {
            // Kiểm tra nếu cột Isbold có giá trị true
            if (e.Node.GetValue("IsCaption") != null && (bool)e.Node.GetValue("IsCaption") == true)
            {
                // Tô đậm phông chữ cho toàn bộ các field trong dòng hiện tại
                e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
            }
        }

        private void frmMenu_Load(object sender, System.EventArgs e)
        {
            this.BeginInvoke(new Action(() => { tlHethong.ExpandAll(); }));
        }

        private void tlHethong_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Tính toán vị trí nhấp chuột trong TreeList
                TreeListHitInfo hitInfo = tlHethong.CalcHitInfo(e.Location);
                if (hitInfo.Node != null)
                {
                    // Đặt Node được chọn
                    tlHethong.FocusedNode = hitInfo.Node;

                    // Lấy giá trị của trường "Ma" từ Node hiện tại
                    SelectedId = (int)hitInfo.Node.GetValue("Ma");
                    // Hiển thị PopupMenu tại vị trí nhấp chuột
                    popupMenu.ShowPopup(tlHethong.PointToScreen(e.Location));

                }

            }

        }

        private void BarEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEditMenu f = new frmEditMenu(SelectedId, false, false);
            if (f.ShowDialog() == DialogResult.OK) Loaddata();
        }

        private void BarAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEditMenu f = new frmEditMenu(SelectedId, true, false);
            if (f.ShowDialog() == DialogResult.OK) Loaddata();

        }

        private void BarAddChild_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEditMenu f = new frmEditMenu(SelectedId, true, true);
            if (f.ShowDialog() == DialogResult.OK) Loaddata();

        }
    }
}