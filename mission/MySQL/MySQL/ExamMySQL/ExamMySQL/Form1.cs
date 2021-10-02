using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExamMySQL
{
    public partial class Form1 : Form
    {
        string _server = "localhost"; //DB서버 주소, 로컬인 경우 localhost
        int _port = 3306; //DB 서버 포트
        string _database = "Mission"; //DB 이름
        string _id = "root"; //계정 아이디
        string _pw = "root"; //계정 비밀번호
        string _connectionAddress = "";

        public Form1()
        {
            InitializeComponent();
            //MySQL 연결을 위한 주소 형식
            _connectionAddress = string.Format("Server={0};port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
