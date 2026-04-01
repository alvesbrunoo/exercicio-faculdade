private void btnVerificar_Click(object sender, EventArgs e)
{
    int numero = int.Parse(txtNumero.Text);

    if (numero >= 10 && numero <= 50)
    {
        MessageBox.Show("Está entre 10 e 50");
    }
    else
    {
        MessageBox.Show("Não está entre 10 e 50");
    }
}