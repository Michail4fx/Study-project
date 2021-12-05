using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Encryption__1._3__Anime_Edition
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
            N = characters.Length; // Length – нужное колличество символов используемых в алфавите (У меня 32 символа).
            textBoxCrypt.ReadOnly = true; // Блокируем взаимодействие с окном расшифрованного/зашифрованного текста.
            textBoxKeyWord.ContextMenu = new ContextMenu(); // Блокируем вызов контекстного меню правой кнопки.
            textBoxKeyWord.ShortcutsEnabled = false; // Блокируем вызов контекстного меню правой кнопки.
        }

        char[] characters = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' }; // Используемый алфавит в виде массива символов.
        private int N; // Длина используемого алфавита.

        private string Encode(string input, string keyword) // Процедура шифрования текста по методу Виженера.
        {
            input = input.ToUpper(); // Меняем шрифт входных символов до прописного регистра.
            input = input.Replace("-", "");
            input = input.Replace("ё", "Е"); // Замена букв ё на Е.
            input = input.Replace("Ё", "Е"); // Замена букв Ё на Е.
            input = input.Replace(",", "");
            input = input.Replace(".", "");
            input = input.Replace(";", "");
            input = input.Replace("/", "");
            input = input.Replace(":", "");
            input = input.Replace("!", "");
            input = input.Replace("?", "");
            input = input.Replace("#", "");
            input = input.Replace("$", "");
            input = input.Replace("%", "");
            input = input.Replace("&", "");
            input = input.Replace("'", "");
            input = input.Replace("(", "");
            input = input.Replace(")", "");
            input = input.Replace("*", "");
            input = input.Replace("+", "");
            input = input.Replace("/", "");
            input = input.Replace("0", "");
            input = input.Replace("1", "");
            input = input.Replace("2", "");
            input = input.Replace("3", "");
            input = input.Replace("4", "");
            input = input.Replace("5", "");
            input = input.Replace("6", "");
            input = input.Replace("7", "");
            input = input.Replace("8", "");
            input = input.Replace("9", "");
            input = input.Replace("<", "");
            input = input.Replace("=", "");
            input = input.Replace(">", "");
            input = input.Replace("@", "");
            input = input.Replace("A", "");
            input = input.Replace("B", "");
            input = input.Replace("C", "");
            input = input.Replace("D", "");
            input = input.Replace("E", "");
            input = input.Replace("F", "");
            input = input.Replace("G", "");
            input = input.Replace("H", "");
            input = input.Replace("I", "");
            input = input.Replace("J", "");
            input = input.Replace("K", "");
            input = input.Replace("L", "");
            input = input.Replace("M", "");
            input = input.Replace("N", "");
            input = input.Replace("O", "");
            input = input.Replace("P", "");
            input = input.Replace("Q", "");
            input = input.Replace("R", "");
            input = input.Replace("S", "");
            input = input.Replace("T", "");
            input = input.Replace("U", "");
            input = input.Replace("V", "");
            input = input.Replace("W", "");
            input = input.Replace("X", "");
            input = input.Replace("Y", "");
            input = input.Replace("Z", "");
            input = input.Replace("[", "");
            input = input.Replace("]", "");
            input = input.Replace("^", "");
            input = input.Replace("_", "");
            input = input.Replace("`", "");
            input = input.Replace("|", "");
            input = input.Replace(Environment.NewLine, " ");
            input = input.Replace(" ", ""); // Замена небуквенных символов пробела на пропуск.
            keyword = keyword.ToUpper(); // Меняем шрифт символов ключа до прописного регистра.

            string result = ""; // Свойство Result блокирует вызывающий поток "пропусков" до завершения задачи.

            int keyword_index = 0; // Локальная переменная для ключа.

            foreach (char symbol in input) // Для одномерных массивов оператор "foreach" обрабатывает элементы в порядке возрастания индекса, начиная с индекса 0 и заканчивая индексом Length - 1.
            {
                int c = (Array.IndexOf(characters, symbol) + Array.IndexOf(characters, keyword[keyword_index])) % 32; // Шифрование производится по формуле: "ci = (pi + ki) mod N".
                // Где ci – символ закодированного сообщения, pi – символ исходного сообщения, ki – символ ключа, N – мощность алфавита (количество символов в алфавите).

                result += characters[c]; // Результат шифрования.
                keyword_index++; // Подбирание ключа для определения.

                if ((keyword_index + 1) == keyword.Length + 1) // length – нужная длина ключа.
                    keyword_index = 0; // Переменная для определения символа из ключа.
            }

            result = result.ToLower(); // Меняем шрифт, после обработки, до строчного регистра.
            textBoxCrypt.Text = result; // Зашифрованный текст отображается в окне "Обработанный текст".
            return result; // Возврат обработанного текста.
        }

        private string Decode(string input, string keyword) // Процедура расшифрования текста по методу Виженера.
        {
            input = input.ToUpper(); // Меняем шрифт входных символов до прописного регистра.
            input = input.Replace("-", ""); // Замена небуквенных символов пробела на пропуск.
            input = input.Replace("ё", "Е"); // Замена букв ё на Е.
            input = input.Replace("Ё", "Е"); // Замена букв Ё на Е.
            input = input.Replace(",", "");
            input = input.Replace(".", "");
            input = input.Replace(";", "");
            input = input.Replace("/", "");
            input = input.Replace(":", "");
            input = input.Replace("!", "");
            input = input.Replace("?", ""); 
            input = input.Replace("#", "");
            input = input.Replace("$", "");
            input = input.Replace("%", "");
            input = input.Replace("&", "");
            input = input.Replace("'", "");
            input = input.Replace("(", "");
            input = input.Replace(")", "");
            input = input.Replace("*", "");
            input = input.Replace("+", "");
            input = input.Replace("/", "");
            input = input.Replace("0", "");
            input = input.Replace("1", "");
            input = input.Replace("2", "");
            input = input.Replace("3", "");
            input = input.Replace("4", "");
            input = input.Replace("5", "");
            input = input.Replace("6", "");
            input = input.Replace("7", "");
            input = input.Replace("8", "");
            input = input.Replace("9", "");
            input = input.Replace("<", "");
            input = input.Replace("=", "");
            input = input.Replace(">", "");
            input = input.Replace("@", "");
            input = input.Replace("A", "");
            input = input.Replace("B", "");
            input = input.Replace("C", "");
            input = input.Replace("D", "");
            input = input.Replace("E", "");
            input = input.Replace("F", "");
            input = input.Replace("G", "");
            input = input.Replace("H", "");
            input = input.Replace("I", "");
            input = input.Replace("J", "");
            input = input.Replace("K", "");
            input = input.Replace("L", "");
            input = input.Replace("M", "");
            input = input.Replace("N", "");
            input = input.Replace("O", "");
            input = input.Replace("P", "");
            input = input.Replace("Q", "");
            input = input.Replace("R", "");
            input = input.Replace("S", "");
            input = input.Replace("T", "");
            input = input.Replace("U", "");
            input = input.Replace("V", "");
            input = input.Replace("W", "");
            input = input.Replace("X", "");
            input = input.Replace("Y", "");
            input = input.Replace("Z", "");
            input = input.Replace("[", "");
            input = input.Replace("]", "");
            input = input.Replace("^", "");
            input = input.Replace("_", "");
            input = input.Replace("`", "");
            input = input.Replace("|", "");
            input = input.Replace(Environment.NewLine, " ");
            input = input.Replace(" ", ""); // Замена небуквенных символов пробела на пропуск.
            keyword = keyword.ToUpper(); // Меняем шрифт символов ключа до прописного регистра.

            string result = ""; // Свойство Result блокирует вызывающий поток "пропусков" до завершения задачи.

            int keyword_index = 0; // Локальная переменная для ключа.

            foreach (char symbol in input) // Оператор "foreach" как и в случае с шифрованием необходим для одномерных массивов.
            {
                int p = (Array.IndexOf(characters, symbol) + N - Array.IndexOf(characters, keyword[keyword_index])) % N; // Расшифрование производится по формуле: "pi = (ci + N - ki) mod N".
                // Где pi – символ исходного сообщения, ci – символ закодированного сообщения, N – мощность алфавита (количество символов в алфавите), ki – символ ключа.

                result += characters[p]; // Результат расшифрования.
                keyword_index++; // Подбор символа ключа для определения.

                if ((keyword_index + 1) == keyword.Length + 1) // length – нужная длина ключа.
                    keyword_index = 0; // Переменная для определения символа из ключа.
            }
            result = result.ToLower(); // Меняем шрифт, после обработки, до строчного регистра.
            textBoxCrypt.Text = result; // Зашифрованный текст отображается в окне "Обработанный текст".
            return result; // Возврат обработанного текста.
        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty; // Обьявление переменной.
            var filePath = string.Empty; // Обьявление переменной.
            using (OpenFileDialog openFileDialog = new OpenFileDialog())  // Функция открытия файла.
            {
                openFileDialog.InitialDirectory = "C:\\"; // Изначальная директория открытия файла.
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; // Тип файла для открытия.
                openFileDialog.FilterIndex = 2; // Индекс для файлового фильтра.
                openFileDialog.RestoreDirectory = true; // Востановление изначальной директории, не сохраняет последнее открытие.
                if (openFileDialog.ShowDialog() == DialogResult.OK) // Диалоговое окно.
                {
                    filePath = openFileDialog.FileName; // Получаем путь к указанному файлу.
                    var fileStream = openFileDialog.OpenFile(); // Прочитаем содержимое файла в поток.
                    using (StreamReader reader = new StreamReader(fileStream)) // Содержимое файла отправляем в "textBoxOriginal".
                    {
                        fileContent = reader.ReadToEnd(); // Прочесть файл до конца.
                        fileContent = fileContent.ToUpper();
                        fileContent = fileContent.Replace("@", "");
                        fileContent = fileContent.Replace("A", "");
                        fileContent = fileContent.Replace("B", "");
                        fileContent = fileContent.Replace("C", "");
                        fileContent = fileContent.Replace("D", "");
                        fileContent = fileContent.Replace("E", "");
                        fileContent = fileContent.Replace("F", "");
                        fileContent = fileContent.Replace("G", "");
                        fileContent = fileContent.Replace("H", "");
                        fileContent = fileContent.Replace("I", "");
                        fileContent = fileContent.Replace("J", "");
                        fileContent = fileContent.Replace("K", "");
                        fileContent = fileContent.Replace("L", "");
                        fileContent = fileContent.Replace("M", "");
                        fileContent = fileContent.Replace("N", "");
                        fileContent = fileContent.Replace("O", "");
                        fileContent = fileContent.Replace("P", "");
                        fileContent = fileContent.Replace("Q", "");
                        fileContent = fileContent.Replace("R", "");
                        fileContent = fileContent.Replace("S", "");
                        fileContent = fileContent.Replace("T", "");
                        fileContent = fileContent.Replace("U", "");
                        fileContent = fileContent.Replace("V", "");
                        fileContent = fileContent.Replace("W", "");
                        fileContent = fileContent.Replace("X", "");
                        fileContent = fileContent.Replace("Y", "");
                        fileContent = fileContent.Replace("Z", "");
                        fileContent = fileContent.Replace("[", "");
                        fileContent = fileContent.Replace("]", "");
                        fileContent = fileContent.Replace("^", "");
                        fileContent = fileContent.Replace("_", "");
                        fileContent = fileContent.Replace("`", "");
                        fileContent = fileContent.ToLower();
                        textBoxOriginal.Text = fileContent; // Отправляем тект в "textBoxOriginal".
                        textBoxOriginal.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void сохранитьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog(); // Открытия диалога сохранения.
            saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*"; // Тип файла для открытия.
            if (saveFileDialog.ShowDialog() == DialogResult.OK) // Функция открытия файла.
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName); // Запись файла.
                streamWriter.WriteLine(textBoxCrypt.Text); // Записать из "textBoxCrypt".
                streamWriter.Close(); // Завершение.
            }
        }

        private void переставитьТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxOriginal.Text = textBoxCrypt.Text; // Перенос текста.
            textBoxCrypt.Clear(); // Очистка шифрованного текста.
            textBoxOriginal.ForeColor = Color.Black;
        }

        private void форматироватьТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxOriginal.Text = textBoxOriginal.Text.Replace(" ", ""); // Очистка оригинального текста.
            textBoxCrypt.Text = textBoxCrypt.Text.Replace(" ", ""); // Очистка обработанного текста.
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxOriginal.Text = "Введите текст:";
            textBoxOriginal.ForeColor = Color.Gray;
            textBoxKeyWord.Text = "Введите ключ:";
            textBoxKeyWord.ForeColor = Color.Gray;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (encryptRadioButton.Checked) // Проверка "RadioBattom" для зашифровывания текста.
            {
                if (textBoxKeyWord.Text == "Введите ключ:")
                {
                    MessageBox.Show("Необходимо ввести ключевое слово."); // Сообшение о отсутвие ключа
                }
                else
                    if (textBoxOriginal.Text == "Введите текст:")
                    {
                        MessageBox.Show("Необходимо ввести основной текст."); // Сообшение о отсутвие ключа
                    }
                    else
                        if (textBoxKeyWord.Text.Length > 1) // Проверка наличия ключа.
                        {
                            Encode(textBoxOriginal.Text, textBoxKeyWord.Text); // Проведение зашифровывания Encode(string input, string keyword)
                            textBoxCrypt.Text = textBoxCrypt.Text.ToString(); // Функция разделения в "textBoxCrypt" по i символов.
                            int i = textBoxCrypt.Text.Length - 5; // Через каждые 5 символов.
                            while (i >= 0) // Подсчёт символов.
                            {
                                textBoxCrypt.Text = textBoxCrypt.Text.Insert(i, " ");  // Вставка пробелов.
                                i -= 5; // Через сколько символов нужен пробел.
                            }
                        }
                        else // В случае отсутвия ключа.
                            MessageBox.Show("Необходимо ввести ключевое слово длиннее одного символа."); // Сообшение о отсутвие ключа.
            }
            else // Проверка "RadioBattom" для расшифровывания текста.
            {
                if (textBoxKeyWord.Text == "Введите ключ:")
                {
                    MessageBox.Show("Необходимо ввести ключевое слово."); // Сообшение о отсутвие ключа
                }
                else
                    if (textBoxOriginal.Text == "Введите текст:")
                    {
                        MessageBox.Show("Необходимо ввести основной текст."); // Сообшение о отсутвие ключа
                    }
                    else
                        if (textBoxKeyWord.Text.Length > 1) // Проверка наличия ключа.
                        {
                            Decode(textBoxOriginal.Text, textBoxKeyWord.Text); // Проведение зашифровывания Encode(string input, string keyword)
                            textBoxCrypt.Text = textBoxCrypt.Text.ToString(); // Функция разделения в "textBoxCrypt" по i символов.
                            int i = textBoxCrypt.Text.Length - 5; // Через каждые 5 символов.
                            while (i >= 0) // Подсчёт символов.
                            {
                                textBoxCrypt.Text = textBoxCrypt.Text.Insert(i, " ");  // Вставка пробелов.
                                i -= 5; // Через сколько символов нужен пробел.
                            }
                        }
                        else // В случае отсутвия ключа.
                            MessageBox.Show("Необходимо ввести ключевое слово длиннее одного символа."); // Сообшение о отсутвие ключа.
            }
        }

        private void textBoxKeyWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !((c >= 'а' && c <= 'я') || (c >= 'А' && c <= 'Я') || c == 8);
            // Ввод текста только на кирилице, с клавишами "Backspace" и "Delete".
        }
        private void textBoxOriginal_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !((c >= 'а' && c <= 'я') || (c >= 'А' && c <= 'Я') || c == 8 || c == 10 || (c >= 32 && c <= 33) || (c >= 35 && c <= 63));
            // Ввод текста только на кирилице, с клавишами "Backspace" и "Delete".
        }

        private void textBoxKeyWord_Enter(object sender, EventArgs e)
        {
            if (textBoxKeyWord.Text == "Введите ключ:")
            {
                textBoxKeyWord.Clear();
                textBoxKeyWord.ForeColor = Color.Black;
            }
        }

        private void textBoxKeyWord_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxKeyWord.Text))
            {
                textBoxKeyWord.Text = "Введите ключ:";
                textBoxKeyWord.ForeColor = Color.Gray;
            }
        }

        private void textBoxOriginal_Enter(object sender, EventArgs e)
        {
            if (textBoxOriginal.Text == "Введите текст:")
            {
                textBoxOriginal.Clear();
                textBoxOriginal.ForeColor = Color.Black;
            }
        }

        private void textBoxOriginal_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxOriginal.Text))
            {
                textBoxOriginal.Text = "Введите текст:";
                textBoxOriginal.ForeColor = Color.Gray;
            }
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }
    }
}
