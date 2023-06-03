// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography.X509Certificates;

static class Program
{
    static void Main(string[] args)
    {
        var store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
        store.Open(OpenFlags.ReadOnly);

        var certificate = store.Certificates.Find(X509FindType.FindByThumbprint, "E18130CEA3DB66C9D14F45C2B99EDABC2ACA8872", false).First();
        var exp = certificate.Export(X509ContentType.Pfx, "iOBBS9WR6eFxFrMf");
        var base64 = Convert.ToBase64String(exp);
        store.Close();

        Console.WriteLine(base64);
    }
}
