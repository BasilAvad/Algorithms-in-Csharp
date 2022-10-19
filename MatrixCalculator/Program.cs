using System;

namespace MatrixCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] x = Matrix.CreatMatrix(2, 2, 0, 10);
            //int[,] y = Matrix.DiagonalMatrix(5, 5, 0, 90);
            //int[,] T = Matrix.ReshapeMatrix(x, 1, 4);
            //int[,] z = Matrix.CreateAnUpperTriangularMatrix(9, 9, 1, 100);
            //int[,] z2 = Matrix.CreateAnLowerTriangularMatrix(9, 9, 1, 100);
            //Console.WriteLine("{0}",Matrix.UpperTriangularMatrixControl(z)?"Ust ucgen matris": "Ust ucgen matris degil");
            //Console.WriteLine("{0}",Matrix.LowerTriangularMatrixControl(z2)?"Alt ucgen matris": "Alt ucgen matris degil");

            //Console.WriteLine();
            Matrix.PrintMatrix(x);
           
            
            double a1 = 0.0; double alfa1 = 0; double d1 = 0.0; double theta1 = 60;
            double a2 = 0.0; double alfa2 = 0.0; double d2 = 0; double theta2 = 60;
            double a3 = 0.0; double alfa3 = 0.0; double d3 = 0.0; double theta3 = 0.0;
            double a4 = 0.0; double alfa4 = 0.0; double d4 = 0.0; double theta4 = 0.0;
            double a5 = 0.0; double alfa5 = 0.0; double d5 = 0.0; double theta5 = 0.0;
            double a6 = 0.0; double alfa6 = 0.0; double d6 = 0.0; double theta6 = 0.0;

            double [,] T_1 = { {Math.Round( Math.Cos((theta1 * (Math.PI)) / 180),3),Math.Round( -Math.Sin((theta1 * (Math.PI)) / 180),3),0,Math.Round( a1,3) }, {Math.Round( Math.Sin((theta1 * (Math.PI)) / 180) * Math.Cos((alfa1 * (Math.PI)) / 180),3),Math.Round( Math.Cos((theta1 * (Math.PI)) / 180)* Math.Cos((alfa1 * (Math.PI)) / 180),3),Math.Round( -Math.Sin((alfa1 * (Math.PI)) / 180),3),Math.Round( -Math.Sin((alfa1 * (Math.PI)) / 180)*d1,3) }
                ,{Math.Round( Math.Sin((theta1 * (Math.PI)) / 180) * Math.Sin((alfa1 * (Math.PI)) / 180),3),Math.Round( Math.Cos((theta1 * (Math.PI)) / 180)* Math.Sin((alfa1 * (Math.PI)) / 180),3),Math.Round( Math.Cos((alfa1 * (Math.PI)) / 180),3),Math.Round( Math.Cos((alfa1 * (Math.PI)) / 180)*d1,3) }
                ,{0,0,0,1 } };
             double [,] T_2 = { {Math.Round( Math.Cos((theta2 * (Math.PI)) / 180),3),Math.Round( -Math.Sin((theta2 * (Math.PI)) / 180),3),0,Math.Round( a2,3) }, {Math.Round( Math.Sin((theta2 * (Math.PI)) / 180) * Math.Cos((alfa2 * (Math.PI)) / 180),3),Math.Round( Math.Cos((theta2 * (Math.PI)) / 180)* Math.Cos((alfa2 * (Math.PI)) / 180),3),Math.Round( -Math.Sin((alfa2 * (Math.PI)) / 180),3),Math.Round( -Math.Sin((alfa2 * (Math.PI)) / 180)*d2,3) }
                ,{Math.Round( Math.Sin((theta2 * (Math.PI)) / 180) * Math.Sin((alfa2 * (Math.PI)) / 180),3),Math.Round( Math.Cos((theta2 * (Math.PI)) / 180)* Math.Sin((alfa2 * (Math.PI)) / 180),3),Math.Round( Math.Cos((alfa2 * (Math.PI)) / 180),3),Math.Round( Math.Cos((alfa2 * (Math.PI)) / 180)*d2,3) }
                ,{0,0,0,1 } };
            double [,] T_3 = { {Math.Round( Math.Cos((theta3 * (Math.PI)) / 180),3),Math.Round( -Math.Sin((theta3 * (Math.PI)) / 180),3),0,Math.Round( a3,3) }, {Math.Round( Math.Sin((theta3 * (Math.PI)) / 180) * Math.Cos((alfa3 * (Math.PI)) / 180),3),Math.Round( Math.Cos((theta3 * (Math.PI)) / 180)* Math.Cos((alfa3 * (Math.PI)) / 180),3),Math.Round( -Math.Sin((alfa3 * (Math.PI)) / 180),3),Math.Round( -Math.Sin((alfa3 * (Math.PI)) / 180)*d3,3) }
                ,{Math.Round( Math.Sin((theta3 * (Math.PI)) / 180) * Math.Sin((alfa3 * (Math.PI)) / 180),3),Math.Round( Math.Cos((theta3 * (Math.PI)) / 180)* Math.Sin((alfa3 * (Math.PI)) / 180),3),Math.Round( Math.Cos((alfa3 * (Math.PI)) / 180),3),Math.Round( Math.Cos((alfa3 * (Math.PI)) / 180)*d3,3) }
                ,{0,0,0,1 } };
            double [,] T_4 = { {Math.Round( Math.Cos((theta4 * (Math.PI)) / 180),3),Math.Round( -Math.Sin((theta4 * (Math.PI)) / 180),3),0,Math.Round( a4,3) }, {Math.Round( Math.Sin((theta4 * (Math.PI)) / 180) * Math.Cos((alfa4 * (Math.PI)) / 180),3),Math.Round( Math.Cos((theta4 * (Math.PI)) / 180)* Math.Cos((alfa4 * (Math.PI)) / 180),3),Math.Round( -Math.Sin((alfa4 * (Math.PI)) / 180),3),Math.Round( -Math.Sin((alfa4 * (Math.PI)) / 180)*d4,3) }
                ,{Math.Round( Math.Sin((theta4 * (Math.PI)) / 180) * Math.Sin((alfa4 * (Math.PI)) / 180),3),Math.Round( Math.Cos((theta4 * (Math.PI)) / 180)* Math.Sin((alfa4 * (Math.PI)) / 180),3),Math.Round( Math.Cos((alfa4 * (Math.PI)) / 180),3),Math.Round( Math.Cos((alfa4 * (Math.PI)) / 180)*d4,3) }
                ,{0,0,0,1 } };
            double [,] T_5 = { {Math.Round( Math.Cos((theta5 * (Math.PI)) / 180),3),Math.Round( -Math.Sin((theta5 * (Math.PI)) / 180),3),0,Math.Round( a5,3) }, {Math.Round( Math.Sin((theta5 * (Math.PI)) / 180) * Math.Cos((alfa5 * (Math.PI)) / 180),3),Math.Round( Math.Cos((theta5 * (Math.PI)) / 180)* Math.Cos((alfa5 * (Math.PI)) / 180),3),Math.Round( -Math.Sin((alfa5 * (Math.PI)) / 180),3),Math.Round( -Math.Sin((alfa5 * (Math.PI)) / 180)*d5,3) }
                ,{Math.Round( Math.Sin((theta5 * (Math.PI)) / 180) * Math.Sin((alfa5 * (Math.PI)) / 180),3),Math.Round( Math.Cos((theta5 * (Math.PI)) / 180)* Math.Sin((alfa5 * (Math.PI)) / 180),3),Math.Round( Math.Cos((alfa5 * (Math.PI)) / 180),3),Math.Round( Math.Cos((alfa5 * (Math.PI)) / 180)*d5,3) }
                ,{0,0,0,1 } };
             double [,] T_6 = { {Math.Round( Math.Cos((theta6 * (Math.PI)) / 180),3),Math.Round( -Math.Sin((theta6 * (Math.PI)) / 180),3),0,Math.Round( a6,3) }, {Math.Round( Math.Sin((theta6 * (Math.PI)) / 180) * Math.Cos((alfa6 * (Math.PI)) / 180),3),Math.Round( Math.Cos((theta6 * (Math.PI)) / 180)* Math.Cos((alfa6 * (Math.PI)) / 180),3),Math.Round( -Math.Sin((alfa6 * (Math.PI)) / 180),3),Math.Round( -Math.Sin((alfa6 * (Math.PI)) / 180)*d6,3) }
                ,{Math.Round( Math.Sin((theta6 * (Math.PI)) / 180) * Math.Sin((alfa6 * (Math.PI)) / 180),3),Math.Round( Math.Cos((theta6 * (Math.PI)) / 180)* Math.Sin((alfa6 * (Math.PI)) / 180),3),Math.Round( Math.Cos((alfa6 * (Math.PI)) / 180),3),Math.Round( Math.Cos((alfa6 * (Math.PI)) / 180)*d6,3) }
                ,{0,0,0,1 } };

            //int[,] A = { { 1, 0, 2 }, { -1, 3, 1 } };
            //int[,] B = { { 3, 1, 2 }, { 2, 1, 3 }, { 1, 0, 5 } };
            double[,] C = new double[T_1.GetUpperBound(0) + 1, T_2.GetUpperBound(1) + 1];
            
            // A nın satır sayısı kadar
            for (int i = 0; i <= T_1.GetUpperBound(0); i++)
            {
                // B nin sütun sayısı kadar
                for (int j = 0; j <= T_2.GetUpperBound(1); j++)
                {
                    double toplam = 0;
                    // A nın sütun sayısı kadar
                    // (ya da B nin satır sayısı)
                    for (int k = 0; k <= T_1.GetUpperBound(1); k++)
                    {
                        toplam += T_1[ i, k] * T_2[k, j];
                    }
                    C[i, j] = toplam;
                }
            }
            double[,] D = new double[T_1.GetUpperBound(0) + 1, T_2.GetUpperBound(1) + 1];
            // A nın satır sayısı kadar
            for (int i = 0; i <= C.GetUpperBound(0); i++)
            {
                // B nin sütun sayısı kadar
                for (int j = 0; j <= T_3.GetUpperBound(1); j++)
                {
                    double toplam = 0;
                    // A nın sütun sayısı kadar
                    // (ya da B nin satır sayısı)
                    for (int k = 0; k <= C.GetUpperBound(1); k++)
                    {
                        toplam += C[ i, k] * T_3[k, j];
                    }
                    D[i, j] = toplam;
                }
            }


            Matrix.PrintMatrix(D);
            //Matrix.PrintMatrix(x);
            //Console.WriteLine(" Elemanların toplamı ={0}", Matrix.MatrixElementSum(x));
            //int[,] D = Matrix.ScalerMulti(2, x);
            //Console.WriteLine();
            //Matrix.PrintMatrix(D);
            //Console.WriteLine("Matrisin determinantı = {0}", Matrix.MatrixDeterminant2(x));
            Console.WriteLine("*********");
            //Matrix.PrintMatrix(y);
            //Console.WriteLine("-----------------");
            //Matrix.PrintMatrix(y);
            //Console.WriteLine("{0}", Matrix.SymmetricControl(y) ? "Simetrik" : "Simetrik değil");
            //Console.WriteLine("{0}", Matrix.DiagonalMatrixControl(y) ? "kosegen matris" : "kosegen matris değil");
            //Console.WriteLine("{0}", Matrix.MatrixComparison(x, y) ? "Eşit" : "Esit Degil");
            ////Console.WriteLine("*********");
            //Matrix.PrintMatrix(z);
            //Console.WriteLine("-------------");
            //Matrix.PrintMatrix(Matrix.ScalarMatrix(4, 4, 1, 9));

            //Console.WriteLine("{0}", Matrix.SquareMatrixControl(x)?"Kare Matris":"Kare Matris degil");
            //int[] D = Matrix.DiagonalNumList(x);
            //Matrix.PrintMatrix2(D);
            //Console.WriteLine("Matrisin izi {0}",Matrix.MatrixTraceCalculator(x));
            //Console.WriteLine("{0}", Matrix.OneMatrixControl(x)?"Birim Matris":"Birim Matris degil");
            Console.ReadLine();
        }
    }
}
