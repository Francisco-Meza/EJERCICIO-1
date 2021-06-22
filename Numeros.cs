using System;
//------------------------------- CLASE DERIVADA ----------------------------
class Numeros : IDatos
{
    private double ans;
    //-------------------------- ATRIBUTOS ----------------------------------
    private int[] datos;
    //-------------------------- CONSTRUCTOR --------------------------------
    public Numeros(int[] datos)
    {
        Datos = datos;
    }
    //-------------------------- METODOS -------------------------------------
    public double Suma()
    {
        for (int i = 0; i < Datos.Length; i++)
        {
            this.ans += Datos[i];
        }
        return ans;
    }
    public double Promedio()
    {
        this.ans = this.Suma() / Datos.Length;
        return ans;
    }
    public int[] Ordenar()
    {
        Array.Reverse(Datos);
        return Datos;
    }
    //------------------------ PROPIEDADES ----------------------------------
    public int[] Datos { get => datos; set => datos = value; }
}
