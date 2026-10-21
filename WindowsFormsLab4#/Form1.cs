using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsLab4_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        // объявление массива массивов (максимально сто записей)
        private const int MaxRecords = 100;
        private object[][] records = new object[MaxRecords][];
        private int count = 0;


        // метод для добавления новой записи
        private void AddRecord(object[] record)
        {
            if (count >= MaxRecords)
            {
                MessageBox.Show("Достигнут лимит записей.");
                return;
            }

            records[count] = record;
            count++;

            // добавление записи массива в виде строки в листбокс
            string line = "";
            for (int i = 0; i < record.Length; i++)
            {
                line += record[i];
                if (i < record.Length - 1)
                    line += "; ";
            }
            listBox1.Items.Add(line);
        }


                                                    // человек
        // метод на проверку корректности имени (и  марки автомобиля)
        private bool IsValidName(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return false;

            foreach (char c in s)
            {
                if (!char.IsLetter(c) && c != ' ' && c != '-')
                    return false;
            }
            return true;
        }

        // кнопка добавить человека
        private void buttonHuman_Add_Click(object sender, EventArgs e)
        {
            //ввод и проверка имени
            string name = textBoxName.Text;

            if (!IsValidName(name))
            {
                textBoxName.Focus();
                MessageBox.Show(
                    "Имя должно содержать только буквы, пробел или дефис.\n" +
                    "Цифры и другие символы запрещены.",
                    "Ошибка в поле «Имя»",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int age;
            float height;
            float weight;

            // ввод и проверка возраста
            try
            {
                age = int.Parse(textBoxAge.Text);
                if (age <= 0)
                {
                    textBoxAge.Focus();
                    throw new Exception("Возраст должен быть больше 0.");
                }
            }
            catch (FormatException)
            {
                textBoxAge.Focus();
                textBoxAge.SelectAll();
                MessageBox.Show("Возраст должен быть числом.", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ввод и проверка роста
            try
            {
                height = float.Parse(textBoxHight.Text);
                if (height <= 0)
                {
                    textBoxHight.Focus();
                    throw new Exception("Рост должен быть больше 0.");
                }
            }
            catch (FormatException)
            {
                textBoxHight.Focus();
                textBoxHight.SelectAll();
                MessageBox.Show("Рост должен быть числом.", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ввод и проверка веса
            try
            {
                weight = float.Parse(textBoxWeight.Text);
                if (weight <= 0)
                {
                    textBoxWeight.Focus();
                    throw new Exception("Вес должен быть больше 0.");
                }
            }
            catch (FormatException)
            {
                textBoxWeight.Focus();
                textBoxWeight.SelectAll();
                MessageBox.Show("Вес должен быть числом.", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // проверка выбора пола
            if (comboBox1.SelectedItem == null)
            {
                comboBox1.Focus();
                MessageBox.Show(
                    "Выберите пол из списка.",
                    "Ошибка в поле «Пол»",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sex = comboBox1.SelectedItem.ToString();

            //добавление записи в массив массивов
            object[] record = new object[]
                {
                    "Человек",                  
                    name,
                    age,                     
                    sex,
                    height,                     
                    weight                      
                };

            AddRecord(record);
        }

        // кнопка очистить для человека
        private void buttonHuman_Clear_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxAge.Clear();
            textBoxWeight.Clear();
            textBoxHight.Clear();
            comboBox1.SelectedIndex = -1;
        }

                                                  //машина
        // проверка на корректность номера
        private bool IsValidCarNumber(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return false;
            if (s.Length < 4 || s.Length > 12) return false;

            foreach (char c in s)
            {
                if (!char.IsLetterOrDigit(c) && c != ' ' && c != '-')
                    return false;
            }
            return true;
        }

        //кнопка добавить для машины
        private void buttonCar_Add_Click(object sender, EventArgs e)
        {

            // ввод и проверка марки
            string brand = textBoxBrand.Text.Trim();

            if (!IsValidName(brand))
            {
                textBoxBrand.Focus();
                MessageBox.Show(
                    "Марка должна содержать только буквы, пробел или дефис.\n" +
                    "Цифры и другие символы запрещены.",
                    "Ошибка в поле «Марка»",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // ввод и проверка номера
            string number = textBoxNumber.Text;

            if (!IsValidCarNumber(number))
            {
                textBoxNumber.Focus();
                textBoxNumber.SelectAll();
                MessageBox.Show(
                    "Номер должен содержать только буквы и цифры (например, А123ВС36).\n" +
                    "Длина — от 4 до 12 символов.",
                    "Ошибка в поле «Номер»",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // ввод и проверка года
            int year;

            try
            {
                year = int.Parse(textBoxYear.Text);
                if (year <= 0)
                {
                    textBoxYear.Focus();
                    throw new Exception("Год должен быть больше 0.");
                }
            }
            catch (FormatException)
            {
                textBoxYear.Focus();
                textBoxYear.SelectAll();
                MessageBox.Show("Год должен быть целым числом.", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ввод и проверка объема двигателя
            float engine;

            try
            {
                engine = float.Parse(textBoxEngine.Text);
                if (engine <= 0)
                {
                    textBoxEngine.Focus();
                    throw new Exception("Объём двигателя должен быть больше 0.");
                }
            }
            catch (FormatException)
            {
                textBoxEngine.Focus();
                textBoxEngine.SelectAll();
                MessageBox.Show("Объём двигателя должен быть числом.", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // добавление записи в массив массивов
            object[] record = new object[]
                {
                    "Автомобиль",
                    brand,
                    number,
                    year,
                    engine
                };

            AddRecord(record);
        }

        //кнопка очистить для человека
        private void buttonCar_Clear_Click(object sender, EventArgs e)
        {
            textBoxBrand.Clear();
            textBoxNumber.Clear();
            textBoxYear.Clear();
            textBoxEngine.Clear();
        }

                                                     // админимтративное здание
        // кнопка добавить для здания
        private void buttonBuilding_Add_Click(object sender, EventArgs e)
        {
            //ввод и проверка адреса
            string address = textBoxAddress.Text;

            if (string.IsNullOrWhiteSpace(address))
            {
                textBoxAddress.Focus();
                MessageBox.Show(
                    "Введите адрес здания.",
                    "Ошибка в поле «Адрес»",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //ввод и проверка площади
            float area;

            try
            {
                area = float.Parse(textBoxArea.Text);
                if (area <= 0)
                {
                    textBoxArea.Focus();
                    throw new Exception("Площадь должна быть больше 0.");
                }
            }
            catch (FormatException)
            {
                textBoxArea.Focus();
                textBoxArea.SelectAll();
                MessageBox.Show("Площадь должна быть числом.", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //добавление записи в массив массивов
            object[] record = new object[]
                {
                    "Здание",
                    address,
                    area
                };

            AddRecord(record);
        }

        // кнопка очистить для здания
        private void buttonBuilding_Clear_Click(object sender, EventArgs e)
        {
            textBoxAddress.Clear();
            textBoxArea.Clear();
        }

        //кнопка показать все имеющиеся записи
        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            if (count == 0)
                listBox1.Items.Add("Пока нет записей.");
            else
            {
                for (int record = 0; record < count; record++)
                {
                    string line = "";
                    for (int i = 0; i < records[record].Length; i++)
                    {
                        line += records[record][i];
                        if (i < records[record].Length - 1)
                            line += "; ";
                    }
                    listBox1.Items.Add(line);
                }
            }
        }

        //кнопка для очитски листбокса
        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
