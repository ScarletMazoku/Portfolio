using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System.IO;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Drawing.Drawing2D;
using System.Security.Policy;
using System.Collections;

namespace DIPLOM
{
    public partial class BALDA : Form
    {
        int timeLeft = 10, counter = 1, player1_score = 0, player2_score = 0, i_current = 0, j_current = 0;
        int cell_i, cell_j;
        string picked_letter;
        TextBox[,] a;
        Dictionary<TextBox, bool>[,] map;
        Random rand = new Random();
        bool flag_sborka, finish_flag1, finish_flag2, isEqual;
        List<int> prev_i = new List<int>() {-1};
        List<int> prev_j = new List<int>() {-1};
        List<string> word_been = new List<string>();
        List<string> current_word_list = new List<string> {};



        public BALDA()
        {
            InitializeComponent();
        }

        private void BALDA_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            Hint_button.Enabled = false;
            Word_verification_textbox.Enabled = false;
            Word_verification_button.Enabled = false;
            Surrend_button.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            counter = 1;
            Score_label.Text = "0:0";
            player1_score = 0;
            player2_score = 0;
            PlayerTurn_label.Text = "Ход игрока " + counter;
        }

        TextBox cell_id(int i, int j) {
            return map[i, j].ElementAt(0).Key;
        }

        bool cell_value(int i, int j) {
            return map[i, j][map[i, j].ElementAt(0).Key];
        }

        void cell_value_change(int i, int j, bool a) 
        {
            if (a) map[i, j][map[i, j].ElementAt(0).Key] = true;
            else map[i, j][map[i, j].ElementAt(0).Key] = false;
        }

        private int Compare(string w1, string w2)
        {            
            if (w1 == w2) return 0;
            for (int i = 0; i < w1.Length && i < w2.Length; i++)
            {
                if (w1[i] != w2[i])
                {
                    if (w1[i] < w2[i])
                    {
                        return -1;
                    }
                    else return 1;
                }
            }
            if (w1.Length < w2.Length) return -1;
            else return 1;
        }

        private bool word_verification(string Find_word) 
        {
            string path = "russian_words_sorted.txt";
            string[] file = File.ReadAllLines(path);
            string Temp_word;
            double Nmax = file.Length;
            double Nmin = 0;
            double N = Math.Ceiling(Nmax / 2);
            int z = Convert.ToInt32(N);
            int Sign = 3;
            while (Sign != 0)
            {
                Temp_word = file[z];
                //Sign = string.Compare(Find_word, Temp_word);
                Sign = Compare(Find_word, Temp_word);
                if (Sign == 0)
                {
                    return true;
                }
                if (N == Nmin || N == Nmax)
                {
                    return false;
                }
                if (Sign == -1)
                {
                    Nmax = N;
                    N = Math.Floor(Nmax - (Nmax - Nmin) / 2);
                    z = Convert.ToInt32(N);
                }
                if (Sign == 1)
                {
                    Nmin = N;
                    N = Math.Ceiling(Nmax - (Nmax - Nmin) / 2);
                    z = Convert.ToInt32(N);
                }
            }
            return false;
        }

        private void write_only(int i, int j)
        {
            cell_id(i, j).ReadOnly = true;
            if (j != 0 && cell_value(i, j - 1) == false) cell_id(i, j - 1).ReadOnly = false;
            if (i != 0 && cell_value(i - 1, j) == false) cell_id(i - 1, j).ReadOnly = false; 
            if (j != 4 && cell_value(i, j + 1) == false) cell_id(i, j + 1).ReadOnly = false;
            if (i != 4 && cell_value(i + 1, j) == false) cell_id(i + 1, j).ReadOnly = false;
        }

