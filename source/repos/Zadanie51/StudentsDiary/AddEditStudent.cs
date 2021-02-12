using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsDiary
{
    public partial class AddEditStudent : Form
    {
        public bool _zajDodatkowe; // Pkt.1. zadania
        public int _studentId;
        private Student _student;   // pole przechowyjące informacje o uczniu w całej klasie
        
        private FileHelper<List<Student>> _fileHelper =
            new FileHelper<List<Student>>(Program.FilePath);

        public AddEditStudent(int id = 0)
        {
            InitializeComponent();
            _studentId = id;

            GetStudentData();
        }

        private void GetStudentData()
        {
            var students = _fileHelper.DeserializeFromFile();
           
            if (_studentId != 0)
            {
                Text = "Edytowanie danych ucznia";

                _student = students.FirstOrDefault(x => x.Id == _studentId);
                    if (_student == null)
                    throw new Exception("Brak użytkownika o podanym Id");
                
                FillTextBoxes();
            }

            var itemsKlasa = students.Select(x => x.Klasa).Distinct().ToList();
            cmbKlasa.Items.Add("Brak");

            cmbKlasa.DataSource = itemsKlasa;
            cmbKlasa.DisplayMember = "Klasa";

        }

        private void FillTextBoxes()
        {
            tbId.Text = _student.Id.ToString();
            cmbKlasa.Text = _student.Klasa;                     //pkt.2. zadania
            tbFirstName.Text = _student.FirstName;
            tbLastName.Text = _student.LastName;
            tbMath.Text = _student.Math;
            tbPhysics.Text = _student.Physics;
            tbTechnology.Text = _student.Technology;
            tbPolishLang.Text = _student.PolishLang;
            tbForeignLang.Text = _student.ForeignLang;
            rtbComments.Text = _student.Comments;
            chboxZajDodatkowe.Checked = _student.ZajDodatkowe;  // pkt.1. zadania
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var students = _fileHelper.DeserializeFromFile();
            
            if (_studentId != 0)
                students.RemoveAll(x => x.Id == _studentId);
            else
                AssignIdToNewStudent(students);
      
            AddNewUserToList(students);

            _fileHelper.SerializeToFile(students);
            Close();
        }

        private void AddNewUserToList(List<Student> students)
        {
            var student = new Student
            {
                Id = _studentId,
                Klasa = cmbKlasa.Text,                           // pkt.2. zadania    
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                Comments = rtbComments.Text,
                ForeignLang = tbForeignLang.Text,
                Math = tbMath.Text,
                Physics = tbPhysics.Text,
                PolishLang = tbPolishLang.Text,
                Technology = tbTechnology.Text,
                ZajDodatkowe = chboxZajDodatkowe.Checked          //pkt.1.Zadania
            };
            students.Add(student);
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AssignIdToNewStudent(List<Student> students) 
        {
            var studentWithHighestId = students
                    .OrderByDescending(x => x.Id).FirstOrDefault();

            _studentId = studentWithHighestId == null ?
                1 : studentWithHighestId.Id + 1;
        }

    }
}
