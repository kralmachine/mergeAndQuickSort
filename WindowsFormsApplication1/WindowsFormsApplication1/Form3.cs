using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        #region tanimlama
        ///////////////////////////////
        int counter = 0;
        int[] A;
        int sayininSayisi = 0;
        Random rnd = new Random();
        StringBuilder sb = new StringBuilder();
        Stopwatch time = new Stopwatch();
        DialogResult algoritmaSec;
        //////////////////////////////
        #endregion
        private void verileriDoldur(int gelenSayi)
        {
            sb.Clear();
            if (sayininSayisi == 10)
            {
                sb.AppendLine("DİZİNİN SIRALANMAMIŞ HALİ");
                sb.AppendLine("---------------------------");
            }

            for (int i = 0; i < gelenSayi; i++)
            {
                A[i] = rnd.Next(0, 10000);
                if (sayininSayisi == 10)
                    sb.AppendLine(A[i].ToString() + "");
            }
        }

        private int quickSort(int[] A, int p, int r,int counter)
        {
            int q;
            counter++;
            if (p < r)
            {
                counter++;
                q = partition(A, p, r, ref counter);
                counter++;
                quickSort(A, p, q - 1, counter);
                counter++;
                this.counter=quickSort(A, q + 1, r, counter);
                counter++;
            }
            else
                counter++;
            return counter;
        }
        private  int partition(int[] A, int p, int r,ref int counter)
        {
            int tmp;
            counter++;
            int x = A[r];
            counter++;
            int i = p - 1;
            counter++;
            for (int j = p; j <= r - 1;counter++,j++)
            {
                counter++;
                if (A[j] <= x)
                {
                    counter++;
                    i++;
                    counter++;
                    tmp = A[i];
                    counter++;
                    A[i] = A[j];
                    counter++;
                    A[j] = tmp;
                    counter++;
                }
                else
                    counter++;
            }
            tmp = A[i + 1];
            counter++;
            A[i + 1] = A[r];
            counter++;
            A[r] = tmp;
            counter++;
            return i + 1;
          
        }

        private int sort(int[] arr, int l, int r,int counter)
        {
            if (l < r)
            {
                counter++;
                int m = (l + r) / 2;
                counter++;
                sort(arr, l, m,counter);
                counter++;
                this.counter=sort(arr, m + 1, r,counter);
                counter++;
                merge(arr, l, m, r,ref counter);
                counter++;
            }
            else
                counter++;
            return counter;

        }
        private void merge(int[] arr, int l, int m, int r,ref int counter)
        {
            int n1 = m - l + 1;
            counter++;
            int n2 = r - m;
            counter++;
            int[] L = new int[n1];
            counter++;
            int[] R = new int[n2];
            counter++;
            for (int h = 0; h < n1; counter++, ++h)
            {
                counter++;
                L[h] = arr[l + h];
                counter++;
            }
            for (int g = 0; g < n2; counter++, ++g)
            {
                counter++;
                R[g] = arr[m + 1 + g];
                counter++;
            }
            int i = 0;
            counter++;
            int j = 0;
            counter++;

            int k = l;
            counter++;
            while (i < n1 && j < n2)
            {
                counter++;
                if (L[i] <= R[j])
                {
                    counter++;
                    arr[k] = L[i];
                    counter++;
                    i++;
                    counter++;
                }
                else if(L[i]>=R[j])
                {
                    counter++;
                    arr[k] = R[j];
                    counter++;
                    j++;
                    counter++;
                }
                k++;
                counter++;
            }

            while (i < n1)
            {
                counter++;
                arr[k] = L[i];
                counter++;
                i++;
                counter++;
                k++;
                counter++;
            }

            while (j < n2)
            {
                counter++;
                arr[k] = R[j];
                counter++;
                j++;
                counter++;
                k++;
                counter++;
            }
        }


        private void btnDiziSiralama_Click(object sender, EventArgs e)
        {
            algoritmaSec = MessageBox.Show("MERGE SORT SEÇMEK İÇİN EVET QUICK SORT SEÇMEK İÇİN HAYIR SEÇİNİZ.", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            algoritmalar(algoritmaSec);
        }
        private void algoritmalar(DialogResult algoSonuc)
        {
            if (algoSonuc == DialogResult.Yes)
            {
                time.Reset();
                
                //A[10] durumu
                A = new int[10];
                sayininSayisi = 10;
                verileriDoldur(sayininSayisi);
                sb.AppendLine("\nDİZİNİN SIRALANMIŞ HALİ");
                sb.AppendLine("---------------------------");
                /////////////////////////
                time.Start();
                sort(A, 0, A.Length - 1,counter);
                //////////////////////////
                time.Stop();
                MessageBox.Show((time.Elapsed) + " " + "mikrosaniyede işlem yapmıştır." + " Counter Değeri :" + counter, "MERGE SORT");
                for (int i = 0; i < 10; i++)
                    sb.AppendLine(A[i].ToString());
                MessageBox.Show(sb.ToString(), "MERGE SORT");
            }
            else
            {
                time.Reset();
                
                //A[10] durumu
                A = new int[10];
                sayininSayisi = 10;
                verileriDoldur(sayininSayisi);
                sb.AppendLine("\nDİZİNİN SIRALANMIŞ HALİ");
                sb.AppendLine("---------------------------");
                /////////////////////////
                time.Start();
                quickSort(A, 0, A.Length - 1,counter);
                //////////////////////////
                time.Stop();
                MessageBox.Show((time.Elapsed) + " " + "mikrosaniyede işlem yapmıştır." + " Counter Değeri :" + counter, "QUICK SORT");
                for (int i = 0; i < 10; i++)
                    sb.AppendLine(A[i].ToString());
                MessageBox.Show(sb.ToString(), "QUICK SORT");
            }

            counter = 0;
            sayininSayisi = 0;
        }
        private void btnDizi10_Click(object sender, EventArgs e)
        {
            //A[10] durumu için counter ve mikrosaniye değeri
            A = new int[10];
            sayininSayisi = 10;
            verileriDoldur(10);
            algoritmaSec = MessageBox.Show("MERGE SORT SEÇMEK İÇİN EVET QUICK SORT SEÇMEK İÇİN HAYIR SEÇİNİZ.", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (algoritmaSec == DialogResult.Yes)
            {
                time.Reset();
                time.Start();
                sort(A, 0, A.Length - 1,counter);
                time.Stop();
                MessageBox.Show((time.Elapsed) + " " + "mikrosaniyede işlem yapmıştır." + " Counter Değeri :" + counter, "MERGE SORT");
            }
            else
            {
                time.Reset();
                time.Start();
                quickSort(A, 0, A.Length - 1,counter);
                time.Stop();
                MessageBox.Show((time.Elapsed) + " " + "mikrosaniyede işlem yapmıştır." + " Counter Değeri :" + counter, "QUICK SORT");
            }
            counter = 0;
            sayininSayisi = 0;

        }
        private void btnDizi100_Click(object sender, EventArgs e)
        {
            //A[100] durumu için counter ve mikrosaniye değeri
            A = new int[100];
            verileriDoldur(100);
            sayininSayisi = 100;
            algoritmaSec = MessageBox.Show("MERGE SORT SEÇMEK İÇİN EVET QUICK SORT SEÇMEK İÇİN HAYIR SEÇİNİZ.", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (algoritmaSec == DialogResult.Yes)
            {
                time.Reset();
                time.Start();
                sort(A, 0, A.Length - 1,counter);
                time.Stop();
                MessageBox.Show((time.Elapsed) + " " + "mikrosaniyede işlem yapmıştır." + " Counter Değeri :" + counter, "MERGE SORT");
            }
            else
            {
                time.Reset();
                time.Start();
                quickSort(A, 0, A.Length - 1,counter);
                time.Stop();
                MessageBox.Show((time.Elapsed) + " " + "mikrosaniyede işlem yapmıştır." + " Counter Değeri :" + counter, "QUICK SORT");
            }
            counter = 0;
            sayininSayisi = 0;
        }
        private void btnDizi1000_Click(object sender, EventArgs e)
        {
            //A[1000] durumu için counter ve mikrosaniye değeri
            A = new int[1000];
            verileriDoldur(1000);
            sayininSayisi = 1000;
            algoritmaSec = MessageBox.Show("MERGE SORT SEÇMEK İÇİN EVET QUICK SORT SEÇMEK İÇİN HAYIR SEÇİNİZ.", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (algoritmaSec == DialogResult.Yes)
            {
                time.Reset();
                time.Start();
                sort(A, 0, A.Length - 1,counter);
                time.Stop();
                MessageBox.Show((time.Elapsed) + " " + "mikrosaniyede işlem yapmıştır." + " Counter Değeri :" + counter, "MERGE SORT");
            }
            else
            {
                time.Reset();
                time.Start();
                quickSort(A, 0, A.Length - 1,counter);
                time.Stop();
                MessageBox.Show((time.Elapsed) + " " + "mikrosaniyede işlem yapmıştır." + " Counter Değeri :" + counter, "QUICK SORT");
            }
            counter = 0;
            sayininSayisi = 0;
        }
        private void btnDizi10000_Click(object sender, EventArgs e)
        {
            //A[10000] durumu için counter ve mikrosaniye değeri
            A = new int[10000];
            verileriDoldur(10000);
            sayininSayisi = 10000;
            algoritmaSec = MessageBox.Show("MERGE SORT SEÇMEK İÇİN EVET QUICK SORT SEÇMEK İÇİN HAYIR SEÇİNİZ.", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (algoritmaSec == DialogResult.Yes)
            {
                time.Reset();
                time.Start();
                sort(A, 0, A.Length - 1,counter);
                time.Stop();
                MessageBox.Show((time.Elapsed) + " " + "mikrosaniyede işlem yapmıştır." + " Counter Değeri :" + counter, "MERGE SORT");
            }
            else
            {
                time.Reset();
                time.Start();
                quickSort(A, 0, A.Length - 1,counter);
                time.Stop();
                MessageBox.Show((time.Elapsed) + " " + "mikrosaniyede işlem yapmıştır." + " Counter Değeri :" + counter, "QUICK SORT");
            }
            counter = 0;
            sayininSayisi = 0;
        }
    }
}
