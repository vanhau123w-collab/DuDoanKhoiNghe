using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuDoanKhoiNghe
{
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnDuDoan_Click(object sender, EventArgs e)
    {
        List<string> MonChon = new List<string>();
        if (cbToan.Checked) MonChon.Add("Toán");
        if (cbLy.Checked) MonChon.Add("Lý");
        if (cbHoa.Checked) MonChon.Add("Hóa");
        if (cbSinh.Checked) MonChon.Add("Sinh");
        if (cbVan.Checked) MonChon.Add("Văn");
        if (cbSu.Checked) MonChon.Add("Sử");
        if (cbDia.Checked) MonChon.Add("Địa");
        if (cbGDCD.Checked) MonChon.Add("GDCD");
        if (cbVe1.Checked) MonChon.Add("Vẽ 1");
        if (cbVe2.Checked) MonChon.Add("Vẽ 2");
        if (cbNangKhieu.Checked) MonChon.Add("Năng khiếu");
        if (cbAnh.Checked) MonChon.Add("Anh");

            List<List<string>> khoiA = new List<List<string>>
{
    new List<string> { "Toán", "Lý", "Hóa" },
    new List<string> { "Toán", "Lý", "Anh" },
    new List<string> { "Toán", "Hóa", "Anh" }
};
        List<List<string>> khoiB = new List<List<string>>
{
    new List<string> { "Toán", "Hóa", "Sinh" },
    new List<string> { "Toán", "Sinh", "Lí" },
};
        List<List<string>> khoiC = new List<List<string>>
{
    new List<string> { "Văn", "Sử", "Địa" },
    new List<string> { "Văn", "Sử", "Anh" },
    new List<string> { "Văn", "Địa", "Anh" }
};
        List<List<string>> khoiD = new List<List<string>>
{
    new List<string> { "Toán", "Văn", "Anh"},
    new List<string> { "Toán","Hóa", "Anh" },
    new List<string> { "Toán","Sinh", "Anh" },
};
        List<List<string>> khoiH = new List<List<string>>
{
        new List<string> { "Toán", "Văn", "Vẽ 1" }
};
        List<List<string>> khoiR = new List<List<string>>
{
    new List<string> { "Toán", "Văn", "Vẽ 2" }
};
        List<List<string>> khoiV = new List<List<string>>
{
    new List<string> { "Toán", "Văn", "Năng khiếu" }
};
        bool trungKhopA = khoiA.Any(tohop => tohop.Count == MonChon.Count && !tohop.Except(MonChon).Any());
        bool trungKhopB = khoiB.Any(tohop => tohop.Count == MonChon.Count && !tohop.Except(MonChon).Any());
        bool trungKhopC = khoiC.Any(tohop => tohop.Count == MonChon.Count && !tohop.Except(MonChon).Any());
        bool trungKhopD = khoiD.Any(tohop => tohop.Count == MonChon.Count && !tohop.Except(MonChon).Any());
        bool trungKhopH = khoiH.Any(tohop => tohop.Count == MonChon.Count && !tohop.Except(MonChon).Any());
        bool trungKhopR = khoiR.Any(tohop => tohop.Count == MonChon.Count && !tohop.Except(MonChon).Any());
        bool trungKhopV = khoiV.Any(tohop => tohop.Count == MonChon.Count && !tohop.Except(MonChon).Any());

        if (trungKhopA)
        {
            this.Hide();
            FormKhoiA frm = new FormKhoiA();
            frm.ShowDialog();
            this.Show();
            }
        else if (trungKhopB)
        {
            this.Hide();
            FormKhoiB frm = new FormKhoiB();
            frm.ShowDialog();
            this.Show();
            }
        else if (trungKhopC)
        {
            this.Hide();
            FormKhoiC frm = new FormKhoiC();
            frm.ShowDialog();
            this.Show();
            }
        else if (trungKhopD)
        {
            this.Hide();
            FormKhoiD frm = new FormKhoiD();
            frm.ShowDialog();
                this.Show();
            }
        else if (trungKhopH)
        {
            this.Hide();
            FormKhoiH frm = new FormKhoiH();
            frm.ShowDialog();
                this.Show();
            }
        else if (trungKhopR)
        {
            this.Hide();
            FormKhoiR frm = new FormKhoiR();
            frm.ShowDialog();
                this.Show();
            }
        else if (trungKhopV)
        {
            this.Hide();
            FormKhoiV frm = new FormKhoiV();
            frm.ShowDialog();
                this.Show();
            }
        else
        {
            this.Hide();
            FormError frm = new FormError();
            frm.ShowDialog();
                this.Show();
            }

    }
}
}
