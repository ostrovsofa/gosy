using System.IO;
using System.Xml;
using System.Xml.Serialization;
using static System.Net.WebRequestMethods;

namespace gosy_tp
{
    public partial class FormMain : Form
    {
        List<Film> films = new List<Film>();

        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            loadFromFile("test.txt");
        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            saveToFile("test.txt");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            films.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            films.Add(new Film() { Id = 1, Title = "Фильм1", Director = "Эгов", Year = 2020, Time = 120 });
            films.Add(new Film() { Id = 2, Title = "Фильм2", Director = "Андреев", Year = 2021, Time = 110 });
            films.Add(new Film() { Id = 3, Title = "Фильм3", Director = "Скалкин", Year = 2021, Time = 90 });
            films.Add(new Film() { Id = 4, Title = "Фильм4", Director = "Строева", Year = 2023, Time = 235 });
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = films;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getFilmByDirector(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getFilmWithLongTime(Convert.ToInt32(textBox2.Text));
        }

        public void getFilmByDirector(string Director)
        {
            List<Film> res = (from f in films where f.Director == Director select f).ToList();
            dataGridView1.DataSource = res;
        }

        public void getFilmWithLongTime(int Year)
        {
            //List<Film> res = films.Where(p => p.Year == Year).OrderByDescending(p => p.Time).ToList();
            Film res = films.OrderByDescending(p => p.Time).FirstOrDefault(p => p.Year == Year);
            List<Film> f = new List<Film>();
            f.Add(res);
            dataGridView1.DataSource = f;

            //
            //Film res = films.OrderByDescending(p => p.Time).FirstOrDefault(p => p.Year == Year);
            //MessageBox.Show("Самый продолжительный фильм за " + Convert.ToString(Year) + " год - " + res.Title);
        }

        private void saveToFile(string path)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Film>));
            using (Stream fStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                xmlFormat.Serialize(fStream, films);
            }
        }

        private void loadFromFile(string path)
        {
            dataGridView1.Columns.Clear();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Film>));
            using (Stream fStream = new FileStream(path, FileMode.Open))
            {
                using (XmlReader reader = XmlReader.Create(fStream))
                {
                    var buffFilms = (List<Film>)serializer.Deserialize(reader);
                    if (buffFilms != null)
                    {
                        films = buffFilms;
                        dataGridView1.DataSource = films;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка при загрузке");
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveToFile("test.txt");
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            loadFromFile("test.txt");
        }

    }
}
