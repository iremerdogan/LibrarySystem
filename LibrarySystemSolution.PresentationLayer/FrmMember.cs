using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarySystemSolution.BusinessLayer.Abstract;
using LibrarySystemSolution.BusinessLayer.Concrete;
using LibrarySystemSolution.DataAccessLayer.EntityFramework;
using LibrarySystemSolution.EntityLayer.Concrete;

namespace LibrarySystemSolution.PresentationLayer
{
    public partial class FrmMemberShip : Form
    {
        private readonly IMemberService _memberService;

        public FrmMemberShip()
        {
            _memberService = new MemberManager(new EFMemberDal());
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = _memberService.TGetAll();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.FirstName = txtMemberFirstName.Text;
            member.LastName = txtMemberLastName.Text;
            member.Address = txtMemberAddress.Text;
            member.Phone_Number = int.Parse(txtPhoneNumber.ToString());
            member.Limit = int.Parse(txtLimit.Text);
            _memberService.TAdd(member);
            MessageBox.Show("New member is added successfully.", "Message", MessageBoxButtons.OK);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMemberId.Text);
            var values = _memberService.TGetById(id);
            _memberService.TRemove(values);
            MessageBox.Show("Member is removed successfully", "Message", MessageBoxButtons.OK);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMemberId.Text);
            var updateValue = _memberService.TGetById(id);
            updateValue.FirstName = txtMemberFirstName.Text;
            updateValue.LastName = txtMemberLastName.Text;
            updateValue.Address = txtMemberAddress.Text;
            updateValue.Phone_Number = int.Parse(txtPhoneNumber.Text);
            updateValue.Limit = int.Parse(txtLimit.Text);
            _memberService.TUpdate(updateValue);
            MessageBox.Show("Member information is updated successfully.", "Message", MessageBoxButtons.OK);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMemberId.Text);
            var findItem = _memberService.TGetById(id);

            dataGridView1.DataSource = new List<Member> { findItem };
        }
    }
}
