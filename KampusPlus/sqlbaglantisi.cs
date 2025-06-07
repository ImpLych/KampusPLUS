using System.Data.SqlClient;

internal class sqlbaglantisi
{
    public SqlConnection baglanti()
    {
        SqlConnection baglan = new SqlConnection("Data Source=HASAN\\SQLEXPRESS;Initial Catalog=KampusPlusProje;Integrated Security=True;TrustServerCertificate=True");

        //if (baglan.State == System.Data.ConnectionState.Closed)
        {
            
        }baglan.Open();

        return baglan;
    }
}
