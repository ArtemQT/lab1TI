using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


enum METHOD
{
    COLUMN,
    VIZENER
}

enum LANGUAGE
{
    RU,
    EN,
}

namespace lab1TI
{
    public partial class CipherForm : System.Windows.Forms.Form
    {

        private LANGUAGE CurAlphabet;
        private METHOD CurMethod;
        private delegate string CurFunction(string key, string text);


        private char[] englishAlphabet =
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };

        private char[] russianAlphabet =
        {
            'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М',
            'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ',
            'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я'
        };

        public CipherForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            CurAlphabet = LANGUAGE.EN;
            CurMethod = METHOD.COLUMN;
        }

        private void MainAlgorithm(CurFunction function)
        {
            bool status;
            // key
            string key;
            (status, key) = IsGoodKey(KeytextBox.Text);
            if (!status)
            {
                MessageBox.Show(key, "Ошибка!");
                return;
            }
            // plain text
            string Planetext;
            (status, Planetext) = IsGoodEntryText(EntrytextBox.Text);
            if (!status)
            {
                MessageBox.Show(Planetext, "Ошибка!");
                return;
            }
            string OriginText = EntrytextBox.Text;
            string cipherText = function(key, Planetext);

            CipheredtextBox.Text = GenerateOutputString(OriginText.ToUpper(), Planetext, cipherText);

            WriteToFilebutton.Enabled = true;
        }

        private string GenerateOutputString(string text, string plain, string cipher)
        {
            string result = string.Empty;

            int encIndex = 0;
            int textIndex = 0;
            while (encIndex < cipher.Length && textIndex < text.Length)
            {
                if (text[textIndex] != plain[encIndex])
                {
                    result += text[textIndex];
                    textIndex++;
                }
                else
                {
                    result += cipher[encIndex];
                    textIndex++;
                    encIndex++;
                }
            }

            // Добавляем оставшиеся символы из text, если они есть
            while (textIndex < text.Length)
            {
                result += text[textIndex];
                textIndex++;
            }

            return result;
        }
        private (bool, string) IsGoodKey(string key)
        {
            if (key.Trim().Length == 0)
                return (false, "Введите ключ. Поле ввода пустое.");

            key = key.ToUpper();
            string ResultKey = "";
            char[] alphabet = CurAlphabet == LANGUAGE.EN ? englishAlphabet : russianAlphabet;

            foreach (char c in key)
            {
                if (alphabet.Contains(c))
                    ResultKey += c;
            }

            if (ResultKey.Length == 0)
            {
                return (false, "В ключе нет символов соответствующим алфавиту.");
            }

            return (true, ResultKey);
        }

        private (bool, string) IsGoodEntryText(string Text)
        {
            if (Text.Trim().Length == 0)
                return (false, "Введите исходный текст. Поле ввода пустое.");

            Text = Text.ToUpper();
            string ResultText = "";
            char[] alphabet = CurAlphabet == LANGUAGE.EN ? englishAlphabet: russianAlphabet;

            foreach(char c in Text)
            {
                if (alphabet.Contains(c))
                    ResultText += c;
            }

            if (ResultText.Length == 0)
            {
                return (false, "В исходном тексте нет символов соответствующим алфавиту.");
            }

            return(true, ResultText);
        }

        private void ResetInputs()
        {
            CipheredtextBox.Text = string.Empty;
            EntrytextBox.Text = "";
            KeytextBox.Text = "";

            WriteToFilebutton.Enabled = false;
        }

        private string VizinerEncription(string key, string text)
        {
   
            if (text.Length > key.Length)
                key += text.Substring(0, text.Length - key.Length);

            // cyper
            string result = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                int index = (Array.IndexOf(russianAlphabet, text[i]) + Array.IndexOf(russianAlphabet, key[i]) + russianAlphabet.Length) % russianAlphabet.Length;
                result += russianAlphabet[index];
            }
            return result;
        }

        private string VizinerDecription(string key, string text)
        {
            int keyIndex = 0;
            int resIndex = 0;
            string result = string.Empty;
            while (keyIndex < text.Length)
            {
                if (keyIndex == key.Length)
                    key += result[resIndex++];
                int index = (Array.IndexOf(russianAlphabet, text[keyIndex]) - Array.IndexOf(russianAlphabet, key[keyIndex]) + russianAlphabet.Length) % russianAlphabet.Length;
                result += russianAlphabet[index];
                keyIndex++;
            }
            return result;
        }

        private int GetRows(int[] indexes, string text)
        {
            int count = 0;
            int length = 0;
            while (length < text.Length)
            {
                int curIndex = count % indexes.Length;
                length += Array.IndexOf(indexes, curIndex + 1) + 1;
                count++;
            }
            return count;
        }

        private int LastRowCount(int[] indexes, string text)
        {
            int count = 0;
            int length = 0;
            while (length < text.Length)
            {
                int curIndex = count % indexes.Length;
                length += Array.IndexOf(indexes, curIndex + 1) + 1;
                count++;
            }
            int result = Array.IndexOf(indexes, count % indexes.Length) - (length - text.Length);
            return result;
        }

        private string ColumnEncription(string key, string text)
        {
            // fill first row
            int[] keyIndexMatrix = new int[key.Length];
            for (int i = 0; i < key.Length; i++)
                keyIndexMatrix[i] = Array.IndexOf(englishAlphabet, key[i]) + 1;

            // find ranks
            var pairs = keyIndexMatrix.Select((value, index) => new { Value = value, Index = index }).ToArray();
            var sortedPairs = pairs.OrderBy(p => p.Value)
                                   .ThenBy(p => p.Index)
                                   .ToArray();

            int[] ranks = new int[keyIndexMatrix.Length];
            for (int i = 0; i < sortedPairs.Length; i++)
            {
                ranks[sortedPairs[i].Index] = i + 1;
            }
            keyIndexMatrix = ranks;

            char[][] matrix = new char[GetRows(keyIndexMatrix, text)][];
            for (int i = 0; i < matrix.Length; i++)
                matrix[i] = new char[key.Length];

            // fill matrix
            int plainTextIndex = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = text[plainTextIndex++];
                    if (plainTextIndex == text.Length) break;
                    if (keyIndexMatrix[j] == (i % keyIndexMatrix.Length) + 1) break;
                }
                if (plainTextIndex == text.Length) break;
            }

            // create result string
            string result = string.Empty;
            for (int i = 0; i < matrix[0].Length; i++)
            {
                int column = Array.IndexOf(keyIndexMatrix, i + 1);
                for (int j = 0; j < matrix.Length; j++)
                    result += matrix[j][column] == '\0' ? "" : matrix[j][column].ToString();
            }
            return result;
        }

        private string ColumnDecription(string key, string text)
        {
            // fill first row
            int[] keyIndexMatrix = new int[key.Length];
            for (int i = 0; i < key.Length; i++)
                keyIndexMatrix[i] = Array.IndexOf(englishAlphabet, key[i]) + 1;

            // find ranks
            var pairs = keyIndexMatrix.Select((value, index) => new { Value = value, Index = index }).ToArray();
            var sortedPairs = pairs.OrderBy(p => p.Value)
                                   .ThenBy(p => p.Index)
                                   .ToArray();
            int[] ranks = new int[keyIndexMatrix.Length];
            for (int i = 0; i < sortedPairs.Length; i++)
            {
                ranks[sortedPairs[i].Index] = i + 1;
            }
            keyIndexMatrix = ranks;

            char[][] matrix = new char[GetRows(keyIndexMatrix, text)][];
            for (int i = 0; i < matrix.Length; i++)
                matrix[i] = new char[key.Length];

            // fill matrix
            int textIndex = 0;
            for (int i = 0; i < matrix[0].Length; i++)
            {
                int index = Array.IndexOf(keyIndexMatrix, i + 1);
                for (int j = 0; j < matrix.Length; j++)
                {
                    int isLeft = Array.IndexOf(keyIndexMatrix, j % keyIndexMatrix.Length + 1);
                    if (isLeft >= index)
                        if (j == matrix.Length - 1 && LastRowCount(keyIndexMatrix, text) >= index)
                            matrix[j][index] = text[textIndex++];
                        else if (j != matrix.Length - 1)
                            matrix[j][index] = text[textIndex++];
                    if (textIndex == text.Length) break;
                }
                if (textIndex == text.Length) break;
            }

            // create result string
            string result = string.Empty;
            for (int i = 0; i < matrix.Length; i++)
                for (int j = 0; j < matrix[i].Length; j++)
                    result += matrix[i][j] == '\0' ? "" : matrix[i][j].ToString();
            return result;
        }
        private void Encryptionbutton_Click(object sender, EventArgs e)
        {
            CipheredtextBox.Text = string.Empty;
            CurFunction Function;
            if (CurMethod == METHOD.VIZENER)
                Function = VizinerEncription;
            else
                Function = ColumnEncription;

            MainAlgorithm(Function);
        }

        private void Decryptionbutton_Click(object sender, EventArgs e)
        {
            CurFunction Function;
            if (CurMethod == METHOD.VIZENER)
                Function = VizinerDecription;
            else
                Function = ColumnDecription;
            MainAlgorithm(Function);
        }

        private void ColumnButton_Click(object sender, EventArgs e)
        {
            CurrentCipherLabel.Text = "Столбцовый улучшенный метод";
            LanguageLabel.Text = "Язык: Англ";
            CurMethod = METHOD.COLUMN;
            CurAlphabet = LANGUAGE.EN;
            ResetInputs();
        }

        private void VigenerButton_Click(object sender, EventArgs e)
        {

            CurrentCipherLabel.Text = "Виженер, самогенерирующийся ключ";
            LanguageLabel.Text = "Язык: Рус";
            CurMethod = METHOD.VIZENER;
            CurAlphabet = LANGUAGE.RU;
            ResetInputs();
        }

        private void ReadFromFilebutton_Click(object sender, EventArgs e)
        {
            EntrytextBox.Text = getStringFromFile();
        }
        private string getStringFromFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bool status;
                string result;
                (status, result) = ReadStringFromFile(openFileDialog1.FileName);
                if (status)
                    return result;
                MessageBox.Show(result, "Ошибка!");
            }
            return string.Empty;
        }

        private (bool, string) ReadStringFromFile(string filename)
        {
            try
            {
                string content = System.IO.File.ReadAllText(filename);
                bool status;
                string info;
                (status, info) = CheckIsGoodPlain(content);
                if (status)
                    return (true, content);
                return (false, "Строка не является корректной!");
            }
            catch (Exception ex)
            {
                return (false, $"Ошибка при чтении файла: {ex.Message}");
            }
        }
        private (bool status, string plainText) CheckIsGoodPlain(string text)
        {
            if (text.Length == 0)
                return (false, "Введите исходный текст!");
            return (true, text);
        }

        private void WriteToFilebutton_Click(object sender, EventArgs e)
        {
            setStringInFile(CipheredtextBox.Text);
        }

        private bool setStringInFile(string text)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bool status;
                string result;
                (status, result) = WriteStringInFile(saveFileDialog1.FileName, text);
                MessageBox.Show(result, status ? "Успех" : "Ошибка");
                return status;
            }
            return true;
        }

        private (bool, string) WriteStringInFile(string fileName, string text)
        {
            try
            {
                System.IO.File.WriteAllText(fileName, text);
                return (true, "Строка успешно записана в файл.");
            }
            catch (Exception ex)
            {
                return (false, $"Ошибка при записи в файл: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetInputs();
        }
    }
}
