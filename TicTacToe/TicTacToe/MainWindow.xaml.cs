using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Yang private ituu
        private MarkType[] aHasil;

        //true kalo giliran player 1 (X)
        private bool aPlayer1;

        //true kalo gamenya selsai
        private bool aSelesai;
        #endregion

        #region MainWindow
        public MainWindow()
        {
            InitializeComponent();

            Mulai(); 
        }
        #endregion

        #region Fungsi Mulai
        private void Mulai()
        {
            aHasil = new MarkType[9];

            for (var i = 0; i < aHasil.Length; i++)
                aHasil[i] = MarkType.Kosong;

            aPlayer1 = true;

            Kotak.Children.Cast<Button>().ToList().ForEach(button =>
            {
                button.Content = string.Empty;
                button.Background = Brushes.White;
            });

            aSelesai = false;
        }
        #endregion

        /// <summary>
        /// kalo ngeklik tombol
        /// </summary>
        /// <param name="sender">kalo diklik</param>
        /// <param name="e">apa yang terjadi</param>
        private void tombol_Click(object sender, RoutedEventArgs e)
        {
            //Buat kalo mau main lagi
            if (aSelesai)
            {
                Mulai();
                return;
            }

            var button = (Button)sender;

            //Nentuin posisi kotak di array
            var kolom = Grid.GetColumn(button);
            var baris = Grid.GetRow(button);
            var index = kolom + (baris * 3);

            //Kalo kotak udah keisi jangan ngapangapain
            if (aHasil[index] != MarkType.Kosong)
                return;

            //Nentuin value dari kotaknya
            if (aPlayer1)
                aHasil[index] = MarkType.Silang;
            else
                aHasil[index] = MarkType.Nol;
            
            //Nentuin content dari kotaknya
            if (aPlayer1)
                button.Content = "X";
            else
                button.Content = "O";

            //Buat gantian pemain
            aPlayer1 ^= true;

            //Buat ngecek ada yang menang
            cekPemenang();
        }

        private void cekPemenang()
        {
            //menang horizontal
            if (aHasil[0] != MarkType.Kosong && (aHasil[0] & aHasil[1] & aHasil[2]) == aHasil[0])
            {
                aSelesai = true;

                //Ganti warna backgrond
                tombol0_0.Background = tombol1_0.Background = tombol2_0.Background = Brushes.Yellow;
                MessageBox.Show("Yey! Click anywhere to play again.", "Alert!");
            }
            else if (aHasil[3] != MarkType.Kosong && (aHasil[3] & aHasil[4] & aHasil[5]) == aHasil[3])
            {
                aSelesai = true;
                tombol0_1.Background = tombol1_1.Background = tombol2_1.Background = Brushes.Yellow;
                MessageBox.Show("Yey! Click anywhere to play again", "Alert!");
            }
            else if (aHasil[6] != MarkType.Kosong && (aHasil[6] & aHasil[7] & aHasil[8]) == aHasil[6])
            {
                aSelesai = true;
                tombol0_2.Background = tombol1_2.Background = tombol2_2.Background = Brushes.Yellow;
                MessageBox.Show("Yey! Click anywhere to play again", "Alert!");
            }
            //menang vertikal
            else if (aHasil[0] != MarkType.Kosong && (aHasil[0] & aHasil[3] & aHasil[6]) == aHasil[0])
            {
                aSelesai = true;
                tombol0_0.Background = tombol0_1.Background = tombol0_2.Background = Brushes.Yellow;
                MessageBox.Show("Yey! Click anywhere to play again", "Alert!");
            }
            else if (aHasil[1] != MarkType.Kosong && (aHasil[1] & aHasil[4] & aHasil[7]) == aHasil[1])
            {
                aSelesai = true;
                tombol1_0.Background = tombol1_1.Background = tombol1_2.Background = Brushes.Yellow;
                MessageBox.Show("Yey! Click anywhere to play again", "Alert!");
            }
            else if (aHasil[2] != MarkType.Kosong && (aHasil[2] & aHasil[5] & aHasil[8]) == aHasil[2])
            {
                aSelesai = true;
                tombol2_0.Background = tombol2_1.Background = tombol2_2.Background = Brushes.Yellow;
                MessageBox.Show("Yey! Click anywhere to play again", "Alert!");
            }
            //menang diagonal
            else if (aHasil[0] != MarkType.Kosong && (aHasil[0] & aHasil[4] & aHasil[8]) == aHasil[0])
            {
                aSelesai = true;
                tombol0_0.Background = tombol1_1.Background = tombol2_2.Background = Brushes.Yellow;
                MessageBox.Show("Yey! Click anywhere to play again", "Alert!");
            }
            else if (aHasil[2] != MarkType.Kosong && (aHasil[2] & aHasil[4] & aHasil[6]) == aHasil[2])
            {
                aSelesai = true;
                tombol2_0.Background = tombol1_1.Background = tombol0_2.Background = Brushes.Yellow;
                MessageBox.Show("Yey! Click anywhere to play again", "Alert!");
            }
            //kalo seri
            else if (!aHasil.Any(hasil => hasil == MarkType.Kosong))
            {
                aSelesai = true;
                Kotak.Children.Cast<Button>().ToList().ForEach(button =>
                {
                    button.Background = Brushes.DarkOliveGreen;
                });
                MessageBox.Show("Draw! Click anywhere to play again", "Alert!");
            }
        }
    }
}