        private void start_word() {
            string path = "russian_words_5letters.txt";
            string word;
            string[] file = File.ReadAllLines(path);
            int N = rand.Next(2066);
            word = file[N];
            Cell2x0.Text = word[0].ToString();
            write_only(2, 0);
            cell_value_change(2, 0, true);
            Cell2x1.Text = word[1].ToString();
            write_only(2, 1);
            cell_value_change(2, 1, true);
            Cell2x2.Text = word[2].ToString();
            write_only(2, 2);
            cell_value_change(2, 2, true);
            Cell2x3.Text = word[3].ToString();
            write_only(2, 3);
            cell_value_change(2, 3, true);
            Cell2x4.Text = word[4].ToString();
            write_only(2, 4);
            cell_value_change(2, 4, true);
            word_been.Add(word);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft --;
                label1.Text = timeLeft + " seconds";
                if (counter == 1) finish_flag1 = false; else finish_flag2 = false;
            }
            else
            {
                timer1.Stop();
                label1.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                if (counter == 1) finish_flag1 = true; else finish_flag2 = true;
                if (finish_flag1 && finish_flag2){ 
                    MessageBox.Show("Game Over");
                    game_over(sender, e); 
                }
                if (counter == 1) counter = 2; else counter = 1;
                timeLeft = 120;
                label1.Text = "120 seconds";
                timer1.Start();
                PlayerTurn_label.Text = "Ход игрока " + counter;
                Find_word.Text = "Добавьте букву";
                button2_Click(sender, e);
            }
        }

        private bool check_all_cellls()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (cell_value(i, j) == false)
                        return false;
                }
            }
            return true;
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            if (Start_button.Text == "Начать")
            {
                Hint_button.Enabled = true;
                Word_verification_textbox.Enabled = true;
                Word_verification_button.Enabled = true;
                Surrend_button.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;

                timeLeft = 120;
                label1.Text = "120 seconds";
                Find_word.Text = "Добавьте букву";
                timer1.Start();
                Start_button.Text = "Завершить ход";
                PlayerTurn_label.Text = "Ход игрока " + counter;
                a = new TextBox[,] {
                    {Cell0x0, Cell0x1, Cell0x2, Cell0x3, Cell0x4},
                    {Cell1x0, Cell1x1, Cell1x2, Cell1x3, Cell1x4},
                    {Cell2x0, Cell2x1, Cell2x2, Cell2x3, Cell2x4},
                    {Cell3x0, Cell3x1, Cell3x2, Cell3x3, Cell3x4},
                    {Cell4x0, Cell4x1, Cell4x2, Cell4x3, Cell4x4}
                };
                map = new Dictionary<TextBox, bool>[5, 5];
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        map[i, j] = new Dictionary<TextBox, bool>() { { a[i, j], false } };
                        cell_id(i, j).ReadOnly = true;
                    }
                }
                start_word();
            }
            else
            {
                if (!word_been.Any(s => s == Find_word.Text))
                {
                    if (word_verification(Find_word.Text.ToLower()))
                    {                        
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                if (cell_value(i, j) == true)
                                    write_only(i, j);
                            }
                        }
                        word_been.Add(Find_word.Text.ToLower());
                        timeLeft = 120;
                        label1.Text = "120 seconds";
                        timer1.Start();
                        if (counter == 1) player1_score += Find_word.Text.Length; else player2_score += Find_word.Text.Length;
                        if (counter == 1) counter = 2; else counter = 1;
                        PlayerTurn_label.Text = "Ход игрока " + counter;
                        Score_label.Text = player1_score + ":" + player2_score;
                        Find_word.Text = "Добавьте букву";
                        flag_sborka = false;
                        prev_i.Clear();
                        prev_j.Clear();
                        prev_i.Add(-1);
                        prev_j.Add(-1);
                        if (check_all_cellls()) {
                            if (player1_score > player2_score)
                            {
                                MessageBox.Show("Player 1 wins", "Congratulations!");
                                game_over(sender, e);                                
                            }
                            else if (player1_score > player2_score)
                            {
                                MessageBox.Show("Player 2 wins", "Congratulations!");
                                game_over(sender, e);
                            }
                            else
                             {
                                MessageBox.Show("Ничья");
                                game_over(sender, e);
                            }
                        }
                    }
                    else
                    {
                        timer1.Stop();
                        MessageBox.Show("Такого слова нет в словаре", "Ошибка");
                        timer1.Start();
                    }
                }
                else { timer1.Stop(); MessageBox.Show("Такое слово уже было"); timer1.Start(); }
            }
            
        }

        private void IsWordExist(string word)
        {
            string path = "russian_words_sorted.txt";
            string[] file = File.ReadAllLines(path);
            word = word.ToLower();
            string pattern = "^" + word + "$";

            foreach (string s in current_word_list)
            {
                if (word.Length < s.Length) return;
            }

            foreach (string s in file)
            {
                Match match = Regex.Match(s, pattern);
                if (match.Success)
                {
                    current_word_list.Add(s);
                    current_word_list = current_word_list.Distinct().ToList();
                    current_word_list.Sort((s1, s2) => s2.Length.CompareTo(s1.Length));
                    foreach (string d in word_been)
                    {
                        if (current_word_list.Contains(d)) { current_word_list.Remove(d); }
                    }
                    if (current_word_list.Count > 20) 
                        current_word_list.RemoveRange(20, current_word_list.Count - 20);
                }
            }
            return;
        }

        private void next_letter(string current_word, List<int[]> path) 
        {
            int current_x = path.Last()[0];
            int current_y = path.Last()[1];

            if (current_x > 4 || current_y > 4 || current_x < 0 || current_y < 0) 
                return;

            if(path.Count() != 1)
                for (int i = 0; i < path.Count() - 1; i++) 
                {
                    if (path[i][0] == current_x && path[i][1] == current_y) return;
                }
            if (cell_id(current_x, current_y).Text == "" && cell_id(current_x, current_y).ReadOnly == true) return;

            if (cell_id(current_x, current_y).Text != "")
                current_word += cell_id(current_x, current_y).Text;
            else
                current_word += ".";

            char unknown_symbol = '.';
            if (current_word.Count(x => x == unknown_symbol) == 2) return;

            if (current_word.Contains("."))
                IsWordExist(current_word);

            int[] a = new int[2] { current_x, current_y + 1 };
            path.Add(a);
            next_letter(current_word, path);
            int last_element_id = path.Count();
            path.RemoveAt(last_element_id - 1);

            a[0] = current_x + 1; a[1] = current_y;
            path.Add(a);
            next_letter(current_word, path);
            path.RemoveAt(last_element_id - 1);

            a[0] = current_x; a[1] = current_y - 1;
            path.Add(a);
            next_letter(current_word, path);
            path.RemoveAt(last_element_id - 1);

            a[0] = current_x - 1; a[1] = current_y;
            path.Add(a);
            next_letter(current_word, path);
            path.RemoveAt(last_element_id - 1);

            //int[] a = new int[2] {current_x, current_y + 1};
            //path.Add(a);
            //List<int[]> path1 = path.ToList();
            //int last_element_id = path.Count();
            //path.RemoveAt(last_element_id - 1);

            //a = new int[2] { current_x + 1, current_y};
            //path.Add(a);
            //List<int[]> path2 = path.ToList();
            //last_element_id = path.Count();
            //path.RemoveAt(last_element_id - 1);

            //a = new int[2] { current_x, current_y - 1 };
            //path.Add(a);
            //List<int[]> path3 = path.ToList();
            //last_element_id = path.Count();
            //path.RemoveAt(last_element_id - 1);

            //a = new int[2] { current_x - 1, current_y };
            //path.Add(a);
            //List<int[]> path4 = path.ToList();
            //last_element_id = path.Count();
            //path.RemoveAt(last_element_id - 1);

            //next_letter(current_word, path1);
            //next_letter(current_word, path2);
            //next_letter(current_word, path3);
            //next_letter(current_word, path4);
        }

        private void Hint_button_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Cursor = System.Windows.Forms.Cursors.WaitCursor;
            List<int[]> coordinate = new List<int[]>();
            int[] a = new int[2];
            string current_letter;
            int current_letter_x, current_letter_y;         

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    current_letter = "";
                    current_letter_x = i;
                    current_letter_y = j;
                    a[0] = i;
                    a[1] = j;
                    coordinate.Add(a);
                    if (cell_id(i, j).ReadOnly == false || cell_id(i, j).Text != "")  
                        next_letter(current_letter, coordinate); 
                    coordinate.Clear();
                }
            }

            //current_word_list = current_word_list.Distinct().ToList();
            //current_word_list.Sort((s1, s2) => s2.Length.CompareTo(s1.Length));
            //foreach (string s in word_been) 
            //{
            //    if (current_word_list.Contains(s)) { current_word_list.Remove(s); } 
            //}
            //current_word_list.RemoveRange(20, current_word_list.Count - 20);

            //List <string> result = current_word_list.Except(word_been).ToList();
            //string message = string.Join(Environment.NewLine, result);
            string message = string.Join(Environment.NewLine, current_word_list);
            Cursor = System.Windows.Forms.Cursors.Default;
            MessageBox.Show(message, "Список возможных слов");
            current_word_list.Clear();
            timer1.Start();
        }

        private void Surrend_button_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (counter == 1) counter = 2; else counter = 1;
            MessageBox.Show("Player " + counter + " wins","Congratulations!");
            Start_button.Text = "Начать";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    cell_id(i, j).ReadOnly = false;
                    cell_id(i, j).Text = "";
                    cell_value_change(i, j, false);
                }
            }
            game_over(sender, e);
        }

        private void Word_verification_button_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (word_verification(Word_verification_textbox.Text)) MessageBox.Show("Слово есть в словаре");
            else MessageBox.Show("Такого слова нет в словаре");
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)//удалить слово
        {
            Find_word.Text = "";
            prev_i.Clear();
            prev_j.Clear();
            prev_i.Add(-1);
            prev_j.Add(-1);
        }

        private void button2_Click(object sender, EventArgs e)//удалить букву
        {
            cell_value_change(i_current, j_current, false);
            cell_id(i_current, j_current).ReadOnly = false;
            cell_id(i_current, j_current).Text = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (cell_value(i, j) == true)
                        write_only(i, j);
                }
            }
            prev_i.Clear();
            prev_j.Clear();
            prev_i.Add(-1);
            prev_j.Add(-1);
        }

        private void find_coordinates(TextBox a) 
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (cell_id(i, j).Name.ToString() == a.Name)
                    {
                        cell_i = i;
                        cell_j = j;
                    }
                }
            }
        }

        private void cell_sborka(object sender, EventArgs e)//Сборка слова
        {
            if ((sender as TextBox).ReadOnly == true && flag_sborka == true)
            {
                find_coordinates(sender as TextBox);
                if (prev_i[0] != -1 && prev_j[0] != -1 && (sender as TextBox).Text != "")
                {
                    isEqual = true;
                    for (int i = 0; i < prev_i.Count; i++)
                    {
                        if (prev_i[i] == cell_i && prev_j[i] == cell_j)
                        {
                            isEqual = false;
                            break;
                        }
                    }
                    if (((Math.Abs(cell_i - prev_i.Last()) + Math.Abs(cell_j - prev_j.Last())) < 2) && isEqual) 
                    {
                        prev_i.Add(cell_i);
                        prev_j.Add(cell_j);
                        Find_word.Text += (sender as TextBox).Text;
                    }
                    else MessageBox.Show("YOU COULD NOT CHOOSE NOT NEIGHBOR CELL");
                }
                else {
                    prev_i[0] = cell_i; 
                    prev_j[0] = cell_j; 
                    Find_word.Text += (sender as TextBox).Text;
                }
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch((sender as TextBox).Text, "^[А-Я]") || (sender as TextBox).Text == "Ё")
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        cell_id(i, j).ReadOnly = true;
                        if (cell_id(i, j).Text != "" && cell_value(i, j) == false) {
                            i_current = i;
                            j_current = j;
                            cell_value_change(i, j, true);
                        }                        
                    }
                }                
                flag_sborka = true;
                Find_word.Text = "";
                Start_button.Focus();
            }
            if(!System.Text.RegularExpressions.Regex.IsMatch((sender as TextBox).Text, "^[А-Я]") && (sender as TextBox).Text != "Ё" && (sender as TextBox).Text != "")
            {
                MessageBox.Show("Используйте только буквы русского алфавита", "Ошибка");
                (sender as TextBox).Clear();
            }                     
        }

        private void game_over(object sender, EventArgs e) 
        { 
            timer1.Stop();
            Start_button.Text = "Начать";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    cell_id(i, j).ReadOnly = false;
                    cell_id(i, j).Text = "";
                    cell_value_change(i, j, false);
                }
            }
            BALDA_Load(sender, e);          
        }
    }
}