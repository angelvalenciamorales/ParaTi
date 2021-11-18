using System;
using System.Windows.Forms;

namespace juegoGato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //private void txtDat1_TextChanged(object sender, EventArgs e)
        //{

        //    if (txtDat1.Text == "0" || txtDat1.Text == "X" || txtDat1.Text == "x")
        //    {
        //        checarGato();
        //    }
        //    else
        //    {
        //        if (txtDat1.Text != "")
        //            MessageBox.Show("Error: Debe poner un (0) o una (x)");
        //        txtDat1.Text = "";

        //    }

        //}

        //private void txtDat2_TextChanged(object sender, EventArgs e)
        //{

        //    if (txtDat2.Text == "0" || txtDat2.Text == "X" || txtDat2.Text == "x")
        //    {
        //        checarGato();
        //    }
        //    else
        //    {
        //        if (txtDat2.Text != "")
        //            MessageBox.Show("Error: Debe poner un (0) o una (x)");
        //        txtDat2.Text = "";

        //    }
        //}

        //private void txtDat3_TextChanged(object sender, EventArgs e)
        //{

        //    if (txtDat3.Text == "0" || txtDat3.Text == "X" || txtDat3.Text == "x")
        //    {
        //        checarGato();
        //    }
        //    else
        //    {
        //        if (txtDat3.Text != "")
        //            MessageBox.Show("Error: Debe poner un (0) o una (x)");
        //        txtDat3.Text = "";

        //    }
        //}

        //private void txtDat4_TextChanged(object sender, EventArgs e)
        //{

        //    if (txtDat4.Text == "0" || txtDat4.Text == "X" || txtDat4.Text == "x")
        //    {
        //        checarGato();
        //    }
        //    else
        //    {
        //        if (txtDat4.Text != "")
        //            MessageBox.Show("Error: Debe poner un (0) o una (x)");
        //        txtDat4.Text = "";

        //    }
        //}

        //private void txtDat5_TextChanged(object sender, EventArgs e)
        //{

        //    if (txtDat5.Text == "0" || txtDat5.Text == "X" || txtDat5.Text == "x")
        //    {
        //        checarGato();
        //    }
        //    else
        //    {
        //        if (txtDat5.Text != "")
        //            MessageBox.Show("Error: Debe poner un (0) o una (x)");
        //        txtDat5.Text = "";

        //    }
        //}

        //private void txtDat6_TextChanged(object sender, EventArgs e)
        //{

        //    if (txtDat6.Text == "0" || txtDat6.Text == "X" || txtDat6.Text == "x")
        //    {
        //        checarGato();
        //    }
        //    else
        //    {
        //        if (txtDat6.Text != "")
        //            MessageBox.Show("Error: Debe poner un (0) o una (x)");
        //        txtDat6.Text = "";

        //    }
        //}

        //private void txtDat7_TextChanged(object sender, EventArgs e)
        //{

        //    if (txtDat7.Text == "0" || txtDat7.Text == "X" || txtDat7.Text == "x")
        //    {
        //        checarGato();
        //    }
        //    else
        //    {
        //        if (txtDat7.Text != "")
        //            MessageBox.Show("Error: Debe poner un (0) o una (x)");
        //        txtDat7.Text = "";

        //    }
        //}

        //private void txtDat8_TextChanged(object sender, EventArgs e)
        //{

        //    if (txtDat8.Text == "0" || txtDat8.Text == "X" || txtDat8.Text == "x")
        //    {
        //        checarGato();
        //    }
        //    else
        //    {
        //        if (txtDat8.Text != "")
        //            MessageBox.Show("Error: Debe poner un (0) o una (x)");
        //        txtDat8.Text = "";

        //    }
        //}

        //private void txtDat9_TextChanged(object sender, EventArgs e)
        //{

        //    if (txtDat9.Text == "0" || txtDat9.Text == "X" || txtDat9.Text == "x")
        //    {
        //        checarGato();
        //    }
        //    else
        //    {
        //        if (txtDat9.Text != "")
        //            MessageBox.Show("Error: Debe poner un (0) o una (x)");
        //        txtDat9.Text = "";

        //    }
        //}
        private void checarGato()
        {
            //optimizacion de  codigo...


            if (txtDat1.Text == "0" && txtDat2.Text == "0" && txtDat3.Text == "0" ||
               txtDat1.Text == "x" && txtDat2.Text == "x" && txtDat3.Text == "x" ||
               txtDat1.Text == "X" && txtDat2.Text == "X" && txtDat3.Text == "X")
            {
                if (txtDat1.Text == "0") MessageBox.Show("el ganador es (0)  ");
                if (txtDat1.Text == "x") MessageBox.Show("el ganador es (x)  ");
                if (txtDat1.Text == "X") MessageBox.Show("El ganador es (X)  ");
            }
            if (txtDat4.Text == "0" && txtDat5.Text == "0" && txtDat6.Text == "0" ||
              txtDat4.Text == "x" && txtDat5.Text == "x" && txtDat6.Text == "x" ||
              txtDat4.Text == "X" && txtDat5.Text == "X" && txtDat6.Text == "X")
            {
                if (txtDat4.Text == "0") MessageBox.Show  ("el ganador es (0)  ");
                if (txtDat4.Text == "x") MessageBox.Show ("el ganador es (x)  ");
                if (txtDat4.Text == "X") MessageBox.Show("El ganador es (X)  ");
            }

            if (txtDat7.Text == "0" && txtDat8.Text == "0" && txtDat9.Text == "0" ||
                txtDat7.Text == "x" && txtDat8.Text == "x" && txtDat9.Text == "x" ||
                txtDat7.Text == "X" && txtDat8.Text == "X" && txtDat9.Text == "X")
            {
                if (txtDat7.Text == "0") MessageBox.Show("el ganador es (0)  ");
                if (txtDat7.Text == "x") MessageBox.Show("el ganador es (x)  ");
                if (txtDat7.Text == "X") MessageBox.Show("El ganador es (X)  ");
            }

            if (txtDat1.Text == "0" && txtDat4.Text == "0" && txtDat7.Text == "0" ||
                  txtDat1.Text == "x" && txtDat4.Text == "x" && txtDat7.Text == "x"||
                  txtDat1.Text == "X" && txtDat4.Text == "X" && txtDat7.Text == "X")
            {
                if (txtDat4.Text == "0") MessageBox.Show("el ganador es (0)  ");
                if (txtDat4.Text == "x") MessageBox.Show("el ganador es (x)  ");
                if (txtDat4.Text == "X") MessageBox.Show("El ganador es (X)  ");
            }
            if (txtDat2.Text == "0" && txtDat5.Text == "0" && txtDat8.Text == "0" ||
                 txtDat2.Text == "x" && txtDat5.Text == "x" && txtDat8.Text == "x" ||
                 txtDat2.Text == "X" && txtDat5.Text == "X" && txtDat8.Text == "X")
            {
                if (txtDat2.Text == "0") MessageBox.Show("el ganador es (0)  ");
                if (txtDat2.Text == "x") MessageBox.Show("el ganador es (x)  ");
                if (txtDat2.Text == "X") MessageBox.Show("El ganador es (X)  ");
            }
            if (txtDat3.Text == "0" && txtDat6.Text == "0" && txtDat9.Text == "0" ||
                 txtDat3.Text == "x" && txtDat6.Text == "x" && txtDat9.Text == "x" ||
                 txtDat3.Text == "X" && txtDat6.Text == "X" && txtDat9.Text == "X")
            {
                if (txtDat3.Text == "0") MessageBox.Show("el ganador es (0)  ");
                if (txtDat3.Text == "x") MessageBox.Show("el ganador es (x)  ");
                if (txtDat3.Text == "X") MessageBox.Show("El ganador es (X)  ");
            }
            if (txtDat3.Text == "0" && txtDat5.Text == "0" && txtDat7.Text == "0" ||
                txtDat3.Text == "x" && txtDat5.Text == "x" && txtDat7.Text == "x" ||
                txtDat3.Text == "X" && txtDat5.Text == "X" && txtDat7.Text == "X")
            {
                if (txtDat3.Text == "0") MessageBox.Show("el ganador es (0)  ");
                if (txtDat3.Text == "x") MessageBox.Show("el ganador es (x)  ");
                if (txtDat3.Text == "X") MessageBox.Show("El ganador es (X)  ");
            }
            if (txtDat1.Text == "0" && txtDat5.Text == "0" && txtDat9.Text == "0" ||
              txtDat1.Text == "x" && txtDat5.Text == "x" && txtDat9.Text == "x" ||
              txtDat1.Text == "X" && txtDat5.Text == "X" && txtDat9.Text == "X")
            {
                if (txtDat1.Text == "0") MessageBox.Show("el ganador es (0)  ");
                if (txtDat1.Text == "x") MessageBox.Show("el ganador es (x)  ");
                if (txtDat1.Text == "X") MessageBox.Show("El ganador es (X)  ");
            }



        }


        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtDat1.Text = "";
            txtDat2.Text = "";
            txtDat3.Text = "";
            txtDat4.Text = "";
            txtDat5.Text = "";
            txtDat6.Text = "";
            txtDat7.Text = "";
            txtDat8.Text = "";
            txtDat9.Text = "";
            lblFinal.Text = "";
        }

        private void txtDat1_TextChanged(object sender, EventArgs e)
        {
            if (txtDat1.Text == "0" || txtDat1.Text == "X" || txtDat1.Text == "x")
            {
                checarGato();
            }
            else
            {
                if (txtDat1.Text != "")
                    MessageBox.Show("Error: Debe poner un (0) o una (x)");
                txtDat1.Text = "";

            }
        }

        private void txtDat2_TextChanged(object sender, EventArgs e)
        {
            if (txtDat2.Text == "0" || txtDat2.Text == "X" || txtDat2.Text == "x")
            {
                checarGato();
            }
            else
            {
                if (txtDat2.Text != "")
                    MessageBox.Show("Error: Debe poner un (0) o una (x)");
                txtDat2.Text = "";

            }
        }

        private void txtDat3_TextChanged(object sender, EventArgs e)
        {
            if (txtDat3.Text == "0" || txtDat3.Text == "X" || txtDat3.Text == "x")
            {
                checarGato();
            }
            else
            {
                if (txtDat3.Text != "")
                    MessageBox.Show("Error: Debe poner un (0) o una (x)");
                txtDat3.Text = "";

            }
        }

        private void txtDat4_TextChanged(object sender, EventArgs e)
        {
            if (txtDat4.Text == "0" || txtDat4.Text == "X" || txtDat4.Text == "x")
            {
                checarGato();
            }
            else
            {
                if (txtDat4.Text != "")
                    MessageBox.Show("Error: Debe poner un (0) o una (x)");
                txtDat4.Text = "";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (txtDat5.Text == "0" || txtDat5.Text == "X" || txtDat5.Text == "x")
            {
                checarGato();
            }
            else
            {
                if (txtDat5.Text != "")
                    MessageBox.Show("Error: Debe poner un (0) o una (x)");
                txtDat5.Text = "";

            }
        }

        private void txtDat6_TextChanged(object sender, EventArgs e)
        {
            if (txtDat6.Text == "0" || txtDat6.Text == "X" || txtDat6.Text == "x")
            {
                checarGato();
            }
            else
            {
                if (txtDat6.Text != "")
                    MessageBox.Show("Error: Debe poner un (0) o una (x)");
                txtDat6.Text = "";

            }
        }

        private void txtDat7_TextChanged(object sender, EventArgs e)
        {

            if (txtDat7.Text == "0" || txtDat7.Text == "X" || txtDat7.Text == "x")
            {
                checarGato();
            }
            else
            {
                if (txtDat7.Text != "")
                    MessageBox.Show("Error: Debe poner un (0) o una (x)");
                txtDat7.Text = "";

            }
        }

        private void txtDat8_TextChanged(object sender, EventArgs e)
        {
            if (txtDat8.Text == "0" || txtDat8.Text == "X" || txtDat8.Text == "x")
            {
                checarGato();
            }
            else
            {
                if (txtDat8.Text != "")
                    MessageBox.Show("Error: Debe poner un (0) o una (x)");
                txtDat8.Text = "";

            }
        }

        private void txtDat9_TextChanged(object sender, EventArgs e)
        {
            if (txtDat9.Text == "0" || txtDat9.Text == "X" || txtDat9.Text == "x")
            {
                checarGato();
            }
            else
            {
                if (txtDat9.Text != "")
                    MessageBox.Show("Error: Debe poner un (0) o una (x)");
                txtDat9.Text = "";

            }
        }
    }
}
